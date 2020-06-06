using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RosaModel;
using RosaLogic;
namespace LoginForm.CustomControls
{
    public partial class employeeUC : UserControl
    {
        private Employee employee;
        private Employee connectedEmployee;
        private ManagementForm managementForm;
        public employeeUC(Employee connectedEmployee,Employee employee,ManagementForm managementForm)
        {
            InitializeComponent();
            this.employee = employee;
            this.managementForm = managementForm;
            this.connectedEmployee = connectedEmployee;
        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void employeeUC_Load(object sender, EventArgs e)
        {
            Init();
        }
        private void Init()
        {
            lblName.Text = $"Name: {employee.firstName} {employee.lastName}";
            lblUsername.Text = $"Username: {employee.username}";
            lblRole.Text = $"Role: {employee.role.ToString()}";
            btnRemove.BackColor = Color.FromArgb(250,85,118);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            Employee_Service employeeService = new Employee_Service();
            DialogResult results = MessageBox.Show($"Are you sure you want to remove user {employee.username}?","Warning",MessageBoxButtons.YesNo,MessageBoxIcon.Question);

            if (results == DialogResult.Yes)
            {
                employeeService.RemoveAccount(employee);
                MessageBox.Show($"User {employee.username} removed!","Remove",MessageBoxButtons.OK);
                managementForm.LoadEmployees();
            }
                        

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditEmployeeForm editAccount = new EditEmployeeForm(connectedEmployee,employee);
            editAccount.Show();
            this.Hide();
        }
    }
}
