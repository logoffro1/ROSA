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
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CreateOrderIDBox = new System.Windows.Forms.TextBox();
            this.CreateMenuitemIDBox = new System.Windows.Forms.TextBox();
            this.OrderIDCreatelabel = new System.Windows.Forms.Label();
            this.MenuitemCreateLabel = new System.Windows.Forms.Label();
            this.CreateItemButton = new System.Windows.Forms.Button();
            this.Messagelabel = new System.Windows.Forms.Label();
            this.DeleteOrderItemButton = new System.Windows.Forms.Button();
            this.DeleteOrderItemBox = new System.Windows.Forms.TextBox();
            this.DeleteOrderitemLabel = new System.Windows.Forms.Label();
            this.SelectOrderButton = new System.Windows.Forms.Button();
            this.ViewByIDBox = new System.Windows.Forms.TextBox();
            this.ViewbyIDLabel = new System.Windows.Forms.Label();
            this.IncreaseButton = new System.Windows.Forms.Button();
            this.DecreaseButton = new System.Windows.Forms.Button();
            this.MenuItemIDBox = new System.Windows.Forms.TextBox();
            this.MenuItemIDLabel = new System.Windows.Forms.Label();
            this.DecreaseAmountButton = new System.Windows.Forms.Button();
            this.LunchPanel = new System.Windows.Forms.Panel();
            this.LunchButton = new System.Windows.Forms.Button();
            this.DinnerButton = new System.Windows.Forms.Button();
            this.DrinksButton = new System.Windows.Forms.Button();
            this.DinnerPanel = new System.Windows.Forms.Panel();
            this.DrinksPanel = new System.Windows.Forms.Panel();
            this.DinnerView = new System.Windows.Forms.ListView();
            this.ItemName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DrinksView = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LunchView = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LunchPanel.SuspendLayout();
            this.DinnerPanel.SuspendLayout();
            this.DrinksPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Backbuttonedit
            // 
            this.Backbuttonedit.Location = new System.Drawing.Point(12, 12);
            this.Backbuttonedit.Name = "Backbuttonedit";
            this.Backbuttonedit.Size = new System.Drawing.Size(141, 39);
            this.Backbuttonedit.TabIndex = 0;
            this.Backbuttonedit.Text = "Back to orders";
            this.Backbuttonedit.UseVisualStyleBackColor = true;
            this.Backbuttonedit.Click += new System.EventHandler(this.Backbuttonedit_Click);
            // 
            // EditView
            // 
            this.EditView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.EditView.HideSelection = false;
            this.EditView.Location = new System.Drawing.Point(12, 57);
            this.EditView.Name = "EditView";
            this.EditView.Size = new System.Drawing.Size(518, 154);
            this.EditView.TabIndex = 1;
            this.EditView.UseCompatibleStateImageBehavior = false;
            this.EditView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Order ID";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Order Item";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Amount";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Status";
            this.columnHeader4.Width = 100;
            // 
            // CreateOrderIDBox
            // 
            this.CreateOrderIDBox.Location = new System.Drawing.Point(12, 248);
            this.CreateOrderIDBox.Name = "CreateOrderIDBox";
            this.CreateOrderIDBox.Size = new System.Drawing.Size(100, 20);
            this.CreateOrderIDBox.TabIndex = 2;
            // 
            // CreateMenuitemIDBox
            // 
            this.CreateMenuitemIDBox.Location = new System.Drawing.Point(12, 285);
            this.CreateMenuitemIDBox.Name = "CreateMenuitemIDBox";
            this.CreateMenuitemIDBox.Size = new System.Drawing.Size(100, 20);
            this.CreateMenuitemIDBox.TabIndex = 3;
            // 
            // OrderIDCreatelabel
            // 
            this.OrderIDCreatelabel.AutoSize = true;
            this.OrderIDCreatelabel.Location = new System.Drawing.Point(12, 232);
            this.OrderIDCreatelabel.Name = "OrderIDCreatelabel";
            this.OrderIDCreatelabel.Size = new System.Drawing.Size(47, 13);
            this.OrderIDCreatelabel.TabIndex = 6;
            this.OrderIDCreatelabel.Text = "Order ID";
            // 
            // MenuitemCreateLabel
            // 
            this.MenuitemCreateLabel.AutoSize = true;
            this.MenuitemCreateLabel.Location = new System.Drawing.Point(12, 271);
            this.MenuitemCreateLabel.Name = "MenuitemCreateLabel";
            this.MenuitemCreateLabel.Size = new System.Drawing.Size(67, 13);
            this.MenuitemCreateLabel.TabIndex = 7;
            this.MenuitemCreateLabel.Text = "Menuitem ID";
            // 
            // CreateItemButton
            // 
            this.CreateItemButton.Location = new System.Drawing.Point(12, 331);
            this.CreateItemButton.Name = "CreateItemButton";
            this.CreateItemButton.Size = new System.Drawing.Size(100, 23);
            this.CreateItemButton.TabIndex = 8;
            this.CreateItemButton.Text = "Create order item";
            this.CreateItemButton.UseVisualStyleBackColor = true;
            this.CreateItemButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // Messagelabel
            // 
            this.Messagelabel.AutoSize = true;
            this.Messagelabel.Location = new System.Drawing.Point(9, 409);
            this.Messagelabel.Name = "Messagelabel";
            this.Messagelabel.Size = new System.Drawing.Size(0, 13);
            this.Messagelabel.TabIndex = 9;
            // 
            // DeleteOrderItemButton
            // 
            this.DeleteOrderItemButton.Location = new System.Drawing.Point(258, 291);
            this.DeleteOrderItemButton.Name = "DeleteOrderItemButton";
            this.DeleteOrderItemButton.Size = new System.Drawing.Size(107, 23);
            this.DeleteOrderItemButton.TabIndex = 10;
            this.DeleteOrderItemButton.Text = "Delete order item";
            this.DeleteOrderItemButton.UseVisualStyleBackColor = true;
            this.DeleteOrderItemButton.Click += new System.EventHandler(this.DeleteOrderItemButton_Click);
            // 
            // DeleteOrderItemBox
            // 
            this.DeleteOrderItemBox.Location = new System.Drawing.Point(258, 244);
            this.DeleteOrderItemBox.Name = "DeleteOrderItemBox";
            this.DeleteOrderItemBox.Size = new System.Drawing.Size(100, 20);
            this.DeleteOrderItemBox.TabIndex = 11;
            // 
            // DeleteOrderitemLabel
            // 
            this.DeleteOrderitemLabel.AutoSize = true;
            this.DeleteOrderitemLabel.Location = new System.Drawing.Point(255, 228);
            this.DeleteOrderitemLabel.Name = "DeleteOrderitemLabel";
            this.DeleteOrderitemLabel.Size = new System.Drawing.Size(66, 13);
            this.DeleteOrderitemLabel.TabIndex = 12;
            this.DeleteOrderitemLabel.Text = "Orderitem ID";
            // 
            // SelectOrderButton
            // 
            this.SelectOrderButton.Location = new System.Drawing.Point(456, 31);
            this.SelectOrderButton.Name = "SelectOrderButton";
            this.SelectOrderButton.Size = new System.Drawing.Size(75, 23);
            this.SelectOrderButton.TabIndex = 13;
            this.SelectOrderButton.Text = "View Items";
            this.SelectOrderButton.UseVisualStyleBackColor = true;
            this.SelectOrderButton.Click += new System.EventHandler(this.SelectOrderButton_Click);
            // 
            // ViewByIDBox
            // 
            this.ViewByIDBox.Location = new System.Drawing.Point(350, 33);
            this.ViewByIDBox.Name = "ViewByIDBox";
            this.ViewByIDBox.Size = new System.Drawing.Size(100, 20);
            this.ViewByIDBox.TabIndex = 14;
            // 
            // ViewbyIDLabel
            // 
            this.ViewbyIDLabel.AutoSize = true;
            this.ViewbyIDLabel.Location = new System.Drawing.Point(347, 17);
            this.ViewbyIDLabel.Name = "ViewbyIDLabel";
            this.ViewbyIDLabel.Size = new System.Drawing.Size(47, 13);
            this.ViewbyIDLabel.TabIndex = 15;
            this.ViewbyIDLabel.Text = "Order ID";
            // 
            // IncreaseButton
            // 
            this.IncreaseButton.Location = new System.Drawing.Point(258, 320);
            this.IncreaseButton.Name = "IncreaseButton";
            this.IncreaseButton.Size = new System.Drawing.Size(107, 23);
            this.IncreaseButton.TabIndex = 16;
            this.IncreaseButton.Text = "Increase Amount";
            this.IncreaseButton.UseVisualStyleBackColor = true;
            this.IncreaseButton.Click += new System.EventHandler(this.IncreaseButton_Click);
            // 
            // DecreaseButton
            // 
            this.DecreaseButton.Location = new System.Drawing.Point(258, 349);
            this.DecreaseButton.Name = "DecreaseButton";
            this.DecreaseButton.Size = new System.Drawing.Size(107, 23);
            this.DecreaseButton.TabIndex = 17;
            this.DecreaseButton.Text = "Decrease Amount";
            this.DecreaseButton.UseVisualStyleBackColor = true;
            this.DecreaseButton.Click += new System.EventHandler(this.DecreaseButton_Click);
            // 
            // MenuItemIDBox
            // 
            this.MenuItemIDBox.Location = new System.Drawing.Point(420, 241);
            this.MenuItemIDBox.Name = "MenuItemIDBox";
            this.MenuItemIDBox.Size = new System.Drawing.Size(100, 20);
            this.MenuItemIDBox.TabIndex = 18;
            // 
            // MenuItemIDLabel
            // 
            this.MenuItemIDLabel.AutoSize = true;
            this.MenuItemIDLabel.Location = new System.Drawing.Point(417, 225);
            this.MenuItemIDLabel.Name = "MenuItemIDLabel";
            this.MenuItemIDLabel.Size = new System.Drawing.Size(67, 13);
            this.MenuItemIDLabel.TabIndex = 19;
            this.MenuItemIDLabel.Text = "Menuitem ID";
            // 
            // DecreaseAmountButton
            // 
            this.DecreaseAmountButton.Location = new System.Drawing.Point(420, 282);
            this.DecreaseAmountButton.Name = "DecreaseAmountButton";
            this.DecreaseAmountButton.Size = new System.Drawing.Size(100, 23);
            this.DecreaseAmountButton.TabIndex = 20;
            this.DecreaseAmountButton.Text = "Decrease Stock";
            this.DecreaseAmountButton.UseVisualStyleBackColor = true;
            this.DecreaseAmountButton.Click += new System.EventHandler(this.DecreaseAmountButton_Click);
            // 
            // LunchPanel
            // 
            this.LunchPanel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.LunchPanel.Controls.Add(this.LunchView);
            this.LunchPanel.Location = new System.Drawing.Point(549, 57);
            this.LunchPanel.Name = "LunchPanel";
            this.LunchPanel.Size = new System.Drawing.Size(239, 365);
            this.LunchPanel.TabIndex = 21;
            // 
            // LunchButton
            // 
            this.LunchButton.Location = new System.Drawing.Point(549, 33);
            this.LunchButton.Name = "LunchButton";
            this.LunchButton.Size = new System.Drawing.Size(75, 23);
            this.LunchButton.TabIndex = 22;
            this.LunchButton.Text = "Lunch";
            this.LunchButton.UseVisualStyleBackColor = true;
            this.LunchButton.Click += new System.EventHandler(this.LunchButton_Click);
            // 
            // DinnerButton
            // 
            this.DinnerButton.Location = new System.Drawing.Point(630, 33);
            this.DinnerButton.Name = "DinnerButton";
            this.DinnerButton.Size = new System.Drawing.Size(75, 23);
            this.DinnerButton.TabIndex = 23;
            this.DinnerButton.Text = "Dinner";
            this.DinnerButton.UseVisualStyleBackColor = true;
            this.DinnerButton.Click += new System.EventHandler(this.DinnerButton_Click);
            // 
            // DrinksButton
            // 
            this.DrinksButton.Location = new System.Drawing.Point(713, 33);
            this.DrinksButton.Name = "DrinksButton";
            this.DrinksButton.Size = new System.Drawing.Size(75, 23);
            this.DrinksButton.TabIndex = 24;
            this.DrinksButton.Text = "Drinks";
            this.DrinksButton.UseVisualStyleBackColor = true;
            this.DrinksButton.Click += new System.EventHandler(this.DrinksButton_Click);
            // 
            // DinnerPanel
            // 
            this.DinnerPanel.BackColor = System.Drawing.Color.Tomato;
            this.DinnerPanel.Controls.Add(this.DinnerView);
            this.DinnerPanel.Location = new System.Drawing.Point(549, 57);
            this.DinnerPanel.Name = "DinnerPanel";
            this.DinnerPanel.Size = new System.Drawing.Size(239, 365);
            this.DinnerPanel.TabIndex = 22;
            // 
            // DrinksPanel
            // 
            this.DrinksPanel.BackColor = System.Drawing.Color.Peru;
            this.DrinksPanel.Controls.Add(this.DrinksView);
            this.DrinksPanel.Location = new System.Drawing.Point(549, 57);
            this.DrinksPanel.Name = "DrinksPanel";
            this.DrinksPanel.Size = new System.Drawing.Size(239, 365);
            this.DrinksPanel.TabIndex = 23;
            // 
            // DinnerView
            // 
            this.DinnerView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ItemName,
            this.Price});
            this.DinnerView.HideSelection = false;
            this.DinnerView.Location = new System.Drawing.Point(3, 3);
            this.DinnerView.Name = "DinnerView";
            this.DinnerView.Size = new System.Drawing.Size(233, 356);
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
            this.Price.Width = 100;
            // 
            // DrinksView
            // 
            this.DrinksView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6});
            this.DrinksView.HideSelection = false;
            this.DrinksView.Location = new System.Drawing.Point(3, 6);
            this.DrinksView.Name = "DrinksView";
            this.DrinksView.Size = new System.Drawing.Size(233, 356);
            this.DrinksView.TabIndex = 25;
            this.DrinksView.UseCompatibleStateImageBehavior = false;
            this.DrinksView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Item Name";
            this.columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Price";
            this.columnHeader6.Width = 100;
            // 
            // LunchView
            // 
            this.LunchView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader8});
            this.LunchView.HideSelection = false;
            this.LunchView.Location = new System.Drawing.Point(3, 6);
            this.LunchView.Name = "LunchView";
            this.LunchView.Size = new System.Drawing.Size(233, 356);
            this.LunchView.TabIndex = 1;
            this.LunchView.UseCompatibleStateImageBehavior = false;
            this.LunchView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Item Name";
            this.columnHeader7.Width = 100;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Price";
            this.columnHeader8.Width = 100;
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DinnerPanel);
            this.Controls.Add(this.DrinksPanel);
            this.Controls.Add(this.DrinksButton);
            this.Controls.Add(this.DinnerButton);
            this.Controls.Add(this.LunchButton);
            this.Controls.Add(this.LunchPanel);
            this.Controls.Add(this.DecreaseAmountButton);
            this.Controls.Add(this.MenuItemIDLabel);
            this.Controls.Add(this.MenuItemIDBox);
            this.Controls.Add(this.DecreaseButton);
            this.Controls.Add(this.IncreaseButton);
            this.Controls.Add(this.ViewbyIDLabel);
            this.Controls.Add(this.ViewByIDBox);
            this.Controls.Add(this.SelectOrderButton);
            this.Controls.Add(this.DeleteOrderitemLabel);
            this.Controls.Add(this.DeleteOrderItemBox);
            this.Controls.Add(this.DeleteOrderItemButton);
            this.Controls.Add(this.Messagelabel);
            this.Controls.Add(this.CreateItemButton);
            this.Controls.Add(this.MenuitemCreateLabel);
            this.Controls.Add(this.OrderIDCreatelabel);
            this.Controls.Add(this.CreateMenuitemIDBox);
            this.Controls.Add(this.CreateOrderIDBox);
            this.Controls.Add(this.EditView);
            this.Controls.Add(this.Backbuttonedit);
            this.Name = "EditForm";
            this.Text = "Edit form";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.LunchPanel.ResumeLayout(false);
            this.DinnerPanel.ResumeLayout(false);
            this.DrinksPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Backbuttonedit;
        private System.Windows.Forms.ListView EditView;
        private System.Windows.Forms.TextBox CreateOrderIDBox;
        private System.Windows.Forms.TextBox CreateMenuitemIDBox;
        private System.Windows.Forms.Label OrderIDCreatelabel;
        private System.Windows.Forms.Label MenuitemCreateLabel;
        private System.Windows.Forms.Button CreateItemButton;
        private System.Windows.Forms.Label Messagelabel;
        private System.Windows.Forms.Button DeleteOrderItemButton;
        private System.Windows.Forms.TextBox DeleteOrderItemBox;
        private System.Windows.Forms.Label DeleteOrderitemLabel;
        private System.Windows.Forms.Button SelectOrderButton;
        private System.Windows.Forms.TextBox ViewByIDBox;
        private System.Windows.Forms.Label ViewbyIDLabel;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button IncreaseButton;
        private System.Windows.Forms.Button DecreaseButton;
        private System.Windows.Forms.TextBox MenuItemIDBox;
        private System.Windows.Forms.Label MenuItemIDLabel;
        private System.Windows.Forms.Button DecreaseAmountButton;
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
    }
}