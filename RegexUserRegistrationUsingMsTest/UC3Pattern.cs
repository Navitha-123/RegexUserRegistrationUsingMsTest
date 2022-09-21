using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexUserRegistrationUsingMsTest
{
    public class UC3Pattern
    {
        public static void ValidEmailAddress()
        {
            Console.WriteLine("Enter Email");
            string email = Console.ReadLine();
            string pattern = @"^([a-z]+)(\.a-z0-9_\+\+)?@([a-z]+)\.([a-z]{2,4})([\.a-z]{2})?$";
            if (Regex.IsMatch(email, pattern))
            {
                Console.WriteLine("valid email");
            }
            else
            {
                Console.WriteLine("invalid email");
            }
        }
    }
}
