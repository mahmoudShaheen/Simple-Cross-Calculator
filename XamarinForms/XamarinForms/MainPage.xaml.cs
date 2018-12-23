using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using CalculatorLibrary;

namespace XamarinForms
{
    public partial class MainPage : ContentPage
    {
        Calc Calc = new Calc();

        public MainPage()
        {
            InitializeComponent();
        }
        void NumberClick(object sender, EventArgs e)
        {
            screen.Text = Calc.NumberClickHandler(screen.Text, (sender as Button).Text);
        }
        void OperationClick(object sender, EventArgs e)
        {
            screen.Text = Calc.OperationClickHandler(screen.Text, (sender as Button).Text);
        }
        void SignClick(object sender, EventArgs e)
        {
            screen.Text = Calc.SignClickHandler(screen.Text);
        }
        void DotClick(object sender, EventArgs e)
        {
            screen.Text = Calc.DotClickHandler(screen.Text);
        }
        void ClearClick(object sender, EventArgs e)
        {
            screen.Text = Calc.ClearClickHandler();
        }
    }
}
