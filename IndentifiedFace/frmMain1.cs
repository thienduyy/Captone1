using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using IndentifiedFace.Configurations;
using System.Data.SqlClient;
using System.Configuration;

namespace IndentifiedFace
{
    public partial class frmMain1 : Form
    {
        //private AppConfig applicationConfiguration;
        private SqlConnection con;
        private DataTable dt = new DataTable("show");
        private DataTable dtGroup = new DataTable("tblGroup");
        private SqlDataAdapter da = new SqlDataAdapter();
        private AppConfig applicationConfiguration;
        
        private frmAddNewEmployee _frmAddNewEmployee;
        public frmMain1()
        {
            InitializeComponent();
            

        }
        public frmMain1(IndentifiedFace.Configurations.Configuration appConfig)
        {
            applicationConfiguration = (AppConfig)appConfig;
            InitializeComponent();
            forceCustomReInitialize();


        }
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _frmAddNewEmployee = new frmAddNewEmployee(applicationConfiguration);
            
            _frmAddNewEmployee.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmTimekeeping diemdanh = new frmTimekeeping(applicationConfiguration);
            diemdanh.Show();
        }
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
            con.Close();
            con.Dispose();
            con = null;
        }

        private void btnListOfEmp_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1(applicationConfiguration);
            frm.ShowDialog();
        }
    }
}
