using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe_wf
{
    internal class ValidInput
    {
        public bool ValidInteger(string value, out string errorMessage)
        {
            int number;
            if (int.TryParse(value, out number))
            {
                if (number >= 3 && number <= 5)
                {
                    errorMessage = "";
                    return true;
                }
                else
                {
                    errorMessage = "Number is too small, enter at least 3";
                    return false;
                }
            }
            else
            {
                errorMessage = "Wrong input! Please enter number bigger than 3";
                return false;
            }
        }
        public bool ValidName(string value, out string errorMessage)
        {
            if(string.IsNullOrEmpty(value))
            {
                errorMessage = "Please enter valid name";
                return false;
            }
            else
            {
                errorMessage = "";
                return true;
            }
        }
    }
}
