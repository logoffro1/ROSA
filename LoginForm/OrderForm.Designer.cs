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
            this.btnRefresh = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Editbutton = new System.Windows.Forms.Button();
            this.AddOrder = new System.Windows.Forms.Button();
            this.OrderIDbox = new System.Windows.Forms.TextBox();
            this.TableIDbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.lbl_orderWarning = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PayButton
            // 
            this.PayButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PayButton.Location = new System.Drawing.Point(627, 532);
            this.PayButton.Margin = new System.Windows.Forms.Padding(2);
            this.PayButton.Name = "PayButton";
            this.PayButton.Size = new System.Drawing.Size(116, 42);
            this.PayButton.TabIndex = 0;
            this.PayButton.Text = "Pay order";
            this.PayButton.UseVisualStyleBackColor = true;
            this.PayButton.Click += new System.EventHandler(this.PayButton_Click);
            // 
            // OrderView
            // 
            this.OrderView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.OrderID,
            this.Table});
            this.OrderView.HideSelection = false;
            this.OrderView.Location = new System.Drawing.Point(12, 62);
            this.OrderView.Name = "OrderView";
            this.OrderView.Size = new System.Drawing.Size(730, 330);
            this.OrderView.TabIndex = 1;
            this.OrderView.UseCompatibleStateImageBehavior = false;
            this.OrderView.View = System.Windows.Forms.View.Details;
            this.OrderView.SelectedIndexChanged += new System.EventHandler(this.OrderView_SelectedIndexChanged);
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
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(283, 398);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(191, 23);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "Refresh order list";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.button1_Click_1);
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
            this.Editbutton.Location = new System.Drawing.Point(12, 532);
            this.Editbutton.Name = "Editbutton";
            this.Editbutton.Size = new System.Drawing.Size(126, 42);
            this.Editbutton.TabIndex = 4;
            this.Editbutton.Text = "Edit order";
            this.Editbutton.UseVisualStyleBackColor = true;
            this.Editbutton.Click += new System.EventHandler(this.button2_Click);
            // 
            // AddOrder
            // 
            this.AddOrder.Location = new System.Drawing.Point(101, 474);
            this.AddOrder.Name = "AddOrder";
            this.AddOrder.Size = new System.Drawing.Size(144, 37);
            this.AddOrder.TabIndex = 5;
            this.AddOrder.Text = "AddOrder";
            this.AddOrder.UseVisualStyleBackColor = true;
            this.AddOrder.Click += new System.EventHandler(this.AddOrder_Click);
            // 
            // OrderIDbox
            // 
            this.OrderIDbox.Location = new System.Drawing.Point(534, 443);
            this.OrderIDbox.Name = "OrderIDbox";
            this.OrderIDbox.Size = new System.Drawing.Size(130, 20);
            this.OrderIDbox.TabIndex = 6;
            this.OrderIDbox.TextChanged += new System.EventHandler(this.OrderIDbox_TextChanged);
            // 
            // TableIDbox
            // 
            this.TableIDbox.Location = new System.Drawing.Point(101, 443);
            this.TableIDbox.Name = "TableIDbox";
            this.TableIDbox.Size = new System.Drawing.Size(143, 20);
            this.TableIDbox.TabIndex = 7;
            this.TableIDbox.TextChanged += new System.EventHandler(this.TableIDbox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(478, 450);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Order ID:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 450);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Table ID:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // RemoveButton
            // 
            this.RemoveButton.Location = new System.Drawing.Point(534, 469);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(130, 42);
            this.RemoveButton.TabIndex = 12;
            this.RemoveButton.Text = "Remove Order";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // lbl_orderWarning
            // 
            this.lbl_orderWarning.BackColor = System.Drawing.Color.Transparent;
            this.lbl_orderWarning.Location = new System.Drawing.Point(245, 532);
            this.lbl_orderWarning.Name = "lbl_orderWarning";
            this.lbl_orderWarning.Size = new System.Drawing.Size(357, 42);
            this.lbl_orderWarning.TabIndex = 13;
            this.lbl_orderWarning.Click += new System.EventHandler(this.lbl_orderWarning_Click);
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LoginForm.Properties.Resources.BG_TABLESPAGE;
            this.ClientSize = new System.Drawing.Size(754, 586);
            this.Controls.Add(this.lbl_orderWarning);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TableIDbox);
            this.Controls.Add(this.OrderIDbox);
            this.Controls.Add(this.AddOrder);
            this.Controls.Add(this.Editbutton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.OrderView);
            this.Controls.Add(this.PayButton);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "OrderForm";
            this.Text = "Order";
            this.Load += new System.EventHandler(this.OrderForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PayButton;
        private System.Windows.Forms.ListView OrderView;
        private System.Windows.Forms.ColumnHeader OrderID;
        private System.Windows.Forms.ColumnHeader Table;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Editbutton;
        private System.Windows.Forms.Button AddOrder;
        private System.Windows.Forms.TextBox OrderIDbox;
        private System.Windows.Forms.TextBox TableIDbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Label lbl_orderWarning;
    }
}