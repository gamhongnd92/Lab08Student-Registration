using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFControllerUtilities;
using StudentRegistrationCodeFirstFromDB;
using System.Windows.Forms;
using StudentRegistrationValidation;

namespace StudentRegistrationApp
{
    public partial class AddOrUpdateStudentForm : Form
    {

        public AddOrUpdateStudentForm()
        {
            InitializeComponent();

            // Register event handler
            this.Load += AddOrUpdateStudentForm_Load;
            buttonAddStudent.Click += ButtonAddStudent_Click;
            buttonUpdateStudent.Click += ButtonUpdateStudent_Click;

            // register event handler for when student is selected
            listBoxStudents.SelectedIndexChanged += (s, e) => GetStudent();
        }

        /// <summary>
        /// Method to load all form's components on load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddOrUpdateStudentForm_Load(object sender, EventArgs e)
        {
            // Bind the listbox of students to Students table
            listBoxStudents.DataSource =
                Controller<StudentRegistrationEntities, Student>.SetBindingList();

            // no student is selected to start
            listBoxStudents.SelectedIndex = -1;

            // Set all textbox to blank;
            textBoxFirstName.ResetText();
            textBoxLastName.ResetText();

            //clear the listbox before adding items again
            listBoxDepartment.Items.Clear();
            // Add the DepartmentCode to the listbox department
            foreach (var department in Controller<StudentRegistrationEntities, Department>.GetEntities())
            {
                listBoxDepartment.Items.Add(department);
            }
            // add a no department option
            listBoxDepartment.Items.Add("None");
        }

        /// <summary>
        /// Method to add a student to the database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonAddStudent_Click(object sender, EventArgs e)
        {
            // get the selected department
            Department department = listBoxDepartment.SelectedItem as Department;

            // make a new student
            Student newStudent = new Student()
            {
                StudentFirstName = textBoxFirstName.Text,
                StudentLastName = textBoxLastName.Text,
                DepartmentId = department?.DepartmentId // could be null!
            };

            // validity check
            if (newStudent.InfoIsInvalid())
            {
                MessageBox.Show("Student information is missing.");
                return;
            }
            // try to add- see if successful
            if (Controller<StudentRegistrationEntities, Student>.AddEntity(newStudent) == null)
            {
                MessageBox.Show("Cannot add Student to database");
                return;
            }

            this.DialogResult = DialogResult.OK;
            Close();
        }

        /// <summary>
        /// Method to update a student
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonUpdateStudent_Click(object sender, EventArgs e)
        {
            // if no student is selected- error
            if (!(listBoxStudents.SelectedItem is Student student))
            {
                MessageBox.Show("Student to be updated must be selected");
                return;
            }
            // assign new name and department from controls
            student.StudentFirstName = textBoxFirstName.Text;
            student.StudentLastName = textBoxLastName.Text;
            Department department = listBoxDepartment.SelectedItem as Department; // get department
            student.DepartmentId = department?.DepartmentId; // could be null!

            // validity check
            if (student.InfoIsInvalid())
            {
                MessageBox.Show("Student information is missing.");
                return;
            }

            // update the db checking if successful
            if (Controller<StudentRegistrationEntities, Student>.UpdateEntity(student) == false)
            {
                MessageBox.Show("Cannot update student to database");
                return;
            }

            this.DialogResult = DialogResult.OK;
            Close();
        }

        /// <summary>
        /// Method to display student's information in controls
        /// </summary>
        private void GetStudent()
        {
            // if not selected
            if (!(listBoxStudents.SelectedItem is Student student))
                return;
            // otherwise display name
            textBoxFirstName.Text = student.StudentFirstName;
            textBoxLastName.Text = student.StudentLastName;


            // go through the listbox of departments 
            // set selected to the one that has the same Id
            for (int i = 0; i < listBoxDepartment.Items.Count; i++)
            {
                //null check!
                if (student.DepartmentId == (listBoxDepartment.Items[i] as Department)?.DepartmentId)
                {
                    listBoxDepartment.SetSelected(i, true);
                }
            }

        }
    }
}
