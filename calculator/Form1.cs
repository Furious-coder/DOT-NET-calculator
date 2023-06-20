namespace calculator
{
    public partial class Form1 : Form
    {
        private decimal first = 0.0m;
        private decimal second = 0.0m;
        private decimal result = 0.0m;
        private string operators = "+";
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (num.Text == "0")
            {
                num.Text = "3";
            }
            else
            {
                num.Text += 3;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            num.Clear();
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (num.Text == "0")
            {
                num.Text = "0";
            }
            else
            {
                num.Text += 0;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (num.Text == "0")
            {
                num.Text = "1";
            }
            else
            {
                num.Text += 1;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (num.Text == "0")
            {
                num.Text = "2";
            }
            else
            {
                num.Text += 2;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (num.Text == "0")
            {
                num.Text = "4";
            }
            else
            {
                num.Text += 4;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (num.Text == "0")
            {
                num.Text = "5";
            }
            else
            {
                num.Text += 5;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (num.Text == "0")
            {
                num.Text = "6";
            }
            else
            {
                num.Text += 6;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (num.Text == "0")
            {
                num.Text = "7";
            }
            else
            {
                num.Text += 7;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (num.Text == "0")
            {
                num.Text = "8";
            }
            else
            {
                num.Text += 8;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (num.Text == "0")
            {
                num.Text = "9";
            }
            else
            {
                num.Text += 9;
            }
        }

        private void plus_Click(object sender, EventArgs e)
        {
            first = decimal.Parse(num.Text);
            num.Clear();
            operators = "+";
        }

        private void minus_Click(object sender, EventArgs e)
        {
            first = decimal.Parse(num.Text);
            num.Clear();
            operators = "-";
        }

        private void multiply_Click(object sender, EventArgs e)
        {
            first = decimal.Parse(num.Text);
            num.Clear();
            operators = "*";
        }

        private void divide_Click(object sender, EventArgs e)
        {
            first = decimal.Parse(num.Text);
            num.Clear();
            operators = "/";
        }

        private void equals_Click(object sender, EventArgs e)
        {
            switch (operators)
            {
                case "+":
                    second = decimal.Parse(num.Text);
                    result=first+second;
                    num.Text = result.ToString();
                    break;
                case "-":
                    second = decimal.Parse(num.Text);
                    result=first-second;
                    num.Text = result.ToString(); break;
                case "*":
                    second = decimal.Parse(num.Text);
                    result=first*second;
                        num.Text = result.ToString(); break;
                case "/":
                    second = decimal.Parse(num.Text);
                    result=first/second;
                    num.Text = result.ToString(); break;

            }
        }
    }
}