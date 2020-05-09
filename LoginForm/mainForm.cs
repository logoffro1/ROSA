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
        bool canEditTable = false;

        public mainForm(Employee employee)
        {
            InitializeComponent();
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
            Environment.Exit(0);
        }
        void ShowTableInfo(int tableId) //show the information for the selected table
        {
            canEditTable = false;
            btnEdit.Text = "ON";
            //add all the table images in a list
            List<PictureBox> tableImages = new List<PictureBox>();
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


            string[] tableStatus = new string[2] { "Order taken", "Order served"};
            Random rnd = new Random();

            Table_Service tableService = new Table_Service();
            Table table = tableService.GetById(tableId);

            //set the placeholder image to the corresponding table image from the list
            picPlaceHolder.Image = tableImages[tableId - 1].Image;     
            //set the labels to the right values from the database
            lblCapacity.Text = "Capacity: " + table.capacity.ToString();
            if(table.isReserved) lblReserved.Text = "Reserved: Yes";
            else lblReserved.Text = "Reserved: No";

            //if the table is occupied, show that on the screen, and set a random status from the tableStatus array
            if (table.isAvailable)
            {
                lblOccupied.Text = "Occupied: Yes";
                lblStatus.Text = "Status: " + tableStatus[rnd.Next(tableStatus.Length)];
            }              
            else //if the table is not ocuppied
            {
                lblOccupied.Text = "Occupied: No";
                lblStatus.Text = "Status: None";
            }

            //show the info panel
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
            pnlTables.Show();
            lblSelectTable.Show();
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

            if (canEditTable)
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
            if (canEditTable)
                btnEdit.Text = "OFF";
            else
                btnEdit.Text = "ON";
        }

        private void lblOccupied_MouseHover(object sender, EventArgs e)
        {
            if(canEditTable)
            lblOccupied.Cursor = Cursors.Hand;
        }

        private void lblReserved_MouseHover(object sender, EventArgs e)
        {
            if (canEditTable)
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
            lblOccupied.Cursor = Cursors.Default;
        }

        private void lblReserved_MouseLeave(object sender, EventArgs e)
        {
            lblReserved.Cursor = Cursors.Default;
        }
    }
}
