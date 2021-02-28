using PasswordCheckerApp;
using System;

namespace PasswordChecker
{
    class Program
    {
        public static void Main(string[] args)
        {
            int minLength = 8;
            string uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string lowercase = "abcdefghijklmnopqrstuvwxyz";
            string digits = "0,1,2,3,4,5,6,7,8,9";
            string specialChars = "~!@#$%^&*()_+";

            Console.WriteLine("Enter a password:");
            string password = Console.ReadLine();
            Console.WriteLine(password);

            int score = 0;

            if (password.Length >= minLength)
            {
                score++;
                Console.WriteLine("point added for length");
            }

            if (Tools.Contains(password, uppercase))
            {
                score++;
                Console.WriteLine("point added for uppercase");
            }

            if (Tools.Contains(password, lowercase))
            {
                score++;
                Console.WriteLine("point added for lowercase");
            }

            if (Tools.Contains(password, digits))
            {
                score++;
                Console.WriteLine("point added for digits");
            }

            if (Tools.Contains(password, specialChars))
            {
                score++;
                Console.WriteLine("point added for chars");
            }
            Console.WriteLine(score);

            //switch statement

            switch (score)
            {
                case 5:
                    Console.WriteLine("Extremely Strong");
                    break;
                case 4:
                    Console.WriteLine("Extremely Strong");
                    break;
                case 3:
                    Console.WriteLine("strong");
                    break;
                case 2:
                    Console.WriteLine("medium");
                    break;
                case 1:
                    Console.WriteLine("weak");
                    break;
                default:
                    Console.WriteLine("awful");
                    break;
            }
        }
    }
}
