using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RosaLogic;
using RosaModel;

namespace LoginForm
{
    public partial class BarKitchenForm : Form
    {
        private Employee employee;
        ListViewItem AddItem;

        public BarKitchenForm(Employee employee)
        {
            this.employee = employee;
            InitializeComponent();

        }
        // the user clicks on Bar
        private void BarView_Click(object sender, EventArgs e)
        {
            if (employee.role == Roles.Bartender || employee.role == Roles.Manager)
            {
                panel_Bar.Show();

                //UI stuff
                BarView.BackColor = Color.FromArgb(122, 122, 122);
                BarView.ForeColor = Color.FromArgb(254, 247, 233);

                kitchenToolStripMenuItem.BackColor = Color.White;
                kitchenToolStripMenuItem.ForeColor = Color.Black;


                panel_Kitchen.Hide();
                KitcheOrBarView();
            }
            else
            {
                MessageBox.Show($"Acces Denied!{Environment.NewLine}Your role does not have permission!", "Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        // Presents the color based on the (Enum)status 
        private Color checkStatus(OrderItem Status) // Presents the color based on the (Enum)status 
        {
            switch (Status.status)
            {
                case StatusEnum.Ordered:
                    if (Status.order.DateTime.AddMinutes(15) < DateTime.Now)
                    { return Color.Red; }
                    else
                    {
                        return Color.Yellow;
                    }
                case StatusEnum.Ready:
                    return Color.Green;
                case StatusEnum.Served:
                    return Color.Green;
                default:
                    return Color.White;
            }
        }
        //Displays the overview of both the Bar and Kitchen View
        private void KitcheOrBarView() 
        {   // Clear ListViews 
            listBarOrderView.Items.Clear();
            listBarReadyView.Items.Clear();
            listKitchenOrderView.Items.Clear();
            listKitchenReadyView.Items.Clear();

            OrderItem_Service OrderedItemService = new OrderItem_Service();
            List<ListViewItem> AddItems = new List<ListViewItem>();
            // Where Query to get the OrderItems for Kitchen and Bar
            List<RosaModel.OrderItem> KitchenBarList = OrderedItemService.GetKItchenOrderedItems(); 

            foreach (OrderItem orderItem in KitchenBarList)
            {
                AddItem = new ListViewItem(orderItem.order.DateTime.ToString("HH:mm:ss"));
                AddItem.SubItems.Add(orderItem.order.Table.tableId.ToString());               
                AddItem.SubItems.Add(orderItem.menuItem.Name);
                AddItem.SubItems.Add(orderItem.amount.ToString());
                AddItem.SubItems.Add(orderItem.order.Notes);
                AddItem.SubItems.Add(orderItem.status.ToString());
                AddItem.SubItems.Add(orderItem.orderItems_id.ToString());
                AddItem.BackColor = checkStatus(orderItem);
                AddItem.Tag = orderItem;
                AddItems.Add(AddItem);
                AddItem.BackColor = checkStatus(orderItem);
                if (orderItem.menuItem.menuCat >= 25)
                {
                    if (orderItem.status == StatusEnum.Ready) 
                    {
                        listBarReadyView.Items.Add(AddItem);
                    }
                    else
                    {
                        listBarOrderView.Items.Add(AddItem);
                    }
                }
                else
                {
                    if (orderItem.status == StatusEnum.Ready)
                    {
                        listKitchenReadyView.Items.Add(AddItem);
                    }
                    else
                    {
                        listKitchenOrderView.Items.Add(AddItem);
                    }
                }
                listBarOrderView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                listBarReadyView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                listKitchenOrderView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                listKitchenReadyView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            }
        }
        // When you click on button you want to update the status of the certain item
        private void MarkAsReadyButton() 
        {
            OrderItem orderItem = new OrderItem();
            OrderItem_Service KitchenOrBarService = new OrderItem_Service();
            if (listBarOrderView.SelectedItems.Count > 0)
            {                
                orderItem.orderItems_id = int.Parse(((RosaModel.OrderItem)listBarOrderView.SelectedItems[0].Tag).orderItems_id.ToString());
            }
            else if (listKitchenOrderView.SelectedItems.Count > 0)
            {
                orderItem.orderItems_id = int.Parse(((RosaModel.OrderItem)listKitchenOrderView.SelectedItems[0].Tag).orderItems_id.ToString());
            }
            KitchenOrBarService.UpdateTableOrder(orderItem.orderItems_id, 2);
            KitcheOrBarView();
            MessageBox.Show("Order Send!");
        }        
        private void btnReadyBar_Click(object sender, EventArgs e)
        {
            MarkAsReadyButton();
        }
        private void btnReadyKitchen_Click(object sender, EventArgs e)
        {
            MarkAsReadyButton();
        }
        // the user click on Kitchen
        private void KitchenView_Click(object sender, EventArgs e) 
        {
            if (employee.role == Roles.Chef || employee.role == Roles.Manager)
            {
                panel_Bar.Hide();
                panel_Kitchen.Show();

                //UI stuff
                kitchenToolStripMenuItem.BackColor = Color.FromArgb(122, 122, 122);
                kitchenToolStripMenuItem.ForeColor = Color.FromArgb(254, 247, 233);

                BarView.BackColor = Color.White;
                BarView.ForeColor = Color.Black;

                KitcheOrBarView();
            }
            else
            {
                MessageBox.Show($"Acces Denied!{Environment.NewLine}Your role does not have permission!", "Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            homeForm homeForm = new homeForm(employee);
            this.Hide();
            homeForm.Show();
        }
        private void tablesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new SwitchForms(employee, this, new tableViewForm(employee));
        }
        private void MenuItemForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void managementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new SwitchForms(employee, this, new ManagementForm(employee));
        }
        private void label4_Click(object sender, EventArgs e)
        {
            new SwitchForms(employee, this, new loginForm());
        }
    }
}
