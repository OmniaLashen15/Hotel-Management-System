namespace HotelManagement
{
    partial class Kitchen
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.TodoTabPage = new System.Windows.Forms.TabPage();
            this.updateButton = new System.Windows.Forms.Button();
            this.onTheLineLabel = new System.Windows.Forms.Label();
            this.queueListBox = new System.Windows.Forms.ListBox();
            this.TodoGrpBox = new System.Windows.Forms.GroupBox();
            this.foodSelectionButton = new System.Windows.Forms.Button();
            this.supplyCheckBox = new System.Windows.Forms.CheckBox();
            this.surpriseCheckBox = new System.Windows.Forms.CheckBox();
            this.towelCheckBox = new System.Windows.Forms.CheckBox();
            this.cleaningCheckBox = new System.Windows.Forms.CheckBox();
            this.dinnerQTLabel = new System.Windows.Forms.Label();
            this.lunchQTLabel = new System.Windows.Forms.Label();
            this.breakfastQTLabel = new System.Windows.Forms.Label();
            this.dinnerTextBox = new System.Windows.Forms.TextBox();
            this.breakfastTextBox = new System.Windows.Forms.TextBox();
            this.lunchTextBox = new System.Windows.Forms.TextBox();
            this.RoomLabel = new System.Windows.Forms.Label();
            this.RoomTypeLabel = new System.Windows.Forms.Label();
            this.FloorLabel = new System.Windows.Forms.Label();
            this.PhoneNumberlabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.Roomtextbox = new System.Windows.Forms.TextBox();
            this.RoomTypeTextBox = new System.Windows.Forms.TextBox();
            this.floorTextBox = new System.Windows.Forms.TextBox();
            this.PhoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.overviewTabPage = new System.Windows.Forms.TabPage();
            this.overviewDataGridView = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.TodoTabPage.SuspendLayout();
            this.TodoGrpBox.SuspendLayout();
            this.overviewTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.overviewDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.TodoTabPage);
            this.tabControl1.Controls.Add(this.overviewTabPage);
            this.tabControl1.Location = new System.Drawing.Point(5, 9);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1305, 599);
            this.tabControl1.TabIndex = 3;
            // 
            // TodoTabPage
            // 
            this.TodoTabPage.BackColor = System.Drawing.Color.White;
            this.TodoTabPage.Controls.Add(this.updateButton);
            this.TodoTabPage.Controls.Add(this.onTheLineLabel);
            this.TodoTabPage.Controls.Add(this.queueListBox);
            this.TodoTabPage.Controls.Add(this.TodoGrpBox);
            this.TodoTabPage.Controls.Add(this.RoomLabel);
            this.TodoTabPage.Controls.Add(this.RoomTypeLabel);
            this.TodoTabPage.Controls.Add(this.FloorLabel);
            this.TodoTabPage.Controls.Add(this.PhoneNumberlabel);
            this.TodoTabPage.Controls.Add(this.nameLabel);
            this.TodoTabPage.Controls.Add(this.Roomtextbox);
            this.TodoTabPage.Controls.Add(this.RoomTypeTextBox);
            this.TodoTabPage.Controls.Add(this.floorTextBox);
            this.TodoTabPage.Controls.Add(this.PhoneNumberTextBox);
            this.TodoTabPage.Controls.Add(this.firstNameTextBox);
            this.TodoTabPage.Controls.Add(this.lastNameTextBox);
            this.TodoTabPage.Location = new System.Drawing.Point(4, 25);
            this.TodoTabPage.Margin = new System.Windows.Forms.Padding(4);
            this.TodoTabPage.Name = "TodoTabPage";
            this.TodoTabPage.Size = new System.Drawing.Size(1297, 570);
            this.TodoTabPage.TabIndex = 0;
            this.TodoTabPage.Text = "TODO*";
            // 
            // updateButton
            // 
            this.updateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.updateButton.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.updateButton.Location = new System.Drawing.Point(941, 470);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(310, 34);
            this.updateButton.TabIndex = 58;
            this.updateButton.Text = "Update changes";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // onTheLineLabel
            // 
            this.onTheLineLabel.AutoSize = true;
            this.onTheLineLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.onTheLineLabel.Location = new System.Drawing.Point(941, 40);
            this.onTheLineLabel.Name = "onTheLineLabel";
            this.onTheLineLabel.Size = new System.Drawing.Size(78, 18);
            this.onTheLineLabel.TabIndex = 61;
            this.onTheLineLabel.Text = "On the line";
            // 
            // queueListBox
            // 
            this.queueListBox.FormattingEnabled = true;
            this.queueListBox.ItemHeight = 16;
            this.queueListBox.Location = new System.Drawing.Point(941, 63);
            this.queueListBox.Name = "queueListBox";
            this.queueListBox.Size = new System.Drawing.Size(310, 388);
            this.queueListBox.TabIndex = 40;
            this.queueListBox.SelectedIndexChanged += new System.EventHandler(this.queueListBox_SelectedIndexChanged);
            // 
            // TodoGrpBox
            // 
            this.TodoGrpBox.BackColor = System.Drawing.Color.Transparent;
            this.TodoGrpBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TodoGrpBox.Controls.Add(this.foodSelectionButton);
            this.TodoGrpBox.Controls.Add(this.supplyCheckBox);
            this.TodoGrpBox.Controls.Add(this.surpriseCheckBox);
            this.TodoGrpBox.Controls.Add(this.towelCheckBox);
            this.TodoGrpBox.Controls.Add(this.cleaningCheckBox);
            this.TodoGrpBox.Controls.Add(this.dinnerQTLabel);
            this.TodoGrpBox.Controls.Add(this.lunchQTLabel);
            this.TodoGrpBox.Controls.Add(this.breakfastQTLabel);
            this.TodoGrpBox.Controls.Add(this.dinnerTextBox);
            this.TodoGrpBox.Controls.Add(this.breakfastTextBox);
            this.TodoGrpBox.Controls.Add(this.lunchTextBox);
            this.TodoGrpBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TodoGrpBox.Location = new System.Drawing.Point(469, 55);
            this.TodoGrpBox.Margin = new System.Windows.Forms.Padding(4);
            this.TodoGrpBox.Name = "TodoGrpBox";
            this.TodoGrpBox.Padding = new System.Windows.Forms.Padding(4);
            this.TodoGrpBox.Size = new System.Drawing.Size(465, 398);
            this.TodoGrpBox.TabIndex = 55;
            this.TodoGrpBox.TabStop = false;
            this.TodoGrpBox.Text = "Todo";
            // 
            // foodSelectionButton
            // 
            this.foodSelectionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.foodSelectionButton.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.foodSelectionButton.Location = new System.Drawing.Point(27, 342);
            this.foodSelectionButton.Name = "foodSelectionButton";
            this.foodSelectionButton.Size = new System.Drawing.Size(408, 36);
            this.foodSelectionButton.TabIndex = 68;
            this.foodSelectionButton.Text = "Change food selection?";
            this.foodSelectionButton.UseVisualStyleBackColor = true;
            this.foodSelectionButton.Click += new System.EventHandler(this.foodSelectionButton_Click);
            // 
            // supplyCheckBox
            // 
            this.supplyCheckBox.AutoSize = true;
            this.supplyCheckBox.Location = new System.Drawing.Point(191, 291);
            this.supplyCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.supplyCheckBox.Name = "supplyCheckBox";
            this.supplyCheckBox.Size = new System.Drawing.Size(155, 20);
            this.supplyCheckBox.TabIndex = 51;
            this.supplyCheckBox.Text = "Food/Supply status ?";
            this.supplyCheckBox.UseVisualStyleBackColor = true;
            this.supplyCheckBox.CheckedChanged += new System.EventHandler(this.supplyCheckBox_CheckedChanged);
            // 
            // surpriseCheckBox
            // 
            this.surpriseCheckBox.AutoSize = true;
            this.surpriseCheckBox.Location = new System.Drawing.Point(327, 236);
            this.surpriseCheckBox.Name = "surpriseCheckBox";
            this.surpriseCheckBox.Size = new System.Drawing.Size(137, 20);
            this.surpriseCheckBox.TabIndex = 51;
            this.surpriseCheckBox.Text = "Sweetest Surprise";
            this.surpriseCheckBox.UseVisualStyleBackColor = true;
            // 
            // towelCheckBox
            // 
            this.towelCheckBox.AutoSize = true;
            this.towelCheckBox.Location = new System.Drawing.Point(191, 236);
            this.towelCheckBox.Name = "towelCheckBox";
            this.towelCheckBox.Size = new System.Drawing.Size(73, 20);
            this.towelCheckBox.TabIndex = 51;
            this.towelCheckBox.Text = "Towels";
            this.towelCheckBox.UseVisualStyleBackColor = true;
            // 
            // cleaningCheckBox
            // 
            this.cleaningCheckBox.AutoSize = true;
            this.cleaningCheckBox.Location = new System.Drawing.Point(38, 236);
            this.cleaningCheckBox.Name = "cleaningCheckBox";
            this.cleaningCheckBox.Size = new System.Drawing.Size(82, 20);
            this.cleaningCheckBox.TabIndex = 51;
            this.cleaningCheckBox.Text = "Cleaning";
            this.cleaningCheckBox.UseVisualStyleBackColor = true;
            // 
            // dinnerQTLabel
            // 
            this.dinnerQTLabel.AutoSize = true;
            this.dinnerQTLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dinnerQTLabel.Location = new System.Drawing.Point(27, 140);
            this.dinnerQTLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dinnerQTLabel.Name = "dinnerQTLabel";
            this.dinnerQTLabel.Size = new System.Drawing.Size(93, 18);
            this.dinnerQTLabel.TabIndex = 63;
            this.dinnerQTLabel.Text = "Dinner [QTY]";
            // 
            // lunchQTLabel
            // 
            this.lunchQTLabel.AutoSize = true;
            this.lunchQTLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lunchQTLabel.Location = new System.Drawing.Point(234, 41);
            this.lunchQTLabel.Name = "lunchQTLabel";
            this.lunchQTLabel.Size = new System.Drawing.Size(90, 18);
            this.lunchQTLabel.TabIndex = 62;
            this.lunchQTLabel.Text = "Lunch [QTY]";
            // 
            // breakfastQTLabel
            // 
            this.breakfastQTLabel.AutoSize = true;
            this.breakfastQTLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.breakfastQTLabel.Location = new System.Drawing.Point(27, 41);
            this.breakfastQTLabel.Name = "breakfastQTLabel";
            this.breakfastQTLabel.Size = new System.Drawing.Size(113, 18);
            this.breakfastQTLabel.TabIndex = 3;
            this.breakfastQTLabel.Text = "Breakfast [QTY]";
            // 
            // dinnerTextBox
            // 
            this.dinnerTextBox.Location = new System.Drawing.Point(27, 171);
            this.dinnerTextBox.Multiline = true;
            this.dinnerTextBox.Name = "dinnerTextBox";
            this.dinnerTextBox.PlaceholderText = "Dinner";
            this.dinnerTextBox.Size = new System.Drawing.Size(408, 34);
            this.dinnerTextBox.TabIndex = 2;
            // 
            // breakfastTextBox
            // 
            this.breakfastTextBox.Location = new System.Drawing.Point(27, 77);
            this.breakfastTextBox.Multiline = true;
            this.breakfastTextBox.Name = "breakfastTextBox";
            this.breakfastTextBox.PlaceholderText = " Breakfast";
            this.breakfastTextBox.Size = new System.Drawing.Size(201, 34);
            this.breakfastTextBox.TabIndex = 1;
            // 
            // lunchTextBox
            // 
            this.lunchTextBox.Location = new System.Drawing.Point(234, 77);
            this.lunchTextBox.Multiline = true;
            this.lunchTextBox.Name = "lunchTextBox";
            this.lunchTextBox.PlaceholderText = "Lunch";
            this.lunchTextBox.Size = new System.Drawing.Size(201, 34);
            this.lunchTextBox.TabIndex = 0;
            // 
            // RoomLabel
            // 
            this.RoomLabel.AutoSize = true;
            this.RoomLabel.Location = new System.Drawing.Point(58, 382);
            this.RoomLabel.Name = "RoomLabel";
            this.RoomLabel.Size = new System.Drawing.Size(54, 16);
            this.RoomLabel.TabIndex = 10;
            this.RoomLabel.Text = "Room #";
            // 
            // RoomTypeLabel
            // 
            this.RoomTypeLabel.AutoSize = true;
            this.RoomTypeLabel.Location = new System.Drawing.Point(58, 295);
            this.RoomTypeLabel.Name = "RoomTypeLabel";
            this.RoomTypeLabel.Size = new System.Drawing.Size(79, 16);
            this.RoomTypeLabel.TabIndex = 9;
            this.RoomTypeLabel.Text = "Room Type";
            // 
            // FloorLabel
            // 
            this.FloorLabel.AutoSize = true;
            this.FloorLabel.Location = new System.Drawing.Point(248, 295);
            this.FloorLabel.Name = "FloorLabel";
            this.FloorLabel.Size = new System.Drawing.Size(48, 16);
            this.FloorLabel.TabIndex = 8;
            this.FloorLabel.Text = "Floor #";
            // 
            // PhoneNumberlabel
            // 
            this.PhoneNumberlabel.AutoSize = true;
            this.PhoneNumberlabel.Location = new System.Drawing.Point(58, 195);
            this.PhoneNumberlabel.Name = "PhoneNumberlabel";
            this.PhoneNumberlabel.Size = new System.Drawing.Size(94, 16);
            this.PhoneNumberlabel.TabIndex = 7;
            this.PhoneNumberlabel.Text = "Phone number";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(58, 84);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(44, 16);
            this.nameLabel.TabIndex = 6;
            this.nameLabel.Text = "Name";
            // 
            // Roomtextbox
            // 
            this.Roomtextbox.Location = new System.Drawing.Point(58, 414);
            this.Roomtextbox.Multiline = true;
            this.Roomtextbox.Name = "Roomtextbox";
            this.Roomtextbox.PlaceholderText = "Room #";
            this.Roomtextbox.Size = new System.Drawing.Size(374, 34);
            this.Roomtextbox.TabIndex = 5;
            // 
            // RoomTypeTextBox
            // 
            this.RoomTypeTextBox.Location = new System.Drawing.Point(58, 314);
            this.RoomTypeTextBox.Multiline = true;
            this.RoomTypeTextBox.Name = "RoomTypeTextBox";
            this.RoomTypeTextBox.PlaceholderText = "Room type";
            this.RoomTypeTextBox.Size = new System.Drawing.Size(184, 34);
            this.RoomTypeTextBox.TabIndex = 4;
            // 
            // floorTextBox
            // 
            this.floorTextBox.Location = new System.Drawing.Point(248, 314);
            this.floorTextBox.Multiline = true;
            this.floorTextBox.Name = "floorTextBox";
            this.floorTextBox.PlaceholderText = "Floor #";
            this.floorTextBox.Size = new System.Drawing.Size(184, 34);
            this.floorTextBox.TabIndex = 3;
            // 
            // PhoneNumberTextBox
            // 
            this.PhoneNumberTextBox.Location = new System.Drawing.Point(58, 226);
            this.PhoneNumberTextBox.Multiline = true;
            this.PhoneNumberTextBox.Name = "PhoneNumberTextBox";
            this.PhoneNumberTextBox.PlaceholderText = "(999)-999-9999";
            this.PhoneNumberTextBox.Size = new System.Drawing.Size(374, 34);
            this.PhoneNumberTextBox.TabIndex = 2;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(58, 117);
            this.firstNameTextBox.Multiline = true;
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.PlaceholderText = " First";
            this.firstNameTextBox.Size = new System.Drawing.Size(184, 36);
            this.firstNameTextBox.TabIndex = 1;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(248, 117);
            this.lastNameTextBox.Multiline = true;
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.PlaceholderText = " Last";
            this.lastNameTextBox.Size = new System.Drawing.Size(184, 34);
            this.lastNameTextBox.TabIndex = 0;
            // 
            // overviewTabPage
            // 
            this.overviewTabPage.BackColor = System.Drawing.Color.White;
            this.overviewTabPage.Controls.Add(this.overviewDataGridView);
            this.overviewTabPage.Location = new System.Drawing.Point(4, 29);
            this.overviewTabPage.Margin = new System.Windows.Forms.Padding(4);
            this.overviewTabPage.Name = "overviewTabPage";
            this.overviewTabPage.Size = new System.Drawing.Size(1297, 566);
            this.overviewTabPage.TabIndex = 1;
            this.overviewTabPage.Text = "Overview";
            // 
            // overviewDataGridView
            // 
            this.overviewDataGridView.BackgroundColor = System.Drawing.SystemColors.AppWorkspace;
            this.overviewDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.overviewDataGridView.Location = new System.Drawing.Point(5, 24);
            this.overviewDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.overviewDataGridView.Name = "overviewDataGridView";
            this.overviewDataGridView.RowHeadersWidth = 51;
            this.overviewDataGridView.RowTemplate.Height = 29;
            this.overviewDataGridView.Size = new System.Drawing.Size(1286, 522);
            this.overviewDataGridView.TabIndex = 5;
            // 
            // Kitchen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1315, 620);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Kitchen";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Room Service";
            this.TransparencyKey = System.Drawing.Color.Lavender;
            this.Load += new System.EventHandler(this.Kitchen_Load);
            this.tabControl1.ResumeLayout(false);
            this.TodoTabPage.ResumeLayout(false);
            this.TodoTabPage.PerformLayout();
            this.TodoGrpBox.ResumeLayout(false);
            this.TodoGrpBox.PerformLayout();
            this.overviewTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.overviewDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage TodoTabPage;
        private TabPage overviewTabPage;
        private DataGridView overviewDataGridView;
        private Label RoomLabel;
        private Label RoomTypeLabel;
        private Label FloorLabel;
        private Label PhoneNumberlabel;
        private Label nameLabel;
        private TextBox Roomtextbox;
        private TextBox RoomTypeTextBox;
        private TextBox floorTextBox;
        private TextBox PhoneNumberTextBox;
        private TextBox firstNameTextBox;
        private TextBox lastNameTextBox;
        private GroupBox TodoGrpBox;
        private Label dinnerQTLabel;
        private Label lunchQTLabel;
        private Label breakfastQTLabel;
        private TextBox dinnerTextBox;
        private TextBox breakfastTextBox;
        private TextBox lunchTextBox;
        private Button foodSelectionButton;
        private CheckBox supplyCheckBox;
        private CheckBox surpriseCheckBox;
        private CheckBox towelCheckBox;
        private CheckBox cleaningCheckBox;
        private Button updateButton;
        private Label onTheLineLabel;
        private ListBox queueListBox;
    }
}