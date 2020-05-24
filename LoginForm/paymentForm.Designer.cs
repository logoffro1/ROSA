namespace LoginForm
{
    partial class paymentForm
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
            this.lbl_paymentMethodWarning = new System.Windows.Forms.Label();
            this.lbl_PaymentMethod = new System.Windows.Forms.Label();
            this.lbl_tip = new System.Windows.Forms.Label();
            this.textBox_tip = new System.Windows.Forms.TextBox();
            this.lbl_vat_static = new System.Windows.Forms.Label();
            this.rbtn_credit = new System.Windows.Forms.RadioButton();
            this.rbtn_pin = new System.Windows.Forms.RadioButton();
            this.rbtn_cash = new System.Windows.Forms.RadioButton();
            this.btn_bill = new System.Windows.Forms.Button();
            this.btn_return = new System.Windows.Forms.Button();
            this.textBox_comments = new System.Windows.Forms.TextBox();
            this.lbl_commentStatic = new System.Windows.Forms.Label();
            this.listView_payments = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbl_orderPrice_static = new System.Windows.Forms.Label();
            this.lbl_date = new System.Windows.Forms.Label();
            this.lbl_paymentTable = new System.Windows.Forms.Label();
            this.lbl_billSuccess = new System.Windows.Forms.Label();
            this.pnl_payment_price = new System.Windows.Forms.Panel();
            this.textBox_totalPrice = new System.Windows.Forms.TextBox();
            this.lbl_totalPrice_static = new System.Windows.Forms.Label();
            this.lbl_vat = new System.Windows.Forms.Label();
            this.lbl_orderPrice = new System.Windows.Forms.Label();
            this.pnl_payment_method = new System.Windows.Forms.Panel();
            this.lbl_price = new System.Windows.Forms.Label();
            this.lbl_payment_tableStatic = new System.Windows.Forms.Label();
            this.lbl_payment_datestatic = new System.Windows.Forms.Label();
            this.pnl_payment_price.SuspendLayout();
            this.pnl_payment_method.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_paymentMethodWarning
            // 
            this.lbl_paymentMethodWarning.BackColor = System.Drawing.Color.Transparent;
            this.lbl_paymentMethodWarning.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_paymentMethodWarning.ForeColor = System.Drawing.Color.Red;
            this.lbl_paymentMethodWarning.Location = new System.Drawing.Point(219, 501);
            this.lbl_paymentMethodWarning.Name = "lbl_paymentMethodWarning";
            this.lbl_paymentMethodWarning.Size = new System.Drawing.Size(339, 45);
            this.lbl_paymentMethodWarning.TabIndex = 35;
            // 
            // lbl_PaymentMethod
            // 
            this.lbl_PaymentMethod.AutoSize = true;
            this.lbl_PaymentMethod.BackColor = System.Drawing.Color.Transparent;
            this.lbl_PaymentMethod.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PaymentMethod.Location = new System.Drawing.Point(581, 332);
            this.lbl_PaymentMethod.Name = "lbl_PaymentMethod";
            this.lbl_PaymentMethod.Size = new System.Drawing.Size(168, 23);
            this.lbl_PaymentMethod.TabIndex = 34;
            this.lbl_PaymentMethod.Text = "Payment Method";
            // 
            // lbl_tip
            // 
            this.lbl_tip.AutoSize = true;
            this.lbl_tip.BackColor = System.Drawing.Color.Transparent;
            this.lbl_tip.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tip.Location = new System.Drawing.Point(18, 89);
            this.lbl_tip.Name = "lbl_tip";
            this.lbl_tip.Size = new System.Drawing.Size(34, 22);
            this.lbl_tip.TabIndex = 33;
            this.lbl_tip.Text = "Tip";
            // 
            // textBox_tip
            // 
            this.textBox_tip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBox_tip.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_tip.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox_tip.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_tip.Location = new System.Drawing.Point(58, 91);
            this.textBox_tip.Name = "textBox_tip";
            this.textBox_tip.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox_tip.Size = new System.Drawing.Size(156, 20);
            this.textBox_tip.TabIndex = 32;
            this.textBox_tip.Text = "0.00";
            this.textBox_tip.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_tip.TextChanged += new System.EventHandler(this.textBox_tip_TextChanged);
            // 
            // lbl_vat_static
            // 
            this.lbl_vat_static.AutoSize = true;
            this.lbl_vat_static.BackColor = System.Drawing.Color.Transparent;
            this.lbl_vat_static.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_vat_static.Location = new System.Drawing.Point(18, 54);
            this.lbl_vat_static.Name = "lbl_vat_static";
            this.lbl_vat_static.Size = new System.Drawing.Size(48, 22);
            this.lbl_vat_static.TabIndex = 27;
            this.lbl_vat_static.Text = "VAT";
            // 
            // rbtn_credit
            // 
            this.rbtn_credit.AutoSize = true;
            this.rbtn_credit.BackColor = System.Drawing.Color.Transparent;
            this.rbtn_credit.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_credit.Location = new System.Drawing.Point(11, 74);
            this.rbtn_credit.Name = "rbtn_credit";
            this.rbtn_credit.Size = new System.Drawing.Size(136, 26);
            this.rbtn_credit.TabIndex = 30;
            this.rbtn_credit.TabStop = true;
            this.rbtn_credit.Text = "Credit Card";
            this.rbtn_credit.UseVisualStyleBackColor = false;
            // 
            // rbtn_pin
            // 
            this.rbtn_pin.AutoSize = true;
            this.rbtn_pin.BackColor = System.Drawing.Color.Transparent;
            this.rbtn_pin.Checked = true;
            this.rbtn_pin.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_pin.Location = new System.Drawing.Point(11, 10);
            this.rbtn_pin.Name = "rbtn_pin";
            this.rbtn_pin.Size = new System.Drawing.Size(54, 26);
            this.rbtn_pin.TabIndex = 29;
            this.rbtn_pin.TabStop = true;
            this.rbtn_pin.Text = "Pin";
            this.rbtn_pin.UseVisualStyleBackColor = false;
            // 
            // rbtn_cash
            // 
            this.rbtn_cash.AutoSize = true;
            this.rbtn_cash.BackColor = System.Drawing.Color.Transparent;
            this.rbtn_cash.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_cash.Location = new System.Drawing.Point(11, 42);
            this.rbtn_cash.Name = "rbtn_cash";
            this.rbtn_cash.Size = new System.Drawing.Size(75, 26);
            this.rbtn_cash.TabIndex = 28;
            this.rbtn_cash.TabStop = true;
            this.rbtn_cash.Text = "Cash";
            this.rbtn_cash.UseVisualStyleBackColor = false;
            // 
            // btn_bill
            // 
            this.btn_bill.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_bill.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_bill.ForeColor = System.Drawing.Color.White;
            this.btn_bill.Location = new System.Drawing.Point(574, 495);
            this.btn_bill.Name = "btn_bill";
            this.btn_bill.Size = new System.Drawing.Size(257, 36);
            this.btn_bill.TabIndex = 27;
            this.btn_bill.Text = "Pay and Print Bill";
            this.btn_bill.UseVisualStyleBackColor = false;
            this.btn_bill.Click += new System.EventHandler(this.btn_bill_Click);
            // 
            // btn_return
            // 
            this.btn_return.BackColor = System.Drawing.Color.Firebrick;
            this.btn_return.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_return.ForeColor = System.Drawing.Color.White;
            this.btn_return.Location = new System.Drawing.Point(29, 495);
            this.btn_return.Name = "btn_return";
            this.btn_return.Size = new System.Drawing.Size(107, 36);
            this.btn_return.TabIndex = 6;
            this.btn_return.Text = "Return";
            this.btn_return.UseVisualStyleBackColor = false;
            this.btn_return.Click += new System.EventHandler(this.btn_return_Click);
            // 
            // textBox_comments
            // 
            this.textBox_comments.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_comments.Location = new System.Drawing.Point(29, 357);
            this.textBox_comments.Multiline = true;
            this.textBox_comments.Name = "textBox_comments";
            this.textBox_comments.Size = new System.Drawing.Size(529, 112);
            this.textBox_comments.TabIndex = 5;
            // 
            // lbl_commentStatic
            // 
            this.lbl_commentStatic.AutoSize = true;
            this.lbl_commentStatic.BackColor = System.Drawing.Color.Transparent;
            this.lbl_commentStatic.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_commentStatic.Location = new System.Drawing.Point(37, 332);
            this.lbl_commentStatic.Name = "lbl_commentStatic";
            this.lbl_commentStatic.Size = new System.Drawing.Size(105, 23);
            this.lbl_commentStatic.TabIndex = 4;
            this.lbl_commentStatic.Text = "Feedback";
            // 
            // listView_payments
            // 
            this.listView_payments.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView_payments.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView_payments.HideSelection = false;
            this.listView_payments.Location = new System.Drawing.Point(29, 51);
            this.listView_payments.Name = "listView_payments";
            this.listView_payments.Size = new System.Drawing.Size(529, 262);
            this.listView_payments.TabIndex = 3;
            this.listView_payments.UseCompatibleStateImageBehavior = false;
            this.listView_payments.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Item";
            this.columnHeader1.Width = 355;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Quantity";
            this.columnHeader2.Width = 109;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Price";
            // 
            // lbl_orderPrice_static
            // 
            this.lbl_orderPrice_static.AutoSize = true;
            this.lbl_orderPrice_static.BackColor = System.Drawing.Color.Transparent;
            this.lbl_orderPrice_static.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_orderPrice_static.Location = new System.Drawing.Point(18, 23);
            this.lbl_orderPrice_static.Name = "lbl_orderPrice_static";
            this.lbl_orderPrice_static.Size = new System.Drawing.Size(113, 22);
            this.lbl_orderPrice_static.TabIndex = 2;
            this.lbl_orderPrice_static.Text = "Order Price";
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.BackColor = System.Drawing.Color.Transparent;
            this.lbl_date.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_date.Location = new System.Drawing.Point(218, 21);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(0, 22);
            this.lbl_date.TabIndex = 1;
            // 
            // lbl_paymentTable
            // 
            this.lbl_paymentTable.AutoSize = true;
            this.lbl_paymentTable.BackColor = System.Drawing.Color.Transparent;
            this.lbl_paymentTable.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_paymentTable.Location = new System.Drawing.Point(90, 21);
            this.lbl_paymentTable.Name = "lbl_paymentTable";
            this.lbl_paymentTable.Size = new System.Drawing.Size(0, 24);
            this.lbl_paymentTable.TabIndex = 0;
            // 
            // lbl_billSuccess
            // 
            this.lbl_billSuccess.AutoSize = true;
            this.lbl_billSuccess.BackColor = System.Drawing.Color.Transparent;
            this.lbl_billSuccess.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_billSuccess.ForeColor = System.Drawing.Color.DarkGreen;
            this.lbl_billSuccess.Location = new System.Drawing.Point(647, 502);
            this.lbl_billSuccess.Name = "lbl_billSuccess";
            this.lbl_billSuccess.Size = new System.Drawing.Size(127, 22);
            this.lbl_billSuccess.TabIndex = 27;
            this.lbl_billSuccess.Text = "Bill Successful";
            this.lbl_billSuccess.Visible = false;
            // 
            // pnl_payment_price
            // 
            this.pnl_payment_price.AutoSize = true;
            this.pnl_payment_price.BackColor = System.Drawing.Color.White;
            this.pnl_payment_price.Controls.Add(this.textBox_totalPrice);
            this.pnl_payment_price.Controls.Add(this.lbl_totalPrice_static);
            this.pnl_payment_price.Controls.Add(this.lbl_vat);
            this.pnl_payment_price.Controls.Add(this.lbl_orderPrice);
            this.pnl_payment_price.Controls.Add(this.lbl_vat_static);
            this.pnl_payment_price.Controls.Add(this.lbl_tip);
            this.pnl_payment_price.Controls.Add(this.lbl_orderPrice_static);
            this.pnl_payment_price.Controls.Add(this.textBox_tip);
            this.pnl_payment_price.Location = new System.Drawing.Point(574, 51);
            this.pnl_payment_price.Name = "pnl_payment_price";
            this.pnl_payment_price.Size = new System.Drawing.Size(257, 262);
            this.pnl_payment_price.TabIndex = 37;
            // 
            // textBox_totalPrice
            // 
            this.textBox_totalPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBox_totalPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_totalPrice.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox_totalPrice.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_totalPrice.Location = new System.Drawing.Point(49, 183);
            this.textBox_totalPrice.Name = "textBox_totalPrice";
            this.textBox_totalPrice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox_totalPrice.Size = new System.Drawing.Size(156, 20);
            this.textBox_totalPrice.TabIndex = 37;
            this.textBox_totalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_totalPrice.TextChanged += new System.EventHandler(this.textBox_totalPrice_TextChanged);
            // 
            // lbl_totalPrice_static
            // 
            this.lbl_totalPrice_static.AutoSize = true;
            this.lbl_totalPrice_static.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_totalPrice_static.Location = new System.Drawing.Point(73, 157);
            this.lbl_totalPrice_static.Name = "lbl_totalPrice_static";
            this.lbl_totalPrice_static.Size = new System.Drawing.Size(107, 23);
            this.lbl_totalPrice_static.TabIndex = 36;
            this.lbl_totalPrice_static.Text = "Total price";
            // 
            // lbl_vat
            // 
            this.lbl_vat.AutoSize = true;
            this.lbl_vat.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_vat.Location = new System.Drawing.Point(150, 61);
            this.lbl_vat.Name = "lbl_vat";
            this.lbl_vat.Size = new System.Drawing.Size(0, 21);
            this.lbl_vat.TabIndex = 35;
            // 
            // lbl_orderPrice
            // 
            this.lbl_orderPrice.AutoSize = true;
            this.lbl_orderPrice.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_orderPrice.Location = new System.Drawing.Point(150, 23);
            this.lbl_orderPrice.Name = "lbl_orderPrice";
            this.lbl_orderPrice.Size = new System.Drawing.Size(0, 21);
            this.lbl_orderPrice.TabIndex = 34;
            // 
            // pnl_payment_method
            // 
            this.pnl_payment_method.BackColor = System.Drawing.Color.White;
            this.pnl_payment_method.Controls.Add(this.rbtn_cash);
            this.pnl_payment_method.Controls.Add(this.rbtn_pin);
            this.pnl_payment_method.Controls.Add(this.rbtn_credit);
            this.pnl_payment_method.Location = new System.Drawing.Point(574, 357);
            this.pnl_payment_method.Name = "pnl_payment_method";
            this.pnl_payment_method.Size = new System.Drawing.Size(257, 112);
            this.pnl_payment_method.TabIndex = 38;
            // 
            // lbl_price
            // 
            this.lbl_price.AutoSize = true;
            this.lbl_price.BackColor = System.Drawing.Color.Transparent;
            this.lbl_price.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_price.Location = new System.Drawing.Point(583, 21);
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.Size = new System.Drawing.Size(56, 23);
            this.lbl_price.TabIndex = 39;
            this.lbl_price.Text = "Price";
            // 
            // lbl_payment_tableStatic
            // 
            this.lbl_payment_tableStatic.AutoSize = true;
            this.lbl_payment_tableStatic.BackColor = System.Drawing.Color.Transparent;
            this.lbl_payment_tableStatic.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_payment_tableStatic.Location = new System.Drawing.Point(25, 21);
            this.lbl_payment_tableStatic.Name = "lbl_payment_tableStatic";
            this.lbl_payment_tableStatic.Size = new System.Drawing.Size(67, 25);
            this.lbl_payment_tableStatic.TabIndex = 40;
            this.lbl_payment_tableStatic.Text = "Table";
            // 
            // lbl_payment_datestatic
            // 
            this.lbl_payment_datestatic.AutoSize = true;
            this.lbl_payment_datestatic.BackColor = System.Drawing.Color.Transparent;
            this.lbl_payment_datestatic.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_payment_datestatic.Location = new System.Drawing.Point(159, 21);
            this.lbl_payment_datestatic.Name = "lbl_payment_datestatic";
            this.lbl_payment_datestatic.Size = new System.Drawing.Size(60, 25);
            this.lbl_payment_datestatic.TabIndex = 41;
            this.lbl_payment_datestatic.Text = "Date";
            // 
            // paymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LoginForm.Properties.Resources.HOME_BG;
            this.ClientSize = new System.Drawing.Size(856, 555);
            this.Controls.Add(this.lbl_payment_datestatic);
            this.Controls.Add(this.lbl_payment_tableStatic);
            this.Controls.Add(this.lbl_price);
            this.Controls.Add(this.lbl_PaymentMethod);
            this.Controls.Add(this.lbl_paymentMethodWarning);
            this.Controls.Add(this.btn_return);
            this.Controls.Add(this.btn_bill);
            this.Controls.Add(this.lbl_billSuccess);
            this.Controls.Add(this.lbl_commentStatic);
            this.Controls.Add(this.listView_payments);
            this.Controls.Add(this.textBox_comments);
            this.Controls.Add(this.lbl_paymentTable);
            this.Controls.Add(this.lbl_date);
            this.Controls.Add(this.pnl_payment_method);
            this.Controls.Add(this.pnl_payment_price);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "paymentForm";
            this.Text = "Payment";
            this.pnl_payment_price.ResumeLayout(false);
            this.pnl_payment_price.PerformLayout();
            this.pnl_payment_method.ResumeLayout(false);
            this.pnl_payment_method.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_paymentMethodWarning;
        private System.Windows.Forms.Label lbl_PaymentMethod;
        private System.Windows.Forms.Label lbl_tip;
        private System.Windows.Forms.TextBox textBox_tip;
        private System.Windows.Forms.Label lbl_vat_static;
        private System.Windows.Forms.RadioButton rbtn_credit;
        private System.Windows.Forms.RadioButton rbtn_pin;
        private System.Windows.Forms.RadioButton rbtn_cash;
        private System.Windows.Forms.Button btn_bill;
        private System.Windows.Forms.Button btn_return;
        private System.Windows.Forms.TextBox textBox_comments;
        private System.Windows.Forms.Label lbl_commentStatic;
        private System.Windows.Forms.ListView listView_payments;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label lbl_orderPrice_static;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.Label lbl_paymentTable;
        private System.Windows.Forms.Label lbl_billSuccess;
        private System.Windows.Forms.Panel pnl_payment_price;
        private System.Windows.Forms.Panel pnl_payment_method;
        private System.Windows.Forms.Label lbl_vat;
        private System.Windows.Forms.Label lbl_orderPrice;
        private System.Windows.Forms.Label lbl_price;
        private System.Windows.Forms.Label lbl_totalPrice_static;
        private System.Windows.Forms.Label lbl_payment_tableStatic;
        private System.Windows.Forms.Label lbl_payment_datestatic;
        private System.Windows.Forms.TextBox textBox_totalPrice;
    }
}