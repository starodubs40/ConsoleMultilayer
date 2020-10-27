namespace PLWinFormCore
{
    partial class MarketerView
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
            this.LogOut = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button_click1 = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(336, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Marketer\'s office";
            // 
            // LogOut
            // 
            this.LogOut.ForeColor = System.Drawing.Color.Sienna;
            this.LogOut.Location = new System.Drawing.Point(698, 499);
            this.LogOut.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LogOut.Name = "LogOut";
            this.LogOut.Size = new System.Drawing.Size(75, 29);
            this.LogOut.TabIndex = 1;
            this.LogOut.Text = "Log Out";
            this.LogOut.UseVisualStyleBackColor = true;
            this.LogOut.Click += new System.EventHandler(this.LogOut_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(222, 79);
            this.listBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(551, 384);
            this.listBox1.TabIndex = 2;
            // 
            // button_click1
            // 
            this.button_click1.Location = new System.Drawing.Point(12, 79);
            this.button_click1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_click1.Name = "button_click1";
            this.button_click1.Size = new System.Drawing.Size(106, 29);
            this.button_click1.TabIndex = 3;
            this.button_click1.Text = "GetUsers";
            this.button_click1.UseVisualStyleBackColor = true;
            this.button_click1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(222, 499);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(123, 29);
            this.ClearButton.TabIndex = 4;
            this.ClearButton.Text = "Clear ListBox";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 128);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(189, 29);
            this.button2.TabIndex = 5;
            this.button2.Text = "GetAllPersonalDiscounts";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(13, 175);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(188, 29);
            this.button3.TabIndex = 6;
            this.button3.Text = "GetProducts";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(13, 223);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(188, 29);
            this.button4.TabIndex = 7;
            this.button4.Text = "GetOrders";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(12, 387);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(188, 29);
            this.button5.TabIndex = 8;
            this.button5.Text = "AddPersonalDiscount";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(13, 434);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(187, 29);
            this.button6.TabIndex = 9;
            this.button6.Text = "ChangePersonalDiscount";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // MarketerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 562);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.button_click1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.LogOut);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MarketerView";
            this.Text = "Marketer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button LogOut;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button_click1;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}