using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexUserRegistrationUsingMsTest
{
    public class UC2Pattern
    {
        public string lastName;
        public UC2Pattern(string lastName)
        {
            this.lastName = lastName;
        }
        
        public string  ValidLastName()
        {
            string pattern = "^[A-Z],[a-z],{3}$";
            if (Regex.IsMatch(lastName, pattern))
            {
                return lastName;

            }
            else
            {
                return lastName;
            }
        }
    }
}
