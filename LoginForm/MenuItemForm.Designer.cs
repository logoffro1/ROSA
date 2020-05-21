namespace LoginForm
{
    partial class MenuItemForm
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
            this.orderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BarView = new System.Windows.Forms.ToolStripMenuItem();
            this.kitchenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel_Bar = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.listBarView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.listKitchenView = new System.Windows.Forms.ListView();
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button6 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.panel_Kitchen = new System.Windows.Forms.Panel();
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
            this.orderToolStripMenuItem,
            this.BarView,
            this.kitchenToolStripMenuItem});
            this.navbar.Location = new System.Drawing.Point(0, 0);
            this.navbar.Name = "navbar";
            this.navbar.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.navbar.Size = new System.Drawing.Size(759, 29);
            this.navbar.TabIndex = 3;
            this.navbar.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(67, 25);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // tablesToolStripMenuItem
            // 
            this.tablesToolStripMenuItem.Name = "tablesToolStripMenuItem";
            this.tablesToolStripMenuItem.Size = new System.Drawing.Size(67, 25);
            this.tablesToolStripMenuItem.Text = "Tables";
            this.tablesToolStripMenuItem.Click += new System.EventHandler(this.tablesToolStripMenuItem_Click);
            // 
            // orderToolStripMenuItem
            // 
            this.orderToolStripMenuItem.Name = "orderToolStripMenuItem";
            this.orderToolStripMenuItem.Size = new System.Drawing.Size(65, 25);
            this.orderToolStripMenuItem.Text = "Order";
            this.orderToolStripMenuItem.Click += new System.EventHandler(this.orderToolStripMenuItem_Click);
            // 
            // BarView
            // 
            this.BarView.Name = "BarView";
            this.BarView.Size = new System.Drawing.Size(46, 25);
            this.BarView.Text = "Bar";
            this.BarView.Click += new System.EventHandler(this.BarView_Click);
            // 
            // kitchenToolStripMenuItem
            // 
            this.kitchenToolStripMenuItem.Name = "kitchenToolStripMenuItem";
            this.kitchenToolStripMenuItem.Size = new System.Drawing.Size(77, 25);
            this.kitchenToolStripMenuItem.Text = "Kitchen";
            this.kitchenToolStripMenuItem.Click += new System.EventHandler(this.kitchenToolStripMenuItem_Click);
            // 
            // panel_Bar
            // 
            this.panel_Bar.BackColor = System.Drawing.Color.Transparent;
            this.panel_Bar.BackgroundImage = global::LoginForm.Properties.Resources.WhiteOpacity;
            this.panel_Bar.Controls.Add(this.label6);
            this.panel_Bar.Controls.Add(this.button3);
            this.panel_Bar.Controls.Add(this.listBarView);
            this.panel_Bar.Controls.Add(this.label2);
            this.panel_Bar.Location = new System.Drawing.Point(9, 55);
            this.panel_Bar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel_Bar.Name = "panel_Bar";
            this.panel_Bar.Size = new System.Drawing.Size(731, 514);
            this.panel_Bar.TabIndex = 35;
            this.panel_Bar.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(232, 13);
            this.label6.TabIndex = 34;
            this.label6.Text = "Note: press on DateSold to delete certain order!";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(522, 43);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(132, 20);
            this.button3.TabIndex = 31;
            this.button3.Text = "Mark As Ready";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // listBarView
            // 
            this.listBarView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.listBarView.HideSelection = false;
            this.listBarView.Location = new System.Drawing.Point(35, 78);
            this.listBarView.Name = "listBarView";
            this.listBarView.Size = new System.Drawing.Size(670, 379);
            this.listBarView.TabIndex = 27;
            this.listBarView.UseCompatibleStateImageBehavior = false;
            this.listBarView.View = System.Windows.Forms.View.Details;
            this.listBarView.SelectedIndexChanged += new System.EventHandler(this.listBarView_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "dateSold";
            this.columnHeader1.Width = 133;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "TableId";
            this.columnHeader2.Width = 70;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Price";
            this.columnHeader3.Width = 70;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Quantity";
            this.columnHeader4.Width = 70;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Name";
            this.columnHeader5.Width = 118;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Status";
            this.columnHeader6.Width = 98;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Notes";
            this.columnHeader7.Width = 260;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 17);
            this.label2.TabIndex = 25;
            this.label2.Text = "Orders for Bar";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(32, 10);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(147, 17);
            this.label11.TabIndex = 25;
            this.label11.Text = "Orders for Kitchen ";
            // 
            // listKitchenView
            // 
            this.listKitchenView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader13,
            this.columnHeader14});
            this.listKitchenView.HideSelection = false;
            this.listKitchenView.Location = new System.Drawing.Point(35, 80);
            this.listKitchenView.Name = "listKitchenView";
            this.listKitchenView.Size = new System.Drawing.Size(670, 379);
            this.listKitchenView.TabIndex = 27;
            this.listKitchenView.UseCompatibleStateImageBehavior = false;
            this.listKitchenView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "dateSold";
            this.columnHeader8.Width = 133;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "TableId";
            this.columnHeader9.Width = 75;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Price";
            this.columnHeader10.Width = 75;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Quantity";
            this.columnHeader11.Width = 70;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Name";
            this.columnHeader12.Width = 118;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Status";
            this.columnHeader13.Width = 118;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "Notes";
            this.columnHeader14.Width = 260;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(522, 39);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(145, 23);
            this.button6.TabIndex = 31;
            this.button6.Text = "Mark As Ready";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(38, 41);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(232, 13);
            this.label9.TabIndex = 34;
            this.label9.Text = "Note: press on DateSold to delete certain order!";
            // 
            // panel_Kitchen
            // 
            this.panel_Kitchen.BackColor = System.Drawing.Color.Transparent;
            this.panel_Kitchen.BackgroundImage = global::LoginForm.Properties.Resources.WhiteOpacity;
            this.panel_Kitchen.Controls.Add(this.label9);
            this.panel_Kitchen.Controls.Add(this.button6);
            this.panel_Kitchen.Controls.Add(this.listKitchenView);
            this.panel_Kitchen.Controls.Add(this.label11);
            this.panel_Kitchen.Location = new System.Drawing.Point(9, 54);
            this.panel_Kitchen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel_Kitchen.Name = "panel_Kitchen";
            this.panel_Kitchen.Size = new System.Drawing.Size(731, 514);
            this.panel_Kitchen.TabIndex = 34;
            this.panel_Kitchen.Visible = false;
            // 
            // MenuItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LoginForm.Properties.Resources.HOME_BG;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(759, 596);
            this.Controls.Add(this.navbar);
            this.Controls.Add(this.panel_Bar);
            this.Controls.Add(this.panel_Kitchen);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MenuItemForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuItemForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MenuItemForm_FormClosing);
            this.Load += new System.EventHandler(this.MenuItemForm_Load);
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
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListView listBarView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ListView listKitchenView;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel_Kitchen;
        private System.Windows.Forms.ToolStripMenuItem orderToolStripMenuItem;
    }
}