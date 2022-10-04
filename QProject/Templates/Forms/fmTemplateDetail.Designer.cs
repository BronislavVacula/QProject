using QProject.Base;

namespace QProject.Templates.Forms
{
    partial class fmTemplateDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmTemplateDetail));
            this.panelActionBar = new DevExpress.XtraEditors.PanelControl();
            this.actionPanelRight = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSaveChanges = new DevExpress.XtraEditors.SimpleButton();
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            this.actionPanelLeft = new System.Windows.Forms.FlowLayoutPanel();
            this.btnFinish = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelActionBar)).BeginInit();
            this.panelActionBar.SuspendLayout();
            this.actionPanelRight.SuspendLayout();
            this.actionPanelLeft.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelActionBar
            // 
            this.panelActionBar.Controls.Add(this.actionPanelRight);
            this.panelActionBar.Controls.Add(this.actionPanelLeft);
            this.panelActionBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelActionBar.Location = new System.Drawing.Point(0, 531);
            this.panelActionBar.Name = "panelActionBar";
            this.panelActionBar.Size = new System.Drawing.Size(756, 39);
            this.panelActionBar.TabIndex = 0;
            // 
            // actionPanelRight
            // 
            this.actionPanelRight.Controls.Add(this.btnSaveChanges);
            this.actionPanelRight.Controls.Add(this.btnOK);
            this.actionPanelRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.actionPanelRight.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.actionPanelRight.Location = new System.Drawing.Point(360, 2);
            this.actionPanelRight.Name = "actionPanelRight";
            this.actionPanelRight.Padding = new System.Windows.Forms.Padding(3);
            this.actionPanelRight.Size = new System.Drawing.Size(394, 35);
            this.actionPanelRight.TabIndex = 1;
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveChanges.ImageOptions.Image")));
            this.btnSaveChanges.Location = new System.Drawing.Point(290, 6);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(95, 23);
            this.btnSaveChanges.TabIndex = 6;
            this.btnSaveChanges.Text = "Uložit změny";
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnOK.ImageOptions.Image")));
            this.btnOK.Location = new System.Drawing.Point(216, 6);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(68, 23);
            this.btnOK.TabIndex = 7;
            this.btnOK.Text = "Potvrdit";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // actionPanelLeft
            // 
            this.actionPanelLeft.Controls.Add(this.btnFinish);
            this.actionPanelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.actionPanelLeft.Location = new System.Drawing.Point(2, 2);
            this.actionPanelLeft.Name = "actionPanelLeft";
            this.actionPanelLeft.Padding = new System.Windows.Forms.Padding(3);
            this.actionPanelLeft.Size = new System.Drawing.Size(383, 35);
            this.actionPanelLeft.TabIndex = 0;
            // 
            // btnFinish
            // 
            this.btnFinish.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnFinish.ImageOptions.Image")));
            this.btnFinish.Location = new System.Drawing.Point(6, 6);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(70, 23);
            this.btnFinish.TabIndex = 5;
            this.btnFinish.Text = "Zrušit";
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // fmTemplateDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 570);
            this.Controls.Add(this.panelActionBar);
            this.DoubleBuffered = true;
            this.Name = "fmTemplateDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detail položky";
            ((System.ComponentModel.ISupportInitialize)(this.panelActionBar)).EndInit();
            this.panelActionBar.ResumeLayout(false);
            this.actionPanelRight.ResumeLayout(false);
            this.actionPanelLeft.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton btnSaveChanges;
        private DevExpress.XtraEditors.SimpleButton btnFinish;
        public FlowLayoutPanel actionPanelRight;
        public DevExpress.XtraEditors.PanelControl panelActionBar;
        public FlowLayoutPanel actionPanelLeft;
        private DevExpress.XtraEditors.SimpleButton btnOK;
    }
}