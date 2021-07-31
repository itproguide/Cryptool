
namespace Cryptool
{
    partial class GenerateSignedCert
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GenerateSignedCert));
            this.dn = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.fluentDesignFormContainer1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.rsaKeySize = new System.Windows.Forms.ComboBox();
            this.algorithm = new System.Windows.Forms.ComboBox();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.passwordPfx = new DevExpress.XtraEditors.TextEdit();
            this.saveAsPfx = new DevExpress.XtraEditors.SimpleButton();
            this.keyEncipher = new DevExpress.XtraEditors.CheckEdit();
            this.DataEncipher = new DevExpress.XtraEditors.CheckEdit();
            this.serverClientAuth = new DevExpress.XtraEditors.CheckEdit();
            this.crlSigner = new DevExpress.XtraEditors.CheckEdit();
            this.certSigner = new DevExpress.XtraEditors.CheckEdit();
            this.validity = new System.Windows.Forms.NumericUpDown();
            this.pathConstrain = new System.Windows.Forms.NumericUpDown();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.dn.Properties)).BeginInit();
            this.fluentDesignFormContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.passwordPfx.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.keyEncipher.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataEncipher.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serverClientAuth.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crlSigner.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.certSigner.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.validity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pathConstrain)).BeginInit();
            this.SuspendLayout();
            // 
            // dn
            // 
            this.dn.Location = new System.Drawing.Point(236, 104);
            this.dn.Margin = new System.Windows.Forms.Padding(4);
            this.dn.Name = "dn";
            this.dn.Size = new System.Drawing.Size(348, 26);
            this.dn.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.BackColor = System.Drawing.Color.White;
            this.labelControl1.Appearance.Options.UseBackColor = true;
            this.labelControl1.Location = new System.Drawing.Point(68, 114);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(137, 19);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Distingushed Name";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.BackColor = System.Drawing.Color.White;
            this.labelControl2.Appearance.Options.UseBackColor = true;
            this.labelControl2.Location = new System.Drawing.Point(68, 175);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(71, 19);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "Algorithm";
            // 
            // fluentDesignFormContainer1
            // 
            this.fluentDesignFormContainer1.Appearance.BackColor = System.Drawing.Color.White;
            this.fluentDesignFormContainer1.Appearance.Options.UseBackColor = true;
            this.fluentDesignFormContainer1.Controls.Add(this.labelControl9);
            this.fluentDesignFormContainer1.Controls.Add(this.rsaKeySize);
            this.fluentDesignFormContainer1.Controls.Add(this.algorithm);
            this.fluentDesignFormContainer1.Controls.Add(this.labelControl8);
            this.fluentDesignFormContainer1.Controls.Add(this.labelControl7);
            this.fluentDesignFormContainer1.Controls.Add(this.passwordPfx);
            this.fluentDesignFormContainer1.Controls.Add(this.saveAsPfx);
            this.fluentDesignFormContainer1.Controls.Add(this.keyEncipher);
            this.fluentDesignFormContainer1.Controls.Add(this.DataEncipher);
            this.fluentDesignFormContainer1.Controls.Add(this.serverClientAuth);
            this.fluentDesignFormContainer1.Controls.Add(this.crlSigner);
            this.fluentDesignFormContainer1.Controls.Add(this.certSigner);
            this.fluentDesignFormContainer1.Controls.Add(this.validity);
            this.fluentDesignFormContainer1.Controls.Add(this.pathConstrain);
            this.fluentDesignFormContainer1.Controls.Add(this.dn);
            this.fluentDesignFormContainer1.Controls.Add(this.labelControl1);
            this.fluentDesignFormContainer1.Controls.Add(this.labelControl2);
            this.fluentDesignFormContainer1.Controls.Add(this.labelControl6);
            this.fluentDesignFormContainer1.Controls.Add(this.labelControl5);
            this.fluentDesignFormContainer1.Controls.Add(this.labelControl4);
            this.fluentDesignFormContainer1.Controls.Add(this.labelControl3);
            this.fluentDesignFormContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fluentDesignFormContainer1.Location = new System.Drawing.Point(0, 0);
            this.fluentDesignFormContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.fluentDesignFormContainer1.Name = "fluentDesignFormContainer1";
            this.fluentDesignFormContainer1.Size = new System.Drawing.Size(1200, 658);
            this.fluentDesignFormContainer1.TabIndex = 5;
            this.fluentDesignFormContainer1.Click += new System.EventHandler(this.fluentDesignFormContainer1_Click);
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.BackColor = System.Drawing.Color.White;
            this.labelControl9.Appearance.Options.UseBackColor = true;
            this.labelControl9.Location = new System.Drawing.Point(68, 514);
            this.labelControl9.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(146, 19);
            this.labelControl9.TabIndex = 26;
            this.labelControl9.Text = "Enhanced Key Usage";
            // 
            // rsaKeySize
            // 
            this.rsaKeySize.FormattingEnabled = true;
            this.rsaKeySize.Items.AddRange(new object[] {
            "1024",
            "2048",
            "4096"});
            this.rsaKeySize.Location = new System.Drawing.Point(236, 235);
            this.rsaKeySize.Margin = new System.Windows.Forms.Padding(4);
            this.rsaKeySize.Name = "rsaKeySize";
            this.rsaKeySize.Size = new System.Drawing.Size(163, 27);
            this.rsaKeySize.TabIndex = 25;
            // 
            // algorithm
            // 
            this.algorithm.FormattingEnabled = true;
            this.algorithm.Items.AddRange(new object[] {
            "MD",
            "SHA1",
            "SHA256",
            "SHA384",
            "SHA512"});
            this.algorithm.Location = new System.Drawing.Point(236, 171);
            this.algorithm.Margin = new System.Windows.Forms.Padding(4);
            this.algorithm.Name = "algorithm";
            this.algorithm.Size = new System.Drawing.Size(163, 27);
            this.algorithm.TabIndex = 24;
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Appearance.Options.UseForeColor = true;
            this.labelControl8.Location = new System.Drawing.Point(68, 48);
            this.labelControl8.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(347, 29);
            this.labelControl8.TabIndex = 23;
            this.labelControl8.Text = "Enter Your Certificate Details";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.BackColor = System.Drawing.Color.White;
            this.labelControl7.Appearance.Options.UseBackColor = true;
            this.labelControl7.Location = new System.Drawing.Point(814, 235);
            this.labelControl7.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(67, 19);
            this.labelControl7.TabIndex = 22;
            this.labelControl7.Text = "Password";
            this.labelControl7.Click += new System.EventHandler(this.labelControl7_Click);
            // 
            // passwordPfx
            // 
            this.passwordPfx.Location = new System.Drawing.Point(910, 225);
            this.passwordPfx.Margin = new System.Windows.Forms.Padding(4);
            this.passwordPfx.Name = "passwordPfx";
            this.passwordPfx.Size = new System.Drawing.Size(112, 26);
            this.passwordPfx.TabIndex = 21;
            this.passwordPfx.EditValueChanged += new System.EventHandler(this.passwordPfx_EditValueChanged);
            // 
            // saveAsPfx
            // 
            this.saveAsPfx.Appearance.BackColor = System.Drawing.SystemColors.MenuBar;
            this.saveAsPfx.Appearance.Options.UseBackColor = true;
            this.saveAsPfx.AppearanceHovered.BackColor = System.Drawing.Color.Silver;
            this.saveAsPfx.AppearanceHovered.Options.UseBackColor = true;
            this.saveAsPfx.AppearancePressed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.saveAsPfx.AppearancePressed.Options.UseBackColor = true;
            this.saveAsPfx.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("saveAsPfx.ImageOptions.Image")));
            this.saveAsPfx.Location = new System.Drawing.Point(814, 270);
            this.saveAsPfx.Margin = new System.Windows.Forms.Padding(4);
            this.saveAsPfx.Name = "saveAsPfx";
            this.saveAsPfx.Size = new System.Drawing.Size(208, 83);
            this.saveAsPfx.TabIndex = 20;
            this.saveAsPfx.Text = "Save as PFX";
            this.saveAsPfx.Click += new System.EventHandler(this.saveAsPfx_Click);
            // 
            // keyEncipher
            // 
            this.keyEncipher.Location = new System.Drawing.Point(471, 456);
            this.keyEncipher.Margin = new System.Windows.Forms.Padding(4);
            this.keyEncipher.Name = "keyEncipher";
            this.keyEncipher.Properties.Caption = "Key Encipher";
            this.keyEncipher.Size = new System.Drawing.Size(158, 27);
            this.keyEncipher.TabIndex = 19;
            // 
            // DataEncipher
            // 
            this.DataEncipher.Location = new System.Drawing.Point(234, 456);
            this.DataEncipher.Margin = new System.Windows.Forms.Padding(4);
            this.DataEncipher.Name = "DataEncipher";
            this.DataEncipher.Properties.Caption = "Data Encipher";
            this.DataEncipher.Size = new System.Drawing.Size(165, 27);
            this.DataEncipher.TabIndex = 18;
            // 
            // serverClientAuth
            // 
            this.serverClientAuth.Location = new System.Drawing.Point(234, 510);
            this.serverClientAuth.Margin = new System.Windows.Forms.Padding(4);
            this.serverClientAuth.Name = "serverClientAuth";
            this.serverClientAuth.Properties.Caption = "Server  Clent Authentication";
            this.serverClientAuth.Size = new System.Drawing.Size(239, 27);
            this.serverClientAuth.TabIndex = 16;
            // 
            // crlSigner
            // 
            this.crlSigner.Location = new System.Drawing.Point(471, 418);
            this.crlSigner.Margin = new System.Windows.Forms.Padding(4);
            this.crlSigner.Name = "crlSigner";
            this.crlSigner.Properties.Caption = "CRL Signer";
            this.crlSigner.Size = new System.Drawing.Size(112, 27);
            this.crlSigner.TabIndex = 15;
            // 
            // certSigner
            // 
            this.certSigner.Location = new System.Drawing.Point(236, 418);
            this.certSigner.Margin = new System.Windows.Forms.Padding(4);
            this.certSigner.Name = "certSigner";
            this.certSigner.Properties.Caption = "Cert Signer";
            this.certSigner.Size = new System.Drawing.Size(112, 27);
            this.certSigner.TabIndex = 14;
            // 
            // validity
            // 
            this.validity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.validity.Location = new System.Drawing.Point(236, 351);
            this.validity.Margin = new System.Windows.Forms.Padding(4);
            this.validity.Name = "validity";
            this.validity.Size = new System.Drawing.Size(202, 27);
            this.validity.TabIndex = 13;
            // 
            // pathConstrain
            // 
            this.pathConstrain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pathConstrain.Location = new System.Drawing.Point(236, 291);
            this.pathConstrain.Margin = new System.Windows.Forms.Padding(4);
            this.pathConstrain.Name = "pathConstrain";
            this.pathConstrain.Size = new System.Drawing.Size(202, 27);
            this.pathConstrain.TabIndex = 12;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.BackColor = System.Drawing.Color.White;
            this.labelControl6.Appearance.Options.UseBackColor = true;
            this.labelControl6.Location = new System.Drawing.Point(68, 428);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(83, 19);
            this.labelControl6.TabIndex = 9;
            this.labelControl6.Text = "Basic Usage";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.BackColor = System.Drawing.Color.White;
            this.labelControl5.Appearance.Options.UseBackColor = true;
            this.labelControl5.Location = new System.Drawing.Point(68, 362);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(101, 19);
            this.labelControl5.TabIndex = 8;
            this.labelControl5.Text = "Validity (Year)";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.BackColor = System.Drawing.Color.White;
            this.labelControl4.Appearance.Options.UseBackColor = true;
            this.labelControl4.Location = new System.Drawing.Point(68, 303);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(31, 19);
            this.labelControl4.TabIndex = 7;
            this.labelControl4.Text = "Path";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.BackColor = System.Drawing.Color.White;
            this.labelControl3.Appearance.Options.UseBackColor = true;
            this.labelControl3.Location = new System.Drawing.Point(68, 244);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(93, 19);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "RAS Key Size";
            // 
            // GenerateSignedCert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 658);
            this.Controls.Add(this.fluentDesignFormContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GenerateSignedCert";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dn.Properties)).EndInit();
            this.fluentDesignFormContainer1.ResumeLayout(false);
            this.fluentDesignFormContainer1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.passwordPfx.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.keyEncipher.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataEncipher.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serverClientAuth.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crlSigner.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.certSigner.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.validity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pathConstrain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit dn;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer fluentDesignFormContainer1;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit passwordPfx;
        private DevExpress.XtraEditors.SimpleButton saveAsPfx;
        private DevExpress.XtraEditors.CheckEdit keyEncipher;
        private DevExpress.XtraEditors.CheckEdit DataEncipher;
        private DevExpress.XtraEditors.CheckEdit serverClientAuth;
        private DevExpress.XtraEditors.CheckEdit crlSigner;
        private DevExpress.XtraEditors.CheckEdit certSigner;
        private System.Windows.Forms.NumericUpDown validity;
        private System.Windows.Forms.NumericUpDown pathConstrain;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.ComboBox rsaKeySize;
        private System.Windows.Forms.ComboBox algorithm;
        private DevExpress.XtraEditors.LabelControl labelControl9;
    }
}