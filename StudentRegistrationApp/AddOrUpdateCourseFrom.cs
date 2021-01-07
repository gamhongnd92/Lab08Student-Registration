using EFControllerUtilities;
using StudentRegistrationCodeFirstFromDB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentRegistrationValidation;

namespace StudentRegistrationApp
{
    public partial class AddOrUpdateCourseFrom : Form
    {

        public AddOrUpdateCourseFrom()
        {
            InitializeComponent();

            // Register Event Handler
            this.Load += AddOrUpdateCourseFrom_Load;
            buttonAddCourse.Click += ButtonAddCourse_Click;
            buttonUpdateCourse.Click += ButtonUpdateCourse_Click;

            // Register event handler for when course is selected
            listBoxCourses.SelectedIndexChanged += (s, e) => GetCourse();
        }

        /// <summary>
        /// Method to load the form elements
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddOrUpdateCourseFrom_Load(object sender, EventArgs e)
        {
            // get courses and departments
            var courses = Controller<StudentRegistrationEntities, Course>.GetEntitiesWithIncluded("Department");
            var departments = Controller<StudentRegistrationEntities, Department>.GetEntities();

            // set them to the listboxes
            listBoxCourses.DataSource = courses;
            listBoxDepartment.DataSource = departments;

            // no course selected to start
            listBoxCourses.SelectedIndex = -1;

            // Set all textbox to blank
            textBoxCourseNumber.ResetText();
            textBoxCourseName.ResetText();
        }

        /// <summary>
        /// Method to add the course
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonAddCourse_Click(object sender, EventArgs e)
        {
            // if department is not selected - error
            if (listBoxDepartment.SelectedIndex < 0)
            {
                MessageBox.Show("Department  must be selected");
                return;
            }
            // get the selected department
            Department department = listBoxDepartment.SelectedItem as Department;

            // if the course number is not a valid integer! Error!
            if (!int.TryParse(textBoxCourseNumber.Text, out int courseNumberAdd))
            {
                MessageBox.Show("Course Number must be a valid integer!");
                return;
            }
            // get the course name to be added
            var courseName = textBoxCourseName.Text;
            // get the department id to add
            int departmentIdAdd = department.DepartmentId;

            // if the course is unique - can add
            if (IsUniqueCourse(courseNumberAdd, departmentIdAdd))
            {
                // create new course
                Course course = new Course()
                {
                    CourseNumber = courseNumberAdd,
                    CourseName = courseName,
                    DepartmentId = departmentIdAdd
                };
                // if invalid - error and return!
                if (course.InfoIsInvalid())
                {
                    MessageBox.Show("Course information is missing or invalid!");
                    return;
                }
                // add entity checking if successful and close
                if (Controller<StudentRegistrationEntities, Course>.AddEntity(course) == null)
                {
                    MessageBox.Show("Course was not added to database!");
                    return;
                }
                this.DialogResult = DialogResult.OK;
                Close();
            }

        }
        /// <summary>
        /// Method to update the course
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonUpdateCourse_Click(object sender, EventArgs e)
        {
            // if not selected - error
            if (!(listBoxCourses.SelectedItem is Course course))
            {
                MessageBox.Show("Course to be updated must be selected");
                return;
            }
            // if inputted course number is not an integer- error
            if (!int.TryParse(textBoxCourseNumber.Text, out int courseNumberUpdate))
            {
                MessageBox.Show("Course Number must be a valid integer!");
                return;
            }
            // get the department
            Department department = listBoxDepartment.SelectedItem as Department;
            int departmentIdUpdate = department.DepartmentId;

            // input new data
            course.CourseNumber = courseNumberUpdate;
            course.CourseName = textBoxCourseName.Text;
            course.Department = department;
            course.DepartmentId = departmentIdUpdate;

            // check if valid
            if (course.InfoIsInvalid())
            {
                MessageBox.Show("Course information is missing or invalid ");
                return;
            }

            // if the new updated course is unique- try updating
            if (IsUniqueCourse(courseNumberUpdate, departmentIdUpdate))
            {
                // update checking if successful and close
                if (Controller<StudentRegistrationEntities, Course>.UpdateEntity(course) == false)
                {
                    MessageBox.Show("Cannot update Course to database");
                    return;
                }

                this.DialogResult = DialogResult.OK;
                Close();
            }

        }

        /// <summary>
        /// Method to get the course and set the appropriate department as selected
        /// </summary>
        private void GetCourse()
        {
            // if not selected- error
            if (!(listBoxCourses.SelectedItem is Course course))
                return;

            // set the textboxes with appropriate information
            textBoxCourseNumber.Text = course.CourseNumber.ToString();
            textBoxCourseName.Text = course.CourseName;

            // go over the items in the department listbox and set selected if matches courses
            for (int i = 0; i < listBoxDepartment.Items.Count; i++)
            {
                if (course.DepartmentId == (listBoxDepartment.Items[i] as Department).DepartmentId)
                {
                    listBoxDepartment.SetSelected(i, true);
                }
            }
        }
        /// <summary>
        /// Method to check if inputted information matches any of the existing courses
        /// To be used when adding to verify uniqueness!
        /// </summary>
        /// <param name="courseNumber"> course number to be checked</param>
        /// <param name="departmentId"> department to be checked</param>
        /// <returns></returns>
        private bool IsUniqueCourse(int courseNumber, int departmentId)
        {
            // if controller can find any entity with same number and department
            if (Controller<StudentRegistrationEntities, Course>.AnyExists(c => (c.CourseNumber == courseNumber) && (c.DepartmentId == departmentId)))
            {
                // error and false
                MessageBox.Show("This Course already Exists! Please Input a different Course Number or Department");
                return false;
            }
            return true;
        }


    }
}
