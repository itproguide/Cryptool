using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cryptool
{
    public partial class GenSignedCert : Form
    {
        public GenSignedCert()
        {
            InitializeComponent();
        }

        private void GenSignedCert_Load(object sender, EventArgs e)
        {

        }

        //Store CA Certificate to system
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            string[] certDetails = new string[5];
            GenCASignedCert newCertGen = new GenCASignedCert();
            string pfxPass = pfxPassword.Text;
            certDetails = newCertGen.saveCAtoStore(StoreSelected.SelectedText, Location.Text, pfxPass);
            dispThump.Text = certDetails[1];
            displayDate.Text = certDetails[2];
            disLocation.Text = certDetails[3];
            DispDNName.Text = certDetails[0];
            caThumbprint.Text = certDetails[1];
            caStore.Text = StoreSelected.SelectedText;



        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        //Load Certificate in pfx format
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog1 = new OpenFileDialog()) 
            {
                openFileDialog1.InitialDirectory = @"C:\";
                openFileDialog1.Title = "Browse Root CA in Pfx";
                openFileDialog1.DefaultExt = "pfx";
                openFileDialog1.Filter = "pfx files(*.pfx) | *.pfx";
                openFileDialog1.ShowDialog();
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    Location.Text = openFileDialog1.FileName;
                }

            }
           
        }

        private void Location_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void labelControl9_Click(object sender, EventArgs e)
        {

        }

        // Download a signed certificate
        private void saveCert_Click(object sender, EventArgs e)
        {
            // Initialise byte array for Generated certificate
            byte[] _certData;
            // variable Store user preference 
            string _path;
            // Save all the selected key usages as string in list
            List<string> keyUsages = new List<string>();

            //Validation for Algrithm seclection
            if (hashAlgorithm.SelectedIndex == -1)//here should skip to else - but doesn't
            {
                MessageBox.Show("Select Algorithm for Hash your CA Certificate", "Error");
            }
            //Valiadation for Key Size
            if (rsaKeySize.SelectedIndex == -1)//here should skip to else - but doesn't
            {
                MessageBox.Show("Select Key Size for you CA Certificate", "Error");
            }
            //
            if (string.IsNullOrEmpty(passwordPfx.Text))//here should skip to else - but doesn't
            {
                MessageBox.Show("Enter a password", "Error");
            }
            if (string.IsNullOrEmpty(dnName.Text))
            {
                MessageBox.Show("Enter a DN Name", "Error");
            } 
            else
            {
                try
                {

                    SaveFileDialog saveFile = new SaveFileDialog();
                    if (saveFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        // collect details from text box
                        string path = saveFile.FileName;
                        string _dnName = dnName.Text;
                        string _algorithm = "SHA256";
                        _algorithm = hashAlgorithm.Text;
                        keyUsages.Add("KeyCertSign");
                        string _password = passwordPfx.Text;
                        

                        // default Certificate sign choice
                        if (isCRLSigner.Checked)
                        {
                            keyUsages.Add("crlsign");
                        }
                        if (isCertSigner.Checked)
                        {
                            keyUsages.Add("certSigner");
                        }
                        if (serverClientAuth.Checked)
                        {
                            keyUsages.Add("serverClientAuth");
                        }
                        if (isDataEncipher.Checked)
                        {

                            keyUsages.Add("DataEncipher");
                        }
                        // convert key size to integer
                        int _keySize = Int32.Parse(rsaKeySize.Text);
                        // path constrain 
                        int _pathConstrain = 0;
                        // validity 
                        int _noOfYears = (int)Decimal.Round(noOfYears.Value, 0);

                        // Create instance
                        GenCASignedCert newCertifcatereq = new GenCASignedCert();
                        // call method 
                        //(int keySize, string subjectDN, string hashAlg, List<string> keyUsages, int pathLenght, int numberofYears, bool isCA)
                        X509Certificate2 certificate = newCertifcatereq.CreateSignedCertificate(_keySize, _dnName, _algorithm, keyUsages, _noOfYears, caThumbprint.Text, serialNumber.Text,caStore.Text);

                        // Export certificate as pfx and save to user defined location
                        _certData = certificate.Export(X509ContentType.Pfx, _password);
                        _path = path + ".pfx";
                        File.WriteAllBytes(_path, _certData);
                    }
                    else
                    {
                        MessageBox.Show("select Proper path");

                    }

                }
                catch (InvalidCastException erorr)
                {
                    if (erorr.Source != null)
                        Console.WriteLine("IOException source: {0}", erorr.Source);
                    throw;
                }

            }
        }

        private void simpleButton1_Click_1(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
