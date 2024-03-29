﻿namespace WindowsFormsFinalSE
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
            this.iconGoods = new FontAwesome.Sharp.IconButton();
            this.iconAgent = new FontAwesome.Sharp.IconButton();
            this.iconAccountant = new FontAwesome.Sharp.IconButton();
            this.Logo = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.PictureBox();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.panelForm = new System.Windows.Forms.Panel();
            this.panelShadow = new System.Windows.Forms.Panel();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.lblTitleChildForm = new System.Windows.Forms.Label();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.iconImport = new FontAwesome.Sharp.IconButton();
            this.iconNote = new FontAwesome.Sharp.IconButton();
            this.iconReport = new FontAwesome.Sharp.IconButton();
            this.MenuPanel.SuspendLayout();
            this.Logo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
            this.MainPanel.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuPanel
            // 
            this.MenuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.MenuPanel.Controls.Add(this.iconReport);
            this.MenuPanel.Controls.Add(this.iconNote);
            this.MenuPanel.Controls.Add(this.iconImport);
            this.MenuPanel.Controls.Add(this.iconGoods);
            this.MenuPanel.Controls.Add(this.iconAgent);
            this.MenuPanel.Controls.Add(this.iconAccountant);
            this.MenuPanel.Controls.Add(this.Logo);
            this.MenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuPanel.Location = new System.Drawing.Point(0, 0);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(200, 628);
            this.MenuPanel.TabIndex = 1;
            // 
            // iconGoods
            // 
            this.iconGoods.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconGoods.FlatAppearance.BorderSize = 0;
            this.iconGoods.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconGoods.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.iconGoods.IconChar = FontAwesome.Sharp.IconChar.BoxOpen;
            this.iconGoods.IconColor = System.Drawing.Color.Gainsboro;
            this.iconGoods.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconGoods.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconGoods.Location = new System.Drawing.Point(0, 303);
            this.iconGoods.Name = "iconGoods";
            this.iconGoods.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconGoods.Size = new System.Drawing.Size(200, 80);
            this.iconGoods.TabIndex = 6;
            this.iconGoods.Text = "Goods";
            this.iconGoods.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconGoods.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconGoods.UseVisualStyleBackColor = true;
            this.iconGoods.Click += new System.EventHandler(this.iconGoods_Click);
            // 
            // iconAgent
            // 
            this.iconAgent.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconAgent.FlatAppearance.BorderSize = 0;
            this.iconAgent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconAgent.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.iconAgent.IconChar = FontAwesome.Sharp.IconChar.Person;
            this.iconAgent.IconColor = System.Drawing.Color.Gainsboro;
            this.iconAgent.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconAgent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconAgent.Location = new System.Drawing.Point(0, 223);
            this.iconAgent.Name = "iconAgent";
            this.iconAgent.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconAgent.Size = new System.Drawing.Size(200, 80);
            this.iconAgent.TabIndex = 5;
            this.iconAgent.Text = "Agent";
            this.iconAgent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconAgent.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconAgent.UseVisualStyleBackColor = true;
            this.iconAgent.Click += new System.EventHandler(this.iconAgent_Click);
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
            this.iconAccountant.Click += new System.EventHandler(this.iconAccountant_Click);
            // 
            // Logo
            // 
            this.Logo.Controls.Add(this.btnHome);
            this.Logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.Logo.Location = new System.Drawing.Point(0, 0);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(200, 143);
            this.Logo.TabIndex = 0;
            // 
            // btnHome
            // 
            this.btnHome.Image = global::WindowsFormsFinalSE.Properties.Resources.LogoTDTBgWhite;
            this.btnHome.Location = new System.Drawing.Point(12, 30);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(166, 76);
            this.btnHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnHome.TabIndex = 0;
            this.btnHome.TabStop = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.panelForm);
            this.MainPanel.Controls.Add(this.panelShadow);
            this.MainPanel.Controls.Add(this.panelTitleBar);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(200, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1198, 628);
            this.MainPanel.TabIndex = 2;
            // 
            // panelForm
            // 
            this.panelForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panelForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelForm.Location = new System.Drawing.Point(0, 84);
            this.panelForm.Name = "panelForm";
            this.panelForm.Size = new System.Drawing.Size(1198, 544);
            this.panelForm.TabIndex = 2;
            // 
            // panelShadow
            // 
            this.panelShadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(58)))));
            this.panelShadow.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelShadow.Location = new System.Drawing.Point(0, 75);
            this.panelShadow.Name = "panelShadow";
            this.panelShadow.Size = new System.Drawing.Size(1198, 9);
            this.panelShadow.TabIndex = 1;
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.panelTitleBar.Controls.Add(this.lblTitleChildForm);
            this.panelTitleBar.Controls.Add(this.iconCurrentChildForm);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(0, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(1198, 75);
            this.panelTitleBar.TabIndex = 0;
            // 
            // lblTitleChildForm
            // 
            this.lblTitleChildForm.AutoSize = true;
            this.lblTitleChildForm.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTitleChildForm.Location = new System.Drawing.Point(72, 30);
            this.lblTitleChildForm.Name = "lblTitleChildForm";
            this.lblTitleChildForm.Size = new System.Drawing.Size(44, 16);
            this.lblTitleChildForm.TabIndex = 1;
            this.lblTitleChildForm.Text = "Home";
            // 
            // iconCurrentChildForm
            // 
            this.iconCurrentChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.iconCurrentChildForm.ForeColor = System.Drawing.Color.MediumOrchid;
            this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconCurrentChildForm.IconColor = System.Drawing.Color.MediumOrchid;
            this.iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurrentChildForm.Location = new System.Drawing.Point(34, 30);
            this.iconCurrentChildForm.Name = "iconCurrentChildForm";
            this.iconCurrentChildForm.Size = new System.Drawing.Size(32, 32);
            this.iconCurrentChildForm.TabIndex = 0;
            this.iconCurrentChildForm.TabStop = false;
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
            this.iconImport.Location = new System.Drawing.Point(0, 383);
            this.iconImport.Name = "iconImport";
            this.iconImport.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconImport.Size = new System.Drawing.Size(200, 80);
            this.iconImport.TabIndex = 7;
            this.iconImport.Text = "Goods Received";
            this.iconImport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconImport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconImport.UseVisualStyleBackColor = true;
            this.iconImport.Click += new System.EventHandler(this.iconImport_Click);
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
            this.iconNote.Location = new System.Drawing.Point(0, 463);
            this.iconNote.Name = "iconNote";
            this.iconNote.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconNote.Size = new System.Drawing.Size(200, 80);
            this.iconNote.TabIndex = 8;
            this.iconNote.Text = "Delivery Note";
            this.iconNote.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconNote.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconNote.UseVisualStyleBackColor = true;
            this.iconNote.Click += new System.EventHandler(this.iconNote_Click);
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
            this.iconReport.Location = new System.Drawing.Point(0, 543);
            this.iconReport.Name = "iconReport";
            this.iconReport.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconReport.Size = new System.Drawing.Size(200, 80);
            this.iconReport.TabIndex = 9;
            this.iconReport.Text = "Report";
            this.iconReport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconReport.UseVisualStyleBackColor = true;
            this.iconReport.Click += new System.EventHandler(this.iconReport_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1398, 628);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.MenuPanel);
            this.Name = "FormMain";
            this.Text = "Supplement Facts Products Management";
            this.MenuPanel.ResumeLayout(false);
            this.Logo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
            this.MainPanel.ResumeLayout(false);
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MenuPanel;
        private FontAwesome.Sharp.IconButton iconAccountant;
        private System.Windows.Forms.Panel Logo;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.PictureBox btnHome;
        private System.Windows.Forms.Panel panelTitleBar;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private System.Windows.Forms.Label lblTitleChildForm;
        private System.Windows.Forms.Panel panelForm;
        private System.Windows.Forms.Panel panelShadow;
        private FontAwesome.Sharp.IconButton iconAgent;
        private FontAwesome.Sharp.IconButton iconGoods;
        private FontAwesome.Sharp.IconButton iconReport;
        private FontAwesome.Sharp.IconButton iconNote;
        private FontAwesome.Sharp.IconButton iconImport;
    }
}

