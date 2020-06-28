namespace LoginForm
{
    partial class BarKitchenForm
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
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tablesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BarView = new System.Windows.Forms.ToolStripMenuItem();
            this.kitchenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.managementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel_Bar = new System.Windows.Forms.Panel();
            this.listBarReadyView = new System.Windows.Forms.ListView();
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader17 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader18 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader19 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.btnReady = new System.Windows.Forms.Button();
            this.listBarOrderView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.panel_Kitchen = new System.Windows.Forms.Panel();
            this.listKitchenReadyView = new System.Windows.Forms.ListView();
            this.columnHeader22 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader23 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader24 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader25 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader26 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
            this.btnReadyKitchen = new System.Windows.Forms.Button();
            this.listKitchenOrderView = new System.Windows.Forms.ListView();
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label11 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.navbar.SuspendLayout();
            this.panel_Bar.SuspendLayout();
            this.panel_Kitchen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // navbar
            // 
            this.navbar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.navbar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navbar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.navbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.tablesToolStripMenuItem,
            this.BarView,
            this.kitchenToolStripMenuItem,
            this.managementToolStripMenuItem});
            this.navbar.Location = new System.Drawing.Point(0, 0);
            this.navbar.Name = "navbar";
            this.navbar.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.navbar.Size = new System.Drawing.Size(754, 32);
            this.navbar.TabIndex = 3;
            this.navbar.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(67, 28);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // tablesToolStripMenuItem
            // 
            this.tablesToolStripMenuItem.Name = "tablesToolStripMenuItem";
            this.tablesToolStripMenuItem.Size = new System.Drawing.Size(67, 28);
            this.tablesToolStripMenuItem.Text = "Tables";
            this.tablesToolStripMenuItem.Click += new System.EventHandler(this.tablesToolStripMenuItem_Click);
            // 
            // BarView
            // 
            this.BarView.Name = "BarView";
            this.BarView.Size = new System.Drawing.Size(46, 28);
            this.BarView.Text = "Bar";
            this.BarView.Click += new System.EventHandler(this.BarView_Click);
            // 
            // kitchenToolStripMenuItem
            // 
            this.kitchenToolStripMenuItem.Name = "kitchenToolStripMenuItem";
            this.kitchenToolStripMenuItem.Size = new System.Drawing.Size(77, 28);
            this.kitchenToolStripMenuItem.Text = "Kitchen";
            this.kitchenToolStripMenuItem.Click += new System.EventHandler(this.KitchenView_Click);
            // 
            // managementToolStripMenuItem
            // 
            this.managementToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.managementToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.managementToolStripMenuItem.Name = "managementToolStripMenuItem";
            this.managementToolStripMenuItem.Size = new System.Drawing.Size(143, 28);
            this.managementToolStripMenuItem.Text = "Management";
            this.managementToolStripMenuItem.Click += new System.EventHandler(this.managementToolStripMenuItem_Click);
            // 
            // panel_Bar
            // 
            this.panel_Bar.BackColor = System.Drawing.Color.Transparent;
            this.panel_Bar.BackgroundImage = global::LoginForm.Properties.Resources.WhiteOpacity;
            this.panel_Bar.Controls.Add(this.listBarReadyView);
            this.panel_Bar.Controls.Add(this.label1);
            this.panel_Bar.Controls.Add(this.btnReady);
            this.panel_Bar.Controls.Add(this.listBarOrderView);
            this.panel_Bar.Controls.Add(this.label2);
            this.panel_Bar.Location = new System.Drawing.Point(9, 55);
            this.panel_Bar.Margin = new System.Windows.Forms.Padding(2);
            this.panel_Bar.Name = "panel_Bar";
            this.panel_Bar.Size = new System.Drawing.Size(501, 514);
            this.panel_Bar.TabIndex = 35;
            this.panel_Bar.Visible = false;
            // 
            // listBarReadyView
            // 
            this.listBarReadyView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader15,
            this.columnHeader16,
            this.columnHeader17,
            this.columnHeader18,
            this.columnHeader19});
            this.listBarReadyView.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBarReadyView.FullRowSelect = true;
            this.listBarReadyView.HideSelection = false;
            this.listBarReadyView.Location = new System.Drawing.Point(16, 295);
            this.listBarReadyView.Name = "listBarReadyView";
            this.listBarReadyView.Size = new System.Drawing.Size(463, 199);
            this.listBarReadyView.TabIndex = 33;
            this.listBarReadyView.UseCompatibleStateImageBehavior = false;
            this.listBarReadyView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "Order Running";
            this.columnHeader15.Width = 133;
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = "Table";
            this.columnHeader16.Width = 70;
            // 
            // columnHeader17
            // 
            this.columnHeader17.Text = "Name";
            this.columnHeader17.Width = 70;
            // 
            // columnHeader18
            // 
            this.columnHeader18.Text = "Amount";
            this.columnHeader18.Width = 70;
            // 
            // columnHeader19
            // 
            this.columnHeader19.Text = "Notes";
            this.columnHeader19.Width = 118;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 259);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 18);
            this.label1.TabIndex = 32;
            this.label1.Text = "Ready Drinks";
            // 
            // btnReady
            // 
            this.btnReady.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReady.Location = new System.Drawing.Point(346, 7);
            this.btnReady.Name = "btnReady";
            this.btnReady.Size = new System.Drawing.Size(132, 35);
            this.btnReady.TabIndex = 31;
            this.btnReady.Text = "Mark As Ready";
            this.btnReady.UseVisualStyleBackColor = true;
            this.btnReady.Click += new System.EventHandler(this.btnReadyBar_Click);
            // 
            // listBarOrderView
            // 
            this.listBarOrderView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listBarOrderView.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBarOrderView.FullRowSelect = true;
            this.listBarOrderView.HideSelection = false;
            this.listBarOrderView.Location = new System.Drawing.Point(16, 48);
            this.listBarOrderView.Name = "listBarOrderView";
            this.listBarOrderView.Size = new System.Drawing.Size(463, 189);
            this.listBarOrderView.TabIndex = 27;
            this.listBarOrderView.UseCompatibleStateImageBehavior = false;
            this.listBarOrderView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Order Running";
            this.columnHeader1.Width = 133;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Table";
            this.columnHeader2.Width = 70;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Name";
            this.columnHeader3.Width = 70;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Amount";
            this.columnHeader4.Width = 70;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Notes";
            this.columnHeader5.Width = 118;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 14);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 18);
            this.label2.TabIndex = 25;
            this.label2.Text = "New Drinks";
            // 
            // panel_Kitchen
            // 
            this.panel_Kitchen.BackColor = System.Drawing.Color.Transparent;
            this.panel_Kitchen.BackgroundImage = global::LoginForm.Properties.Resources.WhiteOpacity;
            this.panel_Kitchen.Controls.Add(this.listKitchenReadyView);
            this.panel_Kitchen.Controls.Add(this.label3);
            this.panel_Kitchen.Controls.Add(this.btnReadyKitchen);
            this.panel_Kitchen.Controls.Add(this.listKitchenOrderView);
            this.panel_Kitchen.Controls.Add(this.label11);
            this.panel_Kitchen.Location = new System.Drawing.Point(7, 55);
            this.panel_Kitchen.Margin = new System.Windows.Forms.Padding(2);
            this.panel_Kitchen.Name = "panel_Kitchen";
            this.panel_Kitchen.Size = new System.Drawing.Size(503, 514);
            this.panel_Kitchen.TabIndex = 34;
            this.panel_Kitchen.Visible = false;
            // 
            // listKitchenReadyView
            // 
            this.listKitchenReadyView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader22,
            this.columnHeader23,
            this.columnHeader24,
            this.columnHeader25,
            this.columnHeader26});
            this.listKitchenReadyView.FullRowSelect = true;
            this.listKitchenReadyView.HideSelection = false;
            this.listKitchenReadyView.Location = new System.Drawing.Point(17, 295);
            this.listKitchenReadyView.Name = "listKitchenReadyView";
            this.listKitchenReadyView.Size = new System.Drawing.Size(463, 199);
            this.listKitchenReadyView.TabIndex = 33;
            this.listKitchenReadyView.UseCompatibleStateImageBehavior = false;
            this.listKitchenReadyView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader22
            // 
            this.columnHeader22.Text = "Order Running";
            this.columnHeader22.Width = 133;
            // 
            // columnHeader23
            // 
            this.columnHeader23.Text = "Table";
            this.columnHeader23.Width = 75;
            // 
            // columnHeader24
            // 
            this.columnHeader24.Text = "Name";
            this.columnHeader24.Width = 75;
            // 
            // columnHeader25
            // 
            this.columnHeader25.Text = "Amount";
            this.columnHeader25.Width = 70;
            // 
            // columnHeader26
            // 
            this.columnHeader26.Text = "Notes";
            this.columnHeader26.Width = 118;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 259);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 17);
            this.label3.TabIndex = 32;
            this.label3.Text = "Ready Meals";
            // 
            // btnReadyKitchen
            // 
            this.btnReadyKitchen.Location = new System.Drawing.Point(335, 7);
            this.btnReadyKitchen.Name = "btnReadyKitchen";
            this.btnReadyKitchen.Size = new System.Drawing.Size(145, 35);
            this.btnReadyKitchen.TabIndex = 31;
            this.btnReadyKitchen.Text = "Mark As Ready";
            this.btnReadyKitchen.UseVisualStyleBackColor = true;
            this.btnReadyKitchen.Click += new System.EventHandler(this.btnReadyKitchen_Click);
            // 
            // listKitchenOrderView
            // 
            this.listKitchenOrderView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12});
            this.listKitchenOrderView.FullRowSelect = true;
            this.listKitchenOrderView.HideSelection = false;
            this.listKitchenOrderView.Location = new System.Drawing.Point(17, 48);
            this.listKitchenOrderView.Name = "listKitchenOrderView";
            this.listKitchenOrderView.Size = new System.Drawing.Size(463, 189);
            this.listKitchenOrderView.TabIndex = 27;
            this.listKitchenOrderView.UseCompatibleStateImageBehavior = false;
            this.listKitchenOrderView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Order Running";
            this.columnHeader8.Width = 133;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Table";
            this.columnHeader9.Width = 75;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Name";
            this.columnHeader10.Width = 75;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Amount";
            this.columnHeader11.Width = 70;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Notes";
            this.columnHeader12.Width = 118;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(14, 15);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 17);
            this.label11.TabIndex = 25;
            this.label11.Text = "New Meals";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(419, 32);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 18);
            this.label4.TabIndex = 34;
            this.label4.Text = "Log Out";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(-23, -46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::LoginForm.Properties.Resources.last_night;
            this.pictureBox2.Location = new System.Drawing.Point(515, 157);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(227, 332);
            this.pictureBox2.TabIndex = 37;
            this.pictureBox2.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(585, 201);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 18);
            this.label5.TabIndex = 38;
            this.label5.Text = "Order Type";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(514, 264);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(218, 18);
            this.label6.TabIndex = 39;
            this.label6.Text = "Ordered Order - Time Spent";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(514, 385);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 18);
            this.label7.TabIndex = 40;
            this.label7.Text = "Ready Order";
            // 
            // BarKitchenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LoginForm.Properties.Resources.HOME_BG;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(754, 586);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel_Bar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.navbar);
            this.Controls.Add(this.panel_Kitchen);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "BarKitchenForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuItemForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MenuItemForm_FormClosing);
            this.navbar.ResumeLayout(false);
            this.navbar.PerformLayout();
            this.panel_Bar.ResumeLayout(false);
            this.panel_Bar.PerformLayout();
            this.panel_Kitchen.ResumeLayout(false);
            this.panel_Kitchen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip navbar;
        private System.Windows.Forms.ToolStripMenuItem BarView;
        private System.Windows.Forms.ToolStripMenuItem kitchenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tablesToolStripMenuItem;
        private System.Windows.Forms.Panel panel_Bar;
        private System.Windows.Forms.Button btnReady;
        private System.Windows.Forms.ListView listBarOrderView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ListView listKitchenOrderView;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.Button btnReadyKitchen;
        private System.Windows.Forms.Panel panel_Kitchen;
        private System.Windows.Forms.ListView listKitchenReadyView;
        private System.Windows.Forms.ColumnHeader columnHeader22;
        private System.Windows.Forms.ColumnHeader columnHeader23;
        private System.Windows.Forms.ColumnHeader columnHeader24;
        private System.Windows.Forms.ColumnHeader columnHeader25;
        private System.Windows.Forms.ColumnHeader columnHeader26;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView listBarReadyView;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.ColumnHeader columnHeader16;
        private System.Windows.Forms.ColumnHeader columnHeader17;
        private System.Windows.Forms.ColumnHeader columnHeader18;
        private System.Windows.Forms.ColumnHeader columnHeader19;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem managementToolStripMenuItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}