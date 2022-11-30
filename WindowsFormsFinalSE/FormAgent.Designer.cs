namespace WindowsFormsFinalSE
{
    partial class FormAgent
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lb_Address = new System.Windows.Forms.Label();
            this.lb_Phone = new System.Windows.Forms.Label();
            this.lb_Name = new System.Windows.Forms.Label();
            this.lb_ID = new System.Windows.Forms.Label();
            this.dataGridView_Agent = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Agent)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_Delete);
            this.panel1.Controls.Add(this.btn_Edit);
            this.panel1.Controls.Add(this.btn_Add);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.txtPhone);
            this.panel1.Controls.Add(this.txtAddress);
            this.panel1.Controls.Add(this.txtID);
            this.panel1.Controls.Add(this.lb_Address);
            this.panel1.Controls.Add(this.lb_Phone);
            this.panel1.Controls.Add(this.lb_Name);
            this.panel1.Controls.Add(this.lb_ID);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(465, 450);
            this.panel1.TabIndex = 0;
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(304, 313);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(91, 39);
            this.btn_Delete.TabIndex = 10;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            // 
            // btn_Edit
            // 
            this.btn_Edit.Location = new System.Drawing.Point(166, 313);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(91, 39);
            this.btn_Edit.TabIndex = 9;
            this.btn_Edit.Text = "Edit";
            this.btn_Edit.UseVisualStyleBackColor = true;
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(29, 313);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(91, 39);
            this.btn_Add.TabIndex = 8;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(166, 76);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(229, 22);
            this.txtName.TabIndex = 5;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(166, 136);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(229, 22);
            this.txtPhone.TabIndex = 6;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(166, 188);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(229, 22);
            this.txtAddress.TabIndex = 7;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(166, 33);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(229, 22);
            this.txtID.TabIndex = 4;
            // 
            // lb_Address
            // 
            this.lb_Address.AutoSize = true;
            this.lb_Address.Location = new System.Drawing.Point(26, 194);
            this.lb_Address.Name = "lb_Address";
            this.lb_Address.Size = new System.Drawing.Size(58, 16);
            this.lb_Address.TabIndex = 3;
            this.lb_Address.Text = "Address";
            // 
            // lb_Phone
            // 
            this.lb_Phone.AutoSize = true;
            this.lb_Phone.Location = new System.Drawing.Point(26, 142);
            this.lb_Phone.Name = "lb_Phone";
            this.lb_Phone.Size = new System.Drawing.Size(94, 16);
            this.lb_Phone.TabIndex = 2;
            this.lb_Phone.Text = "Phone number";
            // 
            // lb_Name
            // 
            this.lb_Name.AutoSize = true;
            this.lb_Name.Location = new System.Drawing.Point(26, 82);
            this.lb_Name.Name = "lb_Name";
            this.lb_Name.Size = new System.Drawing.Size(44, 16);
            this.lb_Name.TabIndex = 1;
            this.lb_Name.Text = "Name";
            // 
            // lb_ID
            // 
            this.lb_ID.AutoSize = true;
            this.lb_ID.Location = new System.Drawing.Point(26, 33);
            this.lb_ID.Name = "lb_ID";
            this.lb_ID.Size = new System.Drawing.Size(20, 16);
            this.lb_ID.TabIndex = 0;
            this.lb_ID.Text = "ID";
            // 
            // dataGridView_Agent
            // 
            this.dataGridView_Agent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Agent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_Agent.Location = new System.Drawing.Point(465, 0);
            this.dataGridView_Agent.Name = "dataGridView_Agent";
            this.dataGridView_Agent.ReadOnly = true;
            this.dataGridView_Agent.RowHeadersWidth = 51;
            this.dataGridView_Agent.RowTemplate.Height = 24;
            this.dataGridView_Agent.Size = new System.Drawing.Size(690, 450);
            this.dataGridView_Agent.TabIndex = 1;
            this.dataGridView_Agent.SelectionChanged += new System.EventHandler(this.dataGridView_Agent_SelectionChanged);
            // 
            // FormAgent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 450);
            this.Controls.Add(this.dataGridView_Agent);
            this.Controls.Add(this.panel1);
            this.Name = "FormAgent";
            this.Text = "Agent";
            this.Load += new System.EventHandler(this.FormAgent_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Agent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView_Agent;
        private System.Windows.Forms.Label lb_ID;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lb_Address;
        private System.Windows.Forms.Label lb_Phone;
        private System.Windows.Forms.Label lb_Name;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Edit;
        
    }
}