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
using System.IO;
namespace LoginForm
{   
     /// <summary>
     /// HOME FORM
     /// Made by Cosmin Ilie 
     /// Student number: 645976
     /// </summary>
    public partial class homeForm : Form
    {
        private Employee employee;

        private List<Image> helpImages = new List<Image>(); //create list for the help images
        private List<PictureBox> circleImages = new List<PictureBox>(); //create list for the circle picture boxes
        private int currentPic = 0; // the current selected help picture
        public homeForm(Employee employee)
        {
            Employee_Service es = new Employee_Service();
            InitializeComponent();
            this.employee = employee;
            this.employee.personalNotes = es.GetNotes(employee);
        }
        void AddImagesToLists()
        {

            //add all the help images
            helpImages.Add(Properties.Resources.helpTablesView);
            helpImages.Add(Properties.Resources.Table2);
            helpImages.Add(Properties.Resources.Table3);
            helpImages.Add(Properties.Resources.Table4);
            helpImages.Add(Properties.Resources.Table5);

            //add all the circle picture boxes
            circleImages.Add(picCircle1);
            circleImages.Add(picCircle2);
            circleImages.Add(picCircle3);
            circleImages.Add(picCircle4);
            circleImages.Add(picCircle5);
        }
        private void mainForm_Load(object sender, EventArgs e)
        {
            InitNotes();
            AddImagesToLists();    
            //show a Welcome message, "Welcome, firstName!"
            lblWelcome.Text = $"Welcome, {employee.firstName}!";
            lblName.Text = employee.firstName+" "+employee.lastName;
            lblRole.Text = employee.role.ToString();

            lblTime.Text = $"{DateTime.Now.DayOfWeek} - {DateTime.Now.Hour.ToString("00")}:{DateTime.Now.Minute.ToString("00")}";
           
            //set the profile picture based on the employee role
            if (employee.role == Roles.Manager)
                profilePicture.Image = Properties.Resources.managerProfile;
            else if (employee.role == Roles.Waiter)
                profilePicture.Image = Properties.Resources.waiterProfile;
            else if (employee.role == Roles.Bartender)
                profilePicture.Image = Properties.Resources.bartenderProfile;
            else if (employee.role == Roles.Chef)
                profilePicture.Image = Properties.Resources.chefProfile;
        }
        private void InitNotes()
        {
            //change the back color to match the sticky note
            txtNotes.BackColor = Color.FromArgb(255, 255, 128);
            lblNotes.BackColor = Color.FromArgb(255, 255, 128);
            btnSave.BackColor = Color.FromArgb(255, 255, 128);
            foreach(string s in employee.personalNotes)
                txtNotes.Text += s + Environment.NewLine;               
        }
        private void mainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
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
        void ChangeHelpPicture(bool goingRight)
        {
            //if goingRight is true, then the user is pressing the right button, if false, then it's pressing the left button

            if (goingRight)
            {
                currentPic++;
                if (currentPic == helpImages.Count) //if it reaches the last photo, set it back to the first photo
                    currentPic = 0;
            }
            else
            {
                currentPic--;
                if (currentPic < 0) //if it goes under 0, set it to the last photo
                    currentPic = helpImages.Count - 1;
            }

            picHelp.BackgroundImage = helpImages[currentPic]; //set the pictureBox image to the correct image

            //loop through the circle images, make it green only for the selected one
            for (int i = 0; i < circleImages.Count; i++)
            {
                if (i == currentPic) //set circle to green
                    circleImages[i].BackgroundImage = Properties.Resources.circleGreen;
                else //set circle to grey
                    circleImages[i].BackgroundImage = Properties.Resources.circleGrey;
            }
        }
        private void btnSlideLeft_Click_1(object sender, EventArgs e)
        {
            ChangeHelpPicture(false);
        }
        private void btnSlideRight_Click(object sender, EventArgs e)
        {
            ChangeHelpPicture(true);
        }
        private void homeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }
        private void tablesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            tableViewForm tableForm = new tableViewForm(employee);
            tableForm.Show();
            this.Dispose();
            

        }
            private void barToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuItemForm menuItemForm = new MenuItemForm(employee,"bar");
            this.Hide();
            menuItemForm.Show();
        }
        private void orderToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OrderForm ot = new OrderForm(employee);
            ot.Show();
            this.Hide();
        }
        private void kitchenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuItemForm menuItemForm = new MenuItemForm(employee, "kitchen");
            this.Hide();
            menuItemForm.Show();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            WriteNotes();
            btnSave.Text = "SAVED...";
        }
        private void WriteNotes()
        {
            Employee_Service es = new Employee_Service();
                //get each new line into a separate string 
                string[] txtLines = txtNotes.Text.Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);

                string formattedLines = "";
                foreach (string s in txtLines)
                    formattedLines+=s+";";

            es.EditAccount(employee.username, formattedLines);
        }
        private void txtNotes_TextChanged(object sender, EventArgs e)
        {
            btnSave.Text = "SAVE";
        }
    }
}
