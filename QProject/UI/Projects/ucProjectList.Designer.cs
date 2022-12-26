namespace QProject.UI.Projects
{
    partial class ucProjectList
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucProjectList));
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.gridProjects = new DevExpress.XtraGrid.GridControl();
            this.gvProjects = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.riProjectNumber = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
            this.gcName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcCategory = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcPriority = new DevExpress.XtraGrid.Columns.GridColumn();
            this.riPriority = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.gcResponsiblePerson = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcReceivedAt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcPlanStart = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcRealStart = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcDeadLine = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcState = new DevExpress.XtraGrid.Columns.GridColumn();
            this.riState = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.gcRemove = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnRemove = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.menuProjects = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.otevřítDetailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.zahájitProjektToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dokončitProjektToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zrušitProjektToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.panelActionBar)).BeginInit();
            this.panelActionBar.SuspendLayout();
            this.actionPanelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridProjects)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProjects)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riProjectNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riPriority)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riState)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRemove)).BeginInit();
            this.menuProjects.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelActionBar
            // 
            this.panelActionBar.Size = new System.Drawing.Size(1062, 39);
            // 
            // actionPanelRight
            // 
            this.actionPanelRight.Location = new System.Drawing.Point(666, 2);
            // 
            // btnNewItem
            // 
            this.btnNewItem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnNewItem.ImageOptions.Image")));
            this.btnNewItem.Click += new System.EventHandler(this.btnNewItem_Click);
            // 
            // gridProjects
            // 
            this.gridProjects.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridProjects.Location = new System.Drawing.Point(0, 39);
            this.gridProjects.MainView = this.gvProjects;
            this.gridProjects.Name = "gridProjects";
            this.gridProjects.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnRemove,
            this.riProjectNumber,
            this.riState,
            this.riPriority});
            this.gridProjects.Size = new System.Drawing.Size(1062, 642);
            this.gridProjects.TabIndex = 3;
            this.gridProjects.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvProjects});
            // 
            // gvProjects
            // 
            this.gvProjects.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gvProjects.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvProjects.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gvProjects.ColumnPanelRowHeight = 35;
            this.gvProjects.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gcNumber,
            this.gcName,
            this.gcCategory,
            this.gcPriority,
            this.gcResponsiblePerson,
            this.gcReceivedAt,
            this.gcPlanStart,
            this.gcRealStart,
            this.gcDeadLine,
            this.gcState,
            this.gcRemove});
            this.gvProjects.GridControl = this.gridProjects;
            this.gvProjects.Name = "gvProjects";
            this.gvProjects.OptionsBehavior.ReadOnly = true;
            this.gvProjects.OptionsView.ShowAutoFilterRow = true;
            this.gvProjects.OptionsView.ShowGroupPanel = false;
            this.gvProjects.MouseUp += new System.Windows.Forms.MouseEventHandler(this.gvProjects_MouseUp);
            // 
            // gcNumber
            // 
            this.gcNumber.AppearanceHeader.Options.UseTextOptions = true;
            this.gcNumber.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.gcNumber.Caption = "Číslo projektu";
            this.gcNumber.ColumnEdit = this.riProjectNumber;
            this.gcNumber.FieldName = "Number";
            this.gcNumber.MaxWidth = 100;
            this.gcNumber.MinWidth = 100;
            this.gcNumber.Name = "gcNumber";
            this.gcNumber.Visible = true;
            this.gcNumber.VisibleIndex = 0;
            this.gcNumber.Width = 100;
            // 
            // riProjectNumber
            // 
            this.riProjectNumber.AutoHeight = false;
            this.riProjectNumber.Name = "riProjectNumber";
            this.riProjectNumber.SingleClick = true;
            this.riProjectNumber.Click += new System.EventHandler(this.riProjectNumber_Click);
            // 
            // gcName
            // 
            this.gcName.Caption = "Název projektu";
            this.gcName.FieldName = "Name";
            this.gcName.MinWidth = 120;
            this.gcName.Name = "gcName";
            this.gcName.Visible = true;
            this.gcName.VisibleIndex = 1;
            this.gcName.Width = 120;
            // 
            // gcCategory
            // 
            this.gcCategory.Caption = "Kategorie";
            this.gcCategory.FieldName = "CategoryName";
            this.gcCategory.MinWidth = 100;
            this.gcCategory.Name = "gcCategory";
            this.gcCategory.Visible = true;
            this.gcCategory.VisibleIndex = 2;
            this.gcCategory.Width = 100;
            // 
            // gcPriority
            // 
            this.gcPriority.Caption = "Priorita";
            this.gcPriority.ColumnEdit = this.riPriority;
            this.gcPriority.FieldName = "Priority";
            this.gcPriority.MaxWidth = 80;
            this.gcPriority.MinWidth = 80;
            this.gcPriority.Name = "gcPriority";
            this.gcPriority.Visible = true;
            this.gcPriority.VisibleIndex = 4;
            this.gcPriority.Width = 80;
            // 
            // riPriority
            // 
            this.riPriority.AutoHeight = false;
            this.riPriority.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.riPriority.Name = "riPriority";
            // 
            // gcResponsiblePerson
            // 
            this.gcResponsiblePerson.Caption = "Odpovědný team";
            this.gcResponsiblePerson.FieldName = "ResponsibleTeamName";
            this.gcResponsiblePerson.Name = "gcResponsiblePerson";
            this.gcResponsiblePerson.Visible = true;
            this.gcResponsiblePerson.VisibleIndex = 3;
            this.gcResponsiblePerson.Width = 70;
            // 
            // gcReceivedAt
            // 
            this.gcReceivedAt.Caption = "Datum přijetí";
            this.gcReceivedAt.FieldName = "ReceivedAt";
            this.gcReceivedAt.MaxWidth = 80;
            this.gcReceivedAt.MinWidth = 80;
            this.gcReceivedAt.Name = "gcReceivedAt";
            this.gcReceivedAt.Visible = true;
            this.gcReceivedAt.VisibleIndex = 5;
            this.gcReceivedAt.Width = 80;
            // 
            // gcPlanStart
            // 
            this.gcPlanStart.Caption = "Plánované zahájení";
            this.gcPlanStart.FieldName = "PlanStartAt";
            this.gcPlanStart.MaxWidth = 80;
            this.gcPlanStart.MinWidth = 80;
            this.gcPlanStart.Name = "gcPlanStart";
            this.gcPlanStart.Visible = true;
            this.gcPlanStart.VisibleIndex = 6;
            this.gcPlanStart.Width = 80;
            // 
            // gcRealStart
            // 
            this.gcRealStart.Caption = "Datum zahájení";
            this.gcRealStart.FieldName = "RealStartAt";
            this.gcRealStart.MaxWidth = 80;
            this.gcRealStart.MinWidth = 80;
            this.gcRealStart.Name = "gcRealStart";
            this.gcRealStart.Visible = true;
            this.gcRealStart.VisibleIndex = 7;
            this.gcRealStart.Width = 80;
            // 
            // gcDeadLine
            // 
            this.gcDeadLine.Caption = "Termín";
            this.gcDeadLine.FieldName = "Deadline";
            this.gcDeadLine.MaxWidth = 80;
            this.gcDeadLine.MinWidth = 80;
            this.gcDeadLine.Name = "gcDeadLine";
            this.gcDeadLine.Visible = true;
            this.gcDeadLine.VisibleIndex = 8;
            this.gcDeadLine.Width = 80;
            // 
            // gcState
            // 
            this.gcState.Caption = "Stav";
            this.gcState.ColumnEdit = this.riState;
            this.gcState.FieldName = "State";
            this.gcState.MaxWidth = 80;
            this.gcState.MinWidth = 80;
            this.gcState.Name = "gcState";
            this.gcState.Visible = true;
            this.gcState.VisibleIndex = 9;
            this.gcState.Width = 80;
            // 
            // riState
            // 
            this.riState.AutoHeight = false;
            this.riState.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.riState.Name = "riState";
            // 
            // gcRemove
            // 
            this.gcRemove.Caption = "gridColumn6";
            this.gcRemove.ColumnEdit = this.btnRemove;
            this.gcRemove.MaxWidth = 25;
            this.gcRemove.MinWidth = 25;
            this.gcRemove.Name = "gcRemove";
            this.gcRemove.OptionsColumn.ShowCaption = false;
            this.gcRemove.Visible = true;
            this.gcRemove.VisibleIndex = 10;
            this.gcRemove.Width = 25;
            // 
            // btnRemove
            // 
            this.btnRemove.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.btnRemove.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // menuProjects
            // 
            this.menuProjects.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.otevřítDetailToolStripMenuItem,
            this.toolStripMenuItem1,
            this.zahájitProjektToolStripMenuItem,
            this.dokončitProjektToolStripMenuItem,
            this.zrušitProjektToolStripMenuItem});
            this.menuProjects.Name = "menuProjects";
            this.menuProjects.Size = new System.Drawing.Size(166, 98);
            // 
            // otevřítDetailToolStripMenuItem
            // 
            this.otevřítDetailToolStripMenuItem.Name = "otevřítDetailToolStripMenuItem";
            this.otevřítDetailToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.otevřítDetailToolStripMenuItem.Text = "Otevřít detail";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(162, 6);
            // 
            // zahájitProjektToolStripMenuItem
            // 
            this.zahájitProjektToolStripMenuItem.Name = "zahájitProjektToolStripMenuItem";
            this.zahájitProjektToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.zahájitProjektToolStripMenuItem.Text = "Zahájit projekt";
            // 
            // dokončitProjektToolStripMenuItem
            // 
            this.dokončitProjektToolStripMenuItem.Name = "dokončitProjektToolStripMenuItem";
            this.dokončitProjektToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.dokončitProjektToolStripMenuItem.Text = "Dokončit projekt";
            // 
            // zrušitProjektToolStripMenuItem
            // 
            this.zrušitProjektToolStripMenuItem.Name = "zrušitProjektToolStripMenuItem";
            this.zrušitProjektToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.zrušitProjektToolStripMenuItem.Text = "Stornovat projekt";
            // 
            // ucProjectList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridProjects);
            this.Name = "ucProjectList";
            this.Size = new System.Drawing.Size(1062, 681);
            this.Controls.SetChildIndex(this.panelActionBar, 0);
            this.Controls.SetChildIndex(this.gridProjects, 0);
            ((System.ComponentModel.ISupportInitialize)(this.panelActionBar)).EndInit();
            this.panelActionBar.ResumeLayout(false);
            this.actionPanelLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridProjects)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProjects)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riProjectNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riPriority)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riState)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRemove)).EndInit();
            this.menuProjects.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridProjects;
        private DevExpress.XtraGrid.Views.Grid.GridView gvProjects;
        private DevExpress.XtraGrid.Columns.GridColumn gcNumber;
        private DevExpress.XtraGrid.Columns.GridColumn gcName;
        private DevExpress.XtraGrid.Columns.GridColumn gcCategory;
        private DevExpress.XtraGrid.Columns.GridColumn gcPriority;
        private DevExpress.XtraGrid.Columns.GridColumn gcResponsiblePerson;
        private DevExpress.XtraGrid.Columns.GridColumn gcReceivedAt;
        private DevExpress.XtraGrid.Columns.GridColumn gcPlanStart;
        private DevExpress.XtraGrid.Columns.GridColumn gcRealStart;
        private DevExpress.XtraGrid.Columns.GridColumn gcState;
        private DevExpress.XtraGrid.Columns.GridColumn gcDeadLine;
        private DevExpress.XtraGrid.Columns.GridColumn gcRemove;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnRemove;
        private DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit riProjectNumber;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox riState;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox riPriority;
        private ContextMenuStrip menuProjects;
        private ToolStripMenuItem otevřítDetailToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem zahájitProjektToolStripMenuItem;
        private ToolStripMenuItem dokončitProjektToolStripMenuItem;
        private ToolStripMenuItem zrušitProjektToolStripMenuItem;
    }
}
