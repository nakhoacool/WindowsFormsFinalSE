namespace WindowsFormsFinalSE
{
    partial class FormAccountant
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
            this.txtBox_AccID = new System.Windows.Forms.TextBox();
            this.txtBox_AccName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBox_AccPhone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBox_AccEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker_AccBirth = new System.Windows.Forms.DateTimePicker();
            this.btn_AccAdd = new System.Windows.Forms.Button();
            this.dataGridView_Acc = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthDayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountantBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.finalSEDataSet = new WindowsFormsFinalSE.FinalSEDataSet();
            this.accountantTableAdapter = new WindowsFormsFinalSE.FinalSEDataSetTableAdapters.AccountantTableAdapter();
            this.btn_AccDelete = new System.Windows.Forms.Button();
            this.btn_AccUpdate = new System.Windows.Forms.Button();
            this.btn_AccClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Acc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountantBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalSEDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // txtBox_AccID
            // 
            this.txtBox_AccID.Location = new System.Drawing.Point(111, 26);
            this.txtBox_AccID.Name = "txtBox_AccID";
            this.txtBox_AccID.Size = new System.Drawing.Size(226, 22);
            this.txtBox_AccID.TabIndex = 2;
            // 
            // txtBox_AccName
            // 
            this.txtBox_AccName.Location = new System.Drawing.Point(111, 71);
            this.txtBox_AccName.Name = "txtBox_AccName";
            this.txtBox_AccName.Size = new System.Drawing.Size(226, 22);
            this.txtBox_AccName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Phone";
            // 
            // txtBox_AccPhone
            // 
            this.txtBox_AccPhone.Location = new System.Drawing.Point(111, 125);
            this.txtBox_AccPhone.Name = "txtBox_AccPhone";
            this.txtBox_AccPhone.Size = new System.Drawing.Size(226, 22);
            this.txtBox_AccPhone.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Email";
            // 
            // txtBox_AccEmail
            // 
            this.txtBox_AccEmail.Location = new System.Drawing.Point(111, 181);
            this.txtBox_AccEmail.Name = "txtBox_AccEmail";
            this.txtBox_AccEmail.Size = new System.Drawing.Size(226, 22);
            this.txtBox_AccEmail.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Birthday";
            // 
            // dateTimePicker_AccBirth
            // 
            this.dateTimePicker_AccBirth.Location = new System.Drawing.Point(111, 241);
            this.dateTimePicker_AccBirth.Name = "dateTimePicker_AccBirth";
            this.dateTimePicker_AccBirth.Size = new System.Drawing.Size(226, 22);
            this.dateTimePicker_AccBirth.TabIndex = 9;
            // 
            // btn_AccAdd
            // 
            this.btn_AccAdd.Location = new System.Drawing.Point(44, 300);
            this.btn_AccAdd.Name = "btn_AccAdd";
            this.btn_AccAdd.Size = new System.Drawing.Size(75, 42);
            this.btn_AccAdd.TabIndex = 10;
            this.btn_AccAdd.Text = "Add";
            this.btn_AccAdd.UseVisualStyleBackColor = true;
            this.btn_AccAdd.Click += new System.EventHandler(this.btn_AccAdd_Click);
            // 
            // dataGridView_Acc
            // 
            this.dataGridView_Acc.AllowUserToAddRows = false;
            this.dataGridView_Acc.AllowUserToDeleteRows = false;
            this.dataGridView_Acc.AutoGenerateColumns = false;
            this.dataGridView_Acc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Acc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.aNameDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.birthDayDataGridViewTextBoxColumn});
            this.dataGridView_Acc.DataSource = this.accountantBindingSource;
            this.dataGridView_Acc.Location = new System.Drawing.Point(380, 26);
            this.dataGridView_Acc.Name = "dataGridView_Acc";
            this.dataGridView_Acc.ReadOnly = true;
            this.dataGridView_Acc.RowHeadersWidth = 51;
            this.dataGridView_Acc.RowTemplate.Height = 24;
            this.dataGridView_Acc.Size = new System.Drawing.Size(679, 237);
            this.dataGridView_Acc.TabIndex = 11;
            this.dataGridView_Acc.Click += new System.EventHandler(this.dataGridView_Acc_Click);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Width = 125;
            // 
            // aNameDataGridViewTextBoxColumn
            // 
            this.aNameDataGridViewTextBoxColumn.DataPropertyName = "AName";
            this.aNameDataGridViewTextBoxColumn.HeaderText = "AName";
            this.aNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.aNameDataGridViewTextBoxColumn.Name = "aNameDataGridViewTextBoxColumn";
            this.aNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.aNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.phoneDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            this.phoneDataGridViewTextBoxColumn.ReadOnly = true;
            this.phoneDataGridViewTextBoxColumn.Width = 125;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            this.emailDataGridViewTextBoxColumn.Width = 125;
            // 
            // birthDayDataGridViewTextBoxColumn
            // 
            this.birthDayDataGridViewTextBoxColumn.DataPropertyName = "BirthDay";
            this.birthDayDataGridViewTextBoxColumn.HeaderText = "BirthDay";
            this.birthDayDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.birthDayDataGridViewTextBoxColumn.Name = "birthDayDataGridViewTextBoxColumn";
            this.birthDayDataGridViewTextBoxColumn.ReadOnly = true;
            this.birthDayDataGridViewTextBoxColumn.Width = 125;
            // 
            // accountantBindingSource
            // 
            this.accountantBindingSource.DataMember = "Accountant";
            this.accountantBindingSource.DataSource = this.finalSEDataSet;
            // 
            // finalSEDataSet
            // 
            this.finalSEDataSet.DataSetName = "FinalSEDataSet";
            this.finalSEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // accountantTableAdapter
            // 
            this.accountantTableAdapter.ClearBeforeFill = true;
            // 
            // btn_AccDelete
            // 
            this.btn_AccDelete.Location = new System.Drawing.Point(44, 363);
            this.btn_AccDelete.Name = "btn_AccDelete";
            this.btn_AccDelete.Size = new System.Drawing.Size(75, 42);
            this.btn_AccDelete.TabIndex = 12;
            this.btn_AccDelete.Text = "Delete";
            this.btn_AccDelete.UseVisualStyleBackColor = true;
            this.btn_AccDelete.Click += new System.EventHandler(this.btn_AccDelete_Click);
            // 
            // btn_AccUpdate
            // 
            this.btn_AccUpdate.Location = new System.Drawing.Point(157, 363);
            this.btn_AccUpdate.Name = "btn_AccUpdate";
            this.btn_AccUpdate.Size = new System.Drawing.Size(75, 42);
            this.btn_AccUpdate.TabIndex = 13;
            this.btn_AccUpdate.Text = "Update";
            this.btn_AccUpdate.UseVisualStyleBackColor = true;
            this.btn_AccUpdate.Click += new System.EventHandler(this.btn_AccUpdate_Click);
            // 
            // btn_AccClear
            // 
            this.btn_AccClear.Location = new System.Drawing.Point(157, 300);
            this.btn_AccClear.Name = "btn_AccClear";
            this.btn_AccClear.Size = new System.Drawing.Size(75, 42);
            this.btn_AccClear.TabIndex = 14;
            this.btn_AccClear.Text = "Clear";
            this.btn_AccClear.UseVisualStyleBackColor = true;
            this.btn_AccClear.Click += new System.EventHandler(this.btn_AccClear_Click);
            // 
            // FormAccountant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1074, 417);
            this.Controls.Add(this.btn_AccClear);
            this.Controls.Add(this.btn_AccUpdate);
            this.Controls.Add(this.btn_AccDelete);
            this.Controls.Add(this.dataGridView_Acc);
            this.Controls.Add(this.btn_AccAdd);
            this.Controls.Add(this.dateTimePicker_AccBirth);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBox_AccEmail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBox_AccPhone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBox_AccName);
            this.Controls.Add(this.txtBox_AccID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormAccountant";
            this.Text = "Accountant";
            this.Load += new System.EventHandler(this.FormAccountant_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Acc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountantBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalSEDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBox_AccID;
        private System.Windows.Forms.TextBox txtBox_AccName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBox_AccPhone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBox_AccEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker_AccBirth;
        private System.Windows.Forms.Button btn_AccAdd;
        private System.Windows.Forms.DataGridView dataGridView_Acc;
        private FinalSEDataSet finalSEDataSet;
        private System.Windows.Forms.BindingSource accountantBindingSource;
        private FinalSEDataSetTableAdapters.AccountantTableAdapter accountantTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthDayDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btn_AccDelete;
        private System.Windows.Forms.Button btn_AccUpdate;
        private System.Windows.Forms.Button btn_AccClear;
    }
}