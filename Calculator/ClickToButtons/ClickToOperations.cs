using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public partial class Form1 : Form
    {
        private void ClickToAddition(object sender, MouseEventArgs e)
        {
            _operation = "+";
            _number1 = Convert.ToInt32(_numberSTR);
            Result.Text = _number1.ToString() + "\n" + _operation;
            _numberSTR = "";
        }

        private void ClickToSubtract(object sender, MouseEventArgs e)
        {
            _operation = "-";
            _number1 = Convert.ToInt32(_numberSTR);
            Result.Text = _number1.ToString() + "\n" + _operation;
            _numberSTR = "";
        }

        private void ClickToMultiplication(object sender, MouseEventArgs e)
        {
            _operation = "*";
            _number1 = Convert.ToInt32(_numberSTR);
            Result.Text = _number1.ToString() + "\n" + _operation;
            _numberSTR = "";
        }

        private void ClickToDivide(object sender, MouseEventArgs e)
        {
            _operation = "/";
            _number1 = Convert.ToInt32(_numberSTR);
            Result.Text = _number1.ToString() + "\n" + _operation;
            _numberSTR = "";
        }

        private void ClikToBackSpace(object sender, MouseEventArgs e)
        {
            if (_numberSTR.Length >= 1)
            {
                _numberSTR = _numberSTR.Remove(_numberSTR.Length - 1);
                if (_numberSTR.Length == 0)
                {
                    Result.Text = "0";
                }
                else
                {
                    Result.Text = _numberSTR;
                }
            }
            else
            {
                Result.Text = "0";
            }
        }

        private void ClikToEqual(object sender, MouseEventArgs e)
        {
            if (_numberSTR != "")
            {
                _number2 = Convert.ToInt32(_numberSTR);
            }
            

            //  Addition operation
            if (_operation == "+")
            {
                _result = _number1 + _number2;
            }
            //  Subtract operation
            if (_operation == "-")
            {
                _result = _number1 - _number2;
            }
            //  Multiplication operation
            if (_operation == "*")
            {
                _result = _number1 * _number2;
            }
            //  Divide operation
            if (_operation == "/")
            {
                if (_number2 == 0)
                {
                    MessageBox.Show("You can not divide to zero!","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    _result = _number1 / _number2;
                }
            }
            Result.Text = _numberSTR = _result.ToString();
        }

        private void ClickToClear(object sender, MouseEventArgs e)
        {
            Result.Text = "0";
            
            _number1 = 0;
            _number2 = 0;
            _result = 0;
            _operation = _numberSTR = "";
        }
    }
}
