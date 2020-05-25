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
        private void CheckCredentials() //validate the credentials
        {
            Employee_Service employeeService = new Employee_Service();

            if (string.IsNullOrWhiteSpace(txtUsername.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                //if the textboxes are empty, give error message
                lblError.Visible = true;
                lblError.Text = "Username and Password required!";

            }
            else //if they are not empty, read the employees from the database and compare them with the input from the user
            {
                lblError.Visible = false;
                lblError.Show();
                //return from the database only the employee that matches those credentials
               Employee employee = employeeService.GetAccount(txtUsername.Text,txtPassword.Text);

                if (employee == null)
                {
                    //if the employee doesn't exist, give error message
                    lblError.Visible = true;
                    lblError.Text = "Username or Password incorrect!";
                }
                else
                {
                    //if the employee exists, login the user and open the main form
                    homeForm HomeForm = new homeForm(employee);
                    HomeForm.Show();
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
            //if enter is pressed, call the CheckCredentials() method
            if (e.KeyCode == Keys.Enter)
                CheckCredentials();
        }
        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            //if enter is pressed, call the CheckCredentials() method
            if (e.KeyCode == Keys.Enter)
                CheckCredentials();
        }
        private void eyePic_Click(object sender, EventArgs e)
        {
            //if the useSystemPasswordChar is true, set it to false and the other way around
            //that shows or hides the password
            txtPassword.UseSystemPasswordChar = !txtPassword.UseSystemPasswordChar;
        }
        private void loginFormV2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
