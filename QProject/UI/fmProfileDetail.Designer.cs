namespace QProject.UI
{
    partial class fmProfileDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmProfileDetail));
            this.groupDatabase = new DevExpress.XtraEditors.GroupControl();
            this.groupMailSettings = new DevExpress.XtraEditors.GroupControl();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnConfirm = new DevExpress.XtraEditors.SimpleButton();
            this.labelDatabaseServer = new DevExpress.XtraEditors.LabelControl();
            this.teDatabaseServer = new DevExpress.XtraEditors.TextEdit();
            this.labelDatabasePort = new DevExpress.XtraEditors.LabelControl();
            this.seDatabasePort = new DevExpress.XtraEditors.SpinEdit();
            this.labelDatabaseName = new DevExpress.XtraEditors.LabelControl();
            this.teDatabaseName = new DevExpress.XtraEditors.TextEdit();
            this.labelDatabaseUsername = new DevExpress.XtraEditors.LabelControl();
            this.teDatabaseUsername = new DevExpress.XtraEditors.TextEdit();
            this.labelDatabasePassword = new DevExpress.XtraEditors.LabelControl();
            this.teDatabasePort = new DevExpress.XtraEditors.TextEdit();
            this.seSMTPPort = new DevExpress.XtraEditors.SpinEdit();
            this.labelSMTPPort = new DevExpress.XtraEditors.LabelControl();
            this.teSMTPServer = new DevExpress.XtraEditors.TextEdit();
            this.labelSMTPServer = new DevExpress.XtraEditors.LabelControl();
            this.ceEnableSSL = new DevExpress.XtraEditors.CheckEdit();
            this.labelSMTPUsername = new DevExpress.XtraEditors.LabelControl();
            this.teSMTPUsername = new DevExpress.XtraEditors.TextEdit();
            this.labelSMTPPassword = new DevExpress.XtraEditors.LabelControl();
            this.teSMTPPassword = new DevExpress.XtraEditors.TextEdit();
            this.labelSMTPSender = new DevExpress.XtraEditors.LabelControl();
            this.teSMTPSenderEmail = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.groupDatabase)).BeginInit();
            this.groupDatabase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupMailSettings)).BeginInit();
            this.groupMailSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teDatabaseServer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seDatabasePort.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teDatabaseName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teDatabaseUsername.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teDatabasePort.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seSMTPPort.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teSMTPServer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceEnableSSL.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teSMTPUsername.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teSMTPPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teSMTPSenderEmail.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupDatabase
            // 
            this.groupDatabase.Controls.Add(this.teDatabasePort);
            this.groupDatabase.Controls.Add(this.labelDatabasePassword);
            this.groupDatabase.Controls.Add(this.teDatabaseUsername);
            this.groupDatabase.Controls.Add(this.labelDatabaseUsername);
            this.groupDatabase.Controls.Add(this.teDatabaseName);
            this.groupDatabase.Controls.Add(this.labelDatabaseName);
            this.groupDatabase.Controls.Add(this.seDatabasePort);
            this.groupDatabase.Controls.Add(this.labelDatabasePort);
            this.groupDatabase.Controls.Add(this.teDatabaseServer);
            this.groupDatabase.Controls.Add(this.labelDatabaseServer);
            this.groupDatabase.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupDatabase.Location = new System.Drawing.Point(0, 0);
            this.groupDatabase.Name = "groupDatabase";
            this.groupDatabase.Size = new System.Drawing.Size(494, 129);
            this.groupDatabase.TabIndex = 0;
            this.groupDatabase.Text = "Databáze";
            // 
            // groupMailSettings
            // 
            this.groupMailSettings.Controls.Add(this.teSMTPSenderEmail);
            this.groupMailSettings.Controls.Add(this.labelSMTPSender);
            this.groupMailSettings.Controls.Add(this.teSMTPPassword);
            this.groupMailSettings.Controls.Add(this.labelSMTPPassword);
            this.groupMailSettings.Controls.Add(this.teSMTPUsername);
            this.groupMailSettings.Controls.Add(this.labelSMTPUsername);
            this.groupMailSettings.Controls.Add(this.ceEnableSSL);
            this.groupMailSettings.Controls.Add(this.seSMTPPort);
            this.groupMailSettings.Controls.Add(this.labelSMTPPort);
            this.groupMailSettings.Controls.Add(this.teSMTPServer);
            this.groupMailSettings.Controls.Add(this.labelSMTPServer);
            this.groupMailSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupMailSettings.Location = new System.Drawing.Point(0, 129);
            this.groupMailSettings.Name = "groupMailSettings";
            this.groupMailSettings.Size = new System.Drawing.Size(494, 178);
            this.groupMailSettings.TabIndex = 1;
            this.groupMailSettings.Text = "Zasílání emailů";
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.btnCancel.Location = new System.Drawing.Point(12, 313);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Zrušit";
            // 
            // btnConfirm
            // 
            this.btnConfirm.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.btnConfirm.Location = new System.Drawing.Point(407, 313);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 3;
            this.btnConfirm.Text = "Potvrdit";
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // labelDatabaseServer
            // 
            this.labelDatabaseServer.Location = new System.Drawing.Point(12, 31);
            this.labelDatabaseServer.Name = "labelDatabaseServer";
            this.labelDatabaseServer.Size = new System.Drawing.Size(36, 13);
            this.labelDatabaseServer.TabIndex = 0;
            this.labelDatabaseServer.Text = "Server:";
            // 
            // teDatabaseServer
            // 
            this.teDatabaseServer.Location = new System.Drawing.Point(12, 50);
            this.teDatabaseServer.Name = "teDatabaseServer";
            this.teDatabaseServer.Size = new System.Drawing.Size(224, 20);
            this.teDatabaseServer.TabIndex = 1;
            // 
            // labelDatabasePort
            // 
            this.labelDatabasePort.Location = new System.Drawing.Point(240, 31);
            this.labelDatabasePort.Name = "labelDatabasePort";
            this.labelDatabasePort.Size = new System.Drawing.Size(24, 13);
            this.labelDatabasePort.TabIndex = 2;
            this.labelDatabasePort.Text = "Port:";
            // 
            // seDatabasePort
            // 
            this.seDatabasePort.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.seDatabasePort.Location = new System.Drawing.Point(242, 50);
            this.seDatabasePort.Name = "seDatabasePort";
            this.seDatabasePort.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.seDatabasePort.Size = new System.Drawing.Size(78, 20);
            this.seDatabasePort.TabIndex = 3;
            // 
            // labelDatabaseName
            // 
            this.labelDatabaseName.Location = new System.Drawing.Point(326, 31);
            this.labelDatabaseName.Name = "labelDatabaseName";
            this.labelDatabaseName.Size = new System.Drawing.Size(82, 13);
            this.labelDatabaseName.TabIndex = 4;
            this.labelDatabaseName.Text = "Název databáze:";
            // 
            // teDatabaseName
            // 
            this.teDatabaseName.Location = new System.Drawing.Point(326, 50);
            this.teDatabaseName.Name = "teDatabaseName";
            this.teDatabaseName.Size = new System.Drawing.Size(156, 20);
            this.teDatabaseName.TabIndex = 5;
            // 
            // labelDatabaseUsername
            // 
            this.labelDatabaseUsername.Location = new System.Drawing.Point(12, 78);
            this.labelDatabaseUsername.Name = "labelDatabaseUsername";
            this.labelDatabaseUsername.Size = new System.Drawing.Size(90, 13);
            this.labelDatabaseUsername.TabIndex = 6;
            this.labelDatabaseUsername.Text = "Uživatelské jméno:";
            // 
            // teDatabaseUsername
            // 
            this.teDatabaseUsername.Location = new System.Drawing.Point(12, 97);
            this.teDatabaseUsername.Name = "teDatabaseUsername";
            this.teDatabaseUsername.Size = new System.Drawing.Size(224, 20);
            this.teDatabaseUsername.TabIndex = 7;
            // 
            // labelDatabasePassword
            // 
            this.labelDatabasePassword.Location = new System.Drawing.Point(242, 78);
            this.labelDatabasePassword.Name = "labelDatabasePassword";
            this.labelDatabasePassword.Size = new System.Drawing.Size(30, 13);
            this.labelDatabasePassword.TabIndex = 8;
            this.labelDatabasePassword.Text = "Heslo:";
            // 
            // teDatabasePort
            // 
            this.teDatabasePort.Location = new System.Drawing.Point(242, 97);
            this.teDatabasePort.Name = "teDatabasePort";
            this.teDatabasePort.Properties.UseSystemPasswordChar = true;
            this.teDatabasePort.Size = new System.Drawing.Size(240, 20);
            this.teDatabasePort.TabIndex = 9;
            // 
            // seSMTPPort
            // 
            this.seSMTPPort.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.seSMTPPort.Location = new System.Drawing.Point(242, 51);
            this.seSMTPPort.Name = "seSMTPPort";
            this.seSMTPPort.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.seSMTPPort.Size = new System.Drawing.Size(78, 20);
            this.seSMTPPort.TabIndex = 7;
            // 
            // labelSMTPPort
            // 
            this.labelSMTPPort.Location = new System.Drawing.Point(240, 32);
            this.labelSMTPPort.Name = "labelSMTPPort";
            this.labelSMTPPort.Size = new System.Drawing.Size(24, 13);
            this.labelSMTPPort.TabIndex = 6;
            this.labelSMTPPort.Text = "Port:";
            // 
            // teSMTPServer
            // 
            this.teSMTPServer.Location = new System.Drawing.Point(12, 51);
            this.teSMTPServer.Name = "teSMTPServer";
            this.teSMTPServer.Size = new System.Drawing.Size(224, 20);
            this.teSMTPServer.TabIndex = 5;
            // 
            // labelSMTPServer
            // 
            this.labelSMTPServer.Location = new System.Drawing.Point(12, 32);
            this.labelSMTPServer.Name = "labelSMTPServer";
            this.labelSMTPServer.Size = new System.Drawing.Size(65, 13);
            this.labelSMTPServer.TabIndex = 4;
            this.labelSMTPServer.Text = "SMTP Server:";
            // 
            // ceEnableSSL
            // 
            this.ceEnableSSL.EditValue = true;
            this.ceEnableSSL.Location = new System.Drawing.Point(326, 51);
            this.ceEnableSSL.Name = "ceEnableSSL";
            this.ceEnableSSL.Properties.Caption = "Pro odeslání povolit SSL";
            this.ceEnableSSL.Size = new System.Drawing.Size(156, 20);
            this.ceEnableSSL.TabIndex = 8;
            // 
            // labelSMTPUsername
            // 
            this.labelSMTPUsername.Location = new System.Drawing.Point(12, 80);
            this.labelSMTPUsername.Name = "labelSMTPUsername";
            this.labelSMTPUsername.Size = new System.Drawing.Size(90, 13);
            this.labelSMTPUsername.TabIndex = 9;
            this.labelSMTPUsername.Text = "Uzivatelské jméno:";
            // 
            // teSMTPUsername
            // 
            this.teSMTPUsername.Location = new System.Drawing.Point(12, 99);
            this.teSMTPUsername.Name = "teSMTPUsername";
            this.teSMTPUsername.Size = new System.Drawing.Size(224, 20);
            this.teSMTPUsername.TabIndex = 10;
            // 
            // labelSMTPPassword
            // 
            this.labelSMTPPassword.Location = new System.Drawing.Point(242, 80);
            this.labelSMTPPassword.Name = "labelSMTPPassword";
            this.labelSMTPPassword.Size = new System.Drawing.Size(30, 13);
            this.labelSMTPPassword.TabIndex = 11;
            this.labelSMTPPassword.Text = "Heslo:";
            // 
            // teSMTPPassword
            // 
            this.teSMTPPassword.Location = new System.Drawing.Point(242, 99);
            this.teSMTPPassword.Name = "teSMTPPassword";
            this.teSMTPPassword.Properties.UseSystemPasswordChar = true;
            this.teSMTPPassword.Size = new System.Drawing.Size(240, 20);
            this.teSMTPPassword.TabIndex = 12;
            // 
            // labelSMTPSender
            // 
            this.labelSMTPSender.Location = new System.Drawing.Point(12, 127);
            this.labelSMTPSender.Name = "labelSMTPSender";
            this.labelSMTPSender.Size = new System.Drawing.Size(199, 13);
            this.labelSMTPSender.TabIndex = 13;
            this.labelSMTPSender.Text = "Emailová adresa (použitá jako odesílatel):";
            // 
            // teSMTPSenderEmail
            // 
            this.teSMTPSenderEmail.Location = new System.Drawing.Point(12, 146);
            this.teSMTPSenderEmail.Name = "teSMTPSenderEmail";
            this.teSMTPSenderEmail.Size = new System.Drawing.Size(470, 20);
            this.teSMTPSenderEmail.TabIndex = 14;
            // 
            // fmProfileDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 344);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.groupMailSettings);
            this.Controls.Add(this.groupDatabase);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fmProfileDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nastavení profilui";
            ((System.ComponentModel.ISupportInitialize)(this.groupDatabase)).EndInit();
            this.groupDatabase.ResumeLayout(false);
            this.groupDatabase.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupMailSettings)).EndInit();
            this.groupMailSettings.ResumeLayout(false);
            this.groupMailSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teDatabaseServer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seDatabasePort.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teDatabaseName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teDatabaseUsername.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teDatabasePort.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seSMTPPort.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teSMTPServer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceEnableSSL.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teSMTPUsername.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teSMTPPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teSMTPSenderEmail.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupDatabase;
        private DevExpress.XtraEditors.GroupControl groupMailSettings;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnConfirm;
        private DevExpress.XtraEditors.TextEdit teDatabasePort;
        private DevExpress.XtraEditors.LabelControl labelDatabasePassword;
        private DevExpress.XtraEditors.TextEdit teDatabaseUsername;
        private DevExpress.XtraEditors.LabelControl labelDatabaseUsername;
        private DevExpress.XtraEditors.TextEdit teDatabaseName;
        private DevExpress.XtraEditors.LabelControl labelDatabaseName;
        private DevExpress.XtraEditors.SpinEdit seDatabasePort;
        private DevExpress.XtraEditors.LabelControl labelDatabasePort;
        private DevExpress.XtraEditors.TextEdit teDatabaseServer;
        private DevExpress.XtraEditors.LabelControl labelDatabaseServer;
        private DevExpress.XtraEditors.TextEdit teSMTPPassword;
        private DevExpress.XtraEditors.LabelControl labelSMTPPassword;
        private DevExpress.XtraEditors.TextEdit teSMTPUsername;
        private DevExpress.XtraEditors.LabelControl labelSMTPUsername;
        private DevExpress.XtraEditors.CheckEdit ceEnableSSL;
        private DevExpress.XtraEditors.SpinEdit seSMTPPort;
        private DevExpress.XtraEditors.LabelControl labelSMTPPort;
        private DevExpress.XtraEditors.TextEdit teSMTPServer;
        private DevExpress.XtraEditors.LabelControl labelSMTPServer;
        private DevExpress.XtraEditors.TextEdit teSMTPSenderEmail;
        private DevExpress.XtraEditors.LabelControl labelSMTPSender;
    }
}