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

        private PictureBox[] tableImages; //create an array for all the table images
        private List<Table> tables;
        private Table selectedTable; //the current selected table by the user
        private List<PictureBox> iconsPB = new List<PictureBox>(); //for storing all the table icons

        public tableViewForm(Employee employee)
        {
            InitializeComponent();
            this.employee = employee;
        }
        private void tableViewForm_Load(object sender, EventArgs e)
        {
            LoadForm();
        }
        private void LoadForm()
        {
            //show a Welcome message, "Welcome, firstName!"
            lblWelcome.Text = $"Welcome, {employee.firstName}!";

            Table_Service tableService = new Table_Service();
            tables = tableService.GetAllTables(); //return all the tables from the database

            //add all the table images in a list 
            tableImages = new PictureBox[10] { picTable1, picTable2, picTable3, picTable4, picTable5, picTable6, picTable7, picTable8, picTable9, picTable10 };

            ChangeTableColor();
        }
        private void tableViewForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void ShowTableIcons(Table table) //show the icons for each table
        {
            int sizeX = tableImages[table.tableId - 1].Height / 3; //make the size to be 1/3 of the table image, so it looks the same on every monitor

            //store the location of the tableImage
            int locationX = tableImages[table.tableId - 1].Location.X;
            int locationY = tableImages[table.tableId - 1].Location.Y;

            if (table.isReserved) //add reserved Icon
                MakePictureBox("reservedIcon", new Point(locationX - sizeX - 2, locationY), Resources.Addressbook_32);

            if (table.order != null) //if the table has an order
            {
                MakePictureBox("orderIcon", new Point(locationX + tableImages[0].Width + 2, locationY), Resources.Purchase_Order_32);
                //if the waiting time is more than 15 minutes, display the time icon
                if (WaitTimeMinutes((int)(DateTime.Now - table.order.DateTime).TotalSeconds) >= 15)
                    MakePictureBox("clockIcon", new Point(locationX - sizeX - 2, locationY + tableImages[table.tableId - 1].Height - sizeX), Resources.Alert_Clock_32);

                if (table.order.ListOrderItems.Count > 0) //if the order has items in it
                {
                    int count = 0;
                    foreach (OrderItem OI in table.order.ListOrderItems)
                        if (OI.status == StatusEnum.Ready) //if the order has food, display the food icon
                        {
                            count++;
                           
                        }
                    if(count == table.order.ListOrderItems.Count)
                    {
                        MakePictureBox("readyIcon", new Point(locationX + tableImages[0].Width + 2, locationY + tableImages[table.tableId - 1].Height - sizeX), Resources.svg_checkmark_verified_6);
                    }
                }
            }
        }
        private void MakePictureBox(string Name, Point Location, Image BackgroundImage) // create picture box for the icons
        {

            int sizeX = tableImages[0].Height / 3; //make the size of the icon 1/3 of the table image
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
            pnlTables.Controls.Add(icon); //add the icon to the pnlTables controls so it becomes visibile
            iconsPB.Add(icon); // add the icons to an icons list (so I can dispose of them easier)
        }
        void ChangeTableColor() //change the back color depending on the availability for all the tables
        {
            foreach (PictureBox pb in iconsPB) //dispose of all the table icons
                pb.Dispose();

            int count = 0; //to keep track of the table number
            foreach (PictureBox p in tableImages) // loop through the t able images list
            {
                //if the table is occupied, set the color to green
                if (tables[count].isAvailable)
                    p.BackColor = Color.FromArgb(102, 210, 105); //green-ish color
                else //if it is not occupied, set it to red
                    p.BackColor = Color.FromArgb(255, 128, 128); //red-ish color

                ShowTableIcons(tables[count]); // foreach table, show the icons
                count++;
            }
        }
        void ShowTableInfo(int tableId) //show the information for the selected table
        {
            selectedTable = tables[tableId - 1]; //set the current selected table

            //set the placeholder image to the corresponding table image from the list
            picPlaceHolder.Image = tableImages[tableId - 1].Image;
            //set the labels to the right values from the database
            lblCapacity.Text = "Capacity: " + selectedTable.capacity.ToString();
            lblStatus.Text = "Status: " + selectedTable.status.ToString();

            SetRadioButtons(); //set the radio buttons of the occupied/reserved      

            ChangeLabelWaitTime(selectedTable);

            //if the table has an order, create and start the timer
            if (selectedTable.status == TableStatus.Ordered)
            {
                Timer timerWaitTime = new Timer();
                timerWaitTime.Tick += TimerWaitTime_Tick;
                timerWaitTime.Interval = 1000;
                timerWaitTime.Start();
            }

            pnlTableInfo.Show();  //show the table info panel
        }
        private void SetRadioButtons()
        {
            if (selectedTable.isReserved)
                btnReservedYes.Checked = true;
            else
                btnReservedNo.Checked = true;

            //if the table is occupied, show that on the screen
            if (!selectedTable.isAvailable)
                btnOccupiedYes.Checked = true;
            else //if the table is not ocuppied
                btnOccupiedNo.Checked = true;
        }
        private void TimerWaitTime_Tick(object sender, EventArgs e) //with every tick, change the wait time label
        {
            ChangeLabelWaitTime(selectedTable);
        }
        private int WaitTimeMinutes(int waitTimeTotalSeconds)
        {
            return waitTimeTotalSeconds / 60;
        }
        private void ChangeLabelWaitTime(Table table)
        {

            /*
             * All this does is, it calculates the wait time for the order from the moment the order was placed
             * it changes the label color of the wait time label depending on the minutes waited
             * it changes the wait time label to the appropiate time       
             */
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
            else //if there is no order, the timer shows 00:00
            {
                lblWaitTime.BackColor = SystemColors.Control;
                lblWaitTime.Text = "00:00";
            }
        }
        private void TableClick(object sender, EventArgs e) //event handler
        {
            PictureBox tablePic = (PictureBox)sender; //store the clicked table
            int tableId = int.Parse(tablePic.Name.Remove(0, 8)); //return only the table number
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
            new SwitchForms(employee, this, new loginForm());
        }
        private void btnSaveTableInfo_Click(object sender, EventArgs e)
        {
            Table_Service tableService = new Table_Service();

            Table tempSelectedTable = new Table() //store the table information into a temp table
            {
                isAvailable = selectedTable.isAvailable,
                isReserved = selectedTable.isReserved
            };

            //set the temp table to the correct information
            if (btnOccupiedYes.Checked)
                tempSelectedTable.isAvailable = false;
            else
                tempSelectedTable.isAvailable = true;

            if (btnReservedYes.Checked)
                tempSelectedTable.isReserved = true;
            else
                tempSelectedTable.isReserved = false;


            // this check if changes were actually made (it compares the temp table with the selected table)
            if (tempSelectedTable.isAvailable != selectedTable.isAvailable || tempSelectedTable.isReserved != selectedTable.isReserved)
            {

                if (tempSelectedTable.isAvailable != selectedTable.isAvailable) //if the isAvailable changed
                    if (selectedTable.status != TableStatus.Ordered) //if the order doesn't have an order, change the availability
                        selectedTable.isAvailable = tempSelectedTable.isAvailable;
                    else //if there is an order, give warning message
                        MessageBox.Show("Can't change info if there is a running order!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                selectedTable.isReserved = tempSelectedTable.isReserved;



                ShowTableInfo(selectedTable.tableId); //refresh ShowTableInfo panel
                tableService.UpdateTable(selectedTable, selectedTable.isAvailable, selectedTable.isReserved); // update the table
                ChangeTableColor(); //change the colors and the icons

            } // if there were no changes, do nothing
        }

        private void homeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new SwitchForms(employee, this, new homeForm(employee));
        }
        private void tablesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new SwitchForms(employee, this, new tableViewForm(employee));

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
            if (selectedTable.status != TableStatus.Ordered) //if there is no order, go to createOrder panel
                new SwitchForms(employee, this, new EditForm(employee, selectedTable, "order"));
            else //if there is an order, go to editOrder panel
                new SwitchForms(employee, this, new EditForm(employee, selectedTable, "editOrder"));
        }

        private void btnOccupiedNo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnOccupiedYes_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
