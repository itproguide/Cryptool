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
    public partial class GenerateSignedCert : DevExpress.XtraEditors.XtraForm
    {
        public GenerateSignedCert()
        {
            InitializeComponent();
        }

        private void saveAsPfx_Click(object sender, EventArgs e)
        {
            // Initialise byte array for Generated certificate
            byte[] _certData;
            // variable Store user preference 
            string _path;
            // Save all the selected key usages as string in list
            List<string> keyUsages = new List<string>();

            //Validation for Algrithm seclection
            if (algorithm.SelectedIndex == -1)//here should skip to else - but doesn't
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
            else
            {
                try
                {

                    SaveFileDialog saveFile = new SaveFileDialog();
                    if (saveFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        // collect details from text box
                        string path = saveFile.FileName;
                        string _dnName = dn.Text;
                        string _algorithm = "SHA256";
                        _algorithm = algorithm.Text;
                        keyUsages.Add("KeyCertSign");
                        string _password = passwordPfx.Text;

                        // default Certificate sign choice
                        if (crlSigner.Checked)
                        {
                            keyUsages.Add("crlsign");
                        }
                        if (certSigner.Checked)
                        {
                            keyUsages.Add("certSigner");
                        }
                        if (keyEncipher.Checked)
                        {
                            keyUsages.Add("keyEncipher");

                        }
                        if (serverClientAuth.Checked)
                        {
                            keyUsages.Add("serverClientAuth");
                        }
                        if (DataEncipher.Checked)
                        {

                            keyUsages.Add("DataEncipher");
                        }
                        // convert key size to integer
                        int _keySize = Int32.Parse(rsaKeySize.Text);
                        // path constrain 
                        int _pathConstrain = (int)Decimal.Round(pathConstrain.Value, 0);
                        // validity 
                        int _noOfYears = (int)Decimal.Round(validity.Value, 0);

                        // Create instance
                        GenerateSelfSigned newCertifcatereq = new GenerateSelfSigned();
                        // call method 
                        //(int keySize, string subjectDN, string hashAlg, List<string> keyUsages, int pathLenght, int numberofYears, bool isCA)
                        X509Certificate2 certificate = newCertifcatereq.CreateCertificate(2048, _dnName, _algorithm, keyUsages,  _pathConstrain, _noOfYears, true);

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

        private void fluentDesignFormContainer1_Click(object sender, EventArgs e)
        {

        }

        private void passwordPfx_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void labelControl7_Click(object sender, EventArgs e)
        {

        }
    }
}
