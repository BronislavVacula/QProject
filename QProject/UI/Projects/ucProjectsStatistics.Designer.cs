namespace QProject.UI.Projects
{
    partial class ucProjectsStatistics
    {
        /// <summary> 
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód vygenerovaný pomocí Návrháře komponent

        /// <summary> 
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.ChartTitle chartTitle1 = new DevExpress.XtraCharts.ChartTitle();
            this.projectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pivotGridField33 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridField32 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridField31 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridField30 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridField29 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridField28 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridField27 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridField26 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridField25 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridField24 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridField23 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridField22 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridField21 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridField20 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridField19 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridField18 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridField17 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridField16 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridField15 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridField14 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridField13 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridField12 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridField11 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridField10 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridField9 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridField8 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridField7 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridField6 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridField5 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridField4 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridField3 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridField2 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridField1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridControl1 = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.chartControl2 = new DevExpress.XtraCharts.ChartControl();
            ((System.ComponentModel.ISupportInitialize)(this.projectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            this.SuspendLayout();
            // 
            // projectBindingSource
            // 
            this.projectBindingSource.DataSource = typeof(QProject.BL.Entities.Projects.Project);
            // 
            // pivotGridField33
            // 
            this.pivotGridField33.AreaIndex = 13;
            this.pivotGridField33.Caption = "Is Deleted";
            this.pivotGridField33.FieldName = "IsDeleted";
            this.pivotGridField33.Name = "pivotGridField33";
            // 
            // pivotGridField32
            // 
            this.pivotGridField32.AreaIndex = 13;
            this.pivotGridField32.Caption = "Is Modified";
            this.pivotGridField32.FieldName = "IsModified";
            this.pivotGridField32.Name = "pivotGridField32";
            // 
            // pivotGridField31
            // 
            this.pivotGridField31.AreaIndex = 13;
            this.pivotGridField31.Caption = "Is Saved";
            this.pivotGridField31.FieldName = "IsSaved";
            this.pivotGridField31.Name = "pivotGridField31";
            // 
            // pivotGridField30
            // 
            this.pivotGridField30.AreaIndex = 13;
            this.pivotGridField30.Caption = "Id";
            this.pivotGridField30.FieldName = "Id";
            this.pivotGridField30.Name = "pivotGridField30";
            // 
            // pivotGridField29
            // 
            this.pivotGridField29.AreaIndex = 13;
            this.pivotGridField29.Caption = "UpdatedAt";
            this.pivotGridField29.FieldName = "UpdatedAt";
            this.pivotGridField29.Name = "pivotGridField29";
            // 
            // pivotGridField28
            // 
            this.pivotGridField28.AreaIndex = 13;
            this.pivotGridField28.Caption = "CreatedAt";
            this.pivotGridField28.FieldName = "CreatedAt";
            this.pivotGridField28.Name = "pivotGridField28";
            // 
            // pivotGridField27
            // 
            this.pivotGridField27.AreaIndex = 13;
            this.pivotGridField27.Caption = "Finance";
            this.pivotGridField27.FieldName = "Finance";
            this.pivotGridField27.Name = "pivotGridField27";
            // 
            // pivotGridField26
            // 
            this.pivotGridField26.AreaIndex = 13;
            this.pivotGridField26.Caption = "Customer Name";
            this.pivotGridField26.FieldName = "CustomerName";
            this.pivotGridField26.Name = "pivotGridField26";
            // 
            // pivotGridField25
            // 
            this.pivotGridField25.AreaIndex = 13;
            this.pivotGridField25.Caption = "Category Name";
            this.pivotGridField25.FieldName = "CategoryName";
            this.pivotGridField25.Name = "pivotGridField25";
            // 
            // pivotGridField24
            // 
            this.pivotGridField24.AreaIndex = 13;
            this.pivotGridField24.Caption = "State";
            this.pivotGridField24.FieldName = "State";
            this.pivotGridField24.Name = "pivotGridField24";
            // 
            // pivotGridField23
            // 
            this.pivotGridField23.AreaIndex = 13;
            this.pivotGridField23.Caption = "Created By Id";
            this.pivotGridField23.FieldName = "CreatedById";
            this.pivotGridField23.Name = "pivotGridField23";
            // 
            // pivotGridField22
            // 
            this.pivotGridField22.AreaIndex = 13;
            this.pivotGridField22.Caption = "Description";
            this.pivotGridField22.FieldName = "Description";
            this.pivotGridField22.Name = "pivotGridField22";
            // 
            // pivotGridField21
            // 
            this.pivotGridField21.AreaIndex = 13;
            this.pivotGridField21.Caption = "Real Spent Time";
            this.pivotGridField21.FieldName = "RealSpentTime";
            this.pivotGridField21.Name = "pivotGridField21";
            // 
            // pivotGridField20
            // 
            this.pivotGridField20.AreaIndex = 13;
            this.pivotGridField20.Caption = "Plan Spent Time";
            this.pivotGridField20.FieldName = "PlanSpentTime";
            this.pivotGridField20.Name = "pivotGridField20";
            // 
            // pivotGridField19
            // 
            this.pivotGridField19.AreaIndex = 13;
            this.pivotGridField19.Caption = "Current Expenses";
            this.pivotGridField19.FieldName = "CurrentExpenses";
            this.pivotGridField19.Name = "pivotGridField19";
            // 
            // pivotGridField18
            // 
            this.pivotGridField18.AreaIndex = 13;
            this.pivotGridField18.Caption = "Current Earnings";
            this.pivotGridField18.FieldName = "CurrentEarnings";
            this.pivotGridField18.Name = "pivotGridField18";
            // 
            // pivotGridField17
            // 
            this.pivotGridField17.AreaIndex = 13;
            this.pivotGridField17.Caption = "Plan Expenses";
            this.pivotGridField17.FieldName = "PlanExpenses";
            this.pivotGridField17.Name = "pivotGridField17";
            // 
            // pivotGridField16
            // 
            this.pivotGridField16.AreaIndex = 13;
            this.pivotGridField16.Caption = "Plan Earnings";
            this.pivotGridField16.FieldName = "PlanEarnings";
            this.pivotGridField16.Name = "pivotGridField16";
            // 
            // pivotGridField15
            // 
            this.pivotGridField15.AreaIndex = 13;
            this.pivotGridField15.Caption = "Deadline";
            this.pivotGridField15.FieldName = "Deadline";
            this.pivotGridField15.Name = "pivotGridField15";
            // 
            // pivotGridField14
            // 
            this.pivotGridField14.AreaIndex = 13;
            this.pivotGridField14.Caption = "Real Start At";
            this.pivotGridField14.FieldName = "RealStartAt";
            this.pivotGridField14.Name = "pivotGridField14";
            // 
            // pivotGridField13
            // 
            this.pivotGridField13.AreaIndex = 13;
            this.pivotGridField13.Caption = "Plan Start At";
            this.pivotGridField13.FieldName = "PlanStartAt";
            this.pivotGridField13.Name = "pivotGridField13";
            // 
            // pivotGridField12
            // 
            this.pivotGridField12.AreaIndex = 13;
            this.pivotGridField12.Caption = "Received At";
            this.pivotGridField12.FieldName = "ReceivedAt";
            this.pivotGridField12.Name = "pivotGridField12";
            // 
            // pivotGridField11
            // 
            this.pivotGridField11.AreaIndex = 13;
            this.pivotGridField11.Caption = "Main Contact";
            this.pivotGridField11.FieldName = "MainContact";
            this.pivotGridField11.Name = "pivotGridField11";
            // 
            // pivotGridField10
            // 
            this.pivotGridField10.AreaIndex = 13;
            this.pivotGridField10.Caption = "Contact Person Id";
            this.pivotGridField10.FieldName = "ContactPersonId";
            this.pivotGridField10.Name = "pivotGridField10";
            // 
            // pivotGridField9
            // 
            this.pivotGridField9.AreaIndex = 13;
            this.pivotGridField9.Caption = "Responsible Person Id";
            this.pivotGridField9.FieldName = "ResponsiblePersonId";
            this.pivotGridField9.Name = "pivotGridField9";
            // 
            // pivotGridField8
            // 
            this.pivotGridField8.AreaIndex = 13;
            this.pivotGridField8.Caption = "Responsible Team Id";
            this.pivotGridField8.FieldName = "ResponsibleTeamId";
            this.pivotGridField8.Name = "pivotGridField8";
            // 
            // pivotGridField7
            // 
            this.pivotGridField7.AreaIndex = 13;
            this.pivotGridField7.Caption = "Priority";
            this.pivotGridField7.FieldName = "Priority";
            this.pivotGridField7.Name = "pivotGridField7";
            // 
            // pivotGridField6
            // 
            this.pivotGridField6.AreaIndex = 13;
            this.pivotGridField6.Caption = "Name";
            this.pivotGridField6.FieldName = "Name";
            this.pivotGridField6.Name = "pivotGridField6";
            // 
            // pivotGridField5
            // 
            this.pivotGridField5.AreaIndex = 13;
            this.pivotGridField5.Caption = "Number Int";
            this.pivotGridField5.FieldName = "NumberInt";
            this.pivotGridField5.Name = "pivotGridField5";
            // 
            // pivotGridField4
            // 
            this.pivotGridField4.AreaIndex = 13;
            this.pivotGridField4.Caption = "Number";
            this.pivotGridField4.FieldName = "Number";
            this.pivotGridField4.Name = "pivotGridField4";
            // 
            // pivotGridField3
            // 
            this.pivotGridField3.AreaIndex = 13;
            this.pivotGridField3.Caption = "Category Id";
            this.pivotGridField3.FieldName = "CategoryId";
            this.pivotGridField3.Name = "pivotGridField3";
            // 
            // pivotGridField2
            // 
            this.pivotGridField2.AreaIndex = 13;
            this.pivotGridField2.Caption = "Customer Id";
            this.pivotGridField2.FieldName = "CustomerId";
            this.pivotGridField2.Name = "pivotGridField2";
            // 
            // pivotGridField1
            // 
            this.pivotGridField1.AreaIndex = 13;
            this.pivotGridField1.Caption = "Template Id";
            this.pivotGridField1.FieldName = "TemplateId";
            this.pivotGridField1.Name = "pivotGridField1";
            // 
            // pivotGridControl1
            // 
            this.pivotGridControl1.DataSource = this.projectBindingSource;
            this.pivotGridControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pivotGridControl1.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.pivotGridField1,
            this.pivotGridField2,
            this.pivotGridField3,
            this.pivotGridField4,
            this.pivotGridField5,
            this.pivotGridField6,
            this.pivotGridField7,
            this.pivotGridField8,
            this.pivotGridField9,
            this.pivotGridField10,
            this.pivotGridField11,
            this.pivotGridField12,
            this.pivotGridField13,
            this.pivotGridField14,
            this.pivotGridField15,
            this.pivotGridField16,
            this.pivotGridField17,
            this.pivotGridField18,
            this.pivotGridField19,
            this.pivotGridField20,
            this.pivotGridField21,
            this.pivotGridField22,
            this.pivotGridField23,
            this.pivotGridField24,
            this.pivotGridField25,
            this.pivotGridField26,
            this.pivotGridField27,
            this.pivotGridField28,
            this.pivotGridField29,
            this.pivotGridField30,
            this.pivotGridField31,
            this.pivotGridField32,
            this.pivotGridField33});
            this.pivotGridControl1.Location = new System.Drawing.Point(0, 0);
            this.pivotGridControl1.Name = "pivotGridControl1";
            this.pivotGridControl1.Size = new System.Drawing.Size(400, 634);
            this.pivotGridControl1.TabIndex = 0;
            // 
            // chartControl2
            // 
            this.chartControl2.DataSource = this.pivotGridControl1;
            xyDiagram1.AxisX.Title.Text = "Category";
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.Title.Text = "Finance";
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            this.chartControl2.Diagram = xyDiagram1;
            this.chartControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartControl2.Legend.MaxHorizontalPercentage = 30D;
            this.chartControl2.Location = new System.Drawing.Point(400, 0);
            this.chartControl2.Name = "chartControl2";
            this.chartControl2.SeriesDataMember = "Series";
            this.chartControl2.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.chartControl2.SeriesTemplate.ArgumentDataMember = "Arguments";
            this.chartControl2.SeriesTemplate.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Qualitative;
            this.chartControl2.SeriesTemplate.SeriesDataMember = "Series";
            this.chartControl2.SeriesTemplate.ValueDataMembersSerializable = "Values";
            this.chartControl2.Size = new System.Drawing.Size(563, 634);
            this.chartControl2.TabIndex = 2;
            chartTitle1.Text = "Stav financí";
            this.chartControl2.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] {
            chartTitle1});
            // 
            // ucProjectsStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chartControl2);
            this.Controls.Add(this.pivotGridControl1);
            this.DoubleBuffered = true;
            this.Name = "ucProjectsStatistics";
            this.Size = new System.Drawing.Size(963, 634);
            ((System.ComponentModel.ISupportInitialize)(this.projectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private BindingSource projectBindingSource;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField33;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField32;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField31;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField30;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField29;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField28;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField27;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField26;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField25;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField24;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField23;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField22;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField21;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField20;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField19;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField18;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField17;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField16;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField15;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField14;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField13;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField12;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField11;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField10;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField9;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField8;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField7;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField6;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField5;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField4;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField3;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField2;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField1;
        private DevExpress.XtraPivotGrid.PivotGridControl pivotGridControl1;
        private DevExpress.XtraCharts.ChartControl chartControl2;
    }
}
