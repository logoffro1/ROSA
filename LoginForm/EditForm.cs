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

        private void Backbuttonedit_Click(object sender, EventArgs e)  // this should go back to the tables page
        {
            OrderForm orderForm = new OrderForm(employee);
            orderForm.Show();
            this.Close();
        }
        private void DeleteOrderItemButton_Click(object sender, EventArgs e)
        {
            RosaLogic.Order_Service orderserv = new RosaLogic.Order_Service();  //deletes selected order item
            orderserv.DeleteOrderItem(int.Parse(EditView.SelectedItems[0].SubItems[1].Text));
            Messagelabel.Text = "Deleted Order item with ID " + EditView.SelectedItems[0].SubItems[1].Text;
            FillOrderViewByOrderID(int.Parse(ViewByIDBox.Text));
        }

        private void SelectOrderButton_Click(object sender, EventArgs e)
        {
            FillOrderViewByOrderID(int.Parse(ViewByIDBox.Text));
        }
        private void FillOrderViewByOrderID(int orderID)
        {
            RosaLogic.Order_Service orderserv = new RosaLogic.Order_Service();
            List<OrderItem> orderitemlist = orderserv.GetByID(orderID);

            EditView.Items.Clear();
            foreach (OrderItem item in orderitemlist)
            {
                ListViewItem li = new ListViewItem(item.orderID.ToString());
                li.SubItems.Add(item.orderItems_id.ToString());
                li.SubItems.Add(item.menuItemID.ToString());
                li.SubItems.Add(item.amount.ToString());
                li.SubItems.Add(item.status.ToString());
                li.SubItems.Add(item.menuItemName);
                EditView.Items.Add(li);
            }
        }

        private void IncreaseButton_Click(object sender, EventArgs e)
        {
            RosaLogic.Order_Service orderserv = new RosaLogic.Order_Service();  // increases selected order item amount 
            orderserv.IncreaseAmount(int.Parse(EditView.SelectedItems[0].SubItems[1].Text));
            FillOrderViewByOrderID(int.Parse(ViewByIDBox.Text));
        }

        private void DecreaseButton_Click(object sender, EventArgs e)
        {
            RosaLogic.Order_Service orderserv = new RosaLogic.Order_Service();  // decreases selected order item amount
            orderserv.DecreaseAmount(int.Parse(EditView.SelectedItems[0].SubItems[1].Text));
            FillOrderViewByOrderID(int.Parse(ViewByIDBox.Text));
        }

        private void DecreaseAmountButton_Click(object sender, EventArgs e)  // this decreases the stock by the set amount | currently on a button but will be used each time an order item is added to an order
        {
            int amount = 1;
            RosaLogic.Order_Service orderserv = new RosaLogic.Order_Service();
            orderserv.DecreaseStock(int.Parse(MenuItemIDBox.Text), amount);
        }

       
        private void GetItems(int menuID,ListView listView)  // gets items for each part of the menu
        {
            RosaLogic.Order_Service orderserv = new RosaLogic.Order_Service();
            List<RosaModel.MenuItem> menuItemsList = orderserv.GetMenuItems(menuID);
            listView.Items.Clear();
            foreach (RosaModel.MenuItem item in menuItemsList)
            {
                ListViewItem li = new ListViewItem(item.Name);
                li.SubItems.Add(item.Price.ToString());
                li.SubItems.Add(item.ID.ToString());
                listView.Items.Add(li);
            }
        }

        

        private void CreateOrderButton_Click(object sender, EventArgs e)
        {
            {
                RosaLogic.Order_Service orderserv = new RosaLogic.Order_Service();
                orderserv.AddOrder(int.Parse(TableIDBox2.Text));
            }
        }

        private void AddOrderItemFromListButton_Click(object sender, EventArgs e) //adding order item from the menu
        {
            if ((!IncreaseAmountOfExistingItem(LunchView)) & (!IncreaseAmountOfExistingItem(DinnerView)) & (!IncreaseAmountOfExistingItem(DrinksView)))
            {
                if ((!CreateByID(LunchView)) & (!CreateByID(DinnerView)) & (!CreateByID(DrinksView)))
                {
                    Messagelabel.Text = "No item selected from menu";
                }
            }
            FillOrderViewByOrderID(int.Parse(ViewByIDBox.Text));
            ClearLists();
        }
        private bool CreateByID(ListView list)
        {
            RosaLogic.Order_Service orderserv = new RosaLogic.Order_Service();  // should get order ID from table screen instead of textbox
            if (list.SelectedItems.Count != 0)
            {
                orderserv.CreateOrderItem(int.Parse(ViewByIDBox.Text), int.Parse(list.SelectedItems[0].SubItems[2].Text));
                Messagelabel.Text = "Added " + list.SelectedItems[0].SubItems[0].Text + " to Order " + ViewByIDBox.Text;
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool CheckListForItem(int menuItemID)
        {
            for (int x = 0; x < EditView.Items.Count; x++)
            {
                if (menuItemID.ToString() == EditView.Items[x].SubItems[2].Text)
                {
                    Messagelabel.Text ="Item with menuItem number " + EditView.Items[x].SubItems[2].Text + " already exists. The amount has been increased.";
                    return true;
                }
                
            }
            return false;
        }
        private void ClearLists()   // clears the selections of the menu lists
        {
            LunchView.SelectedItems.Clear();
            DinnerView.SelectedItems.Clear();
            DrinksView.SelectedItems.Clear();
        }
        
        private bool IncreaseAmountOfExistingItem(ListView list)
        {
            RosaLogic.Order_Service orderserv = new RosaLogic.Order_Service();
            if (list.SelectedItems.Count > 0)
            {
                if (CheckListForItem(int.Parse(list.SelectedItems[0].SubItems[2].Text)))
                {
                    orderserv.IncreaseAmount2(int.Parse(list.SelectedItems[0].SubItems[2].Text));
                    return true;
                }
            }
            return false;
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            ClearLists();
            GetItems(22, DinnerView);
        }

        private void MainsButton_Click(object sender, EventArgs e)
        {
            ClearLists();
            GetItems(23, DinnerView);
        }

        private void Desserts_Click(object sender, EventArgs e)
        {
            ClearLists();
            GetItems(24, DinnerView);
        }

        private void SoftDrinksButton_Click(object sender, EventArgs e)
        {
            ClearLists();
            GetItems(25, DrinksView);
        }

        private void BeersButton_Click(object sender, EventArgs e)
        {
            ClearLists();
            GetItems(27, DrinksView);
        }

        private void HotDrinksButton_Click(object sender, EventArgs e)
        {
            ClearLists();
            GetItems(26, DrinksView);
        }

        private void WinesButton_Click(object sender, EventArgs e)
        {
            ClearLists();
            GetItems(28, DrinksView);
        }

        private void LunchMainButton_Click(object sender, EventArgs e)
        {
            ClearLists();
            GetItems(19, LunchView);
        }

        private void SpecialsButton_Click(object sender, EventArgs e)
        {
            ClearLists();
            GetItems(20, LunchView);
        }

        private void LunchBitesButton_Click(object sender, EventArgs e)
        {
            ClearLists();
            GetItems(21, LunchView);
        }
        private void LunchButton_Click(object sender, EventArgs e)
        {
            DrinksPanel.Hide();
            DinnerPanel.Hide();
            LunchPanel.Show();
        }

        private void DinnerButton_Click(object sender, EventArgs e)
        {
            LunchPanel.Hide();
            DrinksPanel.Hide();
            DinnerPanel.Show();

        }

        private void DrinksButton_Click(object sender, EventArgs e)
        {
            DinnerPanel.Hide();
            LunchPanel.Hide();
            DrinksPanel.Show();
        }

        
    }
}
