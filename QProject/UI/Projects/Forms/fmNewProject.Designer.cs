namespace QProject.UI.Projects.Forms
{
    partial class fmNewProject
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
            this.groupBasicInfo = new DevExpress.XtraEditors.GroupControl();
            this.cbPriority = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.ceCategory = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.teProjectName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.teMainContact = new DevExpress.XtraEditors.TextEdit();
            this.labelMainContact = new DevExpress.XtraEditors.LabelControl();
            this.cbCustomer = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelCustomerName = new DevExpress.XtraEditors.LabelControl();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.deDeadline = new DevExpress.XtraEditors.DateEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.dePlanStart = new DevExpress.XtraEditors.DateEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.sePlanExpenses = new DevExpress.XtraEditors.SpinEdit();
            this.labelPlanExpenses = new DevExpress.XtraEditors.LabelControl();
            this.sePlanEarnings = new DevExpress.XtraEditors.SpinEdit();
            this.labelPlanEarnings = new DevExpress.XtraEditors.LabelControl();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.reDescription = new QProject.UI.Components.QRichEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panelActionBar)).BeginInit();
            this.panelActionBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBasicInfo)).BeginInit();
            this.groupBasicInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbPriority.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceCategory.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teProjectName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teMainContact.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbCustomer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deDeadline.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDeadline.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dePlanStart.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dePlanStart.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sePlanExpenses.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sePlanEarnings.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            this.SuspendLayout();
            // 
            // actionPanelRight
            // 
            this.actionPanelRight.Location = new System.Drawing.Point(167, 2);
            // 
            // panelActionBar
            // 
            this.panelActionBar.Location = new System.Drawing.Point(0, 407);
            this.panelActionBar.Size = new System.Drawing.Size(563, 39);
            // 
            // groupBasicInfo
            // 
            this.groupBasicInfo.Controls.Add(this.cbPriority);
            this.groupBasicInfo.Controls.Add(this.labelControl3);
            this.groupBasicInfo.Controls.Add(this.ceCategory);
            this.groupBasicInfo.Controls.Add(this.labelControl2);
            this.groupBasicInfo.Controls.Add(this.teProjectName);
            this.groupBasicInfo.Controls.Add(this.labelControl1);
            this.groupBasicInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBasicInfo.Location = new System.Drawing.Point(0, 0);
            this.groupBasicInfo.Name = "groupBasicInfo";
            this.groupBasicInfo.Size = new System.Drawing.Size(563, 86);
            this.groupBasicInfo.TabIndex = 1;
            this.groupBasicInfo.Text = "Základní údaje";
            // 
            // cbPriority
            // 
            this.cbPriority.Location = new System.Drawing.Point(457, 50);
            this.cbPriority.Name = "cbPriority";
            this.cbPriority.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbPriority.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbPriority.Size = new System.Drawing.Size(95, 20);
            this.cbPriority.TabIndex = 5;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(457, 31);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(38, 13);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Priorita:";
            // 
            // ceCategory
            // 
            this.ceCategory.Location = new System.Drawing.Point(289, 50);
            this.ceCategory.Name = "ceCategory";
            this.ceCategory.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ceCategory.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.ceCategory.Size = new System.Drawing.Size(162, 20);
            this.ceCategory.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(289, 31);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(50, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Kategorie:";
            // 
            // teProjectName
            // 
            this.teProjectName.Location = new System.Drawing.Point(12, 50);
            this.teProjectName.Name = "teProjectName";
            this.teProjectName.Size = new System.Drawing.Size(273, 20);
            this.teProjectName.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 31);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(77, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Název projektu:";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.teMainContact);
            this.groupControl2.Controls.Add(this.labelMainContact);
            this.groupControl2.Controls.Add(this.cbCustomer);
            this.groupControl2.Controls.Add(this.labelCustomerName);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl2.Location = new System.Drawing.Point(0, 86);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(563, 84);
            this.groupControl2.TabIndex = 2;
            this.groupControl2.Text = "Zákazník";
            // 
            // teMainContact
            // 
            this.teMainContact.Location = new System.Drawing.Point(289, 50);
            this.teMainContact.Name = "teMainContact";
            this.teMainContact.Size = new System.Drawing.Size(263, 20);
            this.teMainContact.TabIndex = 11;
            // 
            // labelMainContact
            // 
            this.labelMainContact.Location = new System.Drawing.Point(289, 31);
            this.labelMainContact.Name = "labelMainContact";
            this.labelMainContact.Size = new System.Drawing.Size(72, 13);
            this.labelMainContact.TabIndex = 10;
            this.labelMainContact.Text = "Hlavní kontakt:";
            // 
            // cbCustomer
            // 
            this.cbCustomer.Location = new System.Drawing.Point(12, 50);
            this.cbCustomer.Name = "cbCustomer";
            this.cbCustomer.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbCustomer.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbCustomer.Size = new System.Drawing.Size(273, 20);
            this.cbCustomer.TabIndex = 9;
            // 
            // labelCustomerName
            // 
            this.labelCustomerName.Location = new System.Drawing.Point(12, 31);
            this.labelCustomerName.Name = "labelCustomerName";
            this.labelCustomerName.Size = new System.Drawing.Size(83, 13);
            this.labelCustomerName.TabIndex = 1;
            this.labelCustomerName.Text = "Název zákazníka:";
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.deDeadline);
            this.groupControl3.Controls.Add(this.labelControl4);
            this.groupControl3.Controls.Add(this.dePlanStart);
            this.groupControl3.Controls.Add(this.labelControl5);
            this.groupControl3.Controls.Add(this.sePlanExpenses);
            this.groupControl3.Controls.Add(this.labelPlanExpenses);
            this.groupControl3.Controls.Add(this.sePlanEarnings);
            this.groupControl3.Controls.Add(this.labelPlanEarnings);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl3.Location = new System.Drawing.Point(0, 170);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(563, 85);
            this.groupControl3.TabIndex = 3;
            this.groupControl3.Text = "Plánované údaje";
            // 
            // deDeadline
            // 
            this.deDeadline.EditValue = null;
            this.deDeadline.Location = new System.Drawing.Point(427, 50);
            this.deDeadline.Name = "deDeadline";
            this.deDeadline.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deDeadline.Size = new System.Drawing.Size(125, 20);
            this.deDeadline.TabIndex = 19;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(427, 31);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(45, 13);
            this.labelControl4.TabIndex = 18;
            this.labelControl4.Text = "Deadline:";
            // 
            // dePlanStart
            // 
            this.dePlanStart.EditValue = null;
            this.dePlanStart.Location = new System.Drawing.Point(289, 50);
            this.dePlanStart.Name = "dePlanStart";
            this.dePlanStart.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dePlanStart.Size = new System.Drawing.Size(132, 20);
            this.dePlanStart.TabIndex = 17;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(289, 31);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(97, 13);
            this.labelControl5.TabIndex = 16;
            this.labelControl5.Text = "Plánované zahájení:";
            // 
            // sePlanExpenses
            // 
            this.sePlanExpenses.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.sePlanExpenses.Location = new System.Drawing.Point(150, 50);
            this.sePlanExpenses.Name = "sePlanExpenses";
            this.sePlanExpenses.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.sePlanExpenses.Size = new System.Drawing.Size(135, 20);
            this.sePlanExpenses.TabIndex = 15;
            // 
            // labelPlanExpenses
            // 
            this.labelPlanExpenses.Location = new System.Drawing.Point(150, 31);
            this.labelPlanExpenses.Name = "labelPlanExpenses";
            this.labelPlanExpenses.Size = new System.Drawing.Size(90, 13);
            this.labelPlanExpenses.TabIndex = 14;
            this.labelPlanExpenses.Text = "Plánované výdaje:";
            // 
            // sePlanEarnings
            // 
            this.sePlanEarnings.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.sePlanEarnings.Location = new System.Drawing.Point(12, 50);
            this.sePlanEarnings.Name = "sePlanEarnings";
            this.sePlanEarnings.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.sePlanEarnings.Size = new System.Drawing.Size(132, 20);
            this.sePlanEarnings.TabIndex = 12;
            // 
            // labelPlanEarnings
            // 
            this.labelPlanEarnings.Location = new System.Drawing.Point(12, 31);
            this.labelPlanEarnings.Name = "labelPlanEarnings";
            this.labelPlanEarnings.Size = new System.Drawing.Size(82, 13);
            this.labelPlanEarnings.TabIndex = 1;
            this.labelPlanEarnings.Text = "Plánované příjmy";
            // 
            // groupControl4
            // 
            this.groupControl4.Controls.Add(this.reDescription);
            this.groupControl4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl4.Location = new System.Drawing.Point(0, 255);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(563, 152);
            this.groupControl4.TabIndex = 4;
            this.groupControl4.Text = "Popis projektu";
            // 
            // reDescription
            // 
            this.reDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reDescription.Location = new System.Drawing.Point(2, 23);
            this.reDescription.Name = "reDescription";
            this.reDescription.ReadOnly = false;
            this.reDescription.Size = new System.Drawing.Size(559, 127);
            this.reDescription.TabIndex = 1;
            // 
            // fmNewProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 446);
            this.Controls.Add(this.groupControl4);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupBasicInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fmNewProject";
            this.Text = "Nový projekt";
            this.Controls.SetChildIndex(this.panelActionBar, 0);
            this.Controls.SetChildIndex(this.groupBasicInfo, 0);
            this.Controls.SetChildIndex(this.groupControl2, 0);
            this.Controls.SetChildIndex(this.groupControl3, 0);
            this.Controls.SetChildIndex(this.groupControl4, 0);
            ((System.ComponentModel.ISupportInitialize)(this.panelActionBar)).EndInit();
            this.panelActionBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupBasicInfo)).EndInit();
            this.groupBasicInfo.ResumeLayout(false);
            this.groupBasicInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbPriority.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceCategory.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teProjectName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teMainContact.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbCustomer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.groupControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deDeadline.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDeadline.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dePlanStart.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dePlanStart.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sePlanExpenses.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sePlanEarnings.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupBasicInfo;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.TextEdit teProjectName;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.ComboBoxEdit cbPriority;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.ComboBoxEdit ceCategory;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelCustomerName;
        private DevExpress.XtraEditors.ComboBoxEdit cbCustomer;
        private DevExpress.XtraEditors.LabelControl labelMainContact;
        private DevExpress.XtraEditors.TextEdit teMainContact;
        private DevExpress.XtraEditors.LabelControl labelPlanEarnings;
        private DevExpress.XtraEditors.SpinEdit sePlanEarnings;
        private DevExpress.XtraEditors.LabelControl labelPlanExpenses;
        private DevExpress.XtraEditors.SpinEdit sePlanExpenses;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.DateEdit dePlanStart;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.DateEdit deDeadline;
        private DevExpress.XtraEditors.GroupControl groupControl4;
        private Components.QRichEdit reDescription;
    }
}