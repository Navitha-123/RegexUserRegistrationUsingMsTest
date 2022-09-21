using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexUserRegistrationUsingMsTest
{
   
    
        public class UC5Pattern
        {
            public string password;

            public UC5Pattern(string password)
            {
                this.password = password;
            }

            public string ValidPasswordRule1()
            {
                var hasLowerChar = new Regex("^(?=.*[a-z]).{8,}$");
                if(!hasLowerChar.IsMatch(password))
                {
                    Console.WriteLine("password should be minimum 8 characters");
                    return null;

                }
                else
                {
                    return password;
                }
            }
        }
    
}
