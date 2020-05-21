namespace LoginForm
{
    partial class OrderForm
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
            this.PayButton = new System.Windows.Forms.Button();
            this.OrderView = new System.Windows.Forms.ListView();
            this.OrderID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Table = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Refresh = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Editbutton = new System.Windows.Forms.Button();
            this.AddOrder = new System.Windows.Forms.Button();
            this.OrderIDbox = new System.Windows.Forms.TextBox();
            this.TableIDbox = new System.Windows.Forms.TextBox();
            this.EmployeeIDbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PayButton
            // 
            this.PayButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PayButton.Location = new System.Drawing.Point(467, 321);
            this.PayButton.Margin = new System.Windows.Forms.Padding(2);
            this.PayButton.Name = "PayButton";
            this.PayButton.Size = new System.Drawing.Size(122, 34);
            this.PayButton.TabIndex = 0;
            this.PayButton.Text = "Pay order";
            this.PayButton.UseVisualStyleBackColor = true;
            this.PayButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // OrderView
            // 
            this.OrderView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.OrderID,
            this.Table});
            this.OrderView.HideSelection = false;
            this.OrderView.Location = new System.Drawing.Point(12, 62);
            this.OrderView.Name = "OrderView";
            this.OrderView.Size = new System.Drawing.Size(365, 192);
            this.OrderView.TabIndex = 1;
            this.OrderView.UseCompatibleStateImageBehavior = false;
            this.OrderView.View = System.Windows.Forms.View.Details;
            // 
            // OrderID
            // 
            this.OrderID.Text = "Order";
            this.OrderID.Width = 108;
            // 
            // Table
            // 
            this.Table.Text = "Table";
            this.Table.Width = 127;
            // 
            // Refresh
            // 
            this.Refresh.Location = new System.Drawing.Point(386, 231);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(191, 23);
            this.Refresh.TabIndex = 2;
            this.Refresh.Text = "Refresh order list";
            this.Refresh.UseVisualStyleBackColor = true;
            this.Refresh.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Back to main";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // Editbutton
            // 
            this.Editbutton.Location = new System.Drawing.Point(12, 320);
            this.Editbutton.Name = "Editbutton";
            this.Editbutton.Size = new System.Drawing.Size(105, 34);
            this.Editbutton.TabIndex = 4;
            this.Editbutton.Text = "Edit order";
            this.Editbutton.UseVisualStyleBackColor = true;
            this.Editbutton.Click += new System.EventHandler(this.button2_Click);
            // 
            // AddOrder
            // 
            this.AddOrder.Location = new System.Drawing.Point(386, 139);
            this.AddOrder.Name = "AddOrder";
            this.AddOrder.Size = new System.Drawing.Size(75, 23);
            this.AddOrder.TabIndex = 5;
            this.AddOrder.Text = "AddOrder";
            this.AddOrder.UseVisualStyleBackColor = true;
            this.AddOrder.Click += new System.EventHandler(this.AddOrder_Click);
            // 
            // OrderIDbox
            // 
            this.OrderIDbox.Location = new System.Drawing.Point(235, 280);
            this.OrderIDbox.Name = "OrderIDbox";
            this.OrderIDbox.Size = new System.Drawing.Size(100, 20);
            this.OrderIDbox.TabIndex = 6;
            // 
            // TableIDbox
            // 
            this.TableIDbox.Location = new System.Drawing.Point(467, 55);
            this.TableIDbox.Name = "TableIDbox";
            this.TableIDbox.Size = new System.Drawing.Size(100, 20);
            this.TableIDbox.TabIndex = 7;
            // 
            // EmployeeIDbox
            // 
            this.EmployeeIDbox.Location = new System.Drawing.Point(467, 94);
            this.EmployeeIDbox.Name = "EmployeeIDbox";
            this.EmployeeIDbox.Size = new System.Drawing.Size(100, 20);
            this.EmployeeIDbox.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(179, 287);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Order ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(383, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Table ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(383, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Employee ID:";
            // 
            // RemoveButton
            // 
            this.RemoveButton.Location = new System.Drawing.Point(12, 277);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(131, 23);
            this.RemoveButton.TabIndex = 12;
            this.RemoveButton.Text = "Remove Order";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EmployeeIDbox);
            this.Controls.Add(this.TableIDbox);
            this.Controls.Add(this.OrderIDbox);
            this.Controls.Add(this.AddOrder);
            this.Controls.Add(this.Editbutton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Refresh);
            this.Controls.Add(this.OrderView);
            this.Controls.Add(this.PayButton);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "OrderForm";
            this.Text = "Order";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PayButton;
        private System.Windows.Forms.ListView OrderView;
        private System.Windows.Forms.ColumnHeader OrderID;
        private System.Windows.Forms.ColumnHeader Table;
        private System.Windows.Forms.Button Refresh;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Editbutton;
        private System.Windows.Forms.Button AddOrder;
        private System.Windows.Forms.TextBox OrderIDbox;
        private System.Windows.Forms.TextBox TableIDbox;
        private System.Windows.Forms.TextBox EmployeeIDbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button RemoveButton;
    }
}