using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexUserRegistrationUsingMsTest
{
    public class UC1Pattern
    {
        public string firstName;

        public UC1Pattern(string firstName)
        {
           this. firstName = firstName;
        }

        public string  ValidfirstName()
        {
           
            string pattern = "^[A-Z],{3}$";
            if (Regex.IsMatch(firstName, pattern))
            {
                return firstName;

            }
            else
            {
                return firstName;
            }
        }

       
    }
}
