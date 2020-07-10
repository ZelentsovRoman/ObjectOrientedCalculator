namespace ObjectOrientedCalculator
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button20 = new System.Windows.Forms.Button();
            this.Plus = new System.Windows.Forms.Button();
            this.Minus = new System.Windows.Forms.Button();
            this.Mult = new System.Windows.Forms.Button();
            this.Div = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button16 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.Max = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Exp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button20
            // 
            this.button20.Location = new System.Drawing.Point(12, 279);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(39, 32);
            this.button20.TabIndex = 65;
            this.button20.Text = "+ / -";
            this.button20.UseVisualStyleBackColor = true;
            this.button20.Click += new System.EventHandler(this.button20_Click);
            // 
            // Plus
            // 
            this.Plus.Location = new System.Drawing.Point(192, 228);
            this.Plus.Name = "Plus";
            this.Plus.Size = new System.Drawing.Size(39, 32);
            this.Plus.TabIndex = 64;
            this.Plus.Text = "+";
            this.Plus.UseVisualStyleBackColor = true;
            this.Plus.Click += new System.EventHandler(this.operChoose);
            // 
            // Minus
            // 
            this.Minus.Location = new System.Drawing.Point(192, 179);
            this.Minus.Name = "Minus";
            this.Minus.Size = new System.Drawing.Size(39, 32);
            this.Minus.TabIndex = 63;
            this.Minus.Text = "-";
            this.Minus.UseVisualStyleBackColor = true;
            this.Minus.Click += new System.EventHandler(this.operChoose);
            // 
            // Mult
            // 
            this.Mult.Location = new System.Drawing.Point(192, 131);
            this.Mult.Name = "Mult";
            this.Mult.Size = new System.Drawing.Size(39, 32);
            this.Mult.TabIndex = 62;
            this.Mult.Text = "*";
            this.Mult.UseVisualStyleBackColor = true;
            this.Mult.Click += new System.EventHandler(this.operChoose);
            // 
            // Div
            // 
            this.Div.Location = new System.Drawing.Point(192, 79);
            this.Div.Name = "Div";
            this.Div.Size = new System.Drawing.Size(39, 32);
            this.Div.TabIndex = 61;
            this.Div.Text = "/";
            this.Div.UseVisualStyleBackColor = true;
            this.Div.Click += new System.EventHandler(this.operChoose);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(219, 49);
            this.textBox1.TabIndex = 60;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox1_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 59;
            this.label1.Text = "label1";
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(129, 279);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(39, 32);
            this.button16.TabIndex = 58;
            this.button16.Text = ".";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(192, 279);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(39, 32);
            this.button15.TabIndex = 57;
            this.button15.Text = "=";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // Max
            // 
            this.Max.Location = new System.Drawing.Point(12, 79);
            this.Max.Name = "Max";
            this.Max.Size = new System.Drawing.Size(39, 32);
            this.Max.TabIndex = 56;
            this.Max.Text = "max";
            this.Max.UseVisualStyleBackColor = true;
            this.Max.Click += new System.EventHandler(this.operChoose);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(12, 131);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(39, 32);
            this.button12.TabIndex = 55;
            this.button12.Text = "7";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(67, 131);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(39, 32);
            this.button11.TabIndex = 54;
            this.button11.Text = "8";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(67, 179);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(39, 32);
            this.button10.TabIndex = 53;
            this.button10.Text = "5";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(12, 179);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(39, 32);
            this.button9.TabIndex = 52;
            this.button9.Text = "4";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(129, 131);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(39, 32);
            this.button8.TabIndex = 51;
            this.button8.Text = "9";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(129, 179);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(39, 32);
            this.button7.TabIndex = 50;
            this.button7.Text = "6";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(129, 228);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(39, 32);
            this.button6.TabIndex = 49;
            this.button6.Text = "3";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(67, 228);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(39, 32);
            this.button5.TabIndex = 48;
            this.button5.Text = "2";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(147, 79);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(39, 32);
            this.button4.TabIndex = 47;
            this.button4.Text = "C";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 228);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(39, 32);
            this.button3.TabIndex = 46;
            this.button3.Text = "1";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(67, 279);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(39, 32);
            this.button2.TabIndex = 45;
            this.button2.Text = "0";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(102, 79);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(39, 32);
            this.button1.TabIndex = 44;
            this.button1.Text = "CE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Exp
            // 
            this.Exp.Location = new System.Drawing.Point(57, 79);
            this.Exp.Name = "Exp";
            this.Exp.Size = new System.Drawing.Size(39, 32);
            this.Exp.TabIndex = 66;
            this.Exp.Text = "exp";
            this.Exp.UseVisualStyleBackColor = true;
            this.Exp.Click += new System.EventHandler(this.funcChoose);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(242, 327);
            this.Controls.Add(this.Exp);
            this.Controls.Add(this.button20);
            this.Controls.Add(this.Plus);
            this.Controls.Add(this.Minus);
            this.Controls.Add(this.Mult);
            this.Controls.Add(this.Div);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.Max);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button Plus;
        private System.Windows.Forms.Button Minus;
        private System.Windows.Forms.Button Mult;
        private System.Windows.Forms.Button Div;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button Max;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Exp;
    }
}

