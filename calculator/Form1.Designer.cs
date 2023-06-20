namespace calculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            num = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button0 = new Button();
            plus = new Button();
            minus = new Button();
            multiply = new Button();
            divide = new Button();
            equals = new Button();
            clear = new Button();
            SuspendLayout();
            // 
            // num
            // 
            num.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            num.Location = new Point(396, 26);
            num.Name = "num";
            num.Size = new Size(217, 61);
            num.TabIndex = 0;
            num.Text = "0";
            num.TextAlign = HorizontalAlignment.Right;
            // 
            // button1
            // 
            button1.Location = new Point(33, 120);
            button1.Name = "button1";
            button1.Size = new Size(85, 81);
            button1.TabIndex = 1;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(148, 120);
            button2.Name = "button2";
            button2.Size = new Size(85, 81);
            button2.TabIndex = 2;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(267, 120);
            button3.Name = "button3";
            button3.Size = new Size(85, 81);
            button3.TabIndex = 3;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(33, 235);
            button4.Name = "button4";
            button4.Size = new Size(85, 81);
            button4.TabIndex = 4;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(148, 235);
            button5.Name = "button5";
            button5.Size = new Size(85, 81);
            button5.TabIndex = 5;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(267, 235);
            button6.Name = "button6";
            button6.Size = new Size(85, 81);
            button6.TabIndex = 6;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(33, 357);
            button7.Name = "button7";
            button7.Size = new Size(85, 81);
            button7.TabIndex = 7;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Location = new Point(148, 357);
            button8.Name = "button8";
            button8.Size = new Size(85, 81);
            button8.TabIndex = 8;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Location = new Point(267, 357);
            button9.Name = "button9";
            button9.Size = new Size(85, 81);
            button9.TabIndex = 9;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button0
            // 
            button0.Location = new Point(378, 357);
            button0.Name = "button0";
            button0.Size = new Size(85, 81);
            button0.TabIndex = 10;
            button0.Text = "0";
            button0.UseVisualStyleBackColor = true;
            button0.Click += button0_Click;
            // 
            // plus
            // 
            plus.Location = new Point(378, 120);
            plus.Name = "plus";
            plus.Size = new Size(85, 136);
            plus.TabIndex = 11;
            plus.Text = "+";
            plus.UseVisualStyleBackColor = true;
            plus.Click += plus_Click;
            // 
            // minus
            // 
            minus.Location = new Point(483, 120);
            minus.Name = "minus";
            minus.Size = new Size(85, 136);
            minus.TabIndex = 12;
            minus.Text = "-";
            minus.UseVisualStyleBackColor = true;
            minus.Click += minus_Click;
            // 
            // multiply
            // 
            multiply.Location = new Point(378, 258);
            multiply.Name = "multiply";
            multiply.Size = new Size(85, 93);
            multiply.TabIndex = 13;
            multiply.Text = "*";
            multiply.UseVisualStyleBackColor = true;
            multiply.Click += multiply_Click;
            // 
            // divide
            // 
            divide.Location = new Point(486, 262);
            divide.Name = "divide";
            divide.Size = new Size(82, 89);
            divide.TabIndex = 14;
            divide.Text = "/";
            divide.UseVisualStyleBackColor = true;
            divide.Click += divide_Click;
            // 
            // equals
            // 
            equals.Location = new Point(483, 357);
            equals.Name = "equals";
            equals.Size = new Size(149, 92);
            equals.TabIndex = 15;
            equals.Text = "=";
            equals.UseVisualStyleBackColor = true;
            equals.Click += equals_Click;
            // 
            // clear
            // 
            clear.Location = new Point(574, 120);
            clear.Name = "clear";
            clear.Size = new Size(47, 81);
            clear.TabIndex = 16;
            clear.Text = "clr";
            clear.UseVisualStyleBackColor = true;
            clear.Click += button10_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(633, 450);
            Controls.Add(clear);
            Controls.Add(equals);
            Controls.Add(divide);
            Controls.Add(multiply);
            Controls.Add(minus);
            Controls.Add(plus);
            Controls.Add(button0);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(num);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox num;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button0;
        private Button plus;
        private Button minus;
        private Button multiply;
        private Button divide;
        private Button equals;
        private Button clear;
    }
}