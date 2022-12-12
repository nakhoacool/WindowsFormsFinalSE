namespace WindowsFormsFinalSE
{
    partial class FormReport
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.txtRevenue = new System.Windows.Forms.TextBox();
            this.btnRevenue = new System.Windows.Forms.Button();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.tabControlReport = new System.Windows.Forms.TabControl();
            this.tabPageIncome = new System.Windows.Forms.TabPage();
            this.txtTotalIncome = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnLoadIncome = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxIncomeSort = new System.Windows.Forms.ComboBox();
            this.dateTimePickerIncomeTo = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePickerIncomeFrom = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridViewIncome = new System.Windows.Forms.DataGridView();
            this.tabPageOutcome = new System.Windows.Forms.TabPage();
            this.txtOutcome = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtImport = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnLoadOutcome = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxOutcomeSort = new System.Windows.Forms.ComboBox();
            this.dateTimePickerOutcomeTo = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePickerOutcomeFrom = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridViewOutcome = new System.Windows.Forms.DataGridView();
            this.importIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.importDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vwItemImportedBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.finalSEDataSetItemImported = new WindowsFormsFinalSE.FinalSEDataSetItemImported();
            this.vw_ItemImportedTableAdapter = new WindowsFormsFinalSE.FinalSEDataSetItemImportedTableAdapters.Vw_ItemImportedTableAdapter();
            this.finalSEDataSetIOrderedView = new WindowsFormsFinalSE.FinalSEDataSetIOrderedView();
            this.vwItemOrderedBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vw_ItemOrderedTableAdapter = new WindowsFormsFinalSE.FinalSEDataSetIOrderedViewTableAdapters.Vw_ItemOrderedTableAdapter();
            this.gIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelBottom.SuspendLayout();
            this.tabControlReport.SuspendLayout();
            this.tabPageIncome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIncome)).BeginInit();
            this.tabPageOutcome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutcome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwItemImportedBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalSEDataSetItemImported)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalSEDataSetIOrderedView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwItemOrderedBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBottom
            // 
            this.panelBottom.Controls.Add(this.txtRevenue);
            this.panelBottom.Controls.Add(this.btnRevenue);
            this.panelBottom.Controls.Add(this.dateTimePicker);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 424);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(1201, 100);
            this.panelBottom.TabIndex = 0;
            // 
            // txtRevenue
            // 
            this.txtRevenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRevenue.Location = new System.Drawing.Point(397, 20);
            this.txtRevenue.Name = "txtRevenue";
            this.txtRevenue.ReadOnly = true;
            this.txtRevenue.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtRevenue.Size = new System.Drawing.Size(203, 34);
            this.txtRevenue.TabIndex = 2;
            // 
            // btnRevenue
            // 
            this.btnRevenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRevenue.Location = new System.Drawing.Point(81, 20);
            this.btnRevenue.Name = "btnRevenue";
            this.btnRevenue.Size = new System.Drawing.Size(106, 31);
            this.btnRevenue.TabIndex = 1;
            this.btnRevenue.Text = "Revenue in:";
            this.btnRevenue.UseVisualStyleBackColor = true;
            this.btnRevenue.Click += new System.EventHandler(this.btnRevenue_Click);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CustomFormat = "MM/yyyy";
            this.dateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker.Location = new System.Drawing.Point(221, 25);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.ShowUpDown = true;
            this.dateTimePicker.Size = new System.Drawing.Size(123, 26);
            this.dateTimePicker.TabIndex = 0;
            // 
            // tabControlReport
            // 
            this.tabControlReport.Controls.Add(this.tabPageIncome);
            this.tabControlReport.Controls.Add(this.tabPageOutcome);
            this.tabControlReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlReport.Location = new System.Drawing.Point(0, 0);
            this.tabControlReport.Name = "tabControlReport";
            this.tabControlReport.SelectedIndex = 0;
            this.tabControlReport.Size = new System.Drawing.Size(1201, 424);
            this.tabControlReport.TabIndex = 1;
            // 
            // tabPageIncome
            // 
            this.tabPageIncome.Controls.Add(this.txtTotalIncome);
            this.tabPageIncome.Controls.Add(this.label5);
            this.tabPageIncome.Controls.Add(this.txtTotal);
            this.tabPageIncome.Controls.Add(this.label4);
            this.tabPageIncome.Controls.Add(this.btnLoadIncome);
            this.tabPageIncome.Controls.Add(this.label1);
            this.tabPageIncome.Controls.Add(this.comboBoxIncomeSort);
            this.tabPageIncome.Controls.Add(this.dateTimePickerIncomeTo);
            this.tabPageIncome.Controls.Add(this.label2);
            this.tabPageIncome.Controls.Add(this.dateTimePickerIncomeFrom);
            this.tabPageIncome.Controls.Add(this.label3);
            this.tabPageIncome.Controls.Add(this.dataGridViewIncome);
            this.tabPageIncome.Location = new System.Drawing.Point(4, 25);
            this.tabPageIncome.Name = "tabPageIncome";
            this.tabPageIncome.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageIncome.Size = new System.Drawing.Size(1193, 395);
            this.tabPageIncome.TabIndex = 1;
            this.tabPageIncome.Text = "Income";
            this.tabPageIncome.UseVisualStyleBackColor = true;
            // 
            // txtTotalIncome
            // 
            this.txtTotalIncome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalIncome.Location = new System.Drawing.Point(217, 363);
            this.txtTotalIncome.Name = "txtTotalIncome";
            this.txtTotalIncome.ReadOnly = true;
            this.txtTotalIncome.Size = new System.Drawing.Size(142, 26);
            this.txtTotalIncome.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(96, 362);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Total Income";
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(255, 300);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(105, 26);
            this.txtTotal.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(137, 306);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Sold products:";
            // 
            // btnLoadIncome
            // 
            this.btnLoadIncome.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadIncome.Location = new System.Drawing.Point(15, 244);
            this.btnLoadIncome.Name = "btnLoadIncome";
            this.btnLoadIncome.Size = new System.Drawing.Size(97, 48);
            this.btnLoadIncome.TabIndex = 14;
            this.btnLoadIncome.Text = "Load ";
            this.btnLoadIncome.UseVisualStyleBackColor = true;
            this.btnLoadIncome.Click += new System.EventHandler(this.btnLoadIncome_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Sort by:";
            // 
            // comboBoxIncomeSort
            // 
            this.comboBoxIncomeSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxIncomeSort.FormattingEnabled = true;
            this.comboBoxIncomeSort.Items.AddRange(new object[] {
            "Quantity",
            "Total Price"});
            this.comboBoxIncomeSort.Location = new System.Drawing.Point(164, 178);
            this.comboBoxIncomeSort.Name = "comboBoxIncomeSort";
            this.comboBoxIncomeSort.Size = new System.Drawing.Size(160, 28);
            this.comboBoxIncomeSort.TabIndex = 12;
            this.comboBoxIncomeSort.Text = "Select sort type";
            // 
            // dateTimePickerIncomeTo
            // 
            this.dateTimePickerIncomeTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerIncomeTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerIncomeTo.Location = new System.Drawing.Point(164, 85);
            this.dateTimePickerIncomeTo.Name = "dateTimePickerIncomeTo";
            this.dateTimePickerIncomeTo.Size = new System.Drawing.Size(110, 26);
            this.dateTimePickerIncomeTo.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(79, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "To:";
            // 
            // dateTimePickerIncomeFrom
            // 
            this.dateTimePickerIncomeFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerIncomeFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerIncomeFrom.Location = new System.Drawing.Point(164, 37);
            this.dateTimePickerIncomeFrom.Name = "dateTimePickerIncomeFrom";
            this.dateTimePickerIncomeFrom.Size = new System.Drawing.Size(110, 26);
            this.dateTimePickerIncomeFrom.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = " Filter By: From";
            // 
            // dataGridViewIncome
            // 
            this.dataGridViewIncome.AutoGenerateColumns = false;
            this.dataGridViewIncome.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewIncome.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gIDDataGridViewTextBoxColumn1,
            this.oIDDataGridViewTextBoxColumn,
            this.gNameDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dataGridViewIncome.DataSource = this.vwItemOrderedBindingSource;
            this.dataGridViewIncome.Location = new System.Drawing.Point(393, 4);
            this.dataGridViewIncome.Name = "dataGridViewIncome";
            this.dataGridViewIncome.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewIncome.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewIncome.RowHeadersWidth = 51;
            this.dataGridViewIncome.RowTemplate.Height = 24;
            this.dataGridViewIncome.Size = new System.Drawing.Size(779, 389);
            this.dataGridViewIncome.TabIndex = 2;
            // 
            // tabPageOutcome
            // 
            this.tabPageOutcome.Controls.Add(this.txtOutcome);
            this.tabPageOutcome.Controls.Add(this.label10);
            this.tabPageOutcome.Controls.Add(this.txtImport);
            this.tabPageOutcome.Controls.Add(this.label6);
            this.tabPageOutcome.Controls.Add(this.btnLoadOutcome);
            this.tabPageOutcome.Controls.Add(this.label7);
            this.tabPageOutcome.Controls.Add(this.comboBoxOutcomeSort);
            this.tabPageOutcome.Controls.Add(this.dateTimePickerOutcomeTo);
            this.tabPageOutcome.Controls.Add(this.label8);
            this.tabPageOutcome.Controls.Add(this.dateTimePickerOutcomeFrom);
            this.tabPageOutcome.Controls.Add(this.label9);
            this.tabPageOutcome.Controls.Add(this.dataGridViewOutcome);
            this.tabPageOutcome.Location = new System.Drawing.Point(4, 25);
            this.tabPageOutcome.Name = "tabPageOutcome";
            this.tabPageOutcome.Size = new System.Drawing.Size(1193, 395);
            this.tabPageOutcome.TabIndex = 2;
            this.tabPageOutcome.Text = "Outcome";
            this.tabPageOutcome.UseVisualStyleBackColor = true;
            // 
            // txtOutcome
            // 
            this.txtOutcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOutcome.Location = new System.Drawing.Point(235, 336);
            this.txtOutcome.Name = "txtOutcome";
            this.txtOutcome.ReadOnly = true;
            this.txtOutcome.Size = new System.Drawing.Size(142, 26);
            this.txtOutcome.TabIndex = 26;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(117, 342);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(119, 20);
            this.label10.TabIndex = 25;
            this.label10.Text = "Total Outcome";
            // 
            // txtImport
            // 
            this.txtImport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImport.Location = new System.Drawing.Point(235, 304);
            this.txtImport.Name = "txtImport";
            this.txtImport.ReadOnly = true;
            this.txtImport.Size = new System.Drawing.Size(105, 26);
            this.txtImport.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(117, 310);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Imported:";
            // 
            // btnLoadOutcome
            // 
            this.btnLoadOutcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadOutcome.Location = new System.Drawing.Point(2, 310);
            this.btnLoadOutcome.Name = "btnLoadOutcome";
            this.btnLoadOutcome.Size = new System.Drawing.Size(97, 48);
            this.btnLoadOutcome.TabIndex = 24;
            this.btnLoadOutcome.Text = "Load ";
            this.btnLoadOutcome.UseVisualStyleBackColor = true;
            this.btnLoadOutcome.Click += new System.EventHandler(this.btnLoadOutcome_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(39, 184);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 20);
            this.label7.TabIndex = 23;
            this.label7.Text = "Sort by:";
            // 
            // comboBoxOutcomeSort
            // 
            this.comboBoxOutcomeSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxOutcomeSort.FormattingEnabled = true;
            this.comboBoxOutcomeSort.Items.AddRange(new object[] {
            "Quantity",
            "Total Price"});
            this.comboBoxOutcomeSort.Location = new System.Drawing.Point(158, 177);
            this.comboBoxOutcomeSort.Name = "comboBoxOutcomeSort";
            this.comboBoxOutcomeSort.Size = new System.Drawing.Size(160, 28);
            this.comboBoxOutcomeSort.TabIndex = 22;
            this.comboBoxOutcomeSort.Text = "Select sort type";
            // 
            // dateTimePickerOutcomeTo
            // 
            this.dateTimePickerOutcomeTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerOutcomeTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerOutcomeTo.Location = new System.Drawing.Point(158, 84);
            this.dateTimePickerOutcomeTo.Name = "dateTimePickerOutcomeTo";
            this.dateTimePickerOutcomeTo.Size = new System.Drawing.Size(110, 26);
            this.dateTimePickerOutcomeTo.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(73, 89);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 20);
            this.label8.TabIndex = 20;
            this.label8.Text = "To:";
            // 
            // dateTimePickerOutcomeFrom
            // 
            this.dateTimePickerOutcomeFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerOutcomeFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerOutcomeFrom.Location = new System.Drawing.Point(158, 36);
            this.dateTimePickerOutcomeFrom.Name = "dateTimePickerOutcomeFrom";
            this.dateTimePickerOutcomeFrom.Size = new System.Drawing.Size(110, 26);
            this.dateTimePickerOutcomeFrom.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 36);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(126, 20);
            this.label9.TabIndex = 18;
            this.label9.Text = " Filter By: From";
            // 
            // dataGridViewOutcome
            // 
            this.dataGridViewOutcome.AutoGenerateColumns = false;
            this.dataGridViewOutcome.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOutcome.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.importIDDataGridViewTextBoxColumn,
            this.gIDDataGridViewTextBoxColumn,
            this.gNameDataGridViewTextBoxColumn1,
            this.quantityDataGridViewTextBoxColumn1,
            this.priceDataGridViewTextBoxColumn,
            this.importDateDataGridViewTextBoxColumn});
            this.dataGridViewOutcome.DataSource = this.vwItemImportedBindingSource;
            this.dataGridViewOutcome.Location = new System.Drawing.Point(392, 3);
            this.dataGridViewOutcome.Name = "dataGridViewOutcome";
            this.dataGridViewOutcome.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewOutcome.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewOutcome.RowHeadersWidth = 51;
            this.dataGridViewOutcome.RowTemplate.Height = 24;
            this.dataGridViewOutcome.Size = new System.Drawing.Size(799, 389);
            this.dataGridViewOutcome.TabIndex = 17;
            this.dataGridViewOutcome.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewOutcome_CellContentClick);
            // 
            // importIDDataGridViewTextBoxColumn
            // 
            this.importIDDataGridViewTextBoxColumn.DataPropertyName = "ImportID";
            this.importIDDataGridViewTextBoxColumn.HeaderText = "ImportID";
            this.importIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.importIDDataGridViewTextBoxColumn.Name = "importIDDataGridViewTextBoxColumn";
            this.importIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.importIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // gIDDataGridViewTextBoxColumn
            // 
            this.gIDDataGridViewTextBoxColumn.DataPropertyName = "GID";
            this.gIDDataGridViewTextBoxColumn.HeaderText = "GID";
            this.gIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.gIDDataGridViewTextBoxColumn.Name = "gIDDataGridViewTextBoxColumn";
            this.gIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.gIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // gNameDataGridViewTextBoxColumn1
            // 
            this.gNameDataGridViewTextBoxColumn1.DataPropertyName = "GName";
            this.gNameDataGridViewTextBoxColumn1.HeaderText = "Name";
            this.gNameDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.gNameDataGridViewTextBoxColumn1.Name = "gNameDataGridViewTextBoxColumn1";
            this.gNameDataGridViewTextBoxColumn1.ReadOnly = true;
            this.gNameDataGridViewTextBoxColumn1.Width = 125;
            // 
            // quantityDataGridViewTextBoxColumn1
            // 
            this.quantityDataGridViewTextBoxColumn1.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn1.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.quantityDataGridViewTextBoxColumn1.Name = "quantityDataGridViewTextBoxColumn1";
            this.quantityDataGridViewTextBoxColumn1.ReadOnly = true;
            this.quantityDataGridViewTextBoxColumn1.Width = 125;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "price";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            this.priceDataGridViewTextBoxColumn.Width = 125;
            // 
            // importDateDataGridViewTextBoxColumn
            // 
            this.importDateDataGridViewTextBoxColumn.DataPropertyName = "ImportDate";
            this.importDateDataGridViewTextBoxColumn.HeaderText = "Import Date";
            this.importDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.importDateDataGridViewTextBoxColumn.Name = "importDateDataGridViewTextBoxColumn";
            this.importDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.importDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // vwItemImportedBindingSource
            // 
            this.vwItemImportedBindingSource.DataMember = "Vw_ItemImported";
            this.vwItemImportedBindingSource.DataSource = this.finalSEDataSetItemImported;
            // 
            // finalSEDataSetItemImported
            // 
            this.finalSEDataSetItemImported.DataSetName = "FinalSEDataSetItemImported";
            this.finalSEDataSetItemImported.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vw_ItemImportedTableAdapter
            // 
            this.vw_ItemImportedTableAdapter.ClearBeforeFill = true;
            // 
            // finalSEDataSetIOrderedView
            // 
            this.finalSEDataSetIOrderedView.DataSetName = "FinalSEDataSetIOrderedView";
            this.finalSEDataSetIOrderedView.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vwItemOrderedBindingSource
            // 
            this.vwItemOrderedBindingSource.DataMember = "Vw_ItemOrdered";
            this.vwItemOrderedBindingSource.DataSource = this.finalSEDataSetIOrderedView;
            // 
            // vw_ItemOrderedTableAdapter
            // 
            this.vw_ItemOrderedTableAdapter.ClearBeforeFill = true;
            // 
            // gIDDataGridViewTextBoxColumn1
            // 
            this.gIDDataGridViewTextBoxColumn1.DataPropertyName = "GID";
            this.gIDDataGridViewTextBoxColumn1.HeaderText = "GID";
            this.gIDDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.gIDDataGridViewTextBoxColumn1.Name = "gIDDataGridViewTextBoxColumn1";
            this.gIDDataGridViewTextBoxColumn1.ReadOnly = true;
            this.gIDDataGridViewTextBoxColumn1.Width = 75;
            // 
            // oIDDataGridViewTextBoxColumn
            // 
            this.oIDDataGridViewTextBoxColumn.DataPropertyName = "OID";
            this.oIDDataGridViewTextBoxColumn.HeaderText = "OID";
            this.oIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.oIDDataGridViewTextBoxColumn.Name = "oIDDataGridViewTextBoxColumn";
            this.oIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.oIDDataGridViewTextBoxColumn.Width = 75;
            // 
            // gNameDataGridViewTextBoxColumn
            // 
            this.gNameDataGridViewTextBoxColumn.DataPropertyName = "GName";
            this.gNameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.gNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.gNameDataGridViewTextBoxColumn.Name = "gNameDataGridViewTextBoxColumn";
            this.gNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.gNameDataGridViewTextBoxColumn.Width = 200;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.ReadOnly = true;
            this.quantityDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "TotalPrice";
            this.dataGridViewTextBoxColumn1.HeaderText = "Total Price";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "OrderDate";
            this.dataGridViewTextBoxColumn2.HeaderText = "Order Date";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // FormReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1201, 524);
            this.Controls.Add(this.tabControlReport);
            this.Controls.Add(this.panelBottom);
            this.Name = "FormReport";
            this.Text = "Report";
            this.Load += new System.EventHandler(this.FormReport_Load);
            this.panelBottom.ResumeLayout(false);
            this.panelBottom.PerformLayout();
            this.tabControlReport.ResumeLayout(false);
            this.tabPageIncome.ResumeLayout(false);
            this.tabPageIncome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIncome)).EndInit();
            this.tabPageOutcome.ResumeLayout(false);
            this.tabPageOutcome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutcome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwItemImportedBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalSEDataSetItemImported)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalSEDataSetIOrderedView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwItemOrderedBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.TabControl tabControlReport;
        private System.Windows.Forms.TabPage tabPageIncome;
        private System.Windows.Forms.TabPage tabPageOutcome;
        private System.Windows.Forms.DataGridViewTextBoxColumn expr1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodsStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnLoadIncome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxIncomeSort;
        private System.Windows.Forms.DateTimePicker dateTimePickerIncomeTo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePickerIncomeFrom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridViewIncome;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTotalIncome;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtImport;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnLoadOutcome;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxOutcomeSort;
        private System.Windows.Forms.DateTimePicker dateTimePickerOutcomeTo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimePickerOutcomeFrom;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dataGridViewOutcome;
        private System.Windows.Forms.TextBox txtOutcome;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Button btnRevenue;
        private System.Windows.Forms.TextBox txtRevenue;
        private FinalSEDataSetItemImported finalSEDataSetItemImported;
        private System.Windows.Forms.BindingSource vwItemImportedBindingSource;
        private FinalSEDataSetItemImportedTableAdapters.Vw_ItemImportedTableAdapter vw_ItemImportedTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn importIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn importDateDataGridViewTextBoxColumn;
        private FinalSEDataSetIOrderedView finalSEDataSetIOrderedView;
        private System.Windows.Forms.BindingSource vwItemOrderedBindingSource;
        private FinalSEDataSetIOrderedViewTableAdapters.Vw_ItemOrderedTableAdapter vw_ItemOrderedTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn gIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn oIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}