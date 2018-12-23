namespace WindowsForms
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.sign = new System.Windows.Forms.Button();
            this.equal = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.multi = new System.Windows.Forms.Button();
            this.division = new System.Windows.Forms.Button();
            this.zero = new System.Windows.Forms.Button();
            this.three = new System.Windows.Forms.Button();
            this.two = new System.Windows.Forms.Button();
            this.one = new System.Windows.Forms.Button();
            this.six = new System.Windows.Forms.Button();
            this.five = new System.Windows.Forms.Button();
            this.four = new System.Windows.Forms.Button();
            this.nine = new System.Windows.Forms.Button();
            this.eight = new System.Windows.Forms.Button();
            this.screen = new System.Windows.Forms.TextBox();
            this.seven = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.button1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button1.Location = new System.Drawing.Point(129, 230);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(53, 33);
            this.button1.TabIndex = 38;
            this.button1.Text = ".";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.DotClick);
            // 
            // sign
            // 
            this.sign.BackColor = System.Drawing.SystemColors.Control;
            this.sign.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.sign.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.sign.Location = new System.Drawing.Point(70, 73);
            this.sign.Name = "sign";
            this.sign.Size = new System.Drawing.Size(53, 33);
            this.sign.TabIndex = 37;
            this.sign.Text = "+/-";
            this.sign.UseVisualStyleBackColor = false;
            this.sign.Click += new System.EventHandler(this.SignClick);
            // 
            // equal
            // 
            this.equal.BackColor = System.Drawing.SystemColors.Control;
            this.equal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.equal.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.equal.Location = new System.Drawing.Point(188, 191);
            this.equal.Name = "equal";
            this.equal.Size = new System.Drawing.Size(53, 72);
            this.equal.TabIndex = 21;
            this.equal.Text = "=";
            this.equal.UseVisualStyleBackColor = false;
            this.equal.Click += new System.EventHandler(this.OperationClick);
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.SystemColors.Control;
            this.clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.clear.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.clear.Location = new System.Drawing.Point(11, 74);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(53, 33);
            this.clear.TabIndex = 36;
            this.clear.Text = "C";
            this.clear.UseVisualStyleBackColor = false;
            this.clear.Click += new System.EventHandler(this.ClearClick);
            // 
            // plus
            // 
            this.plus.BackColor = System.Drawing.SystemColors.Control;
            this.plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.plus.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.plus.Location = new System.Drawing.Point(188, 152);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(53, 33);
            this.plus.TabIndex = 35;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = false;
            this.plus.Click += new System.EventHandler(this.OperationClick);
            // 
            // minus
            // 
            this.minus.BackColor = System.Drawing.SystemColors.Control;
            this.minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.minus.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.minus.Location = new System.Drawing.Point(188, 112);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(53, 33);
            this.minus.TabIndex = 34;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = false;
            this.minus.Click += new System.EventHandler(this.OperationClick);
            // 
            // multi
            // 
            this.multi.BackColor = System.Drawing.SystemColors.Control;
            this.multi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.multi.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.multi.Location = new System.Drawing.Point(188, 73);
            this.multi.Name = "multi";
            this.multi.Size = new System.Drawing.Size(53, 33);
            this.multi.TabIndex = 33;
            this.multi.Text = "*";
            this.multi.UseVisualStyleBackColor = false;
            this.multi.Click += new System.EventHandler(this.OperationClick);
            // 
            // division
            // 
            this.division.BackColor = System.Drawing.SystemColors.Control;
            this.division.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.division.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.division.Location = new System.Drawing.Point(129, 73);
            this.division.Name = "division";
            this.division.Size = new System.Drawing.Size(53, 33);
            this.division.TabIndex = 32;
            this.division.Text = "/";
            this.division.UseVisualStyleBackColor = false;
            this.division.Click += new System.EventHandler(this.OperationClick);
            // 
            // zero
            // 
            this.zero.BackColor = System.Drawing.SystemColors.Control;
            this.zero.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.zero.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.zero.Location = new System.Drawing.Point(11, 230);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(112, 33);
            this.zero.TabIndex = 31;
            this.zero.Text = "0";
            this.zero.UseVisualStyleBackColor = false;
            this.zero.Click += new System.EventHandler(this.NumberClick);
            // 
            // three
            // 
            this.three.BackColor = System.Drawing.SystemColors.Control;
            this.three.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.three.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.three.Location = new System.Drawing.Point(129, 191);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(53, 33);
            this.three.TabIndex = 30;
            this.three.Text = "3";
            this.three.UseVisualStyleBackColor = false;
            this.three.Click += new System.EventHandler(this.NumberClick);
            // 
            // two
            // 
            this.two.BackColor = System.Drawing.SystemColors.Control;
            this.two.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.two.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.two.Location = new System.Drawing.Point(70, 191);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(53, 33);
            this.two.TabIndex = 29;
            this.two.Text = "2";
            this.two.UseVisualStyleBackColor = false;
            this.two.Click += new System.EventHandler(this.NumberClick);
            // 
            // one
            // 
            this.one.BackColor = System.Drawing.SystemColors.Control;
            this.one.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.one.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.one.Location = new System.Drawing.Point(11, 191);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(53, 33);
            this.one.TabIndex = 28;
            this.one.Tag = "";
            this.one.Text = "1";
            this.one.UseVisualStyleBackColor = false;
            this.one.Click += new System.EventHandler(this.NumberClick);
            // 
            // six
            // 
            this.six.BackColor = System.Drawing.SystemColors.Control;
            this.six.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.six.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.six.Location = new System.Drawing.Point(129, 152);
            this.six.Name = "six";
            this.six.Size = new System.Drawing.Size(53, 33);
            this.six.TabIndex = 27;
            this.six.Text = "6";
            this.six.UseVisualStyleBackColor = false;
            this.six.Click += new System.EventHandler(this.NumberClick);
            // 
            // five
            // 
            this.five.BackColor = System.Drawing.SystemColors.Control;
            this.five.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.five.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.five.Location = new System.Drawing.Point(70, 152);
            this.five.Name = "five";
            this.five.Size = new System.Drawing.Size(53, 33);
            this.five.TabIndex = 26;
            this.five.Text = "5";
            this.five.UseVisualStyleBackColor = false;
            this.five.Click += new System.EventHandler(this.NumberClick);
            // 
            // four
            // 
            this.four.BackColor = System.Drawing.SystemColors.Control;
            this.four.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.four.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.four.Location = new System.Drawing.Point(11, 152);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(53, 33);
            this.four.TabIndex = 25;
            this.four.Text = "4";
            this.four.UseVisualStyleBackColor = false;
            this.four.Click += new System.EventHandler(this.NumberClick);
            // 
            // nine
            // 
            this.nine.BackColor = System.Drawing.SystemColors.Control;
            this.nine.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.nine.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.nine.Location = new System.Drawing.Point(129, 113);
            this.nine.Name = "nine";
            this.nine.Size = new System.Drawing.Size(53, 33);
            this.nine.TabIndex = 24;
            this.nine.Text = "9";
            this.nine.UseVisualStyleBackColor = false;
            this.nine.Click += new System.EventHandler(this.NumberClick);
            // 
            // eight
            // 
            this.eight.BackColor = System.Drawing.SystemColors.Control;
            this.eight.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.eight.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.eight.Location = new System.Drawing.Point(70, 113);
            this.eight.Name = "eight";
            this.eight.Size = new System.Drawing.Size(53, 33);
            this.eight.TabIndex = 23;
            this.eight.Text = "8";
            this.eight.UseVisualStyleBackColor = false;
            this.eight.Click += new System.EventHandler(this.NumberClick);
            // 
            // screen
            // 
            this.screen.BackColor = System.Drawing.SystemColors.Control;
            this.screen.Cursor = System.Windows.Forms.Cursors.Default;
            this.screen.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.screen.Location = new System.Drawing.Point(10, 9);
            this.screen.Name = "screen";
            this.screen.ReadOnly = true;
            this.screen.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.screen.Size = new System.Drawing.Size(230, 45);
            this.screen.TabIndex = 22;
            this.screen.Text = "0";
            this.screen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // seven
            // 
            this.seven.BackColor = System.Drawing.SystemColors.Control;
            this.seven.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.seven.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.seven.Location = new System.Drawing.Point(11, 113);
            this.seven.Name = "seven";
            this.seven.Size = new System.Drawing.Size(53, 33);
            this.seven.TabIndex = 20;
            this.seven.Text = "7";
            this.seven.UseVisualStyleBackColor = false;
            this.seven.Click += new System.EventHandler(this.NumberClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 275);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.sign);
            this.Controls.Add(this.equal);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.multi);
            this.Controls.Add(this.division);
            this.Controls.Add(this.zero);
            this.Controls.Add(this.three);
            this.Controls.Add(this.two);
            this.Controls.Add(this.one);
            this.Controls.Add(this.six);
            this.Controls.Add(this.five);
            this.Controls.Add(this.four);
            this.Controls.Add(this.nine);
            this.Controls.Add(this.eight);
            this.Controls.Add(this.screen);
            this.Controls.Add(this.seven);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button sign;
        private System.Windows.Forms.Button equal;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button multi;
        private System.Windows.Forms.Button division;
        private System.Windows.Forms.Button zero;
        private System.Windows.Forms.Button three;
        private System.Windows.Forms.Button two;
        private System.Windows.Forms.Button one;
        private System.Windows.Forms.Button six;
        private System.Windows.Forms.Button five;
        private System.Windows.Forms.Button four;
        private System.Windows.Forms.Button nine;
        private System.Windows.Forms.Button eight;
        private System.Windows.Forms.TextBox screen;
        private System.Windows.Forms.Button seven;
    }
}

