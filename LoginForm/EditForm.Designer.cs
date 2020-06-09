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
            this.SelectOrderButton = new System.Windows.Forms.Button();
            this.IncreaseButton = new System.Windows.Forms.Button();
            this.DecreaseButton = new System.Windows.Forms.Button();
            this.MenuItemIDBox = new System.Windows.Forms.TextBox();
            this.MenuItemIDLabel = new System.Windows.Forms.Label();
            this.DecreaseStockButton = new System.Windows.Forms.Button();
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
            this.DinnerView = new System.Windows.Forms.ListView();
            this.ItemName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuitID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.StartersButton = new System.Windows.Forms.Button();
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
            this.TableIDLabel = new System.Windows.Forms.Label();
            this.TableIDBox2 = new System.Windows.Forms.TextBox();
            this.CreateOrderButton = new System.Windows.Forms.Button();
            this.ViewbyIDLabel = new System.Windows.Forms.Label();
            this.ViewByIDBox = new System.Windows.Forms.TextBox();
            this.btnCheck = new System.Windows.Forms.Button();
            this.LunchPanel.SuspendLayout();
            this.DinnerPanel.SuspendLayout();
            this.DrinksPanel.SuspendLayout();
            this.EditPanel.SuspendLayout();
            this.OrderPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Backbuttonedit
            // 
            this.Backbuttonedit.Location = new System.Drawing.Point(16, 15);
            this.Backbuttonedit.Margin = new System.Windows.Forms.Padding(4);
            this.Backbuttonedit.Name = "Backbuttonedit";
            this.Backbuttonedit.Size = new System.Drawing.Size(188, 48);
            this.Backbuttonedit.TabIndex = 0;
            this.Backbuttonedit.Text = "Back to tables";
            this.Backbuttonedit.UseVisualStyleBackColor = true;
            this.Backbuttonedit.Click += new System.EventHandler(this.Backbuttonedit_Click);
            // 
            // EditView
            // 
            this.EditView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.OrderID,
            this.OrderItem,
            this.MenuID,
            this.Amount,
            this.Status,
            this.ItemName2});
            this.EditView.FullRowSelect = true;
            this.EditView.HideSelection = false;
            this.EditView.Location = new System.Drawing.Point(16, 70);
            this.EditView.Margin = new System.Windows.Forms.Padding(4);
            this.EditView.MultiSelect = false;
            this.EditView.Name = "EditView";
            this.EditView.Size = new System.Drawing.Size(689, 189);
            this.EditView.TabIndex = 1;
            this.EditView.UseCompatibleStateImageBehavior = false;
            this.EditView.View = System.Windows.Forms.View.Details;
            // 
            // OrderID
            // 
            this.OrderID.Text = "Order ID";
            // 
            // OrderItem
            // 
            this.OrderItem.Text = "Order Item ID";
            this.OrderItem.Width = 80;
            // 
            // MenuID
            // 
            this.MenuID.DisplayIndex = 4;
            this.MenuID.Text = "Menu Item ID";
            this.MenuID.Width = 100;
            // 
            // Amount
            // 
            this.Amount.DisplayIndex = 2;
            this.Amount.Text = "Amount";
            // 
            // Status
            // 
            this.Status.DisplayIndex = 3;
            this.Status.Text = "Status";
            this.Status.Width = 90;
            // 
            // ItemName2
            // 
            this.ItemName2.Text = "Name";
            this.ItemName2.Width = 124;
            // 
            // Messagelabel
            // 
            this.Messagelabel.AutoSize = true;
            this.Messagelabel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Messagelabel.Location = new System.Drawing.Point(12, 503);
            this.Messagelabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Messagelabel.Name = "Messagelabel";
            this.Messagelabel.Size = new System.Drawing.Size(0, 17);
            this.Messagelabel.TabIndex = 9;
            // 
            // DeleteOrderItemButton
            // 
            this.DeleteOrderItemButton.Location = new System.Drawing.Point(16, 286);
            this.DeleteOrderItemButton.Margin = new System.Windows.Forms.Padding(4);
            this.DeleteOrderItemButton.Name = "DeleteOrderItemButton";
            this.DeleteOrderItemButton.Size = new System.Drawing.Size(153, 58);
            this.DeleteOrderItemButton.TabIndex = 10;
            this.DeleteOrderItemButton.Text = "Delete order item";
            this.DeleteOrderItemButton.UseVisualStyleBackColor = true;
            this.DeleteOrderItemButton.Click += new System.EventHandler(this.DeleteOrderItemButton_Click);
            // 
            // SelectOrderButton
            // 
            this.SelectOrderButton.Location = new System.Drawing.Point(608, 38);
            this.SelectOrderButton.Margin = new System.Windows.Forms.Padding(4);
            this.SelectOrderButton.Name = "SelectOrderButton";
            this.SelectOrderButton.Size = new System.Drawing.Size(100, 28);
            this.SelectOrderButton.TabIndex = 13;
            this.SelectOrderButton.Text = "View Items";
            this.SelectOrderButton.UseVisualStyleBackColor = true;
            this.SelectOrderButton.Click += new System.EventHandler(this.SelectOrderButton_Click);
            // 
            // IncreaseButton
            // 
            this.IncreaseButton.Location = new System.Drawing.Point(177, 286);
            this.IncreaseButton.Margin = new System.Windows.Forms.Padding(4);
            this.IncreaseButton.Name = "IncreaseButton";
            this.IncreaseButton.Size = new System.Drawing.Size(131, 58);
            this.IncreaseButton.TabIndex = 16;
            this.IncreaseButton.Text = "Increase Amount";
            this.IncreaseButton.UseVisualStyleBackColor = true;
            this.IncreaseButton.Click += new System.EventHandler(this.IncreaseButton_Click);
            // 
            // DecreaseButton
            // 
            this.DecreaseButton.Location = new System.Drawing.Point(316, 286);
            this.DecreaseButton.Margin = new System.Windows.Forms.Padding(4);
            this.DecreaseButton.Name = "DecreaseButton";
            this.DecreaseButton.Size = new System.Drawing.Size(136, 59);
            this.DecreaseButton.TabIndex = 17;
            this.DecreaseButton.Text = "Decrease Amount";
            this.DecreaseButton.UseVisualStyleBackColor = true;
            this.DecreaseButton.Click += new System.EventHandler(this.DecreaseButton_Click);
            // 
            // MenuItemIDBox
            // 
            this.MenuItemIDBox.Location = new System.Drawing.Point(16, 393);
            this.MenuItemIDBox.Margin = new System.Windows.Forms.Padding(4);
            this.MenuItemIDBox.Name = "MenuItemIDBox";
            this.MenuItemIDBox.Size = new System.Drawing.Size(132, 22);
            this.MenuItemIDBox.TabIndex = 18;
            // 
            // MenuItemIDLabel
            // 
            this.MenuItemIDLabel.AutoSize = true;
            this.MenuItemIDLabel.Location = new System.Drawing.Point(12, 374);
            this.MenuItemIDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MenuItemIDLabel.Name = "MenuItemIDLabel";
            this.MenuItemIDLabel.Size = new System.Drawing.Size(86, 17);
            this.MenuItemIDLabel.TabIndex = 19;
            this.MenuItemIDLabel.Text = "Menuitem ID";
            // 
            // DecreaseStockButton
            // 
            this.DecreaseStockButton.Location = new System.Drawing.Point(16, 425);
            this.DecreaseStockButton.Margin = new System.Windows.Forms.Padding(4);
            this.DecreaseStockButton.Name = "DecreaseStockButton";
            this.DecreaseStockButton.Size = new System.Drawing.Size(133, 28);
            this.DecreaseStockButton.TabIndex = 20;
            this.DecreaseStockButton.Text = "Decrease Stock";
            this.DecreaseStockButton.UseVisualStyleBackColor = true;
            this.DecreaseStockButton.Click += new System.EventHandler(this.DecreaseAmountButton_Click);
            // 
            // LunchPanel
            // 
            this.LunchPanel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.LunchPanel.Controls.Add(this.LunchBitesButton);
            this.LunchPanel.Controls.Add(this.SpecialsButton);
            this.LunchPanel.Controls.Add(this.LunchMainButton);
            this.LunchPanel.Controls.Add(this.LunchView);
            this.LunchPanel.Location = new System.Drawing.Point(732, 70);
            this.LunchPanel.Margin = new System.Windows.Forms.Padding(4);
            this.LunchPanel.Name = "LunchPanel";
            this.LunchPanel.Size = new System.Drawing.Size(320, 449);
            this.LunchPanel.TabIndex = 21;
            // 
            // LunchBitesButton
            // 
            this.LunchBitesButton.Location = new System.Drawing.Point(215, 6);
            this.LunchBitesButton.Margin = new System.Windows.Forms.Padding(4);
            this.LunchBitesButton.Name = "LunchBitesButton";
            this.LunchBitesButton.Size = new System.Drawing.Size(100, 48);
            this.LunchBitesButton.TabIndex = 27;
            this.LunchBitesButton.Text = "Bites";
            this.LunchBitesButton.UseVisualStyleBackColor = true;
            this.LunchBitesButton.Click += new System.EventHandler(this.LunchBitesButton_Click);
            // 
            // SpecialsButton
            // 
            this.SpecialsButton.Location = new System.Drawing.Point(108, 6);
            this.SpecialsButton.Margin = new System.Windows.Forms.Padding(4);
            this.SpecialsButton.Name = "SpecialsButton";
            this.SpecialsButton.Size = new System.Drawing.Size(100, 48);
            this.SpecialsButton.TabIndex = 26;
            this.SpecialsButton.Text = "Specials";
            this.SpecialsButton.UseVisualStyleBackColor = true;
            this.SpecialsButton.Click += new System.EventHandler(this.SpecialsButton_Click);
            // 
            // LunchMainButton
            // 
            this.LunchMainButton.Location = new System.Drawing.Point(4, 6);
            this.LunchMainButton.Margin = new System.Windows.Forms.Padding(4);
            this.LunchMainButton.Name = "LunchMainButton";
            this.LunchMainButton.Size = new System.Drawing.Size(100, 48);
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
            this.LunchView.FullRowSelect = true;
            this.LunchView.HideSelection = false;
            this.LunchView.Location = new System.Drawing.Point(4, 62);
            this.LunchView.Margin = new System.Windows.Forms.Padding(4);
            this.LunchView.MultiSelect = false;
            this.LunchView.Name = "LunchView";
            this.LunchView.Size = new System.Drawing.Size(309, 383);
            this.LunchView.TabIndex = 1;
            this.LunchView.UseCompatibleStateImageBehavior = false;
            this.LunchView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Item Name";
            this.columnHeader7.Width = 95;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Price";
            this.columnHeader8.Width = 70;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            // 
            // LunchButton
            // 
            this.LunchButton.Location = new System.Drawing.Point(732, 36);
            this.LunchButton.Margin = new System.Windows.Forms.Padding(4);
            this.LunchButton.Name = "LunchButton";
            this.LunchButton.Size = new System.Drawing.Size(100, 28);
            this.LunchButton.TabIndex = 22;
            this.LunchButton.Text = "Lunch";
            this.LunchButton.UseVisualStyleBackColor = true;
            this.LunchButton.Click += new System.EventHandler(this.LunchButton_Click);
            // 
            // DinnerButton
            // 
            this.DinnerButton.Location = new System.Drawing.Point(840, 34);
            this.DinnerButton.Margin = new System.Windows.Forms.Padding(4);
            this.DinnerButton.Name = "DinnerButton";
            this.DinnerButton.Size = new System.Drawing.Size(100, 28);
            this.DinnerButton.TabIndex = 23;
            this.DinnerButton.Text = "Dinner";
            this.DinnerButton.UseVisualStyleBackColor = true;
            this.DinnerButton.Click += new System.EventHandler(this.DinnerButton_Click);
            // 
            // DrinksButton
            // 
            this.DrinksButton.Location = new System.Drawing.Point(951, 34);
            this.DrinksButton.Margin = new System.Windows.Forms.Padding(4);
            this.DrinksButton.Name = "DrinksButton";
            this.DrinksButton.Size = new System.Drawing.Size(100, 28);
            this.DrinksButton.TabIndex = 24;
            this.DrinksButton.Text = "Drinks";
            this.DrinksButton.UseVisualStyleBackColor = true;
            this.DrinksButton.Click += new System.EventHandler(this.DrinksButton_Click);
            // 
            // DinnerPanel
            // 
            this.DinnerPanel.BackColor = System.Drawing.Color.Tomato;
            this.DinnerPanel.Controls.Add(this.Desserts);
            this.DinnerPanel.Controls.Add(this.MainsButton);
            this.DinnerPanel.Controls.Add(this.DinnerView);
            this.DinnerPanel.Controls.Add(this.StartersButton);
            this.DinnerPanel.Location = new System.Drawing.Point(732, 69);
            this.DinnerPanel.Margin = new System.Windows.Forms.Padding(4);
            this.DinnerPanel.Name = "DinnerPanel";
            this.DinnerPanel.Size = new System.Drawing.Size(320, 449);
            this.DinnerPanel.TabIndex = 22;
            // 
            // Desserts
            // 
            this.Desserts.Location = new System.Drawing.Point(215, 7);
            this.Desserts.Margin = new System.Windows.Forms.Padding(4);
            this.Desserts.Name = "Desserts";
            this.Desserts.Size = new System.Drawing.Size(100, 48);
            this.Desserts.TabIndex = 25;
            this.Desserts.Text = "Desserts";
            this.Desserts.UseVisualStyleBackColor = true;
            this.Desserts.Click += new System.EventHandler(this.Desserts_Click);
            // 
            // MainsButton
            // 
            this.MainsButton.Location = new System.Drawing.Point(109, 7);
            this.MainsButton.Margin = new System.Windows.Forms.Padding(4);
            this.MainsButton.Name = "MainsButton";
            this.MainsButton.Size = new System.Drawing.Size(100, 48);
            this.MainsButton.TabIndex = 25;
            this.MainsButton.Text = "Mains";
            this.MainsButton.UseVisualStyleBackColor = true;
            this.MainsButton.Click += new System.EventHandler(this.MainsButton_Click);
            // 
            // DinnerView
            // 
            this.DinnerView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ItemName,
            this.Price,
            this.menuitID});
            this.DinnerView.FullRowSelect = true;
            this.DinnerView.HideSelection = false;
            this.DinnerView.Location = new System.Drawing.Point(4, 63);
            this.DinnerView.Margin = new System.Windows.Forms.Padding(4);
            this.DinnerView.MultiSelect = false;
            this.DinnerView.Name = "DinnerView";
            this.DinnerView.Size = new System.Drawing.Size(309, 382);
            this.DinnerView.TabIndex = 0;
            this.DinnerView.UseCompatibleStateImageBehavior = false;
            this.DinnerView.View = System.Windows.Forms.View.Details;
            // 
            // ItemName
            // 
            this.ItemName.Text = "Item Name";
            this.ItemName.Width = 100;
            // 
            // Price
            // 
            this.Price.Text = "Price";
            this.Price.Width = 65;
            // 
            // menuitID
            // 
            this.menuitID.Text = "ID";
            // 
            // StartersButton
            // 
            this.StartersButton.Location = new System.Drawing.Point(4, 7);
            this.StartersButton.Margin = new System.Windows.Forms.Padding(4);
            this.StartersButton.Name = "StartersButton";
            this.StartersButton.Size = new System.Drawing.Size(100, 48);
            this.StartersButton.TabIndex = 1;
            this.StartersButton.Text = "Starters";
            this.StartersButton.UseVisualStyleBackColor = true;
            this.StartersButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // DrinksPanel
            // 
            this.DrinksPanel.BackColor = System.Drawing.Color.Peru;
            this.DrinksPanel.Controls.Add(this.WinesButton);
            this.DrinksPanel.Controls.Add(this.BeersButton);
            this.DrinksPanel.Controls.Add(this.HotDrinksButton);
            this.DrinksPanel.Controls.Add(this.SoftDrinksButton);
            this.DrinksPanel.Controls.Add(this.DrinksView);
            this.DrinksPanel.Location = new System.Drawing.Point(732, 70);
            this.DrinksPanel.Margin = new System.Windows.Forms.Padding(4);
            this.DrinksPanel.Name = "DrinksPanel";
            this.DrinksPanel.Size = new System.Drawing.Size(320, 449);
            this.DrinksPanel.TabIndex = 23;
            // 
            // WinesButton
            // 
            this.WinesButton.Location = new System.Drawing.Point(163, 32);
            this.WinesButton.Margin = new System.Windows.Forms.Padding(4);
            this.WinesButton.Name = "WinesButton";
            this.WinesButton.Size = new System.Drawing.Size(153, 28);
            this.WinesButton.TabIndex = 29;
            this.WinesButton.Text = "Wines";
            this.WinesButton.UseVisualStyleBackColor = true;
            this.WinesButton.Click += new System.EventHandler(this.WinesButton_Click);
            // 
            // BeersButton
            // 
            this.BeersButton.Location = new System.Drawing.Point(4, 32);
            this.BeersButton.Margin = new System.Windows.Forms.Padding(4);
            this.BeersButton.Name = "BeersButton";
            this.BeersButton.Size = new System.Drawing.Size(153, 28);
            this.BeersButton.TabIndex = 28;
            this.BeersButton.Text = "Beers";
            this.BeersButton.UseVisualStyleBackColor = true;
            this.BeersButton.Click += new System.EventHandler(this.BeersButton_Click);
            // 
            // HotDrinksButton
            // 
            this.HotDrinksButton.Location = new System.Drawing.Point(163, 4);
            this.HotDrinksButton.Margin = new System.Windows.Forms.Padding(4);
            this.HotDrinksButton.Name = "HotDrinksButton";
            this.HotDrinksButton.Size = new System.Drawing.Size(153, 28);
            this.HotDrinksButton.TabIndex = 27;
            this.HotDrinksButton.Text = "Hot Drinks";
            this.HotDrinksButton.UseVisualStyleBackColor = true;
            this.HotDrinksButton.Click += new System.EventHandler(this.HotDrinksButton_Click);
            // 
            // SoftDrinksButton
            // 
            this.SoftDrinksButton.Location = new System.Drawing.Point(4, 4);
            this.SoftDrinksButton.Margin = new System.Windows.Forms.Padding(4);
            this.SoftDrinksButton.Name = "SoftDrinksButton";
            this.SoftDrinksButton.Size = new System.Drawing.Size(153, 28);
            this.SoftDrinksButton.TabIndex = 26;
            this.SoftDrinksButton.Text = "Soft Drinks";
            this.SoftDrinksButton.UseVisualStyleBackColor = true;
            this.SoftDrinksButton.Click += new System.EventHandler(this.SoftDrinksButton_Click);
            // 
            // DrinksView
            // 
            this.DrinksView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6,
            this.menuitemID});
            this.DrinksView.FullRowSelect = true;
            this.DrinksView.HideSelection = false;
            this.DrinksView.Location = new System.Drawing.Point(4, 62);
            this.DrinksView.Margin = new System.Windows.Forms.Padding(4);
            this.DrinksView.Name = "DrinksView";
            this.DrinksView.Size = new System.Drawing.Size(309, 383);
            this.DrinksView.TabIndex = 25;
            this.DrinksView.UseCompatibleStateImageBehavior = false;
            this.DrinksView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Item Name";
            this.columnHeader5.Width = 90;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Price";
            this.columnHeader6.Width = 90;
            // 
            // menuitemID
            // 
            this.menuitemID.Text = "ID";
            this.menuitemID.Width = 45;
            // 
            // EditPanel
            // 
            this.EditPanel.BackColor = System.Drawing.Color.Transparent;
            this.EditPanel.Controls.Add(this.button1);
            this.EditPanel.Controls.Add(this.LunchPanel);
            this.EditPanel.Controls.Add(this.DrinksPanel);
            this.EditPanel.Controls.Add(this.DinnerPanel);
            this.EditPanel.Controls.Add(this.DrinksButton);
            this.EditPanel.Controls.Add(this.DinnerButton);
            this.EditPanel.Controls.Add(this.LunchButton);
            this.EditPanel.Controls.Add(this.ViewbyIDLabel);
            this.EditPanel.Controls.Add(this.Backbuttonedit);
            this.EditPanel.Controls.Add(this.SelectOrderButton);
            this.EditPanel.Controls.Add(this.ViewByIDBox);
            this.EditPanel.Controls.Add(this.EditView);
            this.EditPanel.Controls.Add(this.AddOrderItemFromListButton);
            this.EditPanel.Controls.Add(this.DecreaseStockButton);
            this.EditPanel.Controls.Add(this.MenuItemIDBox);
            this.EditPanel.Controls.Add(this.MenuItemIDLabel);
            this.EditPanel.Controls.Add(this.DecreaseButton);
            this.EditPanel.Controls.Add(this.DeleteOrderItemButton);
            this.EditPanel.Controls.Add(this.IncreaseButton);
            this.EditPanel.Location = new System.Drawing.Point(0, 0);
            this.EditPanel.Margin = new System.Windows.Forms.Padding(4);
            this.EditPanel.Name = "EditPanel";
            this.EditPanel.Size = new System.Drawing.Size(1067, 551);
            this.EditPanel.TabIndex = 25;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(557, 410);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 43);
            this.button1.TabIndex = 25;
            this.button1.Text = "PAY ORDER";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddOrderItemFromListButton
            // 
            this.AddOrderItemFromListButton.Location = new System.Drawing.Point(480, 286);
            this.AddOrderItemFromListButton.Margin = new System.Windows.Forms.Padding(4);
            this.AddOrderItemFromListButton.Name = "AddOrderItemFromListButton";
            this.AddOrderItemFromListButton.Size = new System.Drawing.Size(228, 58);
            this.AddOrderItemFromListButton.TabIndex = 21;
            this.AddOrderItemFromListButton.Text = "Add Order Item from Menu";
            this.AddOrderItemFromListButton.UseVisualStyleBackColor = true;
            this.AddOrderItemFromListButton.Click += new System.EventHandler(this.AddOrderItemFromListButton_Click);
            // 
            // OrderPanel
            // 
            this.OrderPanel.BackColor = System.Drawing.Color.Transparent;
            this.OrderPanel.Controls.Add(this.btnCheck);
            this.OrderPanel.Controls.Add(this.TableIDLabel);
            this.OrderPanel.Controls.Add(this.TableIDBox2);
            this.OrderPanel.Controls.Add(this.CreateOrderButton);
            this.OrderPanel.Location = new System.Drawing.Point(0, 0);
            this.OrderPanel.Margin = new System.Windows.Forms.Padding(4);
            this.OrderPanel.Name = "OrderPanel";
            this.OrderPanel.Size = new System.Drawing.Size(1063, 551);
            this.OrderPanel.TabIndex = 0;
            // 
            // TableIDLabel
            // 
            this.TableIDLabel.AutoSize = true;
            this.TableIDLabel.Location = new System.Drawing.Point(283, 176);
            this.TableIDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TableIDLabel.Name = "TableIDLabel";
            this.TableIDLabel.Size = new System.Drawing.Size(61, 17);
            this.TableIDLabel.TabIndex = 3;
            this.TableIDLabel.Text = "Table ID";
            // 
            // TableIDBox2
            // 
            this.TableIDBox2.Location = new System.Drawing.Point(283, 199);
            this.TableIDBox2.Margin = new System.Windows.Forms.Padding(4);
            this.TableIDBox2.Name = "TableIDBox2";
            this.TableIDBox2.Size = new System.Drawing.Size(132, 22);
            this.TableIDBox2.TabIndex = 2;
            // 
            // CreateOrderButton
            // 
            this.CreateOrderButton.Location = new System.Drawing.Point(283, 231);
            this.CreateOrderButton.Margin = new System.Windows.Forms.Padding(4);
            this.CreateOrderButton.Name = "CreateOrderButton";
            this.CreateOrderButton.Size = new System.Drawing.Size(133, 28);
            this.CreateOrderButton.TabIndex = 1;
            this.CreateOrderButton.Text = "Create Order";
            this.CreateOrderButton.UseVisualStyleBackColor = true;
            this.CreateOrderButton.Click += new System.EventHandler(this.CreateOrderButton_Click);
            // 
            // ViewbyIDLabel
            // 
            this.ViewbyIDLabel.AutoSize = true;
            this.ViewbyIDLabel.Location = new System.Drawing.Point(463, 21);
            this.ViewbyIDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ViewbyIDLabel.Name = "ViewbyIDLabel";
            this.ViewbyIDLabel.Size = new System.Drawing.Size(62, 17);
            this.ViewbyIDLabel.TabIndex = 15;
            this.ViewbyIDLabel.Text = "Order ID";
            // 
            // ViewByIDBox
            // 
            this.ViewByIDBox.Location = new System.Drawing.Point(467, 41);
            this.ViewByIDBox.Margin = new System.Windows.Forms.Padding(4);
            this.ViewByIDBox.Name = "ViewByIDBox";
            this.ViewByIDBox.Size = new System.Drawing.Size(132, 22);
            this.ViewByIDBox.TabIndex = 14;
            this.ViewByIDBox.TextChanged += new System.EventHandler(this.ViewByIDBox_TextChanged);
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(446, 231);
            this.btnCheck.Margin = new System.Windows.Forms.Padding(4);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(133, 28);
            this.btnCheck.TabIndex = 4;
            this.btnCheck.Text = "Check Order";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LoginForm.Properties.Resources.BG_TABLESPAGE;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.Messagelabel);
            this.Controls.Add(this.EditPanel);
            this.Controls.Add(this.OrderPanel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "EditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit form";
            this.Load += new System.EventHandler(this.EditForm_Load);
            this.LunchPanel.ResumeLayout(false);
            this.DinnerPanel.ResumeLayout(false);
            this.DrinksPanel.ResumeLayout(false);
            this.EditPanel.ResumeLayout(false);
            this.EditPanel.PerformLayout();
            this.OrderPanel.ResumeLayout(false);
            this.OrderPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Backbuttonedit;
        private System.Windows.Forms.ListView EditView;
        private System.Windows.Forms.Label Messagelabel;
        private System.Windows.Forms.Button DeleteOrderItemButton;
        private System.Windows.Forms.Button SelectOrderButton;
        private System.Windows.Forms.ColumnHeader OrderID;
        private System.Windows.Forms.ColumnHeader OrderItem;
        private System.Windows.Forms.ColumnHeader Amount;
        private System.Windows.Forms.ColumnHeader Status;
        private System.Windows.Forms.Button IncreaseButton;
        private System.Windows.Forms.Button DecreaseButton;
        private System.Windows.Forms.TextBox MenuItemIDBox;
        private System.Windows.Forms.Label MenuItemIDLabel;
        private System.Windows.Forms.Button DecreaseStockButton;
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
        private System.Windows.Forms.Label TableIDLabel;
        private System.Windows.Forms.TextBox TableIDBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label ViewbyIDLabel;
        private System.Windows.Forms.TextBox ViewByIDBox;
        private System.Windows.Forms.Button btnCheck;
    }
}