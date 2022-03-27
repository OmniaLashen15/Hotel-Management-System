using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagement
{
    public partial class FinalizePayment : Form
    {
        public FinalizePayment()
        {
            InitializeComponent();
            CenterToParent();
        }
        public int totalAmountFromFrontend = 0;
        public int foodBill = 0;
        private double finalTotalFinalized = 0.0;
        private string paymentType;

        public double FinalTotalFinalized
        {
            get { return finalTotalFinalized; }
            set { finalTotalFinalized = value; }
        }

        public string PaymentType
        {
            get { return paymentType; }
            set { paymentType = value; }
        }
        private string paymentCardNumber;

        public string PaymentCardNumber
        {
            get { return paymentCardNumber; }
            set { paymentCardNumber = value; }
        }
        private string MM_YY_Of_Card;

        public string MM_YY_Of_Card1
        {
            get { return MM_YY_Of_Card; }
            set { MM_YY_Of_Card = value; }
        }
        private string CVC_Of_Card;

        public string CVC_Of_Card1
        {
            get { return CVC_Of_Card; }
            set { CVC_Of_Card = value; }
        }
        private string CardType;

        public string CardType1
        {
            get { return CardType; }
            set { CardType = value; }
        }

        private void FinalizePayment_Load(object sender, EventArgs e)
        {
            double totalWithTax = Convert.ToDouble(totalAmountFromFrontend) * 0.07;
            double FinalTotal = Convert.ToDouble(totalAmountFromFrontend) + totalWithTax + foodBill;
            currentBillAmount.Text = "$" + Convert.ToString(totalAmountFromFrontend) + " USD";
            foodBillAmount.Text = "$" + Convert.ToString(foodBill) + " USD";
            taxAmount.Text = "$" + Convert.ToString(totalWithTax) + " USD";
            totalAmountLabel.Text = "$" + Convert.ToString(FinalTotal) + " USD";
            FinalTotalFinalized = FinalTotal;
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            PaymentType = paymentComboBox.Text;
            PaymentCardNumber = phoneTextBox.Text;
            MM_YY_Of_Card1 = monthComboBox.SelectedItem.ToString() + "/" + yearComboBox.SelectedItem.ToString();
            CVC_Of_Card1 = CVCTextBox.Text;
            CardType1 = cardTypeView.Text;

            this.Hide();
        }

        private void monthComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (phoneTextBox.Text.Substring(0, 1) == "3")
            {
                cardTypeView.Text = "AmericanExpress";
            }
            else if (phoneTextBox.Text.Substring(0, 1) == "4")
            {
                cardTypeView.Text = "Visa";
            }
            else if (phoneTextBox.Text.Substring(0, 1) == "5")
            {
                cardTypeView.Text = "MasterCard";
            }
            else if (phoneTextBox.Text.Substring(0, 1) == "6")
            {
                cardTypeView.Text = "Discover";
            }
            else
                cardTypeView.Text = "Unknown";
        }

        private void phoneTextBox_Leave(object sender, EventArgs e)
        {

            long getphn = Convert.ToInt64(phoneTextBox.Text);
            string formatString = String.Format("{0:0000-0000-0000-0000}", getphn);
            phoneTextBox.Text = formatString;
        }
    }
}
