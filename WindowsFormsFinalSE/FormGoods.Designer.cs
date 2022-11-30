namespace WindowsFormsFinalSE
{
    partial class FormGoods
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manufactureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sellingPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gPhotoDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.goodBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.finalSEDataSet1 = new WindowsFormsFinalSE.FinalSEDataSet1();
            this.goodTableAdapter = new WindowsFormsFinalSE.FinalSEDataSet1TableAdapters.GoodTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalSEDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gIDDataGridViewTextBoxColumn,
            this.gNameDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.manufactureDataGridViewTextBoxColumn,
            this.sellingPriceDataGridViewTextBoxColumn,
            this.gPhotoDataGridViewImageColumn});
            this.dataGridView1.DataSource = this.goodBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(271, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(799, 367);
            this.dataGridView1.TabIndex = 0;
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
            // gNameDataGridViewTextBoxColumn
            // 
            this.gNameDataGridViewTextBoxColumn.DataPropertyName = "GName";
            this.gNameDataGridViewTextBoxColumn.HeaderText = "GName";
            this.gNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.gNameDataGridViewTextBoxColumn.Name = "gNameDataGridViewTextBoxColumn";
            this.gNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.gNameDataGridViewTextBoxColumn.Width = 125;
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
            // manufactureDataGridViewTextBoxColumn
            // 
            this.manufactureDataGridViewTextBoxColumn.DataPropertyName = "Manufacture";
            this.manufactureDataGridViewTextBoxColumn.HeaderText = "Manufacture";
            this.manufactureDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.manufactureDataGridViewTextBoxColumn.Name = "manufactureDataGridViewTextBoxColumn";
            this.manufactureDataGridViewTextBoxColumn.ReadOnly = true;
            this.manufactureDataGridViewTextBoxColumn.Width = 125;
            // 
            // sellingPriceDataGridViewTextBoxColumn
            // 
            this.sellingPriceDataGridViewTextBoxColumn.DataPropertyName = "SellingPrice";
            this.sellingPriceDataGridViewTextBoxColumn.HeaderText = "SellingPrice";
            this.sellingPriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sellingPriceDataGridViewTextBoxColumn.Name = "sellingPriceDataGridViewTextBoxColumn";
            this.sellingPriceDataGridViewTextBoxColumn.ReadOnly = true;
            this.sellingPriceDataGridViewTextBoxColumn.Width = 125;
            // 
            // gPhotoDataGridViewImageColumn
            // 
            this.gPhotoDataGridViewImageColumn.DataPropertyName = "GPhoto";
            this.gPhotoDataGridViewImageColumn.HeaderText = "GPhoto";
            this.gPhotoDataGridViewImageColumn.MinimumWidth = 6;
            this.gPhotoDataGridViewImageColumn.Name = "gPhotoDataGridViewImageColumn";
            this.gPhotoDataGridViewImageColumn.ReadOnly = true;
            this.gPhotoDataGridViewImageColumn.Width = 125;
            // 
            // goodBindingSource
            // 
            this.goodBindingSource.DataMember = "Good";
            this.goodBindingSource.DataSource = this.finalSEDataSet1;
            // 
            // finalSEDataSet1
            // 
            this.finalSEDataSet1.DataSetName = "FinalSEDataSet1";
            this.finalSEDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // goodTableAdapter
            // 
            this.goodTableAdapter.ClearBeforeFill = true;
            // 
            // FormGoods
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormGoods";
            this.Text = "FormGoods";
            this.Load += new System.EventHandler(this.FormGoods_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalSEDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private FinalSEDataSet1 finalSEDataSet1;
        private System.Windows.Forms.BindingSource goodBindingSource;
        private FinalSEDataSet1TableAdapters.GoodTableAdapter goodTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn gIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn manufactureDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sellingPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn gPhotoDataGridViewImageColumn;
    }
}