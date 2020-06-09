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
            dateOfBirth.MaxDate = DateTime.Now.AddYears(-18);
        }

        private void btnAddAcount_Click(object sender, EventArgs e)
        {
            Employee_Service employeeService = new Employee_Service();
            bool emptyField = false;
            if (
                string.IsNullOrEmpty(txtFirstNName.Text)
                || string.IsNullOrEmpty(txtLastName.Text)
                || string.IsNullOrEmpty(txtUsername.Text)
                || string.IsNullOrEmpty(txtPassword.Text))
                emptyField = true;

            if (!btnManager.Checked && !btnWaiter.Checked&& !btnChef.Checked&& !btnBartender.Checked)
                emptyField = true;
                
                if (emptyField)
                MessageBox.Show("All fields must be filled!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
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
                if(tempEmployee != null)
                    MessageBox.Show("This username already exists!","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                else
                {
                    Employee newEmployee = new Employee()
                    {
                        firstName = txtFirstNName.Text,
                        lastName = txtLastName.Text,
                        username = txtUsername.Text,
                        password = txtPassword.Text,
                        role = employeeRole                       
                    };
                    employeeService.AddAccount(newEmployee);
                    MessageBox.Show("New account added!","Added",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new SwitchForms(employee, this, new ManagementForm(employee));
        }

        private void orderToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
    }
}
