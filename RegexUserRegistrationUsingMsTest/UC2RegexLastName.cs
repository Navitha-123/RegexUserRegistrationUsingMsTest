using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexUserRegistrationUsingMsTest
{
    public class UC2RegexLastName
    {
        public static void ValidLastName()
        {
            Console.WriteLine("Enter first name");
            string firstname = Console.ReadLine();
            string pattern = "^[A-Z],[a-z],{3}$";
            if (Regex.IsMatch(firstname, pattern))
            {
                Console.WriteLine("valid first name");

            }
            else
            {
                Console.WriteLine("In valid first name");
            }
        }
    }
}
