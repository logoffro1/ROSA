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
            this.textBox_totalPrice = new System.Windows.Forms.TextBox();
            this.lbl_totalPrice_static = new System.Windows.Forms.Label();
            this.lbl_vat = new System.Windows.Forms.Label();
            this.lbl_orderPrice = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.pnl_payment_method = new System.Windows.Forms.Panel();
            this.lbl_payment_tableStatic = new System.Windows.Forms.Label();
            this.lbl_payment_datestatic = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnl_payment_method.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_paymentMethodWarning
            // 
            this.lbl_paymentMethodWarning.BackColor = System.Drawing.Color.Transparent;
            this.lbl_paymentMethodWarning.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_paymentMethodWarning.ForeColor = System.Drawing.Color.Red;
            this.lbl_paymentMethodWarning.Location = new System.Drawing.Point(499, 320);
            this.lbl_paymentMethodWarning.Name = "lbl_paymentMethodWarning";
            this.lbl_paymentMethodWarning.Size = new System.Drawing.Size(235, 53);
            this.lbl_paymentMethodWarning.TabIndex = 35;
            this.lbl_paymentMethodWarning.Click += new System.EventHandler(this.lbl_paymentMethodWarning_Click);
            // 
            // lbl_PaymentMethod
            // 
            this.lbl_PaymentMethod.AutoSize = true;
            this.lbl_PaymentMethod.BackColor = System.Drawing.Color.Transparent;
            this.lbl_PaymentMethod.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PaymentMethod.Location = new System.Drawing.Point(517, 373);
            this.lbl_PaymentMethod.Name = "lbl_PaymentMethod";
            this.lbl_PaymentMethod.Size = new System.Drawing.Size(186, 25);
            this.lbl_PaymentMethod.TabIndex = 34;
            this.lbl_PaymentMethod.Text = "Payment Method";
            // 
            // lbl_tip
            // 
            this.lbl_tip.AutoSize = true;
            this.lbl_tip.BackColor = System.Drawing.Color.Transparent;
            this.lbl_tip.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tip.Location = new System.Drawing.Point(291, 452);
            this.lbl_tip.Name = "lbl_tip";
            this.lbl_tip.Size = new System.Drawing.Size(33, 22);
            this.lbl_tip.TabIndex = 33;
            this.lbl_tip.Text = "Tip";
            // 
            // textBox_tip
            // 
            this.textBox_tip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.textBox_tip.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_tip.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox_tip.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_tip.Location = new System.Drawing.Point(344, 450);
            this.textBox_tip.MaxLength = 6;
            this.textBox_tip.Name = "textBox_tip";
            this.textBox_tip.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox_tip.Size = new System.Drawing.Size(76, 24);
            this.textBox_tip.TabIndex = 32;
            this.textBox_tip.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox_tip.TextChanged += new System.EventHandler(this.textBox_tip_TextChanged);
            // 
            // lbl_vat_static
            // 
            this.lbl_vat_static.AutoSize = true;
            this.lbl_vat_static.BackColor = System.Drawing.Color.Transparent;
            this.lbl_vat_static.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_vat_static.Location = new System.Drawing.Point(277, 416);
            this.lbl_vat_static.Name = "lbl_vat_static";
            this.lbl_vat_static.Size = new System.Drawing.Size(43, 22);
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
            this.rbtn_pin.Location = new System.Drawing.Point(12, 10);
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
            this.btn_bill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_bill.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_bill.ForeColor = System.Drawing.Color.White;
            this.btn_bill.Location = new System.Drawing.Point(499, 538);
            this.btn_bill.Name = "btn_bill";
            this.btn_bill.Size = new System.Drawing.Size(236, 36);
            this.btn_bill.TabIndex = 27;
            this.btn_bill.Text = "Pay and Print Bill";
            this.btn_bill.UseVisualStyleBackColor = false;
            this.btn_bill.Click += new System.EventHandler(this.btn_bill_Click);
            // 
            // btn_return
            // 
            this.btn_return.BackColor = System.Drawing.Color.Firebrick;
            this.btn_return.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_return.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_return.ForeColor = System.Drawing.Color.White;
            this.btn_return.Location = new System.Drawing.Point(5, 6);
            this.btn_return.Name = "btn_return";
            this.btn_return.Size = new System.Drawing.Size(85, 30);
            this.btn_return.TabIndex = 6;
            this.btn_return.Text = "Return";
            this.btn_return.UseVisualStyleBackColor = false;
            this.btn_return.Click += new System.EventHandler(this.btn_return_Click);
            // 
            // textBox_comments
            // 
            this.textBox_comments.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(247)))), ((int)(((byte)(233)))));
            this.textBox_comments.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_comments.Location = new System.Drawing.Point(510, 63);
            this.textBox_comments.Multiline = true;
            this.textBox_comments.Name = "textBox_comments";
            this.textBox_comments.Size = new System.Drawing.Size(212, 238);
            this.textBox_comments.TabIndex = 5;
            // 
            // lbl_commentStatic
            // 
            this.lbl_commentStatic.AutoSize = true;
            this.lbl_commentStatic.BackColor = System.Drawing.Color.Transparent;
            this.lbl_commentStatic.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_commentStatic.Location = new System.Drawing.Point(547, 21);
            this.lbl_commentStatic.Name = "lbl_commentStatic";
            this.lbl_commentStatic.Size = new System.Drawing.Size(115, 25);
            this.lbl_commentStatic.TabIndex = 4;
            this.lbl_commentStatic.Text = "Feedback";
            // 
            // listView_payments
            // 
            this.listView_payments.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(247)))), ((int)(((byte)(233)))));
            this.listView_payments.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView_payments.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView_payments.HideSelection = false;
            this.listView_payments.Location = new System.Drawing.Point(11, 15);
            this.listView_payments.Name = "listView_payments";
            this.listView_payments.Size = new System.Drawing.Size(422, 355);
            this.listView_payments.TabIndex = 3;
            this.listView_payments.UseCompatibleStateImageBehavior = false;
            this.listView_payments.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Item";
            this.columnHeader1.Width = 230;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Quantity";
            this.columnHeader2.Width = 109;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Price";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader3.Width = 79;
            // 
            // lbl_orderPrice_static
            // 
            this.lbl_orderPrice_static.AutoSize = true;
            this.lbl_orderPrice_static.BackColor = System.Drawing.Color.Transparent;
            this.lbl_orderPrice_static.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_orderPrice_static.Location = new System.Drawing.Point(212, 384);
            this.lbl_orderPrice_static.Name = "lbl_orderPrice_static";
            this.lbl_orderPrice_static.Size = new System.Drawing.Size(114, 22);
            this.lbl_orderPrice_static.TabIndex = 2;
            this.lbl_orderPrice_static.Text = "Order Price";
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.BackColor = System.Drawing.Color.Transparent;
            this.lbl_date.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_date.Location = new System.Drawing.Point(267, 23);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(0, 22);
            this.lbl_date.TabIndex = 1;
            // 
            // lbl_paymentTable
            // 
            this.lbl_paymentTable.AutoSize = true;
            this.lbl_paymentTable.BackColor = System.Drawing.Color.Transparent;
            this.lbl_paymentTable.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_paymentTable.Location = new System.Drawing.Point(177, 21);
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
            this.lbl_billSuccess.Location = new System.Drawing.Point(548, 545);
            this.lbl_billSuccess.Name = "lbl_billSuccess";
            this.lbl_billSuccess.Size = new System.Drawing.Size(127, 22);
            this.lbl_billSuccess.TabIndex = 27;
            this.lbl_billSuccess.Text = "Bill Successful";
            this.lbl_billSuccess.Visible = false;
            // 
            // textBox_totalPrice
            // 
            this.textBox_totalPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.textBox_totalPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_totalPrice.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox_totalPrice.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_totalPrice.Location = new System.Drawing.Point(344, 490);
            this.textBox_totalPrice.Name = "textBox_totalPrice";
            this.textBox_totalPrice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox_totalPrice.Size = new System.Drawing.Size(76, 24);
            this.textBox_totalPrice.TabIndex = 37;
            this.textBox_totalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox_totalPrice.TextChanged += new System.EventHandler(this.textBox_totalPrice_TextChanged);
            // 
            // lbl_totalPrice_static
            // 
            this.lbl_totalPrice_static.AutoSize = true;
            this.lbl_totalPrice_static.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_totalPrice_static.Location = new System.Drawing.Point(127, 491);
            this.lbl_totalPrice_static.Name = "lbl_totalPrice_static";
            this.lbl_totalPrice_static.Size = new System.Drawing.Size(204, 23);
            this.lbl_totalPrice_static.TabIndex = 36;
            this.lbl_totalPrice_static.Text = "Total price (incl. VAT)";
            // 
            // lbl_vat
            // 
            this.lbl_vat.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_vat.Location = new System.Drawing.Point(344, 416);
            this.lbl_vat.Name = "lbl_vat";
            this.lbl_vat.Size = new System.Drawing.Size(85, 24);
            this.lbl_vat.TabIndex = 35;
            this.lbl_vat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_orderPrice
            // 
            this.lbl_orderPrice.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_orderPrice.Location = new System.Drawing.Point(344, 384);
            this.lbl_orderPrice.Name = "lbl_orderPrice";
            this.lbl_orderPrice.Size = new System.Drawing.Size(85, 24);
            this.lbl_orderPrice.TabIndex = 34;
            this.lbl_orderPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(356, 450);
            this.textBox1.MaxLength = 6;
            this.textBox1.Name = "textBox1";
            this.textBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox1.Size = new System.Drawing.Size(76, 24);
            this.textBox1.TabIndex = 38;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox2.Enabled = false;
            this.textBox2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(356, 490);
            this.textBox2.MaxLength = 6;
            this.textBox2.Name = "textBox2";
            this.textBox2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox2.Size = new System.Drawing.Size(76, 24);
            this.textBox2.TabIndex = 39;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // pnl_payment_method
            // 
            this.pnl_payment_method.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(247)))), ((int)(((byte)(233)))));
            this.pnl_payment_method.Controls.Add(this.rbtn_cash);
            this.pnl_payment_method.Controls.Add(this.rbtn_pin);
            this.pnl_payment_method.Controls.Add(this.rbtn_credit);
            this.pnl_payment_method.Location = new System.Drawing.Point(11, 9);
            this.pnl_payment_method.Name = "pnl_payment_method";
            this.pnl_payment_method.Size = new System.Drawing.Size(212, 112);
            this.pnl_payment_method.TabIndex = 38;
            // 
            // lbl_payment_tableStatic
            // 
            this.lbl_payment_tableStatic.AutoSize = true;
            this.lbl_payment_tableStatic.BackColor = System.Drawing.Color.Transparent;
            this.lbl_payment_tableStatic.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_payment_tableStatic.Location = new System.Drawing.Point(110, 21);
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
            this.lbl_payment_datestatic.Location = new System.Drawing.Point(207, 20);
            this.lbl_payment_datestatic.Name = "lbl_payment_datestatic";
            this.lbl_payment_datestatic.Size = new System.Drawing.Size(60, 25);
            this.lbl_payment_datestatic.TabIndex = 41;
            this.lbl_payment_datestatic.Text = "Date";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(214)))), ((int)(((byte)(148)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lbl_orderPrice);
            this.panel1.Controls.Add(this.lbl_vat);
            this.panel1.Controls.Add(this.textBox_totalPrice);
            this.panel1.Controls.Add(this.listView_payments);
            this.panel1.Controls.Add(this.lbl_totalPrice_static);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox_tip);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.lbl_orderPrice_static);
            this.panel1.Controls.Add(this.lbl_tip);
            this.panel1.Controls.Add(this.lbl_vat_static);
            this.panel1.Location = new System.Drawing.Point(19, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(444, 526);
            this.panel1.TabIndex = 42;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(214)))), ((int)(((byte)(148)))));
            this.panel2.Controls.Add(this.pnl_payment_method);
            this.panel2.Location = new System.Drawing.Point(499, 401);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(236, 131);
            this.panel2.TabIndex = 43;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(214)))), ((int)(((byte)(148)))));
            this.panel3.Location = new System.Drawing.Point(499, 49);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(235, 268);
            this.panel3.TabIndex = 44;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LoginForm.Properties.Resources.chapeau;
            this.pictureBox1.Location = new System.Drawing.Point(11, 384);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(171, 99);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 40;
            this.pictureBox1.TabStop = false;
            // 
            // paymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(247)))), ((int)(((byte)(233)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(754, 586);
            this.Controls.Add(this.lbl_paymentMethodWarning);
            this.Controls.Add(this.lbl_payment_datestatic);
            this.Controls.Add(this.textBox_comments);
            this.Controls.Add(this.lbl_payment_tableStatic);
            this.Controls.Add(this.lbl_PaymentMethod);
            this.Controls.Add(this.btn_return);
            this.Controls.Add(this.btn_bill);
            this.Controls.Add(this.lbl_billSuccess);
            this.Controls.Add(this.lbl_commentStatic);
            this.Controls.Add(this.lbl_paymentTable);
            this.Controls.Add(this.lbl_date);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "paymentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chapeau - Payment";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.paymentForm_FormClosing);
            this.pnl_payment_method.ResumeLayout(false);
            this.pnl_payment_method.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Panel pnl_payment_method;
        private System.Windows.Forms.Label lbl_vat;
        private System.Windows.Forms.Label lbl_orderPrice;
        private System.Windows.Forms.Label lbl_totalPrice_static;
        private System.Windows.Forms.Label lbl_payment_tableStatic;
        private System.Windows.Forms.Label lbl_payment_datestatic;
        private System.Windows.Forms.TextBox textBox_totalPrice;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}