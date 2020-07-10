using System;
using System.Windows.Forms;
using ObjectOrientedCalculator.Operations;


namespace ObjectOrientedCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        RichTextBox openRichTextBox = new RichTextBox();
        double a, b;
        bool zn = true;
        string Operation;
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 0;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (zn == true)
            {
                textBox1.Text = "-" + textBox1.Text;
                zn = false;
            }
            else if (zn == false)
            {
                textBox1.Text = textBox1.Text.Replace("-", "");
                zn = true;
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ",";
        }
        private void operChoose(object sender, EventArgs e)
        {
            a = float.Parse(textBox1.Text);
            textBox1.Clear();
            Operation = ((Button)sender).Name;
            
        }
        private void funcChoose(object sender, EventArgs e)
        {
            a = float.Parse(textBox1.Text);
            Operation = ((Button)sender).Name;
            IOneArgCalculator calculator = OneArgFactory.CreateObjectOrientedCalculator(Operation);
            b = calculator.Calculate(a);
            textBox1.Text = b.ToString();
        }
        private void button15_Click(object sender, EventArgs e)
        {
            b = Convert.ToDouble(textBox1.Text);
            ITwoArgCalculator calculator = TwoArgFactory.CreateObjectOrientedCalculator(Operation);
            double res = calculator.Calculate(a, b);
            textBox1.Text = res.ToString();
        }
        
        //ограничение ввода символов с клавиатуры
        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (Char.IsDigit(e.KeyChar)) return;
            else
                e.Handled = true;
        }
        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 7;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 8;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 9;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 4;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 5;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 6;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 1;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 2;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 3;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int lenght = textBox1.Text.Length - 1;
            string text = textBox1.Text;
            textBox1.Clear();
            for (int i = 0; i < lenght; i++)
            {
                textBox1.Text = textBox1.Text + text[i];
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            label1.Text = "";
        }
    }
}
