using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexUserRegistrationUsingMsTest
{
    public class UC8Pattern
    {
        public string password;

        public UC8Pattern(string password)
        {
            this.password = password;
        }

        public string  ValidPassWordRule4()
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
                return null;
            }
            else if (!hasLowerChar.IsMatch(password))
            {
                Console.WriteLine("the password should have atleast one lower case letter");
                return null;
            }
            else if (!hasNnumber.IsMatch(password))
            {
                Console.WriteLine("password must contain numeric number"); 
                return null;
            }
            else if (!hasUpperChar.IsMatch(password))
            {
                Console.WriteLine("password should have atleast one upper case letter");
                return null;

            }
            else if(!hasSpecialChar.IsMatch(password))
            {
                Console.WriteLine("password should have atleast one special char letter");
                return null;
            }
            else
            {
                if (pattern.IsMatch(password))
                {
                    return password;
                }
                else
                {
                    return null;
                }

            }
        }
    }
}
