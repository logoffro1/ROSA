using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RosaModel;
namespace LoginForm
{
    public partial class OrderTemp : Form
    {
        private Employee employee;
        public OrderTemp(Employee employee)
        {
            this.employee = employee;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            paymentForm payment = new paymentForm(employee);
            this.Hide();
            payment.Show();

        }
    }
}
