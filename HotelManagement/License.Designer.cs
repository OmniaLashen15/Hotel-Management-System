namespace HotelManagement
{
    partial class License
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(License));
            this.LisenceRichTxt = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // LisenceRichTxt
            // 
            this.LisenceRichTxt.BackColor = System.Drawing.Color.White;
            this.LisenceRichTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LisenceRichTxt.Font = new System.Drawing.Font("Simplified Arabic Fixed", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LisenceRichTxt.Location = new System.Drawing.Point(1, 5);
            this.LisenceRichTxt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LisenceRichTxt.Name = "LisenceRichTxt";
            this.LisenceRichTxt.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.LisenceRichTxt.Size = new System.Drawing.Size(513, 240);
            this.LisenceRichTxt.TabIndex = 0;
            this.LisenceRichTxt.Text = resources.GetString("LisenceRichTxt.Text");
            // 
            // License
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(682, 239);
            this.Controls.Add(this.LisenceRichTxt);
            this.DoubleBuffered = true;
            this.Name = "License";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 24, 25);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "License";
            this.TransparencyKey = System.Drawing.Color.Lavender;
            this.ResumeLayout(false);

        }

        #endregion

        private RichTextBox LisenceRichTxt;
    }
}