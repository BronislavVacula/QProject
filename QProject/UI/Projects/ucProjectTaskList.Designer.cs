namespace QProject.UI.Projects
{
    partial class ucProjectTaskList
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
            this.gridTasks = new DevExpress.XtraGrid.GridControl();
            this.gvTasks = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcSubject = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcCategory = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcPriority = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcResponsiblePerson = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcDeadline = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcState = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelActionBar)).BeginInit();
            this.panelActionBar.SuspendLayout();
            this.actionPanelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridTasks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTasks)).BeginInit();
            this.SuspendLayout();
            // 
            // panelActionBar
            // 
            this.panelActionBar.Size = new System.Drawing.Size(868, 39);
            // 
            // actionPanelRight
            // 
            this.actionPanelRight.Location = new System.Drawing.Point(472, 2);
            // 
            // btnNewItem
            // 
            this.btnNewItem.Text = "Nová úloha";
            // 
            // gridTasks
            // 
            this.gridTasks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridTasks.Location = new System.Drawing.Point(0, 39);
            this.gridTasks.MainView = this.gvTasks;
            this.gridTasks.Name = "gridTasks";
            this.gridTasks.Size = new System.Drawing.Size(868, 575);
            this.gridTasks.TabIndex = 3;
            this.gridTasks.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvTasks});
            // 
            // gvTasks
            // 
            this.gvTasks.ColumnPanelRowHeight = 35;
            this.gvTasks.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gcSubject,
            this.gcCategory,
            this.gcPriority,
            this.gcResponsiblePerson,
            this.gcDeadline,
            this.gcState});
            this.gvTasks.GridControl = this.gridTasks;
            this.gvTasks.Name = "gvTasks";
            this.gvTasks.OptionsView.ShowGroupPanel = false;
            // 
            // gcSubject
            // 
            this.gcSubject.Caption = "Předmět";
            this.gcSubject.MinWidth = 150;
            this.gcSubject.Name = "gcSubject";
            this.gcSubject.Visible = true;
            this.gcSubject.VisibleIndex = 0;
            this.gcSubject.Width = 150;
            // 
            // gcCategory
            // 
            this.gcCategory.Caption = "Kategorie";
            this.gcCategory.MaxWidth = 200;
            this.gcCategory.MinWidth = 120;
            this.gcCategory.Name = "gcCategory";
            this.gcCategory.Visible = true;
            this.gcCategory.VisibleIndex = 1;
            this.gcCategory.Width = 120;
            // 
            // gcPriority
            // 
            this.gcPriority.Caption = "Priorita";
            this.gcPriority.MaxWidth = 80;
            this.gcPriority.MinWidth = 80;
            this.gcPriority.Name = "gcPriority";
            this.gcPriority.Visible = true;
            this.gcPriority.VisibleIndex = 2;
            this.gcPriority.Width = 80;
            // 
            // gcResponsiblePerson
            // 
            this.gcResponsiblePerson.Caption = "Odpovědná osoba";
            this.gcResponsiblePerson.MaxWidth = 200;
            this.gcResponsiblePerson.MinWidth = 120;
            this.gcResponsiblePerson.Name = "gcResponsiblePerson";
            this.gcResponsiblePerson.Visible = true;
            this.gcResponsiblePerson.VisibleIndex = 3;
            this.gcResponsiblePerson.Width = 120;
            // 
            // gcDeadline
            // 
            this.gcDeadline.Caption = "Termín";
            this.gcDeadline.MaxWidth = 100;
            this.gcDeadline.MinWidth = 100;
            this.gcDeadline.Name = "gcDeadline";
            this.gcDeadline.Visible = true;
            this.gcDeadline.VisibleIndex = 4;
            this.gcDeadline.Width = 100;
            // 
            // gcState
            // 
            this.gcState.Caption = "Stav";
            this.gcState.MaxWidth = 80;
            this.gcState.MinWidth = 80;
            this.gcState.Name = "gcState";
            this.gcState.Visible = true;
            this.gcState.VisibleIndex = 5;
            this.gcState.Width = 80;
            // 
            // ucProjectTaskList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridTasks);
            this.Name = "ucProjectTaskList";
            this.Size = new System.Drawing.Size(868, 614);
            this.Controls.SetChildIndex(this.panelActionBar, 0);
            this.Controls.SetChildIndex(this.gridTasks, 0);
            ((System.ComponentModel.ISupportInitialize)(this.panelActionBar)).EndInit();
            this.panelActionBar.ResumeLayout(false);
            this.actionPanelLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridTasks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTasks)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridTasks;
        private DevExpress.XtraGrid.Views.Grid.GridView gvTasks;
        private DevExpress.XtraGrid.Columns.GridColumn gcSubject;
        private DevExpress.XtraGrid.Columns.GridColumn gcCategory;
        private DevExpress.XtraGrid.Columns.GridColumn gcPriority;
        private DevExpress.XtraGrid.Columns.GridColumn gcResponsiblePerson;
        private DevExpress.XtraGrid.Columns.GridColumn gcDeadline;
        private DevExpress.XtraGrid.Columns.GridColumn gcState;
    }
}
