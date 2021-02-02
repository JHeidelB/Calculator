
using System;

namespace Jamae_Calc_Lab1
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
            this.inputandoutput = new System.Windows.Forms.TextBox();
            this.Sqrt = new System.Windows.Forms.Button();
            this.xsquared = new System.Windows.Forms.Button();
            this.xpowery = new System.Windows.Forms.Button();
            this.onedividedbyx = new System.Windows.Forms.Button();
            this.divide = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.clearentry = new System.Windows.Forms.Button();
            this.multiply = new System.Windows.Forms.Button();
            this.nine = new System.Windows.Forms.Button();
            this.eight = new System.Windows.Forms.Button();
            this.seven = new System.Windows.Forms.Button();
            this.equals = new System.Windows.Forms.Button();
            this.period = new System.Windows.Forms.Button();
            this.zero = new System.Windows.Forms.Button();
            this.positiveornegative = new System.Windows.Forms.Button();
            this.addition = new System.Windows.Forms.Button();
            this.three = new System.Windows.Forms.Button();
            this.two = new System.Windows.Forms.Button();
            this.one = new System.Windows.Forms.Button();
            this.subtract = new System.Windows.Forms.Button();
            this.six = new System.Windows.Forms.Button();
            this.five = new System.Windows.Forms.Button();
            this.four = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inputandoutput
            // 
            this.inputandoutput.Location = new System.Drawing.Point(13, 13);
            this.inputandoutput.Name = "inputandoutput";
            this.inputandoutput.Size = new System.Drawing.Size(354, 39);
            this.inputandoutput.TabIndex = 0;
            // 
            // Sqrt
            // 
            this.Sqrt.Location = new System.Drawing.Point(13, 58);
            this.Sqrt.Name = "Sqrt";
            this.Sqrt.Size = new System.Drawing.Size(84, 49);
            this.Sqrt.TabIndex = 1;
            this.Sqrt.Text = "SQRT";
            this.Sqrt.UseVisualStyleBackColor = true;
            this.Sqrt.Click += new System.EventHandler(this.Sqrt_Click);
            // 
            // xsquared
            // 
            this.xsquared.Location = new System.Drawing.Point(103, 58);
            this.xsquared.Name = "xsquared";
            this.xsquared.Size = new System.Drawing.Size(84, 49);
            this.xsquared.TabIndex = 2;
            this.xsquared.Text = "x^2";
            this.xsquared.UseVisualStyleBackColor = true;
            this.xsquared.Click += new System.EventHandler(this.xsquared_Click);
            // 
            // xpowery
            // 
            this.xpowery.Location = new System.Drawing.Point(193, 58);
            this.xpowery.Name = "xpowery";
            this.xpowery.Size = new System.Drawing.Size(84, 49);
            this.xpowery.TabIndex = 3;
            this.xpowery.Text = "x^y";
            this.xpowery.UseVisualStyleBackColor = true;
            this.xpowery.Click += new System.EventHandler(this.xpowery_Click);
            // 
            // onedividedbyx
            // 
            this.onedividedbyx.Location = new System.Drawing.Point(283, 58);
            this.onedividedbyx.Name = "onedividedbyx";
            this.onedividedbyx.Size = new System.Drawing.Size(84, 49);
            this.onedividedbyx.TabIndex = 4;
            this.onedividedbyx.Text = "1/x";
            this.onedividedbyx.UseVisualStyleBackColor = true;
            this.onedividedbyx.Click += new System.EventHandler(this.onedividedbyx_Click);
            // 
            // divide
            // 
            this.divide.Location = new System.Drawing.Point(283, 113);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(84, 49);
            this.divide.TabIndex = 8;
            this.divide.Text = "/";
            this.divide.UseVisualStyleBackColor = true;
            this.divide.Click += new System.EventHandler(this.divide_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(193, 113);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(84, 49);
            this.delete.TabIndex = 7;
            this.delete.Text = "DEL.";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(103, 113);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(84, 49);
            this.clear.TabIndex = 6;
            this.clear.Text = "C";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // clearentry
            // 
            this.clearentry.Location = new System.Drawing.Point(13, 113);
            this.clearentry.Name = "clearentry";
            this.clearentry.Size = new System.Drawing.Size(84, 49);
            this.clearentry.TabIndex = 5;
            this.clearentry.Text = "CE";
            this.clearentry.UseVisualStyleBackColor = true;
            this.clearentry.Click += new System.EventHandler(this.clearentry_Click);
            // 
            // multiply
            // 
            this.multiply.Location = new System.Drawing.Point(283, 168);
            this.multiply.Name = "multiply";
            this.multiply.Size = new System.Drawing.Size(84, 49);
            this.multiply.TabIndex = 12;
            this.multiply.Text = "X";
            this.multiply.UseVisualStyleBackColor = true;
            this.multiply.Click += new System.EventHandler(this.multiply_Click);
            // 
            // nine
            // 
            this.nine.Location = new System.Drawing.Point(193, 168);
            this.nine.Name = "nine";
            this.nine.Size = new System.Drawing.Size(84, 49);
            this.nine.TabIndex = 11;
            this.nine.Text = "9";
            this.nine.UseVisualStyleBackColor = true;
            this.nine.Click += new System.EventHandler(this.nine_Click);
            // 
            // eight
            // 
            this.eight.Location = new System.Drawing.Point(103, 168);
            this.eight.Name = "eight";
            this.eight.Size = new System.Drawing.Size(84, 49);
            this.eight.TabIndex = 10;
            this.eight.Text = "8";
            this.eight.UseVisualStyleBackColor = true;
            this.eight.Click += new System.EventHandler(this.eight_Click);
            // 
            // seven
            // 
            this.seven.Location = new System.Drawing.Point(13, 168);
            this.seven.Name = "seven";
            this.seven.Size = new System.Drawing.Size(84, 49);
            this.seven.TabIndex = 9;
            this.seven.Text = "7";
            this.seven.UseVisualStyleBackColor = true;
            this.seven.Click += new System.EventHandler(this.seven_Click);
            // 
            // equals
            // 
            this.equals.Location = new System.Drawing.Point(283, 331);
            this.equals.Name = "equals";
            this.equals.Size = new System.Drawing.Size(84, 49);
            this.equals.TabIndex = 24;
            this.equals.Text = "=";
            this.equals.UseVisualStyleBackColor = true;
            this.equals.Click += new System.EventHandler(this.equals_Click);
            // 
            // period
            // 
            this.period.Location = new System.Drawing.Point(193, 331);
            this.period.Name = "period";
            this.period.Size = new System.Drawing.Size(84, 49);
            this.period.TabIndex = 23;
            this.period.Text = ".";
            this.period.UseVisualStyleBackColor = true;
            this.period.Click += new System.EventHandler(this.period_Click);
            // 
            // zero
            // 
            this.zero.Location = new System.Drawing.Point(103, 331);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(84, 49);
            this.zero.TabIndex = 22;
            this.zero.Text = "0";
            this.zero.UseVisualStyleBackColor = true;
            this.zero.Click += new System.EventHandler(this.zero_Click);
            // 
            // positiveornegative
            // 
            this.positiveornegative.Location = new System.Drawing.Point(13, 331);
            this.positiveornegative.Name = "positiveornegative";
            this.positiveornegative.Size = new System.Drawing.Size(84, 49);
            this.positiveornegative.TabIndex = 21;
            this.positiveornegative.Text = "+/-";
            this.positiveornegative.UseVisualStyleBackColor = true;
            this.positiveornegative.Click += new System.EventHandler(this.positiveornegative_Click);
            // 
            // addition
            // 
            this.addition.Location = new System.Drawing.Point(283, 276);
            this.addition.Name = "addition";
            this.addition.Size = new System.Drawing.Size(84, 49);
            this.addition.TabIndex = 20;
            this.addition.Text = "+";
            this.addition.UseVisualStyleBackColor = true;
            this.addition.Click += new System.EventHandler(this.addition_Click);
            // 
            // three
            // 
            this.three.Location = new System.Drawing.Point(193, 276);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(84, 49);
            this.three.TabIndex = 19;
            this.three.Text = "3";
            this.three.UseVisualStyleBackColor = true;
            this.three.Click += new System.EventHandler(this.three_Click);
            // 
            // two
            // 
            this.two.Location = new System.Drawing.Point(103, 276);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(84, 49);
            this.two.TabIndex = 18;
            this.two.Text = "2";
            this.two.UseVisualStyleBackColor = true;
            this.two.Click += new System.EventHandler(this.two_Click);
            // 
            // one
            // 
            this.one.Location = new System.Drawing.Point(13, 276);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(84, 49);
            this.one.TabIndex = 17;
            this.one.Text = "1";
            this.one.UseVisualStyleBackColor = true;
            this.one.Click += new System.EventHandler(this.one_Click);
            // 
            // subtract
            // 
            this.subtract.Location = new System.Drawing.Point(283, 221);
            this.subtract.Name = "subtract";
            this.subtract.Size = new System.Drawing.Size(84, 49);
            this.subtract.TabIndex = 16;
            this.subtract.Text = "-";
            this.subtract.UseVisualStyleBackColor = true;
            this.subtract.Click += new System.EventHandler(this.subtract_Click);
            // 
            // six
            // 
            this.six.Location = new System.Drawing.Point(193, 221);
            this.six.Name = "six";
            this.six.Size = new System.Drawing.Size(84, 49);
            this.six.TabIndex = 15;
            this.six.Text = "6";
            this.six.UseVisualStyleBackColor = true;
            this.six.Click += new System.EventHandler(this.six_Click);
            // 
            // five
            // 
            this.five.Location = new System.Drawing.Point(103, 223);
            this.five.Name = "five";
            this.five.Size = new System.Drawing.Size(84, 49);
            this.five.TabIndex = 14;
            this.five.Text = "5";
            this.five.UseVisualStyleBackColor = true;
            this.five.Click += new System.EventHandler(this.five_Click);
            // 
            // four
            // 
            this.four.Location = new System.Drawing.Point(13, 223);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(84, 49);
            this.four.TabIndex = 13;
            this.four.Text = "4";
            this.four.UseVisualStyleBackColor = true;
            this.four.Click += new System.EventHandler(this.four_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 385);
            this.Controls.Add(this.equals);
            this.Controls.Add(this.period);
            this.Controls.Add(this.zero);
            this.Controls.Add(this.positiveornegative);
            this.Controls.Add(this.addition);
            this.Controls.Add(this.three);
            this.Controls.Add(this.two);
            this.Controls.Add(this.one);
            this.Controls.Add(this.subtract);
            this.Controls.Add(this.six);
            this.Controls.Add(this.five);
            this.Controls.Add(this.four);
            this.Controls.Add(this.multiply);
            this.Controls.Add(this.nine);
            this.Controls.Add(this.eight);
            this.Controls.Add(this.seven);
            this.Controls.Add(this.divide);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.clearentry);
            this.Controls.Add(this.onedividedbyx);
            this.Controls.Add(this.xpowery);
            this.Controls.Add(this.xsquared);
            this.Controls.Add(this.Sqrt);
            this.Controls.Add(this.inputandoutput);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Sqrt;
        private System.Windows.Forms.Button xsquared;
        private System.Windows.Forms.Button xpowery;
        private System.Windows.Forms.Button onedividedbyx;
        private System.Windows.Forms.Button divide;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button clearentry;
        private System.Windows.Forms.Button multiply;
        private System.Windows.Forms.Button nine;
        private System.Windows.Forms.Button eight;
        private System.Windows.Forms.Button seven;
        private System.Windows.Forms.Button equals;
        private System.Windows.Forms.Button period;
        private System.Windows.Forms.Button zero;
        private System.Windows.Forms.Button positiveornegative;
        private System.Windows.Forms.Button addition;
        private System.Windows.Forms.Button three;
        private System.Windows.Forms.Button two;
        private System.Windows.Forms.Button one;
        private System.Windows.Forms.Button subtract;
        private System.Windows.Forms.Button six;
        private System.Windows.Forms.Button five;
        private System.Windows.Forms.Button four;
        private System.Windows.Forms.TextBox inputandoutput;

        public EventHandler inputandoutput_TextChanged { get; private set; }
    }
}

