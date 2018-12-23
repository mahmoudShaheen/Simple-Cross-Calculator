using System;
using System.Windows.Forms;
using CalculatorLibrary;

namespace WindowsForms
{
    public partial class Form1 : Form
    {
        Calc Calc = new Calc();

        public Form1()
        {
            InitializeComponent();
        }

        private void OperationClick(object sender, EventArgs e)
        {
            screen.Text = Calc.OperationClickHandler(screen.Text, (sender as Button).Text);
        }

        private void SignClick(object sender, EventArgs e)
        {
            screen.Text = Calc.SignClickHandler(screen.Text);
        }

        private void ClearClick(object sender, EventArgs e)
        {
            screen.Text = Calc.ClearClickHandler();
        }

        private void DotClick(object sender, EventArgs e)
        {
            screen.Text = Calc.DotClickHandler(screen.Text);
        }

        private void NumberClick(object sender, EventArgs e)
        {
            screen.Text = Calc.NumberClickHandler(screen.Text, (sender as Button).Text);
        }
    }
}
