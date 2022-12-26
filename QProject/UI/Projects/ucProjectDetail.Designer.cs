namespace QProject.UI.Projects
{
    partial class ucProjectDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucProjectDetail));
            this.navigationDetail = new DevExpress.XtraBars.Navigation.NavigationPane();
            this.navDetail = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.ucProjectDetailMainInfo1 = new QProject.UI.Projects.ucProjectDetailMainInfo();
            this.navTasks = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.ucProjectTaskList1 = new QProject.UI.Projects.ucProjectTaskList();
            this.navSpentTime = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.ucProjectSpentTimeList1 = new QProject.UI.Projects.ucProjectSpentTimeList();
            this.navFinance = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.ucProjectDetailFinancial1 = new QProject.UI.Projects.ucProjectDetailFinancial();
            this.navigationPage4 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.ucProjectDetailResources1 = new QProject.UI.Projects.ucProjectDetailResources();
            ((System.ComponentModel.ISupportInitialize)(this.navigationDetail)).BeginInit();
            this.navigationDetail.SuspendLayout();
            this.navDetail.SuspendLayout();
            this.navTasks.SuspendLayout();
            this.navSpentTime.SuspendLayout();
            this.navFinance.SuspendLayout();
            this.navigationPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // navigationDetail
            // 
            this.navigationDetail.Controls.Add(this.navDetail);
            this.navigationDetail.Controls.Add(this.navTasks);
            this.navigationDetail.Controls.Add(this.navSpentTime);
            this.navigationDetail.Controls.Add(this.navFinance);
            this.navigationDetail.Controls.Add(this.navigationPage4);
            this.navigationDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navigationDetail.Location = new System.Drawing.Point(0, 0);
            this.navigationDetail.Name = "navigationDetail";
            this.navigationDetail.PageProperties.ShowCollapseButton = false;
            this.navigationDetail.PageProperties.ShowExpandButton = false;
            this.navigationDetail.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.navDetail,
            this.navTasks,
            this.navSpentTime,
            this.navFinance,
            this.navigationPage4});
            this.navigationDetail.RegularSize = new System.Drawing.Size(994, 652);
            this.navigationDetail.SelectedPage = this.navDetail;
            this.navigationDetail.Size = new System.Drawing.Size(994, 652);
            this.navigationDetail.State = DevExpress.XtraBars.Navigation.NavigationPaneState.Expanded;
            this.navigationDetail.TabIndex = 2;
            this.navigationDetail.Text = "navigationPane1";
            this.navigationDetail.StateChanging += new DevExpress.XtraBars.Navigation.StateChangingEventHandler(this.navigationDetail_StateChanging);
            this.navigationDetail.SelectedPageChanging += new DevExpress.XtraBars.Navigation.SelectedPageChangingEventHandler(this.navigationDetail_SelectedPageChanging);
            // 
            // navDetail
            // 
            this.navDetail.Caption = "  Hlavní informace";
            this.navDetail.Controls.Add(this.ucProjectDetailMainInfo1);
            this.navDetail.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("navDetail.ImageOptions.Image")));
            this.navDetail.Name = "navDetail";
            this.navDetail.Properties.ShowMode = DevExpress.XtraBars.Navigation.ItemShowMode.ImageAndText;
            this.navDetail.Size = new System.Drawing.Size(836, 588);
            // 
            // ucProjectDetailMainInfo1
            // 
            this.ucProjectDetailMainInfo1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucProjectDetailMainInfo1.HasChanges = false;
            this.ucProjectDetailMainInfo1.Location = new System.Drawing.Point(0, 0);
            this.ucProjectDetailMainInfo1.Name = "ucProjectDetailMainInfo1";
            this.ucProjectDetailMainInfo1.RelatedEntity = null;
            this.ucProjectDetailMainInfo1.Size = new System.Drawing.Size(836, 588);
            this.ucProjectDetailMainInfo1.TabIndex = 0;
            // 
            // navTasks
            // 
            this.navTasks.Caption = "  Úlohy";
            this.navTasks.Controls.Add(this.ucProjectTaskList1);
            this.navTasks.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("navTasks.ImageOptions.Image")));
            this.navTasks.Name = "navTasks";
            this.navTasks.Properties.ShowMode = DevExpress.XtraBars.Navigation.ItemShowMode.ImageAndText;
            this.navTasks.Size = new System.Drawing.Size(836, 588);
            // 
            // ucProjectTaskList1
            // 
            this.ucProjectTaskList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucProjectTaskList1.Location = new System.Drawing.Point(0, 0);
            this.ucProjectTaskList1.Name = "ucProjectTaskList1";
            this.ucProjectTaskList1.Size = new System.Drawing.Size(836, 588);
            this.ucProjectTaskList1.TabIndex = 0;
            // 
            // navSpentTime
            // 
            this.navSpentTime.Caption = "  Strávený čas";
            this.navSpentTime.Controls.Add(this.ucProjectSpentTimeList1);
            this.navSpentTime.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("navSpentTime.ImageOptions.Image")));
            this.navSpentTime.Name = "navSpentTime";
            this.navSpentTime.Properties.ShowMode = DevExpress.XtraBars.Navigation.ItemShowMode.ImageAndText;
            this.navSpentTime.Size = new System.Drawing.Size(836, 588);
            // 
            // ucProjectSpentTimeList1
            // 
            this.ucProjectSpentTimeList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucProjectSpentTimeList1.Location = new System.Drawing.Point(0, 0);
            this.ucProjectSpentTimeList1.Name = "ucProjectSpentTimeList1";
            this.ucProjectSpentTimeList1.Size = new System.Drawing.Size(836, 588);
            this.ucProjectSpentTimeList1.TabIndex = 0;
            // 
            // navFinance
            // 
            this.navFinance.Caption = "  Finance";
            this.navFinance.Controls.Add(this.ucProjectDetailFinancial1);
            this.navFinance.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("navFinance.ImageOptions.Image")));
            this.navFinance.Name = "navFinance";
            this.navFinance.Properties.ShowMode = DevExpress.XtraBars.Navigation.ItemShowMode.ImageAndText;
            this.navFinance.Size = new System.Drawing.Size(836, 579);
            // 
            // ucProjectDetailFinancial1
            // 
            this.ucProjectDetailFinancial1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucProjectDetailFinancial1.HasChanges = false;
            this.ucProjectDetailFinancial1.Location = new System.Drawing.Point(0, 0);
            this.ucProjectDetailFinancial1.Name = "ucProjectDetailFinancial1";
            this.ucProjectDetailFinancial1.RelatedEntity = null;
            this.ucProjectDetailFinancial1.Size = new System.Drawing.Size(836, 579);
            this.ucProjectDetailFinancial1.TabIndex = 0;
            // 
            // navigationPage4
            // 
            this.navigationPage4.Caption = "  Použité zdroje";
            this.navigationPage4.Controls.Add(this.ucProjectDetailResources1);
            this.navigationPage4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("navigationPage4.ImageOptions.Image")));
            this.navigationPage4.Name = "navigationPage4";
            this.navigationPage4.Properties.ShowMode = DevExpress.XtraBars.Navigation.ItemShowMode.ImageAndText;
            this.navigationPage4.Size = new System.Drawing.Size(836, 588);
            // 
            // ucProjectDetailResources1
            // 
            this.ucProjectDetailResources1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucProjectDetailResources1.HasChanges = false;
            this.ucProjectDetailResources1.Location = new System.Drawing.Point(0, 0);
            this.ucProjectDetailResources1.Name = "ucProjectDetailResources1";
            this.ucProjectDetailResources1.RelatedEntity = null;
            this.ucProjectDetailResources1.Size = new System.Drawing.Size(836, 588);
            this.ucProjectDetailResources1.TabIndex = 0;
            // 
            // ucProjectDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.navigationDetail);
            this.DoubleBuffered = true;
            this.Name = "ucProjectDetail";
            this.Size = new System.Drawing.Size(994, 652);
            ((System.ComponentModel.ISupportInitialize)(this.navigationDetail)).EndInit();
            this.navigationDetail.ResumeLayout(false);
            this.navDetail.ResumeLayout(false);
            this.navTasks.ResumeLayout(false);
            this.navSpentTime.ResumeLayout(false);
            this.navFinance.ResumeLayout(false);
            this.navigationPage4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Navigation.NavigationPane navigationDetail;
        private DevExpress.XtraBars.Navigation.NavigationPage navDetail;
        private DevExpress.XtraBars.Navigation.NavigationPage navTasks;
        private DevExpress.XtraBars.Navigation.NavigationPage navSpentTime;
        private DevExpress.XtraBars.Navigation.NavigationPage navFinance;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage4;
        private ucProjectDetailMainInfo ucProjectDetailMainInfo1;
        private ucProjectTaskList ucProjectTaskList1;
        private ucProjectSpentTimeList ucProjectSpentTimeList1;
        private ucProjectDetailFinancial ucProjectDetailFinancial1;
        private ucProjectDetailResources ucProjectDetailResources1;
    }
}
