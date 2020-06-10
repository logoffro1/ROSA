using RosaLogic;
using System;
using RosaModel;
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
    public partial class Revenue : Form
    {
        public string orderItems;     // name of the item
        public string menuItems;
        public int sales;       // amount of times the item was sold
        public float cost;     // the price of the item
        public int boughtByCustomer; // the amount of unique customers it was bought by
        public float Turnover;
        private Employee employee;

        public Revenue(Employee employee)
        {
            InitializeComponent();
            monthcalendarrevenue.SelectionRange = new SelectionRange(DateTime.Today, DateTime.Today);
            lbldateerror.Visible = false;
            this.employee = employee;

        }

        private void monthcalendarrevenue_DateChanged(object sender, DateRangeEventArgs e)
        {
            try
            {
                Revenue_Service service = new Revenue_Service();
                int totalSales = 0;
                float totalTurnOver = 0;
                //get the revenue from the database for the start and end date
                List<RosaModel.RevenueItem> revenues = service.GetRevenue(monthcalendarrevenue.SelectionStart, monthcalendarrevenue.SelectionEnd);
                //clear the current items
                listviewrevenue.Items.Clear();
                //format each item in the list to an array of strings and add those to the listView
                foreach (RosaModel.RevenueItem  item in revenues)
                {
                    string[] items = new string[] {
                        item.orderItems,
                        item.menuItems,
                        item.sales.ToString(),
                        item.Turnover.ToString("0.00 €"), // format the turnover to a currency format
                        
                    };
                    //add the sales and turnover to a total
                    totalSales += item.sales;
                    totalTurnOver += item.Turnover;
                    ListViewItem li = new ListViewItem(items);
                    listviewrevenue.Items.Add(li);
                }
                
                //create and add a listViewItem for the total
                ListViewItem total = new ListViewItem(new string[] { "Total", totalSales.ToString(), totalTurnOver.ToString("0.00 €"), " " });
                listviewrevenue.Items.Add(total);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void datetimestartdate_ValueChanged(object sender, EventArgs e)
        {
            // prevent selection of the future
            if (datetimestartdate.Value > DateTime.Today)
            {
                datetimestartdate.Value = DateTime.Today;
            }
            // if the start date is after the end date then clear the listView and show the error
            if (datetimestartdate.Value > datetimeenddate.Value)
            {
                lbldateerror.Visible = true;
                listviewrevenue.Items.Clear();
            }
            else
            {
                lbldateerror.Visible = false;
                //change the start of the selection in the calender
                monthcalendarrevenue.SelectionStart = datetimestartdate.Value;
            }
        }

        private void datetimeenddate_ValueChanged(object sender, EventArgs e)
        {
            // prevent selection of the future
            if (datetimeenddate.Value > DateTime.Today)
            {
                datetimeenddate.Value = DateTime.Today;
            }
            // if the start date is after the end date then clear the listView and show the error
            if (datetimestartdate.Value > datetimeenddate.Value)
            {
                lbldateerror.Visible = true;
                listviewrevenue.Items.Clear();
            }
            else
            {
                lbldateerror.Visible = false;
                //change the end of the selection in the calender
                monthcalendarrevenue.SelectionEnd = datetimeenddate.Value;
            }

        }
        private void listViewRevenue_DrawSubItem(object sender, DrawListViewSubItemEventArgs e)
        {
            // make sure subitems are drawn line normal because ownerdraw is enabled
            e.DrawDefault = true;
        }

        private void listViewRevenue_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            // make sure headers are drawn line normal because ownerdraw is enabled
            e.DrawDefault = true;
        }

        private void listViewRevenue_DrawItem(object sender, DrawListViewItemEventArgs e)
        {
            // add a line above the last item, which is the total
            if (e.Item.Index == listviewrevenue.Items.Count - 1)
            {
                e.Graphics.DrawLine(Pens.Black, e.Bounds.Left, e.Bounds.Top - 1, e.Bounds.Right, e.Bounds.Top - 1);
            }
        }

        private void butcalrevenue_Click(object sender, EventArgs e)
        {
            
        }

        private void Revenue_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ManagementForm managementForm = new ManagementForm(employee);
            managementForm.Show();
            this.Hide();
        }
    }
}