namespace Attendence_Project
{
    partial class SearchForm
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
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.labSearch = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.EntryId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmpId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmpName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Designation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OutTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalWorking_Hour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(223, 24);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(87, 24);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(100, 22);
            this.txtSearch.TabIndex = 1;
            // 
            // labSearch
            // 
            this.labSearch.AutoSize = true;
            this.labSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labSearch.Location = new System.Drawing.Point(25, 27);
            this.labSearch.Name = "labSearch";
            this.labSearch.Size = new System.Drawing.Size(56, 16);
            this.labSearch.TabIndex = 2;
            this.labSearch.Text = "EnterId";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EntryId,
            this.EmpId,
            this.EmpName,
            this.Designation,
            this.InTime,
            this.OutTime,
            this.TotalWorking_Hour});
            this.dataGridView1.Location = new System.Drawing.Point(3, 73);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(785, 365);
            this.dataGridView1.TabIndex = 3;
            // 
            // EntryId
            // 
            this.EntryId.HeaderText = "EntryId";
            this.EntryId.MinimumWidth = 6;
            this.EntryId.Name = "EntryId";
            this.EntryId.Width = 125;
            // 
            // EmpId
            // 
            this.EmpId.HeaderText = "EmpId";
            this.EmpId.MinimumWidth = 6;
            this.EmpId.Name = "EmpId";
            this.EmpId.Width = 125;
            // 
            // EmpName
            // 
            this.EmpName.HeaderText = "EmpName";
            this.EmpName.MinimumWidth = 6;
            this.EmpName.Name = "EmpName";
            this.EmpName.Width = 125;
            // 
            // Designation
            // 
            this.Designation.HeaderText = "Designation";
            this.Designation.MinimumWidth = 6;
            this.Designation.Name = "Designation";
            this.Designation.Width = 125;
            // 
            // InTime
            // 
            this.InTime.HeaderText = "InTime";
            this.InTime.MinimumWidth = 6;
            this.InTime.Name = "InTime";
            this.InTime.Width = 125;
            // 
            // OutTime
            // 
            this.OutTime.HeaderText = "OutTime";
            this.OutTime.MinimumWidth = 6;
            this.OutTime.Name = "OutTime";
            this.OutTime.Width = 125;
            // 
            // TotalWorking_Hour
            // 
            this.TotalWorking_Hour.HeaderText = "TotalWorking_Hour";
            this.TotalWorking_Hour.MinimumWidth = 6;
            this.TotalWorking_Hour.Name = "TotalWorking_Hour";
            this.TotalWorking_Hour.Width = 125;
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.Name = "SearchForm";
            this.Text = "SearchForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label labSearch;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn EntryId;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpId;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Designation;
        private System.Windows.Forms.DataGridViewTextBoxColumn InTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn OutTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalWorking_Hour;
    }
}