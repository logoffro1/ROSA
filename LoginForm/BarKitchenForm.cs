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
        ListViewItem stucust;

        public BarKitchenForm(Employee employee, string name)     
        {
            this.employee = employee;
            InitializeComponent();
            KitcheOrBarView(name);
        }
        private void BarView_Click(object sender, EventArgs e)
        {
            KitcheOrBarView("bar");
            return;
        }
        private void RefreshDatabase(object sender, EventArgs e)
        {
            KitcheOrBarView("kitchen");
        }
        private Color checkStatus(RosaModel.MenuItem menuItem) // Presents the color based on the (Enum)status 
        {
            switch (menuItem.orderItem.status)
            {
                case StatusEnum.Ordered:
                    if (menuItem.order.DateTime.AddMinutes(15) < DateTime.Now)
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
        private void KitcheOrBarView(string name) //Displays the overview of both the Bar and Kitchen View
        {
            MenuItem_Service BarService = new MenuItem_Service();
            OrderItem orderitems = new OrderItem();
            List<RosaModel.MenuItem> barLIst = BarService.GetOrderItem();
            List<ListViewItem> stucustList = new List<ListViewItem>();
            for (int i = 0; i < barLIst.Count; i++)
            {
                stucust = new ListViewItem(barLIst[i].order.DateTime.ToString("HH:mm:ss"));
                stucust.SubItems.Add(barLIst[i].order.Table.tableId.ToString());
                stucust.SubItems.Add(barLIst[i].orderItem.amount.ToString());
                stucust.SubItems.Add(barLIst[i].Name);
                stucust.SubItems.Add(barLIst[i].orderItem.status.ToString());
                stucust.SubItems.Add(barLIst[i].order.Notes.ToString());
                stucust.SubItems.Add(barLIst[i].orderItem.orderID.ToString());
                stucust.BackColor = checkStatus(barLIst[i]);
                stucustList.Add(stucust);

            }
            if (name == "bar") //Displays the overview of the Bar View for the Bartender and Manager
            {
                panel_Bar.Show();
                panel_Kitchen.Hide();

                listBarView.Items.Clear();
                listBarView1.Items.Clear();

                for (int i = 0; i < stucustList.Count; i++)
                {
                    if (barLIst[i].menuCat >= 25) // it is more than 24 because all drinks has number above 24
                    {
                        if (barLIst[i].orderItem.status == (StatusEnum)Enum.Parse(typeof(StatusEnum), StatusEnum.Ordered.ToString()))
                        {
                            listBarView.Items.Add(stucustList[i]); //  ordered
                        }
                        else
                        {
                            listBarView1.Items.Add(stucustList[i]); // served and ready
                        }
                    }
                    listBarView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                    listBarView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                }
            }
            else if (name == "kitchen" ) //Displays the overview of the Kitchen View for the Chef and Manager
            {
                panel_Bar.Hide();
                panel_Kitchen.Show();

                listKitchenView.Items.Clear();
                listKitchenView1.Items.Clear();
                for (int i = 0; i < stucustList.Count; i++)
                {

                    if (barLIst[i].menuCat <= 24) // it is laess than 25 because all dishes has number below 25
                    {

                        if (barLIst[i].orderItem.status == (StatusEnum)Enum.Parse(typeof(StatusEnum), StatusEnum.Ordered.ToString()))
                        {
                            listKitchenView.Items.Add(stucustList[i]); //  ordered
                        }
                        else
                        {
                            listKitchenView1.Items.Add(stucustList[i]); // served and ready
                        }
                    }

                    listKitchenView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                    listKitchenView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                }
            }
        }
        private void UpdateButtons() // When you click on button you want to update the status of the certain order
        {
            MenuItem_Service tableService = new MenuItem_Service();
            int status = 2; // to which one it goes from order status to ready status

            if (listBarView.SelectedItems.Count > 0)
            {
                OrderItem temp = new OrderItem(
                 int.Parse(listBarView.SelectedItems[0].SubItems[6].Text),  // orderId
                 (StatusEnum)Enum.Parse(typeof(StatusEnum), listBarView.SelectedItems[0].SubItems[4].Text)); // Status

                if (temp.status == StatusEnum.Ordered)
                {
                    tableService.UpdateTableOrder(temp.orderID, status); // updates table                     
                    MessageBox.Show("Order Send!");
                    KitcheOrBarView("bar");
                }
            }
            else if (listKitchenView.SelectedItems.Count > 0)
            {
                OrderItem temp = new OrderItem(
                int.Parse(listKitchenView.SelectedItems[0].SubItems[6].Text),  // orderId
                (StatusEnum)Enum.Parse(typeof(StatusEnum),listKitchenView.SelectedItems[0].SubItems[4].Text)); // Status

                if (temp.status == StatusEnum.Ordered)
                {
                    tableService.UpdateTableOrder(temp.orderID, status); // update table
                    MessageBox.Show("Order Send!");
                    KitcheOrBarView("kitchen");
                }
            }
            else
            {
                MessageBox.Show("Item Was Not Selected!");
            }
        }

        private void btnReady_Click(object sender, EventArgs e)
        {
            UpdateButtons();
        }
        private void btnReadyKitchen_Click(object sender, EventArgs e)
        {
            UpdateButtons();
        }
        private void kitchenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KitcheOrBarView("kitchen");
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            homeForm homeForm = new homeForm(employee);
            this.Hide();
            homeForm.Show();
        }
        private void tablesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tableViewForm tableViewForm = new tableViewForm(employee);
            tableViewForm.Show();
            this.Hide();
        }
        private void MenuItemForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void BarKitchenForm_Load(object sender, EventArgs e)
        {

        }
    }
}
