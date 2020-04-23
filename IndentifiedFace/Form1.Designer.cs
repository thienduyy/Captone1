
namespace IndentifiedFace
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbgetEmployee = new System.Windows.Forms.ComboBox();
            this.dgvDS = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_exit = new System.Windows.Forms.Button();
            this.bt_available = new System.Windows.Forms.Button();
            this.bt_getbyGroup = new System.Windows.Forms.Button();
            this.bt_getonebyone = new System.Windows.Forms.Button();
            this.bt_checkall = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDS)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpTo
            // 
            this.dtpTo.CustomFormat = "dd/MM/yyyy";
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTo.Location = new System.Drawing.Point(697, 46);
            this.dtpTo.Margin = new System.Windows.Forms.Padding(4);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(148, 25);
            this.dtpTo.TabIndex = 4;
            this.dtpTo.Value = new System.DateTime(2020, 1, 2, 0, 0, 0, 0);
            this.dtpTo.ValueChanged += new System.EventHandler(this.dtpTo_ValueChanged);
            // 
            // dtpFrom
            // 
            this.dtpFrom.CustomFormat = "dd/MM/yyyy";
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFrom.Location = new System.Drawing.Point(467, 46);
            this.dtpFrom.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(148, 25);
            this.dtpFrom.TabIndex = 5;
            this.dtpFrom.Value = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.dtpFrom.ValueChanged += new System.EventHandler(this.dtpFrom_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 19);
            this.label2.TabIndex = 10;
            this.label2.Text = "Name         : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(654, 51);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 19);
            this.label1.TabIndex = 8;
            this.label1.Text = "To :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 11.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(406, 50);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 19);
            this.label6.TabIndex = 7;
            this.label6.Text = "From :";
            // 
            // cmbgetEmployee
            // 
            this.cmbgetEmployee.FormattingEnabled = true;
            this.cmbgetEmployee.Location = new System.Drawing.Point(142, 246);
            this.cmbgetEmployee.Name = "cmbgetEmployee";
            this.cmbgetEmployee.Size = new System.Drawing.Size(128, 25);
            this.cmbgetEmployee.TabIndex = 9;
            // 
            // dgvDS
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDS.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDS.ColumnHeadersHeight = 25;
            this.dgvDS.Location = new System.Drawing.Point(324, 115);
            this.dgvDS.Name = "dgvDS";
            this.dgvDS.ReadOnly = true;
            this.dgvDS.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dgvDS.Size = new System.Drawing.Size(548, 228);
            this.dgvDS.TabIndex = 0;
            this.dgvDS.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDS_CellContentClick);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(26, 49);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(115, 1);
            this.panel3.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 22);
            this.label3.TabIndex = 15;
            this.label3.Text = "Statistical";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(286, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1, 350);
            this.panel1.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(313, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 21);
            this.label4.TabIndex = 15;
            this.label4.Text = "List :";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(142, 330);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(128, 25);
            this.comboBox1.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 330);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 19);
            this.label5.TabIndex = 10;
            this.label5.Text = "Department : ";
            // 
            // btn_exit
            // 
            this.btn_exit.Image = global::IndentifiedFace.Properties.Resources.x_30px1;
            this.btn_exit.Location = new System.Drawing.Point(804, 360);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(68, 36);
            this.btn_exit.TabIndex = 14;
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // bt_available
            // 
            this.bt_available.Image = global::IndentifiedFace.Properties.Resources.day_off_25px;
            this.bt_available.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_available.Location = new System.Drawing.Point(35, 141);
            this.bt_available.Name = "bt_available";
            this.bt_available.Size = new System.Drawing.Size(204, 36);
            this.bt_available.TabIndex = 13;
            this.bt_available.Text = "Working Days";
            this.bt_available.UseVisualStyleBackColor = true;
            this.bt_available.Click += new System.EventHandler(this.bt_available_Click);
            // 
            // bt_getbyGroup
            // 
            this.bt_getbyGroup.Image = global::IndentifiedFace.Properties.Resources.user_groups_25px;
            this.bt_getbyGroup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_getbyGroup.Location = new System.Drawing.Point(35, 283);
            this.bt_getbyGroup.Name = "bt_getbyGroup";
            this.bt_getbyGroup.Size = new System.Drawing.Size(204, 36);
            this.bt_getbyGroup.TabIndex = 12;
            this.bt_getbyGroup.Text = "By Department";
            this.bt_getbyGroup.UseVisualStyleBackColor = true;
            // 
            // bt_getonebyone
            // 
            this.bt_getonebyone.Image = global::IndentifiedFace.Properties.Resources.find_user_male_25px;
            this.bt_getonebyone.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_getonebyone.Location = new System.Drawing.Point(35, 193);
            this.bt_getonebyone.Name = "bt_getonebyone";
            this.bt_getonebyone.Size = new System.Drawing.Size(204, 36);
            this.bt_getonebyone.TabIndex = 11;
            this.bt_getonebyone.Text = "     By Name Employee";
            this.bt_getonebyone.UseVisualStyleBackColor = true;
            this.bt_getonebyone.Click += new System.EventHandler(this.bt_getonebyone_Click);
            // 
            // bt_checkall
            // 
            this.bt_checkall.Image = global::IndentifiedFace.Properties.Resources.search_property_25px;
            this.bt_checkall.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_checkall.Location = new System.Drawing.Point(35, 90);
            this.bt_checkall.Name = "bt_checkall";
            this.bt_checkall.Size = new System.Drawing.Size(204, 36);
            this.bt_checkall.TabIndex = 10;
            this.bt_checkall.Text = "Find All";
            this.bt_checkall.UseVisualStyleBackColor = true;
            this.bt_checkall.Click += new System.EventHandler(this.bt_checkall_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(405, 80);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(450, 1);
            this.panel2.TabIndex = 16;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Location = new System.Drawing.Point(3, 418);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(896, 1);
            this.panel4.TabIndex = 16;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 428);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvDS);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.bt_available);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.cmbgetEmployee);
            this.Controls.Add(this.bt_getbyGroup);
            this.Controls.Add(this.dtpTo);
            this.Controls.Add(this.bt_getonebyone);
            this.Controls.Add(this.dtpFrom);
            this.Controls.Add(this.bt_checkall);
            this.Font = new System.Drawing.Font("Times New Roman", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thống kê";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        

        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbgetEmployee;
        private System.Windows.Forms.Button bt_checkall;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bt_getonebyone;
        private System.Windows.Forms.Button bt_getbyGroup;
        private System.Windows.Forms.Button bt_available;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.DataGridView dgvDS;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
    }
}