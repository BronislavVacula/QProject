namespace QProject.Templates.Controls
{
    partial class ucTemplateDetail
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucTemplateDetail));
            this.panelActionBar = new DevExpress.XtraEditors.PanelControl();
            this.actionPanelRight = new System.Windows.Forms.FlowLayoutPanel();
            this.btnChange = new DevExpress.XtraEditors.SimpleButton();
            this.btnFinish = new DevExpress.XtraEditors.SimpleButton();
            this.btnSaveChanges = new DevExpress.XtraEditors.SimpleButton();
            this.actionPanelLeft = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.panelActionBar)).BeginInit();
            this.panelActionBar.SuspendLayout();
            this.actionPanelRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelActionBar
            // 
            this.panelActionBar.Controls.Add(this.actionPanelRight);
            this.panelActionBar.Controls.Add(this.actionPanelLeft);
            this.panelActionBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelActionBar.Location = new System.Drawing.Point(0, 614);
            this.panelActionBar.Name = "panelActionBar";
            this.panelActionBar.Size = new System.Drawing.Size(929, 39);
            this.panelActionBar.TabIndex = 1;
            // 
            // actionPanelRight
            // 
            this.actionPanelRight.Controls.Add(this.btnChange);
            this.actionPanelRight.Controls.Add(this.btnFinish);
            this.actionPanelRight.Controls.Add(this.btnSaveChanges);
            this.actionPanelRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.actionPanelRight.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.actionPanelRight.Location = new System.Drawing.Point(533, 2);
            this.actionPanelRight.Name = "actionPanelRight";
            this.actionPanelRight.Padding = new System.Windows.Forms.Padding(3);
            this.actionPanelRight.Size = new System.Drawing.Size(394, 35);
            this.actionPanelRight.TabIndex = 1;
            // 
            // btnChange
            // 
            this.btnChange.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnChange.ImageOptions.Image")));
            this.btnChange.Location = new System.Drawing.Point(307, 6);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(78, 23);
            this.btnChange.TabIndex = 5;
            this.btnChange.Text = "Upravit";
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // btnFinish
            // 
            this.btnFinish.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnFinish.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnFinish.ImageOptions.Image")));
            this.btnFinish.Location = new System.Drawing.Point(196, 6);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(105, 23);
            this.btnFinish.TabIndex = 7;
            this.btnFinish.Text = "Ukončit úpravy";
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveChanges.ImageOptions.Image")));
            this.btnSaveChanges.Location = new System.Drawing.Point(95, 6);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(95, 23);
            this.btnSaveChanges.TabIndex = 6;
            this.btnSaveChanges.Text = "Uložit změny";
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // actionPanelLeft
            // 
            this.actionPanelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.actionPanelLeft.Location = new System.Drawing.Point(2, 2);
            this.actionPanelLeft.Name = "actionPanelLeft";
            this.actionPanelLeft.Padding = new System.Windows.Forms.Padding(3);
            this.actionPanelLeft.Size = new System.Drawing.Size(383, 35);
            this.actionPanelLeft.TabIndex = 0;
            // 
            // ucTemplateDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelActionBar);
            this.DoubleBuffered = true;
            this.Name = "ucTemplateDetail";
            this.Size = new System.Drawing.Size(929, 653);
            ((System.ComponentModel.ISupportInitialize)(this.panelActionBar)).EndInit();
            this.panelActionBar.ResumeLayout(false);
            this.actionPanelRight.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public DevExpress.XtraEditors.PanelControl panelActionBar;
        public FlowLayoutPanel actionPanelRight;
        public FlowLayoutPanel actionPanelLeft;
        public DevExpress.XtraEditors.SimpleButton btnChange;
        public DevExpress.XtraEditors.SimpleButton btnFinish;
        public DevExpress.XtraEditors.SimpleButton btnSaveChanges;
    }
}
