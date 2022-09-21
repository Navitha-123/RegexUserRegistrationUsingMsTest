using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexUserRegistrationUsingMsTest
{
    public class UC4MobileNumber
    {
        public static void ValidMobileNumber()
        {
            Console.WriteLine("Enter Mobile num");
            string mobilenumber = Console.ReadLine();
            string pattern = "^[+][91]{3}[..][6-9]{2}[0-9]{9}$";
            if (Regex.IsMatch(mobilenumber, pattern))
            {
                Console.WriteLine("valid mobile number");
            }
            else
            {
                Console.WriteLine("invalid mobile number");
            }
        }
    }
}
