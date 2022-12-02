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
            this.goodBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.finalSEDataSet1 = new WindowsFormsFinalSE.FinalSEDataSet1();
            this.goodTableAdapter = new WindowsFormsFinalSE.FinalSEDataSet1TableAdapters.GoodTableAdapter();
            this.importBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.finalSEDataSet2 = new WindowsFormsFinalSE.FinalSEDataSet2();
            this.importTableAdapter = new WindowsFormsFinalSE.FinalSEDataSet2TableAdapters.ImportTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.receiptGridView = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbTotalPrice = new System.Windows.Forms.Label();
            this.txtTotalPrice = new System.Windows.Forms.TextBox();
            this.groupBoxAcc = new System.Windows.Forms.GroupBox();
            this.lbID = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBoxGood = new System.Windows.Forms.GroupBox();
            this.lbImportID = new System.Windows.Forms.Label();
            this.lbGID = new System.Windows.Forms.Label();
            this.lbQuantity = new System.Windows.Forms.Label();
            this.lbDate = new System.Windows.Forms.Label();
            this.txtImportID = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtGID = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.goodBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalSEDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.importBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalSEDataSet2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.receiptGridView)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBoxAcc.SuspendLayout();
            this.groupBoxGood.SuspendLayout();
            this.SuspendLayout();
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
            // importBindingSource
            // 
            this.importBindingSource.DataMember = "Import";
            this.importBindingSource.DataSource = this.finalSEDataSet2;
            // 
            // finalSEDataSet2
            // 
            this.finalSEDataSet2.DataSetName = "FinalSEDataSet2";
            this.finalSEDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // importTableAdapter
            // 
            this.importTableAdapter.ClearBeforeFill = true;
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
            this.panel1.Size = new System.Drawing.Size(1247, 55);
            this.panel1.TabIndex = 0;
            // 
            // receiptGridView
            // 
            this.receiptGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.receiptGridView.Dock = System.Windows.Forms.DockStyle.Right;
            this.receiptGridView.Location = new System.Drawing.Point(366, 0);
            this.receiptGridView.Name = "receiptGridView";
            this.receiptGridView.RowHeadersWidth = 51;
            this.receiptGridView.RowTemplate.Height = 24;
            this.receiptGridView.Size = new System.Drawing.Size(881, 418);
            this.receiptGridView.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBoxGood);
            this.panel2.Controls.Add(this.groupBoxAcc);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(360, 418);
            this.panel2.TabIndex = 2;
            // 
            // lbTotalPrice
            // 
            this.lbTotalPrice.AutoSize = true;
            this.lbTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalPrice.Location = new System.Drawing.Point(722, 21);
            this.lbTotalPrice.Name = "lbTotalPrice";
            this.lbTotalPrice.Size = new System.Drawing.Size(116, 25);
            this.lbTotalPrice.TabIndex = 0;
            this.lbTotalPrice.Text = "Total Price: ";
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalPrice.Location = new System.Drawing.Point(872, 14);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.Size = new System.Drawing.Size(299, 32);
            this.txtTotalPrice.TabIndex = 1;
            // 
            // groupBoxAcc
            // 
            this.groupBoxAcc.Controls.Add(this.textBox1);
            this.groupBoxAcc.Controls.Add(this.comboBox1);
            this.groupBoxAcc.Controls.Add(this.lbName);
            this.groupBoxAcc.Controls.Add(this.lbID);
            this.groupBoxAcc.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxAcc.Location = new System.Drawing.Point(0, 0);
            this.groupBoxAcc.Name = "groupBoxAcc";
            this.groupBoxAcc.Size = new System.Drawing.Size(360, 116);
            this.groupBoxAcc.TabIndex = 0;
            this.groupBoxAcc.TabStop = false;
            this.groupBoxAcc.Text = "Acountant info:";
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
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(78, 30);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(97, 28);
            this.comboBox1.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(78, 79);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(216, 26);
            this.textBox1.TabIndex = 4;
            // 
            // groupBoxGood
            // 
            this.groupBoxGood.Controls.Add(this.label1);
            this.groupBoxGood.Controls.Add(this.dateTimePicker1);
            this.groupBoxGood.Controls.Add(this.txtGID);
            this.groupBoxGood.Controls.Add(this.txtQuantity);
            this.groupBoxGood.Controls.Add(this.txtImportID);
            this.groupBoxGood.Controls.Add(this.lbDate);
            this.groupBoxGood.Controls.Add(this.lbQuantity);
            this.groupBoxGood.Controls.Add(this.lbGID);
            this.groupBoxGood.Controls.Add(this.lbImportID);
            this.groupBoxGood.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBoxGood.Location = new System.Drawing.Point(0, 122);
            this.groupBoxGood.Name = "groupBoxGood";
            this.groupBoxGood.Size = new System.Drawing.Size(360, 296);
            this.groupBoxGood.TabIndex = 1;
            this.groupBoxGood.TabStop = false;
            this.groupBoxGood.Text = "Goods infor:";
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
            // lbQuantity
            // 
            this.lbQuantity.AutoSize = true;
            this.lbQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQuantity.Location = new System.Drawing.Point(17, 137);
            this.lbQuantity.Name = "lbQuantity";
            this.lbQuantity.Size = new System.Drawing.Size(71, 20);
            this.lbQuantity.TabIndex = 2;
            this.lbQuantity.Text = "Quantity";
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDate.Location = new System.Drawing.Point(17, 193);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(97, 20);
            this.lbDate.TabIndex = 3;
            this.lbDate.Text = "Import Date";
            // 
            // txtImportID
            // 
            this.txtImportID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImportID.Location = new System.Drawing.Point(124, 27);
            this.txtImportID.Name = "txtImportID";
            this.txtImportID.Size = new System.Drawing.Size(170, 26);
            this.txtImportID.TabIndex = 4;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.Location = new System.Drawing.Point(124, 131);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(170, 26);
            this.txtQuantity.TabIndex = 5;
            // 
            // txtGID
            // 
            this.txtGID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGID.Location = new System.Drawing.Point(124, 77);
            this.txtGID.Name = "txtGID";
            this.txtGID.Size = new System.Drawing.Size(170, 26);
            this.txtGID.TabIndex = 6;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(124, 190);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(183, 267);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "double click to delete row";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(16, 8);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 38);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(124, 8);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 38);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(239, 8);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 38);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
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
            // 
            // FormGoods
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1247, 473);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.receiptGridView);
            this.Controls.Add(this.panel1);
            this.Name = "FormGoods";
            this.Text = "Goods Received";
            this.Load += new System.EventHandler(this.FormGoods_Load);
            ((System.ComponentModel.ISupportInitialize)(this.goodBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalSEDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.importBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalSEDataSet2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.receiptGridView)).EndInit();
            this.panel2.ResumeLayout(false);
            this.groupBoxAcc.ResumeLayout(false);
            this.groupBoxAcc.PerformLayout();
            this.groupBoxGood.ResumeLayout(false);
            this.groupBoxGood.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private FinalSEDataSet1 finalSEDataSet1;
        private System.Windows.Forms.BindingSource goodBindingSource;
        private FinalSEDataSet1TableAdapters.GoodTableAdapter goodTableAdapter;
        private FinalSEDataSet2 finalSEDataSet2;
        private System.Windows.Forms.BindingSource importBindingSource;
        private FinalSEDataSet2TableAdapters.ImportTableAdapter importTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtTotalPrice;
        private System.Windows.Forms.Label lbTotalPrice;
        private System.Windows.Forms.DataGridView receiptGridView;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBoxAcc;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.GroupBox groupBoxGood;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.Label lbQuantity;
        private System.Windows.Forms.Label lbGID;
        private System.Windows.Forms.Label lbImportID;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtGID;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtImportID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
    }
}