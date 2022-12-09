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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxGoodID = new System.Windows.Forms.TextBox();
            this.textBoxGoodName = new System.Windows.Forms.TextBox();
            this.textBoxGoodManu = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonGoodBrowse = new System.Windows.Forms.Button();
            this.pictureBoxGoodPhoto = new System.Windows.Forms.PictureBox();
            this.buttonGoodSave = new System.Windows.Forms.Button();
            this.textBoxGoodQuantity = new System.Windows.Forms.TextBox();
            this.textBoxGoodSell = new System.Windows.Forms.TextBox();
            this.goodGridView = new System.Windows.Forms.DataGridView();
            this.buttonGoodDelete = new System.Windows.Forms.Button();
            this.buttonGoodClear = new System.Windows.Forms.Button();
            this.buttonGoodEdit = new System.Windows.Forms.Button();
            this.buttonGoodSearch = new System.Windows.Forms.Button();
            this.finalSEDataSetGood = new WindowsFormsFinalSE.FinalSEDataSetGood();
            this.goodBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.goodTableAdapter = new WindowsFormsFinalSE.FinalSEDataSetGoodTableAdapters.GoodTableAdapter();
            this.gIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manufactureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.importPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sellingPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gPhotoDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxGoodImpPrice = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGoodPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalSEDataSetGood)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "GID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "GName";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Quantity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Manufacture";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 267);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Selling price";
            // 
            // textBoxGoodID
            // 
            this.textBoxGoodID.Location = new System.Drawing.Point(123, 31);
            this.textBoxGoodID.Name = "textBoxGoodID";
            this.textBoxGoodID.Size = new System.Drawing.Size(137, 22);
            this.textBoxGoodID.TabIndex = 6;
            // 
            // textBoxGoodName
            // 
            this.textBoxGoodName.Location = new System.Drawing.Point(123, 79);
            this.textBoxGoodName.Name = "textBoxGoodName";
            this.textBoxGoodName.Size = new System.Drawing.Size(137, 22);
            this.textBoxGoodName.TabIndex = 7;
            // 
            // textBoxGoodManu
            // 
            this.textBoxGoodManu.Location = new System.Drawing.Point(123, 172);
            this.textBoxGoodManu.Name = "textBoxGoodManu";
            this.textBoxGoodManu.Size = new System.Drawing.Size(137, 22);
            this.textBoxGoodManu.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 326);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Photo";
            // 
            // buttonGoodBrowse
            // 
            this.buttonGoodBrowse.Location = new System.Drawing.Point(123, 485);
            this.buttonGoodBrowse.Name = "buttonGoodBrowse";
            this.buttonGoodBrowse.Size = new System.Drawing.Size(137, 44);
            this.buttonGoodBrowse.TabIndex = 11;
            this.buttonGoodBrowse.Text = "Browse...";
            this.buttonGoodBrowse.UseVisualStyleBackColor = true;
            this.buttonGoodBrowse.Click += new System.EventHandler(this.buttonGoodBrowse_Click);
            // 
            // pictureBoxGoodPhoto
            // 
            this.pictureBoxGoodPhoto.Location = new System.Drawing.Point(84, 326);
            this.pictureBoxGoodPhoto.Name = "pictureBoxGoodPhoto";
            this.pictureBoxGoodPhoto.Size = new System.Drawing.Size(211, 127);
            this.pictureBoxGoodPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxGoodPhoto.TabIndex = 12;
            this.pictureBoxGoodPhoto.TabStop = false;
            // 
            // buttonGoodSave
            // 
            this.buttonGoodSave.Location = new System.Drawing.Point(331, 440);
            this.buttonGoodSave.Name = "buttonGoodSave";
            this.buttonGoodSave.Size = new System.Drawing.Size(99, 44);
            this.buttonGoodSave.TabIndex = 14;
            this.buttonGoodSave.Text = "Add";
            this.buttonGoodSave.UseVisualStyleBackColor = true;
            this.buttonGoodSave.Click += new System.EventHandler(this.buttonGoodSave_Click);
            // 
            // textBoxGoodQuantity
            // 
            this.textBoxGoodQuantity.Location = new System.Drawing.Point(123, 125);
            this.textBoxGoodQuantity.Name = "textBoxGoodQuantity";
            this.textBoxGoodQuantity.Size = new System.Drawing.Size(137, 22);
            this.textBoxGoodQuantity.TabIndex = 15;
            // 
            // textBoxGoodSell
            // 
            this.textBoxGoodSell.Location = new System.Drawing.Point(123, 267);
            this.textBoxGoodSell.Name = "textBoxGoodSell";
            this.textBoxGoodSell.Size = new System.Drawing.Size(137, 22);
            this.textBoxGoodSell.TabIndex = 16;
            // 
            // goodGridView
            // 
            this.goodGridView.AllowUserToAddRows = false;
            this.goodGridView.AllowUserToDeleteRows = false;
            this.goodGridView.AutoGenerateColumns = false;
            this.goodGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.goodGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gIDDataGridViewTextBoxColumn,
            this.gNameDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.manufactureDataGridViewTextBoxColumn,
            this.importPriceDataGridViewTextBoxColumn,
            this.sellingPriceDataGridViewTextBoxColumn,
            this.gPhotoDataGridViewImageColumn});
            this.goodGridView.DataSource = this.goodBindingSource;
            this.goodGridView.Location = new System.Drawing.Point(331, 31);
            this.goodGridView.Name = "goodGridView";
            this.goodGridView.ReadOnly = true;
            this.goodGridView.RowHeadersWidth = 51;
            this.goodGridView.RowTemplate.Height = 24;
            this.goodGridView.Size = new System.Drawing.Size(811, 375);
            this.goodGridView.TabIndex = 17;
            this.goodGridView.SelectionChanged += new System.EventHandler(this.goodGridView_SelectionChanged);
            // 
            // buttonGoodDelete
            // 
            this.buttonGoodDelete.Location = new System.Drawing.Point(331, 490);
            this.buttonGoodDelete.Name = "buttonGoodDelete";
            this.buttonGoodDelete.Size = new System.Drawing.Size(99, 44);
            this.buttonGoodDelete.TabIndex = 18;
            this.buttonGoodDelete.Text = "Delete";
            this.buttonGoodDelete.UseVisualStyleBackColor = true;
            this.buttonGoodDelete.Click += new System.EventHandler(this.buttonGoodDelete_Click);
            // 
            // buttonGoodClear
            // 
            this.buttonGoodClear.Location = new System.Drawing.Point(567, 440);
            this.buttonGoodClear.Name = "buttonGoodClear";
            this.buttonGoodClear.Size = new System.Drawing.Size(99, 44);
            this.buttonGoodClear.TabIndex = 19;
            this.buttonGoodClear.Text = "Clear";
            this.buttonGoodClear.UseVisualStyleBackColor = true;
            this.buttonGoodClear.Click += new System.EventHandler(this.buttonGoodClear_Click);
            // 
            // buttonGoodEdit
            // 
            this.buttonGoodEdit.Location = new System.Drawing.Point(450, 491);
            this.buttonGoodEdit.Name = "buttonGoodEdit";
            this.buttonGoodEdit.Size = new System.Drawing.Size(99, 44);
            this.buttonGoodEdit.TabIndex = 20;
            this.buttonGoodEdit.Text = "Edit";
            this.buttonGoodEdit.UseVisualStyleBackColor = true;
            this.buttonGoodEdit.Click += new System.EventHandler(this.buttonGoodEdit_Click);
            // 
            // buttonGoodSearch
            // 
            this.buttonGoodSearch.Location = new System.Drawing.Point(450, 440);
            this.buttonGoodSearch.Name = "buttonGoodSearch";
            this.buttonGoodSearch.Size = new System.Drawing.Size(99, 44);
            this.buttonGoodSearch.TabIndex = 21;
            this.buttonGoodSearch.Text = "Search";
            this.buttonGoodSearch.UseVisualStyleBackColor = true;
            this.buttonGoodSearch.Click += new System.EventHandler(this.buttonGoodSearch_Click);
            // 
            // finalSEDataSetGood
            // 
            this.finalSEDataSetGood.DataSetName = "FinalSEDataSetGood";
            this.finalSEDataSetGood.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // goodBindingSource
            // 
            this.goodBindingSource.DataMember = "Good";
            this.goodBindingSource.DataSource = this.finalSEDataSetGood;
            // 
            // goodTableAdapter
            // 
            this.goodTableAdapter.ClearBeforeFill = true;
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
            // importPriceDataGridViewTextBoxColumn
            // 
            this.importPriceDataGridViewTextBoxColumn.DataPropertyName = "ImportPrice";
            this.importPriceDataGridViewTextBoxColumn.HeaderText = "ImportPrice";
            this.importPriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.importPriceDataGridViewTextBoxColumn.Name = "importPriceDataGridViewTextBoxColumn";
            this.importPriceDataGridViewTextBoxColumn.ReadOnly = true;
            this.importPriceDataGridViewTextBoxColumn.Width = 125;
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 219);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 16);
            this.label7.TabIndex = 22;
            this.label7.Text = "Import price";
            // 
            // textBoxGoodImpPrice
            // 
            this.textBoxGoodImpPrice.Location = new System.Drawing.Point(123, 219);
            this.textBoxGoodImpPrice.Name = "textBoxGoodImpPrice";
            this.textBoxGoodImpPrice.Size = new System.Drawing.Size(137, 22);
            this.textBoxGoodImpPrice.TabIndex = 23;
            // 
            // FormGoods
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 541);
            this.Controls.Add(this.textBoxGoodImpPrice);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.buttonGoodSearch);
            this.Controls.Add(this.buttonGoodEdit);
            this.Controls.Add(this.buttonGoodClear);
            this.Controls.Add(this.buttonGoodDelete);
            this.Controls.Add(this.goodGridView);
            this.Controls.Add(this.textBoxGoodSell);
            this.Controls.Add(this.textBoxGoodQuantity);
            this.Controls.Add(this.buttonGoodSave);
            this.Controls.Add(this.pictureBoxGoodPhoto);
            this.Controls.Add(this.buttonGoodBrowse);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxGoodManu);
            this.Controls.Add(this.textBoxGoodName);
            this.Controls.Add(this.textBoxGoodID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormGoods";
            this.Text = "FormGoods";
            this.Load += new System.EventHandler(this.FormGoods_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGoodPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalSEDataSetGood)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxGoodID;
        private System.Windows.Forms.TextBox textBoxGoodName;
        private System.Windows.Forms.TextBox textBoxGoodManu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonGoodBrowse;
        private System.Windows.Forms.PictureBox pictureBoxGoodPhoto;
        private System.Windows.Forms.Button buttonGoodSave;
        private System.Windows.Forms.TextBox textBoxGoodQuantity;
        private System.Windows.Forms.TextBox textBoxGoodSell;
        private System.Windows.Forms.DataGridView goodGridView;
        private System.Windows.Forms.Button buttonGoodDelete;
        private System.Windows.Forms.Button buttonGoodClear;
        private System.Windows.Forms.Button buttonGoodEdit;
        private System.Windows.Forms.Button buttonGoodSearch;
        private FinalSEDataSetGood finalSEDataSetGood;
        private System.Windows.Forms.BindingSource goodBindingSource;
        private FinalSEDataSetGoodTableAdapters.GoodTableAdapter goodTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn gIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn manufactureDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn importPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sellingPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn gPhotoDataGridViewImageColumn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxGoodImpPrice;
    }
}