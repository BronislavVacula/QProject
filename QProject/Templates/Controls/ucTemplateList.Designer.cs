namespace QProject.Templates.Controls
{
    partial class ucTemplateList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucTemplateList));
            this.panelActionBar = new DevExpress.XtraEditors.PanelControl();
            this.actionPanelRight = new System.Windows.Forms.FlowLayoutPanel();
            this.actionPanelLeft = new System.Windows.Forms.FlowLayoutPanel();
            this.btnNewItem = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelActionBar)).BeginInit();
            this.panelActionBar.SuspendLayout();
            this.actionPanelLeft.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelActionBar
            // 
            this.panelActionBar.Controls.Add(this.actionPanelRight);
            this.panelActionBar.Controls.Add(this.actionPanelLeft);
            this.panelActionBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelActionBar.Location = new System.Drawing.Point(0, 0);
            this.panelActionBar.Name = "panelActionBar";
            this.panelActionBar.Size = new System.Drawing.Size(872, 39);
            this.panelActionBar.TabIndex = 2;
            // 
            // actionPanelRight
            // 
            this.actionPanelRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.actionPanelRight.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.actionPanelRight.Location = new System.Drawing.Point(476, 2);
            this.actionPanelRight.Name = "actionPanelRight";
            this.actionPanelRight.Padding = new System.Windows.Forms.Padding(3);
            this.actionPanelRight.Size = new System.Drawing.Size(394, 35);
            this.actionPanelRight.TabIndex = 1;
            // 
            // actionPanelLeft
            // 
            this.actionPanelLeft.Controls.Add(this.btnNewItem);
            this.actionPanelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.actionPanelLeft.Location = new System.Drawing.Point(2, 2);
            this.actionPanelLeft.Name = "actionPanelLeft";
            this.actionPanelLeft.Padding = new System.Windows.Forms.Padding(3);
            this.actionPanelLeft.Size = new System.Drawing.Size(383, 35);
            this.actionPanelLeft.TabIndex = 0;
            // 
            // btnNewItem
            // 
            this.btnNewItem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.btnNewItem.Location = new System.Drawing.Point(6, 6);
            this.btnNewItem.Name = "btnNewItem";
            this.btnNewItem.Size = new System.Drawing.Size(101, 23);
            this.btnNewItem.TabIndex = 0;
            this.btnNewItem.Text = "Nová položka";
            // 
            // ucTemplateList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelActionBar);
            this.DoubleBuffered = true;
            this.Name = "ucTemplateList";
            this.Size = new System.Drawing.Size(872, 610);
            ((System.ComponentModel.ISupportInitialize)(this.panelActionBar)).EndInit();
            this.panelActionBar.ResumeLayout(false);
            this.actionPanelLeft.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public DevExpress.XtraEditors.PanelControl panelActionBar;
        public FlowLayoutPanel actionPanelRight;
        public FlowLayoutPanel actionPanelLeft;
        protected DevExpress.XtraEditors.SimpleButton btnNewItem;
    }
}
