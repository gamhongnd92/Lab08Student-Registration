namespace StudentRegistrationApp
{
    partial class StudentRegistrationAppMainForm
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
            this.labelStudents = new System.Windows.Forms.Label();
            this.labelCourses = new System.Windows.Forms.Label();
            this.labelRegistrations = new System.Windows.Forms.Label();
            this.labelDepartments = new System.Windows.Forms.Label();
            this.dataGridViewStudents = new System.Windows.Forms.DataGridView();
            this.dataGridViewCourses = new System.Windows.Forms.DataGridView();
            this.dataGridViewRegistrations = new System.Windows.Forms.DataGridView();
            this.dataGridViewDepartments = new System.Windows.Forms.DataGridView();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.buttonDrop = new System.Windows.Forms.Button();
            this.labelButtonExplanation = new System.Windows.Forms.Label();
            this.buttonAddUpdateStudent = new System.Windows.Forms.Button();
            this.btnAddUpdateDepartment = new System.Windows.Forms.Button();
            this.btnAddUpdateCourse = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCourses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRegistrations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDepartments)).BeginInit();
            this.SuspendLayout();
            // 
            // labelStudents
            // 
            this.labelStudents.AutoSize = true;
            this.labelStudents.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelStudents.Location = new System.Drawing.Point(51, 9);
            this.labelStudents.Name = "labelStudents";
            this.labelStudents.Size = new System.Drawing.Size(66, 19);
            this.labelStudents.TabIndex = 0;
            this.labelStudents.Text = "Students";
            // 
            // labelCourses
            // 
            this.labelCourses.AutoSize = true;
            this.labelCourses.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelCourses.Location = new System.Drawing.Point(51, 233);
            this.labelCourses.Name = "labelCourses";
            this.labelCourses.Size = new System.Drawing.Size(62, 19);
            this.labelCourses.TabIndex = 1;
            this.labelCourses.Text = "Courses";
            // 
            // labelRegistrations
            // 
            this.labelRegistrations.AutoSize = true;
            this.labelRegistrations.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelRegistrations.Location = new System.Drawing.Point(51, 469);
            this.labelRegistrations.Name = "labelRegistrations";
            this.labelRegistrations.Size = new System.Drawing.Size(93, 19);
            this.labelRegistrations.TabIndex = 2;
            this.labelRegistrations.Text = "Registrations";
            // 
            // labelDepartments
            // 
            this.labelDepartments.AutoSize = true;
            this.labelDepartments.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelDepartments.Location = new System.Drawing.Point(701, 9);
            this.labelDepartments.Name = "labelDepartments";
            this.labelDepartments.Size = new System.Drawing.Size(91, 19);
            this.labelDepartments.TabIndex = 3;
            this.labelDepartments.Text = "Departments";
            // 
            // dataGridViewStudents
            // 
            this.dataGridViewStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStudents.Location = new System.Drawing.Point(51, 46);
            this.dataGridViewStudents.Name = "dataGridViewStudents";
            this.dataGridViewStudents.RowHeadersWidth = 51;
            this.dataGridViewStudents.RowTemplate.Height = 24;
            this.dataGridViewStudents.Size = new System.Drawing.Size(461, 166);
            this.dataGridViewStudents.TabIndex = 4;
            // 
            // dataGridViewCourses
            // 
            this.dataGridViewCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCourses.Location = new System.Drawing.Point(51, 267);
            this.dataGridViewCourses.Name = "dataGridViewCourses";
            this.dataGridViewCourses.RowHeadersWidth = 51;
            this.dataGridViewCourses.RowTemplate.Height = 24;
            this.dataGridViewCourses.Size = new System.Drawing.Size(576, 177);
            this.dataGridViewCourses.TabIndex = 5;
            // 
            // dataGridViewRegistrations
            // 
            this.dataGridViewRegistrations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRegistrations.Location = new System.Drawing.Point(51, 509);
            this.dataGridViewRegistrations.Name = "dataGridViewRegistrations";
            this.dataGridViewRegistrations.RowHeadersWidth = 51;
            this.dataGridViewRegistrations.RowTemplate.Height = 24;
            this.dataGridViewRegistrations.Size = new System.Drawing.Size(693, 182);
            this.dataGridViewRegistrations.TabIndex = 6;
            // 
            // dataGridViewDepartments
            // 
            this.dataGridViewDepartments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDepartments.Location = new System.Drawing.Point(701, 46);
            this.dataGridViewDepartments.Name = "dataGridViewDepartments";
            this.dataGridViewDepartments.RowHeadersWidth = 51;
            this.dataGridViewDepartments.RowTemplate.Height = 24;
            this.dataGridViewDepartments.Size = new System.Drawing.Size(443, 166);
            this.dataGridViewDepartments.TabIndex = 7;
            // 
            // buttonRegister
            // 
            this.buttonRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegister.Location = new System.Drawing.Point(790, 509);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(103, 46);
            this.buttonRegister.TabIndex = 8;
            this.buttonRegister.Text = "Register";
            this.buttonRegister.UseVisualStyleBackColor = true;
            // 
            // buttonDrop
            // 
            this.buttonDrop.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDrop.Location = new System.Drawing.Point(790, 598);
            this.buttonDrop.Name = "buttonDrop";
            this.buttonDrop.Size = new System.Drawing.Size(103, 46);
            this.buttonDrop.TabIndex = 9;
            this.buttonDrop.Text = "Drop";
            this.buttonDrop.UseVisualStyleBackColor = true;
            // 
            // labelButtonExplanation
            // 
            this.labelButtonExplanation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelButtonExplanation.Location = new System.Drawing.Point(977, 509);
            this.labelButtonExplanation.Name = "labelButtonExplanation";
            this.labelButtonExplanation.Size = new System.Drawing.Size(187, 135);
            this.labelButtonExplanation.TabIndex = 10;
            this.labelButtonExplanation.Text = "Register by selecting students and courses then hit Register button \r\n\r\nDrop by s" +
    "electing Registration then hit Drop button";
            // 
            // buttonAddUpdateStudent
            // 
            this.buttonAddUpdateStudent.Location = new System.Drawing.Point(540, 79);
            this.buttonAddUpdateStudent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAddUpdateStudent.Name = "buttonAddUpdateStudent";
            this.buttonAddUpdateStudent.Size = new System.Drawing.Size(118, 90);
            this.buttonAddUpdateStudent.TabIndex = 11;
            this.buttonAddUpdateStudent.Text = "Add or Update Student";
            this.buttonAddUpdateStudent.UseVisualStyleBackColor = true;
            // 
            // btnAddUpdateDepartment
            // 
            this.btnAddUpdateDepartment.Location = new System.Drawing.Point(1166, 79);
            this.btnAddUpdateDepartment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddUpdateDepartment.Name = "btnAddUpdateDepartment";
            this.btnAddUpdateDepartment.Size = new System.Drawing.Size(108, 90);
            this.btnAddUpdateDepartment.TabIndex = 12;
            this.btnAddUpdateDepartment.Text = "Add or Update Department";
            this.btnAddUpdateDepartment.UseVisualStyleBackColor = true;
            // 
            // btnAddUpdateCourse
            // 
            this.btnAddUpdateCourse.Location = new System.Drawing.Point(660, 299);
            this.btnAddUpdateCourse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddUpdateCourse.Name = "btnAddUpdateCourse";
            this.btnAddUpdateCourse.Size = new System.Drawing.Size(118, 90);
            this.btnAddUpdateCourse.TabIndex = 13;
            this.btnAddUpdateCourse.Text = "Add or Update Courses";
            this.btnAddUpdateCourse.UseVisualStyleBackColor = true;
            // 
            // StudentRegistrationAppMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 745);
            this.Controls.Add(this.btnAddUpdateCourse);
            this.Controls.Add(this.btnAddUpdateDepartment);
            this.Controls.Add(this.buttonAddUpdateStudent);
            this.Controls.Add(this.labelButtonExplanation);
            this.Controls.Add(this.buttonDrop);
            this.Controls.Add(this.buttonRegister);
            this.Controls.Add(this.dataGridViewDepartments);
            this.Controls.Add(this.dataGridViewRegistrations);
            this.Controls.Add(this.dataGridViewCourses);
            this.Controls.Add(this.dataGridViewStudents);
            this.Controls.Add(this.labelDepartments);
            this.Controls.Add(this.labelRegistrations);
            this.Controls.Add(this.labelCourses);
            this.Controls.Add(this.labelStudents);
            this.Name = "StudentRegistrationAppMainForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCourses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRegistrations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDepartments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelStudents;
        private System.Windows.Forms.Label labelCourses;
        private System.Windows.Forms.Label labelRegistrations;
        private System.Windows.Forms.Label labelDepartments;
        private System.Windows.Forms.DataGridView dataGridViewStudents;
        private System.Windows.Forms.DataGridView dataGridViewCourses;
        private System.Windows.Forms.DataGridView dataGridViewRegistrations;
        private System.Windows.Forms.DataGridView dataGridViewDepartments;
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.Button buttonDrop;
        private System.Windows.Forms.Label labelButtonExplanation;
        private System.Windows.Forms.Button buttonAddUpdateStudent;
        private System.Windows.Forms.Button btnAddUpdateDepartment;
        private System.Windows.Forms.Button btnAddUpdateCourse;
    }
}

