namespace HotelManagement
{
    partial class FrontEnd
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
            this.esPanel = new System.Windows.Forms.TabControl();
            this.reservationPage = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.deleteButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.newButton = new System.Windows.Forms.Button();
            this.resEditButton = new System.Windows.Forms.ComboBox();
            this.middlePanel = new System.Windows.Forms.Panel();
            this.foodMenuButton = new System.Windows.Forms.Button();
            this.finalizebtn = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.checkinCheckBox = new System.Windows.Forms.CheckBox();
            this.smsCheckBox = new System.Windows.Forms.CheckBox();
            this.foodSupplyCheckBox = new System.Windows.Forms.CheckBox();
            this.depDatePicker = new System.Windows.Forms.DateTimePicker();
            this.entryDatePicker = new System.Windows.Forms.DateTimePicker();
            this.floorComboBox = new System.Windows.Forms.ComboBox();
            this.roomNComboBox = new System.Windows.Forms.ComboBox();
            this.qtGuestComboBox = new System.Windows.Forms.ComboBox();
            this.roomTypeComboBox = new System.Windows.Forms.ComboBox();
            this.depatureLabel = new System.Windows.Forms.Label();
            this.entryLabel = new System.Windows.Forms.Label();
            this.choiceLabel = new System.Windows.Forms.Label();
            this.LeftPanel = new System.Windows.Forms.Panel();
            this.stateComboBox = new System.Windows.Forms.ComboBox();
            this.monthComboBox = new System.Windows.Forms.ComboBox();
            this.genderComboBox = new System.Windows.Forms.ComboBox();
            this.dayComboBox = new System.Windows.Forms.ComboBox();
            this.zipTexBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.yearTextBox = new System.Windows.Forms.TextBox();
            this.phoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.aptTextBox = new System.Windows.Forms.TextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.addLabel = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.PhoneLabel = new System.Windows.Forms.Label();
            this.genderLabel = new System.Windows.Forms.Label();
            this.birthdayLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.searchPage = new System.Windows.Forms.TabPage();
            this.SearchError = new System.Windows.Forms.TextBox();
            this.searchDataGridView = new System.Windows.Forms.DataGridView();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.ReservationAdvTab = new System.Windows.Forms.TabPage();
            this.resTotalDataGridView = new System.Windows.Forms.DataGridView();
            this.roomPage = new System.Windows.Forms.TabPage();
            this.dataGridViewReversed = new System.Windows.Forms.DataGridView();
            this.dataGridViewOccupied = new System.Windows.Forms.DataGridView();
            this.datalabel2 = new System.Windows.Forms.Label();
            this.reservedLabel = new System.Windows.Forms.Label();
            this.dataLabel = new System.Windows.Forms.Label();
            this.occupiedLabel = new System.Windows.Forms.Label();
            this.esPanel.SuspendLayout();
            this.reservationPage.SuspendLayout();
            this.panel1.SuspendLayout();
            this.middlePanel.SuspendLayout();
            this.LeftPanel.SuspendLayout();
            this.searchPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchDataGridView)).BeginInit();
            this.ReservationAdvTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resTotalDataGridView)).BeginInit();
            this.roomPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReversed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOccupied)).BeginInit();
            this.SuspendLayout();
            // 
            // esPanel
            // 
            this.esPanel.Controls.Add(this.reservationPage);
            this.esPanel.Controls.Add(this.searchPage);
            this.esPanel.Controls.Add(this.ReservationAdvTab);
            this.esPanel.Controls.Add(this.roomPage);
            this.esPanel.Location = new System.Drawing.Point(14, 27);
            this.esPanel.Name = "esPanel";
            this.esPanel.SelectedIndex = 0;
            this.esPanel.Size = new System.Drawing.Size(1287, 586);
            this.esPanel.TabIndex = 0;
            // 
            // reservationPage
            // 
            this.reservationPage.Controls.Add(this.panel1);
            this.reservationPage.Controls.Add(this.middlePanel);
            this.reservationPage.Controls.Add(this.LeftPanel);
            this.reservationPage.Location = new System.Drawing.Point(4, 29);
            this.reservationPage.Name = "reservationPage";
            this.reservationPage.Padding = new System.Windows.Forms.Padding(3);
            this.reservationPage.Size = new System.Drawing.Size(1279, 553);
            this.reservationPage.TabIndex = 0;
            this.reservationPage.Text = "Reservation";
            this.reservationPage.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.deleteButton);
            this.panel1.Controls.Add(this.updateButton);
            this.panel1.Controls.Add(this.editButton);
            this.panel1.Controls.Add(this.newButton);
            this.panel1.Controls.Add(this.resEditButton);
            this.panel1.Location = new System.Drawing.Point(936, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(347, 557);
            this.panel1.TabIndex = 2;
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.Black;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.ForeColor = System.Drawing.Color.Red;
            this.deleteButton.Location = new System.Drawing.Point(8, 367);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(329, 53);
            this.deleteButton.TabIndex = 21;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.updateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.updateButton.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.updateButton.Location = new System.Drawing.Point(8, 304);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(329, 57);
            this.updateButton.TabIndex = 1;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = false;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // editButton
            // 
            this.editButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.editButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.editButton.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.editButton.Location = new System.Drawing.Point(8, 426);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(329, 48);
            this.editButton.TabIndex = 2;
            this.editButton.Text = "Edit existing Reservation";
            this.editButton.UseVisualStyleBackColor = false;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // newButton
            // 
            this.newButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.newButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.newButton.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.newButton.Location = new System.Drawing.Point(8, 480);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(329, 52);
            this.newButton.TabIndex = 3;
            this.newButton.Text = "New reservation";
            this.newButton.UseVisualStyleBackColor = false;
            this.newButton.Click += new System.EventHandler(this.newButton_Click);
            // 
            // resEditButton
            // 
            this.resEditButton.ForeColor = System.Drawing.Color.Green;
            this.resEditButton.FormattingEnabled = true;
            this.resEditButton.ItemHeight = 20;
            this.resEditButton.Items.AddRange(new object[] {
            "[ID]    [NAME]    [PHONE NUMBER]"});
            this.resEditButton.Location = new System.Drawing.Point(8, 37);
            this.resEditButton.Margin = new System.Windows.Forms.Padding(4);
            this.resEditButton.Name = "resEditButton";
            this.resEditButton.Size = new System.Drawing.Size(329, 28);
            this.resEditButton.TabIndex = 20;
            this.resEditButton.Text = "Select reservation to edit";
            this.resEditButton.SelectedIndexChanged += new System.EventHandler(this.resEditButton_SelectedIndexChanged);
            // 
            // middlePanel
            // 
            this.middlePanel.BackColor = System.Drawing.Color.Gainsboro;
            this.middlePanel.Controls.Add(this.foodMenuButton);
            this.middlePanel.Controls.Add(this.finalizebtn);
            this.middlePanel.Controls.Add(this.btnSubmit);
            this.middlePanel.Controls.Add(this.checkinCheckBox);
            this.middlePanel.Controls.Add(this.smsCheckBox);
            this.middlePanel.Controls.Add(this.foodSupplyCheckBox);
            this.middlePanel.Controls.Add(this.depDatePicker);
            this.middlePanel.Controls.Add(this.entryDatePicker);
            this.middlePanel.Controls.Add(this.floorComboBox);
            this.middlePanel.Controls.Add(this.roomNComboBox);
            this.middlePanel.Controls.Add(this.qtGuestComboBox);
            this.middlePanel.Controls.Add(this.roomTypeComboBox);
            this.middlePanel.Controls.Add(this.depatureLabel);
            this.middlePanel.Controls.Add(this.entryLabel);
            this.middlePanel.Controls.Add(this.choiceLabel);
            this.middlePanel.Location = new System.Drawing.Point(468, 0);
            this.middlePanel.Margin = new System.Windows.Forms.Padding(4);
            this.middlePanel.Name = "middlePanel";
            this.middlePanel.Size = new System.Drawing.Size(460, 557);
            this.middlePanel.TabIndex = 1;
            // 
            // foodMenuButton
            // 
            this.foodMenuButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.foodMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.foodMenuButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.foodMenuButton.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.foodMenuButton.Location = new System.Drawing.Point(8, 304);
            this.foodMenuButton.Name = "foodMenuButton";
            this.foodMenuButton.Size = new System.Drawing.Size(446, 57);
            this.foodMenuButton.TabIndex = 1;
            this.foodMenuButton.Text = "Food and menu";
            this.foodMenuButton.UseVisualStyleBackColor = false;
            this.foodMenuButton.Click += new System.EventHandler(this.foodMenuButton_Click);
            // 
            // finalizebtn
            // 
            this.finalizebtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.finalizebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.finalizebtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.finalizebtn.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.finalizebtn.Location = new System.Drawing.Point(8, 426);
            this.finalizebtn.Name = "finalizebtn";
            this.finalizebtn.Size = new System.Drawing.Size(446, 48);
            this.finalizebtn.TabIndex = 2;
            this.finalizebtn.Text = "Finalize bill";
            this.finalizebtn.UseVisualStyleBackColor = false;
            this.finalizebtn.Click += new System.EventHandler(this.finalizeButton_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSubmit.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.btnSubmit.Location = new System.Drawing.Point(8, 480);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(446, 52);
            this.btnSubmit.TabIndex = 3;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // checkinCheckBox
            // 
            this.checkinCheckBox.AutoSize = true;
            this.checkinCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.checkinCheckBox.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkinCheckBox.Location = new System.Drawing.Point(15, 381);
            this.checkinCheckBox.Name = "checkinCheckBox";
            this.checkinCheckBox.Size = new System.Drawing.Size(78, 21);
            this.checkinCheckBox.TabIndex = 4;
            this.checkinCheckBox.Text = "Check in";
            this.checkinCheckBox.UseVisualStyleBackColor = false;
            this.checkinCheckBox.CheckedChanged += new System.EventHandler(this.checkinCheckBox_CheckedChanged);
            // 
            // smsCheckBox
            // 
            this.smsCheckBox.AutoSize = true;
            this.smsCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.smsCheckBox.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.smsCheckBox.Location = new System.Drawing.Point(158, 381);
            this.smsCheckBox.Name = "smsCheckBox";
            this.smsCheckBox.Size = new System.Drawing.Size(92, 21);
            this.smsCheckBox.TabIndex = 5;
            this.smsCheckBox.Text = "Send sms?";
            this.smsCheckBox.UseVisualStyleBackColor = false;
            // 
            // foodSupplyCheckBox
            // 
            this.foodSupplyCheckBox.AutoSize = true;
            this.foodSupplyCheckBox.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.foodSupplyCheckBox.Location = new System.Drawing.Point(294, 381);
            this.foodSupplyCheckBox.Name = "foodSupplyCheckBox";
            this.foodSupplyCheckBox.Size = new System.Drawing.Size(152, 21);
            this.foodSupplyCheckBox.TabIndex = 6;
            this.foodSupplyCheckBox.Text = "Food/Supply status ?";
            this.foodSupplyCheckBox.UseVisualStyleBackColor = true;
            this.foodSupplyCheckBox.CheckedChanged += new System.EventHandler(this.foodSupplyCheckBox_CheckedChanged);
            // 
            // depDatePicker
            // 
            this.depDatePicker.CustomFormat = "MM-dd-yyyy";
            this.depDatePicker.Location = new System.Drawing.Point(8, 252);
            this.depDatePicker.MaxDate = new System.DateTime(2025, 4, 27, 23, 59, 0, 0);
            this.depDatePicker.MinDate = new System.DateTime(2014, 4, 27, 0, 0, 0, 0);
            this.depDatePicker.Name = "depDatePicker";
            this.depDatePicker.Size = new System.Drawing.Size(446, 27);
            this.depDatePicker.TabIndex = 31;
            this.depDatePicker.Value = new System.DateTime(2014, 4, 27, 0, 0, 0, 0);
            // 
            // entryDatePicker
            // 
            this.entryDatePicker.CustomFormat = "MM-dd-yyyy";
            this.entryDatePicker.Location = new System.Drawing.Point(8, 176);
            this.entryDatePicker.MaxDate = new System.DateTime(2025, 4, 27, 23, 59, 0, 0);
            this.entryDatePicker.MinDate = new System.DateTime(2014, 5, 11, 0, 0, 0, 0);
            this.entryDatePicker.Name = "entryDatePicker";
            this.entryDatePicker.Size = new System.Drawing.Size(446, 27);
            this.entryDatePicker.TabIndex = 26;
            this.entryDatePicker.Value = new System.DateTime(2014, 5, 11, 0, 0, 0, 0);
            // 
            // floorComboBox
            // 
            this.floorComboBox.FormattingEnabled = true;
            this.floorComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.floorComboBox.Location = new System.Drawing.Point(8, 101);
            this.floorComboBox.Name = "floorComboBox";
            this.floorComboBox.Size = new System.Drawing.Size(220, 28);
            this.floorComboBox.TabIndex = 17;
            this.floorComboBox.Text = " Floor";
            // 
            // roomNComboBox
            // 
            this.roomNComboBox.FormattingEnabled = true;
            this.roomNComboBox.Items.AddRange(new object[] {
            "101",
            "102",
            "103",
            "104",
            "105",
            "106",
            "107",
            "108",
            "109",
            "110",
            "201",
            "202",
            "203",
            "204",
            "205",
            "206",
            "207",
            "208",
            "209",
            "210",
            "301",
            "302",
            "303",
            "304",
            "305",
            "306",
            "307",
            "308",
            "309",
            "310",
            "401",
            "402",
            "403",
            "404",
            "405",
            "406",
            "407",
            "408",
            "409",
            "410",
            "501",
            "502",
            "503",
            "504",
            "505",
            "506",
            "507",
            "508",
            "509",
            "510"});
            this.roomNComboBox.Location = new System.Drawing.Point(234, 101);
            this.roomNComboBox.Name = "roomNComboBox";
            this.roomNComboBox.Size = new System.Drawing.Size(220, 28);
            this.roomNComboBox.TabIndex = 18;
            this.roomNComboBox.Text = "Room #";
            // 
            // qtGuestComboBox
            // 
            this.qtGuestComboBox.FormattingEnabled = true;
            this.qtGuestComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.qtGuestComboBox.Location = new System.Drawing.Point(8, 37);
            this.qtGuestComboBox.Name = "qtGuestComboBox";
            this.qtGuestComboBox.Size = new System.Drawing.Size(220, 28);
            this.qtGuestComboBox.TabIndex = 2;
            this.qtGuestComboBox.Text = "# of guests";
            // 
            // roomTypeComboBox
            // 
            this.roomTypeComboBox.FormattingEnabled = true;
            this.roomTypeComboBox.Items.AddRange(new object[] {
            "Single",
            "Double",
            "Twin",
            "Duplex",
            "Suite"});
            this.roomTypeComboBox.Location = new System.Drawing.Point(234, 37);
            this.roomTypeComboBox.Name = "roomTypeComboBox";
            this.roomTypeComboBox.Size = new System.Drawing.Size(220, 28);
            this.roomTypeComboBox.TabIndex = 15;
            this.roomTypeComboBox.Text = "Room type";
            this.roomTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.roomTypeComboBox_SelectedIndexChanged);
            // 
            // depatureLabel
            // 
            this.depatureLabel.AutoSize = true;
            this.depatureLabel.Location = new System.Drawing.Point(12, 222);
            this.depatureLabel.Name = "depatureLabel";
            this.depatureLabel.Size = new System.Drawing.Size(120, 20);
            this.depatureLabel.TabIndex = 4;
            this.depatureLabel.Text = "Deperture [date]";
            // 
            // entryLabel
            // 
            this.entryLabel.AutoSize = true;
            this.entryLabel.Location = new System.Drawing.Point(12, 152);
            this.entryLabel.Name = "entryLabel";
            this.entryLabel.Size = new System.Drawing.Size(86, 20);
            this.entryLabel.TabIndex = 3;
            this.entryLabel.Text = "Entry [date]";
            // 
            // choiceLabel
            // 
            this.choiceLabel.AutoSize = true;
            this.choiceLabel.Location = new System.Drawing.Point(8, 8);
            this.choiceLabel.Name = "choiceLabel";
            this.choiceLabel.Size = new System.Drawing.Size(91, 20);
            this.choiceLabel.TabIndex = 1;
            this.choiceLabel.Text = "Your choices";
            // 
            // LeftPanel
            // 
            this.LeftPanel.BackColor = System.Drawing.Color.Gainsboro;
            this.LeftPanel.Controls.Add(this.stateComboBox);
            this.LeftPanel.Controls.Add(this.monthComboBox);
            this.LeftPanel.Controls.Add(this.genderComboBox);
            this.LeftPanel.Controls.Add(this.dayComboBox);
            this.LeftPanel.Controls.Add(this.zipTexBox);
            this.LeftPanel.Controls.Add(this.firstNameTextBox);
            this.LeftPanel.Controls.Add(this.lastNameTextBox);
            this.LeftPanel.Controls.Add(this.yearTextBox);
            this.LeftPanel.Controls.Add(this.phoneNumberTextBox);
            this.LeftPanel.Controls.Add(this.aptTextBox);
            this.LeftPanel.Controls.Add(this.cityTextBox);
            this.LeftPanel.Controls.Add(this.addLabel);
            this.LeftPanel.Controls.Add(this.emailTextBox);
            this.LeftPanel.Controls.Add(this.label5);
            this.LeftPanel.Controls.Add(this.PhoneLabel);
            this.LeftPanel.Controls.Add(this.genderLabel);
            this.LeftPanel.Controls.Add(this.birthdayLabel);
            this.LeftPanel.Controls.Add(this.nameLabel);
            this.LeftPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftPanel.Margin = new System.Windows.Forms.Padding(4);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Size = new System.Drawing.Size(460, 557);
            this.LeftPanel.TabIndex = 0;
            // 
            // stateComboBox
            // 
            this.stateComboBox.FormattingEnabled = true;
            this.stateComboBox.Items.AddRange(new object[] {
            "Alabama ",
            "Alaska ",
            "Arizona ",
            "Arkansas ",
            "California ",
            "Colorado ",
            "Connecticut ",
            "Delaware ",
            "Florida ",
            "Georgia ",
            "Hawaii ",
            "Idaho ",
            "Illinois Indiana ",
            "Iowa ",
            "Kansas ",
            "Kentucky ",
            "Louisiana ",
            "Maine ",
            "Maryland ",
            "Massachusetts ",
            "Michigan ",
            "Minnesota ",
            "Mississippi ",
            "Missouri ",
            "Montana Nebraska ",
            "Nevada ",
            "New Hampshire ",
            "New Jersey ",
            "New Mexico ",
            "New York ",
            "North Carolina ",
            "North Dakota ",
            "Ohio ",
            "Oklahoma ",
            "Oregon ",
            "Pennsylvania Rhode Island ",
            "South Carolina ",
            "South Dakota ",
            "Tennessee ",
            "Texas ",
            "Utah ",
            "Vermont ",
            "Virginia ",
            "Washington ",
            "West Virginia ",
            "Wisconsin ",
            "Wyoming"});
            this.stateComboBox.Location = new System.Drawing.Point(8, 498);
            this.stateComboBox.Name = "stateComboBox";
            this.stateComboBox.Size = new System.Drawing.Size(216, 28);
            this.stateComboBox.TabIndex = 1;
            // 
            // monthComboBox
            // 
            this.monthComboBox.FormattingEnabled = true;
            this.monthComboBox.Items.AddRange(new object[] {
            "January ",
            "February ",
            "March ",
            "April ",
            "May ",
            "June ",
            "July ",
            "August ",
            "September ",
            "October ",
            "November ",
            "December"});
            this.monthComboBox.Location = new System.Drawing.Point(8, 101);
            this.monthComboBox.Name = "monthComboBox";
            this.monthComboBox.Size = new System.Drawing.Size(151, 28);
            this.monthComboBox.TabIndex = 2;
            // 
            // genderComboBox
            // 
            this.genderComboBox.FormattingEnabled = true;
            this.genderComboBox.Items.AddRange(new object[] {
            "Female",
            "Male",
            "Other"});
            this.genderComboBox.Location = new System.Drawing.Point(8, 175);
            this.genderComboBox.Name = "genderComboBox";
            this.genderComboBox.Size = new System.Drawing.Size(446, 28);
            this.genderComboBox.TabIndex = 3;
            // 
            // dayComboBox
            // 
            this.dayComboBox.FormattingEnabled = true;
            this.dayComboBox.Items.AddRange(new object[] {
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
            "12",
            "13",
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
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.dayComboBox.Location = new System.Drawing.Point(172, 101);
            this.dayComboBox.Name = "dayComboBox";
            this.dayComboBox.Size = new System.Drawing.Size(151, 28);
            this.dayComboBox.TabIndex = 15;
            // 
            // zipTexBox
            // 
            this.zipTexBox.Location = new System.Drawing.Point(234, 498);
            this.zipTexBox.Multiline = true;
            this.zipTexBox.Name = "zipTexBox";
            this.zipTexBox.PlaceholderText = "Zip code";
            this.zipTexBox.Size = new System.Drawing.Size(220, 34);
            this.zipTexBox.TabIndex = 14;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(8, 31);
            this.firstNameTextBox.Multiline = true;
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.PlaceholderText = " First";
            this.firstNameTextBox.Size = new System.Drawing.Size(220, 34);
            this.firstNameTextBox.TabIndex = 13;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(234, 31);
            this.lastNameTextBox.Multiline = true;
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.PlaceholderText = " Last";
            this.lastNameTextBox.Size = new System.Drawing.Size(220, 34);
            this.lastNameTextBox.TabIndex = 12;
            // 
            // yearTextBox
            // 
            this.yearTextBox.Location = new System.Drawing.Point(329, 101);
            this.yearTextBox.Multiline = true;
            this.yearTextBox.Name = "yearTextBox";
            this.yearTextBox.PlaceholderText = " Year";
            this.yearTextBox.Size = new System.Drawing.Size(125, 34);
            this.yearTextBox.TabIndex = 11;
            // 
            // phoneNumberTextBox
            // 
            this.phoneNumberTextBox.Location = new System.Drawing.Point(8, 245);
            this.phoneNumberTextBox.Multiline = true;
            this.phoneNumberTextBox.Name = "phoneNumberTextBox";
            this.phoneNumberTextBox.PlaceholderText = "(999) 999-999";
            this.phoneNumberTextBox.Size = new System.Drawing.Size(446, 34);
            this.phoneNumberTextBox.TabIndex = 10;
            this.phoneNumberTextBox.Leave += new System.EventHandler(this.phoneNumberTextBox_Leave);
            // 
            // aptTextBox
            // 
            this.aptTextBox.Location = new System.Drawing.Point(8, 440);
            this.aptTextBox.Multiline = true;
            this.aptTextBox.Name = "aptTextBox";
            this.aptTextBox.PlaceholderText = "Apt./Suite";
            this.aptTextBox.Size = new System.Drawing.Size(220, 34);
            this.aptTextBox.TabIndex = 9;
            // 
            // cityTextBox
            // 
            this.cityTextBox.Location = new System.Drawing.Point(234, 440);
            this.cityTextBox.Multiline = true;
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.PlaceholderText = "City";
            this.cityTextBox.Size = new System.Drawing.Size(220, 34);
            this.cityTextBox.TabIndex = 8;
            // 
            // addLabel
            // 
            this.addLabel.Location = new System.Drawing.Point(8, 381);
            this.addLabel.Multiline = true;
            this.addLabel.Name = "addLabel";
            this.addLabel.PlaceholderText = "Street address";
            this.addLabel.Size = new System.Drawing.Size(446, 34);
            this.addLabel.TabIndex = 7;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(8, 327);
            this.emailTextBox.Multiline = true;
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.PlaceholderText = "first.last@example.com";
            this.emailTextBox.Size = new System.Drawing.Size(446, 34);
            this.emailTextBox.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 304);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Your e-mail ddress";
            // 
            // PhoneLabel
            // 
            this.PhoneLabel.AutoSize = true;
            this.PhoneLabel.Location = new System.Drawing.Point(12, 222);
            this.PhoneLabel.Name = "PhoneLabel";
            this.PhoneLabel.Size = new System.Drawing.Size(108, 20);
            this.PhoneLabel.TabIndex = 4;
            this.PhoneLabel.Text = "Phone Number";
            // 
            // genderLabel
            // 
            this.genderLabel.AutoSize = true;
            this.genderLabel.Location = new System.Drawing.Point(12, 152);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(57, 20);
            this.genderLabel.TabIndex = 3;
            this.genderLabel.Text = "Gender";
            // 
            // birthdayLabel
            // 
            this.birthdayLabel.AutoSize = true;
            this.birthdayLabel.Location = new System.Drawing.Point(12, 82);
            this.birthdayLabel.Name = "birthdayLabel";
            this.birthdayLabel.Size = new System.Drawing.Size(64, 20);
            this.birthdayLabel.TabIndex = 2;
            this.birthdayLabel.Text = "Birthday";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(8, 8);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(49, 20);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Name";
            // 
            // searchPage
            // 
            this.searchPage.Controls.Add(this.SearchError);
            this.searchPage.Controls.Add(this.searchDataGridView);
            this.searchPage.Controls.Add(this.searchButton);
            this.searchPage.Controls.Add(this.searchTextBox);
            this.searchPage.Location = new System.Drawing.Point(4, 29);
            this.searchPage.Name = "searchPage";
            this.searchPage.Padding = new System.Windows.Forms.Padding(3);
            this.searchPage.Size = new System.Drawing.Size(1279, 553);
            this.searchPage.TabIndex = 1;
            this.searchPage.Text = "Universal Search";
            this.searchPage.UseVisualStyleBackColor = true;
            // 
            // SearchError
            // 
            this.SearchError.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SearchError.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SearchError.Location = new System.Drawing.Point(360, 70);
            this.SearchError.Multiline = true;
            this.SearchError.Name = "SearchError";
            this.SearchError.Size = new System.Drawing.Size(313, 150);
            this.SearchError.TabIndex = 19;
            this.SearchError.Text = "I ran out of entries :( SORRY DUDE.\r\n\r\nYou know, we can make another deal. \r\n\r\nI " +
    "sure will find something.\r\n\r\n";
            this.SearchError.Visible = false;
            // 
            // searchDataGridView
            // 
            this.searchDataGridView.BackgroundColor = System.Drawing.SystemColors.AppWorkspace;
            this.searchDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.searchDataGridView.Location = new System.Drawing.Point(112, 87);
            this.searchDataGridView.Name = "searchDataGridView";
            this.searchDataGridView.RowHeadersWidth = 51;
            this.searchDataGridView.RowTemplate.Height = 29;
            this.searchDataGridView.Size = new System.Drawing.Size(973, 290);
            this.searchDataGridView.TabIndex = 0;
            this.searchDataGridView.Visible = false;
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.Transparent;
            this.searchButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.searchButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.searchButton.Location = new System.Drawing.Point(1009, 341);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(85, 36);
            this.searchButton.TabIndex = 17;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(93, 266);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.PlaceholderText = "SearchBox";
            this.searchTextBox.Size = new System.Drawing.Size(973, 27);
            this.searchTextBox.TabIndex = 20;
            // 
            // ReservationAdvTab
            // 
            this.ReservationAdvTab.Controls.Add(this.resTotalDataGridView);
            this.ReservationAdvTab.Location = new System.Drawing.Point(4, 29);
            this.ReservationAdvTab.Name = "ReservationAdvTab";
            this.ReservationAdvTab.Padding = new System.Windows.Forms.Padding(3);
            this.ReservationAdvTab.Size = new System.Drawing.Size(1279, 553);
            this.ReservationAdvTab.TabIndex = 2;
            this.ReservationAdvTab.Text = "Reservation Adv. view";
            this.ReservationAdvTab.UseVisualStyleBackColor = true;
            // 
            // resTotalDataGridView
            // 
            this.resTotalDataGridView.BackgroundColor = System.Drawing.SystemColors.AppWorkspace;
            this.resTotalDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resTotalDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resTotalDataGridView.Location = new System.Drawing.Point(3, 3);
            this.resTotalDataGridView.Name = "resTotalDataGridView";
            this.resTotalDataGridView.RowHeadersWidth = 51;
            this.resTotalDataGridView.RowTemplate.Height = 29;
            this.resTotalDataGridView.Size = new System.Drawing.Size(1273, 547);
            this.resTotalDataGridView.TabIndex = 0;
            // 
            // roomPage
            // 
            this.roomPage.Controls.Add(this.dataGridViewReversed);
            this.roomPage.Controls.Add(this.dataGridViewOccupied);
            this.roomPage.Controls.Add(this.datalabel2);
            this.roomPage.Controls.Add(this.reservedLabel);
            this.roomPage.Controls.Add(this.dataLabel);
            this.roomPage.Controls.Add(this.occupiedLabel);
            this.roomPage.Location = new System.Drawing.Point(4, 29);
            this.roomPage.Name = "roomPage";
            this.roomPage.Padding = new System.Windows.Forms.Padding(3);
            this.roomPage.Size = new System.Drawing.Size(1279, 553);
            this.roomPage.TabIndex = 3;
            this.roomPage.Text = "Room availibility";
            this.roomPage.UseVisualStyleBackColor = true;
            // 
            // dataGridViewReversed
            // 
            this.dataGridViewReversed.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridViewReversed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReversed.Location = new System.Drawing.Point(623, 81);
            this.dataGridViewReversed.Name = "dataGridViewReversed";
            this.dataGridViewReversed.RowHeadersWidth = 51;
            this.dataGridViewReversed.RowTemplate.Height = 29;
            this.dataGridViewReversed.Size = new System.Drawing.Size(656, 469);
            this.dataGridViewReversed.TabIndex = 9;
            // 
            // dataGridViewOccupied
            // 
            this.dataGridViewOccupied.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridViewOccupied.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOccupied.Location = new System.Drawing.Point(0, 81);
            this.dataGridViewOccupied.Name = "dataGridViewOccupied";
            this.dataGridViewOccupied.RowHeadersWidth = 51;
            this.dataGridViewOccupied.RowTemplate.Height = 29;
            this.dataGridViewOccupied.Size = new System.Drawing.Size(617, 469);
            this.dataGridViewOccupied.TabIndex = 8;
            // 
            // datalabel2
            // 
            this.datalabel2.AutoSize = true;
            this.datalabel2.Location = new System.Drawing.Point(637, 45);
            this.datalabel2.Name = "datalabel2";
            this.datalabel2.Size = new System.Drawing.Size(331, 40);
            this.datalabel2.TabIndex = 7;
            this.datalabel2.Text = "Room#| Type  |  ID#   |       Name      |      Phone #\r\n\r\n";
            // 
            // reservedLabel
            // 
            this.reservedLabel.AutoSize = true;
            this.reservedLabel.Location = new System.Drawing.Point(637, 8);
            this.reservedLabel.Name = "reservedLabel";
            this.reservedLabel.Size = new System.Drawing.Size(69, 20);
            this.reservedLabel.TabIndex = 6;
            this.reservedLabel.Text = "Reserved";
            // 
            // dataLabel
            // 
            this.dataLabel.AutoSize = true;
            this.dataLabel.Location = new System.Drawing.Point(4, 46);
            this.dataLabel.Name = "dataLabel";
            this.dataLabel.Size = new System.Drawing.Size(331, 40);
            this.dataLabel.TabIndex = 4;
            this.dataLabel.Text = "Room#| Type  |  ID#   |       Name      |      Phone #\r\n\r\n";
            // 
            // occupiedLabel
            // 
            this.occupiedLabel.AutoSize = true;
            this.occupiedLabel.Location = new System.Drawing.Point(4, 8);
            this.occupiedLabel.Name = "occupiedLabel";
            this.occupiedLabel.Size = new System.Drawing.Size(72, 20);
            this.occupiedLabel.TabIndex = 3;
            this.occupiedLabel.Text = "Occupied";
            // 
            // FrontEnd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1313, 624);
            this.Controls.Add(this.esPanel);
            this.Name = "FrontEnd";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FrontEnd";
            this.TransparencyKey = System.Drawing.Color.Lavender;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrontEnd_FormClosing);
            this.Load += new System.EventHandler(this.FrontEnd_Load);
            this.esPanel.ResumeLayout(false);
            this.reservationPage.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.middlePanel.ResumeLayout(false);
            this.middlePanel.PerformLayout();
            this.LeftPanel.ResumeLayout(false);
            this.LeftPanel.PerformLayout();
            this.searchPage.ResumeLayout(false);
            this.searchPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchDataGridView)).EndInit();
            this.ReservationAdvTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.resTotalDataGridView)).EndInit();
            this.roomPage.ResumeLayout(false);
            this.roomPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReversed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOccupied)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl esPanel;
        private TabPage reservationPage;
        private Panel LeftPanel;
        private ComboBox stateComboBox;
        private ComboBox monthComboBox;
        private ComboBox genderComboBox;
        private ComboBox dayComboBox;
        private TextBox zipTexBox;
        private TextBox firstNameTextBox;
        private TextBox lastNameTextBox;
        private TextBox yearTextBox;
        private TextBox phoneNumberTextBox;
        private TextBox aptTextBox;
        private TextBox cityTextBox;
        private TextBox addLabel;
        private TextBox emailTextBox;
        private Label label5;
        private Label PhoneLabel;
        private Label genderLabel;
        private Label birthdayLabel;
        private Label nameLabel;
        private TabPage searchPage;
        private TabPage ReservationAdvTab;
        private TabPage roomPage;
        private Panel middlePanel;
        private ComboBox qtGuestComboBox;
        private ComboBox roomTypeComboBox;
        private Label depatureLabel;
        private Label entryLabel;
        private Label choiceLabel;
        private ComboBox floorComboBox;
        private ComboBox roomNComboBox;
        private DateTimePicker depDatePicker;
        private DateTimePicker entryDatePicker;
        private Button foodMenuButton;
        private Button finalizebtn;
        private Button btnSubmit;
        private CheckBox checkinCheckBox;
        private CheckBox smsCheckBox;
        private CheckBox foodSupplyCheckBox;
        private Panel panel1;
        private Button deleteButton;
        private Button updateButton;
        private Button editButton;
        private Button newButton;
        private ComboBox resEditButton;
        private DataGridView searchDataGridView;
        private TextBox SearchError;
        private DataGridView resTotalDataGridView;
        private Label dataLabel;
        private Label occupiedLabel;
        private Label datalabel2;
        private Label reservedLabel;
        private Button searchButton;
        private TextBox searchTextBox;
        private DataGridView dataGridViewReversed;
        private DataGridView dataGridViewOccupied;
    }
}