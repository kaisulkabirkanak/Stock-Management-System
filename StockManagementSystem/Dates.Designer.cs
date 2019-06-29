namespace StockManagementSystem
{
    partial class Dates
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.SoldRadioButton = new System.Windows.Forms.RadioButton();
            this.DamageRadioButton = new System.Windows.Forms.RadioButton();
            this.LostRadioButton = new System.Windows.Forms.RadioButton();
            this.SearchButton = new System.Windows.Forms.Button();
            this.ShowRichTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(193, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "From Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(193, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "To Date";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(291, 56);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(291, 105);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 5;
            // 
            // SoldRadioButton
            // 
            this.SoldRadioButton.AutoSize = true;
            this.SoldRadioButton.Location = new System.Drawing.Point(174, 179);
            this.SoldRadioButton.Name = "SoldRadioButton";
            this.SoldRadioButton.Size = new System.Drawing.Size(46, 17);
            this.SoldRadioButton.TabIndex = 6;
            this.SoldRadioButton.TabStop = true;
            this.SoldRadioButton.Text = "Sold";
            this.SoldRadioButton.UseVisualStyleBackColor = true;
            // 
            // DamageRadioButton
            // 
            this.DamageRadioButton.AutoSize = true;
            this.DamageRadioButton.Location = new System.Drawing.Point(311, 179);
            this.DamageRadioButton.Name = "DamageRadioButton";
            this.DamageRadioButton.Size = new System.Drawing.Size(65, 17);
            this.DamageRadioButton.TabIndex = 7;
            this.DamageRadioButton.TabStop = true;
            this.DamageRadioButton.Text = "Damage";
            this.DamageRadioButton.UseVisualStyleBackColor = true;
            // 
            // LostRadioButton
            // 
            this.LostRadioButton.AutoSize = true;
            this.LostRadioButton.Location = new System.Drawing.Point(468, 179);
            this.LostRadioButton.Name = "LostRadioButton";
            this.LostRadioButton.Size = new System.Drawing.Size(45, 17);
            this.LostRadioButton.TabIndex = 8;
            this.LostRadioButton.TabStop = true;
            this.LostRadioButton.Text = "Lost";
            this.LostRadioButton.UseVisualStyleBackColor = true;
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(478, 224);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 23);
            this.SearchButton.TabIndex = 9;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            // 
            // ShowRichTextBox
            // 
            this.ShowRichTextBox.Location = new System.Drawing.Point(87, 264);
            this.ShowRichTextBox.Name = "ShowRichTextBox";
            this.ShowRichTextBox.Size = new System.Drawing.Size(633, 174);
            this.ShowRichTextBox.TabIndex = 10;
            this.ShowRichTextBox.Text = "";
            // 
            // Dates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ShowRichTextBox);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.LostRadioButton);
            this.Controls.Add(this.DamageRadioButton);
            this.Controls.Add(this.SoldRadioButton);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Dates";
            this.Text = "Dates";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.RadioButton SoldRadioButton;
        private System.Windows.Forms.RadioButton DamageRadioButton;
        private System.Windows.Forms.RadioButton LostRadioButton;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.RichTextBox ShowRichTextBox;
    }
}