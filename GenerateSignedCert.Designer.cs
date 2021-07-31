
namespace Cryptool
{
    partial class GenSignedCert
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GenSignedCert));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.caStore = new DevExpress.XtraEditors.TextEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.caThumbprint = new DevExpress.XtraEditors.TextEdit();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DispDNName = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pfxPassword = new DevExpress.XtraEditors.TextEdit();
            this.displayDate = new System.Windows.Forms.Label();
            this.dispThump = new System.Windows.Forms.Label();
            this.disLocation = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.StoreSelected = new DevExpress.XtraEditors.ComboBoxEdit();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.Location = new DevExpress.XtraEditors.TextEdit();
            this.SelectCA = new DevExpress.XtraEditors.SimpleButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.serialNumber = new DevExpress.XtraEditors.TextEdit();
            this.noOfYears = new System.Windows.Forms.NumericUpDown();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.passwordPfx = new DevExpress.XtraEditors.TextEdit();
            this.saveCert = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.serverClientAuth = new DevExpress.XtraEditors.CheckEdit();
            this.isCRLSigner = new System.Windows.Forms.CheckBox();
            this.isDataEncipher = new System.Windows.Forms.CheckBox();
            this.isDocumentSigner = new System.Windows.Forms.CheckBox();
            this.isCertSigner = new System.Windows.Forms.CheckBox();
            this.hashAlgorithm = new DevExpress.XtraEditors.ComboBoxEdit();
            this.rsaKeySize = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.dnName = new DevExpress.XtraEditors.TextEdit();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.caStore.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.caThumbprint.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pfxPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StoreSelected.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Location.Properties)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.serialNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noOfYears)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordPfx.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serverClientAuth.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hashAlgorithm.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rsaKeySize.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dnName.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.caStore);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.caThumbprint);
            this.groupBox2.Location = new System.Drawing.Point(37, 221);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(815, 64);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Provide CA certificate Details [System Certificate Store]";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(679, 26);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 26);
            this.label8.TabIndex = 11;
            this.label8.Text = "For Root CA in trust store,\r\nRun as Administrator";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(400, 25);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Store Location";
            // 
            // caStore
            // 
            this.caStore.Location = new System.Drawing.Point(499, 22);
            this.caStore.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.caStore.Name = "caStore";
            this.caStore.Size = new System.Drawing.Size(168, 20);
            this.caStore.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 25);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "CA Thumbprint :";
            // 
            // caThumbprint
            // 
            this.caThumbprint.Location = new System.Drawing.Point(157, 22);
            this.caThumbprint.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.caThumbprint.Name = "caThumbprint";
            this.caThumbprint.Size = new System.Drawing.Size(168, 20);
            this.caThumbprint.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DispDNName);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.pfxPassword);
            this.groupBox1.Controls.Add(this.displayDate);
            this.groupBox1.Controls.Add(this.dispThump);
            this.groupBox1.Controls.Add(this.disLocation);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.StoreSelected);
            this.groupBox1.Controls.Add(this.simpleButton2);
            this.groupBox1.Controls.Add(this.Location);
            this.groupBox1.Controls.Add(this.SelectCA);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(37, 26);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(815, 172);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Upload Your CA Certififcate";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // DispDNName
            // 
            this.DispDNName.AutoSize = true;
            this.DispDNName.Location = new System.Drawing.Point(496, 92);
            this.DispDNName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DispDNName.Name = "DispDNName";
            this.DispDNName.Size = new System.Drawing.Size(0, 13);
            this.DispDNName.TabIndex = 16;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(400, 14);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "Friendly Name:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 104);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Password";
            // 
            // pfxPassword
            // 
            this.pfxPassword.Location = new System.Drawing.Point(157, 100);
            this.pfxPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pfxPassword.Name = "pfxPassword";
            this.pfxPassword.Size = new System.Drawing.Size(168, 20);
            this.pfxPassword.TabIndex = 13;
            // 
            // displayDate
            // 
            this.displayDate.AutoSize = true;
            this.displayDate.Location = new System.Drawing.Point(496, 64);
            this.displayDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.displayDate.Name = "displayDate";
            this.displayDate.Size = new System.Drawing.Size(0, 13);
            this.displayDate.TabIndex = 12;
            // 
            // dispThump
            // 
            this.dispThump.AutoSize = true;
            this.dispThump.Location = new System.Drawing.Point(496, 39);
            this.dispThump.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dispThump.Name = "dispThump";
            this.dispThump.Size = new System.Drawing.Size(0, 13);
            this.dispThump.TabIndex = 11;
            // 
            // disLocation
            // 
            this.disLocation.AutoSize = true;
            this.disLocation.Location = new System.Drawing.Point(496, 14);
            this.disLocation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.disLocation.Name = "disLocation";
            this.disLocation.Size = new System.Drawing.Size(0, 13);
            this.disLocation.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(400, 92);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "DN Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(400, 39);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Thumbprint:";
            // 
            // StoreSelected
            // 
            this.StoreSelected.Location = new System.Drawing.Point(157, 25);
            this.StoreSelected.Name = "StoreSelected";
            this.StoreSelected.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.StoreSelected.Properties.Items.AddRange(new object[] {
            "Tempstore",
            "Personal",
            "Trusted Root Certification Authorities"});
            this.StoreSelected.Size = new System.Drawing.Size(168, 20);
            this.StoreSelected.TabIndex = 7;
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.simpleButton2.Appearance.Options.UseBackColor = true;
            this.simpleButton2.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton2.ImageOptions.SvgImage")));
            this.simpleButton2.Location = new System.Drawing.Point(157, 130);
            this.simpleButton2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(168, 31);
            this.simpleButton2.TabIndex = 6;
            this.simpleButton2.Text = "Save CA to Store";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // Location
            // 
            this.Location.Location = new System.Drawing.Point(157, 62);
            this.Location.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Location.Name = "Location";
            this.Location.Size = new System.Drawing.Size(168, 20);
            this.Location.TabIndex = 5;
            this.Location.EditValueChanged += new System.EventHandler(this.Location_EditValueChanged);
            // 
            // SelectCA
            // 
            this.SelectCA.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("SelectCA.ImageOptions.SvgImage")));
            this.SelectCA.Location = new System.Drawing.Point(329, 62);
            this.SelectCA.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SelectCA.Name = "SelectCA";
            this.SelectCA.Size = new System.Drawing.Size(38, 20);
            this.SelectCA.TabIndex = 4;
            this.SelectCA.Text = "Click";
            this.SelectCA.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(400, 65);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Not After:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 65);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Select CA Certificate(pfx)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Store";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.labelControl5);
            this.groupBox3.Controls.Add(this.serialNumber);
            this.groupBox3.Controls.Add(this.noOfYears);
            this.groupBox3.Controls.Add(this.labelControl4);
            this.groupBox3.Controls.Add(this.labelControl7);
            this.groupBox3.Controls.Add(this.passwordPfx);
            this.groupBox3.Controls.Add(this.saveCert);
            this.groupBox3.Controls.Add(this.labelControl9);
            this.groupBox3.Controls.Add(this.labelControl6);
            this.groupBox3.Controls.Add(this.serverClientAuth);
            this.groupBox3.Controls.Add(this.isCRLSigner);
            this.groupBox3.Controls.Add(this.isDataEncipher);
            this.groupBox3.Controls.Add(this.isDocumentSigner);
            this.groupBox3.Controls.Add(this.isCertSigner);
            this.groupBox3.Controls.Add(this.hashAlgorithm);
            this.groupBox3.Controls.Add(this.rsaKeySize);
            this.groupBox3.Controls.Add(this.labelControl3);
            this.groupBox3.Controls.Add(this.labelControl2);
            this.groupBox3.Controls.Add(this.labelControl1);
            this.groupBox3.Controls.Add(this.dnName);
            this.groupBox3.Location = new System.Drawing.Point(37, 301);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Size = new System.Drawing.Size(815, 161);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Enter Certificate Details";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(22, 141);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(66, 13);
            this.labelControl5.TabIndex = 36;
            this.labelControl5.Text = "Serial Number";
            // 
            // serialNumber
            // 
            this.serialNumber.Location = new System.Drawing.Point(157, 136);
            this.serialNumber.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.serialNumber.Name = "serialNumber";
            this.serialNumber.Size = new System.Drawing.Size(168, 20);
            this.serialNumber.TabIndex = 35;
            // 
            // noOfYears
            // 
            this.noOfYears.Location = new System.Drawing.Point(157, 105);
            this.noOfYears.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.noOfYears.Name = "noOfYears";
            this.noOfYears.Size = new System.Drawing.Size(168, 20);
            this.noOfYears.TabIndex = 34;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(22, 110);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(34, 13);
            this.labelControl4.TabIndex = 33;
            this.labelControl4.Text = "Validity";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.BackColor = System.Drawing.Color.White;
            this.labelControl7.Appearance.Options.UseBackColor = true;
            this.labelControl7.Location = new System.Drawing.Point(403, 110);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(46, 13);
            this.labelControl7.TabIndex = 31;
            this.labelControl7.Text = "Password";
            // 
            // passwordPfx
            // 
            this.passwordPfx.Location = new System.Drawing.Point(505, 108);
            this.passwordPfx.Name = "passwordPfx";
            this.passwordPfx.Size = new System.Drawing.Size(75, 20);
            this.passwordPfx.TabIndex = 30;
            // 
            // saveCert
            // 
            this.saveCert.Appearance.BackColor = System.Drawing.SystemColors.MenuBar;
            this.saveCert.Appearance.Options.UseBackColor = true;
            this.saveCert.AppearanceHovered.BackColor = System.Drawing.Color.Silver;
            this.saveCert.AppearanceHovered.Options.UseBackColor = true;
            this.saveCert.AppearancePressed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.saveCert.AppearancePressed.Options.UseBackColor = true;
            this.saveCert.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("saveCert.ImageOptions.Image")));
            this.saveCert.Location = new System.Drawing.Point(610, 101);
            this.saveCert.Name = "saveCert";
            this.saveCert.Size = new System.Drawing.Size(159, 29);
            this.saveCert.TabIndex = 29;
            this.saveCert.Text = "Apply for Signed Cert";
            this.saveCert.Click += new System.EventHandler(this.saveCert_Click);
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.BackColor = System.Drawing.Color.White;
            this.labelControl9.Appearance.Options.UseBackColor = true;
            this.labelControl9.Location = new System.Drawing.Point(403, 75);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(101, 13);
            this.labelControl9.TabIndex = 28;
            this.labelControl9.Text = "Enhanced Key Usage";
            this.labelControl9.Click += new System.EventHandler(this.labelControl9_Click);
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.BackColor = System.Drawing.Color.White;
            this.labelControl6.Appearance.Options.UseBackColor = true;
            this.labelControl6.Location = new System.Drawing.Point(403, 19);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(57, 13);
            this.labelControl6.TabIndex = 27;
            this.labelControl6.Text = "Basic Usage";
            // 
            // serverClientAuth
            // 
            this.serverClientAuth.Location = new System.Drawing.Point(505, 72);
            this.serverClientAuth.Name = "serverClientAuth";
            this.serverClientAuth.Properties.Caption = "isSrvClientAuth";
            this.serverClientAuth.Size = new System.Drawing.Size(159, 20);
            this.serverClientAuth.TabIndex = 17;
            // 
            // isCRLSigner
            // 
            this.isCRLSigner.AutoSize = true;
            this.isCRLSigner.Location = new System.Drawing.Point(623, 45);
            this.isCRLSigner.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.isCRLSigner.Name = "isCRLSigner";
            this.isCRLSigner.Size = new System.Drawing.Size(80, 17);
            this.isCRLSigner.TabIndex = 11;
            this.isCRLSigner.Text = "CRL Signer";
            this.isCRLSigner.UseVisualStyleBackColor = true;
            // 
            // isDataEncipher
            // 
            this.isDataEncipher.AutoSize = true;
            this.isDataEncipher.Location = new System.Drawing.Point(505, 45);
            this.isDataEncipher.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.isDataEncipher.Name = "isDataEncipher";
            this.isDataEncipher.Size = new System.Drawing.Size(94, 17);
            this.isDataEncipher.TabIndex = 10;
            this.isDataEncipher.Text = "Data Encipher";
            this.isDataEncipher.UseVisualStyleBackColor = true;
            // 
            // isDocumentSigner
            // 
            this.isDocumentSigner.AutoSize = true;
            this.isDocumentSigner.Location = new System.Drawing.Point(623, 18);
            this.isDocumentSigner.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.isDocumentSigner.Name = "isDocumentSigner";
            this.isDocumentSigner.Size = new System.Drawing.Size(108, 17);
            this.isDocumentSigner.TabIndex = 9;
            this.isDocumentSigner.Text = "Document Signer";
            this.isDocumentSigner.UseVisualStyleBackColor = true;
            // 
            // isCertSigner
            // 
            this.isCertSigner.AutoSize = true;
            this.isCertSigner.Location = new System.Drawing.Point(505, 18);
            this.isCertSigner.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.isCertSigner.Name = "isCertSigner";
            this.isCertSigner.Size = new System.Drawing.Size(106, 17);
            this.isCertSigner.TabIndex = 8;
            this.isCertSigner.Text = "Certificate Signer";
            this.isCertSigner.UseVisualStyleBackColor = true;
            // 
            // hashAlgorithm
            // 
            this.hashAlgorithm.Location = new System.Drawing.Point(157, 74);
            this.hashAlgorithm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.hashAlgorithm.Name = "hashAlgorithm";
            this.hashAlgorithm.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.hashAlgorithm.Properties.Items.AddRange(new object[] {
            "MD",
            "SHA1",
            "SHA256",
            "SHA384",
            "SHA512"});
            this.hashAlgorithm.Size = new System.Drawing.Size(168, 20);
            this.hashAlgorithm.TabIndex = 7;
            // 
            // rsaKeySize
            // 
            this.rsaKeySize.Location = new System.Drawing.Point(157, 45);
            this.rsaKeySize.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rsaKeySize.Name = "rsaKeySize";
            this.rsaKeySize.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rsaKeySize.Properties.Items.AddRange(new object[] {
            "2048",
            "4096"});
            this.rsaKeySize.Size = new System.Drawing.Size(168, 20);
            this.rsaKeySize.TabIndex = 6;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(22, 76);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(72, 13);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "Hash Algorithm";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(22, 49);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(40, 13);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "Key Size";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(22, 21);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(93, 13);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Distinguished Name";
            // 
            // dnName
            // 
            this.dnName.Location = new System.Drawing.Point(157, 17);
            this.dnName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dnName.Name = "dnName";
            this.dnName.Size = new System.Drawing.Size(168, 20);
            this.dnName.TabIndex = 0;
            // 
            // GenSignedCert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(890, 469);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "GenSignedCert";
            this.Text = "GenSignedCert";
            this.Load += new System.EventHandler(this.GenSignedCert_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.caStore.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.caThumbprint.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pfxPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StoreSelected.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Location.Properties)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.serialNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noOfYears)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordPfx.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serverClientAuth.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hashAlgorithm.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rsaKeySize.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dnName.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraEditors.TextEdit caThumbprint;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.TextEdit Location;
        private DevExpress.XtraEditors.SimpleButton SelectCA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.ComboBoxEdit StoreSelected;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraEditors.TextEdit caStore;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label displayDate;
        private System.Windows.Forms.Label dispThump;
        private System.Windows.Forms.Label disLocation;
        private System.Windows.Forms.Label label9;
        private DevExpress.XtraEditors.TextEdit pfxPassword;
        private System.Windows.Forms.Label DispDNName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox3;
        private DevExpress.XtraEditors.ComboBoxEdit hashAlgorithm;
        private DevExpress.XtraEditors.ComboBoxEdit rsaKeySize;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit dnName;
        private System.Windows.Forms.CheckBox isCRLSigner;
        private System.Windows.Forms.CheckBox isDataEncipher;
        private System.Windows.Forms.CheckBox isDocumentSigner;
        private System.Windows.Forms.CheckBox isCertSigner;
        private DevExpress.XtraEditors.CheckEdit serverClientAuth;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit passwordPfx;
        private DevExpress.XtraEditors.SimpleButton saveCert;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.NumericUpDown noOfYears;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit serialNumber;
        private System.Windows.Forms.Label label8;
    }
}