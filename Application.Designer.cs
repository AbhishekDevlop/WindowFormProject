namespace Attendence_Project
{
    partial class Application
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
            this.btnApply = new System.Windows.Forms.Button();
            this.dateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerTo = new System.Windows.Forms.DateTimePicker();
            this.txtReason = new System.Windows.Forms.TextBox();
            this.labToDate = new System.Windows.Forms.Label();
            this.labReason = new System.Windows.Forms.Label();
            this.labHeading = new System.Windows.Forms.Label();
            this.labFromDate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnApply
            // 
            this.btnApply.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApply.Location = new System.Drawing.Point(39, 309);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(132, 49);
            this.btnApply.TabIndex = 0;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // dateTimePickerFrom
            // 
            this.dateTimePickerFrom.Location = new System.Drawing.Point(154, 69);
            this.dateTimePickerFrom.Name = "dateTimePickerFrom";
            this.dateTimePickerFrom.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerFrom.TabIndex = 1;
            // 
            // dateTimePickerTo
            // 
            this.dateTimePickerTo.Location = new System.Drawing.Point(154, 121);
            this.dateTimePickerTo.Name = "dateTimePickerTo";
            this.dateTimePickerTo.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerTo.TabIndex = 2;
            // 
            // txtReason
            // 
            this.txtReason.Location = new System.Drawing.Point(154, 178);
            this.txtReason.Multiline = true;
            this.txtReason.Name = "txtReason";
            this.txtReason.Size = new System.Drawing.Size(285, 42);
            this.txtReason.TabIndex = 3;
            // 
            // labToDate
            // 
            this.labToDate.AutoSize = true;
            this.labToDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labToDate.Location = new System.Drawing.Point(49, 121);
            this.labToDate.Name = "labToDate";
            this.labToDate.Size = new System.Drawing.Size(80, 20);
            this.labToDate.TabIndex = 5;
            this.labToDate.Text = "TO Date";
            // 
            // labReason
            // 
            this.labReason.AutoSize = true;
            this.labReason.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labReason.Location = new System.Drawing.Point(49, 190);
            this.labReason.Name = "labReason";
            this.labReason.Size = new System.Drawing.Size(72, 20);
            this.labReason.TabIndex = 6;
            this.labReason.Tag = "Reason";
            this.labReason.Text = "Reason";
            // 
            // labHeading
            // 
            this.labHeading.AutoSize = true;
            this.labHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labHeading.Location = new System.Drawing.Point(33, 9);
            this.labHeading.Name = "labHeading";
            this.labHeading.Size = new System.Drawing.Size(174, 32);
            this.labHeading.TabIndex = 7;
            this.labHeading.Text = "Leave Form";
            // 
            // labFromDate
            // 
            this.labFromDate.AutoSize = true;
            this.labFromDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labFromDate.Location = new System.Drawing.Point(49, 69);
            this.labFromDate.Name = "labFromDate";
            this.labFromDate.Size = new System.Drawing.Size(98, 20);
            this.labFromDate.TabIndex = 4;
            this.labFromDate.Text = "From Date";
            // 
            // Application
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labHeading);
            this.Controls.Add(this.labReason);
            this.Controls.Add(this.labToDate);
            this.Controls.Add(this.labFromDate);
            this.Controls.Add(this.txtReason);
            this.Controls.Add(this.dateTimePickerTo);
            this.Controls.Add(this.dateTimePickerFrom);
            this.Controls.Add(this.btnApply);
            this.Name = "Application";
            this.Text = "Application";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.DateTimePicker dateTimePickerFrom;
        private System.Windows.Forms.DateTimePicker dateTimePickerTo;
        private System.Windows.Forms.TextBox txtReason;
        private System.Windows.Forms.Label labToDate;
        private System.Windows.Forms.Label labReason;
        private System.Windows.Forms.Label labHeading;
        private System.Windows.Forms.Label labFromDate;
    }
}