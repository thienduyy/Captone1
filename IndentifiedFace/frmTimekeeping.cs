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
		// Khởi tạo các biến dt, dt0, dt1... là tên của các table tương ứng
        private SqlConnection con;
        private DataTable dt = new DataTable("Table0");
        private DataTable dt0 = new DataTable("Table1");
        private DataTable dt1 = new DataTable("Table2");
        private DataTable dt2 = new DataTable("Table3");
        private DataTable dt3 = new DataTable("Table4");
        private DataTable dtbl = new DataTable();
        private DataTable dtGroup = new DataTable("TableClass");
        private DateTime date;
        private SqlDataAdapter da = new SqlDataAdapter();

		// khai báo, khởi tạo các biến image về số byte, color...
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
		// khai báo Presence là 1 mảng danh sách các employee hiện diện
        List<String> Presence = new List<string>();
		// khai báo Absence là 1 mảng danh sách các employee vắng mặt
        List<String> Absence = new List<string>();
		// khai báo Temporary là 1 mảng danh sách các employee tạm thời
        List<String> Temporary = new List<string>();

        Boolean test = false;
        private SerialPortConn serialPortManager;

		// hàm này thực hiện truy vấn để đưa ra danh sách employee theo từng group
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
			// khởi tạo biến tham chiếu command để thao tác với csdl
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
			// truy vấn lấy fldEmployeeID,fldFirstName,fldLastName ... từ bảng tblGroup kết hợp với tblEmployee điều kiện là fldGroupID của 2 bảng bằng nhau
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
                                    + @",lastdate'
                                             FROM   tblGroup INNER JOIN tblEmployee 
                                             ON tblGroup.fldGroupID = tblEmployee.fldGroupID";
            da.SelectCommand = command;
			// thực hiện xuất dữ liệu lấy được sau truy vấn vào table(dt)
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                grvdata.DataSource = dt;
                grvdata.Columns[4].DefaultCellStyle.Format = "dd/MM/yyyy";
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
// truy vấn lấy fldEmployeeID,fldFirstName,fldLastName ... từ bảng tblGroup kết hợp với tblEmployee trên cơ sở là fldGroupID của 2 bảng bằng nhau với điều kiện là fldGroupName giống(like) biến group bắt được
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
			// thực hiện xuất dữ liệu lấy được sau truy vấn vào table(dt0)
            da.Fill(dt0);
            if (dt0.Rows.Count > 0)
            {
                grvdata.DataSource = dt0;
                grvdata.Columns[4].DefaultCellStyle.Format = "dd/MM/yyyy";
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
			String cn = @"Data Source=DESKTOP-1GICUND\;Initial Catalog=Employee;Integrated Security=True";
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
        private void frmTimekeeping_Load(object sender, EventArgs e)
        {
            date = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.Hour, DateTime.Now.Minute,DateTime.Now.Second);

        }
		// Hàm này thực hiện đếm số người đã điểm danh
        private void cbGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Presence.Count != 0)
                MessageBox.Show("Tổng số nhân viên trong phòng: " + str + " : " + dt0.Rows.Count + "\n Số nhân viên có mặt: " + Presence.Count + "\n Số nhân viên vắng mặt: " + Absence.Count, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //==========================
            test = false;
            txtmanv.Text = null;
            txtHo.Text = null;
            txtTen.Text = null;
            txtPhong.Text = null;
            dpBirth.Format = DateTimePickerFormat.Custom;
            dpBirth.CustomFormat = "dd/MM/yyyy";
            //==========================
            str = cbGroup.Text;
            dt0.Clear();
            EmployeeGroupID.Clear();
            dt2.Clear();
            dt3.Clear();
            Temporary.Clear();
            Absence.Clear();
            Presence.Clear();
            txtListDiemDanh.Text = "0 Nhân viên";
            txtShow.Text = "0 nhân viên";
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
                grvdata.Columns[4].DefaultCellStyle.Format = "dd/MM/yyyy";
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

		// Khi bật chương trình điểm danh, ấn vào button Camera thì nó chạy vào hàm này	
        private void btnCamera_Click(object sender, EventArgs e)
        {
			
            grabber = new Capture();
            grabber.QueryFrame();
			// đoạn này nó sẽ chạy vào hàm FrameGrabber để thực hiện việc nhận dạng xem ai đang ở trước camera
            Application.Idle += new EventHandler(FrameGrabber);
            btnCallTheRoll.Enabled = true;
            btnCamera.Enabled = false;

        }
		// Hàm này thực hiện kiểm tra xem cái chuỗi st đưa vào có trả về dữ liệu là đúng hay sai, hay nói cách khác hàm này thực hiện kiểm tra việc đúng sai của dữ liệu
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

		// Hàm này thực hiện nhận dạng
        void FrameGrabber(object sender, EventArgs e)
        {
            try
            {
				// khởi tạo 1 đối tượng là currentFrame có dạng là hình ảnh
                imageBoxFrameGrabber.Image = currentFrame;
				// khởi tạo currentFrame sẽ có khung hình rộng 350, cao 335
                currentFrame = grabber.QueryFrame().Resize(350, 335, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);
				// khai báo đối tượng gray này để quy định cái ảnh mà mình nhận được nằm trong khung
                gray = currentFrame.Convert<Gray, Byte>();
				// facesDetected là khuôn hình ảnh nằm trong khung và sẽ có dạng theo quy định của gray
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
                            double StopValue = Convert.ToDouble(System.Configuration.ConfigurationSettings.AppSettings["StopValue"]);
							// cái này là hiển thị ở trên khung hình màu đỏ gồm có số ID, cái thứ 2 là font chữ, cái thứ 3 là vị trí hiển thị, cái cuối là màu sắc
                            currentFrame.Draw("Ma NV:" + name, ref font, new Point(f.rect.X - 2, f.rect.Y - 2), new Bgr(Color.White));

                            dt1.Clear();
                            SqlCommand cmd = new SqlCommand();
                            cmd.Connection = con;
                            cmd.CommandType = CommandType.Text;
							// truy vấn lấy thông tin của Employee trong csdl
                            cmd.CommandText = @"SELECT  lastdate,fldEmployeeID as N'" + applicationConfiguration.getLanguagePackage().getMemberCodeAlias()
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
                            
							// Hiển thị thông tin của Employee vừa lấy được ở trên ra bảng
                            da.Fill(dt1);

                            grvdata.Columns[4].DefaultCellStyle.Format = "dd/MM/yyyy";
                            txtmanv.DataBindings.Clear();
                            txtmanv.DataBindings.Add("Text", dt1, applicationConfiguration.getLanguagePackage().getMemberCodeAlias());
                            txtHo.DataBindings.Clear();
                            txtHo.DataBindings.Add("Text", dt1, applicationConfiguration.getLanguagePackage().getLastNameAlias());
                            txtTen.DataBindings.Clear();
                            txtTen.DataBindings.Add("Text", dt1, applicationConfiguration.getLanguagePackage().getFirstNameAlias());
                            txtPhong.DataBindings.Clear();
                            txtPhong.DataBindings.Add("Text", dt1, applicationConfiguration.getLanguagePackage().getClassAlias());
                           txtGioitinh.DataBindings.Clear();
                           txtGioitinh.DataBindings.Add("Text", dt1, applicationConfiguration.getLanguagePackage().getSexAlias());
                           dpBirth.DataBindings.Clear();
                           dpBirth.DataBindings.Add("Text", dt1, applicationConfiguration.getLanguagePackage().getBirthAlias());
                            //btnCallTheRoll_Click(sender, e);
                            DateTime date = Convert.ToDateTime(dt1.Rows[0]["lastdate"]);
                            TimeSpan diff = DateTime.Now - date;
                            double seconds = diff.TotalSeconds;
                            if(seconds>StopValue)
                            {
                            SqlCommand cmd2 = new SqlCommand();
                            cmd2.Connection = con;
                            cmd2.CommandType = CommandType.Text;
							// truy vấn lấy thông tin của Employee trong csdl
                            cmd2.CommandText = "update tblEmployee set lastdate=GETDATE() where fldEmployeeID=" + dt1.Rows[0][1].ToString();
                            cmd2.ExecuteNonQuery();
                            MessageBox.Show("Thông báo", "Quá thời gian quy định", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        else
                        {
                            name = "";
                            txtmanv.Text = null;
                            txtHo.Text = null;
                            txtTen.Text = null;
                            txtPhong.Text = null;
                            txtGioitinh.Text = null;
                            dpBirth.Value = Convert.ToDateTime("dd/MM/yyyy");
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
                        MessageBox.Show("Nhân viên:  " + txtHo.Text + " " + txtTen.Text + " đã được tạo!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                ShowInformation();
                if (comboBoxOutputDevice.Text.Equals("") || comboBoxOutputDevice.Text == null)
                {
                    MessageBox.Show("Computer no device to record out Com port!");
                    return;
                }
				// đoạn này đưa dữ liệu ra cổng COM sẽ là A
                //serialPortManager.WriteConnection(applicationConfiguration.getLanguagePackage().getMakingRollCallSuccessSerialMessage());
            }
            else
            {
                MessageBox.Show("Nhân viên phòng " + cbGroup.Text + " không được tìm thấy!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				// đoạn này đưa dữ liệu ra cổng COM sẽ là B
                //serialPortManager.WriteConnection(applicationConfiguration.getLanguagePackage().getMakingRollCallFailSerialMessage());
            }

        }
		// Hàm này chỉ là hiển thị thông tin Employees
        public void ShowInformation()
        {
            txtListDiemDanh.Text = Presence.Count.ToString() + " Nhân viên";
            txtShow.Text = Absence.Count.ToString() + " Nhân viên";
            dt2.Clear();
            dtbl.Clear();
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

                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = con;
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.CommandText = @"SELECT  fldEmployeeID FROM tblGroup INNER JOIN tblEmployee 
                                            ON tblGroup.fldGroupID = tblEmployee.fldGroupID
                                            where fldEmployeeID= @EmployeeID";
                sqlCmd.Parameters.Add("@EmployeeID", SqlDbType.Int, 16).Value = Convert.ToInt16(item.ToString());
                da.SelectCommand = sqlCmd;
                da.Fill(dtbl);

                if (dt1.Rows.Count > 0)
                {
                    SqlCommand cmd2 = new SqlCommand();
                    cmd2.Connection = con;
                    cmd2.CommandType = CommandType.Text;
                    cmd2.CommandText = @"INSERT INTO tblTimekeeping(tDatetime,fldEmployeeID) VALUES('" + date + "','" + dtbl.Rows[0]["fldEmployeeID"] + "')";
                    cmd2.ExecuteNonQuery();
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
                /* creating Excel Application
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
                app.Quit();*/
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

        private void btnList_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.ShowDialog();
        }

        

    }
}

