namespace WindowsFormsFinalSE
{
    partial class FormDelivery
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
            this.dataGridViewNote = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.finalSEDataSetNote = new WindowsFormsFinalSE.FinalSEDataSetNote();
            this.deliveryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.deliveryTableAdapter = new WindowsFormsFinalSE.FinalSEDataSetNoteTableAdapters.DeliveryTableAdapter();
            this.deliveryIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goodsStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelDeliveryID = new System.Windows.Forms.Label();
            this.txtDeliveryID = new System.Windows.Forms.TextBox();
            this.txtAID = new System.Windows.Forms.TextBox();
            this.labelAID = new System.Windows.Forms.Label();
            this.txtOID = new System.Windows.Forms.TextBox();
            this.labelOID = new System.Windows.Forms.Label();
            this.labelGoodStatus = new System.Windows.Forms.Label();
            this.txtPaymentStatus = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnFind = new System.Windows.Forms.Button();
            this.txtFind = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNote)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.finalSEDataSetNote)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewNote
            // 
            this.dataGridViewNote.AutoGenerateColumns = false;
            this.dataGridViewNote.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNote.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.deliveryIDDataGridViewTextBoxColumn,
            this.aIDDataGridViewTextBoxColumn,
            this.oIDDataGridViewTextBoxColumn,
            this.goodsStatusDataGridViewTextBoxColumn,
            this.paymentStatusDataGridViewTextBoxColumn});
            this.dataGridViewNote.DataSource = this.deliveryBindingSource;
            this.dataGridViewNote.Location = new System.Drawing.Point(336, 12);
            this.dataGridViewNote.Name = "dataGridViewNote";
            this.dataGridViewNote.ReadOnly = true;
            this.dataGridViewNote.RowHeadersWidth = 51;
            this.dataGridViewNote.RowTemplate.Height = 24;
            this.dataGridViewNote.Size = new System.Drawing.Size(732, 415);
            this.dataGridViewNote.TabIndex = 0;
            this.dataGridViewNote.SelectionChanged += new System.EventHandler(this.dataGridViewNote_SelectionChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnPrint);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.comboBoxStatus);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.txtFind);
            this.panel1.Controls.Add(this.btnFind);
            this.panel1.Controls.Add(this.txtPaymentStatus);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.labelGoodStatus);
            this.panel1.Controls.Add(this.txtOID);
            this.panel1.Controls.Add(this.labelOID);
            this.panel1.Controls.Add(this.txtAID);
            this.panel1.Controls.Add(this.labelAID);
            this.panel1.Controls.Add(this.txtDeliveryID);
            this.panel1.Controls.Add(this.labelDeliveryID);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(330, 459);
            this.panel1.TabIndex = 1;
            // 
            // finalSEDataSetNote
            // 
            this.finalSEDataSetNote.DataSetName = "FinalSEDataSetNote";
            this.finalSEDataSetNote.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // deliveryBindingSource
            // 
            this.deliveryBindingSource.DataMember = "Delivery";
            this.deliveryBindingSource.DataSource = this.finalSEDataSetNote;
            // 
            // deliveryTableAdapter
            // 
            this.deliveryTableAdapter.ClearBeforeFill = true;
            // 
            // deliveryIDDataGridViewTextBoxColumn
            // 
            this.deliveryIDDataGridViewTextBoxColumn.DataPropertyName = "DeliveryID";
            this.deliveryIDDataGridViewTextBoxColumn.HeaderText = "DeliveryID";
            this.deliveryIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.deliveryIDDataGridViewTextBoxColumn.Name = "deliveryIDDataGridViewTextBoxColumn";
            this.deliveryIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.deliveryIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // aIDDataGridViewTextBoxColumn
            // 
            this.aIDDataGridViewTextBoxColumn.DataPropertyName = "AID";
            this.aIDDataGridViewTextBoxColumn.HeaderText = "AID";
            this.aIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.aIDDataGridViewTextBoxColumn.Name = "aIDDataGridViewTextBoxColumn";
            this.aIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.aIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // oIDDataGridViewTextBoxColumn
            // 
            this.oIDDataGridViewTextBoxColumn.DataPropertyName = "OID";
            this.oIDDataGridViewTextBoxColumn.HeaderText = "OID";
            this.oIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.oIDDataGridViewTextBoxColumn.Name = "oIDDataGridViewTextBoxColumn";
            this.oIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.oIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // goodsStatusDataGridViewTextBoxColumn
            // 
            this.goodsStatusDataGridViewTextBoxColumn.DataPropertyName = "GoodsStatus";
            this.goodsStatusDataGridViewTextBoxColumn.HeaderText = "Goods Status";
            this.goodsStatusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.goodsStatusDataGridViewTextBoxColumn.Name = "goodsStatusDataGridViewTextBoxColumn";
            this.goodsStatusDataGridViewTextBoxColumn.ReadOnly = true;
            this.goodsStatusDataGridViewTextBoxColumn.Width = 175;
            // 
            // paymentStatusDataGridViewTextBoxColumn
            // 
            this.paymentStatusDataGridViewTextBoxColumn.DataPropertyName = "PaymentStatus";
            this.paymentStatusDataGridViewTextBoxColumn.HeaderText = "Payment Status";
            this.paymentStatusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.paymentStatusDataGridViewTextBoxColumn.Name = "paymentStatusDataGridViewTextBoxColumn";
            this.paymentStatusDataGridViewTextBoxColumn.ReadOnly = true;
            this.paymentStatusDataGridViewTextBoxColumn.Width = 125;
            // 
            // labelDeliveryID
            // 
            this.labelDeliveryID.AutoSize = true;
            this.labelDeliveryID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDeliveryID.Location = new System.Drawing.Point(26, 62);
            this.labelDeliveryID.Name = "labelDeliveryID";
            this.labelDeliveryID.Size = new System.Drawing.Size(92, 20);
            this.labelDeliveryID.TabIndex = 0;
            this.labelDeliveryID.Text = "DeliveryID:";
            // 
            // txtDeliveryID
            // 
            this.txtDeliveryID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDeliveryID.Location = new System.Drawing.Point(195, 56);
            this.txtDeliveryID.Name = "txtDeliveryID";
            this.txtDeliveryID.ReadOnly = true;
            this.txtDeliveryID.Size = new System.Drawing.Size(120, 26);
            this.txtDeliveryID.TabIndex = 1;
            // 
            // txtAID
            // 
            this.txtAID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAID.Location = new System.Drawing.Point(195, 114);
            this.txtAID.Name = "txtAID";
            this.txtAID.ReadOnly = true;
            this.txtAID.Size = new System.Drawing.Size(120, 26);
            this.txtAID.TabIndex = 3;
            // 
            // labelAID
            // 
            this.labelAID.AutoSize = true;
            this.labelAID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAID.Location = new System.Drawing.Point(26, 117);
            this.labelAID.Name = "labelAID";
            this.labelAID.Size = new System.Drawing.Size(42, 20);
            this.labelAID.TabIndex = 2;
            this.labelAID.Text = "AID:";
            // 
            // txtOID
            // 
            this.txtOID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOID.Location = new System.Drawing.Point(195, 171);
            this.txtOID.Name = "txtOID";
            this.txtOID.ReadOnly = true;
            this.txtOID.Size = new System.Drawing.Size(120, 26);
            this.txtOID.TabIndex = 5;
            // 
            // labelOID
            // 
            this.labelOID.AutoSize = true;
            this.labelOID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOID.Location = new System.Drawing.Point(26, 177);
            this.labelOID.Name = "labelOID";
            this.labelOID.Size = new System.Drawing.Size(44, 20);
            this.labelOID.TabIndex = 4;
            this.labelOID.Text = "OID:";
            // 
            // labelGoodStatus
            // 
            this.labelGoodStatus.AutoSize = true;
            this.labelGoodStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGoodStatus.Location = new System.Drawing.Point(26, 233);
            this.labelGoodStatus.Name = "labelGoodStatus";
            this.labelGoodStatus.Size = new System.Drawing.Size(114, 20);
            this.labelGoodStatus.TabIndex = 6;
            this.labelGoodStatus.Text = "Goods status:";
            // 
            // txtPaymentStatus
            // 
            this.txtPaymentStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPaymentStatus.Location = new System.Drawing.Point(195, 284);
            this.txtPaymentStatus.Name = "txtPaymentStatus";
            this.txtPaymentStatus.ReadOnly = true;
            this.txtPaymentStatus.Size = new System.Drawing.Size(120, 26);
            this.txtPaymentStatus.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(26, 290);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Payment Status:";
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(62, 355);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(56, 34);
            this.btnFind.TabIndex = 10;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // txtFind
            // 
            this.txtFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFind.Location = new System.Drawing.Point(131, 355);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(129, 26);
            this.txtFind.TabIndex = 11;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(162, 403);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(98, 44);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Items.AddRange(new object[] {
            "Pending",
            "Shipped",
            "Delivered",
            "Cancel"});
            this.comboBoxStatus.Location = new System.Drawing.Point(155, 230);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBoxStatus.Size = new System.Drawing.Size(160, 28);
            this.comboBoxStatus.TabIndex = 13;
            this.comboBoxStatus.Text = "Status";
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(40, 403);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(78, 44);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(30, 3);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(52, 26);
            this.btnPrint.TabIndex = 15;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // FormDelivery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 459);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridViewNote);
            this.Name = "FormDelivery";
            this.Text = "FormDelivery";
            this.Load += new System.EventHandler(this.FormDelivery_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNote)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.finalSEDataSetNote)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewNote;
        private System.Windows.Forms.Panel panel1;
        private FinalSEDataSetNote finalSEDataSetNote;
        private System.Windows.Forms.BindingSource deliveryBindingSource;
        private FinalSEDataSetNoteTableAdapters.DeliveryTableAdapter deliveryTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliveryIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodsStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtPaymentStatus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelGoodStatus;
        private System.Windows.Forms.TextBox txtOID;
        private System.Windows.Forms.Label labelOID;
        private System.Windows.Forms.TextBox txtAID;
        private System.Windows.Forms.Label labelAID;
        private System.Windows.Forms.TextBox txtDeliveryID;
        private System.Windows.Forms.Label labelDeliveryID;
        private System.Windows.Forms.TextBox txtFind;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnPrint;
    }
}