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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_excel2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtListDiemDanh = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtShow = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbGroup = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBoxOutputDevice = new System.Windows.Forms.ComboBox();
            this.grvData2 = new System.Windows.Forms.DataGridView();
            this.grvdata3 = new System.Windows.Forms.DataGridView();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.imageBoxFrameGrabber = new Emgu.CV.UI.ImageBox();
            this.btnCamera = new System.Windows.Forms.Button();
            this.btnCallTheRoll = new System.Windows.Forms.Button();
            this.btn_excel1 = new System.Windows.Forms.Button();
            this.btnAddNewEmployee = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvData2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvdata3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBoxFrameGrabber)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(5, 5);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.imageBoxFrameGrabber);
            this.splitContainer1.Panel1.Controls.Add(this.panel2);
            this.splitContainer1.Panel1.Controls.Add(this.panel3);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btnCamera);
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Panel2.Controls.Add(this.btnCallTheRoll);
            this.splitContainer1.Panel2.Controls.Add(this.btn_excel2);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.btn_excel1);
            this.splitContainer1.Panel2.Controls.Add(this.btnAddNewEmployee);
            this.splitContainer1.Panel2.Controls.Add(this.btnexit);
            this.splitContainer1.Panel2.Controls.Add(this.txtListDiemDanh);
            this.splitContainer1.Panel2.Controls.Add(this.label7);
            this.splitContainer1.Panel2.Controls.Add(this.txtShow);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.cbGroup);
            this.splitContainer1.Panel2.Controls.Add(this.label10);
            this.splitContainer1.Panel2.Controls.Add(this.comboBoxOutputDevice);
            this.splitContainer1.Panel2.Controls.Add(this.grvData2);
            this.splitContainer1.Panel2.Controls.Add(this.grvdata3);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(1040, 429);
            this.splitContainer1.SplitterDistance = 362;
            this.splitContainer1.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 21);
            this.label5.TabIndex = 5;
            this.label5.Text = "Face Employee:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(12, 46);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(180, 1);
            this.panel3.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Face Recognition";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(22, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(140, 1);
            this.panel1.TabIndex = 6;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btn_excel2
            // 
            this.btn_excel2.Image = global::IndentifiedFace.Properties.Resources.microsoft_excel_2019_25px1;
            this.btn_excel2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_excel2.Location = new System.Drawing.Point(404, 279);
            this.btn_excel2.Name = "btn_excel2";
            this.btn_excel2.Size = new System.Drawing.Size(172, 29);
            this.btn_excel2.TabIndex = 6;
            this.btn_excel2.Text = "        Export File Excel";
            this.btn_excel2.UseVisualStyleBackColor = true;
            this.btn_excel2.Click += new System.EventHandler(this.btn_excel2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 254);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "Employee Present:";
            // 
            // txtListDiemDanh
            // 
            this.txtListDiemDanh.AutoSize = true;
            this.txtListDiemDanh.Location = new System.Drawing.Point(135, 254);
            this.txtListDiemDanh.Name = "txtListDiemDanh";
            this.txtListDiemDanh.Size = new System.Drawing.Size(14, 15);
            this.txtListDiemDanh.TabIndex = 9;
            this.txtListDiemDanh.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(348, 254);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 15);
            this.label7.TabIndex = 11;
            this.label7.Text = "Employee Absent:";
            // 
            // txtShow
            // 
            this.txtShow.AutoSize = true;
            this.txtShow.Location = new System.Drawing.Point(456, 254);
            this.txtShow.Name = "txtShow";
            this.txtShow.Size = new System.Drawing.Size(14, 15);
            this.txtShow.TabIndex = 9;
            this.txtShow.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 22);
            this.label4.TabIndex = 5;
            this.label4.Text = "Attendance";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Department:";
            // 
            // cbGroup
            // 
            this.cbGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGroup.Location = new System.Drawing.Point(100, 63);
            this.cbGroup.Name = "cbGroup";
            this.cbGroup.Size = new System.Drawing.Size(104, 23);
            this.cbGroup.TabIndex = 12;
            this.cbGroup.SelectedIndexChanged += new System.EventHandler(this.cbGroup_SelectedIndexChanged_1);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(234, 71);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 15);
            this.label10.TabIndex = 12;
            this.label10.Text = "Device";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBoxOutputDevice
            // 
            this.comboBoxOutputDevice.FormattingEnabled = true;
            this.comboBoxOutputDevice.Location = new System.Drawing.Point(283, 63);
            this.comboBoxOutputDevice.Name = "comboBoxOutputDevice";
            this.comboBoxOutputDevice.Size = new System.Drawing.Size(121, 23);
            this.comboBoxOutputDevice.TabIndex = 11;
            this.comboBoxOutputDevice.SelectedIndexChanged += new System.EventHandler(this.comboBoxOutputDevice_SelectedIndexChanged);
            // 
            // grvData2
            // 
            this.grvData2.BackgroundColor = System.Drawing.Color.LightGray;
            this.grvData2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvData2.Location = new System.Drawing.Point(10, 106);
            this.grvData2.Name = "grvData2";
            this.grvData2.Size = new System.Drawing.Size(323, 141);
            this.grvData2.TabIndex = 4;
            this.grvData2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvData2_CellContentClick);
            // 
            // grvdata3
            // 
            this.grvdata3.BackgroundColor = System.Drawing.Color.LightGray;
            this.grvdata3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvdata3.Location = new System.Drawing.Point(341, 106);
            this.grvdata3.Name = "grvdata3";
            this.grvdata3.Size = new System.Drawing.Size(323, 141);
            this.grvdata3.TabIndex = 4;
            this.grvdata3.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvdata3_CellContentClick);
            // 
            // imageBoxFrameGrabber
            // 
            this.imageBoxFrameGrabber.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("imageBoxFrameGrabber.BackgroundImage")));
            this.imageBoxFrameGrabber.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.imageBoxFrameGrabber.Location = new System.Drawing.Point(12, 120);
            this.imageBoxFrameGrabber.Name = "imageBoxFrameGrabber";
            this.imageBoxFrameGrabber.Size = new System.Drawing.Size(340, 263);
            this.imageBoxFrameGrabber.TabIndex = 2;
            this.imageBoxFrameGrabber.TabStop = false;
            // 
            // btnCamera
            // 
            this.btnCamera.ForeColor = System.Drawing.Color.Blue;
            this.btnCamera.Image = global::IndentifiedFace.Properties.Resources.camera_30_1px;
            this.btnCamera.Location = new System.Drawing.Point(136, 358);
            this.btnCamera.Name = "btnCamera";
            this.btnCamera.Size = new System.Drawing.Size(84, 48);
            this.btnCamera.TabIndex = 3;
            this.toolTip1.SetToolTip(this.btnCamera, "Open Camera");
            this.btnCamera.UseVisualStyleBackColor = true;
            this.btnCamera.Click += new System.EventHandler(this.btnCamera_Click);
            // 
            // btnCallTheRoll
            // 
            this.btnCallTheRoll.ForeColor = System.Drawing.Color.Blue;
            this.btnCallTheRoll.Image = global::IndentifiedFace.Properties.Resources.attendance_30px;
            this.btnCallTheRoll.Location = new System.Drawing.Point(249, 358);
            this.btnCallTheRoll.Name = "btnCallTheRoll";
            this.btnCallTheRoll.Size = new System.Drawing.Size(84, 48);
            this.btnCallTheRoll.TabIndex = 4;
            this.toolTip1.SetToolTip(this.btnCallTheRoll, "Attendance");
            this.btnCallTheRoll.UseVisualStyleBackColor = true;
            this.btnCallTheRoll.Click += new System.EventHandler(this.btnCallTheRoll_Click);
            // 
            // btn_excel1
            // 
            this.btn_excel1.Image = global::IndentifiedFace.Properties.Resources.microsoft_excel_2019_25px1;
            this.btn_excel1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_excel1.Location = new System.Drawing.Point(74, 279);
            this.btn_excel1.Name = "btn_excel1";
            this.btn_excel1.Size = new System.Drawing.Size(172, 29);
            this.btn_excel1.TabIndex = 6;
            this.btn_excel1.Text = "        Export File Excel";
            this.btn_excel1.UseVisualStyleBackColor = true;
            this.btn_excel1.Click += new System.EventHandler(this.btn_excel1_Click);
            // 
            // btnAddNewEmployee
            // 
            this.btnAddNewEmployee.ForeColor = System.Drawing.Color.Blue;
            this.btnAddNewEmployee.Image = global::IndentifiedFace.Properties.Resources.add_user_group_woman_man_30px;
            this.btnAddNewEmployee.Location = new System.Drawing.Point(358, 358);
            this.btnAddNewEmployee.Name = "btnAddNewEmployee";
            this.btnAddNewEmployee.Size = new System.Drawing.Size(84, 48);
            this.btnAddNewEmployee.TabIndex = 6;
            this.toolTip1.SetToolTip(this.btnAddNewEmployee, "Add Employee");
            this.btnAddNewEmployee.UseVisualStyleBackColor = true;
            this.btnAddNewEmployee.Click += new System.EventHandler(this.btnAddNewEmployee_Click);
            // 
            // btnexit
            // 
            this.btnexit.ForeColor = System.Drawing.Color.Red;
            this.btnexit.Image = global::IndentifiedFace.Properties.Resources.x_30px;
            this.btnexit.Location = new System.Drawing.Point(469, 358);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(84, 48);
            this.btnexit.TabIndex = 5;
            this.toolTip1.SetToolTip(this.btnexit, "Close");
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(358, 17);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1, 400);
            this.panel2.TabIndex = 4;
            // 
            // frmTimekeeping
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1050, 439);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTimekeeping";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Making Timekeeping";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmTimekeeping_FormClosed);
            this.Load += new System.EventHandler(this.frmTimekeeping_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grvData2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvdata3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBoxFrameGrabber)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private void forceCustomReInitialize()
        {
            LanguagePackage langPack = applicationConfiguration.getLanguagePackage();

            //
            this.btnAddNewEmployee.Text = langPack.getAddMembersButtonLabel();
            this.btnexit.Text = langPack.getQuitButtonTitle();
            this.btnCallTheRoll.Text = langPack.getMakingRollCallButtonLabel();
            this.btnCamera.Text = langPack.getCameraActionButtonLabel();
           /* this.groupBox1.Text = langPack.getMemeberInfoBlockTitle();
            this.label6.Text = langPack.getBirthAlias();
            this.label5.Text = langPack.getSexAlias();
            this.label4.Text = langPack.getClassAlias();
            this.label3.Text = langPack.getFirstNameAlias();
            this.label8.Text = langPack.getMemberCodeAlias();
            this.label9.Text = langPack.getLastNameAlias();*/
            this.label2.Text = langPack.getMembersAlreadyMakingRollCallTitle();
            this.label7.Text = langPack.getMembersNotMakingRollCallYetTitle();
            
            this.label1.Text = langPack.getClassAlias();
            this.label10.Text = langPack.getOutputDeviceSelectionTitle();
            this.Text = langPack.getMakingRollCallFormTitle();
        }
        private System.Windows.Forms.Button btnCallTheRoll;
        private System.Windows.Forms.Button btnCamera;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnAddNewEmployee;
        private Emgu.CV.UI.ImageBox imageBoxFrameGrabber;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_excel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txtListDiemDanh;
        private System.Windows.Forms.DataGridView grvData2;
        private System.Windows.Forms.Button btn_excel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label txtShow;
        private System.Windows.Forms.DataGridView grvdata3;
        private System.Windows.Forms.ComboBox cbGroup;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBoxOutputDevice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panel2;
    }
}