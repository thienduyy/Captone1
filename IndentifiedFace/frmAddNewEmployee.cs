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
namespace IndentifiedFace
{
    public partial class frmAddNewEmployee : Form
    {
        private SqlConnection con;
        private DataTable dt = new DataTable("tblEmployee");
        private DataTable dt1 = new DataTable("ShowInfo");
        private DataTable dtGroup = new DataTable("tblGroup");
        private SqlDataAdapter da = new SqlDataAdapter();
        private Boolean kt;

        string EmployeeName, GroupName;
        Capture grabber;
        Image<Bgr, Byte> currentFrame;
        Image<Gray, Byte> gray;
        HaarCascade haar;
        Image<Gray, Byte> result, TrainedFace;
        List<Image<Gray, Byte>> trainingImages = new List<Image<Gray, byte>>();
        int ContTrain, NumLabels;
        List<String> EmployeeID = new List<string>();
        string name, LoadFaces;
        MCvFont font = new MCvFont(FONT.CV_FONT_HERSHEY_TRIPLEX, 0.5d, 0.5d);
        private AppConfig applicationConfiguration;
        private void connect()
        {
            String cn = @"Data Source=PUNN\;Initial Catalog=Employee;Integrated Security=True";
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
            con.Close();
            con.Dispose();
            con = null;
        }

        private void getdata()
        {
            SqlCommand command = new SqlCommand();
            command.Connection = con;
            command.CommandType = CommandType.Text;
            command.CommandText = "Select * from tblEmployee";
            da.SelectCommand = command;
            da.Fill(dt);

            command.CommandText = "Select * from tblGroup";
            da.SelectCommand = command;
            da.Fill(dtGroup);
            cbGroup.DataSource = dtGroup;
            //MessageBox.Show("Hello");
            cbGroup.DisplayMember = "fldGroupName";
            cbGroup.ValueMember = "fldGroupID";
     

            //cbGroup.SelectedValue = "fldGroupID";
            //cbGroup.SelectedIndex = 0;

        }

        public frmAddNewEmployee(Configuration appConfig)
        {
            applicationConfiguration = (AppConfig)appConfig;
            InitializeComponent();
                    forceCustomReInitialize();

            btnReset.Enabled = false;
            btnAddNewEmployee.Enabled = false;
            cbGioitinh.SelectedIndex = 0;
            connect();
            dt.Clear();
            //SqlCommand command = new SqlCommand();
            //command.Connection = con;
            //command.CommandType = CommandType.Text;
            //command.CommandText = @"SELECT * from tblEmployee ";
            getdata();
            //da.SelectCommand = command;
            //da.Fill(dt);

            haar = new HaarCascade("haarcascade_frontalface_default.xml");

            try
            {
                foreach (DataRow dr in dt.Rows)
                {
                    EmployeeID.Add(dr.ItemArray[0].ToString());
                }
                ContTrain = NumLabels = EmployeeID.Count();
                for (int i = 1; i <= NumLabels; i++)
                {
                    LoadFaces = String.Format("face" + i + ".bmp");
                    trainingImages.Add(new Image<Gray, byte>(Application.StartupPath + "/TrainedFaces/" + LoadFaces));
                }

            }
            catch (Exception)
            {
            }

        }

        public frmAddNewEmployee()
        {
            //applicationConfiguration = (AppConfig)appConfig;
            InitializeComponent();
            //forceCustomReInitialize();

            btnReset.Enabled = false;
            btnAddNewEmployee.Enabled = false;
            cbGioitinh.SelectedIndex = 0;
            connect();
            dt.Clear();
            //SqlCommand command = new SqlCommand();
            //command.Connection = con;
            //command.CommandType = CommandType.Text;
            //command.CommandText = @"SELECT * from tblEmployee ";
            getdata();
            //da.SelectCommand = command;
            //da.Fill(dt);

            haar = new HaarCascade("haarcascade_frontalface_default.xml");

            try
            {
                foreach (DataRow dr in dt.Rows)
                {
                    EmployeeID.Add(dr.ItemArray[0].ToString());
                }
                ContTrain = NumLabels = EmployeeID.Count();
                for (int i = 1; i <= NumLabels; i++)
                {
                    LoadFaces = String.Format("face" + i + ".bmp");
                    trainingImages.Add(new Image<Gray, byte>(Application.StartupPath + "/TrainedFaces/" + LoadFaces));
                }

            }
            catch (Exception)
            {
            }

        }

        

        void FrameGrabber(object sender, EventArgs e)
        {
    
            try
            {

                imageBoxFrameGrabber1.Image = currentFrame;
                currentFrame = grabber.QueryFrame().Resize(350, 335, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);// tao khung cho camera
                gray = currentFrame.Convert<Gray, Byte>();
                MCvAvgComp[][] facesDetected = gray.DetectHaarCascade(
                                                                       haar,
                                                                       1.2,
                                                                       10,
                                                                       Emgu.CV.CvEnum.HAAR_DETECTION_TYPE.DO_CANNY_PRUNING,
                                                                       new Size(20, 20)
                                                                      );

                foreach (MCvAvgComp f in facesDetected[0])
                {                
                    result = currentFrame.Copy(f.rect).Convert<Gray, byte>().Resize(100, 100, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);//copy khung hình chưa khuôn mặt
                    ImageFace.Image = result;
                    currentFrame.Draw(f.rect, new Bgr(Color.Red), 2);
                    if (trainingImages.ToArray().Length != 0)
                    {
                        MCvTermCriteria termCrit = new MCvTermCriteria(ContTrain, 0.01);
                        EigenObjectRecognizer recognizer = new EigenObjectRecognizer(trainingImages.ToArray(),
                                                                                EmployeeID.ToArray(),
                                                                              3000, ref termCrit);
                        name = recognizer.Recognize(result);
                        btnAddNewEmployee.Enabled = true;
                        if (name != "")
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
                            cmd.Parameters.Add("@EmployeeID", SqlDbType.Int, 16).Value = Convert.ToInt16(name);
                            da.SelectCommand = cmd;
                            da.Fill(dt1);
                            foreach (DataRow dr in dt1.Rows)
                            {
                                EmployeeName = dr.ItemArray[1].ToString() + " " + dr.ItemArray[2].ToString();
                                GroupName = dr.ItemArray[5].ToString();
                            }
                            //currentFrame.Draw("Employee ID: " + name, ref font, new Point(
                            //                f.rect.X - 2, f.rect.Y - 2),
                            //                new Bgr(Color.White)
                            //                );
                            currentFrame.Draw(f.rect, new Bgr(Color.Red), 2);
                        }
                        
                    }
                    else
                        name = "";
                }
            }
            catch (Exception)
            {
                //MessageBox.Show("KHông phát hiện được khuôn mặt nào!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            
        }

        private void btnCamera_Click(object sender, EventArgs e)
        {
            grabber = new Capture();
            grabber.QueryFrame();
            Application.Idle += new EventHandler(FrameGrabber);
            btnReset.Enabled = true;
            btnAddNewEmployee.Enabled = true;
            btnCamera.Enabled = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (grabber != null)
            {
                grabber.Dispose();
            }
            Close();
            Dispose();
            disconnect();
        }

        private void frmAddNewEmployee_Load(object sender, EventArgs e)
        {
            connect();
            getdata();
          
           
        }

        private Boolean CheckInfo()
        {
            kt = true;
            if (txtHo.Text == "")
            {
                MessageBox.Show("LastName is required!", "Message", MessageBoxButtons.OK);
                kt = false;
            }
            else if (txtTen.Text == "")
            {
                MessageBox.Show("FirstName is required !", "Message", MessageBoxButtons.OK);
                kt = false;
            }
            else if (dtBirth.Value == null)
            {
                MessageBox.Show("Birth day is required!", "Message", MessageBoxButtons.OK);
                kt = false;
            }

            return kt;
        }

       
        private void btnReset_Click(object sender, EventArgs e)
        {
            txtmasv.Text = null;
            txtHo.Text = null;
            txtTen.Text = null;
            cbGioitinh.SelectedIndex = 0;
            cbGroup.SelectedIndex = 0;
        }

        private void btnDanhSachSV_Click(object sender, EventArgs e)
        {
            if (grabber != null)
            {
                grabber.Dispose();
            }
            Close();
            Dispose();
            disconnect();
            new frmMain1(applicationConfiguration).Show();
        }

        private void ImageFace_Click(object sender, EventArgs e)
        {

        }

        private void txtmasv_TextChanged(object sender, EventArgs e)
        {

        }

        private void imageBoxFrameGrabber1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmAddNewEmployee_Load_1(object sender, EventArgs e)
        {

        }

        private void cbGroup_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnAddNewEmployee_Click_1(object sender, EventArgs e)
        {


                CheckInfo();
                if (kt == true)
                {
                    try
                    {
                        TrainedFace = result;
                        trainingImages.Add(TrainedFace);
                        ImageFace.Image = result;
                        for (int i = 1; i < trainingImages.ToArray().Length + 1; i++)
                        {
                            trainingImages.ToArray()[i - 1].Save(String.Format("{0}/TrainedFaces/face{1}.bmp", Application.StartupPath, i));
                        }


                        DataRow row = dt.NewRow();
                        row["fldFirstName"] = txtHo.Text; 
                        row["fldLastName"] = txtTen.Text;
                        row["fldGroupID"] = cbGroup.SelectedValue;
                        if (cbGioitinh.Text == applicationConfiguration.getLanguagePackage().getMaleAlias())
                            row["fldSex"] = 1;
                        else if (cbGioitinh.Text == applicationConfiguration.getLanguagePackage().getMaleAlias())
                            row["fldSex"] = 0;
                        row["fldBirth"] = dtBirth.Value;
                        int x = trainingImages.ToArray().Length;
                        row["fldImage"] = "face" + x + ".bmp";

                        dt.Rows.Add(row);
                        SqlCommand commandInsert = new SqlCommand();
                        commandInsert.Connection = con;
                        commandInsert.CommandType = CommandType.Text;
                        commandInsert.CommandText = @" Insert tblEmployee (fldFirstName,fldLastName,fldGroupID,fldSex,fldBirth,fldImage)
                                                Values (@fldFirstName,@fldLastName,@fldGroupID,@fldSex,@fldBirth,@fldImage)";
                        commandInsert.Parameters.Add("@fldFirstName", SqlDbType.NVarChar, 50, "fldFirstName");
                        commandInsert.Parameters.Add("@fldLastName", SqlDbType.NVarChar, 50, "fldLastName");
                        commandInsert.Parameters.Add("@fldGroupID", SqlDbType.Int, 50, "fldGroupID");
                        commandInsert.Parameters.Add("@fldSex", SqlDbType.Int, 50, "fldSex");
                        commandInsert.Parameters.Add("@fldBirth", SqlDbType.DateTime, 50, "fldBirth");
                        commandInsert.Parameters.Add("@fldImage", SqlDbType.NVarChar, 50, "fldImage");
                        da.InsertCommand = commandInsert;
                        da.Update(dt);


                        MessageBox.Show("Add successful!", "Message", MessageBoxButtons.OK);
                        //if (grabber != null)
                        //{
                        //    grabber.Dispose();
                        //}
                        //Close();
                        //Dispose();
                        //disconnect();
                        ////new frmMain(applicationConfiguration).Show();
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Have an error", "Error :"+ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
           


        }


    }



