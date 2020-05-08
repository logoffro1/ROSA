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
    public partial class loginForm : Form
    {
      
        public loginForm()
        {
            InitializeComponent();
        }

        private void loginForm_Load(object sender, EventArgs e)
        {
     
        }
        private void CheckCredentials()
        {
            Employee_Service employeeService = new Employee_Service();

            bool employeeExists = false;

            if (txtUsername.Text == "" || txtPassword.Text == "")
            {
                //if the textboxes are empty, give error message
                lblError.Visible = true;
                lblError.Text = "Username and Password required!";

            }
            else
            {
                //if they are not empty, read the employees from the database and compare them with the input from the user
                lblError.Visible = false;

                List<Employee> employees = employeeService.GetEmployees();
                foreach (Employee employee in employees)
                {
                    if (employee.username == txtUsername.Text && employee.password == txtPassword.Text)
                    {
                        //if the user input matches with the database info, set employeeExists to true
                        employeeExists = true;
                        break;
                    }
                }
                if (!employeeExists)
                {
                    //if the employee doesn't exist, give error message
                    lblError.Visible = true;
                    lblError.Text = "Username or Password incorrect!";
                }
                else
                {
                    //if the employee exists, login the user and open the main form
                    mainForm MainForm = new mainForm();
                    MainForm.Show();
                    this.Hide();
                }


            }
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {

            CheckCredentials();
        }

        private void txtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                CheckCredentials();
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
                CheckCredentials();

        }
        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void eyePic_Click(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !txtPassword.UseSystemPasswordChar;
        }
    }
}
