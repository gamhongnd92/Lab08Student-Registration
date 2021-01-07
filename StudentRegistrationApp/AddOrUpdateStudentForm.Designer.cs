namespace StudentRegistrationApp
{
    partial class AddOrUpdateStudentForm
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
            this.listBoxStudents = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.listBoxDepartment = new System.Windows.Forms.ListBox();
            this.buttonAddStudent = new System.Windows.Forms.Button();
            this.buttonUpdateStudent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxStudents
            // 
            this.listBoxStudents.FormattingEnabled = true;
            this.listBoxStudents.ItemHeight = 16;
            this.listBoxStudents.Location = new System.Drawing.Point(180, 22);
            this.listBoxStudents.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxStudents.Name = "listBoxStudents";
            this.listBoxStudents.Size = new System.Drawing.Size(275, 180);
            this.listBoxStudents.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Students";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 237);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "First Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 282);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Last Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 331);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Department";
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(210, 236);
            this.textBoxFirstName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(198, 22);
            this.textBoxFirstName.TabIndex = 5;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(210, 282);
            this.textBoxLastName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(198, 22);
            this.textBoxLastName.TabIndex = 6;
            // 
            // listBoxDepartment
            // 
            this.listBoxDepartment.FormattingEnabled = true;
            this.listBoxDepartment.ItemHeight = 16;
            this.listBoxDepartment.Location = new System.Drawing.Point(210, 331);
            this.listBoxDepartment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxDepartment.Name = "listBoxDepartment";
            this.listBoxDepartment.Size = new System.Drawing.Size(198, 100);
            this.listBoxDepartment.TabIndex = 7;
            // 
            // buttonAddStudent
            // 
            this.buttonAddStudent.Location = new System.Drawing.Point(210, 454);
            this.buttonAddStudent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAddStudent.Name = "buttonAddStudent";
            this.buttonAddStudent.Size = new System.Drawing.Size(106, 30);
            this.buttonAddStudent.TabIndex = 9;
            this.buttonAddStudent.Text = "Add";
            this.buttonAddStudent.UseVisualStyleBackColor = true;
            // 
            // buttonUpdateStudent
            // 
            this.buttonUpdateStudent.Location = new System.Drawing.Point(349, 454);
            this.buttonUpdateStudent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonUpdateStudent.Name = "buttonUpdateStudent";
            this.buttonUpdateStudent.Size = new System.Drawing.Size(106, 30);
            this.buttonUpdateStudent.TabIndex = 10;
            this.buttonUpdateStudent.Text = "Update";
            this.buttonUpdateStudent.UseVisualStyleBackColor = true;
            // 
            // AddOrUpdateStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 520);
            this.Controls.Add(this.buttonUpdateStudent);
            this.Controls.Add(this.buttonAddStudent);
            this.Controls.Add(this.listBoxDepartment);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxStudents);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AddOrUpdateStudentForm";
            this.Text = "AddOrUpdateStudent";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxStudents;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.ListBox listBoxDepartment;
        private System.Windows.Forms.Button buttonAddStudent;
        private System.Windows.Forms.Button buttonUpdateStudent;
    }
}