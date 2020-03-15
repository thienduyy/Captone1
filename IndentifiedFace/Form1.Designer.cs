
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbgetEmployee = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvDS = new System.Windows.Forms.DataGridView();
            this.bt_checkall = new System.Windows.Forms.Button();
            this.bt_getonebyone = new System.Windows.Forms.Button();
            this.bt_getbyGroup = new System.Windows.Forms.Button();
            this.bt_available = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDS)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpTo
            // 
            this.dtpTo.CustomFormat = "dd/MM/yyyy";
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTo.Location = new System.Drawing.Point(243, 20);
            this.dtpTo.Margin = new System.Windows.Forms.Padding(4);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(148, 25);
            this.dtpTo.TabIndex = 4;
            this.dtpTo.Value = new System.DateTime(2015, 1, 2, 0, 0, 0, 0);
            this.dtpTo.ValueChanged += new System.EventHandler(this.dtpTo_ValueChanged);
            // 
            // dtpFrom
            // 
            this.dtpFrom.CustomFormat = "dd/MM/yyyy";
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFrom.Location = new System.Drawing.Point(57, 19);
            this.dtpFrom.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(148, 25);
            this.dtpFrom.TabIndex = 5;
            this.dtpFrom.Value = new System.DateTime(2015, 1, 1, 0, 0, 0, 0);
            this.dtpFrom.ValueChanged += new System.EventHandler(this.dtpFrom_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cmbgetEmployee);
            this.groupBox1.Controls.Add(this.dtpTo);
            this.groupBox1.Controls.Add(this.dtpFrom);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(971, 56);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(417, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 19);
            this.label2.TabIndex = 10;
            this.label2.Text = "Nhân viên: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(213, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 19);
            this.label1.TabIndex = 8;
            this.label1.Text = "to";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 11.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(5, 24);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 19);
            this.label6.TabIndex = 7;
            this.label6.Text = "From";
            // 
            // cmbgetEmployee
            // 
            this.cmbgetEmployee.FormattingEnabled = true;
            this.cmbgetEmployee.Location = new System.Drawing.Point(524, 23);
            this.cmbgetEmployee.Name = "cmbgetEmployee";
            this.cmbgetEmployee.Size = new System.Drawing.Size(202, 25);
            this.cmbgetEmployee.TabIndex = 9;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox2.Controls.Add(this.dgvDS);
            this.groupBox2.Location = new System.Drawing.Point(0, 56);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(726, 415);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "List";
            // 
            // dgvDS
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDS.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDS.ColumnHeadersHeight = 25;
            this.dgvDS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDS.Location = new System.Drawing.Point(4, 22);
            this.dgvDS.Name = "dgvDS";
            this.dgvDS.ReadOnly = true;
            this.dgvDS.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dgvDS.Size = new System.Drawing.Size(718, 389);
            this.dgvDS.TabIndex = 0;
            this.dgvDS.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDS_CellContentClick);
            // 
            // bt_checkall
            // 
            this.bt_checkall.Location = new System.Drawing.Point(755, 83);
            this.bt_checkall.Name = "bt_checkall";
            this.bt_checkall.Size = new System.Drawing.Size(204, 62);
            this.bt_checkall.TabIndex = 10;
            this.bt_checkall.Text = "Xem tất cả";
            this.bt_checkall.UseVisualStyleBackColor = true;
            this.bt_checkall.Click += new System.EventHandler(this.bt_checkall_Click);
            // 
            // bt_getonebyone
            // 
            this.bt_getonebyone.Location = new System.Drawing.Point(755, 178);
            this.bt_getonebyone.Name = "bt_getonebyone";
            this.bt_getonebyone.Size = new System.Drawing.Size(204, 62);
            this.bt_getonebyone.TabIndex = 11;
            this.bt_getonebyone.Text = "Xem theo tên NV";
            this.bt_getonebyone.UseVisualStyleBackColor = true;
            this.bt_getonebyone.Click += new System.EventHandler(this.bt_getonebyone_Click);
            // 
            // bt_getbyGroup
            // 
            this.bt_getbyGroup.Location = new System.Drawing.Point(755, 275);
            this.bt_getbyGroup.Name = "bt_getbyGroup";
            this.bt_getbyGroup.Size = new System.Drawing.Size(204, 62);
            this.bt_getbyGroup.TabIndex = 12;
            this.bt_getbyGroup.Text = "Xem theo phòng (demo)";
            this.bt_getbyGroup.UseVisualStyleBackColor = true;
            // 
            // bt_available
            // 
            this.bt_available.Location = new System.Drawing.Point(755, 368);
            this.bt_available.Name = "bt_available";
            this.bt_available.Size = new System.Drawing.Size(204, 62);
            this.bt_available.TabIndex = 13;
            this.bt_available.Text = "Thống kê số lần có mặt";
            this.bt_available.UseVisualStyleBackColor = true;
            this.bt_available.Click += new System.EventHandler(this.bt_available_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 503);
            this.Controls.Add(this.bt_available);
            this.Controls.Add(this.bt_getbyGroup);
            this.Controls.Add(this.bt_getonebyone);
            this.Controls.Add(this.bt_checkall);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thống kê";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        

        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDS;
        private System.Windows.Forms.ComboBox cmbgetEmployee;
        protected System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bt_checkall;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bt_getonebyone;
        private System.Windows.Forms.Button bt_getbyGroup;
        private System.Windows.Forms.Button bt_available;
    }
}