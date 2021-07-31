using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cryptool
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {

            InitializeComponent();
            // window size
            this.MaximumSize = new System.Drawing.Size(1153, 525);
            this.MinimumSize = new System.Drawing.Size(1153, 525);
            //default lad Self-Signed certificate
            panelControl2.Controls.Clear();
            GenerateSignedCert newCert = new GenerateSignedCert();
            newCert.TopLevel = false;
            panelControl2.Controls.Add(newCert);
            newCert.Show();
        }

        private void sidePanel1_Click(object sender, EventArgs e)
        {

        }
        
        //Load from Self Signed certificate to panel 
        private void simpleButton1_Click(object sender, EventArgs e)
        {


            panelControl2.Controls.Clear();
            GenerateSignedCert newCert = new GenerateSignedCert();
            newCert.TopLevel = false;
            panelControl2.Controls.Add(newCert);
            newCert.Show();

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        //Load Signed Certificate
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            
            panelControl2.Controls.Clear();
            GenSignedCert newCert = new GenSignedCert();
            newCert.TopLevel = false; 
            panelControl2.Controls.Add(newCert);
            newCert.Show();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {

        }


        private void panelControl2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {

        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }
    }
}
