using EFControllerUtilities;
using StudentRegistrationCodeFirstFromDB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentRegistrationValidation;

namespace StudentRegistrationApp
{
    public partial class AddOrUpdateDepartmentForm : Form
    {
        public AddOrUpdateDepartmentForm()
        {
            InitializeComponent();

            // Register the event handler
            this.Load += AddOrUpdateDepartmentForm_Load;
            buttonAddDepartment.Click += ButtonAddDepartment_Click;
            buttonUpdateDepartment.Click += ButtonUpdateDepartment_Click;

            // register event handler for when Department is selected
            listBoxDepartments.SelectedIndexChanged += (s, e) => GetDepartment();
        }

        /// <summary>
        /// Method to set up form's elements on load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddOrUpdateDepartmentForm_Load(object sender, EventArgs e)
        {
            // Bind the listbox of Department to Departments table
            listBoxDepartments.DataSource = Controller<StudentRegistrationEntities, Department>.SetBindingList();

            // No department selected to start
            listBoxDepartments.SelectedIndex = -1;

            // Sett all textbox to blank
            textBoxDepartmentCode.ResetText();
            textBoxDepartmentName.ResetText();
        }

        /// <summary>
        /// Get the needed information based on the selected item
        /// </summary>
        private void GetDepartment()
        {
            // check if selected is a department- otherwise error
            if (!(listBoxDepartments.SelectedItem is Department department))
                return;
            // input data into the textboxes
            textBoxDepartmentCode.Text = department.DepartmentCode;
            textBoxDepartmentName.Text = department.DepartmentName;
        }

        /// <summary>
        /// Method to update the department information
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonUpdateDepartment_Click(object sender, EventArgs e)
        {
            // if not selected - error
            if (!(listBoxDepartments.SelectedItem is Department department))
            {
                MessageBox.Show("Department to be updated must be selected");
                return;
            }
            // get the information from the textboxes and set to the department
            department.DepartmentCode = textBoxDepartmentCode.Text;
            department.DepartmentName = textBoxDepartmentName.Text;

            // check if valid- error if not
            if (department.InfoIsInvalid())
            {
                MessageBox.Show("Department information is invalid or missing");
                return;
            }
            // if the new updated code is not unique- error!
            if (IsUniqueDepartment(department.DepartmentCode))
            {
                // update the db checking if successful
                if (Controller<StudentRegistrationEntities, Department>.UpdateEntity(department) == false)
                {
                    MessageBox.Show("Cannot update department to database");
                    return;
                }

                this.DialogResult = DialogResult.OK;
                Close();
            }
        }

        /// <summary>
        /// Method to add a department to the database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonAddDepartment_Click(object sender, EventArgs e)
        {
            // call helper method to ensure it is unique!
            if (IsUniqueDepartment(textBoxDepartmentCode.Text))
            {
                // if it is- create new department
                Department department = new Department()
                {
                    DepartmentCode = textBoxDepartmentCode.Text,
                    DepartmentName = textBoxDepartmentName.Text
                };
                // check if valid
                if (department.InfoIsInvalid())
                {
                    MessageBox.Show("Department information is invalid or missing");
                    return;
                }
                // now update the db checking if successful
                if (Controller<StudentRegistrationEntities, Department>.AddEntity(department) == null)
                {
                    MessageBox.Show("Cannot add Department to database");
                    return;
                }
                this.DialogResult = DialogResult.OK;
                Close();
            }

        }

        /// <summary>
        /// Method to check if the department to be added is unique
        /// </summary>
        /// <param name="departmentCode"> department code to be added</param>
        /// <returns></returns>
        private bool IsUniqueDepartment(string departmentCode)
        {
            // check if any entity exists with the same department code
            if (Controller<StudentRegistrationEntities, Department>.AnyExists(d => d.DepartmentCode == departmentCode))
            {
                // error message and return false
                MessageBox.Show("This Department already Exists! Please Input a Different Code");
                return false;
            }
            return true;
        }


    }
}
