using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Threading.Tasks;
using IndentifiedFace.Configurations;
//using System.Data;

namespace IndentifiedFace
{
    public partial class frmLogin : Form
    {
        private SqlConnection con;
        private DataTable dt = new DataTable("User");
        private SqlDataAdapter da = new SqlDataAdapter();
        private LanguagePackage languagePackage;
        private AppConfig applicationConfiguration;
        public frmLogin()
        {
            InitializeComponent();
        }
        public frmLogin(Configuration appConfig)
        {
            // TODO: Complete member initialization
            applicationConfiguration = (AppConfig)appConfig;
            this.languagePackage = appConfig.getLanguagePackage();
            InitializeComponent();
        }
        private void connect()
        {
            //String cn = applicationConfiguration.getDatabaseConnectionString();
            String cn = @"Data Source=DESKTOP-OOJ4QPN;Initial Catalog=Employee;Integrated Security=True";
            try
            {
                con = new SqlConnection(cn);
                con.Open();
            }
            catch
            {
                MessageBox.Show(languagePackage.getErrorConnectToDatabaseMessage(), languagePackage.getErrorConnectToDatabaseTitle(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void disconnect()
        {
            con.Close();
            con.Dispose();
            con = null;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
       
       
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        //public static string UserName = "";
        private void btLogin_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = con;
            command.CommandType = CommandType.Text;
            command.CommandText = @"Select * From tblAccount
                                            Where (fldUsername = @User)
                                            And (fldPassword = @Pass)";
            command.Parameters.Add("@User", SqlDbType.NVarChar, 50).Value = txtUsername.Text;
            command.Parameters.Add("@Pass", SqlDbType.NVarChar, 50).Value = txtPassword.Text;
            da.SelectCommand = command;
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                frmMain1 main = new frmMain1(applicationConfiguration);
                main.Show();
                Hide();
            }
            else
            {
                if (MessageBox.Show(languagePackage.getAskRetryLoginMessage(), languagePackage.getAskRetryLoginTitle(), MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    txtUsername.Focus();
                }
                else
                {
                    Close();
                    Dispose();
                    disconnect();
                    System.Windows.Forms.Application.Exit();
                }
            }
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            connect();
            
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtUsername_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(txtUsername.Text))
            {
                e.Cancel = true;
                txtUsername.Focus();
                errorProvider1.SetError(txtUsername, "Please enter your username!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtUsername, null);
            }
        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                e.Cancel = true;
                txtPassword.Focus();
                errorProvider1.SetError(txtPassword, "Please enter your password!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtUsername, null);
            }
        }
    }
}
