using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThePoint
{
    public class PasswordValidator
    {
        public static bool isValidPassword(string password)
        {
            StringBuilder sb = new StringBuilder();
            string errorText = "";
            // check for at least 6 characters long and no more than 13
            if (!isValidLength(password))
            {
                errorText = "Password needs to be within 6 to 13 characters.";
                sb.AppendLine(errorText);
            }

            // check for one uppercase, lowercase
            if (!isValidCasing(password))
            {
                errorText = "Password needs at least one upper and one lower case";
                sb.AppendLine(errorText);
            }
            // check for number
            if (!isValidDigit(password))
            {
                errorText = "Passowrd requires at least one number";
                sb.AppendLine(errorText);
            }
            // check for no T or &
            if (!isValidIngelmar(password))
            {
                errorText = "Password cannot contain a 'T' or a '&'";
                sb.AppendLine(errorText);
            }

            if (sb.Length != 0)
            {
                System.Console.WriteLine("Password is invalid:");
                System.Console.WriteLine(sb.ToString());
            }



            return (sb.Length == 0) ? true : false;
            
        }

        private static bool isValidIngelmar(string password)
        {
            foreach (char c in password)
            {
                if (c == 'T' || c == '&')
                {
                    return false;
                }

            }
            return true;
        }

        private static bool isValidLength(string password)
        {
            if (password.Length >= 6 && password.Length < 14)
            {
                return true;
            }
            return false;
        }

        private static bool isValidCasing(string password)
        {
            bool hasUpper = false;
            bool hasLower = false;
            foreach (char c in password)
            {
                if (char.IsUpper(c))
                {
                    hasUpper = true;
                    continue;
                }
                if (char.IsLower(c))
                {
                    hasLower = true;
                    continue;
                }
            }

            return hasUpper && hasLower;
        }

        private static bool isValidDigit(string password)
        {
            foreach (char c in password)
            {
                if (char.IsDigit(c))
                {
                    return true;
                }
            }
            return false;
        }


    }
}