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
    public partial class ManagementForm : Form
    {
        private Employee employee;
        public ManagementForm(Employee employee)
        {
            InitializeComponent();
            this.employee = employee;
        }

        private void ManagementForm_FormClosing(object sender, FormClosingEventArgs e)
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
            new SwitchForms(employee, this, new BarKitchenForm(employee,"bar"));
        }

        private void kitchenToolStripMenuItem_Click(object sender, EventArgs e)
        {

            new SwitchForms(employee, this, new BarKitchenForm(employee,"kitchen"));
        }

        private void lblLogout_Click(object sender, EventArgs e)
        {
            loginForm loginForm = new loginForm();
            loginForm.Show();
            this.Hide();
        }
    }
}
