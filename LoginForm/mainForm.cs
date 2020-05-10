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
    public partial class mainForm : Form
    {
        Employee employee;
        //create a list for all the table images
        List<PictureBox> tableImages = new List<PictureBox>();
        bool canEditTable = false; // if the table can be edited
        private Table selectedTable; //the current selected table by the user
        int currentPic = -1;
        public mainForm(Employee employee)
        {
            InitializeComponent();

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

            this.employee = employee;
        }

        private void mainForm_Load(object sender, EventArgs e)
        {             
            //split the name into 2 parts, firstName and lastName
            string[] nameSplit = employee.employeeName.Split(' ');
            //show a Welcome message, "Welcome, firstName!"
            lblWelcome.Text = $"Welcome, {nameSplit[0]}!";            
        }

        private void mainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        void ChangeTableImageColor() //change the back color depending on the availability
        {
            Table_Service tableService = new Table_Service();
            List<Table> tables = tableService.GetAllTables(); //return all the tables from the database
            int count = 0;
            foreach (PictureBox p in tableImages) // loop through the images list
            {
                //if the table is occupied, set the color to green
                if (!tables[count].isAvailable)
                    p.BackColor = SystemColors.Desktop;
                else //if it is not occupied, set it to orange/red
                    p.BackColor = Color.Salmon;

                count++;
            }
        }
        void ShowTableInfo(int tableId) //show the information for the selected table
        {
            //set the editing/saving options to false by default
            canEditTable = false;
            btnSaveTableInfo.Enabled = false;
            btnEdit.Text = "ON";

            string[] tableStatus = new string[2] { "Order taken", "Order served"};
            Random rnd = new Random();

            Table_Service tableService = new Table_Service();
            selectedTable = tableService.GetById(tableId);

            //set the placeholder image to the corresponding table image from the list
            picPlaceHolder.Image = tableImages[tableId - 1].Image;     
            //set the labels to the right values from the database
            lblCapacity.Text = "Capacity: " + selectedTable.capacity.ToString();
            if(selectedTable.isReserved) lblReserved.Text = "Reserved: Yes";
            else lblReserved.Text = "Reserved: No";

            //if the table is occupied, show that on the screen, and set a random status from the tableStatus array
            if (selectedTable.isAvailable)
            {
                lblOccupied.Text = "Occupied: Yes";
                lblStatus.Text = "Status: " + tableStatus[rnd.Next(tableStatus.Length)];
            }              
            else //if the table is not ocuppied
            {
                lblOccupied.Text = "Occupied: No";
                lblStatus.Text = "Status: None";
            }

            //show the table info panel
            pnlTableInfo.Show();
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
        private void tablesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlTablesView.Show();
            ChangeTableImageColor();
            pnlTableInfo.Hide();
            pnlHome.Hide();
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
                if (lblOccupied.Text == "Occupied: Yes")
                    lblOccupied.Text = "Occupied: No";
                else
                    lblOccupied.Text = "Occupied: Yes";
            }
         
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            canEditTable = !canEditTable;
            if (canEditTable) //when pressing on the ON/OFF button, change the text and enable/disable the save option
            {
                btnEdit.Text = "OFF";
                btnSaveTableInfo.Enabled = true;
            }
               
            else
            {
                btnEdit.Text = "ON";
                btnSaveTableInfo.Enabled = false;
            }
             
        }

        private void lblOccupied_MouseHover(object sender, EventArgs e)
        {
            if(canEditTable) //if  you can edit the table, change the cursor when hovering over label
            lblOccupied.Cursor = Cursors.Hand;
        }

        private void lblReserved_MouseHover(object sender, EventArgs e)
        {
            if (canEditTable) //if  you can edit the table, change the cursor when hovering over label
                lblReserved.Cursor = Cursors.Hand;
        }

        private void lblReserved_Click(object sender, EventArgs e)
        {
            if (canEditTable)
            {
                if (lblReserved.Text == "Reserved: Yes")
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

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlTablesView.Hide();
            pnlHome.Show();
        }

        private void lblStatus_MouseHover(object sender, EventArgs e)
        {
            if (canEditTable)
                lblStatus.Cursor = Cursors.Hand;
            else
                lblStatus.Cursor = Cursors.Default;
        }

        private void lblStatus_Click(object sender, EventArgs e)
        {
            if(canEditTable)
            {
                if (lblStatus.Text == "Status: Order taken")
                    lblStatus.Text = "Status: Order served";
                else if (lblStatus.Text == "Status: Order served")
                    lblStatus.Text = "Status: Order taken";

            }
        }
        private void btnSaveTableInfo_Click(object sender, EventArgs e)
        {
            employee.role = RolesEnum.Manager;
            Table_Service tableService = new Table_Service();
            //depending on what the label text is, set isAvailable and isReserved
            bool isAvailable;
            bool isReserved;
            if (lblReserved.Text == "Reserved: Yes")
                isReserved = true;
            else
                isReserved = false;

            if (lblOccupied.Text == "Occupied: Yes")
                isAvailable = true;
            else
                isAvailable = false;

            tableService.UpdateTable(selectedTable, isAvailable, isReserved); // update table
            ChangeTableImageColor();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //test ( prototype)
            currentPic++;
            if (currentPic == tableImages.Count)
                currentPic = 0;
            picTest1.Image = tableImages[currentPic].Image;
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //test ( prototype)
            currentPic--;
            if (currentPic <= -1)
                currentPic = 9;
            picTest1.Image = tableImages[currentPic].Image;
           
        }

        private void managementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlManagementView.Show();
            pnlManagementInfo.Hide();
            pnlHome.Hide();

        }
    }
}
