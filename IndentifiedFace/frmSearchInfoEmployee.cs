using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using IndentifiedFace.Configurations;

namespace IndentifiedFace
{
    public partial class frmSearchInfoEmployee : Form
    {
        public frmSearchInfoEmployee()
        {
            InitializeComponent();
        }

        public frmSearchInfoEmployee(Configuration appConfig)
        {
            applicationConfiguration = (AppConfig)appConfig;
            InitializeComponent();
            forceCustomReInitialize();
        }
        public AppConfig applicationConfiguration { get; set; }

        private void frmSearchInfoEmployee_Load(object sender, EventArgs e)
        {

        }

        private void btnwebcam_Click(object sender, EventArgs e)
        {

        }
    }
}
