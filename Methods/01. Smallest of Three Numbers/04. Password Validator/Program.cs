using System;

namespace _04._Password_Validator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string passwordInput = Console.ReadLine();
            bool isPasswordValid = ValidatePassword(passwordInput);
            if (isPasswordValid) {
                Console.WriteLine("Password is valid");
            }
        }

        static bool ValidatePassword(string password) {
            bool isPasswordValid = true;

            if (!ValidatePasswordLenth(password))
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
                isPasswordValid = false;
            }

            if (!ValidatePasswordDigitLetter(password))
            {
                Console.WriteLine("Password must consist only of letters and digits");
                isPasswordValid = false;
            }

            if (!ValidatePassowordMinimumDigits(password))
            {
                Console.WriteLine("Password must have at least 2 digits");
                isPasswordValid = false;
            }

            return isPasswordValid;
        }
        static bool ValidatePasswordLenth(string passowrd) {
            if (passowrd.Length >= 6 && passowrd.Length <= 10)
            {
                return true;
            }
            else 
            {
                return false;
            }
        }

        static bool ValidatePasswordDigitLetter(string password) {
            foreach (char ch in password)
            {
                if (!Char.IsLetterOrDigit(ch)) 
                { 
                return false;
                }
            }
            return true;
        }

        static bool ValidatePassowordMinimumDigits(string passowrd) {
            int br = 0;
            foreach (char ch in passowrd) {
                if (Char.IsDigit(ch))
                {
                    br++;
                }
            }
            if (br >= 2) {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
