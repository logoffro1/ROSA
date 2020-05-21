using RosaLogic;
using RosaModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class EditForm : Form
    {
        private Employee employee;
        public EditForm(Employee employee)
        {
            this.employee = employee;
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Backbuttonedit_Click(object sender, EventArgs e)
        {
            OrderForm orderForm = new OrderForm(employee);
            orderForm.Show();
            this.Close();
        }
        
    }
}
