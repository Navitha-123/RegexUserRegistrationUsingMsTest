using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexUserRegistrationUsingMsTest
{
    public class UC9EmailSamples
    {
        public static void ValidEmailAddress()
        {
            Console.WriteLine("enter a email");
            string Email = Console.ReadLine();
            string pattern = @"([a-z]+)(\.[a-z0-9_\+\-]+)?@([a-z]+)\.([a-z]{2,4})(\.[a-z]{2})?$";
            if (Regex.IsMatch("abc.100@abc.com.au", pattern))
            {
                Console.WriteLine("abc.100@abc.com.au email is valid");
            }
            else
            {
                Console.WriteLine("email is not valid");
            }
            if (Regex.IsMatch("abc@yahoo.com", pattern))
            {
                Console.WriteLine("abc@yahoo.com,valid email");
            }
            else
            {
                Console.WriteLine(" abc@.com.my mail is not valid");
            }
            if (Regex.IsMatch("abc-100@yahoo.com", pattern))
            {
                Console.WriteLine("abc-100@yahoo.com,valid email");
            }
            else
            {
                Console.WriteLine(" abc123@gmail.a invalid email");
            }
            if (Regex.IsMatch("abc.100@yahoo.com", pattern))
            {
                Console.WriteLine("abc.100@yahoo.com mail is valid");
            }
            else
            {
                Console.WriteLine("abc123@.com mail is invalid");
            }
            if (Regex.IsMatch("abc111@abc.com", pattern))
            {
                Console.WriteLine("abc111@abc.com mail is valid");
            }
            else
            {
                Console.WriteLine("abc123@.com.com mail is not valid");
            }
            if (Regex.IsMatch("abc-100@abc.net", pattern))
            {
                Console.WriteLine("abc-100@abc.net mail is valid");
            }
            else
            {
                Console.WriteLine(".abc@abc.com mail is invalid");
            }
            if (Regex.IsMatch("abc@1.com", pattern))
            {
                Console.WriteLine("abc@1.com mail is valid");
            }
            else
            {
                Console.WriteLine("abc()*@gmail.com mail is not valid");
            }
            if (Regex.IsMatch("abc@gmail.com.com", pattern))
            {
                Console.WriteLine("abc@gmail.com.com mail is valid");
            }
            else
            {
                Console.WriteLine("abc@%*.com mail is not valid");
            }
            if (Regex.IsMatch("abc@gmail.com.com", pattern))
            {
                Console.WriteLine("abc@gmail.com.com mail is valid");
            }
            else
            {
                Console.WriteLine("abc.@gmail.com  mail is notvalid");
            }
            if (Regex.IsMatch("abc+100@gmail.com", pattern))
            {
                Console.WriteLine("abc+100@gmail.com mail is valid");
            }
            else
            {
                Console.WriteLine("abc@gmail.com.1a mail is not valid");
            }
            if (Regex.IsMatch("abc()*@gmail.com", pattern))
            {
                Console.WriteLine("abc()*@gmail.com mail is valid");
            }
            else
            {
                Console.WriteLine("abc()*@gmail.com mail is invalid");
            }
            if (Regex.IsMatch("abc..2002@gmail.com ", pattern))
            {
                Console.WriteLine("abc..2002@gmail.com mail is valid");
            }
            else
            {
                Console.WriteLine("abc..2002@gmail.com  mail is invalid");
            }
            if (Regex.IsMatch("abc@abc@gmail.com ", pattern))
            {
                Console.WriteLine("abc@abc@gmail.com mail is valid");

            }
            else
            {
                Console.WriteLine("abc@abc@gmail.com mail is notvalid");
            }
            if (Regex.IsMatch("abc@gmail.com.aa.au ", pattern))
            {
                Console.WriteLine("abc@gmail.com.aa.au  mail is valid");
            }
            else
            {
                Console.WriteLine("abc@gmail.com.aa.au  mail is not invalid");
            }
            if (Regex.IsMatch("abc()*@gmail.com", pattern))
            {
                Console.WriteLine("abc()*@gmail.com mail is valid");
            }
            else
            {
                Console.WriteLine("abc()*@gmail.com mail is invalid");
            }
        }
    }
}
