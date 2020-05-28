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
    public partial class BarKitchenForm : Form //change class name
    {
        private Employee employee;

        public BarKitchenForm(Employee employee, string name)     //just need employee to decide if it's kitchen (chef) or bar (bartender) 
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
        private Color checkStatus(RosaModel.MenuItem b) // Presents the color based on the (Enum)status 
        {
            switch (b.Status)  //change varaible name b, eg. menuItem
            {
                case StatusEnum.Ordered:
                    if (b.dateSold.AddMinutes(15) < DateTime.Now)
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
            //Work with order items, not with menu items

            MenuItem_Service BarService = new MenuItem_Service();
            List<RosaModel.MenuItem> barLIst = BarService.GetMenuItem();
            if (name == "bar") //Displays the overview of the Bar View
            {
                panel_Bar.Show();
                panel_Kitchen.Hide();

                listBarView.Items.Clear();

                for (int i = 0; i < barLIst.Count; i++)
                {
                    ListViewItem stucust = new ListViewItem(barLIst[i].dateSold.Date.ToString());
                    stucust.SubItems.Add(barLIst[i].TableId.ToString());
                    stucust.SubItems.Add(barLIst[i].Price.ToString());
                    stucust.SubItems.Add(barLIst[i].Quantity.ToString());
                    stucust.SubItems.Add(barLIst[i].Name);
                    stucust.SubItems.Add(barLIst[i].Status.ToString());
                    stucust.SubItems.Add(barLIst[i].Note.ToString());
                    stucust.SubItems.Add(barLIst[i].orderID.ToString());
                    stucust.BackColor = checkStatus(barLIst[i]);

                    if (barLIst[i].menuCat >= 25) // it is more than 24 because all drinks has number above 24
                    {
                        listBarView.Items.Add(stucust);
                    }
                    listKitchenView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                }
            }
            else if (name == "kitchen") //Displays the overview of the Kitchen View
            {
                panel_Bar.Hide();
                panel_Kitchen.Show();

                listKitchenView.Items.Clear();

                for (int i = 0; i < barLIst.Count; i++)
                {
                    ListViewItem stucust = new ListViewItem(barLIst[i].dateSold.Date.ToString());
                    stucust.SubItems.Add(barLIst[i].TableId.ToString());
                    stucust.SubItems.Add(barLIst[i].Price.ToString());
                    stucust.SubItems.Add(barLIst[i].Quantity.ToString());
                    stucust.SubItems.Add(barLIst[i].Name);
                    stucust.SubItems.Add(barLIst[i].Status.ToString());
                    stucust.SubItems.Add(barLIst[i].Note.ToString());
                    stucust.SubItems.Add(barLIst[i].orderID.ToString());
                    stucust.BackColor = checkStatus(barLIst[i]);

                    if (barLIst[i].menuCat <= 24) // it is less than 25 because all dishes has number below 25
                    {

                        listKitchenView.Items.Add(stucust);
                    }
                    listKitchenView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                }
            }
        }
        private void Bottons() //what buttons?
        {
            // When you click on button you want to update the status of the certain order
            MenuItem_Service tableService = new MenuItem_Service();
            int status = 2; // to which one it goes from order status to ready status

            if (listBarView.SelectedItems.Count > 0)
            {
                // the numbers of order in ths MenuItem temp is based from the constructor method from class MenuItem.cs
                RosaModel.MenuItem temp = new RosaModel.MenuItem(
                   Convert.ToInt32(listBarView.SelectedItems[0].SubItems[1].Text), // Table from the KitchenBarView in this case it is the 2nd column from the add list
                   listBarView.SelectedItems[0].SubItems[4].Text, // Name from the KitchenBarView in this case it is the 5th column from the add list
                   Convert.ToInt32(listBarView.SelectedItems[0].SubItems[3].Text), // Quantity from the KitchenBarView in this case it is the 4rd column from the add list
                   Convert.ToDecimal(listBarView.SelectedItems[0].SubItems[2].Text), // Price from the KitchenBarView in this case it is the 3rd column from the add list
                   (StatusEnum)Enum.Parse(typeof(StatusEnum), listBarView.SelectedItems[0].SubItems[5].Text),// Status from the KitchenBarView in this case it is the 6th column from the add list
                   int.Parse(listBarView.SelectedItems[0].SubItems[7].Text), // OrderID from the KitchenBarView in this case it is the 8th column from the add list
                   DateTime.Parse(listBarView.SelectedItems[0].SubItems[0].Text), // Date and Time from the KitchenBarView in this case it is the 1st column from the add list
                   listBarView.SelectedItems[0].SubItems[6].Text); // Note from the KitchenBarView in this case it is the 7th column from the add list

                if (temp.Status == StatusEnum.Ordered)
                {
                    tableService.UpdateTableOrder(temp, status); // updates table 
                    MessageBox.Show("Order Send!");
                    KitcheOrBarView("bar");
                }
                else
                {
                    MessageBox.Show("Selected Item IS Not For Update!");
                }
            }
            else if (listKitchenView.SelectedItems.Count > 0)
            {
                // the numbers of order in ths MenuItem temp is based from the constructor method from class MenuItem.cs
                RosaModel.MenuItem temp = new RosaModel.MenuItem(
                  Convert.ToInt32(listKitchenView.SelectedItems[0].SubItems[1].Text), // Table from the KitchenBarView in this case it is the 2nd column from the add list
                  listKitchenView.SelectedItems[0].SubItems[4].Text, // Name from the KitchenBarView in this case it is the 5th column from the add list 
                  Convert.ToInt32(listKitchenView.SelectedItems[0].SubItems[3].Text), // Quantity from the KitchenBarView in this case it is the 4rd column from the add list 
                  Convert.ToDecimal(listKitchenView.SelectedItems[0].SubItems[2].Text), // Price from the KitchenBarView in this case it is the 3rd column from the add list 
                  (StatusEnum)Enum.Parse(typeof(StatusEnum), listKitchenView.SelectedItems[0].SubItems[5].Text), // Status from the KitchenBarView in this case it is the 6th column from the add list
                  int.Parse(listKitchenView.SelectedItems[0].SubItems[7].Text), // OrderID from the KitchenBarView in this case it is the 8th column from the add list
                  DateTime.Parse(listKitchenView.SelectedItems[0].SubItems[0].Text),  // Date and Time from the KitchenBarView in this case it is the 1st column from the add list
                  listKitchenView.SelectedItems[0].SubItems[6].Text); // Note from the KitchenBarView in this case it is the 7th column from the add list

                if (temp.Status == StatusEnum.Ordered)
                {
                    tableService.UpdateTableOrder(temp, status); // update table
                    MessageBox.Show("Order Send!");
                    KitcheOrBarView("kitchen");
                }
                else
                {
                    MessageBox.Show("Selected Item IS Not For Update!");
                }
            }
            else
            {
                MessageBox.Show("Item Was Not Selected!");
            }
        }

        private void btnReady_Click(object sender, EventArgs e)
        {
            Bottons();
        }
        private void btnReadyKitchen_Click(object sender, EventArgs e)
        {
            Bottons();
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

        private void MenuItemForm_Load(object sender, EventArgs e)
        {

        }
    }
}
