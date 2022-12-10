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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.tabControlReport = new System.Windows.Forms.TabControl();
            this.tabPageTopSelling = new System.Windows.Forms.TabPage();
            this.dataGridViewTopSelling = new System.Windows.Forms.DataGridView();
            this.tabPageIncome = new System.Windows.Forms.TabPage();
            this.dataGridViewIncome = new System.Windows.Forms.DataGridView();
            this.tabPageOutcome = new System.Windows.Forms.TabPage();
            this.dataGridViewOutcome = new System.Windows.Forms.DataGridView();
            this.tabPageRevenue = new System.Windows.Forms.TabPage();
            this.dataGridViewRevenue = new System.Windows.Forms.DataGridView();
            this.finalSEDataSetSold = new WindowsFormsFinalSE.FinalSEDataSetSold();
            this.incomeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.incomeTableAdapter = new WindowsFormsFinalSE.FinalSEDataSetSoldTableAdapters.IncomeTableAdapter();
            this.expr1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goodsStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lb_From = new System.Windows.Forms.Label();
            this.dateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.labelTo = new System.Windows.Forms.Label();
            this.dateTimePickerTo = new System.Windows.Forms.DateTimePicker();
            this.comboBoxSort = new System.Windows.Forms.ComboBox();
            this.labelSort = new System.Windows.Forms.Label();
            this.btnLoad = new System.Windows.Forms.Button();
            this.tabControlReport.SuspendLayout();
            this.tabPageTopSelling.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTopSelling)).BeginInit();
            this.tabPageIncome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIncome)).BeginInit();
            this.tabPageOutcome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutcome)).BeginInit();
            this.tabPageRevenue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRevenue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalSEDataSetSold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.incomeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBottom
            // 
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 424);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(1201, 100);
            this.panelBottom.TabIndex = 0;
            // 
            // tabControlReport
            // 
            this.tabControlReport.Controls.Add(this.tabPageTopSelling);
            this.tabControlReport.Controls.Add(this.tabPageIncome);
            this.tabControlReport.Controls.Add(this.tabPageOutcome);
            this.tabControlReport.Controls.Add(this.tabPageRevenue);
            this.tabControlReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlReport.Location = new System.Drawing.Point(0, 0);
            this.tabControlReport.Name = "tabControlReport";
            this.tabControlReport.SelectedIndex = 0;
            this.tabControlReport.Size = new System.Drawing.Size(1201, 424);
            this.tabControlReport.TabIndex = 1;
            // 
            // tabPageTopSelling
            // 
            this.tabPageTopSelling.Controls.Add(this.btnLoad);
            this.tabPageTopSelling.Controls.Add(this.labelSort);
            this.tabPageTopSelling.Controls.Add(this.comboBoxSort);
            this.tabPageTopSelling.Controls.Add(this.dateTimePickerTo);
            this.tabPageTopSelling.Controls.Add(this.labelTo);
            this.tabPageTopSelling.Controls.Add(this.dateTimePickerFrom);
            this.tabPageTopSelling.Controls.Add(this.lb_From);
            this.tabPageTopSelling.Controls.Add(this.dataGridViewTopSelling);
            this.tabPageTopSelling.Location = new System.Drawing.Point(4, 25);
            this.tabPageTopSelling.Name = "tabPageTopSelling";
            this.tabPageTopSelling.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTopSelling.Size = new System.Drawing.Size(1193, 395);
            this.tabPageTopSelling.TabIndex = 0;
            this.tabPageTopSelling.Text = "Top Selling";
            this.tabPageTopSelling.UseVisualStyleBackColor = true;
            // 
            // dataGridViewTopSelling
            // 
            this.dataGridViewTopSelling.AutoGenerateColumns = false;
            this.dataGridViewTopSelling.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTopSelling.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.expr1DataGridViewTextBoxColumn,
            this.totalPriceDataGridViewTextBoxColumn,
            this.orderDateDataGridViewTextBoxColumn,
            this.goodsStatusDataGridViewTextBoxColumn,
            this.paymentStatusDataGridViewTextBoxColumn});
            this.dataGridViewTopSelling.DataSource = this.incomeBindingSource;
            this.dataGridViewTopSelling.Location = new System.Drawing.Point(507, 3);
            this.dataGridViewTopSelling.Name = "dataGridViewTopSelling";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTopSelling.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewTopSelling.RowHeadersWidth = 51;
            this.dataGridViewTopSelling.RowTemplate.Height = 24;
            this.dataGridViewTopSelling.Size = new System.Drawing.Size(678, 389);
            this.dataGridViewTopSelling.TabIndex = 0;
            // 
            // tabPageIncome
            // 
            this.tabPageIncome.Controls.Add(this.dataGridViewIncome);
            this.tabPageIncome.Location = new System.Drawing.Point(4, 25);
            this.tabPageIncome.Name = "tabPageIncome";
            this.tabPageIncome.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageIncome.Size = new System.Drawing.Size(1193, 395);
            this.tabPageIncome.TabIndex = 1;
            this.tabPageIncome.Text = "Income";
            this.tabPageIncome.UseVisualStyleBackColor = true;
            // 
            // dataGridViewIncome
            // 
            this.dataGridViewIncome.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewIncome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewIncome.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewIncome.Name = "dataGridViewIncome";
            this.dataGridViewIncome.RowHeadersWidth = 51;
            this.dataGridViewIncome.RowTemplate.Height = 24;
            this.dataGridViewIncome.Size = new System.Drawing.Size(1187, 389);
            this.dataGridViewIncome.TabIndex = 1;
            // 
            // tabPageOutcome
            // 
            this.tabPageOutcome.Controls.Add(this.dataGridViewOutcome);
            this.tabPageOutcome.Location = new System.Drawing.Point(4, 25);
            this.tabPageOutcome.Name = "tabPageOutcome";
            this.tabPageOutcome.Size = new System.Drawing.Size(1193, 395);
            this.tabPageOutcome.TabIndex = 2;
            this.tabPageOutcome.Text = "Outcome";
            this.tabPageOutcome.UseVisualStyleBackColor = true;
            // 
            // dataGridViewOutcome
            // 
            this.dataGridViewOutcome.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOutcome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewOutcome.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewOutcome.Name = "dataGridViewOutcome";
            this.dataGridViewOutcome.RowHeadersWidth = 51;
            this.dataGridViewOutcome.RowTemplate.Height = 24;
            this.dataGridViewOutcome.Size = new System.Drawing.Size(1193, 395);
            this.dataGridViewOutcome.TabIndex = 1;
            // 
            // tabPageRevenue
            // 
            this.tabPageRevenue.Controls.Add(this.dataGridViewRevenue);
            this.tabPageRevenue.Location = new System.Drawing.Point(4, 25);
            this.tabPageRevenue.Name = "tabPageRevenue";
            this.tabPageRevenue.Size = new System.Drawing.Size(1193, 395);
            this.tabPageRevenue.TabIndex = 3;
            this.tabPageRevenue.Text = "Revenue";
            this.tabPageRevenue.UseVisualStyleBackColor = true;
            // 
            // dataGridViewRevenue
            // 
            this.dataGridViewRevenue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRevenue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewRevenue.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewRevenue.Name = "dataGridViewRevenue";
            this.dataGridViewRevenue.RowHeadersWidth = 51;
            this.dataGridViewRevenue.RowTemplate.Height = 24;
            this.dataGridViewRevenue.Size = new System.Drawing.Size(1193, 395);
            this.dataGridViewRevenue.TabIndex = 1;
            // 
            // finalSEDataSetSold
            // 
            this.finalSEDataSetSold.DataSetName = "FinalSEDataSetSold";
            this.finalSEDataSetSold.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // incomeBindingSource
            // 
            this.incomeBindingSource.DataMember = "Income";
            this.incomeBindingSource.DataSource = this.finalSEDataSetSold;
            // 
            // incomeTableAdapter
            // 
            this.incomeTableAdapter.ClearBeforeFill = true;
            // 
            // expr1DataGridViewTextBoxColumn
            // 
            this.expr1DataGridViewTextBoxColumn.DataPropertyName = "GID";
            this.expr1DataGridViewTextBoxColumn.HeaderText = "GID";
            this.expr1DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.expr1DataGridViewTextBoxColumn.Name = "expr1DataGridViewTextBoxColumn";
            this.expr1DataGridViewTextBoxColumn.Width = 125;
            // 
            // totalPriceDataGridViewTextBoxColumn
            // 
            this.totalPriceDataGridViewTextBoxColumn.DataPropertyName = "TotalPrice";
            this.totalPriceDataGridViewTextBoxColumn.HeaderText = "Total Price";
            this.totalPriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.totalPriceDataGridViewTextBoxColumn.Name = "totalPriceDataGridViewTextBoxColumn";
            this.totalPriceDataGridViewTextBoxColumn.Width = 125;
            // 
            // orderDateDataGridViewTextBoxColumn
            // 
            this.orderDateDataGridViewTextBoxColumn.DataPropertyName = "OrderDate";
            this.orderDateDataGridViewTextBoxColumn.HeaderText = "Order Date";
            this.orderDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.orderDateDataGridViewTextBoxColumn.Name = "orderDateDataGridViewTextBoxColumn";
            this.orderDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // goodsStatusDataGridViewTextBoxColumn
            // 
            this.goodsStatusDataGridViewTextBoxColumn.DataPropertyName = "GoodsStatus";
            this.goodsStatusDataGridViewTextBoxColumn.HeaderText = "Goods Status";
            this.goodsStatusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.goodsStatusDataGridViewTextBoxColumn.Name = "goodsStatusDataGridViewTextBoxColumn";
            this.goodsStatusDataGridViewTextBoxColumn.Width = 125;
            // 
            // paymentStatusDataGridViewTextBoxColumn
            // 
            this.paymentStatusDataGridViewTextBoxColumn.DataPropertyName = "PaymentStatus";
            this.paymentStatusDataGridViewTextBoxColumn.HeaderText = "Payment Status";
            this.paymentStatusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.paymentStatusDataGridViewTextBoxColumn.Name = "paymentStatusDataGridViewTextBoxColumn";
            this.paymentStatusDataGridViewTextBoxColumn.Width = 125;
            // 
            // lb_From
            // 
            this.lb_From.AutoSize = true;
            this.lb_From.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_From.Location = new System.Drawing.Point(8, 17);
            this.lb_From.Name = "lb_From";
            this.lb_From.Size = new System.Drawing.Size(126, 20);
            this.lb_From.TabIndex = 1;
            this.lb_From.Text = " Filter By: From";
            // 
            // dateTimePickerFrom
            // 
            this.dateTimePickerFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerFrom.Location = new System.Drawing.Point(154, 17);
            this.dateTimePickerFrom.Name = "dateTimePickerFrom";
            this.dateTimePickerFrom.Size = new System.Drawing.Size(97, 26);
            this.dateTimePickerFrom.TabIndex = 2;
            // 
            // labelTo
            // 
            this.labelTo.AutoSize = true;
            this.labelTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTo.Location = new System.Drawing.Point(69, 70);
            this.labelTo.Name = "labelTo";
            this.labelTo.Size = new System.Drawing.Size(33, 20);
            this.labelTo.TabIndex = 3;
            this.labelTo.Text = "To:";
            // 
            // dateTimePickerTo
            // 
            this.dateTimePickerTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerTo.Location = new System.Drawing.Point(154, 65);
            this.dateTimePickerTo.Name = "dateTimePickerTo";
            this.dateTimePickerTo.Size = new System.Drawing.Size(97, 26);
            this.dateTimePickerTo.TabIndex = 4;
            // 
            // comboBoxSort
            // 
            this.comboBoxSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSort.FormattingEnabled = true;
            this.comboBoxSort.Items.AddRange(new object[] {
            "Quantity",
            "Total Price"});
            this.comboBoxSort.Location = new System.Drawing.Point(154, 158);
            this.comboBoxSort.Name = "comboBoxSort";
            this.comboBoxSort.Size = new System.Drawing.Size(160, 28);
            this.comboBoxSort.TabIndex = 5;
            this.comboBoxSort.Text = "Select sort type";
            // 
            // labelSort
            // 
            this.labelSort.AutoSize = true;
            this.labelSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSort.Location = new System.Drawing.Point(35, 165);
            this.labelSort.Name = "labelSort";
            this.labelSort.Size = new System.Drawing.Size(67, 20);
            this.labelSort.TabIndex = 6;
            this.labelSort.Text = "Sort by:";
            // 
            // btnLoad
            // 
            this.btnLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.Location = new System.Drawing.Point(154, 300);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(91, 48);
            this.btnLoad.TabIndex = 7;
            this.btnLoad.Text = "Load ";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
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
            this.tabControlReport.ResumeLayout(false);
            this.tabPageTopSelling.ResumeLayout(false);
            this.tabPageTopSelling.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTopSelling)).EndInit();
            this.tabPageIncome.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIncome)).EndInit();
            this.tabPageOutcome.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutcome)).EndInit();
            this.tabPageRevenue.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRevenue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalSEDataSetSold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.incomeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.TabControl tabControlReport;
        private System.Windows.Forms.TabPage tabPageTopSelling;
        private System.Windows.Forms.DataGridView dataGridViewTopSelling;
        private System.Windows.Forms.TabPage tabPageIncome;
        private System.Windows.Forms.TabPage tabPageOutcome;
        private System.Windows.Forms.TabPage tabPageRevenue;
        private System.Windows.Forms.DataGridView dataGridViewIncome;
        private System.Windows.Forms.DataGridView dataGridViewOutcome;
        private System.Windows.Forms.DataGridView dataGridViewRevenue;
        private FinalSEDataSetSold finalSEDataSetSold;
        private System.Windows.Forms.BindingSource incomeBindingSource;
        private FinalSEDataSetSoldTableAdapters.IncomeTableAdapter incomeTableAdapter;
        private System.Windows.Forms.DateTimePicker dateTimePickerTo;
        private System.Windows.Forms.Label labelTo;
        private System.Windows.Forms.DateTimePicker dateTimePickerFrom;
        private System.Windows.Forms.Label lb_From;
        private System.Windows.Forms.DataGridViewTextBoxColumn expr1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodsStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label labelSort;
        private System.Windows.Forms.ComboBox comboBoxSort;
        private System.Windows.Forms.Button btnLoad;
    }
}