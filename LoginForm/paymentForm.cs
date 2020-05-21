using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RosaLogic;
using RosaModel;

namespace LoginForm
{
    public partial class paymentForm : Form
    {

        private int currentOrderId;
        private Employee employee;
        public paymentForm(Employee employee)
        {
            this.employee = employee;

            InitializeComponent();
            
        }

        private void resetForm()
        {
            //pnl_payment.Show();

            btn_bill.Visible = true;
            lbl_billSuccess.Visible = false;
            lbl_paymentMethodWarning.Text = "";

            textBox_comments.Text = "";
            textBox_tip.Text = "";
            rbtn_pin.Checked = true;

        }


        private void btn_reset_Click(object sender, EventArgs e)
        {

            resetForm();

            //change so that it's passed
            currentOrderId = 5;

            Payment_Service paymentService = new Payment_Service();
            Payment payment = paymentService.GetPayment(currentOrderId);

            OrderItem_Service orderItemService = new OrderItem_Service();
            List<OrderItem> orderItems = orderItemService.GetById(currentOrderId);

            listView_payments.Items.Clear();

            //Adds records of data to the listview
            lbl_paymentTable.Text = payment.order.table.ToString();
            lbl_date.Text =  payment.order.dateTime.ToString("dd/MM/yyyy HH:mm:ss");
            lbl_orderPrice.Text =  payment.totalPrice.ToString("€ 0.00");
            lbl_vat.Text = payment.totalVAT.ToString("€ 0.00");
            //textBox_comments.Text = payment.comments.ToString();
            textBox_tip.Text = "0.00";
            textBox_totalPrice.Text = (payment.totalPrice).ToString("0.00");


            foreach (OrderItem item in orderItems)
            {
                string[] row = { item.menuItem.Name, item.amount.ToString(), item.menuItem.Price.ToString(), item.status.ToString() };
                listView_payments.Items.Add(new ListViewItem(row));
            }
        }

        private void btn_bill_Click(object sender, EventArgs e)
        {
            Payment payment = new Payment();

            if (rbtn_cash.Checked)
                payment.paymentMethod = PaymentMethodEnum.Cash;
            else if (rbtn_pin.Checked)
                payment.paymentMethod = PaymentMethodEnum.Pin;
            else if (rbtn_credit.Checked)
                payment.paymentMethod = PaymentMethodEnum.VISA;     //change to credit card?? YES
            else
            {
                lbl_paymentMethodWarning.Text = "Select a payment method";
                return;
            }

            payment.totalPrice = decimal.Parse(lbl_orderPrice_static.Text.Split(' ')[2]);
            payment.totalVAT = decimal.Parse(lbl_vat_static.Text.Split(' ')[1]);

            //if incorrect format, just sets tip to 0
            try
            {
                payment.tipAmount = decimal.Parse(textBox_tip.Text);
            }
            catch (Exception)
            {
                payment.tipAmount = 0;
            }

            payment.comments = textBox_comments.Text;
            payment.orderId = currentOrderId;


            Payment_Service paymentService = new Payment_Service();
            paymentService.PayBill(payment);

            btn_bill.Visible = false;
            lbl_billSuccess.Visible = true;


        }

        private void paymentForm_Load(object sender, EventArgs e)
        {

        }

        private void lbl_totalPrice_Click(object sender, EventArgs e)
        {

        }

        private void lbl_orderPrice_Click(object sender, EventArgs e)
        {

        }

        private void textBox_tip_TextChanged(object sender, EventArgs e)
        {
            float temp1;

            try
            {
                if (textBox_tip.Text == "")
                    temp1 = 0;
                else 
                    temp1 = float.Parse(textBox_tip.Text);

                float temp2 = float.Parse(lbl_orderPrice.Text.Split(' ')[1]);
                textBox_totalPrice.Text = (temp1 + temp2).ToString("0.00");

                lbl_paymentMethodWarning.Text = "";
            }
            catch(Exception)
            {
                lbl_paymentMethodWarning.Text = "Input a decimal number in the tip box please.";
            }
        }

        private void textBox_totalPrice_TextChanged(object sender, EventArgs e)
        {
            float temp1;

            try
            {
                if (textBox_totalPrice.Text == "" || float.Parse(textBox_totalPrice.Text) < float.Parse(lbl_orderPrice.Text.Split(' ')[1]))
                {
                    lbl_paymentMethodWarning.Text = "Insert a value bigger or equal than the order price";
                    return;
                }
                else
                    temp1 = float.Parse(textBox_totalPrice.Text);

                float temp2 = float.Parse(lbl_orderPrice.Text.Split(' ')[1]);
                textBox_tip.Text = (temp1 - temp2).ToString("0.00");

                lbl_paymentMethodWarning.Text = "";
            }
            catch (Exception)
            {
                lbl_paymentMethodWarning.Text = "Input a decimal number in the tip box please.";
            }
        }
    }
}
