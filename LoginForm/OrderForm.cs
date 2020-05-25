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
    public partial class OrderForm : Form
    {
        private Employee employee;
        public OrderForm(Employee employee)
        {
            this.employee = employee;
            InitializeComponent();
            LoadOrders();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int orderId = int.Parse(OrderView.SelectedItems[0].Text);
                paymentForm payment = new paymentForm(orderId, employee);
                this.Hide();
                payment.Show();
            }
            catch(Exception)
            {
                lbl_orderWarning.Text = "This order does not have any items! Please put items before paying!";
            }


        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            OrderView.Items.Clear();


            LoadOrders();
            
        }

        private void LoadOrders()
        {
            RosaLogic.Order_Service orderService = new RosaLogic.Order_Service();
            List<Order> Orderlist = orderService.GetOrders();


            foreach (Order s in Orderlist)
            {

                ListViewItem li = new ListViewItem(s.orderID.ToString());
                li.SubItems.Add(s.table.ToString());
               // li.SubItems.Add(s.isPaid.ToString());

                OrderView.Items.Add(li);
            }
            OrderView.FullRowSelect = true;
            OrderView.GridLines = true;
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            homeForm homeForm = new homeForm(employee);
            homeForm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EditForm EditForm = new EditForm(employee);
            EditForm.Show();
            this.Hide();
        }
        public string ListviewSelectItem(int number)
        {
            string temp;
            temp = OrderView.SelectedItems[number].Text;
            return temp;
        }

        private void AddOrder_Click(object sender, EventArgs e)
        {
            RosaLogic.Order_Service orderserv = new RosaLogic.Order_Service();
            orderserv.AddOrder(int.Parse(TableIDbox.Text), int.Parse(EmployeeIDbox.Text));
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {

            RosaLogic.Order_Service orderserv = new RosaLogic.Order_Service();
            orderserv.RemoveOrder(int.Parse(OrderIDbox.Text));
        }

        private void EmployeeIDbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void TableIDbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void OrderIDbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
