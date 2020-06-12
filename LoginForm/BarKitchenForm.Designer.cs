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
            this.listBarView1 = new System.Windows.Forms.ListView();
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader17 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader18 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader19 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader20 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.btnReady = new System.Windows.Forms.Button();
            this.listBarView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.panel_Kitchen = new System.Windows.Forms.Panel();
            this.listKitchenView1 = new System.Windows.Forms.ListView();
            this.columnHeader22 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader23 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader24 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader25 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader26 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader27 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
            this.btnReadyKitchen = new System.Windows.Forms.Button();
            this.listKitchenView = new System.Windows.Forms.ListView();
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label11 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.navbar.SuspendLayout();
            this.panel_Bar.SuspendLayout();
            this.panel_Kitchen.SuspendLayout();
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
            this.navbar.Size = new System.Drawing.Size(754, 30);
            this.navbar.TabIndex = 3;
            this.navbar.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(67, 26);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // tablesToolStripMenuItem
            // 
            this.tablesToolStripMenuItem.Name = "tablesToolStripMenuItem";
            this.tablesToolStripMenuItem.Size = new System.Drawing.Size(67, 26);
            this.tablesToolStripMenuItem.Text = "Tables";
            this.tablesToolStripMenuItem.Click += new System.EventHandler(this.tablesToolStripMenuItem_Click);
            // 
            // BarView
            // 
            this.BarView.Name = "BarView";
            this.BarView.Size = new System.Drawing.Size(46, 26);
            this.BarView.Text = "Bar";
            this.BarView.Click += new System.EventHandler(this.BarView_Click);
            // 
            // kitchenToolStripMenuItem
            // 
            this.kitchenToolStripMenuItem.Name = "kitchenToolStripMenuItem";
            this.kitchenToolStripMenuItem.Size = new System.Drawing.Size(77, 26);
            this.kitchenToolStripMenuItem.Text = "Kitchen";
            this.kitchenToolStripMenuItem.Click += new System.EventHandler(this.kitchenToolStripMenuItem_Click);
            // 
            // managementToolStripMenuItem
            // 
            this.managementToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.managementToolStripMenuItem.Font = new System.Drawing.Font("Tw Cen MT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.managementToolStripMenuItem.Name = "managementToolStripMenuItem";
            this.managementToolStripMenuItem.Size = new System.Drawing.Size(125, 26);
            this.managementToolStripMenuItem.Text = "Management";
            this.managementToolStripMenuItem.Click += new System.EventHandler(this.managementToolStripMenuItem_Click);
            // 
            // panel_Bar
            // 
            this.panel_Bar.BackColor = System.Drawing.Color.Transparent;
            this.panel_Bar.BackgroundImage = global::LoginForm.Properties.Resources.WhiteOpacity;
            this.panel_Bar.Controls.Add(this.listBarView1);
            this.panel_Bar.Controls.Add(this.label1);
            this.panel_Bar.Controls.Add(this.btnReady);
            this.panel_Bar.Controls.Add(this.listBarView);
            this.panel_Bar.Controls.Add(this.label2);
            this.panel_Bar.Location = new System.Drawing.Point(9, 55);
            this.panel_Bar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel_Bar.Name = "panel_Bar";
            this.panel_Bar.Size = new System.Drawing.Size(731, 514);
            this.panel_Bar.TabIndex = 35;
            this.panel_Bar.Visible = false;
            // 
            // listBarView1
            // 
            this.listBarView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader15,
            this.columnHeader16,
            this.columnHeader17,
            this.columnHeader18,
            this.columnHeader19,
            this.columnHeader20});
            this.listBarView1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBarView1.FullRowSelect = true;
            this.listBarView1.HideSelection = false;
            this.listBarView1.Location = new System.Drawing.Point(35, 302);
            this.listBarView1.Name = "listBarView1";
            this.listBarView1.Size = new System.Drawing.Size(670, 194);
            this.listBarView1.TabIndex = 33;
            this.listBarView1.UseCompatibleStateImageBehavior = false;
            this.listBarView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "TimeSold";
            this.columnHeader15.Width = 133;
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = "TableId";
            this.columnHeader16.Width = 70;
            // 
            // columnHeader17
            // 
            this.columnHeader17.Text = "Amount";
            this.columnHeader17.Width = 70;
            // 
            // columnHeader18
            // 
            this.columnHeader18.Text = "Name";
            this.columnHeader18.Width = 70;
            // 
            // columnHeader19
            // 
            this.columnHeader19.Text = "Status";
            this.columnHeader19.Width = 118;
            // 
            // columnHeader20
            // 
            this.columnHeader20.Text = "Notes";
            this.columnHeader20.Width = 98;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 282);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 18);
            this.label1.TabIndex = 32;
            this.label1.Text = "Orders Ready";
            // 
            // btnReady
            // 
            this.btnReady.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReady.Location = new System.Drawing.Point(573, 11);
            this.btnReady.Name = "btnReady";
            this.btnReady.Size = new System.Drawing.Size(132, 24);
            this.btnReady.TabIndex = 31;
            this.btnReady.Text = "Mark As Ready";
            this.btnReady.UseVisualStyleBackColor = true;
            this.btnReady.Click += new System.EventHandler(this.btnReady_Click);
            // 
            // listBarView
            // 
            this.listBarView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listBarView.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBarView.FullRowSelect = true;
            this.listBarView.HideSelection = false;
            this.listBarView.Location = new System.Drawing.Point(35, 41);
            this.listBarView.Name = "listBarView";
            this.listBarView.Size = new System.Drawing.Size(670, 223);
            this.listBarView.TabIndex = 27;
            this.listBarView.UseCompatibleStateImageBehavior = false;
            this.listBarView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "TimeSold";
            this.columnHeader1.Width = 133;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "TableId";
            this.columnHeader2.Width = 70;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Amount";
            this.columnHeader3.Width = 70;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Name";
            this.columnHeader4.Width = 70;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Status";
            this.columnHeader5.Width = 118;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Notes";
            this.columnHeader6.Width = 98;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 18);
            this.label2.TabIndex = 25;
            this.label2.Text = "Orders for Bar";
            // 
            // panel_Kitchen
            // 
            this.panel_Kitchen.BackColor = System.Drawing.Color.Transparent;
            this.panel_Kitchen.BackgroundImage = global::LoginForm.Properties.Resources.WhiteOpacity;
            this.panel_Kitchen.Controls.Add(this.listKitchenView1);
            this.panel_Kitchen.Controls.Add(this.label3);
            this.panel_Kitchen.Controls.Add(this.btnReadyKitchen);
            this.panel_Kitchen.Controls.Add(this.listKitchenView);
            this.panel_Kitchen.Controls.Add(this.label11);
            this.panel_Kitchen.Location = new System.Drawing.Point(7, 55);
            this.panel_Kitchen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel_Kitchen.Name = "panel_Kitchen";
            this.panel_Kitchen.Size = new System.Drawing.Size(731, 514);
            this.panel_Kitchen.TabIndex = 34;
            this.panel_Kitchen.Visible = false;
            // 
            // listKitchenView1
            // 
            this.listKitchenView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader22,
            this.columnHeader23,
            this.columnHeader24,
            this.columnHeader25,
            this.columnHeader26,
            this.columnHeader27});
            this.listKitchenView1.FullRowSelect = true;
            this.listKitchenView1.HideSelection = false;
            this.listKitchenView1.Location = new System.Drawing.Point(33, 295);
            this.listKitchenView1.Name = "listKitchenView1";
            this.listKitchenView1.Size = new System.Drawing.Size(670, 199);
            this.listKitchenView1.TabIndex = 33;
            this.listKitchenView1.UseCompatibleStateImageBehavior = false;
            this.listKitchenView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader22
            // 
            this.columnHeader22.Text = "TimeSold";
            this.columnHeader22.Width = 133;
            // 
            // columnHeader23
            // 
            this.columnHeader23.Text = "TableId";
            this.columnHeader23.Width = 75;
            // 
            // columnHeader24
            // 
            this.columnHeader24.Text = "Amount";
            this.columnHeader24.Width = 75;
            // 
            // columnHeader25
            // 
            this.columnHeader25.Text = "Name";
            this.columnHeader25.Width = 70;
            // 
            // columnHeader26
            // 
            this.columnHeader26.Text = "Status";
            this.columnHeader26.Width = 118;
            // 
            // columnHeader27
            // 
            this.columnHeader27.Text = "Notes";
            this.columnHeader27.Width = 118;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 267);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 17);
            this.label3.TabIndex = 32;
            this.label3.Text = "Orders Ready";
            // 
            // btnReadyKitchen
            // 
            this.btnReadyKitchen.Location = new System.Drawing.Point(551, 11);
            this.btnReadyKitchen.Name = "btnReadyKitchen";
            this.btnReadyKitchen.Size = new System.Drawing.Size(145, 23);
            this.btnReadyKitchen.TabIndex = 31;
            this.btnReadyKitchen.Text = "Mark As Ready";
            this.btnReadyKitchen.UseVisualStyleBackColor = true;
            this.btnReadyKitchen.Click += new System.EventHandler(this.btnReadyKitchen_Click);
            // 
            // listKitchenView
            // 
            this.listKitchenView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader13});
            this.listKitchenView.FullRowSelect = true;
            this.listKitchenView.HideSelection = false;
            this.listKitchenView.Location = new System.Drawing.Point(33, 48);
            this.listKitchenView.Name = "listKitchenView";
            this.listKitchenView.Size = new System.Drawing.Size(670, 189);
            this.listKitchenView.TabIndex = 27;
            this.listKitchenView.UseCompatibleStateImageBehavior = false;
            this.listKitchenView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "TimeSold";
            this.columnHeader8.Width = 133;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "TableId";
            this.columnHeader9.Width = 75;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Amount";
            this.columnHeader10.Width = 75;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Name";
            this.columnHeader11.Width = 70;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Status";
            this.columnHeader12.Width = 118;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Notes";
            this.columnHeader13.Width = 118;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(30, 17);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(147, 17);
            this.label11.TabIndex = 25;
            this.label11.Text = "Orders for Kitchen ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.Font = new System.Drawing.Font("Tw Cen MT", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(696, 36);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 17);
            this.label4.TabIndex = 34;
            this.label4.Text = "Log Out";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // BarKitchenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LoginForm.Properties.Resources.HOME_BG;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(754, 586);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.navbar);
            this.Controls.Add(this.panel_Bar);
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
        private System.Windows.Forms.ListView listBarView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ListView listKitchenView;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.Button btnReadyKitchen;
        private System.Windows.Forms.Panel panel_Kitchen;
        private System.Windows.Forms.ListView listKitchenView1;
        private System.Windows.Forms.ColumnHeader columnHeader22;
        private System.Windows.Forms.ColumnHeader columnHeader23;
        private System.Windows.Forms.ColumnHeader columnHeader24;
        private System.Windows.Forms.ColumnHeader columnHeader25;
        private System.Windows.Forms.ColumnHeader columnHeader26;
        private System.Windows.Forms.ColumnHeader columnHeader27;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView listBarView1;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.ColumnHeader columnHeader16;
        private System.Windows.Forms.ColumnHeader columnHeader17;
        private System.Windows.Forms.ColumnHeader columnHeader18;
        private System.Windows.Forms.ColumnHeader columnHeader19;
        private System.Windows.Forms.ColumnHeader columnHeader20;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem managementToolStripMenuItem;
        private System.Windows.Forms.Label label4;
    }
}