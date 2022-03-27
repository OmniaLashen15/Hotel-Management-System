namespace HotelManagement
{
    partial class FinalizePayment
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
            this.reservationLabel = new System.Windows.Forms.Label();
            this.currentBillLabel = new System.Windows.Forms.Label();
            this.foodBillLabel = new System.Windows.Forms.Label();
            this.paymentLabel = new System.Windows.Forms.Label();
            this.monthComboBox = new System.Windows.Forms.ComboBox();
            this.paymentComboBox = new System.Windows.Forms.ComboBox();
            this.yearComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.currentBillAmount = new System.Windows.Forms.Label();
            this.foodBillAmount = new System.Windows.Forms.Label();
            this.taxAmount = new System.Windows.Forms.Label();
            this.TaxLabel = new System.Windows.Forms.Label();
            this.totalAmountLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.CVCTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.nextButton = new System.Windows.Forms.Button();
            this.cardTypeView = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // reservationLabel
            // 
            this.reservationLabel.AutoSize = true;
            this.reservationLabel.Location = new System.Drawing.Point(8, 5);
            this.reservationLabel.Name = "reservationLabel";
            this.reservationLabel.Size = new System.Drawing.Size(86, 20);
            this.reservationLabel.TabIndex = 0;
            this.reservationLabel.Text = "Reservation";
            // 
            // currentBillLabel
            // 
            this.currentBillLabel.AutoSize = true;
            this.currentBillLabel.Location = new System.Drawing.Point(8, 37);
            this.currentBillLabel.Name = "currentBillLabel";
            this.currentBillLabel.Size = new System.Drawing.Size(82, 20);
            this.currentBillLabel.TabIndex = 1;
            this.currentBillLabel.Text = "Current bill";
            // 
            // foodBillLabel
            // 
            this.foodBillLabel.AutoSize = true;
            this.foodBillLabel.Location = new System.Drawing.Point(8, 75);
            this.foodBillLabel.Name = "foodBillLabel";
            this.foodBillLabel.Size = new System.Drawing.Size(68, 20);
            this.foodBillLabel.TabIndex = 2;
            this.foodBillLabel.Text = "Food bill";
            // 
            // paymentLabel
            // 
            this.paymentLabel.AutoSize = true;
            this.paymentLabel.Location = new System.Drawing.Point(16, 131);
            this.paymentLabel.Name = "paymentLabel";
            this.paymentLabel.Size = new System.Drawing.Size(65, 20);
            this.paymentLabel.TabIndex = 3;
            this.paymentLabel.Text = "Payment";
            // 
            // monthComboBox
            // 
            this.monthComboBox.FormattingEnabled = true;
            this.monthComboBox.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.monthComboBox.Location = new System.Drawing.Point(16, 215);
            this.monthComboBox.Name = "monthComboBox";
            this.monthComboBox.Size = new System.Drawing.Size(104, 28);
            this.monthComboBox.TabIndex = 4;
            this.monthComboBox.Text = "MM";
            this.monthComboBox.SelectedIndexChanged += new System.EventHandler(this.monthComboBox_SelectedIndexChanged);
            // 
            // paymentComboBox
            // 
            this.paymentComboBox.FormattingEnabled = true;
            this.paymentComboBox.Items.AddRange(new object[] {
            "Credit",
            "Debit"});
            this.paymentComboBox.Location = new System.Drawing.Point(16, 168);
            this.paymentComboBox.Name = "paymentComboBox";
            this.paymentComboBox.Size = new System.Drawing.Size(205, 28);
            this.paymentComboBox.TabIndex = 29;
            this.paymentComboBox.Text = "Payment Type";
            // 
            // yearComboBox
            // 
            this.yearComboBox.FormattingEnabled = true;
            this.yearComboBox.Items.AddRange(new object[] {
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24"});
            this.yearComboBox.Location = new System.Drawing.Point(154, 215);
            this.yearComboBox.Name = "yearComboBox";
            this.yearComboBox.Size = new System.Drawing.Size(67, 28);
            this.yearComboBox.TabIndex = 6;
            this.yearComboBox.Text = "YY";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(126, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "/";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(500, 5);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(41, 20);
            this.priceLabel.TabIndex = 30;
            this.priceLabel.Text = "Price";
            // 
            // currentBillAmount
            // 
            this.currentBillAmount.AutoSize = true;
            this.currentBillAmount.Location = new System.Drawing.Point(472, 46);
            this.currentBillAmount.Name = "currentBillAmount";
            this.currentBillAmount.Size = new System.Drawing.Size(17, 20);
            this.currentBillAmount.TabIndex = 31;
            this.currentBillAmount.Text = "$";
            // 
            // foodBillAmount
            // 
            this.foodBillAmount.AutoSize = true;
            this.foodBillAmount.Location = new System.Drawing.Point(472, 75);
            this.foodBillAmount.Name = "foodBillAmount";
            this.foodBillAmount.Size = new System.Drawing.Size(17, 20);
            this.foodBillAmount.TabIndex = 32;
            this.foodBillAmount.Text = "$";
            // 
            // taxAmount
            // 
            this.taxAmount.AutoSize = true;
            this.taxAmount.Location = new System.Drawing.Point(448, 101);
            this.taxAmount.Name = "taxAmount";
            this.taxAmount.Size = new System.Drawing.Size(17, 20);
            this.taxAmount.TabIndex = 33;
            this.taxAmount.Text = "$";
            // 
            // TaxLabel
            // 
            this.TaxLabel.AutoSize = true;
            this.TaxLabel.Location = new System.Drawing.Point(363, 101);
            this.TaxLabel.Name = "TaxLabel";
            this.TaxLabel.Size = new System.Drawing.Size(30, 20);
            this.TaxLabel.TabIndex = 34;
            this.TaxLabel.Text = "Tax";
            // 
            // totalAmountLabel
            // 
            this.totalAmountLabel.AutoSize = true;
            this.totalAmountLabel.Location = new System.Drawing.Point(435, 131);
            this.totalAmountLabel.Name = "totalAmountLabel";
            this.totalAmountLabel.Size = new System.Drawing.Size(17, 20);
            this.totalAmountLabel.TabIndex = 35;
            this.totalAmountLabel.Text = "$";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.totalLabel.Location = new System.Drawing.Point(346, 131);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(44, 20);
            this.totalLabel.TabIndex = 36;
            this.totalLabel.Text = "Total";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(337, 223);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 20);
            this.label9.TabIndex = 37;
            this.label9.Text = "Card type:";
            // 
            // CVCTextBox
            // 
            this.CVCTextBox.Location = new System.Drawing.Point(261, 218);
            this.CVCTextBox.Multiline = true;
            this.CVCTextBox.Name = "CVCTextBox";
            this.CVCTextBox.PlaceholderText = "CVC";
            this.CVCTextBox.Size = new System.Drawing.Size(60, 34);
            this.CVCTextBox.TabIndex = 39;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Location = new System.Drawing.Point(261, 169);
            this.phoneTextBox.Multiline = true;
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.PlaceholderText = "9999 - 9999 - 9999 - 9999";
            this.phoneTextBox.Size = new System.Drawing.Size(289, 34);
            this.phoneTextBox.TabIndex = 40;
            this.phoneTextBox.Leave += new System.EventHandler(this.phoneTextBox_Leave);
            // 
            // nextButton
            // 
            this.nextButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.nextButton.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nextButton.Location = new System.Drawing.Point(435, 256);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(115, 44);
            this.nextButton.TabIndex = 41;
            this.nextButton.Text = "Next";
            this.nextButton.UseVisualStyleBackColor = false;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // cardTypeView
            // 
            this.cardTypeView.AutoSize = true;
            this.cardTypeView.Location = new System.Drawing.Point(427, 223);
            this.cardTypeView.Name = "cardTypeView";
            this.cardTypeView.Size = new System.Drawing.Size(70, 20);
            this.cardTypeView.TabIndex = 38;
            this.cardTypeView.Text = "Unknown";
            // 
            // FinalizePayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(561, 303);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(this.CVCTextBox);
            this.Controls.Add(this.cardTypeView);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.totalAmountLabel);
            this.Controls.Add(this.TaxLabel);
            this.Controls.Add(this.taxAmount);
            this.Controls.Add(this.foodBillAmount);
            this.Controls.Add(this.currentBillAmount);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.yearComboBox);
            this.Controls.Add(this.paymentComboBox);
            this.Controls.Add(this.monthComboBox);
            this.Controls.Add(this.paymentLabel);
            this.Controls.Add(this.foodBillLabel);
            this.Controls.Add(this.currentBillLabel);
            this.Controls.Add(this.reservationLabel);
            this.Name = "FinalizePayment";
            this.Padding = new System.Windows.Forms.Padding(27, 37, 27, 25);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FinalizePayment";
            this.Load += new System.EventHandler(this.FinalizePayment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label reservationLabel;
        private Label currentBillLabel;
        private Label foodBillLabel;
        private Label paymentLabel;
        private Label label2;
        private Label priceLabel;
        private Label currentBillAmount;
        private Label foodBillAmount;
        private Label taxAmount;
        private Label TaxLabel;
        private Label totalAmountLabel;
        private Label totalLabel;
        private Label label9;
        private Button nextButton;
        public ComboBox paymentComboBox;
        public TextBox phoneTextBox;
        public ComboBox monthComboBox;
        public ComboBox yearComboBox;
        public TextBox CVCTextBox;
        private Label cardTypeView;
    }
}