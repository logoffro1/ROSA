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
    /// <summary>
    /// UI Form for the payment UI
    /// By Dewi Becu
    /// </summary>
    public partial class paymentForm : Form
    {
        //Employee field for the home page and the pass the employee that is using the application
        private Employee employee;
        //The order that this payment is about
        private int currentOrderId;
        //Current payment
        private Payment currentPayment;

        //Loads the form with all approriate data
        public paymentForm(int orderID, Employee employee)
        {
            currentOrderId = orderID; //might want to first go through table
            this.employee = employee;
            InitializeComponent();

            ShowData();
        }

        //Accesses DB to get all nesessary information for the OrderId that was passed from the Order screen
        //------------------------------get passed the whole order & pass order as a parameter, use the whole running order instead of orderItem
        //^ cant cause gabrian still hasnt done his part, and the order id or order object will have to be passed by his implementation
        private void ShowData() //------------------------------get passed the whole order & pass order as a parameter, use the whole running order instead of orderItem
        {
            //Accesses the data for the database
            Payment_Service paymentService = new Payment_Service();
            Payment payment = paymentService.GetPayment(currentOrderId);

            //Clears items in case it was not from a previous payment viewing
            listView_payments.Items.Clear();

            //Makes the database payment the currentPayment object
            currentPayment = payment;

            //Adds records of data to the listview
            lbl_paymentTable.Text = payment.Order.Table.tableId.ToString();
            lbl_date.Text = payment.Order.DateTime.ToString("dd/MM/yyyy HH:mm:ss");
            lbl_orderPrice.Text = payment.TotalPrice.ToString("€ 0.00");
            lbl_vat.Text = payment.TotalVAT.ToString("€ 0.00");
            textBox_tip.Text = "0.00";
            textBox_totalPrice.Text = (payment.TotalPrice).ToString("0.00");

            //Adds each order item to the listview
            foreach (OrderItem item in payment.Order.ListOrderItems)
            {
                string[] row = { item.menuItem.Name, item.amount.ToString(), item.menuItem.Price.ToString(), item.status.ToString() };
                listView_payments.Items.Add(new ListViewItem(row));
            }
        }

        //The payment button when a waiter/waitress wants to bill a customer/table
        private void btn_bill_Click(object sender, EventArgs e)
        {
             
            //Checks which payment method is used, else they are warned 
            if (rbtn_cash.Checked)
                currentPayment.PaymentMethod = PaymentMethodEnum.Cash;
            else if (rbtn_pin.Checked)
                currentPayment.PaymentMethod = PaymentMethodEnum.Pin;
            else if (rbtn_credit.Checked)
                currentPayment.PaymentMethod = PaymentMethodEnum.Credit;    
            else
            {
                lbl_paymentMethodWarning.Text = "Select a payment method";
                return;
            }

            //If incorrect format, just sets tip to 0
            try
            {
                currentPayment.TipAmount = decimal.Parse(textBox_tip.Text);
            }
            catch (Exception)
            {
                currentPayment.TipAmount = 0;
            }

            //Puts remaining data in the payment object
            currentPayment.Feedback = textBox_comments.Text;
            currentPayment.OrderId = currentOrderId;                //-----------NEEDED?

            //Puts new payment/bill in the database and sets order to paid
            Payment_Service paymentService = new Payment_Service();
            paymentService.PayBill(currentPayment);

            //UI to help show user that bill is paid
            btn_bill.Hide();
            lbl_billSuccess.Show();
        }

        //total price textbox changes amount according to what is in the rip textbox
        private void textBox_tip_TextChanged(object sender, EventArgs e)
        {
            float tempTip;

            try
            {
                //If there's no value in the textbox, just set it to 0
                if (textBox_tip.Text == "")
                    tempTip = 0;
                else
                    tempTip = float.Parse(textBox_tip.Text);                                

                float tempOrderPrice = float.Parse(lbl_orderPrice.Text.Split(' ')[1]);      //-----------CHANGE!
                textBox_totalPrice.Text = (tempTip + tempOrderPrice).ToString("0.00");      

                lbl_paymentMethodWarning.Text = "";
            }
            catch(Exception)
            {
                lbl_paymentMethodWarning.Text = "Input a decimal number in the tip box please.";
            }
        }


        //Tip textbox changes amount according to what is in the total price textbox
        private void textBox_totalPrice_TextChanged(object sender, EventArgs e)
        {
            float tempOrderPrice; 

            try
            {
                //If there's nothing in the total price text box OR if the total price is less than what is should be, put a warning
                if (textBox_totalPrice.Text == "" || float.Parse(textBox_totalPrice.Text) < float.Parse(lbl_orderPrice.Text.Split(' ')[1]))
                {
                    lbl_paymentMethodWarning.Text = "Insert a value bigger or equal than the order price";
                    return;
                }
                else
                    tempOrderPrice = float.Parse(textBox_totalPrice.Text);

                float tempTip = float.Parse(lbl_orderPrice.Text.Split(' ')[1]);//-----------CHANGE!
                textBox_tip.Text = (tempOrderPrice - tempTip).ToString("0.00");

                lbl_paymentMethodWarning.Text = "";
            }
            catch (Exception)
            {
                lbl_paymentMethodWarning.Text = "Input a decimal number in the tip box please.";
            }
        }

        //Returns to the order screen
        private void btn_return_Click(object sender, EventArgs e)
        {
            tableViewForm tableViewForm = new tableViewForm(employee);
            tableViewForm.Show();
            this.Hide();
        }
        private void paymentForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
