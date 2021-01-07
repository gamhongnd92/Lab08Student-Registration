namespace StudentRegistrationApp
{
    partial class AddOrUpdateCourseFrom
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
            this.listBoxCourses = new System.Windows.Forms.ListBox();
            this.listBoxDepartment = new System.Windows.Forms.ListBox();
            this.textBoxCourseNumber = new System.Windows.Forms.TextBox();
            this.textBoxCourseName = new System.Windows.Forms.TextBox();
            this.buttonAddCourse = new System.Windows.Forms.Button();
            this.buttonUpdateCourse = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxCourses
            // 
            this.listBoxCourses.FormattingEnabled = true;
            this.listBoxCourses.ItemHeight = 16;
            this.listBoxCourses.Location = new System.Drawing.Point(261, 23);
            this.listBoxCourses.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxCourses.Name = "listBoxCourses";
            this.listBoxCourses.Size = new System.Drawing.Size(189, 180);
            this.listBoxCourses.TabIndex = 0;
            // 
            // listBoxDepartment
            // 
            this.listBoxDepartment.FormattingEnabled = true;
            this.listBoxDepartment.ItemHeight = 16;
            this.listBoxDepartment.Location = new System.Drawing.Point(268, 233);
            this.listBoxDepartment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxDepartment.Name = "listBoxDepartment";
            this.listBoxDepartment.Size = new System.Drawing.Size(181, 116);
            this.listBoxDepartment.TabIndex = 1;
            // 
            // textBoxCourseNumber
            // 
            this.textBoxCourseNumber.Location = new System.Drawing.Point(267, 394);
            this.textBoxCourseNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxCourseNumber.Name = "textBoxCourseNumber";
            this.textBoxCourseNumber.Size = new System.Drawing.Size(182, 22);
            this.textBoxCourseNumber.TabIndex = 2;
            // 
            // textBoxCourseName
            // 
            this.textBoxCourseName.Location = new System.Drawing.Point(268, 444);
            this.textBoxCourseName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxCourseName.Name = "textBoxCourseName";
            this.textBoxCourseName.Size = new System.Drawing.Size(182, 22);
            this.textBoxCourseName.TabIndex = 3;
            // 
            // buttonAddCourse
            // 
            this.buttonAddCourse.Location = new System.Drawing.Point(261, 498);
            this.buttonAddCourse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAddCourse.Name = "buttonAddCourse";
            this.buttonAddCourse.Size = new System.Drawing.Size(98, 30);
            this.buttonAddCourse.TabIndex = 4;
            this.buttonAddCourse.Text = "Add";
            this.buttonAddCourse.UseVisualStyleBackColor = true;
            // 
            // buttonUpdateCourse
            // 
            this.buttonUpdateCourse.Location = new System.Drawing.Point(393, 498);
            this.buttonUpdateCourse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonUpdateCourse.Name = "buttonUpdateCourse";
            this.buttonUpdateCourse.Size = new System.Drawing.Size(98, 30);
            this.buttonUpdateCourse.TabIndex = 5;
            this.buttonUpdateCourse.Text = "Update";
            this.buttonUpdateCourse.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(113, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Courses";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(113, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Department";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(113, 398);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Course Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(113, 447);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Course Name";
            // 
            // AddOrUpdateCourseFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 549);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonUpdateCourse);
            this.Controls.Add(this.buttonAddCourse);
            this.Controls.Add(this.textBoxCourseName);
            this.Controls.Add(this.textBoxCourseNumber);
            this.Controls.Add(this.listBoxDepartment);
            this.Controls.Add(this.listBoxCourses);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AddOrUpdateCourseFrom";
            this.Text = "AddOrUpdateCourse";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxCourses;
        private System.Windows.Forms.ListBox listBoxDepartment;
        private System.Windows.Forms.TextBox textBoxCourseNumber;
        private System.Windows.Forms.TextBox textBoxCourseName;
        private System.Windows.Forms.Button buttonAddCourse;
        private System.Windows.Forms.Button buttonUpdateCourse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}