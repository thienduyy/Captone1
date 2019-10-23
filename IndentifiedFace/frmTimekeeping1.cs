using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;
using System.IO;
using IndentifiedFace.Configurations;
using IndentifiedFace.IO;
using System.IO.Ports;

namespace IndentifiedFace
{
    public partial class frmTimekeeping : Form
    {

        private SqlConnection con;
        private DataTable dt = new DataTable("Table0");
        private DataTable dt0 = new DataTable("Table1");
        private DataTable dt1 = new DataTable("Table2");
        private DataTable dt2 = new DataTable("Table3");
        private DataTable dt3 = new DataTable("Table4");
        private DataTable dtGroup = new DataTable("TableClass");
        private SqlDataAdapter da = new SqlDataAdapter();

        Capture grabber;
        Image<Bgr, Byte> currentFrame;
        Image<Gray, Byte> gray;
        HaarCascade haar;
        Image<Gray, Byte> result;
        List<Image<Gray, Byte>> trainingImages = new List<Image<Gray, byte>>();
        int ContTrain;
        List<String> EmployeeID = new List<string>();
        List<String> EmployeeGroupID = new List<string>();
        string name = "", LoadFaces, str;
        MCvFont font = new MCvFont(FONT.CV_FONT_HERSHEY_TRIPLEX, 0.5d, 0.5d);
        List<String> Presence = new List<string>();
        List<String> Absence = new List<string>();
        List<String> Temporary = new List<string>();

        Boolean test = false;
        private SerialPortConn serialPortManager;

        public frmTimekeeping(Configuration appConfig)
        {
            applicationConfiguration = (AppConfig)appConfig;
            InitializeComponent();
            // forceCustomReInitialize();

            /* Initial output device */
            foreach (string s in SerialPort.GetPortNames())
            {
                comboBoxOutputDevice.Items.Add(s);
            }

            connect();
            haar = new HaarCascade("haarcascade_frontalface_default.xml");
            dt.Clear();
            dt0.Clear();
            SqlCommand command = new SqlCommand();
            command.Connection = con;
            command.CommandType = CommandType.Text;
            command.CommandText = "Select * from tblGroup";
            da.SelectCommand = command;
            da.Fill(dtGroup);
            cbGroup.DataSource = dtGroup;
            cbGroup.DisplayMember = "fldGroupName";
            cbGroup.ValueMember = "fldGroupID";
            str = cbGroup.Text;
            command.CommandText = @"SELECT  fldEmployeeID as N'" + applicationConfiguration.getLanguagePackage().getMemberCodeAlias()
                                    + @"',fldFirstName as N'" + applicationConfiguration.getLanguagePackage().getLastNameAlias()
                                    + @"',fldLastName as N'" + applicationConfiguration.getLanguagePackage().getFirstNameAlias()
                                    + @"',
                                            (Case fldSex when 'True' then N'" + applicationConfiguration.getLanguagePackage().getMaleAlias()
                                    + @"' else N'" + applicationConfiguration.getLanguagePackage().getFemaleAlias()
                                    + @"' end) as N'" + applicationConfiguration.getLanguagePackage().getSexAlias()
                                    + @"',
                                             fldBirth as N'" + applicationConfiguration.getLanguagePackage().getBirthAlias()
                                    + @"', fldGroupName as N'" + applicationConfiguration.getLanguagePackage().getClassAlias()
                                    + @"'
                                             FROM   tblGroup INNER JOIN tblEmployee 
                                             ON tblGroup.fldGroupID = tblEmployee.fldGroupID";
            da.SelectCommand = command;
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                grvdata.DataSource = dt;
            }

            try
            {
                foreach (DataRow dr in dt.Rows)
                {
                    EmployeeID.Add(dr.ItemArray[0].ToString());
                }

                ContTrain = EmployeeID.Count();
                for (int i = 1; i <= EmployeeID.Count(); i++)
                {
                    LoadFaces = String.Format("face" + i + ".bmp");
                    trainingImages.Add(new Image<Gray, byte>(Application.StartupPath + "/TrainedFaces/" + LoadFaces));//load ảnh
                }

            }
            catch (Exception)
            {
                MessageBox.Show(applicationConfiguration.getLanguagePackage().getMemberNotFoundMessage(),
                    applicationConfiguration.getLanguagePackage().getMemberNotFoundLabel(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            command.CommandText = @"SELECT  fldEmployeeID as N'" + applicationConfiguration.getLanguagePackage().getMemberCodeAlias()
                                    + @"',fldFirstName as N'" + applicationConfiguration.getLanguagePackage().getLastNameAlias()
                                    + @"',fldLastName as N'" + applicationConfiguration.getLanguagePackage().getFirstNameAlias()
                                    + @"',
                                            (Case fldSex when 'True' then N'" + applicationConfiguration.getLanguagePackage().getMaleAlias()
                                    + @"' else N'" + applicationConfiguration.getLanguagePackage().getFemaleAlias()
                                    + @"' end) as N'" + applicationConfiguration.getLanguagePackage().getSexAlias()
                                    + @"',
                                             fldBirth as N'" + applicationConfiguration.getLanguagePackage().getBirthAlias()
                                    + @"', fldGroupName as N'" + applicationConfiguration.getLanguagePackage().getClassAlias()
                                    + @"',fldImage as 'Hình ảnh'
                                             FROM   tblGroup INNER JOIN tblEmployee 
                                             ON tblGroup.fldGroupID = tblEmployee.fldGroupID
                                                where fldGroupName like @Group";
            command.Parameters.Add("@Group", SqlDbType.NVarChar, 50).Value = str;
            da.SelectCommand = command;
            da.Fill(dt0);
            if (dt0.Rows.Count > 0)
            {
                grvdata.DataSource = dt0;
            }
            try
            {
                foreach (DataRow dr in dt0.Rows)
                {
                    EmployeeGroupID.Add(dr.ItemArray[0].ToString());
                }
            }
            catch (Exception)
            {
            }
            btnCallTheRoll.Enabled = false;
        }
        private AppConfig applicationConfiguration;

        private void connect()
        {
            String cn = applicationConfiguration.getDatabaseConnectionString();
            try
            {
                con = new SqlConnection(cn);
                con.Open();
            }
            catch
            {
                MessageBox.Show(applicationConfiguration.getLanguagePackage().getErrorConnectToDatabaseMessage(),
                    applicationConfiguration.getLanguagePackage().getErrorConnectToDatabaseTitle(),
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void disconnect()
        {
            try
            {
                con.Close();
                con.Dispose();
                con = null;
            }
            catch (Exception e) { }

        }

        public frmTimekeeping()
        {

            InitializeComponent();
            connect();
            haar = new HaarCascade("haarcascade_frontalface_default.xml");
            dt.Clear();
            dt0.Clear();
            SqlCommand command = new SqlCommand();
            command.Connection = con;
            command.CommandType = CommandType.Text;
            command.CommandText = "Select * from tblGroup";
            da.SelectCommand = command;
            da.Fill(dtGroup);
            cbGroup.DataSource = dtGroup;
            cbGroup.DisplayMember = "fldGroupName";
            cbGroup.ValueMember = "fldGroupID";
            str = cbGroup.Text;
            command.CommandText = @"SELECT  fldEmployeeID as N'" + applicationConfiguration.getLanguagePackage().getMemberCodeAlias()
                                    + @"',fldFirstName as N'" + applicationConfiguration.getLanguagePackage().getLastNameAlias()
                                    + @"',fldLastName as N'" + applicationConfiguration.getLanguagePackage().getFirstNameAlias()
                                    + @"',
                                            (Case fldSex when 'True' then N'" + applicationConfiguration.getLanguagePackage().getMaleAlias()
                                    + @"' else N'" + applicationConfiguration.getLanguagePackage().getFemaleAlias()
                                    + @"' end) as N'" + applicationConfiguration.getLanguagePackage().getSexAlias()
                                    + @"',
                                             fldBirth as N'" + applicationConfiguration.getLanguagePackage().getBirthAlias()
                                    + @"', fldGroupName as N'" + applicationConfiguration.getLanguagePackage().getClassAlias()
                                    + @"'
                                             FROM   tblGroup INNER JOIN tblEmployee 
                                             ON tblGroup.fldGroupID = tblEmployee.fldGroupID";
            da.SelectCommand = command;
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                grvdata.DataSource = dt;
            }

            try
            {
                foreach (DataRow dr in dt.Rows)
                {
                    EmployeeID.Add(dr.ItemArray[0].ToString());
                }

                ContTrain = EmployeeID.Count();
                for (int i = 1; i <= EmployeeID.Count(); i++)
                {
                    LoadFaces = String.Format("face" + i + ".bmp");
                    trainingImages.Add(new Image<Gray, byte>(Application.StartupPath + "/TrainedFaces/" + LoadFaces));//load ảnh
                }

            }
            catch (Exception)
            {
                MessageBox.Show(applicationConfiguration.getLanguagePackage().getMemberNotFoundMessage(),
                    applicationConfiguration.getLanguagePackage().getMemberNotFoundLabel(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            command.CommandText = @"SELECT  fldEmployeeID as N'" + applicationConfiguration.getLanguagePackage().getMemberCodeAlias()
                                    + @"',fldFirstName as N'" + applicationConfiguration.getLanguagePackage().getLastNameAlias()
                                    + @"',fldLastName as N'" + applicationConfiguration.getLanguagePackage().getFirstNameAlias()
                                    + @"',
                                            (Case fldSex when 'True' then N'" + applicationConfiguration.getLanguagePackage().getMaleAlias()
                                    + @"' else N'" + applicationConfiguration.getLanguagePackage().getFemaleAlias()
                                    + @"' end) as N'" + applicationConfiguration.getLanguagePackage().getSexAlias()
                                    + @"',
                                             fldBirth as N'" + applicationConfiguration.getLanguagePackage().getBirthAlias()
                                    + @"', fldGroupName as N'" + applicationConfiguration.getLanguagePackage().getClassAlias()
                                    + @"',fldImage as 'Hình ảnh'
                                             FROM   tblGroup INNER JOIN tblEmployee 
                                             ON tblGroup.fldGroupID = tblEmployee.fldGroupID
                                                where fldGroupName like @Group";
            command.Parameters.Add("@Group", SqlDbType.NVarChar, 50).Value = str;
            da.SelectCommand = command;
            da.Fill(dt0);
            if (dt0.Rows.Count > 0)
            {
                grvdata.DataSource = dt0;
            }
            try
            {
                foreach (DataRow dr in dt0.Rows)
                {
                    EmployeeGroupID.Add(dr.ItemArray[0].ToString());
                }
            }
            catch (Exception)
            {
            }
            btnCallTheRoll.Enabled = false;
        }
        private void frmTimekeeping_Load(object sender, EventArgs e)
        {

        }
        private void cbGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Presence.Count != 0)
                MessageBox.Show("Total Employee of group" + str + " : " + dt0.Rows.Count + "\n Number of employees are present: " + Presence.Count + "\n Number of employees are absentt: " + Absence.Count, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //==========================
            test = false;
            txtmasv.Text = null;
            txtHo.Text = null;
            txtTen.Text = null;
            txtLop.Text = null;
            //==========================
            str = cbGroup.Text;
            dt0.Clear();
            EmployeeGroupID.Clear();
            dt2.Clear();
            dt3.Clear();
            Temporary.Clear();
            Absence.Clear();
            Presence.Clear();
            txtListDiemDanh.Text = "0 Employee";
            txtShow.Text = "0 Employee";
            haar = new HaarCascade("haarcascade_frontalface_default.xml");
            SqlCommand command = new SqlCommand();
            command.Connection = con;
            command.CommandType = CommandType.Text;
            command.CommandText = @"SELECT  fldEmployeeID as N'" + applicationConfiguration.getLanguagePackage().getMemberCodeAlias()
                                    + @"',fldFirstName as N'" + applicationConfiguration.getLanguagePackage().getLastNameAlias()
                                    + @"',fldLastName as N'" + applicationConfiguration.getLanguagePackage().getFirstNameAlias()
                                    + @"',
                                            (Case fldSex when 'True' then N'" + applicationConfiguration.getLanguagePackage().getMaleAlias()
                                    + @"' else N'" + applicationConfiguration.getLanguagePackage().getFemaleAlias()
                                    + @"' end) as N'" + applicationConfiguration.getLanguagePackage().getSexAlias()
                                    + @"',
                                             fldBirth as N'" + applicationConfiguration.getLanguagePackage().getBirthAlias()
                                    + @"', fldGroupName as N'" + applicationConfiguration.getLanguagePackage().getClassAlias()
                                    + @"'
                                                     FROM   tblGroup INNER JOIN tblEmployee
                                                     ON tblGroup.fldGroupID = tblEmployee.fldGroupID
                                                     where fldGroupName like @CGroup";
            command.Parameters.Add("@Group", SqlDbType.NVarChar, 50).Value = cbGroup.Text;

            da.SelectCommand = command;
            da.Fill(dt0);
            if (dt0.Rows.Count > 0)
            {
                grvdata.DataSource = dt0;
            }
            try
            {

                foreach (DataRow dr in dt0.Rows)
                {
                    EmployeeGroupID.Add(dr.ItemArray[0].ToString());
                }
            }
            catch (Exception)
            {
                MessageBox.Show(applicationConfiguration.getLanguagePackage().getMemberNotFoundMessage(),
                     applicationConfiguration.getLanguagePackage().getMemberNotFoundLabel(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnCamera_Click(object sender, EventArgs e)
        {
            grabber = new Capture();
            grabber.QueryFrame();
            Application.Idle += new EventHandler(FrameGrabber);
            btnCallTheRoll.Enabled = true;
            btnCamera.Enabled = false;

        }
        private Boolean Check(string st)
        {
            for (int i = 0; i < EmployeeGroupID.Count; i++)
            {

                if (st == EmployeeGroupID[i])
                {
                    test = true;
                    break;
                }
            }
            return test;
        }

        void FrameGrabber(object sender, EventArgs e)
        {
            try
            {
                imageBoxFrameGrabber.Image = currentFrame;
                currentFrame = grabber.QueryFrame().Resize(350, 335, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);
                gray = currentFrame.Convert<Gray, Byte>();
                MCvAvgComp[][] facesDetected = gray.DetectHaarCascade(haar, 1.1, 10, Emgu.CV.CvEnum.HAAR_DETECTION_TYPE.DO_CANNY_PRUNING, new Size(20, 20));

                foreach (MCvAvgComp f in facesDetected[0])
                {
                    result = currentFrame.Copy(f.rect).Convert<Gray, byte>().Resize(100, 100, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);
                    currentFrame.Draw(f.rect, new Bgr(Color.Red), 2);
                    if (trainingImages.ToArray().Length != 0)
                    {

                        MCvTermCriteria termCrit = new MCvTermCriteria(ContTrain, 0.001);
                        EigenObjectRecognizer recognizer = new EigenObjectRecognizer(trainingImages.ToArray(), EmployeeID.ToArray(), 3000, ref termCrit);
                        name = recognizer.Recognize(result);
                        Check(name);
                        if (test == true)
                        {
                            currentFrame.Draw("Employee ID:" + name, ref font, new Point(f.rect.X - 2, f.rect.Y - 2), new Bgr(Color.White));

                            dt1.Clear();
                            SqlCommand cmd = new SqlCommand();
                            cmd.Connection = con;
                            cmd.CommandType = CommandType.Text;
                            cmd.CommandText = @"SELECT  fldEmployeeID as N'" + applicationConfiguration.getLanguagePackage().getMemberCodeAlias()
                                    + @"',fldFirstName as N'" + applicationConfiguration.getLanguagePackage().getLastNameAlias()
                                    + @"',fldLastName as N'" + applicationConfiguration.getLanguagePackage().getFirstNameAlias()
                                    + @"',
                                            (Case fldSex when 'True' then N'" + applicationConfiguration.getLanguagePackage().getMaleAlias()
                                    + @"' else N'" + applicationConfiguration.getLanguagePackage().getFemaleAlias()
                                    + @"' end) as N'" + applicationConfiguration.getLanguagePackage().getSexAlias()
                                    + @"',
                                             fldBirth as N'" + applicationConfiguration.getLanguagePackage().getBirthAlias()
                                    + @"', fldGroupName as N'" + applicationConfiguration.getLanguagePackage().getClassAlias()
                                    + @"'
                                                                     FROM   tblGroup INNER JOIN tblEmployee 
                                                                     ON tblGroup.fldGroupID = tblEmployee.fldGroupID
                                                                      where fldEmployeeID= @EmployeeID";
                            cmd.Parameters.Add("@EmployeeID", SqlDbType.Int, 16).Value = Convert.ToInt16(name);
                            da.SelectCommand = cmd;
                            da.Fill(dt1);
                            txtmasv.DataBindings.Clear();
                            txtmasv.DataBindings.Add("Text", dt1, applicationConfiguration.getLanguagePackage().getMemberCodeAlias());
                            txtHo.DataBindings.Clear();
                            txtHo.DataBindings.Add("Text", dt1, applicationConfiguration.getLanguagePackage().getLastNameAlias());
                            txtTen.DataBindings.Clear();
                            txtTen.DataBindings.Add("Text", dt1, applicationConfiguration.getLanguagePackage().getFirstNameAlias());
                            txtLop.DataBindings.Clear();
                            txtLop.DataBindings.Add("Text", dt1, applicationConfiguration.getLanguagePackage().getClassAlias());
                            txtGioitinh.DataBindings.Clear();
                            txtGioitinh.DataBindings.Add("Text", dt1, applicationConfiguration.getLanguagePackage().getSexAlias());
                            dpBirth.DataBindings.Clear();
                            dpBirth.DataBindings.Add("Text", dt1, applicationConfiguration.getLanguagePackage().getBirthAlias());
                           // btnCallTheRoll_Click(sender, e);
                            
                        }
                        else
                        {
                            name = "";
                            txtmasv.Text = null;
                            txtHo.Text = null;
                            txtTen.Text = null;
                            txtLop.Text = null;
                            txtGioitinh.Text = null;
                            dpBirth.Value = Convert.ToDateTime("01/07/1987");
                        }

                    }

                }
            }
            catch (Exception)
            {

            }

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(applicationConfiguration.getLanguagePackage().getMainFormQuitConfimMessage(),
                applicationConfiguration.getLanguagePackage().getMainFormQuitConfimTitle(), MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                if (Presence.Count != 0)
                {
                    MessageBox.Show("Total " + cbGroup.Text + " : " + dt0.Rows.Count + "\n Available: " + Presence.Count + "\n Absented: " + Absence.Count, "Alert", MessageBoxButtons.OK);
                    if (grabber != null)
                    {
                        grabber.Dispose();
                    }
                    Close();
                    Dispose();
                    disconnect();
                }
                else
                {
                    MessageBox.Show("Total " + cbGroup.Text + " : " + dt0.Rows.Count + " \n No member has been made roll-call", "Alert", MessageBoxButtons.OK);
                    if (grabber != null)
                    {
                        grabber.Dispose();
                    }
                    Close();
                    Dispose();
                    disconnect();
                }
            }
        }

        private void Timekeeping()
        {
            Boolean Test = false;
            if (name != "")
            {
                if (Presence.Count == 0)
                {
                    Presence.Add(name.ToString());
                    for (int i = 0; i < EmployeeGroupID.Count; i++)
                    {
                        if (EmployeeGroupID[i].ToString() != name)
                        {
                            Absence.Add(EmployeeGroupID[i].ToString());
                            Temporary.Add(EmployeeGroupID[i].ToString());
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < Presence.Count; i++)
                    {
                        if (name.ToString() == Presence[i].ToString())
                            Test = true;

                    }
                    if (Test == false)
                    {
                        Presence.Add(name.ToString());
                        Absence.Clear();
                        for (int j = 0; j < Temporary.Count; j++)
                        {
                            if (name.ToString() != Temporary[j].ToString())
                            {
                                Absence.Add(Temporary[j].ToString());
                            }

                        }
                        Temporary.Clear();
                        for (int k = 0; k < Absence.Count; k++)
                        {
                            Temporary.Add(Absence[k].ToString());
                        }

                    }
                    else if (Test == true)
                        MessageBox.Show("Employee " + txtHo.Text + " " + txtTen.Text + " already made!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                ShowInformation();
                if (comboBoxOutputDevice.Text.Equals("") || comboBoxOutputDevice.Text == null)
                {
                    MessageBox.Show("Computer no device to record out Com port!");
                    return;
                }
                serialPortManager.WriteConnection(applicationConfiguration.getLanguagePackage().getMakingRollCallSuccessSerialMessage());
            }
            else
            {
               MessageBox.Show("Employee " + cbGroup.Text + " not found!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                serialPortManager.WriteConnection(applicationConfiguration.getLanguagePackage().getMakingRollCallFailSerialMessage());
            }

        }

        public void ShowInformation()
        {
            txtListDiemDanh.Text = Presence.Count.ToString() + " Employees";
            txtShow.Text = Absence.Count.ToString() + " Employees";
            dt2.Clear();
            foreach (var item in Presence)
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = @"SELECT  fldEmployeeID as N'" + applicationConfiguration.getLanguagePackage().getMemberCodeAlias()
                                    + @"',fldFirstName as N'" + applicationConfiguration.getLanguagePackage().getLastNameAlias()
                                    + @"',fldLastName as N'" + applicationConfiguration.getLanguagePackage().getFirstNameAlias()
                                    + @"',
                                            (Case fldSex when 'True' then N'" + applicationConfiguration.getLanguagePackage().getMaleAlias()
                                    + @"' else N'" + applicationConfiguration.getLanguagePackage().getFemaleAlias()
                                    + @"' end) as N'" + applicationConfiguration.getLanguagePackage().getSexAlias()
                                    + @"',
                                             fldBirth as N'" + applicationConfiguration.getLanguagePackage().getBirthAlias()
                                    + @"', fldGroupName as N'" + applicationConfiguration.getLanguagePackage().getClassAlias()
                                    + @"'
                                            FROM   tblGroup INNER JOIN tblEmployee 
                                            ON tblGroup.fldGroupID = tblEmployee.fldGroupID
                                            where fldEmployeeID= @EmployeeID";
                cmd.Parameters.Add("@EmployeeID", SqlDbType.Int, 16).Value = Convert.ToInt16(item.ToString());
                da.SelectCommand = cmd;
                da.Fill(dt2);

                if (dt1.Rows.Count > 0)
                {
                    grvData2.DataSource = dt2;
                }
            }
            dt3.Clear();
            foreach (var item in Absence)
            {
                SqlCommand command = new SqlCommand();
                command.Connection = con;
                command.CommandType = CommandType.Text;
                command.CommandText = @"SELECT  fldEmployeeID as N'" + applicationConfiguration.getLanguagePackage().getMemberCodeAlias()
                                    + @"',fldFirstName as N'" + applicationConfiguration.getLanguagePackage().getLastNameAlias()
                                    + @"',fldLastName as N'" + applicationConfiguration.getLanguagePackage().getFirstNameAlias()
                                    + @"',
                                            (Case fldSex when 'True' then N'" + applicationConfiguration.getLanguagePackage().getMaleAlias()
                                    + @"' else N'" + applicationConfiguration.getLanguagePackage().getFemaleAlias()
                                    + @"' end) as N'" + applicationConfiguration.getLanguagePackage().getSexAlias()
                                    + @"',
                                             fldBirth as N'" + applicationConfiguration.getLanguagePackage().getBirthAlias()
                                    + @"', fldGroupName as N'" + applicationConfiguration.getLanguagePackage().getClassAlias()
                                    + @"'
                                    FROM   tblGroup INNER JOIN tblEmployee 
                                    ON tblGroup.fldGroupID = tblEmployee.fldGroupID
                                    where fldEmployeeID= @EmployeeID";
                command.Parameters.Add("@EmployeeID", SqlDbType.Int, 16).Value = Convert.ToInt16(item.ToString());
                da.SelectCommand = command;
                da.Fill(dt3);
                if (dt3.Rows.Count > 0)
                {
                    grvdata3.DataSource = dt3;
                }
            }
        }

        private void btnCallTheRoll_Click(object sender, EventArgs e)
        {

            Timekeeping();
        }


        private void frmTimekeeping_FormClosed(object sender, FormClosedEventArgs e)
        {
            try { serialPortManager.CloseConnection(); }
            catch
            {
                //No problem 
            }
        }

        private void comboBoxOutputDevice_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                // try to close if it has opened a connection before
                serialPortManager.CloseConnection();
            }
            catch (Exception ex)
            {
                //Noproblem ^^
            }
            serialPortManager = new SerialPortConn(comboBoxOutputDevice.Text);
            serialPortManager.OpenConnection();
        }

        private void btnAddNewEmployee_Click(object sender, EventArgs e)
        {

            if (grabber != null)
            {
                grabber.Dispose();
            }
            Close();
            Dispose();
            disconnect();
            frmAddNewEmployee _themMoi = new frmAddNewEmployee(applicationConfiguration);
            _themMoi.Show();
        }



        private void cbGroup_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void grvData2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_excel1_Click(object sender, EventArgs e)
        {
            try
            {
                // creating Excel Application
                Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
                // creating new WorkBook within Excel application
                Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
                // creating new Excelsheet in workbook
                Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
                // see the excel sheet behind the program
                app.Visible = true;
                // get the reference of first sheet. By default its name is Sheet1.
                // store its reference to worksheet
                worksheet = workbook.Sheets["Sheet1"];
                worksheet = workbook.ActiveSheet;
                // changing the name of active sheet
                worksheet.Name = "Exported from gridview";
                // storing header part in Excel
                for (int i = 1; i < grvData2.Columns.Count + 1; i++)
                {
                    worksheet.Cells[1, i] = grvData2.Columns[i - 1].HeaderText;
                }
                // storing Each row and column value to excel sheet

                for (int i = 0; i < grvData2.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < grvData2.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = grvData2.Rows[i].Cells[j].Value.ToString();
                    }
                }
                // save the application

                workbook.SaveAs("c:\\grvData2.xls", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                // Exit from the application
                app.Quit();
            }
            catch (Exception)
            {

            }
            finally
            {
               
            }
        }

        private void btn_excel2_Click(object sender, EventArgs e)
        {
            try
            {
                // creating Excel Application
                Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
                // creating new WorkBook within Excel application
                Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
                // creating new Excelsheet in workbook
                Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
                // see the excel sheet behind the program
                app.Visible = true;
                // get the reference of first sheet. By default its name is Sheet1.
                // store its reference to worksheet
                worksheet = workbook.Sheets["Sheet1"];
                worksheet = workbook.ActiveSheet;
                // changing the name of active sheet
                worksheet.Name = "Exported from gridview";
                // storing header part in Excel
                for (int i = 1; i < grvdata3.Columns.Count + 1; i++)
                {
                    worksheet.Cells[1, i] = grvdata3.Columns[i - 1].HeaderText;
                }
                // storing Each row and column value to excel sheet

                for (int i = 0; i < grvdata3.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < grvdata3.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = grvdata3.Rows[i].Cells[j].Value.ToString();
                    }
                }
                // save the application

                workbook.SaveAs("c:\\grvData3.xls", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                // Exit from the application
                app.Quit();
            }
            catch (Exception)
            {


            }
            finally
            {
               
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

    }
}

