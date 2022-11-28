namespace WindowsFormsFinalSE
{
    partial class FormMain
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
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.iconReport = new FontAwesome.Sharp.IconButton();
            this.iconNote = new FontAwesome.Sharp.IconButton();
            this.iconImport = new FontAwesome.Sharp.IconButton();
            this.iconAccountant = new FontAwesome.Sharp.IconButton();
            this.Logo = new System.Windows.Forms.Panel();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.MenuPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuPanel
            // 
            this.MenuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.MenuPanel.Controls.Add(this.iconReport);
            this.MenuPanel.Controls.Add(this.iconNote);
            this.MenuPanel.Controls.Add(this.iconImport);
            this.MenuPanel.Controls.Add(this.iconAccountant);
            this.MenuPanel.Controls.Add(this.Logo);
            this.MenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuPanel.Location = new System.Drawing.Point(0, 0);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(200, 544);
            this.MenuPanel.TabIndex = 1;
            this.MenuPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.MenuPanel_Paint);
            // 
            // iconReport
            // 
            this.iconReport.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconReport.FlatAppearance.BorderSize = 0;
            this.iconReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconReport.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.iconReport.IconChar = FontAwesome.Sharp.IconChar.Readme;
            this.iconReport.IconColor = System.Drawing.Color.Gainsboro;
            this.iconReport.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconReport.Location = new System.Drawing.Point(0, 383);
            this.iconReport.Name = "iconReport";
            this.iconReport.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconReport.Size = new System.Drawing.Size(200, 80);
            this.iconReport.TabIndex = 4;
            this.iconReport.Text = "Report";
            this.iconReport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconReport.UseVisualStyleBackColor = true;
            // 
            // iconNote
            // 
            this.iconNote.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconNote.FlatAppearance.BorderSize = 0;
            this.iconNote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconNote.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.iconNote.IconChar = FontAwesome.Sharp.IconChar.BoxesPacking;
            this.iconNote.IconColor = System.Drawing.Color.Gainsboro;
            this.iconNote.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconNote.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconNote.Location = new System.Drawing.Point(0, 303);
            this.iconNote.Name = "iconNote";
            this.iconNote.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconNote.Size = new System.Drawing.Size(200, 80);
            this.iconNote.TabIndex = 3;
            this.iconNote.Text = "Delivery Note";
            this.iconNote.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconNote.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconNote.UseVisualStyleBackColor = true;
            // 
            // iconImport
            // 
            this.iconImport.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconImport.FlatAppearance.BorderSize = 0;
            this.iconImport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconImport.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.iconImport.IconChar = FontAwesome.Sharp.IconChar.Box;
            this.iconImport.IconColor = System.Drawing.Color.Gainsboro;
            this.iconImport.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconImport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconImport.Location = new System.Drawing.Point(0, 223);
            this.iconImport.Name = "iconImport";
            this.iconImport.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconImport.Size = new System.Drawing.Size(200, 80);
            this.iconImport.TabIndex = 2;
            this.iconImport.Text = "Goods Received";
            this.iconImport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconImport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconImport.UseVisualStyleBackColor = true;
            // 
            // iconAccountant
            // 
            this.iconAccountant.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconAccountant.FlatAppearance.BorderSize = 0;
            this.iconAccountant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconAccountant.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.iconAccountant.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.iconAccountant.IconColor = System.Drawing.Color.Gainsboro;
            this.iconAccountant.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconAccountant.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconAccountant.Location = new System.Drawing.Point(0, 143);
            this.iconAccountant.Name = "iconAccountant";
            this.iconAccountant.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconAccountant.Size = new System.Drawing.Size(200, 80);
            this.iconAccountant.TabIndex = 1;
            this.iconAccountant.Text = "Accountant";
            this.iconAccountant.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconAccountant.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconAccountant.UseVisualStyleBackColor = true;
            // 
            // Logo
            // 
            this.Logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.Logo.Location = new System.Drawing.Point(0, 0);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(200, 143);
            this.Logo.TabIndex = 0;
            // 
            // MainPanel
            // 
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(200, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(902, 544);
            this.MainPanel.TabIndex = 2;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1102, 544);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.MenuPanel);
            this.Name = "FormMain";
            this.Text = "Supplement Facts Products Management";
            this.MenuPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MenuPanel;
        private FontAwesome.Sharp.IconButton iconReport;
        private FontAwesome.Sharp.IconButton iconNote;
        private FontAwesome.Sharp.IconButton iconImport;
        private FontAwesome.Sharp.IconButton iconAccountant;
        private System.Windows.Forms.Panel Logo;
        private System.Windows.Forms.Panel MainPanel;
    }
}

