using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe_wf
{
    internal class ValidInput
    {
        public bool ValidName(string value, out string errorMessage)
        {
            if(string.IsNullOrWhiteSpace(value))
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
