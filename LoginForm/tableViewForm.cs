using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RosaLogic;
using RosaModel;
namespace LoginForm
{
    /// <summary>
    /// TABLE VIEW FORM
    /// Made by Cosmin Ilie 
    /// Student number: 645976
    /// </summary>
    public partial class tableViewForm : Form
    {
        private Employee employee;

        private List<PictureBox> tableImages;   //create a list for all the table images
        private List<Table> tables = new List<Table>();
        private Table selectedTable; //the current selected table by the user
        private Timer timerWaitTime = new Timer();
        private int waitTimeMinutes; //for the order
        public tableViewForm(Employee employee)
        {
            InitializeComponent();
            this.employee = employee;
            if (employee.role == Roles.Waiter)
                return;

        }
        private void tableViewForm_Load(object sender, EventArgs e)
        {

            //show a Welcome message, "Welcome, firstName!"
            lblWelcome.Text = $"Welcome, {employee.firstName}!";

            Table_Service tableService = new Table_Service();
            tables = tableService.GetAllTables(); //return all the tables from the database

            //add all the table images in a list 
            tableImages = new List<PictureBox>() { picTable1, picTable2, picTable3, picTable4, picTable5, picTable6, picTable7, picTable8, picTable9, picTable10 };

            ChangeTableColor();
        }
        private void tableViewForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void ShowTableIcons(Table table)
        {


            int sizeX = tableImages[table.tableId - 1].Height / 4;
            int sizeY = sizeX;
            if (table.isReserved)
            {
                PictureBox reservedIcon = new PictureBox()
                {

                    Size = new Size(sizeX, sizeY),
                    Location = new Point(tableImages[table.tableId - 1].Location.X - sizeX+2, tableImages[table.tableId - 1].Location.Y),
                    BackgroundImage = Properties.Resources.Addressbook_32,
                    BackColor = Color.Transparent,
                    BackgroundImageLayout = ImageLayout.Stretch
                };

                pnlTables.Controls.Add(reservedIcon);
            }
                if (table.order != null)
            {
                //loop through the order items, see if it has food and drinks that are not ready
                ChangeLabelWaitTime(table);
                if (waitTimeMinutes >= 15)
                {
                    PictureBox clockIcon = new PictureBox()
                    {

                        Size = new Size(sizeX, sizeY),
                        Location = new Point(tableImages[table.tableId - 1].Location.X - sizeX+2, tableImages[table.tableId - 1].Location.Y + tableImages[table.tableId-1].Height-sizeX),
                        BackgroundImage = Properties.Resources.Alert_Clock_32,
                        BackColor = Color.Transparent,
                        BackgroundImageLayout = ImageLayout.Stretch
                    };
                    pnlTables.Controls.Add(clockIcon);
                }
                if(table.order.listOrderItems != null)
                {
                    foreach(OrderItem OI in table.order.listOrderItems)
                    {
                        
                    }
                }
            }
        }
        void ChangeTableColor() //change the back color depending on the availability for all the tables
        {
            int count = 0; //to keep track of the table number

            foreach (PictureBox p in tableImages) // loop through the table images list
            {
                //if the table is occupied, set the color to green
                if (tables[count].isAvailable)
                    p.BackColor = Color.FromArgb(102, 210, 105); //green-ish color
                else //if it is not occupied, set it to red
                    p.BackColor = Color.FromArgb(255, 128, 128); //red-ish color

                ShowTableIcons(tables[count]);
                count++;
            }
        }
        void ChangeTableImageColor(PictureBox tableImage) //change the back color depending on the availability for one table
        {
            if (!selectedTable.isAvailable)
                tableImage.BackColor = Color.FromArgb(255, 128, 128); //red-ish color
            else
                tableImage.BackColor = Color.FromArgb(102, 210, 105); //green-ish color

        }
        void ShowTableInfo(int tableId) //show the information for the selected table
        {
            timerWaitTime.Stop();

            selectedTable = tables[tableId - 1]; //set the current selected table

            //set the placeholder image to the corresponding table image from the list
            picPlaceHolder.Image = tableImages[tableId - 1].Image;
            //set the labels to the right values from the database
            lblCapacity.Text = "Capacity: " + selectedTable.capacity.ToString();
            if (selectedTable.isReserved)
                btnReservedYes.Checked = true;
            else
                btnReservedNo.Checked = true;

            //if the table is occupied, show that on the screen
            if (!selectedTable.isAvailable)
                btnOccupiedYes.Checked = true;
            else //if the table is not ocuppied
                btnOccupiedNo.Checked = true;

            lblStatus.Text = "Status: " + selectedTable.CheckStatus().ToString();

            ChangeLabelWaitTime(selectedTable);

            if (selectedTable.CheckStatus() == TableStatus.Ordered)
            {
                timerWaitTime.Tick += TimerWaitTime_Tick;
                timerWaitTime.Interval = 1000;
                timerWaitTime.Start();
            }

            pnlTableInfo.Show();  //show the table info panel
        }

        private void TimerWaitTime_Tick(object sender, EventArgs e)
        {
            ChangeLabelWaitTime(selectedTable);
        }
        private void ChangeLabelWaitTime(Table table)
        {
            if (table.CheckStatus() == TableStatus.Ordered)
            {
                int waitTimetotalSeconds = (int)(DateTime.Now - table.order.dateTime).TotalSeconds;

                if (waitTimetotalSeconds > 0)
                {
                    waitTimeMinutes = waitTimetotalSeconds / 60;
                    int waitTimeSeconds = waitTimetotalSeconds % 60;
                    if (waitTimeMinutes < 5)
                        lblWaitTime.BackColor = Color.LightGreen;
                    else if (waitTimeMinutes < 15)
                        lblWaitTime.BackColor = Color.Yellow;
                    else
                        lblWaitTime.BackColor = Color.PaleVioletRed;

                    lblWaitTime.Text = $"{waitTimeMinutes.ToString("00")}:{waitTimeSeconds.ToString("00")}";
                }
            }
            else
            {
                lblWaitTime.BackColor = SystemColors.Control;
                lblWaitTime.Text = "00:00";
            }
        }
        private void TableClick(object sender, EventArgs e) //event handler
        {
            PictureBox tablePic = (PictureBox)sender; //store the clicked table
            int tableId = int.Parse(tablePic.Name.Remove(0, 8));
            // string[] tableSplit = tablePic.Name.Split('e'); //split the name from the number -> kinda dangerous, eg. do getTable, getIndex
            ShowTableInfo(tableId); //pass the number to ShowTableInfo     
        }
        private void btnExitTableInfo_Click(object sender, EventArgs e)
        {
            pnlTableInfo.Hide();
        }
        private void lblLogout_MouseHover(object sender, EventArgs e)
        {
            lblLogout.ForeColor = Color.Blue;
        }
        private void lblLogout_MouseLeave(object sender, EventArgs e)
        {
            lblLogout.ForeColor = Color.Black;
        }
        private void lblLogout_Click(object sender, EventArgs e)
        {
            //return to the login form
            loginForm loginForm = new loginForm();
            loginForm.Show();
            this.Hide();
        }
        private void btnSaveTableInfo_Click(object sender, EventArgs e)
        {
            Table_Service tableService = new Table_Service();
           
            if (selectedTable.CheckStatus() != TableStatus.Ordered)
            {
                if (btnOccupiedYes.Checked)
                    selectedTable.isAvailable = false;
                else
                    selectedTable.isAvailable = true;

                ChangeTableImageColor(tableImages[selectedTable.tableId - 1]);
                ShowTableInfo(selectedTable.tableId);
                // update table  
                tableService.UpdateTable(selectedTable, selectedTable.isAvailable, selectedTable.isReserved);
            }
            else
                MessageBox.Show("Can't change info if there is a running order(PLACEHOLDER)", "Placeholder", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            ShowTableIcons(selectedTable);
        }
        private void homeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            homeForm homeForm = new homeForm(employee);
            homeForm.Show();
            this.Hide();
        }
        private void tablesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }
        private void barToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BarKitchenForm menuItemForm = new BarKitchenForm(employee, "bar");
            this.Hide();
            menuItemForm.Show();
        }

        private void btnReservedYes_CheckedChanged(object sender, EventArgs e)
        {
            if (btnReservedYes.Checked)
            {
                selectedTable.isReserved = true;
                btnReservedYes.Enabled = false;
                btnReservedNo.Enabled = true;
                btnReservedNo.Checked = false;
            }

        }

        private void btnReservedNo_CheckedChanged(object sender, EventArgs e)
        {
            if (btnReservedNo.Checked)
            {
                selectedTable.isReserved = false;
                btnReservedNo.Enabled = false;
                btnReservedYes.Enabled = true;
                btnReservedYes.Checked = false;
            }


        }
    }
}
