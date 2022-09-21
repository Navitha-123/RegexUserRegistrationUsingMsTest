using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexUserRegistrationUsingMsTest
{
    public class UC8PasswordSpecialCharacter
    {
        public static void ValidPassWord(string password)
        {
            var hasLowerChar = new Regex(@"[a-z]+");
            var hasUpperChar = new Regex(@"[A-Z]+");
            var hasNnumber = new Regex(@"[0-9]+");
            var hasMiniChar = new Regex(@".{8,}");
            var hasSpecialChar = new Regex(@"[!@#$%^&**()+=-\[{\]};:<>|./?,-]");
            var pattern = new Regex("^(?=.*[a-z])(?=.[!@#$%^&**()+=-\\[{\\]};:<>|./?,-]*[A-Z].{8,}$)");
            if (!hasMiniChar.IsMatch(password))
            {
                Console.WriteLine("Password should have mini 8 char");

            }
            else if (!hasLowerChar.IsMatch(password))
            {
                Console.WriteLine("the password should have atleast one lower case letter");
            }
            else if (!hasNnumber.IsMatch(password))
            {
                Console.WriteLine("password must contain numeric number");
            }
            else if (!hasUpperChar.IsMatch(password))
            {
                Console.WriteLine("password should have atleast one upper case letter");

            }
            else
            {
                if (pattern.IsMatch(password))
                {
                    Console.WriteLine("password is valid");
                }

            }
        }
    }
}
