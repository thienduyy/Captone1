namespace IndentifiedFace
{
    partial class frmCheck
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
            this.digitalClockCtrl1 = new SriClocks.DigitalClockCtrl();
            this.btn_check = new System.Windows.Forms.Button();
            this.txt_s = new System.Windows.Forms.TextBox();
            this.grvData2 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tDatetime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_check = new System.Windows.Forms.TextBox();
            this.btn_s = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtGioitinh = new System.Windows.Forms.TextBox();
            this.txtLop = new System.Windows.Forms.TextBox();
            this.dpBirth = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtHo = new System.Windows.Forms.TextBox();
            this.txtmasv = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grvData2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // digitalClockCtrl1
            // 
            this.digitalClockCtrl1.BackColor = System.Drawing.Color.Black;
            this.digitalClockCtrl1.CountDownTime = 10000;
            this.digitalClockCtrl1.Location = new System.Drawing.Point(1, 41);
            this.digitalClockCtrl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.digitalClockCtrl1.Name = "digitalClockCtrl1";
            this.digitalClockCtrl1.SetClockType = SriClocks.ClockType.DigitalClock;
            this.digitalClockCtrl1.Size = new System.Drawing.Size(483, 44);
            this.digitalClockCtrl1.TabIndex = 0;
            // 
            // btn_check
            // 
            this.btn_check.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_check.Location = new System.Drawing.Point(744, 85);
            this.btn_check.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_check.Name = "btn_check";
            this.btn_check.Size = new System.Drawing.Size(236, 288);
            this.btn_check.TabIndex = 1;
            this.btn_check.Text = "Enter Your Pin";
            this.btn_check.UseVisualStyleBackColor = true;
            this.btn_check.Click += new System.EventHandler(this.btn_check_Click);
            // 
            // txt_s
            // 
            this.txt_s.Location = new System.Drawing.Point(1, 10);
            this.txt_s.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_s.Name = "txt_s";
            this.txt_s.Size = new System.Drawing.Size(291, 22);
            this.txt_s.TabIndex = 2;
            this.txt_s.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // grvData2
            // 
            this.grvData2.BackgroundColor = System.Drawing.Color.LightGray;
            this.grvData2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvData2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.tDatetime,
            this.Note});
            this.grvData2.Location = new System.Drawing.Point(1, 379);
            this.grvData2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grvData2.Name = "grvData2";
            this.grvData2.Size = new System.Drawing.Size(483, 190);
            this.grvData2.TabIndex = 5;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "Number";
            this.ID.Name = "ID";
            // 
            // tDatetime
            // 
            this.tDatetime.DataPropertyName = "tDatetime";
            this.tDatetime.HeaderText = "DateTime";
            this.tDatetime.Name = "tDatetime";
            // 
            // Note
            // 
            this.Note.DataPropertyName = "Note";
            this.Note.HeaderText = "Note";
            this.Note.Name = "Note";
            // 
            // txt_check
            // 
            this.txt_check.Location = new System.Drawing.Point(744, 53);
            this.txt_check.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_check.Name = "txt_check";
            this.txt_check.Size = new System.Drawing.Size(235, 22);
            this.txt_check.TabIndex = 6;
            // 
            // btn_s
            // 
            this.btn_s.Location = new System.Drawing.Point(312, 4);
            this.btn_s.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_s.Name = "btn_s";
            this.btn_s.Size = new System.Drawing.Size(172, 36);
            this.btn_s.TabIndex = 1;
            this.btn_s.Text = "OK";
            this.btn_s.UseVisualStyleBackColor = true;
            this.btn_s.Click += new System.EventHandler(this.btn_s_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 358);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Chi tiết các lần điểm danh";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtGioitinh);
            this.groupBox1.Controls.Add(this.txtLop);
            this.groupBox1.Controls.Add(this.dpBirth);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtTen);
            this.groupBox1.Controls.Add(this.txtHo);
            this.groupBox1.Controls.Add(this.txtmasv);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(1, 85);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(483, 266);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin nhân viên";
            // 
            // txtGioitinh
            // 
            this.txtGioitinh.Enabled = false;
            this.txtGioitinh.Location = new System.Drawing.Point(203, 185);
            this.txtGioitinh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtGioitinh.Name = "txtGioitinh";
            this.txtGioitinh.Size = new System.Drawing.Size(148, 29);
            this.txtGioitinh.TabIndex = 10;
            // 
            // txtLop
            // 
            this.txtLop.Enabled = false;
            this.txtLop.Location = new System.Drawing.Point(203, 150);
            this.txtLop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtLop.Name = "txtLop";
            this.txtLop.Size = new System.Drawing.Size(148, 29);
            this.txtLop.TabIndex = 9;
            // 
            // dpBirth
            // 
            this.dpBirth.Enabled = false;
            this.dpBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpBirth.Location = new System.Drawing.Point(203, 226);
            this.dpBirth.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dpBirth.Name = "dpBirth";
            this.dpBirth.Size = new System.Drawing.Size(148, 29);
            this.dpBirth.TabIndex = 3;
            this.dpBirth.Value = new System.DateTime(1987, 9, 20, 0, 0, 0, 0);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 235);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 22);
            this.label6.TabIndex = 2;
            this.label6.Text = "Ngày sinh: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 193);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 22);
            this.label5.TabIndex = 2;
            this.label5.Text = "Giới tính: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 159);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 22);
            this.label4.TabIndex = 2;
            this.label4.Text = "Phòng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 122);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 39);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 22);
            this.label8.TabIndex = 2;
            this.label8.Text = "Mã nhân viên";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 80);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 22);
            this.label9.TabIndex = 2;
            this.label9.Text = "Họ: ";
            // 
            // txtTen
            // 
            this.txtTen.Enabled = false;
            this.txtTen.Location = new System.Drawing.Point(203, 113);
            this.txtTen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(148, 29);
            this.txtTen.TabIndex = 1;
            // 
            // txtHo
            // 
            this.txtHo.Enabled = false;
            this.txtHo.Location = new System.Drawing.Point(203, 71);
            this.txtHo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtHo.Name = "txtHo";
            this.txtHo.Size = new System.Drawing.Size(148, 29);
            this.txtHo.TabIndex = 1;
            // 
            // txtmasv
            // 
            this.txtmasv.Enabled = false;
            this.txtmasv.Location = new System.Drawing.Point(203, 31);
            this.txtmasv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtmasv.Name = "txtmasv";
            this.txtmasv.Size = new System.Drawing.Size(148, 29);
            this.txtmasv.TabIndex = 1;
            // 
            // frmCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 571);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_check);
            this.Controls.Add(this.grvData2);
            this.Controls.Add(this.txt_s);
            this.Controls.Add(this.btn_s);
            this.Controls.Add(this.btn_check);
            this.Controls.Add(this.digitalClockCtrl1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmCheck";
            this.Text = "Check";
            ((System.ComponentModel.ISupportInitialize)(this.grvData2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SriClocks.DigitalClockCtrl digitalClockCtrl1;
        private System.Windows.Forms.Button btn_check;
        private System.Windows.Forms.TextBox txt_s;
        private System.Windows.Forms.DataGridView grvData2;
        private System.Windows.Forms.TextBox txt_check;
        private System.Windows.Forms.Button btn_s;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtGioitinh;
        private System.Windows.Forms.TextBox txtLop;
        private System.Windows.Forms.DateTimePicker dpBirth;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtHo;
        private System.Windows.Forms.TextBox txtmasv;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn tDatetime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Note;
    }
}