namespace LoginForm
{
    partial class EditForm
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
            this.Backbuttonedit = new System.Windows.Forms.Button();
            this.EditView = new System.Windows.Forms.ListView();
            this.OrderID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.OrderItem = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MenuID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Amount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ItemName2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Messagelabel = new System.Windows.Forms.Label();
            this.DeleteOrderItemButton = new System.Windows.Forms.Button();
            this.IncreaseButton = new System.Windows.Forms.Button();
            this.DecreaseButton = new System.Windows.Forms.Button();
            this.LunchPanel = new System.Windows.Forms.Panel();
            this.LunchBitesButton = new System.Windows.Forms.Button();
            this.SpecialsButton = new System.Windows.Forms.Button();
            this.LunchMainButton = new System.Windows.Forms.Button();
            this.LunchView = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LunchButton = new System.Windows.Forms.Button();
            this.DinnerButton = new System.Windows.Forms.Button();
            this.DrinksButton = new System.Windows.Forms.Button();
            this.DinnerPanel = new System.Windows.Forms.Panel();
            this.Desserts = new System.Windows.Forms.Button();
            this.MainsButton = new System.Windows.Forms.Button();
            this.StartersButton = new System.Windows.Forms.Button();
            this.DinnerView = new System.Windows.Forms.ListView();
            this.ItemName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuitID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DrinksPanel = new System.Windows.Forms.Panel();
            this.WinesButton = new System.Windows.Forms.Button();
            this.BeersButton = new System.Windows.Forms.Button();
            this.HotDrinksButton = new System.Windows.Forms.Button();
            this.SoftDrinksButton = new System.Windows.Forms.Button();
            this.DrinksView = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuitemID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EditPanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.AddOrderItemFromListButton = new System.Windows.Forms.Button();
            this.OrderPanel = new System.Windows.Forms.Panel();
            this.Backbutton = new System.Windows.Forms.Button();
            this.CreateLabel = new System.Windows.Forms.Label();
            this.CreateOrderButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LunchPanel.SuspendLayout();
            this.DinnerPanel.SuspendLayout();
            this.DrinksPanel.SuspendLayout();
            this.EditPanel.SuspendLayout();
            this.OrderPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Backbuttonedit
            // 
            this.Backbuttonedit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(0)))), ((int)(((byte)(42)))));
            this.Backbuttonedit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Backbuttonedit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Backbuttonedit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(247)))), ((int)(((byte)(233)))));
            this.Backbuttonedit.Location = new System.Drawing.Point(12, 12);
            this.Backbuttonedit.Name = "Backbuttonedit";
            this.Backbuttonedit.Size = new System.Drawing.Size(141, 40);
            this.Backbuttonedit.TabIndex = 0;
            this.Backbuttonedit.Text = "Back to tables";
            this.Backbuttonedit.UseVisualStyleBackColor = false;
            this.Backbuttonedit.Click += new System.EventHandler(this.Backbuttonedit_Click);
            // 
            // EditView
            // 
            this.EditView.BackColor = System.Drawing.Color.White;
            this.EditView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.OrderID,
            this.OrderItem,
            this.MenuID,
            this.Amount,
            this.Status,
            this.ItemName2});
            this.EditView.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.EditView.FullRowSelect = true;
            this.EditView.GridLines = true;
            this.EditView.HideSelection = false;
            this.EditView.Location = new System.Drawing.Point(8, 13);
            this.EditView.MultiSelect = false;
            this.EditView.Name = "EditView";
            this.EditView.Scrollable = false;
            this.EditView.Size = new System.Drawing.Size(464, 337);
            this.EditView.TabIndex = 1;
            this.EditView.UseCompatibleStateImageBehavior = false;
            this.EditView.View = System.Windows.Forms.View.Details;
            // 
            // OrderID
            // 
            this.OrderID.DisplayIndex = 5;
            this.OrderID.Text = "Order ID";
            this.OrderID.Width = 57;
            // 
            // OrderItem
            // 
            this.OrderItem.DisplayIndex = 4;
            this.OrderItem.Text = "Order Item ID";
            this.OrderItem.Width = 84;
            // 
            // MenuID
            // 
            this.MenuID.DisplayIndex = 3;
            this.MenuID.Text = "Menu Item ID";
            this.MenuID.Width = 85;
            // 
            // Amount
            // 
            this.Amount.DisplayIndex = 1;
            this.Amount.Text = "Amount";
            this.Amount.Width = 90;
            // 
            // Status
            // 
            this.Status.DisplayIndex = 2;
            this.Status.Text = "Status";
            this.Status.Width = 130;
            // 
            // ItemName2
            // 
            this.ItemName2.DisplayIndex = 0;
            this.ItemName2.Text = "Name";
            this.ItemName2.Width = 260;
            // 
            // Messagelabel
            // 
            this.Messagelabel.AutoSize = true;
            this.Messagelabel.BackColor = System.Drawing.Color.Lime;
            this.Messagelabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Messagelabel.Location = new System.Drawing.Point(12, 541);
            this.Messagelabel.Name = "Messagelabel";
            this.Messagelabel.Size = new System.Drawing.Size(147, 19);
            this.Messagelabel.TabIndex = 9;
            this.Messagelabel.Text = "Messages go here";
            // 
            // DeleteOrderItemButton
            // 
            this.DeleteOrderItemButton.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.DeleteOrderItemButton.Location = new System.Drawing.Point(8, 367);
            this.DeleteOrderItemButton.Name = "DeleteOrderItemButton";
            this.DeleteOrderItemButton.Size = new System.Drawing.Size(150, 48);
            this.DeleteOrderItemButton.TabIndex = 10;
            this.DeleteOrderItemButton.Text = "Delete order item";
            this.DeleteOrderItemButton.UseVisualStyleBackColor = true;
            this.DeleteOrderItemButton.Click += new System.EventHandler(this.DeleteOrderItemButton_Click);
            // 
            // IncreaseButton
            // 
            this.IncreaseButton.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.IncreaseButton.Location = new System.Drawing.Point(322, 367);
            this.IncreaseButton.Name = "IncreaseButton";
            this.IncreaseButton.Size = new System.Drawing.Size(150, 48);
            this.IncreaseButton.TabIndex = 16;
            this.IncreaseButton.Text = "Increase Amount";
            this.IncreaseButton.UseVisualStyleBackColor = true;
            this.IncreaseButton.Click += new System.EventHandler(this.IncreaseButton_Click);
            // 
            // DecreaseButton
            // 
            this.DecreaseButton.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.DecreaseButton.Location = new System.Drawing.Point(164, 367);
            this.DecreaseButton.Name = "DecreaseButton";
            this.DecreaseButton.Size = new System.Drawing.Size(150, 48);
            this.DecreaseButton.TabIndex = 17;
            this.DecreaseButton.Text = "Decrease Amount";
            this.DecreaseButton.UseVisualStyleBackColor = true;
            this.DecreaseButton.Click += new System.EventHandler(this.DecreaseButton_Click);
            // 
            // LunchPanel
            // 
            this.LunchPanel.BackColor = System.Drawing.Color.PaleTurquoise;
            this.LunchPanel.Controls.Add(this.LunchBitesButton);
            this.LunchPanel.Controls.Add(this.SpecialsButton);
            this.LunchPanel.Controls.Add(this.LunchMainButton);
            this.LunchPanel.Controls.Add(this.LunchView);
            this.LunchPanel.Location = new System.Drawing.Point(498, 74);
            this.LunchPanel.Name = "LunchPanel";
            this.LunchPanel.Size = new System.Drawing.Size(247, 428);
            this.LunchPanel.TabIndex = 21;
            // 
            // LunchBitesButton
            // 
            this.LunchBitesButton.Font = new System.Drawing.Font("Century Gothic", 10.5F, System.Drawing.FontStyle.Italic);
            this.LunchBitesButton.Location = new System.Drawing.Point(165, 13);
            this.LunchBitesButton.Name = "LunchBitesButton";
            this.LunchBitesButton.Size = new System.Drawing.Size(75, 60);
            this.LunchBitesButton.TabIndex = 27;
            this.LunchBitesButton.Text = "Bites";
            this.LunchBitesButton.UseVisualStyleBackColor = true;
            this.LunchBitesButton.Click += new System.EventHandler(this.LunchBitesButton_Click);
            // 
            // SpecialsButton
            // 
            this.SpecialsButton.Font = new System.Drawing.Font("Century Gothic", 10.5F, System.Drawing.FontStyle.Italic);
            this.SpecialsButton.Location = new System.Drawing.Point(85, 13);
            this.SpecialsButton.Name = "SpecialsButton";
            this.SpecialsButton.Size = new System.Drawing.Size(75, 60);
            this.SpecialsButton.TabIndex = 26;
            this.SpecialsButton.Text = "Specials";
            this.SpecialsButton.UseVisualStyleBackColor = true;
            this.SpecialsButton.Click += new System.EventHandler(this.SpecialsButton_Click);
            // 
            // LunchMainButton
            // 
            this.LunchMainButton.Font = new System.Drawing.Font("Century Gothic", 10.5F, System.Drawing.FontStyle.Italic);
            this.LunchMainButton.Location = new System.Drawing.Point(6, 13);
            this.LunchMainButton.Name = "LunchMainButton";
            this.LunchMainButton.Size = new System.Drawing.Size(75, 60);
            this.LunchMainButton.TabIndex = 25;
            this.LunchMainButton.Text = "Mains";
            this.LunchMainButton.UseVisualStyleBackColor = true;
            this.LunchMainButton.Click += new System.EventHandler(this.LunchMainButton_Click);
            // 
            // LunchView
            // 
            this.LunchView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader8,
            this.ID});
            this.LunchView.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LunchView.FullRowSelect = true;
            this.LunchView.HideSelection = false;
            this.LunchView.Location = new System.Drawing.Point(6, 83);
            this.LunchView.MultiSelect = false;
            this.LunchView.Name = "LunchView";
            this.LunchView.Scrollable = false;
            this.LunchView.Size = new System.Drawing.Size(234, 267);
            this.LunchView.TabIndex = 1;
            this.LunchView.UseCompatibleStateImageBehavior = false;
            this.LunchView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Item Name";
            this.columnHeader7.Width = 160;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Price";
            this.columnHeader8.Width = 70;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 35;
            // 
            // LunchButton
            // 
            this.LunchButton.BackColor = System.Drawing.Color.PaleTurquoise;
            this.LunchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LunchButton.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LunchButton.Location = new System.Drawing.Point(498, 16);
            this.LunchButton.Name = "LunchButton";
            this.LunchButton.Size = new System.Drawing.Size(75, 52);
            this.LunchButton.TabIndex = 22;
            this.LunchButton.Text = "Lunch";
            this.LunchButton.UseVisualStyleBackColor = false;
            this.LunchButton.Click += new System.EventHandler(this.LunchButton_Click);
            // 
            // DinnerButton
            // 
            this.DinnerButton.BackColor = System.Drawing.Color.DarkSalmon;
            this.DinnerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DinnerButton.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DinnerButton.Location = new System.Drawing.Point(582, 16);
            this.DinnerButton.Name = "DinnerButton";
            this.DinnerButton.Size = new System.Drawing.Size(78, 52);
            this.DinnerButton.TabIndex = 23;
            this.DinnerButton.Text = "Dinner";
            this.DinnerButton.UseVisualStyleBackColor = false;
            this.DinnerButton.Click += new System.EventHandler(this.DinnerButton_Click);
            // 
            // DrinksButton
            // 
            this.DrinksButton.BackColor = System.Drawing.Color.PaleGreen;
            this.DrinksButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DrinksButton.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DrinksButton.Location = new System.Drawing.Point(670, 16);
            this.DrinksButton.Name = "DrinksButton";
            this.DrinksButton.Size = new System.Drawing.Size(75, 52);
            this.DrinksButton.TabIndex = 24;
            this.DrinksButton.Text = "Drinks";
            this.DrinksButton.UseVisualStyleBackColor = false;
            this.DrinksButton.Click += new System.EventHandler(this.DrinksButton_Click);
            // 
            // DinnerPanel
            // 
            this.DinnerPanel.BackColor = System.Drawing.Color.DarkSalmon;
            this.DinnerPanel.Controls.Add(this.Desserts);
            this.DinnerPanel.Controls.Add(this.MainsButton);
            this.DinnerPanel.Controls.Add(this.StartersButton);
            this.DinnerPanel.Controls.Add(this.DinnerView);
            this.DinnerPanel.Location = new System.Drawing.Point(498, 74);
            this.DinnerPanel.Name = "DinnerPanel";
            this.DinnerPanel.Size = new System.Drawing.Size(247, 428);
            this.DinnerPanel.TabIndex = 22;
            // 
            // Desserts
            // 
            this.Desserts.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Desserts.Location = new System.Drawing.Point(166, 13);
            this.Desserts.Name = "Desserts";
            this.Desserts.Size = new System.Drawing.Size(75, 60);
            this.Desserts.TabIndex = 25;
            this.Desserts.Text = "Desserts";
            this.Desserts.UseVisualStyleBackColor = true;
            this.Desserts.Click += new System.EventHandler(this.Desserts_Click);
            // 
            // MainsButton
            // 
            this.MainsButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainsButton.Location = new System.Drawing.Point(85, 13);
            this.MainsButton.Name = "MainsButton";
            this.MainsButton.Size = new System.Drawing.Size(75, 60);
            this.MainsButton.TabIndex = 25;
            this.MainsButton.Text = "Mains";
            this.MainsButton.UseVisualStyleBackColor = true;
            this.MainsButton.Click += new System.EventHandler(this.MainsButton_Click);
            // 
            // StartersButton
            // 
            this.StartersButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartersButton.Location = new System.Drawing.Point(6, 13);
            this.StartersButton.Name = "StartersButton";
            this.StartersButton.Size = new System.Drawing.Size(75, 60);
            this.StartersButton.TabIndex = 1;
            this.StartersButton.Text = "Starters";
            this.StartersButton.UseVisualStyleBackColor = true;
            this.StartersButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // DinnerView
            // 
            this.DinnerView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ItemName,
            this.Price,
            this.menuitID});
            this.DinnerView.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.DinnerView.FullRowSelect = true;
            this.DinnerView.GridLines = true;
            this.DinnerView.HideSelection = false;
            this.DinnerView.Location = new System.Drawing.Point(6, 83);
            this.DinnerView.MultiSelect = false;
            this.DinnerView.Name = "DinnerView";
            this.DinnerView.Scrollable = false;
            this.DinnerView.Size = new System.Drawing.Size(234, 267);
            this.DinnerView.TabIndex = 0;
            this.DinnerView.UseCompatibleStateImageBehavior = false;
            this.DinnerView.View = System.Windows.Forms.View.Details;
            // 
            // ItemName
            // 
            this.ItemName.Text = "Item Name";
            this.ItemName.Width = 160;
            // 
            // Price
            // 
            this.Price.Text = "Price";
            this.Price.Width = 70;
            // 
            // menuitID
            // 
            this.menuitID.Text = "ID";
            // 
            // DrinksPanel
            // 
            this.DrinksPanel.BackColor = System.Drawing.Color.PaleGreen;
            this.DrinksPanel.Controls.Add(this.WinesButton);
            this.DrinksPanel.Controls.Add(this.BeersButton);
            this.DrinksPanel.Controls.Add(this.HotDrinksButton);
            this.DrinksPanel.Controls.Add(this.SoftDrinksButton);
            this.DrinksPanel.Controls.Add(this.DrinksView);
            this.DrinksPanel.Location = new System.Drawing.Point(498, 74);
            this.DrinksPanel.Name = "DrinksPanel";
            this.DrinksPanel.Size = new System.Drawing.Size(247, 428);
            this.DrinksPanel.TabIndex = 23;
            // 
            // WinesButton
            // 
            this.WinesButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WinesButton.Location = new System.Drawing.Point(125, 59);
            this.WinesButton.Name = "WinesButton";
            this.WinesButton.Size = new System.Drawing.Size(115, 41);
            this.WinesButton.TabIndex = 29;
            this.WinesButton.Text = "Wines";
            this.WinesButton.UseVisualStyleBackColor = true;
            this.WinesButton.Click += new System.EventHandler(this.WinesButton_Click);
            // 
            // BeersButton
            // 
            this.BeersButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BeersButton.Location = new System.Drawing.Point(7, 59);
            this.BeersButton.Name = "BeersButton";
            this.BeersButton.Size = new System.Drawing.Size(115, 41);
            this.BeersButton.TabIndex = 28;
            this.BeersButton.Text = "Beers";
            this.BeersButton.UseVisualStyleBackColor = true;
            this.BeersButton.Click += new System.EventHandler(this.BeersButton_Click);
            // 
            // HotDrinksButton
            // 
            this.HotDrinksButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HotDrinksButton.Location = new System.Drawing.Point(125, 13);
            this.HotDrinksButton.Name = "HotDrinksButton";
            this.HotDrinksButton.Size = new System.Drawing.Size(115, 44);
            this.HotDrinksButton.TabIndex = 27;
            this.HotDrinksButton.Text = "Hot Drinks";
            this.HotDrinksButton.UseVisualStyleBackColor = true;
            this.HotDrinksButton.Click += new System.EventHandler(this.HotDrinksButton_Click);
            // 
            // SoftDrinksButton
            // 
            this.SoftDrinksButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(247)))), ((int)(((byte)(233)))));
            this.SoftDrinksButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.SoftDrinksButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SoftDrinksButton.Location = new System.Drawing.Point(7, 13);
            this.SoftDrinksButton.Name = "SoftDrinksButton";
            this.SoftDrinksButton.Size = new System.Drawing.Size(115, 44);
            this.SoftDrinksButton.TabIndex = 26;
            this.SoftDrinksButton.Text = "Soft Drinks";
            this.SoftDrinksButton.UseVisualStyleBackColor = false;
            this.SoftDrinksButton.Click += new System.EventHandler(this.SoftDrinksButton_Click);
            // 
            // DrinksView
            // 
            this.DrinksView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6,
            this.menuitemID});
            this.DrinksView.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.DrinksView.FullRowSelect = true;
            this.DrinksView.HideSelection = false;
            this.DrinksView.Location = new System.Drawing.Point(6, 106);
            this.DrinksView.Name = "DrinksView";
            this.DrinksView.Scrollable = false;
            this.DrinksView.Size = new System.Drawing.Size(234, 244);
            this.DrinksView.TabIndex = 25;
            this.DrinksView.UseCompatibleStateImageBehavior = false;
            this.DrinksView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Item Name";
            this.columnHeader5.Width = 160;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Price";
            this.columnHeader6.Width = 70;
            // 
            // menuitemID
            // 
            this.menuitemID.Text = "ID";
            this.menuitemID.Width = 45;
            // 
            // EditPanel
            // 
            this.EditPanel.BackColor = System.Drawing.Color.Transparent;
            this.EditPanel.Controls.Add(this.Messagelabel);
            this.EditPanel.Controls.Add(this.button1);
            this.EditPanel.Controls.Add(this.DrinksButton);
            this.EditPanel.Controls.Add(this.DinnerButton);
            this.EditPanel.Controls.Add(this.LunchButton);
            this.EditPanel.Controls.Add(this.Backbuttonedit);
            this.EditPanel.Controls.Add(this.AddOrderItemFromListButton);
            this.EditPanel.Controls.Add(this.panel1);
            this.EditPanel.Controls.Add(this.DrinksPanel);
            this.EditPanel.Controls.Add(this.LunchPanel);
            this.EditPanel.Controls.Add(this.DinnerPanel);
            this.EditPanel.Location = new System.Drawing.Point(0, 0);
            this.EditPanel.Name = "EditPanel";
            this.EditPanel.Size = new System.Drawing.Size(754, 589);
            this.EditPanel.TabIndex = 25;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LimeGreen;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(498, 527);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(247, 47);
            this.button1.TabIndex = 25;
            this.button1.Text = "Payment";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddOrderItemFromListButton
            // 
            this.AddOrderItemFromListButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddOrderItemFromListButton.Location = new System.Drawing.Point(505, 441);
            this.AddOrderItemFromListButton.Name = "AddOrderItemFromListButton";
            this.AddOrderItemFromListButton.Size = new System.Drawing.Size(233, 48);
            this.AddOrderItemFromListButton.TabIndex = 21;
            this.AddOrderItemFromListButton.Text = "Add Order Item from Menu";
            this.AddOrderItemFromListButton.UseVisualStyleBackColor = true;
            this.AddOrderItemFromListButton.Click += new System.EventHandler(this.AddOrderItemFromListButton_Click);
            // 
            // OrderPanel
            // 
            this.OrderPanel.BackColor = System.Drawing.Color.Transparent;
            this.OrderPanel.Controls.Add(this.Backbutton);
            this.OrderPanel.Controls.Add(this.CreateLabel);
            this.OrderPanel.Controls.Add(this.CreateOrderButton);
            this.OrderPanel.Location = new System.Drawing.Point(0, 0);
            this.OrderPanel.Name = "OrderPanel";
            this.OrderPanel.Size = new System.Drawing.Size(754, 589);
            this.OrderPanel.TabIndex = 0;
            // 
            // Backbutton
            // 
            this.Backbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(0)))), ((int)(((byte)(42)))));
            this.Backbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Backbutton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Backbutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(247)))), ((int)(((byte)(233)))));
            this.Backbutton.Location = new System.Drawing.Point(12, 12);
            this.Backbutton.Name = "Backbutton";
            this.Backbutton.Size = new System.Drawing.Size(141, 40);
            this.Backbutton.TabIndex = 4;
            this.Backbutton.Text = "Back to tables";
            this.Backbutton.UseVisualStyleBackColor = false;
            this.Backbutton.Click += new System.EventHandler(this.Backbutton_Click);
            // 
            // CreateLabel
            // 
            this.CreateLabel.BackColor = System.Drawing.Color.Lime;
            this.CreateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateLabel.Location = new System.Drawing.Point(214, 119);
            this.CreateLabel.Name = "CreateLabel";
            this.CreateLabel.Size = new System.Drawing.Size(341, 66);
            this.CreateLabel.TabIndex = 3;
            this.CreateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CreateOrderButton
            // 
            this.CreateOrderButton.BackColor = System.Drawing.Color.Orange;
            this.CreateOrderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateOrderButton.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateOrderButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(247)))), ((int)(((byte)(233)))));
            this.CreateOrderButton.Location = new System.Drawing.Point(248, 222);
            this.CreateOrderButton.Name = "CreateOrderButton";
            this.CreateOrderButton.Size = new System.Drawing.Size(271, 96);
            this.CreateOrderButton.TabIndex = 1;
            this.CreateOrderButton.Text = "Create Order";
            this.CreateOrderButton.UseVisualStyleBackColor = false;
            this.CreateOrderButton.Click += new System.EventHandler(this.CreateOrderButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(214)))), ((int)(((byte)(148)))));
            this.panel1.Controls.Add(this.EditView);
            this.panel1.Controls.Add(this.DeleteOrderItemButton);
            this.panel1.Controls.Add(this.IncreaseButton);
            this.panel1.Controls.Add(this.DecreaseButton);
            this.panel1.Location = new System.Drawing.Point(12, 74);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(480, 428);
            this.panel1.TabIndex = 26;
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(247)))), ((int)(((byte)(233)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(754, 586);
            this.Controls.Add(this.EditPanel);
            this.Controls.Add(this.OrderPanel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "EditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditForm_FormClosing);
            this.Load += new System.EventHandler(this.EditForm_Load);
            this.LunchPanel.ResumeLayout(false);
            this.DinnerPanel.ResumeLayout(false);
            this.DrinksPanel.ResumeLayout(false);
            this.EditPanel.ResumeLayout(false);
            this.EditPanel.PerformLayout();
            this.OrderPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Backbuttonedit;
        private System.Windows.Forms.ListView EditView;
        private System.Windows.Forms.Label Messagelabel;
        private System.Windows.Forms.Button DeleteOrderItemButton;
        private System.Windows.Forms.ColumnHeader OrderID;
        private System.Windows.Forms.ColumnHeader OrderItem;
        private System.Windows.Forms.ColumnHeader Amount;
        private System.Windows.Forms.ColumnHeader Status;
        private System.Windows.Forms.Button IncreaseButton;
        private System.Windows.Forms.Button DecreaseButton;
        private System.Windows.Forms.Panel LunchPanel;
        private System.Windows.Forms.Panel DinnerPanel;
        private System.Windows.Forms.Button LunchButton;
        private System.Windows.Forms.Button DinnerButton;
        private System.Windows.Forms.Button DrinksButton;
        private System.Windows.Forms.Panel DrinksPanel;
        private System.Windows.Forms.ListView DinnerView;
        private System.Windows.Forms.ColumnHeader ItemName;
        private System.Windows.Forms.ColumnHeader Price;
        private System.Windows.Forms.ListView LunchView;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ListView DrinksView;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader MenuID;
        private System.Windows.Forms.Button Desserts;
        private System.Windows.Forms.Button MainsButton;
        private System.Windows.Forms.Button StartersButton;
        private System.Windows.Forms.Button WinesButton;
        private System.Windows.Forms.Button BeersButton;
        private System.Windows.Forms.Button HotDrinksButton;
        private System.Windows.Forms.Button SoftDrinksButton;
        private System.Windows.Forms.Button LunchBitesButton;
        private System.Windows.Forms.Button SpecialsButton;
        private System.Windows.Forms.Button LunchMainButton;
        private System.Windows.Forms.Panel EditPanel;
        private System.Windows.Forms.Panel OrderPanel;
        private System.Windows.Forms.Button CreateOrderButton;
        private System.Windows.Forms.Button AddOrderItemFromListButton;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader menuitID;
        private System.Windows.Forms.ColumnHeader menuitemID;
        private System.Windows.Forms.ColumnHeader ItemName2;
        private System.Windows.Forms.Label CreateLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Backbutton;
        private System.Windows.Forms.Panel panel1;
    }
}