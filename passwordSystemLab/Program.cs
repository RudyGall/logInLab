using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace passwordSystemLab
{
    class Program
    {
        static void Main(string[] args)
        {
            bool runP = true;
            while (runP == true)
            {
                string userEmail = emailValid();
                string userPassword = passwordValid();
                runP = Continue();
            }          
        }
        public static string emailValid()
        {
            List<string> validEmails = new List<string>();
            bool responseValid = true;
            string userEmail = "";
            while (responseValid)
            {
                Console.WriteLine("Please enter your email address");
                userEmail = Console.ReadLine();

                if (!Regex.IsMatch(userEmail, @"^[A-z0-9]{3,}(@)[A-z0-9]{3,}(.+)[A-z0-9]{2,3}$"))
                {
                    Console.WriteLine("I'm sorry this is not a valid email address");
                }
                else
                {
                    Console.WriteLine("Email address is valid");
                    validEmails.Add(userEmail);
                    break;
                }
            }
            return userEmail;
        }
        public static string passwordValid()
        {
            List<string> validPasswords = new List<string>();
            bool responseValid = true;
            string userPassword = "";
            while (responseValid)
            {
                Console.WriteLine("Please enter a Password (Password must begin with an Upper followed by a number and be at least 5 long)");
                userPassword = Console.ReadLine();

                if (!Regex.IsMatch(userPassword, @"^[A-Z]+[0-9]+[A-z0-9]{3,}$"))
                {
                    Console.WriteLine("I'm sorry, this is not a valid password");
                }
                else
                {
                    Console.WriteLine("Password is valid");
                    validPasswords.Add(userPassword);
                    break;
                }
            }
            return userPassword;
        }
        public static bool Continue()
        {
            Console.WriteLine("\nWould you like to run the application again? (Y or N)");
            string input = Console.ReadLine().ToLower();
            input = input.ToLower();
            bool goOn;
            if (input == "y")
            {
                goOn = true;
            }
            else if (input == "n")
            {
                Console.WriteLine("Thank you, Goodbye!");
                Console.ReadLine();
                goOn = false;
            }
            else
            {
                Console.WriteLine("I don't understand that, let's try again");
                goOn = Continue();
            }
            return goOn;
        }
    }
}
