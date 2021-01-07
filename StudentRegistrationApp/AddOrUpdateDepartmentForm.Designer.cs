namespace StudentRegistrationApp
{
    partial class AddOrUpdateDepartmentForm
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
            this.listBoxDepartments = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxDepartmentCode = new System.Windows.Forms.TextBox();
            this.textBoxDepartmentName = new System.Windows.Forms.TextBox();
            this.buttonAddDepartment = new System.Windows.Forms.Button();
            this.buttonUpdateDepartment = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxDepartments
            // 
            this.listBoxDepartments.FormattingEnabled = true;
            this.listBoxDepartments.ItemHeight = 16;
            this.listBoxDepartments.Location = new System.Drawing.Point(207, 11);
            this.listBoxDepartments.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxDepartments.Name = "listBoxDepartments";
            this.listBoxDepartments.Size = new System.Drawing.Size(234, 180);
            this.listBoxDepartments.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(204, 236);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Department Code";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(204, 322);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Department Name";
            // 
            // textBoxDepartmentCode
            // 
            this.textBoxDepartmentCode.Location = new System.Drawing.Point(207, 269);
            this.textBoxDepartmentCode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxDepartmentCode.Name = "textBoxDepartmentCode";
            this.textBoxDepartmentCode.Size = new System.Drawing.Size(173, 22);
            this.textBoxDepartmentCode.TabIndex = 3;
            // 
            // textBoxDepartmentName
            // 
            this.textBoxDepartmentName.Location = new System.Drawing.Point(207, 353);
            this.textBoxDepartmentName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxDepartmentName.Name = "textBoxDepartmentName";
            this.textBoxDepartmentName.Size = new System.Drawing.Size(234, 22);
            this.textBoxDepartmentName.TabIndex = 4;
            // 
            // buttonAddDepartment
            // 
            this.buttonAddDepartment.Location = new System.Drawing.Point(207, 418);
            this.buttonAddDepartment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAddDepartment.Name = "buttonAddDepartment";
            this.buttonAddDepartment.Size = new System.Drawing.Size(90, 36);
            this.buttonAddDepartment.TabIndex = 5;
            this.buttonAddDepartment.Text = "Add";
            this.buttonAddDepartment.UseVisualStyleBackColor = true;
            // 
            // buttonUpdateDepartment
            // 
            this.buttonUpdateDepartment.Location = new System.Drawing.Point(348, 418);
            this.buttonUpdateDepartment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonUpdateDepartment.Name = "buttonUpdateDepartment";
            this.buttonUpdateDepartment.Size = new System.Drawing.Size(93, 36);
            this.buttonUpdateDepartment.TabIndex = 6;
            this.buttonUpdateDepartment.Text = "Update";
            this.buttonUpdateDepartment.UseVisualStyleBackColor = true;
            // 
            // AddOrUpdateDepartmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 546);
            this.Controls.Add(this.buttonUpdateDepartment);
            this.Controls.Add(this.buttonAddDepartment);
            this.Controls.Add(this.textBoxDepartmentName);
            this.Controls.Add(this.textBoxDepartmentCode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxDepartments);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AddOrUpdateDepartmentForm";
            this.Text = "AddOrUpdateDepartment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxDepartments;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxDepartmentCode;
        private System.Windows.Forms.TextBox textBoxDepartmentName;
        private System.Windows.Forms.Button buttonAddDepartment;
        private System.Windows.Forms.Button buttonUpdateDepartment;
    }
}