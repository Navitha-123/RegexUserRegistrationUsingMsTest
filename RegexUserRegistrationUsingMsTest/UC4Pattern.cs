using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexUserRegistrationUsingMsTest
{
    public class UC4Pattern
    {
        public string mobilenumber;

        public UC4Pattern(string mobilenumber)
        {
            this.mobilenumber = mobilenumber;
        }

        public string ValidMobileNumber()
        {
            string pattern = "^[+][91]{3}[..][6-9]{2}[0-9]{9}$";
            if (Regex.IsMatch(mobilenumber, pattern))
            {
                return mobilenumber;
            }
            else
            {
                return mobilenumber;
            }
        }
           
        
    }
}
