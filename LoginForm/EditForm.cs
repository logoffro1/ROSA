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
            DinnerPanel.Hide();
            LunchPanel.Hide();
            DrinksPanel.Hide();
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

        private void button1_Click(object sender, EventArgs e)
        {
            RosaLogic.Order_Service orderserv = new RosaLogic.Order_Service();
            bool parsetry = int.TryParse(CreateMenuitemIDBox.Text, out _);
            if (!parsetry)
            {
                 Messagelabel.Text = "Invalid entry in menuitem ID";
            }
            else if(int.Parse(CreateMenuitemIDBox.Text) > 63)
            {
                Messagelabel.Text = "Menuitem ID does not exist";
            }
            else
            {
            orderserv.CreateOrderItem(int.Parse(CreateOrderIDBox.Text), int.Parse(CreateMenuitemIDBox.Text));
                Messagelabel.Text = "Created Orderitem for Order "+ CreateOrderIDBox.Text + " with menuitem ID "+ CreateMenuitemIDBox.Text;
            }
            
        }

        private void DeleteOrderItemButton_Click(object sender, EventArgs e)
        {
            RosaLogic.Order_Service orderserv = new RosaLogic.Order_Service();
            bool parsetry = int.TryParse(DeleteOrderItemBox.Text, out _);
            if (!parsetry)
            {
                Messagelabel.Text = "Invalid entry in menuitem ID";
            }
            else
            {
                orderserv.DeleteOrderItem(int.Parse(DeleteOrderItemBox.Text));
                Messagelabel.Text = "Deleted Orderitem with ID" + DeleteOrderItemBox.Text;
            }
        }

        private void SelectOrderButton_Click(object sender, EventArgs e)
        {
            RosaLogic.Order_Service orderserv = new RosaLogic.Order_Service();
            List<OrderItem> orderitemlist = orderserv.GetByID(int.Parse(ViewByIDBox.Text));

            EditView.Items.Clear();
            foreach (OrderItem item in orderitemlist)
            {
                ListViewItem li = new ListViewItem(item.orderID.ToString());
                li.SubItems.Add(item.orderItems_id.ToString());
                //li.SubItems.Add(item.menuItem.Name.ToString());
                li.SubItems.Add(item.amount.ToString());
                li.SubItems.Add(item.status.ToString());
                EditView.Items.Add(li);
            }
        }

        private void IncreaseButton_Click(object sender, EventArgs e)
        {
            RosaLogic.Order_Service orderserv = new RosaLogic.Order_Service();
            orderserv.IncreaseAmount(int.Parse(DeleteOrderItemBox.Text));
        }

        private void DecreaseButton_Click(object sender, EventArgs e)
        {
            RosaLogic.Order_Service orderserv = new RosaLogic.Order_Service();
            orderserv.DecreaseAmount(int.Parse(DeleteOrderItemBox.Text));
        }

        private void DecreaseAmountButton_Click(object sender, EventArgs e)
        {
            int amount = 1;

            RosaLogic.Order_Service orderserv = new RosaLogic.Order_Service();
            orderserv.DecreaseStock(int.Parse(MenuItemIDBox.Text), amount);
        }

        private void LunchButton_Click(object sender, EventArgs e)
        {
            DrinksPanel.Hide();
            DinnerPanel.Hide();
            LunchPanel.Show();
            GetItems(19, LunchView);
        }

        private void DinnerButton_Click(object sender, EventArgs e)
        {
            LunchPanel.Hide();
            DrinksPanel.Hide();
            DinnerPanel.Show();
            GetItems(23, DinnerView);
        }

        private void DrinksButton_Click(object sender, EventArgs e)
        {
            DinnerPanel.Hide();
            LunchPanel.Hide();
            DrinksPanel.Show();
            GetItems(25, DrinksView);
        }
        private void GetItems(int menuID,ListView listView)
        {
            RosaLogic.Order_Service orderserv = new RosaLogic.Order_Service();
            List<RosaModel.MenuItem> menuItemsList = orderserv.GetMenuItems(menuID);
            listView.Items.Clear();
            foreach (RosaModel.MenuItem item in menuItemsList)
            {
                ListViewItem li = new ListViewItem(item.Name);
                li.SubItems.Add(item.Price.ToString());
                listView.Items.Add(li);
            }
        }
    }
}
