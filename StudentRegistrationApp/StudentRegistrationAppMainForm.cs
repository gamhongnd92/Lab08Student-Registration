using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentRegistrationCodeFirstFromDB;
using EFControllerUtilities;
using SeedDatabaseExtensions;
using System.Data.Entity;
using System.Diagnostics;

namespace StudentRegistrationApp
{
    public partial class StudentRegistrationAppMainForm : Form
    {
        public StudentRegistrationAppMainForm()
        {
            InitializeComponent();
            // set title
            this.Text = "Student Registration App";

            this.Load += (s, e) => StudentRegistrationAppMainForm_Load();

            // Add or Update Student
            AddOrUpdateStudentForm addOrUpdateStudent = new AddOrUpdateStudentForm();
            buttonAddUpdateStudent.Click += (s, e) => AddOrUpdateForm<Student>(dataGridViewStudents, addOrUpdateStudent);

            // Add or Update Department 
            AddOrUpdateDepartmentForm addOrUpdateDepartment = new AddOrUpdateDepartmentForm();
            btnAddUpdateDepartment.Click += (s, e) => AddOrUpdateForm<Department>(dataGridViewDepartments, addOrUpdateDepartment);

            // Add or Update Course 
            AddOrUpdateCourseFrom addOrUpdateCourse = new AddOrUpdateCourseFrom();
            btnAddUpdateCourse.Click += (s, e) => AddOrUpdateForm<Course>(dataGridViewCourses, addOrUpdateCourse);

            // Register Student to the Courses
            buttonRegister.Click += (s, e) => RegisterStudent(dataGridViewStudents, dataGridViewCourses);

            // Drop the Student from the Course
            buttonDrop.Click += (s, e) => DropFromCourse(dataGridViewRegistrations);
        }

        /// <summary>
        /// Method to load all datagridviews and seed the initial database
        /// </summary>
        private void StudentRegistrationAppMainForm_Load()
        {
            // using the Unit-of-work context
            // seed the database
            using (StudentRegistrationEntities context = new StudentRegistrationEntities())
            {
                context.SeedDatabase();
            }
            // common setup for datagridview controls
            InitializeDataGridView<Student>(dataGridViewStudents, "Courses", "Department");
            InitializeDataGridView<Course>(dataGridViewCourses, "Students", "Department");
            InitializeDataGridView<Department>(dataGridViewDepartments, "Courses", "Students");
            // set up the registration view using a custom method
            InitializeRegistrationView(dataGridViewRegistrations);
        }

        /// <summary>
        /// Set up the datagridviews of the three different entities
        /// Use generics to be able to put in any class data
        /// </summary>
        /// <typeparam name="T"> generics </typeparam>
        /// <param name="gridView"> datagridview to be seeded </param>
        /// <param name="columnsToHide"> which columns should not be displayed </param>
        private void InitializeDataGridView<T>(DataGridView gridView, params string[] columnsToHide) where T : class
        {
            // Allow users to add/delete rows, and fill out columns to the entire width of the control
            gridView.AllowUserToAddRows = false;
            gridView.AllowUserToDeleteRows = true;
            gridView.ReadOnly = true;
            gridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // set the handler used to delete an item
            gridView.UserDeletingRow += (s, e) => DeletingRow<T>(s as DataGridView, e);

            // add the Binding List to the datagridview
            gridView.DataSource = Controller<StudentRegistrationEntities, T>.SetBindingList();
            // go through the columns that we don't want to display - and set them to not visible
            foreach (string column in columnsToHide)
                gridView.Columns[column].Visible = false;
        }

        /// <summary>
        /// Method to delete a row from datagridview
        /// Generics to be able to apply to all editable datagridviews
        /// </summary>
        /// <typeparam name="T"> generic</typeparam>
        /// <param name="dataGridView"> datagridview in which delete has occurred </param>
        /// <param name="e"> event arguments </param>
        private void DeletingRow<T>(DataGridView dataGridView, DataGridViewRowCancelEventArgs e) where T : class
        {
            // get an item which was deleted from the args
            T item = e.Row.DataBoundItem as T;

            // if department- null all students before deleting!
            if (typeof(T) == typeof(Department))
            {
                // call helper method
                RemoveStudentsFromDepartment((item as Department).DepartmentId, dataGridViewStudents);
            }

            // delete - check if successful
            if (Controller<StudentRegistrationEntities, T>.DeleteEntity(item) == false)
            {
                MessageBox.Show("Delete of Department was not successful!");
            }
            else
            {
                // refresh 
                dataGridView.Refresh();
                // if department- reset the courses to show the changes!
                if (typeof(T) == typeof(Department))
                {
                    dataGridViewCourses.DataSource = Controller<StudentRegistrationEntities, Course>.SetBindingList();
                }
            }
            // always reload the registration display
            ReloadRegistrationView();
        }

        /// <summary>
        /// Method to remove all students from the department given the departmentID 
        /// </summary>
        /// <param name="departmentId"> department id to remove </param>
        /// <param name="studentsDisplay"> datagridview of students to display changes</param>
        private static void RemoveStudentsFromDepartment(int departmentId, DataGridView studentsDisplay)
        {
            // using unit-of-work context
            using (StudentRegistrationEntities context = new StudentRegistrationEntities())
            {
                // get the students in that department
                var students = context.Students.Where(x => x.DepartmentId == departmentId).ToList();
                // for all- set their department and departmentId to null
                foreach (Student st in students)
                {
                    st.Department = null;
                    st.DepartmentId = null;
                }
                // save changes
                context.SaveChanges();
            }
            // refresh the display to show changes
            studentsDisplay.DataSource = Controller<StudentRegistrationEntities, Student>.SetBindingList();
            studentsDisplay.Refresh();
        }

        /// <summary>
        /// Method to display all registrations
        /// </summary>
        /// <param name="datagridviewRegistrations"> datagridview to be used for display</param>
        private static void InitializeRegistrationView(DataGridView datagridviewRegistrations)
        {
            // set number of columns
            datagridviewRegistrations.ColumnCount = 5;
            // Set the column header names.
            datagridviewRegistrations.Columns[0].Name = "Department";
            datagridviewRegistrations.Columns[1].Name = "Course Number";
            datagridviewRegistrations.Columns[2].Name = "Course Name";
            datagridviewRegistrations.Columns[3].Name = "Student ID";
            datagridviewRegistrations.Columns[4].Name = "Last Name";
            // using unit-of-work context
            using (StudentRegistrationEntities context = new StudentRegistrationEntities())
            {
                // loop through all courses
                foreach (Course course in context.Courses)
                {
                    // loop over all courses for each student
                    foreach (Student st in course.Students)
                    {
                        // get the needed information
                        string[] rowAdd = { course.Department.DepartmentCode, course.CourseNumber.ToString(), course.CourseName, st.StudentId.ToString(), st.StudentLastName };
                        // add to display
                        datagridviewRegistrations.Rows.Add(rowAdd);
                    }
                }
            }
            // set all properties
            datagridviewRegistrations.AllowUserToAddRows = false;
            datagridviewRegistrations.AllowUserToDeleteRows = false;
            datagridviewRegistrations.ReadOnly = true;
            datagridviewRegistrations.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        /// <summary>
        /// Method to display any child form
        /// </summary>
        /// <typeparam name="T"> generic </typeparam>
        /// <param name="dataGridView"> datagridview that is about to receive changes</param>
        /// <param name="form"> form to display</param>
        private void AddOrUpdateForm<T>(DataGridView dataGridView, Form form) where T : class
        {
            // if okay was clicked on the child
            var result = form.ShowDialog();
            if (result == DialogResult.OK)
            {
                // reload the datagridview
                dataGridView.DataSource = Controller<StudentRegistrationEntities, T>.SetBindingList();
                dataGridView.Refresh();

                // always update the student registrations
                ReloadRegistrationView();
            }
            // hide the child form
            form.Hide();
        }

        /// <summary>
        /// Method to reload data in the registration view
        /// </summary>
        private void ReloadRegistrationView()
        {
            // clear all rows
            dataGridViewRegistrations.Rows.Clear();
            //using unit-of-work displosable context
            using (StudentRegistrationEntities registrationViewContext = new StudentRegistrationEntities())
            {
                // loop through all courses
                foreach (Course course in registrationViewContext.Courses)
                {
                    // loop over all courses for each student
                    foreach (Student st in course.Students)
                    {
                        // get needed data
                        string[] rowAdd = { course.Department.DepartmentCode, course.CourseNumber.ToString(), course.CourseName, st.StudentId.ToString(), st.StudentLastName };
                        dataGridViewRegistrations.Rows.Add(rowAdd); // add to the datagridview
                    }
                }
            }
        }

        /// <summary>
        /// Method to drop a registration
        /// </summary>
        /// <param name="registrations"> datagridview to be processed</param>
        private void DropFromCourse(DataGridView registrations)
        {
            // if none is selected - error!
            if (registrations.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please Select a Registration to be dropped!");
            }
            else
            {
                // using unit-of-work context
                using (StudentRegistrationEntities context = new StudentRegistrationEntities())
                {
                    // for every selected row
                    foreach (DataGridViewRow row in registrations.SelectedRows)
                    {
                        // find the student based on ID
                        int selectedStudentID = Convert.ToInt32(row.Cells[3].Value);
                        Student selectedStudent = context.Students.Find(selectedStudentID);

                        // look for Department ID
                        string departmentCode = Convert.ToString(row.Cells[0].Value);
                        Department selectedDepartment = context.Departments.SingleOrDefault(department => department.DepartmentCode == departmentCode);
                        int selectedDepartmentId = selectedDepartment.DepartmentId;

                        // look for Course ID
                        int courseNumber = Convert.ToInt32(row.Cells[1].Value);
                        Course selectedCourse = context.Courses.SingleOrDefault(course => course.CourseNumber == courseNumber && course.DepartmentId == selectedDepartmentId);

                        // remove the course from the student
                        selectedStudent.Courses.Remove(selectedCourse);
                        context.SaveChanges(); // save changes
                    }
                }
                // reload the display to show changes
                ReloadRegistrationView();
            }
        }

        /// <summary>
        /// Method to add registration
        /// </summary>
        /// <param name="students"> datagridview from which a student was selected</param>
        /// <param name="courses"> datagridview from which a course was selected</param>
        private void RegisterStudent(DataGridView students, DataGridView courses)
        {
            // if one was not selected- error
            if (students.SelectedRows.Count == 0 || courses.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please Select a Student and a Course for Registration!");
            }
            else
            {
                // using unit-of-work context
                using (StudentRegistrationEntities context = new StudentRegistrationEntities())
                {
                    // foreach of the students
                    foreach (DataGridViewRow row in students.SelectedRows)
                    {
                        // check that it is a student - not really required (since mostly display!)
                        // but just in case
                        if (row.DataBoundItem is Student student)
                        {
                            // go through all selected courses
                            foreach (DataGridViewRow rowCourse in courses.SelectedRows)
                            {
                                // check that it is a course - not really required (since mostly display!)
                                // but just in case
                                if (rowCourse.DataBoundItem is Course course)
                                {
                                    // get course and student from the context
                                    var courseFromContext = context.Courses.Find(course.CourseId);
                                    var studentFromContext = context.Students.Find(student.StudentId);
                                    // add the course to the student
                                    //could've been other way around
                                    studentFromContext.Courses.Add(courseFromContext);
                                    context.SaveChanges(); // save changes



                                }
                            }
                        }

                    }

                }
            }
            // reload the display of the registrations
            ReloadRegistrationView();
        }

    }
}
