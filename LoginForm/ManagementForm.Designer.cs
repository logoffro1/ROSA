namespace LoginForm
{
    partial class ManagementForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.navbar = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tablesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.orderToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.barToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kitchenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.managementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblLogout = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnRevenue = new System.Windows.Forms.Button();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.navbar.SuspendLayout();
            this.SuspendLayout();
            // 
            // navbar
            // 
            this.navbar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.navbar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navbar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.navbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem1,
            this.tablesToolStripMenuItem1,
            this.orderToolStripMenuItem1,
            this.barToolStripMenuItem,
            this.kitchenToolStripMenuItem,
            this.managementToolStripMenuItem});
            this.navbar.Location = new System.Drawing.Point(0, 0);
            this.navbar.Name = "navbar";
            this.navbar.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.navbar.Size = new System.Drawing.Size(1006, 36);
            this.navbar.TabIndex = 3;
            // 
            // homeToolStripMenuItem1
            // 
            this.homeToolStripMenuItem1.Name = "homeToolStripMenuItem1";
            this.homeToolStripMenuItem1.Size = new System.Drawing.Size(82, 32);
            this.homeToolStripMenuItem1.Text = "Home";
            this.homeToolStripMenuItem1.Click += new System.EventHandler(this.homeToolStripMenuItem1_Click);
            // 
            // tablesToolStripMenuItem1
            // 
            this.tablesToolStripMenuItem1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tablesToolStripMenuItem1.Name = "tablesToolStripMenuItem1";
            this.tablesToolStripMenuItem1.Size = new System.Drawing.Size(82, 32);
            this.tablesToolStripMenuItem1.Text = "Tables";
            this.tablesToolStripMenuItem1.Click += new System.EventHandler(this.tablesToolStripMenuItem1_Click);
            // 
            // orderToolStripMenuItem1
            // 
            this.orderToolStripMenuItem1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.orderToolStripMenuItem1.Name = "orderToolStripMenuItem1";
            this.orderToolStripMenuItem1.Size = new System.Drawing.Size(78, 32);
            this.orderToolStripMenuItem1.Text = "Order";
            // 
            // barToolStripMenuItem
            // 
            this.barToolStripMenuItem.Name = "barToolStripMenuItem";
            this.barToolStripMenuItem.Size = new System.Drawing.Size(55, 32);
            this.barToolStripMenuItem.Text = "Bar";
            this.barToolStripMenuItem.Click += new System.EventHandler(this.barToolStripMenuItem_Click);
            // 
            // kitchenToolStripMenuItem
            // 
            this.kitchenToolStripMenuItem.Name = "kitchenToolStripMenuItem";
            this.kitchenToolStripMenuItem.Size = new System.Drawing.Size(94, 32);
            this.kitchenToolStripMenuItem.Text = "Kitchen";
            this.kitchenToolStripMenuItem.Click += new System.EventHandler(this.kitchenToolStripMenuItem_Click);
            // 
            // managementToolStripMenuItem
            // 
            this.managementToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.managementToolStripMenuItem.Font = new System.Drawing.Font("Tw Cen MT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.managementToolStripMenuItem.Name = "managementToolStripMenuItem";
            this.managementToolStripMenuItem.Size = new System.Drawing.Size(159, 32);
            this.managementToolStripMenuItem.Text = "Management";
            // 
            // lblLogout
            // 
            this.lblLogout.AutoSize = true;
            this.lblLogout.BackColor = System.Drawing.Color.Transparent;
            this.lblLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblLogout.Font = new System.Drawing.Font("Tw Cen MT", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogout.ForeColor = System.Drawing.Color.Black;
            this.lblLogout.Location = new System.Drawing.Point(927, 39);
            this.lblLogout.Name = "lblLogout";
            this.lblLogout.Size = new System.Drawing.Size(72, 22);
            this.lblLogout.TabIndex = 6;
            this.lblLogout.Text = "Log Out";
            this.lblLogout.Click += new System.EventHandler(this.lblLogout_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.BackColor = System.Drawing.Color.Transparent;
            this.lblWelcome.Font = new System.Drawing.Font("Tw Cen MT", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(743, 39);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(131, 22);
            this.lblWelcome.TabIndex = 5;
            this.lblWelcome.Text = "Welcome, Alex!";
            // 
            // btnRevenue
            // 
            this.btnRevenue.Location = new System.Drawing.Point(45, 212);
            this.btnRevenue.Name = "btnRevenue";
            this.btnRevenue.Size = new System.Drawing.Size(79, 33);
            this.btnRevenue.TabIndex = 7;
            this.btnRevenue.Text = "Revenue";
            this.btnRevenue.UseVisualStyleBackColor = true;
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.Location = new System.Drawing.Point(231, 131);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(116, 48);
            this.btnAddEmployee.TabIndex = 8;
            this.btnAddEmployee.Text = "Add Employee";
            this.btnAddEmployee.UseVisualStyleBackColor = true;
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
            // 
            // ManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LoginForm.Properties.Resources.BG_TABLESPAGE;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1006, 721);
            this.Controls.Add(this.btnAddEmployee);
            this.Controls.Add(this.btnRevenue);
            this.Controls.Add(this.lblLogout);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.navbar);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ManagementForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManagementForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ManagementForm_FormClosing);
            this.navbar.ResumeLayout(false);
            this.navbar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip navbar;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tablesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem orderToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem barToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kitchenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem managementToolStripMenuItem;
        private System.Windows.Forms.Label lblLogout;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnRevenue;
        private System.Windows.Forms.Button btnAddEmployee;
    }
}