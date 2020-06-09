using System;
using System.Drawing;
using System.Windows.Forms;
using RosaLogic;
using RosaModel;
using LoginForm.Properties;
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

        private Image[] helpImages; //create array for the help images
        private PictureBox[] circleImages; //create array for the circle picture boxes
        private int currentPic = 0; // the current selected help picture
        private const int nrOfPictures = 5;
        public homeForm(Employee employee)
        {

            InitializeComponent();

            Employee_Service es = new Employee_Service();
            this.employee = employee;
            this.employee.personalNotes = es.GetNotes(employee);
        }
        void AddImagesToLists()
        {
            //add all the help images
            helpImages = new Image[nrOfPictures] { Resources.helpTablesView, Resources.Table2, Resources.Table3, Resources.Table4, Resources.Table5 };
            //add all the circle picture boxes
            circleImages = new PictureBox[nrOfPictures] { picCircle1, picCircle2, picCircle3, picCircle4, picCircle5 };
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            InitNotes();
            AddImagesToLists();
            //show a Welcome message, "Welcome, firstName!"
            lblWelcome.Text = $"Welcome, {employee.firstName}!";
            lblName.Text = employee.firstName + " " + employee.lastName;
            lblRole.Text = employee.role.ToString();

            lblTime.Text = $"{DateTime.Now.DayOfWeek} - {DateTime.Now.Hour.ToString("00")}:{DateTime.Now.Minute.ToString("00")}";

            //set the profile picture based on the employee role
            if (employee.role == Roles.Manager)
                profilePicture.Image = Resources.managerProfile;
            else if (employee.role == Roles.Waiter)
                profilePicture.Image = Resources.waiterProfile;
            else if (employee.role == Roles.Bartender)
                profilePicture.Image = Resources.bartenderProfile;
            else if (employee.role == Roles.Chef)
                profilePicture.Image = Resources.chefProfile;
        }
        private void InitNotes()
        {
            //change the back color to match the sticky note
            txtNotes.BackColor = Color.FromArgb(255, 255, 128);
            lblNotes.BackColor = Color.FromArgb(255, 255, 128);
            btnSave.BackColor = Color.FromArgb(255, 255, 128);
            foreach (string s in employee.personalNotes)
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
                if (currentPic == helpImages.Length) //if it reaches the last photo, set it back to the first photo
                    currentPic = 0;
            }
            else
            {
                currentPic--;
                if (currentPic < 0) //if it goes under 0, set it to the last photo
                    currentPic = helpImages.Length - 1;
            }

            picHelp.BackgroundImage = helpImages[currentPic]; //set the pictureBox image to the correct image

            //loop through the circle images, make it green only for the selected one
            for (int i = 0; i < circleImages.Length; i++)
            {
                if (i == currentPic) //set circle to green
                    circleImages[i].BackgroundImage = Resources.circleGreen;
                else //set circle to grey
                    circleImages[i].BackgroundImage = Resources.circleGrey;
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
        private void tablesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new SwitchForms(employee, this, new tableViewForm(employee));
        }
        private void barToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new SwitchForms(employee, this, new BarKitchenForm(employee, "bar"));
        }
        private void kitchenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new SwitchForms(employee, this, new BarKitchenForm(employee, "kitchen"));
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
                formattedLines += s + ";";

            es.EditAccount(employee.username, formattedLines);
        }
        private void txtNotes_TextChanged(object sender, EventArgs e)
        {
            btnSave.Text = "SAVE";
        }
        private void managementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new SwitchForms(employee, this, new ManagementForm(employee));
        }
    }
}
