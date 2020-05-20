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
            this.pnl_payment = new System.Windows.Forms.Panel();
            this.lbl_orderId = new System.Windows.Forms.Label();
            this.lbl_paymentMethodWarning = new System.Windows.Forms.Label();
            this.lbl_PaymentMethod = new System.Windows.Forms.Label();
            this.lbl_tip = new System.Windows.Forms.Label();
            this.textBox_tip = new System.Windows.Forms.TextBox();
            this.lbl_vat = new System.Windows.Forms.Label();
            this.rbtn_credit = new System.Windows.Forms.RadioButton();
            this.rbtn_pin = new System.Windows.Forms.RadioButton();
            this.rbtn_cash = new System.Windows.Forms.RadioButton();
            this.btn_bill = new System.Windows.Forms.Button();
            this.btn_return = new System.Windows.Forms.Button();
            this.textBox_comments = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listView_payments = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbl_totalPrice = new System.Windows.Forms.Label();
            this.lbl_date = new System.Windows.Forms.Label();
            this.lbl_order = new System.Windows.Forms.Label();
            this.lbl_billSuccess = new System.Windows.Forms.Label();
            this.btn_reset = new System.Windows.Forms.Button();
            this.pnl_payment.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_payment
            // 
            this.pnl_payment.Controls.Add(this.lbl_orderId);
            this.pnl_payment.Controls.Add(this.lbl_paymentMethodWarning);
            this.pnl_payment.Controls.Add(this.lbl_PaymentMethod);
            this.pnl_payment.Controls.Add(this.lbl_tip);
            this.pnl_payment.Controls.Add(this.textBox_tip);
            this.pnl_payment.Controls.Add(this.lbl_vat);
            this.pnl_payment.Controls.Add(this.rbtn_credit);
            this.pnl_payment.Controls.Add(this.rbtn_pin);
            this.pnl_payment.Controls.Add(this.rbtn_cash);
            this.pnl_payment.Controls.Add(this.btn_bill);
            this.pnl_payment.Controls.Add(this.btn_return);
            this.pnl_payment.Controls.Add(this.textBox_comments);
            this.pnl_payment.Controls.Add(this.label2);
            this.pnl_payment.Controls.Add(this.listView_payments);
            this.pnl_payment.Controls.Add(this.lbl_totalPrice);
            this.pnl_payment.Controls.Add(this.lbl_date);
            this.pnl_payment.Controls.Add(this.lbl_order);
            this.pnl_payment.Controls.Add(this.lbl_billSuccess);
            this.pnl_payment.Location = new System.Drawing.Point(12, 12);
            this.pnl_payment.Name = "pnl_payment";
            this.pnl_payment.Size = new System.Drawing.Size(736, 517);
            this.pnl_payment.TabIndex = 1;
            // 
            // lbl_orderId
            // 
            this.lbl_orderId.AutoSize = true;
            this.lbl_orderId.Location = new System.Drawing.Point(183, 476);
            this.lbl_orderId.Name = "lbl_orderId";
            this.lbl_orderId.Size = new System.Drawing.Size(35, 13);
            this.lbl_orderId.TabIndex = 36;
            this.lbl_orderId.Text = "label3";
            this.lbl_orderId.Visible = false;
            // 
            // lbl_paymentMethodWarning
            // 
            this.lbl_paymentMethodWarning.ForeColor = System.Drawing.Color.Red;
            this.lbl_paymentMethodWarning.Location = new System.Drawing.Point(513, 260);
            this.lbl_paymentMethodWarning.Name = "lbl_paymentMethodWarning";
            this.lbl_paymentMethodWarning.Size = new System.Drawing.Size(188, 23);
            this.lbl_paymentMethodWarning.TabIndex = 35;
            // 
            // lbl_PaymentMethod
            // 
            this.lbl_PaymentMethod.AutoSize = true;
            this.lbl_PaymentMethod.Location = new System.Drawing.Point(505, 152);
            this.lbl_PaymentMethod.Name = "lbl_PaymentMethod";
            this.lbl_PaymentMethod.Size = new System.Drawing.Size(87, 13);
            this.lbl_PaymentMethod.TabIndex = 34;
            this.lbl_PaymentMethod.Text = "Payment Method";
            // 
            // lbl_tip
            // 
            this.lbl_tip.AutoSize = true;
            this.lbl_tip.Location = new System.Drawing.Point(503, 300);
            this.lbl_tip.Name = "lbl_tip";
            this.lbl_tip.Size = new System.Drawing.Size(22, 13);
            this.lbl_tip.TabIndex = 33;
            this.lbl_tip.Text = "Tip";
            // 
            // textBox_tip
            // 
            this.textBox_tip.Location = new System.Drawing.Point(545, 297);
            this.textBox_tip.Name = "textBox_tip";
            this.textBox_tip.Size = new System.Drawing.Size(156, 20);
            this.textBox_tip.TabIndex = 32;
            // 
            // lbl_vat
            // 
            this.lbl_vat.AutoSize = true;
            this.lbl_vat.Location = new System.Drawing.Point(508, 88);
            this.lbl_vat.Name = "lbl_vat";
            this.lbl_vat.Size = new System.Drawing.Size(28, 13);
            this.lbl_vat.TabIndex = 27;
            this.lbl_vat.Text = "VAT";
            // 
            // rbtn_credit
            // 
            this.rbtn_credit.AutoSize = true;
            this.rbtn_credit.Location = new System.Drawing.Point(508, 232);
            this.rbtn_credit.Name = "rbtn_credit";
            this.rbtn_credit.Size = new System.Drawing.Size(77, 17);
            this.rbtn_credit.TabIndex = 30;
            this.rbtn_credit.TabStop = true;
            this.rbtn_credit.Text = "Credit Card";
            this.rbtn_credit.UseVisualStyleBackColor = true;
            // 
            // rbtn_pin
            // 
            this.rbtn_pin.AutoSize = true;
            this.rbtn_pin.Location = new System.Drawing.Point(508, 206);
            this.rbtn_pin.Name = "rbtn_pin";
            this.rbtn_pin.Size = new System.Drawing.Size(40, 17);
            this.rbtn_pin.TabIndex = 29;
            this.rbtn_pin.TabStop = true;
            this.rbtn_pin.Text = "Pin";
            this.rbtn_pin.UseVisualStyleBackColor = true;
            // 
            // rbtn_cash
            // 
            this.rbtn_cash.AutoSize = true;
            this.rbtn_cash.Location = new System.Drawing.Point(508, 183);
            this.rbtn_cash.Name = "rbtn_cash";
            this.rbtn_cash.Size = new System.Drawing.Size(49, 17);
            this.rbtn_cash.TabIndex = 28;
            this.rbtn_cash.TabStop = true;
            this.rbtn_cash.Text = "Cash";
            this.rbtn_cash.UseVisualStyleBackColor = true;
            // 
            // btn_bill
            // 
            this.btn_bill.Location = new System.Drawing.Point(589, 466);
            this.btn_bill.Name = "btn_bill";
            this.btn_bill.Size = new System.Drawing.Size(112, 23);
            this.btn_bill.TabIndex = 27;
            this.btn_bill.Text = "Pay and Print Bill";
            this.btn_bill.UseVisualStyleBackColor = true;
            this.btn_bill.Click += new System.EventHandler(this.btn_bill_Click);
            // 
            // btn_return
            // 
            this.btn_return.Location = new System.Drawing.Point(29, 467);
            this.btn_return.Name = "btn_return";
            this.btn_return.Size = new System.Drawing.Size(75, 23);
            this.btn_return.TabIndex = 6;
            this.btn_return.Text = "Return";
            this.btn_return.UseVisualStyleBackColor = true;
            // 
            // textBox_comments
            // 
            this.textBox_comments.Location = new System.Drawing.Point(29, 349);
            this.textBox_comments.Multiline = true;
            this.textBox_comments.Name = "textBox_comments";
            this.textBox_comments.Size = new System.Drawing.Size(672, 83);
            this.textBox_comments.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 327);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Comments";
            // 
            // listView_payments
            // 
            this.listView_payments.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView_payments.HideSelection = false;
            this.listView_payments.Location = new System.Drawing.Point(29, 51);
            this.listView_payments.Name = "listView_payments";
            this.listView_payments.Size = new System.Drawing.Size(439, 273);
            this.listView_payments.TabIndex = 3;
            this.listView_payments.UseCompatibleStateImageBehavior = false;
            this.listView_payments.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Item";
            this.columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Quantity";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Price";
            // 
            // lbl_totalPrice
            // 
            this.lbl_totalPrice.AutoSize = true;
            this.lbl_totalPrice.Location = new System.Drawing.Point(505, 51);
            this.lbl_totalPrice.Name = "lbl_totalPrice";
            this.lbl_totalPrice.Size = new System.Drawing.Size(58, 13);
            this.lbl_totalPrice.TabIndex = 2;
            this.lbl_totalPrice.Text = "Total Price";
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Location = new System.Drawing.Point(235, 22);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(30, 13);
            this.lbl_date.TabIndex = 1;
            this.lbl_date.Text = "Date";
            // 
            // lbl_order
            // 
            this.lbl_order.AutoSize = true;
            this.lbl_order.Location = new System.Drawing.Point(38, 23);
            this.lbl_order.Name = "lbl_order";
            this.lbl_order.Size = new System.Drawing.Size(34, 13);
            this.lbl_order.TabIndex = 0;
            this.lbl_order.Text = "Table";
            // 
            // lbl_billSuccess
            // 
            this.lbl_billSuccess.AutoSize = true;
            this.lbl_billSuccess.Location = new System.Drawing.Point(606, 472);
            this.lbl_billSuccess.Name = "lbl_billSuccess";
            this.lbl_billSuccess.Size = new System.Drawing.Size(75, 13);
            this.lbl_billSuccess.TabIndex = 27;
            this.lbl_billSuccess.Text = "Bill Successful";
            this.lbl_billSuccess.Visible = false;
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(771, 35);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(75, 23);
            this.btn_reset.TabIndex = 2;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // paymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 555);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.pnl_payment);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Payment";
            this.Text = "Payment";
            this.Load += new System.EventHandler(this.paymentForm_Load);
            this.pnl_payment.ResumeLayout(false);
            this.pnl_payment.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_payment;
        private System.Windows.Forms.Label lbl_orderId;
        private System.Windows.Forms.Label lbl_paymentMethodWarning;
        private System.Windows.Forms.Label lbl_PaymentMethod;
        private System.Windows.Forms.Label lbl_tip;
        private System.Windows.Forms.TextBox textBox_tip;
        private System.Windows.Forms.Label lbl_vat;
        private System.Windows.Forms.RadioButton rbtn_credit;
        private System.Windows.Forms.RadioButton rbtn_pin;
        private System.Windows.Forms.RadioButton rbtn_cash;
        private System.Windows.Forms.Button btn_bill;
        private System.Windows.Forms.Button btn_return;
        private System.Windows.Forms.TextBox textBox_comments;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listView_payments;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label lbl_totalPrice;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.Label lbl_order;
        private System.Windows.Forms.Label lbl_billSuccess;
        private System.Windows.Forms.Button btn_reset;
    }
}