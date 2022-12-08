namespace WindowsFormsFinalSE
{
    partial class FormImport
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnImport = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtTotalPrice = new System.Windows.Forms.TextBox();
            this.lbTotalPrice = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.groupBoxGood = new System.Windows.Forms.GroupBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.lbQuantity = new System.Windows.Forms.Label();
            this.comboBoxGID = new System.Windows.Forms.ComboBox();
            this.goodBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.goodimportDataSet = new WindowsFormsFinalSE.goodimportDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePickerImport = new System.Windows.Forms.DateTimePicker();
            this.txtGName = new System.Windows.Forms.TextBox();
            this.txtImportID = new System.Windows.Forms.TextBox();
            this.lbDate = new System.Windows.Forms.Label();
            this.lbGName = new System.Windows.Forms.Label();
            this.lbGID = new System.Windows.Forms.Label();
            this.lbImportID = new System.Windows.Forms.Label();
            this.groupBoxAcc = new System.Windows.Forms.GroupBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.comboBoxID = new System.Windows.Forms.ComboBox();
            this.accountantBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accoutantimportDataset = new WindowsFormsFinalSE.accoutantimportDataset();
            this.lbName = new System.Windows.Forms.Label();
            this.lbID = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ImportGridView = new System.Windows.Forms.DataGridView();
            this.accountantTableAdapter = new WindowsFormsFinalSE.accoutantimportDatasetTableAdapters.AccountantTableAdapter();
            this.goodTableAdapter = new WindowsFormsFinalSE.goodimportDataSetTableAdapters.GoodTableAdapter();
            this.finalSEDataSetImport = new WindowsFormsFinalSE.FinalSEDataSetImport();
            this.importBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.importTableAdapter = new WindowsFormsFinalSE.FinalSEDataSetImportTableAdapters.ImportTableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBoxGood.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.goodBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodimportDataSet)).BeginInit();
            this.groupBoxAcc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accountantBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accoutantimportDataset)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImportGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalSEDataSetImport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.importBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnImport);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.btnEdit);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.txtTotalPrice);
            this.panel1.Controls.Add(this.lbTotalPrice);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 418);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1202, 55);
            this.panel1.TabIndex = 0;
            // 
            // btnImport
            // 
            this.btnImport.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImport.Location = new System.Drawing.Point(366, 8);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(172, 38);
            this.btnImport.TabIndex = 5;
            this.btnImport.Text = "Import";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(239, 8);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 38);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(124, 8);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 38);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(16, 8);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 38);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalPrice.Location = new System.Drawing.Point(759, 5);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.Size = new System.Drawing.Size(299, 32);
            this.txtTotalPrice.TabIndex = 1;
            // 
            // lbTotalPrice
            // 
            this.lbTotalPrice.AutoSize = true;
            this.lbTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalPrice.Location = new System.Drawing.Point(647, 12);
            this.lbTotalPrice.Name = "lbTotalPrice";
            this.lbTotalPrice.Size = new System.Drawing.Size(116, 25);
            this.lbTotalPrice.TabIndex = 0;
            this.lbTotalPrice.Text = "Total Price: ";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(360, 418);
            this.panel2.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.groupBoxGood);
            this.panel4.Controls.Add(this.groupBoxAcc);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(360, 418);
            this.panel4.TabIndex = 3;
            // 
            // groupBoxGood
            // 
            this.groupBoxGood.Controls.Add(this.txtQuantity);
            this.groupBoxGood.Controls.Add(this.lbQuantity);
            this.groupBoxGood.Controls.Add(this.comboBoxGID);
            this.groupBoxGood.Controls.Add(this.label1);
            this.groupBoxGood.Controls.Add(this.dateTimePickerImport);
            this.groupBoxGood.Controls.Add(this.txtGName);
            this.groupBoxGood.Controls.Add(this.txtImportID);
            this.groupBoxGood.Controls.Add(this.lbDate);
            this.groupBoxGood.Controls.Add(this.lbGName);
            this.groupBoxGood.Controls.Add(this.lbGID);
            this.groupBoxGood.Controls.Add(this.lbImportID);
            this.groupBoxGood.Location = new System.Drawing.Point(0, 122);
            this.groupBoxGood.Name = "groupBoxGood";
            this.groupBoxGood.Size = new System.Drawing.Size(360, 296);
            this.groupBoxGood.TabIndex = 1;
            this.groupBoxGood.TabStop = false;
            this.groupBoxGood.Text = "Goods infor:";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.Location = new System.Drawing.Point(124, 174);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(121, 26);
            this.txtQuantity.TabIndex = 11;
            // 
            // lbQuantity
            // 
            this.lbQuantity.AutoSize = true;
            this.lbQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQuantity.Location = new System.Drawing.Point(17, 180);
            this.lbQuantity.Name = "lbQuantity";
            this.lbQuantity.Size = new System.Drawing.Size(71, 20);
            this.lbQuantity.TabIndex = 10;
            this.lbQuantity.Text = "Quantity";
            // 
            // comboBoxGID
            // 
            this.comboBoxGID.DataSource = this.goodBindingSource;
            this.comboBoxGID.DisplayMember = "GID";
            this.comboBoxGID.FormattingEnabled = true;
            this.comboBoxGID.Location = new System.Drawing.Point(124, 83);
            this.comboBoxGID.Name = "comboBoxGID";
            this.comboBoxGID.Size = new System.Drawing.Size(121, 24);
            this.comboBoxGID.TabIndex = 9;
            this.comboBoxGID.ValueMember = "GID";
            this.comboBoxGID.SelectedIndexChanged += new System.EventHandler(this.comboBoxGID_SelectedIndexChanged);
            // 
            // goodBindingSource
            // 
            this.goodBindingSource.DataMember = "Good";
            this.goodBindingSource.DataSource = this.goodimportDataSet;
            // 
            // goodimportDataSet
            // 
            this.goodimportDataSet.DataSetName = "goodimportDataSet";
            this.goodimportDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(27, 268);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "double click to delete row";
            // 
            // dateTimePickerImport
            // 
            this.dateTimePickerImport.Location = new System.Drawing.Point(120, 230);
            this.dateTimePickerImport.Name = "dateTimePickerImport";
            this.dateTimePickerImport.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerImport.TabIndex = 7;
            // 
            // txtGName
            // 
            this.txtGName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGName.Location = new System.Drawing.Point(124, 131);
            this.txtGName.Name = "txtGName";
            this.txtGName.ReadOnly = true;
            this.txtGName.Size = new System.Drawing.Size(230, 26);
            this.txtGName.TabIndex = 5;
            // 
            // txtImportID
            // 
            this.txtImportID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImportID.Location = new System.Drawing.Point(124, 27);
            this.txtImportID.Name = "txtImportID";
            this.txtImportID.Size = new System.Drawing.Size(121, 26);
            this.txtImportID.TabIndex = 4;
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDate.Location = new System.Drawing.Point(17, 230);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(97, 20);
            this.lbDate.TabIndex = 3;
            this.lbDate.Text = "Import Date";
            // 
            // lbGName
            // 
            this.lbGName.AutoSize = true;
            this.lbGName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGName.Location = new System.Drawing.Point(17, 137);
            this.lbGName.Name = "lbGName";
            this.lbGName.Size = new System.Drawing.Size(53, 20);
            this.lbGName.TabIndex = 2;
            this.lbGName.Text = "Name";
            // 
            // lbGID
            // 
            this.lbGID.AutoSize = true;
            this.lbGID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGID.Location = new System.Drawing.Point(17, 83);
            this.lbGID.Name = "lbGID";
            this.lbGID.Size = new System.Drawing.Size(39, 20);
            this.lbGID.TabIndex = 1;
            this.lbGID.Text = "GID";
            // 
            // lbImportID
            // 
            this.lbImportID.AutoSize = true;
            this.lbImportID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbImportID.Location = new System.Drawing.Point(16, 33);
            this.lbImportID.Name = "lbImportID";
            this.lbImportID.Size = new System.Drawing.Size(73, 20);
            this.lbImportID.TabIndex = 0;
            this.lbImportID.Text = "ImportID";
            // 
            // groupBoxAcc
            // 
            this.groupBoxAcc.Controls.Add(this.txtName);
            this.groupBoxAcc.Controls.Add(this.comboBoxID);
            this.groupBoxAcc.Controls.Add(this.lbName);
            this.groupBoxAcc.Controls.Add(this.lbID);
            this.groupBoxAcc.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxAcc.Location = new System.Drawing.Point(0, 0);
            this.groupBoxAcc.Name = "groupBoxAcc";
            this.groupBoxAcc.Size = new System.Drawing.Size(360, 125);
            this.groupBoxAcc.TabIndex = 0;
            this.groupBoxAcc.TabStop = false;
            this.groupBoxAcc.Text = "Acountant info:";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(78, 79);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(216, 26);
            this.txtName.TabIndex = 4;
            // 
            // comboBoxID
            // 
            this.comboBoxID.DataSource = this.accountantBindingSource;
            this.comboBoxID.DisplayMember = "ID";
            this.comboBoxID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxID.FormattingEnabled = true;
            this.comboBoxID.Location = new System.Drawing.Point(78, 30);
            this.comboBoxID.Name = "comboBoxID";
            this.comboBoxID.Size = new System.Drawing.Size(97, 28);
            this.comboBoxID.TabIndex = 3;
            this.comboBoxID.ValueMember = "ID";
            this.comboBoxID.SelectedIndexChanged += new System.EventHandler(this.comboBoxID_SelectedIndexChanged);
            // 
            // accountantBindingSource
            // 
            this.accountantBindingSource.DataMember = "Accountant";
            this.accountantBindingSource.DataSource = this.accoutantimportDataset;
            // 
            // accoutantimportDataset
            // 
            this.accoutantimportDataset.DataSetName = "accoutantimportDataset";
            this.accoutantimportDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(12, 85);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(58, 20);
            this.lbName.TabIndex = 2;
            this.lbName.Text = "Name:";
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbID.Location = new System.Drawing.Point(12, 38);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(31, 20);
            this.lbID.TabIndex = 1;
            this.lbID.Text = "ID:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.ImportGridView);
            this.panel3.Location = new System.Drawing.Point(379, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(823, 412);
            this.panel3.TabIndex = 3;
            // 
            // ImportGridView
            // 
            this.ImportGridView.AutoGenerateColumns = false;
            this.ImportGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ImportGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ImportGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.gIDDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.totalPriceDataGridViewTextBoxColumn});
            this.ImportGridView.DataSource = this.importBindingSource;
            this.ImportGridView.Location = new System.Drawing.Point(3, 28);
            this.ImportGridView.Name = "ImportGridView";
            this.ImportGridView.RowHeadersWidth = 51;
            this.ImportGridView.RowTemplate.Height = 24;
            this.ImportGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ImportGridView.Size = new System.Drawing.Size(779, 379);
            this.ImportGridView.TabIndex = 0;
            // 
            // accountantTableAdapter
            // 
            this.accountantTableAdapter.ClearBeforeFill = true;
            // 
            // goodTableAdapter
            // 
            this.goodTableAdapter.ClearBeforeFill = true;
            // 
            // finalSEDataSetImport
            // 
            this.finalSEDataSetImport.DataSetName = "FinalSEDataSetImport";
            this.finalSEDataSetImport.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // importBindingSource
            // 
            this.importBindingSource.DataMember = "Import";
            this.importBindingSource.DataSource = this.finalSEDataSetImport;
            // 
            // importTableAdapter
            // 
            this.importTableAdapter.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // gIDDataGridViewTextBoxColumn
            // 
            this.gIDDataGridViewTextBoxColumn.DataPropertyName = "GID";
            this.gIDDataGridViewTextBoxColumn.HeaderText = "GID";
            this.gIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.gIDDataGridViewTextBoxColumn.Name = "gIDDataGridViewTextBoxColumn";
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            // 
            // totalPriceDataGridViewTextBoxColumn
            // 
            this.totalPriceDataGridViewTextBoxColumn.DataPropertyName = "totalPrice";
            this.totalPriceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.totalPriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.totalPriceDataGridViewTextBoxColumn.Name = "totalPriceDataGridViewTextBoxColumn";
            // 
            // FormImport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1202, 473);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormImport";
            this.Text = "Goods Received";
            this.Load += new System.EventHandler(this.FormGoods_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.groupBoxGood.ResumeLayout(false);
            this.groupBoxGood.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.goodBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodimportDataSet)).EndInit();
            this.groupBoxAcc.ResumeLayout(false);
            this.groupBoxAcc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accountantBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accoutantimportDataset)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ImportGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalSEDataSetImport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.importBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtTotalPrice;
        private System.Windows.Forms.Label lbTotalPrice;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView ImportGridView;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.GroupBox groupBoxGood;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePickerImport;
        private System.Windows.Forms.TextBox txtGName;
        private System.Windows.Forms.TextBox txtImportID;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.Label lbGName;
        private System.Windows.Forms.Label lbGID;
        private System.Windows.Forms.Label lbImportID;
        private System.Windows.Forms.GroupBox groupBoxAcc;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.ComboBox comboBoxGID;
        private System.Windows.Forms.ComboBox comboBoxID;
        private accoutantimportDataset accoutantimportDataset;
        private System.Windows.Forms.BindingSource accountantBindingSource;
        private accoutantimportDatasetTableAdapters.AccountantTableAdapter accountantTableAdapter;
        private goodimportDataSet goodimportDataSet;
        private System.Windows.Forms.BindingSource goodBindingSource;
        private goodimportDataSetTableAdapters.GoodTableAdapter goodTableAdapter;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label lbQuantity;
        private FinalSEDataSetImport finalSEDataSetImport;
        private System.Windows.Forms.BindingSource importBindingSource;
        private FinalSEDataSetImportTableAdapters.ImportTableAdapter importTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPriceDataGridViewTextBoxColumn;
    }
}