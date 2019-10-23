using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using IndentifiedFace.Configurations;

namespace IndentifiedFace
{
    public partial class Form1 : Form
    {
        private SqlConnection con;
        private SqlDataAdapter da = new SqlDataAdapter();
        private AppConfig applicationConfiguration;
        DataTable dt = new DataTable();
        DataTable dt1 = new DataTable();
        DataTable dt2 = new DataTable();
        DataTable dt3 = new DataTable();
        private void connect()
        {
            //String cn = applicationConfiguration.getDatabaseConnectionString();
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
        //=======================
        // Lay list theo manv
        private void GetListOne()
        {
            
            dt.Clear();
            connect();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = @"SELECT DISTINCT c.tDatetime as N'Ngày tháng', b.fldEmployeeID as N'Mã nhân viên',
                                        b.fldFirstName as N'Họ
                                     ',b.fldLastName as N'Tên
                                    ', (Case b.fldSex when 'True' then N'Nam
                                    ' else N'Nữ
                                    ' end) as N'Giới tính
                                    ',b.fldBirth as N'Ngày sinh
                                    ', a.fldGroupName as N'Phòng ban
                                    ' FROM   tblGroup a INNER JOIN tblEmployee b
                                            ON a.fldGroupID = b.fldGroupID INNER JOIN tblTimekeeping c
                                            ON b.fldEmployeeID = c.fldEmployeeID  WHERE c.tDatetime >= '" + Convert.ToDateTime(dtpFrom.Value) + "' and c.tDatetime <= '" + Convert.ToDateTime(dtpTo.Value) + "' and b.fldEmployeeID = '" + cmbgetEmployee.SelectedValue + "'";

            da.SelectCommand = cmd;
            da.Fill(dt);
            dgvDS.DataSource = dt;
            dgvDS.Columns[0].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm:ss";


        }


        //===================================
        //Lay list tat ca nv tu ngay ... den ngay ....
        private void GetList()
        {
            dt1.Clear();
            connect();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = @"SELECT DISTINCT c.tDatetime as N'Ngày tháng', b.fldEmployeeID as N'Mã nhân viên',
                                        b.fldFirstName as N'Họ
                                     ',b.fldLastName as N'Tên
                                    ', (Case b.fldSex when 'True' then N'Nam
                                    ' else N'Nữ
                                    ' end) as N'Giới tính
                                    ',b.fldBirth as N'Ngày sinh
                                    ', a.fldGroupName as N'Phòng ban
                                    ' FROM   tblGroup a INNER JOIN tblEmployee b
                                            ON a.fldGroupID = b.fldGroupID INNER JOIN tblTimekeeping c
                                            ON b.fldEmployeeID = c.fldEmployeeID  WHERE c.tDatetime between ('" + Convert.ToDateTime(dtpFrom.Value) + "') and ('" + Convert.ToDateTime(dtpTo.Value) + "') ";

            da.SelectCommand = cmd;
            da.Fill(dt1);
            dgvDS.DataSource = dt1;
            dgvDS.Columns[0].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm:ss";


        }
        //========================================


        //============
        //do du lieu len combo
        private void fillcombo()
        {
            dt2.Clear();
            connect();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = @"SELECT fldEmployeeID, fldFirstName +' '+ fldLastName as fldName from tblEmployee";

            da.SelectCommand = cmd;
            da.Fill(dt2);
            cmbgetEmployee.DataSource = dt2;
            cmbgetEmployee.DisplayMember = "fldName";
            cmbgetEmployee.ValueMember = "fldEmployeeID";
        }
        
        //====================
        //dem ngay cong
        private void demngaycong()
        {
            dt3.Clear();
            connect();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;//,,
            cmd.CommandText = @"SELECT b.fldEmployeeID, a.fldFirstName, a.fldLastName,count(b.fldEmployeeID)  as test
                                        FROM   tblEmployee a, tblTimekeeping b
                                         WHERE a.fldEmployeeID = b.fldEmployeeID and b.tDatetime >= '" +Convert.ToDateTime(dtpFrom.Value) + "' and b.tDatetime <= '" + Convert.ToDateTime(dtpTo.Value) + "' and a.fldEmployeeID = '" + cmbgetEmployee.SelectedValue + "' ";
                                        

            da.SelectCommand = cmd;
            da.Fill(dt3);
            dgvDS.DataSource = dt3;
            
        }

        public Form1()
        {
            InitializeComponent();
            //dtpFrom.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            //dtpTo.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day + 1);
            
            
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            //GetList();
            fillcombo();
            cmbgetEmployee.Enabled = false;
            label2.Enabled = false;
            
        }

        private void dtpFrom_ValueChanged(object sender, EventArgs e)
        {
            GetList();
            
        }

        //private void GetList()
        //{
        //    throw new NotImplementedException();
        //}
        //private void GetListOne()
        //{
        //    throw new NotImplementedException();
        //}
        private void dtpTo_ValueChanged(object sender, EventArgs e)
        {
            GetList();
         
        }

        private void dgvDS_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            GetList();
            GetListOne();
        }

        private void bt_checkall_Click(object sender, EventArgs e)
        {
            cmbgetEmployee.Enabled = false;
            label2.Enabled = false;
            GetList();
            

        }

        private void bt_getonebyone_Click(object sender, EventArgs e)
        {
            cmbgetEmployee.Enabled = true;
            label2.Enabled = true;
            GetListOne();

        }

        private void bt_available_Click(object sender, EventArgs e)
        {
            cmbgetEmployee.Enabled = true;
            label2.Enabled = true;
            //demngaycong();
        }

       

       

    }
}
