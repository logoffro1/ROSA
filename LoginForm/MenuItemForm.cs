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
    public partial class MenuItemForm : Form
    {
        private Employee employee;
        public MenuItemForm()
        {
            InitializeComponent();
        }
        public MenuItemForm(Employee employee)
        {
            this.employee = employee;
            InitializeComponent();
        }

        private void BarView_Click(object sender, EventArgs e)
        {
            MenuItem_Service BarService = new MenuItem_Service();
            List<RosaModel.MenuItem> barLIst = BarService.GetMenuItem();


            if (sender == BarView)
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

                    if (barLIst[i].menuCat >= 25)
                    {

                        listBarView.Items.Add(stucust);
                    }
                    listBarView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize); // added this

                }
            }
            else if (sender == kitchenToolStripMenuItem)
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

                    if (barLIst[i].menuCat <= 24)
                    {

                        listKitchenView.Items.Add(stucust);
                    }
                    listKitchenView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize); //added this

                }
            }
        }
        private Color checkStatus(RosaModel.MenuItem b)
        {
            switch (b.Status)
            {
                case StatusEnum.Ordered:
                    return Color.Yellow;
                case StatusEnum.Ready:
                    return Color.Green;
                case StatusEnum.Waiting:
                    if (b.dateSold.AddMinutes(15) < DateTime.Now)
                    { return Color.Red; }
                    else
                    {
                        return Color.Blue;
                    }
            }
            return Color.White;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MenuItem_Service tableService = new MenuItem_Service();
            int status = 3;


            if (listBarView.SelectedItems.Count > 0)
            {
                //change
                RosaModel.MenuItem temp = new RosaModel.MenuItem(
                   Convert.ToInt32(listBarView.SelectedItems[0].SubItems[1].Text),
                   listBarView.SelectedItems[0].SubItems[4].Text,
                   Convert.ToInt32(listBarView.SelectedItems[0].SubItems[3].Text),
                   Convert.ToDecimal(listBarView.SelectedItems[0].SubItems[2].Text),
                   (StatusEnum)Enum.Parse(typeof(StatusEnum), listBarView.SelectedItems[0].SubItems[5].Text),
                   int.Parse(listBarView.SelectedItems[0].SubItems[7].Text),
                   DateTime.Parse(listBarView.SelectedItems[0].SubItems[0].Text),
                   listBarView.SelectedItems[0].SubItems[6].Text);

                if (temp.Status == StatusEnum.Ready || temp.Status == StatusEnum.Waiting || temp.Status == StatusEnum.Ordered)
                {
                    tableService.UpdateTableOrder(temp, status); // update table
                    MessageBox.Show("Order Send!");
                    BarView_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Selected Item IS Not For Update!");
                }
            }
            else if (listKitchenView.SelectedItems.Count > 0)
            {
                RosaModel.MenuItem temp = new RosaModel.MenuItem(
                  Convert.ToInt32(listKitchenView.SelectedItems[0].SubItems[1].Text),
                  listKitchenView.SelectedItems[0].SubItems[4].Text,
                  Convert.ToInt32(listKitchenView.SelectedItems[0].SubItems[3].Text),
                  Convert.ToDecimal(listKitchenView.SelectedItems[0].SubItems[2].Text),
                  (StatusEnum)Enum.Parse(typeof(StatusEnum), listKitchenView.SelectedItems[0].SubItems[5].Text),
                  int.Parse(listKitchenView.SelectedItems[0].SubItems[7].Text),
                  DateTime.Parse(listKitchenView.SelectedItems[0].SubItems[0].Text),
                  listKitchenView.SelectedItems[0].SubItems[6].Text);

                if (temp.Status == StatusEnum.Ready || temp.Status == StatusEnum.Waiting || temp.Status == StatusEnum.Ordered)
                {
                    tableService.UpdateTableOrder(temp, status); // update table
                    MessageBox.Show("Order Send!");
                    BarView_Click(sender, e);
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

        private void button6_Click(object sender, EventArgs e)
        {
            button3_Click(sender,e);
        }

        private void kitchenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BarView_Click(sender,e);
        }

        private void MenuItemForm_Load(object sender, EventArgs e)
        {

        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            homeForm homeForm = new homeForm(employee);
            this.Hide();
            homeForm.Show();

        }

        private void tablesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditForm tableViewForm = new EditForm(employee);          
            tableViewForm.Show();
            this.Hide();
        }

        private void MenuItemForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void orderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrderForm ot = new OrderForm(employee);
            ot.Show();
            this.Hide();
        }

        private void listBarView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
