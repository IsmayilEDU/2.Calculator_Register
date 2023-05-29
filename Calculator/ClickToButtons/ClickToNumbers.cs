  using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public partial class Form1 : Form
    {

        private void ClickToZero(object sender, MouseEventArgs e)
        {
            _numberSTR += "0";
            Result.Text = _numberSTR;
        }

        private void ClickToOne(object sender, MouseEventArgs e)
        {
            _numberSTR += "1";
            Result.Text= _numberSTR;
        }

        private void ClickToTwo(object sender, MouseEventArgs e)
        {
            _numberSTR += "2";
            Result.Text = _numberSTR;
        }

        private void ClickToThree(object sender, MouseEventArgs e)
        {
            _numberSTR += "3";
            Result.Text = _numberSTR;
        }

        private void ClickToFour(object sender, MouseEventArgs e)
        {
            _numberSTR += "4";
            Result.Text = _numberSTR;
        }

        private void ClickToFive(object sender, MouseEventArgs e)
        {
            _numberSTR += "5";
            Result.Text = _numberSTR;
        }

        private void ClickToSix(object sender, MouseEventArgs e)
        {
            _numberSTR += "6";
            Result.Text = _numberSTR;
        }

        private void ClickToSeven(object sender, MouseEventArgs e)
        {
            _numberSTR += "7";
            Result.Text = _numberSTR;
        }

        private void ClickToEight(object sender, MouseEventArgs e)
        {
            _numberSTR += "8";
            Result.Text = _numberSTR;
        }

        private void ClickToNine(object sender, MouseEventArgs e)
        {
            _numberSTR += "9";
            Result.Text = _numberSTR;
        }
    }
}
