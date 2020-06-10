using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RosaLogic;
using RosaModel;

namespace LoginForm
{
    public partial class AddEmployeeForm : Form
    {
        private Employee employee;
        public AddEmployeeForm(Employee employee)
        {
            InitializeComponent();
            this.employee = employee;
        }

        private void AddEmployeeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void homeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new SwitchForms(employee, this, new homeForm(employee));
        }

        private void tablesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new SwitchForms(employee, this, new tableViewForm(employee));
        }

        private void barToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new SwitchForms(employee, this, new BarKitchenForm(employee, "bar"));
        }

        private void kitchenToolStripMenuItem_Click(object sender, EventArgs e)
        {

            new SwitchForms(employee, this, new BarKitchenForm(employee, "kitchen"));
        }

        private void lblLogout_Click(object sender, EventArgs e)
        {
            loginForm loginForm = new loginForm();
            loginForm.Show();
            this.Hide();
        }
        private void AddEmployeeForm_Load(object sender, EventArgs e)
        {
            dateOfBirth.MaxDate = DateTime.Now.AddYears(-18); // so the new employee can't be younger than 18 yo
        }

        private void btnAddAcount_Click(object sender, EventArgs e)
        {
            Employee_Service employeeService = new Employee_Service();
            bool emptyField = false; // to check if a field is empty

            if (
                string.IsNullOrEmpty(txtFirstNName.Text)
                || string.IsNullOrEmpty(txtLastName.Text)
                || string.IsNullOrEmpty(txtUsername.Text)
                || string.IsNullOrEmpty(txtPassword.Text)) //if the textboxes are empty, set emptyField to true
                emptyField = true;

           //if all the  radio buttons are unchecked, set emptyField to truue
            if (!btnManager.Checked && !btnWaiter.Checked && !btnChef.Checked && !btnBartender.Checked) 
                emptyField = true;

            if (emptyField) //show warning if there are empty fields
                MessageBox.Show("All fields must be filled!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                // set the employeeRole based on what was checked
                Roles employeeRole;
                if (btnManager.Checked)
                    employeeRole = Roles.Manager;
                else if (btnWaiter.Checked)
                    employeeRole = Roles.Waiter;
                else if (btnChef.Checked)
                    employeeRole = Roles.Chef;
                else
                    employeeRole = Roles.Bartender;


                Employee tempEmployee = employeeService.GetAccountByUsername(txtUsername.Text);
                if (tempEmployee != null) //check if that username already exists
                    MessageBox.Show("This username already exists!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    Employee newEmployee = new Employee() //create the new employee
                    {
                        firstName = txtFirstNName.Text,
                        lastName = txtLastName.Text,
                        username = txtUsername.Text,
                        password = txtPassword.Text,
                        role = employeeRole
                    };
                    employeeService.AddAccount(newEmployee); //add the new employee to the DB
                    MessageBox.Show("New account added!", "Added", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new SwitchForms(employee, this, new ManagementForm(employee));
        }

        private void managementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new SwitchForms(employee, this, new ManagementForm(employee));
        }
    }
}
