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
    public partial class tableViewForm : Form
    {
        private Employee employee;

        private List<PictureBox> tableImages = new List<PictureBox>();   //create a list for all the table images
        private List<Table> tables = new List<Table>();
        private bool canEditTable = false; // if the table can be edited
        private Table selectedTable; //the current selected table by the user
        private Timer timerWaitTime = new Timer();
        public tableViewForm(Employee employee)
        {
            InitializeComponent();
            this.employee = employee;
            AddImagesToLists();
        }
        void AddImagesToLists()
        {
            //add all the table images in a list       
            tableImages.Add(picTable1);
            tableImages.Add(picTable2);
            tableImages.Add(picTable3);
            tableImages.Add(picTable4);
            tableImages.Add(picTable5);
            tableImages.Add(picTable6);
            tableImages.Add(picTable7);
            tableImages.Add(picTable8);
            tableImages.Add(picTable9);
            tableImages.Add(picTable10);
        }
        private void tableViewForm_Load(object sender, EventArgs e)
        {
            //split the name into 2 parts, firstName and lastName
            string[] nameSplit = employee.employeeName.Split(' ');
            //show a Welcome message, "Welcome, firstName!"
            lblWelcome.Text = $"Welcome, {nameSplit[0]}!";

            Table_Service tableService = new Table_Service();
            tables = tableService.GetAllTables(); //return all the tables from the database
            ChangeTableImageColor();
        }
        private void tableViewForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        void ChangeTableImageColor() //change the back color depending on the availability for all the tables
        {
            int count = 0;
            foreach (PictureBox p in tableImages) // loop through the images list
            {
                //if the table is occupied, set the color to green
                if (tables[count].isAvailable)
                    p.BackColor = Color.FromArgb(102, 210, 105); //green-ish color
                else //if it is not occupied, set it to red
                    p.BackColor = Color.FromArgb(255, 128, 128); //red-ish color

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
            //set the editing/saving options to false by default
            canEditTable = false;
            btnSaveTableInfo.Enabled = false;
            btnEdit.Text = "ON";
            selectedTable = tables[tableId - 1];

            string status;
            if (selectedTable.status == 1)
                status = "Waiting";
            else if (selectedTable.status == 2)
                status = "Ordered";
            else if (selectedTable.status == 3)
                status = "Ready";
            else if (selectedTable.status == 4)
                status = "Served";
            else if (selectedTable.status == 5)
                status = "Billed";
            else
                status = "None";

            if (selectedTable.isAvailable)
                status = "None";

            //set the placeholder image to the corresponding table image from the list
            picPlaceHolder.Image = tableImages[tableId - 1].Image;
            //set the labels to the right values from the database
            lblCapacity.Text = "Capacity: " + selectedTable.capacity.ToString();
            if (selectedTable.isReserved)
                lblReserved.Text = "Reserved: Yes";
            else
                lblReserved.Text = "Reserved: No";

            //if the table is occupied, show that on the screen
            if (!selectedTable.isAvailable)
                lblOccupied.Text = "Occupied: Yes";
            else //if the table is not ocuppied
                lblOccupied.Text = "Occupied: No";

            lblStatus.Text = "Status: " + status;

            ChangeLabelWaitTime();
          
            if (selectedTable.status < 4)
            {
                timerWaitTime.Tick += TimerWaitTime_Tick;
                timerWaitTime.Interval = 1000;
                timerWaitTime.Start();
            }
            //show the table info panel
            pnlTableInfo.Show();
        }

        private void TimerWaitTime_Tick(object sender, EventArgs e)
        {
            ChangeLabelWaitTime(); ;
        }

        private void ChangeLabelWaitTime()
        {
            int waitTimetotalSeconds = (int)(DateTime.Now - selectedTable.orderdate).TotalSeconds;
            if (!selectedTable.isAvailable && waitTimetotalSeconds > 0)
            {
              
                int waitTimeMinutes = waitTimetotalSeconds / 60;
                int waitTimeSeconds = waitTimetotalSeconds % 60;
                if (waitTimeMinutes < 5)
                    lblWaitTime.BackColor = Color.LightGreen;
                else if (waitTimeMinutes < 15)
                    lblWaitTime.BackColor = Color.Yellow;
                else
                    lblWaitTime.BackColor = Color.PaleVioletRed;
                lblWaitTime.Text = $"{waitTimeMinutes.ToString("00")}:{waitTimeSeconds.ToString("00")}";
            }
            else
            {
                lblWaitTime.BackColor = SystemColors.Control;
                lblWaitTime.Text = "00:00";
            }
        }
        private void picTable1_Click(object sender, EventArgs e)
        {
            ShowTableInfo(1);
        }

        private void picTable2_Click(object sender, EventArgs e)
        {
            ShowTableInfo(2);
        }

        private void picTable3_Click(object sender, EventArgs e)
        {
            ShowTableInfo(3);
        }

        private void picTable4_Click(object sender, EventArgs e)
        {
            ShowTableInfo(4);
        }

        private void picTable5_Click(object sender, EventArgs e)
        {
            ShowTableInfo(5);
        }

        private void picTable6_Click(object sender, EventArgs e)
        {
            ShowTableInfo(6);
        }

        private void picTable7_Click(object sender, EventArgs e)
        {
            ShowTableInfo(7);
        }

        private void picTable8_Click(object sender, EventArgs e)
        {
            ShowTableInfo(8);
        }

        private void picTable9_Click(object sender, EventArgs e)
        {
            ShowTableInfo(9);
        }

        private void picTable10_Click(object sender, EventArgs e)
        {
            ShowTableInfo(10);
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

        private void lblOccupied_Click(object sender, EventArgs e)
        {
            if (canEditTable) // if you can edit the table, change the occupied status
            {
                selectedTable.isAvailable = !selectedTable.isAvailable;
                if (selectedTable.isAvailable)
                    lblOccupied.Text = "Occupied: No";
                else
                    lblOccupied.Text = "Occupied: Yes";
            }
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            canEditTable = !canEditTable;
            if (canEditTable) //when pressing on the ON/OFF button, change the text and enable/disable the save option
                btnEdit.Text = "OFF";
            else
                btnEdit.Text = "ON";

            btnSaveTableInfo.Enabled = !btnSaveTableInfo.Enabled;
        }
        private void lblReserved_Click(object sender, EventArgs e)
        {
            if (canEditTable)
            {
                selectedTable.isReserved = !selectedTable.isReserved;

                if (selectedTable.isReserved)
                    lblReserved.Text = "Reserved: No";
                else
                    lblReserved.Text = "Reserved: Yes";
            }
        }
        private void lblOccupied_MouseLeave(object sender, EventArgs e)
        {
            lblOccupied.Cursor = Cursors.Default; //change the cursor to default when not hovering over label
        }

        private void lblReserved_MouseLeave(object sender, EventArgs e)
        {
            lblReserved.Cursor = Cursors.Default;
        }
        private void btnSaveTableInfo_Click(object sender, EventArgs e)
        {
            Table_Service tableService = new Table_Service();

            ChangeTableImageColor(tableImages[selectedTable.tableId - 1]);
            tableService.UpdateTable(selectedTable, selectedTable.isAvailable, selectedTable.isReserved); // update table       
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
        private void lblOccupied_MouseEnter(object sender, EventArgs e)
        {
            if (canEditTable) //if  you can edit the table, change the cursor when hovering over label
                lblOccupied.Cursor = Cursors.Hand;
        }
        private void lblReserved_MouseEnter(object sender, EventArgs e)
        {
            if (canEditTable) //if  you can edit the table, change the cursor when hovering over label
                lblReserved.Cursor = Cursors.Hand;
        }

        private void navbar_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void barToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuItemForm menuItemForm = new MenuItemForm(employee);
            this.Hide();
            menuItemForm.Show();
        }

        private void pnlTableInfo_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
