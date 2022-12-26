namespace QProject.UI.Projects.Forms
{
    partial class fmProjectTask
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
            this.basicInfoTable = new DevExpress.Utils.Layout.TablePanel();
            this.timeSpanEdit1 = new DevExpress.XtraEditors.TimeSpanEdit();
            this.dateEdit1 = new DevExpress.XtraEditors.DateEdit();
            this.comboBoxEdit2 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.comboBoxEdit1 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit2 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupDescription = new DevExpress.XtraEditors.GroupControl();
            this.reDescription = new QProject.UI.Components.QRichEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panelActionBar)).BeginInit();
            this.panelActionBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBasicInfo)).BeginInit();
            this.groupBasicInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.basicInfoTable)).BeginInit();
            this.basicInfoTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeSpanEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupDescription)).BeginInit();
            this.groupDescription.SuspendLayout();
            this.SuspendLayout();
            // 
            // actionPanelRight
            // 
            this.actionPanelRight.Location = new System.Drawing.Point(262, 2);
            // 
            // panelActionBar
            // 
            this.panelActionBar.Location = new System.Drawing.Point(0, 370);
            this.panelActionBar.Size = new System.Drawing.Size(658, 39);
            // 
            // groupBasicInfo
            // 
            this.groupBasicInfo.Controls.Add(this.basicInfoTable);
            this.groupBasicInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBasicInfo.Location = new System.Drawing.Point(0, 0);
            this.groupBasicInfo.Name = "groupBasicInfo";
            this.groupBasicInfo.Size = new System.Drawing.Size(658, 132);
            this.groupBasicInfo.TabIndex = 2;
            this.groupBasicInfo.Text = "Základní údaje";
            // 
            // basicInfoTable
            // 
            this.basicInfoTable.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F)});
            this.basicInfoTable.Controls.Add(this.timeSpanEdit1);
            this.basicInfoTable.Controls.Add(this.dateEdit1);
            this.basicInfoTable.Controls.Add(this.comboBoxEdit2);
            this.basicInfoTable.Controls.Add(this.comboBoxEdit1);
            this.basicInfoTable.Controls.Add(this.labelControl4);
            this.basicInfoTable.Controls.Add(this.textEdit2);
            this.basicInfoTable.Controls.Add(this.labelControl3);
            this.basicInfoTable.Controls.Add(this.labelControl6);
            this.basicInfoTable.Controls.Add(this.labelControl5);
            this.basicInfoTable.Controls.Add(this.labelControl2);
            this.basicInfoTable.Controls.Add(this.textEdit1);
            this.basicInfoTable.Controls.Add(this.labelControl1);
            this.basicInfoTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.basicInfoTable.Location = new System.Drawing.Point(2, 23);
            this.basicInfoTable.Name = "basicInfoTable";
            this.basicInfoTable.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F)});
            this.basicInfoTable.Size = new System.Drawing.Size(654, 107);
            this.basicInfoTable.TabIndex = 0;
            // 
            // timeSpanEdit1
            // 
            this.basicInfoTable.SetColumn(this.timeSpanEdit1, 2);
            this.timeSpanEdit1.EditValue = System.TimeSpan.Parse("00:00:00");
            this.timeSpanEdit1.Location = new System.Drawing.Point(330, 82);
            this.timeSpanEdit1.Name = "timeSpanEdit1";
            this.timeSpanEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.basicInfoTable.SetRow(this.timeSpanEdit1, 3);
            this.timeSpanEdit1.Size = new System.Drawing.Size(158, 20);
            this.timeSpanEdit1.TabIndex = 3;
            // 
            // dateEdit1
            // 
            this.basicInfoTable.SetColumn(this.dateEdit1, 3);
            this.dateEdit1.EditValue = null;
            this.dateEdit1.Location = new System.Drawing.Point(494, 82);
            this.dateEdit1.Name = "dateEdit1";
            this.dateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.basicInfoTable.SetRow(this.dateEdit1, 3);
            this.dateEdit1.Size = new System.Drawing.Size(158, 20);
            this.dateEdit1.TabIndex = 3;
            // 
            // comboBoxEdit2
            // 
            this.basicInfoTable.SetColumn(this.comboBoxEdit2, 3);
            this.comboBoxEdit2.Location = new System.Drawing.Point(494, 29);
            this.comboBoxEdit2.Name = "comboBoxEdit2";
            this.comboBoxEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.basicInfoTable.SetRow(this.comboBoxEdit2, 1);
            this.comboBoxEdit2.Size = new System.Drawing.Size(158, 20);
            this.comboBoxEdit2.TabIndex = 3;
            // 
            // comboBoxEdit1
            // 
            this.basicInfoTable.SetColumn(this.comboBoxEdit1, 2);
            this.comboBoxEdit1.Location = new System.Drawing.Point(330, 29);
            this.comboBoxEdit1.Name = "comboBoxEdit1";
            this.comboBoxEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.basicInfoTable.SetRow(this.comboBoxEdit1, 1);
            this.comboBoxEdit1.Size = new System.Drawing.Size(158, 20);
            this.comboBoxEdit1.TabIndex = 3;
            // 
            // labelControl4
            // 
            this.basicInfoTable.SetColumn(this.labelControl4, 3);
            this.labelControl4.Location = new System.Drawing.Point(494, 58);
            this.labelControl4.Name = "labelControl4";
            this.basicInfoTable.SetRow(this.labelControl4, 2);
            this.labelControl4.Size = new System.Drawing.Size(36, 13);
            this.labelControl4.TabIndex = 4;
            this.labelControl4.Text = "Termín:";
            // 
            // textEdit2
            // 
            this.basicInfoTable.SetColumn(this.textEdit2, 0);
            this.basicInfoTable.SetColumnSpan(this.textEdit2, 2);
            this.textEdit2.Location = new System.Drawing.Point(3, 82);
            this.textEdit2.Name = "textEdit2";
            this.basicInfoTable.SetRow(this.textEdit2, 3);
            this.textEdit2.Size = new System.Drawing.Size(322, 20);
            this.textEdit2.TabIndex = 1;
            // 
            // labelControl3
            // 
            this.basicInfoTable.SetColumn(this.labelControl3, 3);
            this.labelControl3.Location = new System.Drawing.Point(494, 6);
            this.labelControl3.Name = "labelControl3";
            this.basicInfoTable.SetRow(this.labelControl3, 0);
            this.labelControl3.Size = new System.Drawing.Size(38, 13);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Priorita:";
            // 
            // labelControl6
            // 
            this.basicInfoTable.SetColumn(this.labelControl6, 0);
            this.labelControl6.Location = new System.Drawing.Point(3, 58);
            this.labelControl6.Name = "labelControl6";
            this.basicInfoTable.SetRow(this.labelControl6, 2);
            this.labelControl6.Size = new System.Drawing.Size(92, 13);
            this.labelControl6.TabIndex = 0;
            this.labelControl6.Text = "Odpovědná osoba:";
            // 
            // labelControl5
            // 
            this.basicInfoTable.SetColumn(this.labelControl5, 2);
            this.labelControl5.Location = new System.Drawing.Point(330, 58);
            this.labelControl5.Name = "labelControl5";
            this.basicInfoTable.SetRow(this.labelControl5, 2);
            this.labelControl5.Size = new System.Drawing.Size(119, 13);
            this.labelControl5.TabIndex = 3;
            this.labelControl5.Text = "Plánovaný strávený čas:";
            // 
            // labelControl2
            // 
            this.basicInfoTable.SetColumn(this.labelControl2, 2);
            this.labelControl2.Location = new System.Drawing.Point(330, 6);
            this.labelControl2.Name = "labelControl2";
            this.basicInfoTable.SetRow(this.labelControl2, 0);
            this.labelControl2.Size = new System.Drawing.Size(50, 13);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Kategorie:";
            // 
            // textEdit1
            // 
            this.basicInfoTable.SetColumn(this.textEdit1, 0);
            this.basicInfoTable.SetColumnSpan(this.textEdit1, 2);
            this.textEdit1.Location = new System.Drawing.Point(3, 29);
            this.textEdit1.Name = "textEdit1";
            this.basicInfoTable.SetRow(this.textEdit1, 1);
            this.textEdit1.Size = new System.Drawing.Size(322, 20);
            this.textEdit1.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.basicInfoTable.SetColumn(this.labelControl1, 0);
            this.labelControl1.Location = new System.Drawing.Point(3, 6);
            this.labelControl1.Name = "labelControl1";
            this.basicInfoTable.SetRow(this.labelControl1, 0);
            this.labelControl1.Size = new System.Drawing.Size(44, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Předmět:";
            // 
            // groupDescription
            // 
            this.groupDescription.Controls.Add(this.reDescription);
            this.groupDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupDescription.Location = new System.Drawing.Point(0, 132);
            this.groupDescription.Name = "groupDescription";
            this.groupDescription.Size = new System.Drawing.Size(658, 277);
            this.groupDescription.TabIndex = 3;
            this.groupDescription.Text = "Popis";
            // 
            // reDescription
            // 
            this.reDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reDescription.Location = new System.Drawing.Point(2, 23);
            this.reDescription.Name = "reDescription";
            this.reDescription.ReadOnly = false;
            this.reDescription.Size = new System.Drawing.Size(654, 252);
            this.reDescription.TabIndex = 0;
            // 
            // fmProjectTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 409);
            this.Controls.Add(this.groupDescription);
            this.Controls.Add(this.groupBasicInfo);
            this.Name = "fmProjectTask";
            this.Text = "Nová úloha";
            this.Controls.SetChildIndex(this.groupBasicInfo, 0);
            this.Controls.SetChildIndex(this.groupDescription, 0);
            this.Controls.SetChildIndex(this.panelActionBar, 0);
            ((System.ComponentModel.ISupportInitialize)(this.panelActionBar)).EndInit();
            this.panelActionBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupBasicInfo)).EndInit();
            this.groupBasicInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.basicInfoTable)).EndInit();
            this.basicInfoTable.ResumeLayout(false);
            this.basicInfoTable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeSpanEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupDescription)).EndInit();
            this.groupDescription.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupBasicInfo;
        private DevExpress.Utils.Layout.TablePanel basicInfoTable;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit textEdit2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TimeSpanEdit timeSpanEdit1;
        private DevExpress.XtraEditors.DateEdit dateEdit1;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEdit2;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEdit1;
        private DevExpress.XtraEditors.GroupControl groupDescription;
        private Components.QRichEdit reDescription;
    }
}