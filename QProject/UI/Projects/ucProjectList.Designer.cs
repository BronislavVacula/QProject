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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucProjectList));
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions3 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject9 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject10 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject11 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject12 = new DevExpress.Utils.SerializableAppearanceObject();
            this.gridProjects = new DevExpress.XtraGrid.GridControl();
            this.gvProjects = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcCategory = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcPriority = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcDeadLine = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcPreview = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnPreview = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gcEdit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnEdit = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gcRemove = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnRemove = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panelActionBar)).BeginInit();
            this.panelActionBar.SuspendLayout();
            this.actionPanelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridProjects)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProjects)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRemove)).BeginInit();
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
            this.btnPreview,
            this.btnEdit,
            this.btnRemove});
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
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gcDeadLine,
            this.gridColumn5,
            this.gcPreview,
            this.gcEdit,
            this.gcRemove});
            this.gvProjects.GridControl = this.gridProjects;
            this.gvProjects.Name = "gvProjects";
            this.gvProjects.OptionsView.ShowAutoFilterRow = true;
            this.gvProjects.OptionsView.ShowGroupPanel = false;
            // 
            // gcNumber
            // 
            this.gcNumber.AppearanceHeader.Options.UseTextOptions = true;
            this.gcNumber.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.gcNumber.Caption = "Číslo projektu";
            this.gcNumber.FieldName = "Number";
            this.gcNumber.MaxWidth = 100;
            this.gcNumber.MinWidth = 100;
            this.gcNumber.Name = "gcNumber";
            this.gcNumber.Visible = true;
            this.gcNumber.VisibleIndex = 0;
            this.gcNumber.Width = 100;
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
            this.gcPriority.FieldName = "PriorityName";
            this.gcPriority.MaxWidth = 80;
            this.gcPriority.MinWidth = 80;
            this.gcPriority.Name = "gcPriority";
            this.gcPriority.Visible = true;
            this.gcPriority.VisibleIndex = 4;
            this.gcPriority.Width = 80;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Odpovědný team";
            this.gridColumn1.FieldName = "ResponsibleTeamName";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 3;
            this.gridColumn1.Width = 70;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Datum přijetí";
            this.gridColumn2.FieldName = "ReceivedAt";
            this.gridColumn2.MaxWidth = 80;
            this.gridColumn2.MinWidth = 80;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 5;
            this.gridColumn2.Width = 80;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Plánované zahájení";
            this.gridColumn3.FieldName = "PlanStartAt";
            this.gridColumn3.MaxWidth = 80;
            this.gridColumn3.MinWidth = 80;
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 6;
            this.gridColumn3.Width = 80;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Datum zahájení";
            this.gridColumn4.FieldName = "RealStartAt";
            this.gridColumn4.MaxWidth = 80;
            this.gridColumn4.MinWidth = 80;
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 7;
            this.gridColumn4.Width = 80;
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
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Stav";
            this.gridColumn5.FieldName = "StateName";
            this.gridColumn5.MaxWidth = 80;
            this.gridColumn5.MinWidth = 80;
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 9;
            this.gridColumn5.Width = 80;
            // 
            // gcPreview
            // 
            this.gcPreview.Caption = "gridColumn6";
            this.gcPreview.ColumnEdit = this.btnPreview;
            this.gcPreview.MaxWidth = 25;
            this.gcPreview.MinWidth = 25;
            this.gcPreview.Name = "gcPreview";
            this.gcPreview.OptionsColumn.ShowCaption = false;
            this.gcPreview.Visible = true;
            this.gcPreview.VisibleIndex = 10;
            this.gcPreview.Width = 25;
            // 
            // btnPreview
            // 
            this.btnPreview.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.btnPreview.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // gcEdit
            // 
            this.gcEdit.Caption = "gridColumn6";
            this.gcEdit.ColumnEdit = this.btnEdit;
            this.gcEdit.MaxWidth = 25;
            this.gcEdit.MinWidth = 25;
            this.gcEdit.Name = "gcEdit";
            this.gcEdit.OptionsColumn.ShowCaption = false;
            this.gcEdit.Visible = true;
            this.gcEdit.VisibleIndex = 11;
            this.gcEdit.Width = 25;
            // 
            // btnEdit
            // 
            this.btnEdit.AutoHeight = false;
            editorButtonImageOptions2.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions2.Image")));
            this.btnEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
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
            this.gcRemove.VisibleIndex = 12;
            this.gcRemove.Width = 25;
            // 
            // btnRemove
            // 
            this.btnRemove.AutoHeight = false;
            editorButtonImageOptions3.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions3.Image")));
            this.btnRemove.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions3, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject9, serializableAppearanceObject10, serializableAppearanceObject11, serializableAppearanceObject12, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
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
            ((System.ComponentModel.ISupportInitialize)(this.btnPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRemove)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridProjects;
        private DevExpress.XtraGrid.Views.Grid.GridView gvProjects;
        private DevExpress.XtraGrid.Columns.GridColumn gcNumber;
        private DevExpress.XtraGrid.Columns.GridColumn gcName;
        private DevExpress.XtraGrid.Columns.GridColumn gcCategory;
        private DevExpress.XtraGrid.Columns.GridColumn gcPriority;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gcDeadLine;
        private DevExpress.XtraGrid.Columns.GridColumn gcPreview;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnPreview;
        private DevExpress.XtraGrid.Columns.GridColumn gcEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnEdit;
        private DevExpress.XtraGrid.Columns.GridColumn gcRemove;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnRemove;
    }
}
