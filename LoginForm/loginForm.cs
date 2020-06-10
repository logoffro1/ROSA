using System;
using System.Windows.Forms;
using RosaLogic;
using RosaModel;
namespace LoginForm
{
    /// <summary>
    /// LOGIN FORM
    /// Made by Cosmin Ilie 
    /// Student number: 645976
    /// </summary>
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }
        private void CheckCredentials() //validate the credentials
        {
            Employee_Service employeeService = new Employee_Service();

            if (txtUsername.Text == string.Empty || txtPassword.Text == string.Empty)
            {
                //if the textboxes are empty, give error message
                lblError.Show();
                lblError.Text = "Username and Password required!";
            }
            else //if they are not empty, read the employees from the database and compare them with the input from the user
            {
                lblError.Hide();
                //return from the database only the employee that matches those credentials
                Employee employee = employeeService.GetAccount(txtUsername.Text, txtPassword.Text);

                if (employee == null)
                {
                    //if the employee doesn't exist, give error message
                    lblError.Show();
                    lblError.Text = "Username or Password incorrect!";
                }
                else
                {
                    //if the employee exists, login the user and open the correct form
                    switch (employee.role)
                    {
                        case Roles.Waiter:
                            new SwitchForms(employee, this, new tableViewForm(employee));
                            break;
                        case Roles.Bartender:
                            new SwitchForms(employee, this, new BarKitchenForm(employee,"bar"));
                            break;
                        case Roles.Chef:
                            new SwitchForms(employee, this, new BarKitchenForm(employee, "kitchen"));
                            break;
                        case Roles.Manager:
                            new SwitchForms(employee, this, new ManagementForm(employee));
                            break;
                        default:
                            new SwitchForms(employee, this, new homeForm(employee));
                            break;
                    }
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
            if (e.KeyCode.Equals(Keys.Enter))
                CheckCredentials();
        }
        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            //if enter is pressed, call the CheckCredentials() method
            if (e.KeyCode.Equals(Keys.Enter))
                CheckCredentials();
        }
        private void eyePic_Click(object sender, EventArgs e)
        {
            //if the useSystemPasswordChar is true, set it to false and the other way around
            //that shows or hides the password
            txtPassword.UseSystemPasswordChar = !txtPassword.UseSystemPasswordChar;

            if (txtPassword.UseSystemPasswordChar) //change the eye picture
                eyePic.BackgroundImage = Properties.Resources.Black_Eye_Watch_128;
            else
                eyePic.BackgroundImage = Properties.Resources.Closed_Eye2;
        }
        private void loginFormV2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
