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
            this.panelBottom = new System.Windows.Forms.Panel();
            this.tabControlReport = new System.Windows.Forms.TabControl();
            this.tabPageTopSelling = new System.Windows.Forms.TabPage();
            this.tabPageIncome = new System.Windows.Forms.TabPage();
            this.tabPageOutcome = new System.Windows.Forms.TabPage();
            this.tabPageRevenue = new System.Windows.Forms.TabPage();
            this.dataGridViewTopSelling = new System.Windows.Forms.DataGridView();
            this.dataGridViewIncome = new System.Windows.Forms.DataGridView();
            this.dataGridViewOutcome = new System.Windows.Forms.DataGridView();
            this.dataGridViewRevenue = new System.Windows.Forms.DataGridView();
            this.tabControlReport.SuspendLayout();
            this.tabPageTopSelling.SuspendLayout();
            this.tabPageIncome.SuspendLayout();
            this.tabPageOutcome.SuspendLayout();
            this.tabPageRevenue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTopSelling)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIncome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutcome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRevenue)).BeginInit();
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
            this.tabPageTopSelling.Controls.Add(this.dataGridViewTopSelling);
            this.tabPageTopSelling.Location = new System.Drawing.Point(4, 25);
            this.tabPageTopSelling.Name = "tabPageTopSelling";
            this.tabPageTopSelling.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTopSelling.Size = new System.Drawing.Size(1193, 395);
            this.tabPageTopSelling.TabIndex = 0;
            this.tabPageTopSelling.Text = "Top Selling";
            this.tabPageTopSelling.UseVisualStyleBackColor = true;
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
            // dataGridViewTopSelling
            // 
            this.dataGridViewTopSelling.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTopSelling.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewTopSelling.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewTopSelling.Name = "dataGridViewTopSelling";
            this.dataGridViewTopSelling.RowHeadersWidth = 51;
            this.dataGridViewTopSelling.RowTemplate.Height = 24;
            this.dataGridViewTopSelling.Size = new System.Drawing.Size(1187, 389);
            this.dataGridViewTopSelling.TabIndex = 0;
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
            // FormReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1201, 524);
            this.Controls.Add(this.tabControlReport);
            this.Controls.Add(this.panelBottom);
            this.Name = "FormReport";
            this.Text = "Report";
            this.tabControlReport.ResumeLayout(false);
            this.tabPageTopSelling.ResumeLayout(false);
            this.tabPageIncome.ResumeLayout(false);
            this.tabPageOutcome.ResumeLayout(false);
            this.tabPageRevenue.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTopSelling)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIncome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutcome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRevenue)).EndInit();
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
    }
}