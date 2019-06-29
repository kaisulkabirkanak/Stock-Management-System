namespace StockManagementSystem
{
    partial class Searchview
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
            this.CategoryComboBox = new System.Windows.Forms.ComboBox();
            this.CompanyComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SearchButton = new System.Windows.Forms.Button();
            this.ShowRichTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // CategoryComboBox
            // 
            this.CategoryComboBox.FormattingEnabled = true;
            this.CategoryComboBox.Location = new System.Drawing.Point(318, 79);
            this.CategoryComboBox.Name = "CategoryComboBox";
            this.CategoryComboBox.Size = new System.Drawing.Size(188, 21);
            this.CategoryComboBox.TabIndex = 20;
            // 
            // CompanyComboBox
            // 
            this.CompanyComboBox.FormattingEnabled = true;
            this.CompanyComboBox.Location = new System.Drawing.Point(318, 33);
            this.CompanyComboBox.Name = "CompanyComboBox";
            this.CompanyComboBox.Size = new System.Drawing.Size(188, 21);
            this.CompanyComboBox.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(214, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Company";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(214, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Category";
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(431, 123);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 23);
            this.SearchButton.TabIndex = 21;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            // 
            // ShowRichTextBox
            // 
            this.ShowRichTextBox.Location = new System.Drawing.Point(74, 175);
            this.ShowRichTextBox.Name = "ShowRichTextBox";
            this.ShowRichTextBox.Size = new System.Drawing.Size(669, 229);
            this.ShowRichTextBox.TabIndex = 22;
            this.ShowRichTextBox.Text = "";
            // 
            // Searchview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ShowRichTextBox);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.CategoryComboBox);
            this.Controls.Add(this.CompanyComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Searchview";
            this.Text = "Searchview";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CategoryComboBox;
        private System.Windows.Forms.ComboBox CompanyComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.RichTextBox ShowRichTextBox;
    }
}