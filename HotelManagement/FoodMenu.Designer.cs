namespace HotelManagement
{
    partial class FoodMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FoodMenu));
            this.foodPanel = new System.Windows.Forms.Panel();
            this.dinnerQTY = new System.Windows.Forms.TextBox();
            this.lunchQTY = new System.Windows.Forms.TextBox();
            this.breakfastQTY = new System.Windows.Forms.TextBox();
            this.dinnerCheckBox = new System.Windows.Forms.CheckBox();
            this.lunchCheckBox = new System.Windows.Forms.CheckBox();
            this.breakfastCheckBox = new System.Windows.Forms.CheckBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lunchPicture = new System.Windows.Forms.PictureBox();
            this.breakfastPicture = new System.Windows.Forms.PictureBox();
            this.foodSelectionLabel = new System.Windows.Forms.Label();
            this.needPanel = new System.Windows.Forms.Panel();
            this.surpriseCheckBox = new System.Windows.Forms.CheckBox();
            this.towelsCheckBox = new System.Windows.Forms.CheckBox();
            this.cleaningCheckBox = new System.Windows.Forms.CheckBox();
            this.needsLabel = new System.Windows.Forms.Label();
            this.nextButton = new System.Windows.Forms.Button();
            this.foodPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lunchPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.breakfastPicture)).BeginInit();
            this.needPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // foodPanel
            // 
            this.foodPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.foodPanel.Controls.Add(this.dinnerQTY);
            this.foodPanel.Controls.Add(this.lunchQTY);
            this.foodPanel.Controls.Add(this.breakfastQTY);
            this.foodPanel.Controls.Add(this.dinnerCheckBox);
            this.foodPanel.Controls.Add(this.lunchCheckBox);
            this.foodPanel.Controls.Add(this.breakfastCheckBox);
            this.foodPanel.Controls.Add(this.pictureBox3);
            this.foodPanel.Controls.Add(this.lunchPicture);
            this.foodPanel.Controls.Add(this.breakfastPicture);
            this.foodPanel.Controls.Add(this.foodSelectionLabel);
            this.foodPanel.Location = new System.Drawing.Point(12, 12);
            this.foodPanel.Name = "foodPanel";
            this.foodPanel.Size = new System.Drawing.Size(443, 484);
            this.foodPanel.TabIndex = 0;
            // 
            // dinnerQTY
            // 
            this.dinnerQTY.Location = new System.Drawing.Point(18, 447);
            this.dinnerQTY.Multiline = true;
            this.dinnerQTY.Name = "dinnerQTY";
            this.dinnerQTY.PlaceholderText = "Quantity ?";
            this.dinnerQTY.Size = new System.Drawing.Size(186, 34);
            this.dinnerQTY.TabIndex = 9;
            // 
            // lunchQTY
            // 
            this.lunchQTY.Location = new System.Drawing.Point(224, 219);
            this.lunchQTY.Multiline = true;
            this.lunchQTY.Name = "lunchQTY";
            this.lunchQTY.PlaceholderText = "Quantity ?";
            this.lunchQTY.Size = new System.Drawing.Size(175, 34);
            this.lunchQTY.TabIndex = 8;
            // 
            // breakfastQTY
            // 
            this.breakfastQTY.Location = new System.Drawing.Point(18, 219);
            this.breakfastQTY.Multiline = true;
            this.breakfastQTY.Name = "breakfastQTY";
            this.breakfastQTY.PlaceholderText = "Quantity ?";
            this.breakfastQTY.Size = new System.Drawing.Size(172, 34);
            this.breakfastQTY.TabIndex = 7;
            // 
            // dinnerCheckBox
            // 
            this.dinnerCheckBox.AutoSize = true;
            this.dinnerCheckBox.Location = new System.Drawing.Point(18, 417);
            this.dinnerCheckBox.Name = "dinnerCheckBox";
            this.dinnerCheckBox.Size = new System.Drawing.Size(121, 24);
            this.dinnerCheckBox.TabIndex = 6;
            this.dinnerCheckBox.Text = "Dinner   ($15)";
            this.dinnerCheckBox.UseVisualStyleBackColor = true;
            this.dinnerCheckBox.CheckedChanged += new System.EventHandler(this.dinnerCheckBox_CheckedChanged);
            // 
            // lunchCheckBox
            // 
            this.lunchCheckBox.AutoSize = true;
            this.lunchCheckBox.Location = new System.Drawing.Point(224, 189);
            this.lunchCheckBox.Name = "lunchCheckBox";
            this.lunchCheckBox.Size = new System.Drawing.Size(115, 24);
            this.lunchCheckBox.TabIndex = 5;
            this.lunchCheckBox.Text = "Lunch   ($15)";
            this.lunchCheckBox.UseVisualStyleBackColor = true;
            this.lunchCheckBox.CheckedChanged += new System.EventHandler(this.lunchCheckBox_CheckedChanged);
            // 
            // breakfastCheckBox
            // 
            this.breakfastCheckBox.AutoSize = true;
            this.breakfastCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.breakfastCheckBox.Location = new System.Drawing.Point(18, 189);
            this.breakfastCheckBox.Name = "breakfastCheckBox";
            this.breakfastCheckBox.Size = new System.Drawing.Size(131, 24);
            this.breakfastCheckBox.TabIndex = 4;
            this.breakfastCheckBox.Text = "Break Fast  ($7)";
            this.breakfastCheckBox.UseVisualStyleBackColor = false;
            this.breakfastCheckBox.CheckedChanged += new System.EventHandler(this.breakfastCheckBox_CheckedChanged);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(18, 267);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(186, 144);
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // lunchPicture
            // 
            this.lunchPicture.Image = ((System.Drawing.Image)(resources.GetObject("lunchPicture.Image")));
            this.lunchPicture.Location = new System.Drawing.Point(224, 66);
            this.lunchPicture.Name = "lunchPicture";
            this.lunchPicture.Size = new System.Drawing.Size(192, 113);
            this.lunchPicture.TabIndex = 2;
            this.lunchPicture.TabStop = false;
            // 
            // breakfastPicture
            // 
            this.breakfastPicture.Image = ((System.Drawing.Image)(resources.GetObject("breakfastPicture.Image")));
            this.breakfastPicture.Location = new System.Drawing.Point(18, 66);
            this.breakfastPicture.Name = "breakfastPicture";
            this.breakfastPicture.Size = new System.Drawing.Size(172, 113);
            this.breakfastPicture.TabIndex = 1;
            this.breakfastPicture.TabStop = false;
            // 
            // foodSelectionLabel
            // 
            this.foodSelectionLabel.AutoSize = true;
            this.foodSelectionLabel.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.foodSelectionLabel.Location = new System.Drawing.Point(4, 12);
            this.foodSelectionLabel.Name = "foodSelectionLabel";
            this.foodSelectionLabel.Size = new System.Drawing.Size(134, 28);
            this.foodSelectionLabel.TabIndex = 0;
            this.foodSelectionLabel.Text = "Food Selection";
            // 
            // needPanel
            // 
            this.needPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.needPanel.Controls.Add(this.surpriseCheckBox);
            this.needPanel.Controls.Add(this.towelsCheckBox);
            this.needPanel.Controls.Add(this.cleaningCheckBox);
            this.needPanel.Controls.Add(this.needsLabel);
            this.needPanel.Location = new System.Drawing.Point(483, 12);
            this.needPanel.Name = "needPanel";
            this.needPanel.Size = new System.Drawing.Size(199, 426);
            this.needPanel.TabIndex = 1;
            // 
            // surpriseCheckBox
            // 
            this.surpriseCheckBox.AutoSize = true;
            this.surpriseCheckBox.Location = new System.Drawing.Point(18, 175);
            this.surpriseCheckBox.Name = "surpriseCheckBox";
            this.surpriseCheckBox.Size = new System.Drawing.Size(145, 24);
            this.surpriseCheckBox.TabIndex = 13;
            this.surpriseCheckBox.Text = "Sweetest surprise";
            this.surpriseCheckBox.UseVisualStyleBackColor = true;
            // 
            // towelsCheckBox
            // 
            this.towelsCheckBox.AutoSize = true;
            this.towelsCheckBox.Location = new System.Drawing.Point(18, 114);
            this.towelsCheckBox.Name = "towelsCheckBox";
            this.towelsCheckBox.Size = new System.Drawing.Size(76, 24);
            this.towelsCheckBox.TabIndex = 12;
            this.towelsCheckBox.Text = "Towels";
            this.towelsCheckBox.UseVisualStyleBackColor = true;
            // 
            // cleaningCheckBox
            // 
            this.cleaningCheckBox.AutoSize = true;
            this.cleaningCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.cleaningCheckBox.Location = new System.Drawing.Point(18, 56);
            this.cleaningCheckBox.Name = "cleaningCheckBox";
            this.cleaningCheckBox.Size = new System.Drawing.Size(89, 24);
            this.cleaningCheckBox.TabIndex = 11;
            this.cleaningCheckBox.Text = "Cleaning";
            this.cleaningCheckBox.UseVisualStyleBackColor = false;
            // 
            // needsLabel
            // 
            this.needsLabel.AutoSize = true;
            this.needsLabel.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.needsLabel.Location = new System.Drawing.Point(14, 12);
            this.needsLabel.Name = "needsLabel";
            this.needsLabel.Size = new System.Drawing.Size(125, 28);
            this.needsLabel.TabIndex = 10;
            this.needsLabel.Text = "Special needs";
            // 
            // nextButton
            // 
            this.nextButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.nextButton.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nextButton.Location = new System.Drawing.Point(483, 444);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(199, 52);
            this.nextButton.TabIndex = 0;
            this.nextButton.Text = "Next";
            this.nextButton.UseVisualStyleBackColor = false;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // FoodMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(694, 497);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.needPanel);
            this.Controls.Add(this.foodPanel);
            this.Name = "FoodMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Food and Menu";
            this.foodPanel.ResumeLayout(false);
            this.foodPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lunchPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.breakfastPicture)).EndInit();
            this.needPanel.ResumeLayout(false);
            this.needPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel foodPanel;
        private PictureBox pictureBox3;
        private PictureBox lunchPicture;
        private PictureBox breakfastPicture;
        private Label foodSelectionLabel;
        private Label needsLabel;
        private Button nextButton;
        public Panel needPanel;
        public CheckBox dinnerCheckBox;
        public CheckBox lunchCheckBox;
        public CheckBox breakfastCheckBox;
        public TextBox dinnerQTY;
        public TextBox lunchQTY;
        public TextBox breakfastQTY;
        public CheckBox surpriseCheckBox;
        public CheckBox towelsCheckBox;
        public CheckBox cleaningCheckBox;
    }
}