using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using RosaLogic;
using RosaModel;
using LoginForm.Properties;
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
        private List<PictureBox> iconsPB = new List<PictureBox>();
        public tableViewForm(Employee employee)
        {
            InitializeComponent();
            this.employee = employee;
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
            int sizeX = tableImages[table.tableId - 1].Height / 3;
            int sizeY = sizeX;
            int locationX = tableImages[table.tableId - 1].Location.X;
            int locationY = tableImages[table.tableId - 1].Location.Y;
            if (table.isReserved)
                MakePictureBox("reservedIcon", new Point(locationX - sizeX - 2, locationY), Resources.Addressbook_32);

            if (table.order != null)
            {
                if (WaitTimeMinutes((int)(DateTime.Now - table.order.DateTime).TotalSeconds) >= 15)
                    MakePictureBox("clockIcon", new Point(locationX - sizeX - 2, locationY + tableImages[table.tableId - 1].Height - sizeX), Resources.Alert_Clock_32);

                if (table.order.ListOrderItems.Count > 0)
                {
                    foreach (OrderItem OI in table.order.ListOrderItems)
                        if (OI.menuItem.menuCat >= 25)
                        {
                            MakePictureBox("drinkIcon", new Point(locationX + tableImages[0].Width + 2, locationY), Resources.Coffee_32);
                            break;
                        }
                    foreach (OrderItem OI in table.order.ListOrderItems)
                        if (OI.menuItem.menuCat < 25)
                        {
                            MakePictureBox("foodIcon", new Point(locationX + tableImages[0].Width + 2, locationY + tableImages[table.tableId - 1].Height - sizeX), Resources.Food_32);
                            break;
                        }
                }
            }
        }
        private void MakePictureBox(string Name, Point Location, Image BackgroundImage)
        {

            int sizeX = tableImages[0].Height / 3;
            int sizeY = sizeX;
            PictureBox icon = new PictureBox()
            {
                Name = Name,
                Size = new Size(sizeX, sizeY),
                Location = Location,
                BackgroundImage = BackgroundImage,
                BackColor = Color.Transparent,
                BackgroundImageLayout = ImageLayout.Stretch

            };
            pnlTables.Controls.Add(icon);
            iconsPB.Add(icon);
        }
        void ChangeTableColor() //change the back color depending on the availability for all the tables
        {
            foreach (PictureBox pb in iconsPB)
                pb.Dispose();

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

            lblStatus.Text = "Status: " + selectedTable.status.ToString();

            ChangeLabelWaitTime(selectedTable);

            if (selectedTable.status == TableStatus.Ordered)
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
        private int WaitTimeMinutes(int waitTimeTotalSeconds)
        {
            return waitTimeTotalSeconds / 60;
        }
        private void ChangeLabelWaitTime(Table table)
        {
            if (table.status == TableStatus.Ordered)
            {
                int waitTimetotalSeconds = (int)(DateTime.Now - table.order.DateTime).TotalSeconds;

                if (waitTimetotalSeconds > 0)
                {
                    int waitTimeMinutes = WaitTimeMinutes(waitTimetotalSeconds);
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
            Table tempSelectedTable = new Table()
            {
                isAvailable = selectedTable.isAvailable,
                isReserved = selectedTable.isReserved
            };

            if (btnOccupiedYes.Checked)
                tempSelectedTable.isAvailable = false;
            else
                tempSelectedTable.isAvailable = true;

            if (btnReservedYes.Checked)
                tempSelectedTable.isReserved = true;
            else
                tempSelectedTable.isReserved = false;

            if (tempSelectedTable.isAvailable != selectedTable.isAvailable || tempSelectedTable.isReserved != selectedTable.isReserved)
            {

                if(tempSelectedTable.isAvailable != selectedTable.isAvailable)
                if (selectedTable.status != TableStatus.Ordered)
                    selectedTable.isAvailable = tempSelectedTable.isAvailable;
                else
                MessageBox.Show("Can't change info if there is a running order(PLACEHOLDER)", "Placeholder", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                selectedTable.isReserved = tempSelectedTable.isReserved;

                    ShowTableInfo(selectedTable.tableId);
                    tableService.UpdateTable(selectedTable, selectedTable.isAvailable, selectedTable.isReserved);
                    ChangeTableColor();           
            }
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
            new SwitchForms(employee, this, new BarKitchenForm(employee, "bar"));
        }

        private void btnReservedYes_CheckedChanged(object sender, EventArgs e)
        {
            if (btnReservedYes.Checked)
            {
                btnReservedYes.Enabled = false;
                btnReservedNo.Enabled = true;
                btnReservedNo.Checked = false;
            }

        }

        private void btnReservedNo_CheckedChanged(object sender, EventArgs e)
        {
            if (btnReservedNo.Checked)
            {
                btnReservedNo.Enabled = false;
                btnReservedYes.Enabled = true;
                btnReservedYes.Checked = false;
            }
        }

        private void managementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new SwitchForms(employee, this, new ManagementForm(employee));

        }

        private void kitchenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new SwitchForms(employee, this, new BarKitchenForm(employee, "kitchen"));
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {

        }
    }
}
