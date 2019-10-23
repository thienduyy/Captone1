using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace IndentifiedFace
{
    public partial class frmCheck : Form
    {
        public frmCheck()
        {
            applicationConfiguration =new AppConfig("En");
          
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private SqlConnection con;
        private AppConfig applicationConfiguration ;
        DataTable dt1=new DataTable();
        private SqlDataAdapter da = new SqlDataAdapter();
        private void btn_s_Click(object sender, EventArgs e)
        {

            if (txt_s.Text!="")
            {
                String cn = applicationConfiguration.getDatabaseConnectionString();
               
                    con = new SqlConnection(cn);
               
                dt1.Clear();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                // truy vấn lấy thông tin của Employee trong csdl
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
                cmd.Parameters.Add("@EmployeeID", SqlDbType.Int, 16).Value = Convert.ToInt16(txt_s.Text);
                da.SelectCommand = cmd;
                // Hiển thị thông tin của Employee vừa lấy được ở trên ra bảng
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
                //btnCallTheRoll_Click(sender, e);
                DataTable tb = applicationConfiguration.EXECUTE_PROCE(@"SELECT distinct  [ID]
                                                                      ,[tDatetime]     
                                                                      ,[Note]
                                                                  FROM [tblTimekeeping] where fldEmployeeID=" + txt_s.Text);
                grvData2.DataSource = tb;
                
                
            }
            else
            {
               
                txtmasv.Text = null;
                txtHo.Text = null;
                txtTen.Text = null;
                txtLop.Text = null;
                txtGioitinh.Text = null;
                dpBirth.Value = Convert.ToDateTime("01/09/1987");
            }
        }

        private void btn_check_Click(object sender, EventArgs e)
        {
            DataTable tb = applicationConfiguration.EXECUTE_PROCE(@"SELECT   [fldEmployeeID]
                                                                  ,[fldFirstName]
                                                                  ,[fldLastName]
                                                                  ,[fldGroupID]
                                                                  ,[fldSex]
                                                                  ,[fldBirth]
                                                                  ,[fldImage]
                                                              FROM [tblEmployee] where fldEmployeeID=" + txt_check.Text);
            if (tb != null && tb.Rows.Count > 0)

            {
                if(MessageBox.Show("Employee Found in Company. Are you sure Timekeeping?","Alert",MessageBoxButtons.YesNo)==DialogResult.Yes)
                {
                frmTimekeeping diemdanh = new frmTimekeeping(applicationConfiguration);
                diemdanh.Show();
                this.Hide();
                }

            }
            else
            {
                MessageBox.Show("Employee " + txt_check.Text + " not found!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
