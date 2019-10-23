using IndentifiedFace.Configurations;
namespace IndentifiedFace
{
    partial class frmTimekeeping
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTimekeeping));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.imageBoxFrameGrabber = new Emgu.CV.UI.ImageBox();
            this.btnexit = new System.Windows.Forms.Button();
            this.btnCallTheRoll = new System.Windows.Forms.Button();
            this.btnCamera = new System.Windows.Forms.Button();
            this.grvdata = new System.Windows.Forms.DataGridView();
            this.grvData2 = new System.Windows.Forms.DataGridView();
            this.txtShow = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtGioitinh = new System.Windows.Forms.TextBox();
            this.txtPhong = new System.Windows.Forms.TextBox();
            this.dpBirth = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtHo = new System.Windows.Forms.TextBox();
            this.txtmanv = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBoxOutputDevice = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.grvdata3 = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.btn_excel1 = new System.Windows.Forms.Button();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.txtListDiemDanh = new System.Windows.Forms.Label();
            this.btn_excel2 = new System.Windows.Forms.Button();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cbGroup = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAddNewEmployee = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBoxFrameGrabber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvdata)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvData2)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvdata3)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.imageBoxFrameGrabber);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(362, 277);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nhận dạng khuôn mặt";
            // 
            // imageBoxFrameGrabber
            // 
            this.imageBoxFrameGrabber.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("imageBoxFrameGrabber.BackgroundImage")));
            this.imageBoxFrameGrabber.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.imageBoxFrameGrabber.Dock = System.Windows.Forms.DockStyle.Top;
            this.imageBoxFrameGrabber.Location = new System.Drawing.Point(3, 18);
            this.imageBoxFrameGrabber.Name = "imageBoxFrameGrabber";
            this.imageBoxFrameGrabber.Size = new System.Drawing.Size(356, 243);
            this.imageBoxFrameGrabber.TabIndex = 2;
            this.imageBoxFrameGrabber.TabStop = false;
            // 
            // btnexit
            // 
            this.btnexit.ForeColor = System.Drawing.Color.Red;
            this.btnexit.Location = new System.Drawing.Point(270, 3);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(83, 29);
            this.btnexit.TabIndex = 5;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btnCallTheRoll
            // 
            this.btnCallTheRoll.ForeColor = System.Drawing.Color.Blue;
            this.btnCallTheRoll.Location = new System.Drawing.Point(92, 3);
            this.btnCallTheRoll.Name = "btnCallTheRoll";
            this.btnCallTheRoll.Size = new System.Drawing.Size(83, 29);
            this.btnCallTheRoll.TabIndex = 4;
            this.btnCallTheRoll.Text = "Điểm danh";
            this.btnCallTheRoll.UseVisualStyleBackColor = true;
            this.btnCallTheRoll.Click += new System.EventHandler(this.btnCallTheRoll_Click);
            // 
            // btnCamera
            // 
            this.btnCamera.ForeColor = System.Drawing.Color.Blue;
            this.btnCamera.Location = new System.Drawing.Point(3, 3);
            this.btnCamera.Name = "btnCamera";
            this.btnCamera.Size = new System.Drawing.Size(83, 29);
            this.btnCamera.TabIndex = 3;
            this.btnCamera.Text = "Camera";
            this.btnCamera.UseVisualStyleBackColor = true;
            this.btnCamera.Click += new System.EventHandler(this.btnCamera_Click);
            // 
            // grvdata
            // 
            this.grvdata.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.grvdata.BackgroundColor = System.Drawing.Color.LightGray;
            this.grvdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvdata.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grvdata.Location = new System.Drawing.Point(3, 338);
            this.grvdata.Name = "grvdata";
            this.grvdata.Size = new System.Drawing.Size(668, 281);
            this.grvdata.TabIndex = 4;
            // 
            // grvData2
            // 
            this.grvData2.BackgroundColor = System.Drawing.Color.LightGray;
            this.grvData2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvData2.Dock = System.Windows.Forms.DockStyle.Top;
            this.grvData2.Location = new System.Drawing.Point(0, 0);
            this.grvData2.Name = "grvData2";
            this.grvData2.Size = new System.Drawing.Size(307, 156);
            this.grvData2.TabIndex = 4;
            this.grvData2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvData2_CellContentClick);
            // 
            // txtShow
            // 
            this.txtShow.AutoSize = true;
            this.txtShow.Location = new System.Drawing.Point(195, 0);
            this.txtShow.Name = "txtShow";
            this.txtShow.Size = new System.Drawing.Size(14, 15);
            this.txtShow.TabIndex = 9;
            this.txtShow.Text = "0";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtGioitinh);
            this.groupBox1.Controls.Add(this.txtPhong);
            this.groupBox1.Controls.Add(this.dpBirth);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtTen);
            this.groupBox1.Controls.Add(this.txtHo);
            this.groupBox1.Controls.Add(this.txtmanv);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 277);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(362, 345);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin của nhân viên: ";
            // 
            // txtGioitinh
            // 
            this.txtGioitinh.Enabled = false;
            this.txtGioitinh.Location = new System.Drawing.Point(181, 186);
            this.txtGioitinh.Name = "txtGioitinh";
            this.txtGioitinh.Size = new System.Drawing.Size(112, 25);
            this.txtGioitinh.TabIndex = 10;
            // 
            // txtPhong
            // 
            this.txtPhong.Enabled = false;
            this.txtPhong.Location = new System.Drawing.Point(181, 158);
            this.txtPhong.Name = "txtPhong";
            this.txtPhong.Size = new System.Drawing.Size(112, 25);
            this.txtPhong.TabIndex = 9;
            // 
            // dpBirth
            // 
            this.dpBirth.CustomFormat = "dd/MM/yyyy";
            this.dpBirth.Enabled = false;
            this.dpBirth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpBirth.Location = new System.Drawing.Point(181, 220);
            this.dpBirth.Name = "dpBirth";
            this.dpBirth.Size = new System.Drawing.Size(112, 25);
            this.dpBirth.TabIndex = 3;
            this.dpBirth.Value = new System.DateTime(1987, 12, 20, 0, 0, 0, 0);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(44, 227);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "Ngày sinh: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Giới tính: ";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Phòng: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(44, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 17);
            this.label8.TabIndex = 2;
            this.label8.Text = "Mã nhân viên: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(44, 101);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 17);
            this.label9.TabIndex = 2;
            this.label9.Text = "Họ: ";
            // 
            // txtTen
            // 
            this.txtTen.Enabled = false;
            this.txtTen.Location = new System.Drawing.Point(181, 128);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(112, 25);
            this.txtTen.TabIndex = 1;
            // 
            // txtHo
            // 
            this.txtHo.Enabled = false;
            this.txtHo.Location = new System.Drawing.Point(181, 94);
            this.txtHo.Name = "txtHo";
            this.txtHo.Size = new System.Drawing.Size(112, 25);
            this.txtHo.TabIndex = 1;
            // 
            // txtmanv
            // 
            this.txtmanv.Enabled = false;
            this.txtmanv.Location = new System.Drawing.Point(181, 61);
            this.txtmanv.Name = "txtmanv";
            this.txtmanv.Size = new System.Drawing.Size(112, 25);
            this.txtmanv.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(59, 3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 15);
            this.label10.TabIndex = 12;
            this.label10.Text = "Thiết bị đầu ra";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBoxOutputDevice
            // 
            this.comboBoxOutputDevice.FormattingEnabled = true;
            this.comboBoxOutputDevice.Location = new System.Drawing.Point(303, 3);
            this.comboBoxOutputDevice.Name = "comboBoxOutputDevice";
            this.comboBoxOutputDevice.Size = new System.Drawing.Size(121, 23);
            this.comboBoxOutputDevice.TabIndex = 11;
            this.comboBoxOutputDevice.SelectedIndexChanged += new System.EventHandler(this.comboBoxOutputDevice_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "Nhân viên đã điểm danh: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(186, 15);
            this.label7.TabIndex = 11;
            this.label7.Text = "Nhân viên chưa được điểm danh: ";
            // 
            // grvdata3
            // 
            this.grvdata3.BackgroundColor = System.Drawing.Color.LightGray;
            this.grvdata3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvdata3.Dock = System.Windows.Forms.DockStyle.Top;
            this.grvdata3.Location = new System.Drawing.Point(0, 0);
            this.grvdata3.Name = "grvdata3";
            this.grvdata3.Size = new System.Drawing.Size(357, 156);
            this.grvdata3.TabIndex = 4;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.splitContainer2);
            this.groupBox3.Controls.Add(this.grvdata);
            this.groupBox3.Controls.Add(this.flowLayoutPanel2);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(674, 622);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thao tác: ";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(3, 51);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.btn_excel1);
            this.splitContainer2.Panel1.Controls.Add(this.flowLayoutPanel4);
            this.splitContainer2.Panel1.Controls.Add(this.grvData2);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.btn_excel2);
            this.splitContainer2.Panel2.Controls.Add(this.flowLayoutPanel3);
            this.splitContainer2.Panel2.Controls.Add(this.grvdata3);
            this.splitContainer2.Size = new System.Drawing.Size(668, 287);
            this.splitContainer2.SplitterDistance = 307;
            this.splitContainer2.TabIndex = 14;
            // 
            // btn_excel1
            // 
            this.btn_excel1.Location = new System.Drawing.Point(6, 182);
            this.btn_excel1.Name = "btn_excel1";
            this.btn_excel1.Size = new System.Drawing.Size(301, 29);
            this.btn_excel1.TabIndex = 6;
            this.btn_excel1.Text = "Xuất file Excel";
            this.btn_excel1.UseVisualStyleBackColor = true;
            this.btn_excel1.Click += new System.EventHandler(this.btn_excel1_Click);
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Controls.Add(this.label2);
            this.flowLayoutPanel4.Controls.Add(this.txtListDiemDanh);
            this.flowLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(0, 156);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(307, 15);
            this.flowLayoutPanel4.TabIndex = 5;
            // 
            // txtListDiemDanh
            // 
            this.txtListDiemDanh.AutoSize = true;
            this.txtListDiemDanh.Location = new System.Drawing.Point(150, 0);
            this.txtListDiemDanh.Name = "txtListDiemDanh";
            this.txtListDiemDanh.Size = new System.Drawing.Size(14, 15);
            this.txtListDiemDanh.TabIndex = 9;
            this.txtListDiemDanh.Text = "0";
            // 
            // btn_excel2
            // 
            this.btn_excel2.Location = new System.Drawing.Point(3, 181);
            this.btn_excel2.Name = "btn_excel2";
            this.btn_excel2.Size = new System.Drawing.Size(354, 29);
            this.btn_excel2.TabIndex = 6;
            this.btn_excel2.Text = "Xuất file Excel";
            this.btn_excel2.UseVisualStyleBackColor = true;
            this.btn_excel2.Click += new System.EventHandler(this.btn_excel2_Click);
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.label7);
            this.flowLayoutPanel3.Controls.Add(this.txtShow);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(0, 156);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(357, 15);
            this.flowLayoutPanel3.TabIndex = 12;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.panel1);
            this.flowLayoutPanel2.Controls.Add(this.cbGroup);
            this.flowLayoutPanel2.Controls.Add(this.panel2);
            this.flowLayoutPanel2.Controls.Add(this.comboBoxOutputDevice);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 18);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(668, 33);
            this.flowLayoutPanel2.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(63, 23);
            this.panel1.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Phòng: ";
            // 
            // cbGroup
            // 
            this.cbGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGroup.Location = new System.Drawing.Point(72, 3);
            this.cbGroup.Name = "cbGroup";
            this.cbGroup.Size = new System.Drawing.Size(73, 23);
            this.cbGroup.TabIndex = 12;
            this.cbGroup.SelectedIndexChanged += new System.EventHandler(this.cbGroup_SelectedIndexChanged_1);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label10);
            this.panel2.Location = new System.Drawing.Point(151, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(146, 23);
            this.panel2.TabIndex = 14;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(5, 5);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.flowLayoutPanel1);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox3);
            this.splitContainer1.Size = new System.Drawing.Size(1040, 622);
            this.splitContainer1.SplitterDistance = 362;
            this.splitContainer1.TabIndex = 13;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnCamera);
            this.flowLayoutPanel1.Controls.Add(this.btnCallTheRoll);
            this.flowLayoutPanel1.Controls.Add(this.btnAddNewEmployee);
            this.flowLayoutPanel1.Controls.Add(this.btnexit);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 585);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(362, 37);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // btnAddNewEmployee
            // 
            this.btnAddNewEmployee.ForeColor = System.Drawing.Color.Blue;
            this.btnAddNewEmployee.Location = new System.Drawing.Point(181, 3);
            this.btnAddNewEmployee.Name = "btnAddNewEmployee";
            this.btnAddNewEmployee.Size = new System.Drawing.Size(83, 29);
            this.btnAddNewEmployee.TabIndex = 6;
            this.btnAddNewEmployee.Text = "Thêm: ";
            this.btnAddNewEmployee.UseVisualStyleBackColor = true;
            this.btnAddNewEmployee.Click += new System.EventHandler(this.btnAddNewEmployee_Click);
            // 
            // frmTimekeeping
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1050, 632);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTimekeeping";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Text = "Making Timekeeping";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmTimekeeping_FormClosed);
            this.Load += new System.EventHandler(this.frmTimekeeping_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imageBoxFrameGrabber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvdata)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvData2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvdata3)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private void forceCustomReInitialize()
        {
            LanguagePackage langPack = applicationConfiguration.getLanguagePackage();

            this.groupBox2.Text = langPack.getFaceDetectingBlockTitle();
            this.btnAddNewEmployee.Text = langPack.getAddMembersButtonLabel();
            this.btnexit.Text = langPack.getQuitButtonTitle();
            this.btnCallTheRoll.Text = langPack.getMakingRollCallButtonLabel();
            this.btnCamera.Text = langPack.getCameraActionButtonLabel();
            this.groupBox1.Text = langPack.getMemeberInfoBlockTitle();
            this.label6.Text = langPack.getBirthAlias();
            this.label5.Text = langPack.getSexAlias();
            this.label4.Text = langPack.getClassAlias();
            this.label3.Text = langPack.getFirstNameAlias();
            this.label8.Text = langPack.getMemberCodeAlias();
            this.label9.Text = langPack.getLastNameAlias();
            this.label2.Text = langPack.getMembersAlreadyMakingRollCallTitle();
            this.label7.Text = langPack.getMembersNotMakingRollCallYetTitle();
            this.groupBox3.Text = langPack.getMakingRollCallOperationsBlockTitle();
            this.label1.Text = langPack.getClassAlias();
            this.label10.Text = langPack.getOutputDeviceSelectionTitle();
            this.Text = langPack.getMakingRollCallFormTitle();
        }

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCallTheRoll;
        private System.Windows.Forms.Button btnCamera;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.DataGridView grvdata;
        private Emgu.CV.UI.ImageBox imageBoxFrameGrabber;
        private System.Windows.Forms.DataGridView grvData2;
        private System.Windows.Forms.Label txtShow;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dpBirth;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtHo;
        private System.Windows.Forms.TextBox txtmanv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView grvdata3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label txtListDiemDanh;
        private System.Windows.Forms.ComboBox cbGroup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPhong;
        private System.Windows.Forms.TextBox txtGioitinh;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBoxOutputDevice;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.Button btnAddNewEmployee;
        private System.Windows.Forms.Button btn_excel1;
        private System.Windows.Forms.Button btn_excel2;
     
    }
}