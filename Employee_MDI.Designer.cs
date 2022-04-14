namespace Attendence_Project
{
    partial class Employee_MDI
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuItemApplyForLeave = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemReport = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemAskForHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemLeaveStatus = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemApplyForLeave,
            this.ToolStripMenuItemReport,
            this.ToolStripMenuItemAskForHelp,
            this.ToolStripMenuItemLeaveStatus});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ToolStripMenuItemApplyForLeave
            // 
            this.ToolStripMenuItemApplyForLeave.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.ToolStripMenuItemApplyForLeave.Name = "ToolStripMenuItemApplyForLeave";
            this.ToolStripMenuItemApplyForLeave.Size = new System.Drawing.Size(135, 26);
            this.ToolStripMenuItemApplyForLeave.Text = "Apply For Leave";
            // 
            // ToolStripMenuItemReport
            // 
            this.ToolStripMenuItemReport.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.ToolStripMenuItemReport.Name = "ToolStripMenuItemReport";
            this.ToolStripMenuItemReport.Size = new System.Drawing.Size(71, 26);
            this.ToolStripMenuItemReport.Text = "Report";
            // 
            // ToolStripMenuItemAskForHelp
            // 
            this.ToolStripMenuItemAskForHelp.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.ToolStripMenuItemAskForHelp.Name = "ToolStripMenuItemAskForHelp";
            this.ToolStripMenuItemAskForHelp.Size = new System.Drawing.Size(112, 26);
            this.ToolStripMenuItemAskForHelp.Text = "Ask For Help";
            // 
            // ToolStripMenuItemLeaveStatus
            // 
            this.ToolStripMenuItemLeaveStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.ToolStripMenuItemLeaveStatus.Name = "ToolStripMenuItemLeaveStatus";
            this.ToolStripMenuItemLeaveStatus.Size = new System.Drawing.Size(195, 24);
            this.ToolStripMenuItemLeaveStatus.Text = "Leave Application Status";
            this.ToolStripMenuItemLeaveStatus.Click += new System.EventHandler(this.ToolStripMenuItemLeaveStatus_Click);
            // 
            // Employee_MDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Employee_MDI";
            this.Text = "Employee_MDI";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemApplyForLeave;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemReport;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemAskForHelp;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemLeaveStatus;
    }
}