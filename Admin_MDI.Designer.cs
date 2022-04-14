namespace Attendence_Project
{
    partial class Admin_MDI
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
            this.ToolStripMenuItemMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemAddNewEmployee = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemAttendenceSheet = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemSearchEmployeeDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemApplications = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemReport = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemAskForHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.labName = new System.Windows.Forms.Label();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemMenu,
            this.ToolStripMenuItemReport,
            this.ToolStripMenuItemAskForHelp});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(805, 30);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ToolStripMenuItemMenu
            // 
            this.ToolStripMenuItemMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemAddNewEmployee,
            this.ToolStripMenuItemAttendenceSheet,
            this.ToolStripMenuItemSearchEmployeeDetails,
            this.ToolStripMenuItemApplications});
            this.ToolStripMenuItemMenu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.ToolStripMenuItemMenu.Name = "ToolStripMenuItemMenu";
            this.ToolStripMenuItemMenu.Size = new System.Drawing.Size(63, 26);
            this.ToolStripMenuItemMenu.Text = "Menu";
            // 
            // ToolStripMenuItemAddNewEmployee
            // 
            this.ToolStripMenuItemAddNewEmployee.Name = "ToolStripMenuItemAddNewEmployee";
            this.ToolStripMenuItemAddNewEmployee.Size = new System.Drawing.Size(262, 26);
            this.ToolStripMenuItemAddNewEmployee.Text = "Add New Employee";
            this.ToolStripMenuItemAddNewEmployee.Click += new System.EventHandler(this.ToolStripMenuItemAddNewEmployee_Click);
            // 
            // ToolStripMenuItemAttendenceSheet
            // 
            this.ToolStripMenuItemAttendenceSheet.Name = "ToolStripMenuItemAttendenceSheet";
            this.ToolStripMenuItemAttendenceSheet.Size = new System.Drawing.Size(262, 26);
            this.ToolStripMenuItemAttendenceSheet.Text = "Attendence Sheet";
            // 
            // ToolStripMenuItemSearchEmployeeDetails
            // 
            this.ToolStripMenuItemSearchEmployeeDetails.Name = "ToolStripMenuItemSearchEmployeeDetails";
            this.ToolStripMenuItemSearchEmployeeDetails.Size = new System.Drawing.Size(262, 26);
            this.ToolStripMenuItemSearchEmployeeDetails.Text = "Search Employee Details";
            this.ToolStripMenuItemSearchEmployeeDetails.Click += new System.EventHandler(this.ToolStripMenuItemSearchEmployeeDetails_Click);
            // 
            // ToolStripMenuItemApplications
            // 
            this.ToolStripMenuItemApplications.Name = "ToolStripMenuItemApplications";
            this.ToolStripMenuItemApplications.Size = new System.Drawing.Size(262, 26);
            this.ToolStripMenuItemApplications.Text = "Applications";
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
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labName.Location = new System.Drawing.Point(12, 46);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(103, 38);
            this.labName.TabIndex = 4;
            this.labName.Text = "label2";
            // 
            // btnLogOut
            // 
            this.btnLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.Location = new System.Drawing.Point(676, 31);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(112, 32);
            this.btnLogOut.TabIndex = 6;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // Admin_MDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 450);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.labName);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Admin_MDI";
            this.Text = "Admin_MDI";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemMenu;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemAddNewEmployee;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemAttendenceSheet;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemSearchEmployeeDetails;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemApplications;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemReport;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemAskForHelp;
        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.Button btnLogOut;
    }
}