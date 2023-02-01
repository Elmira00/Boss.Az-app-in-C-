using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    class Checker
    {
        public bool IsValidEmail(string email)
        {
            return Regex.IsMatch(email, @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
        }
        public bool isNumber(string id)
        {
            return Regex.IsMatch(id, @"[0-9\-]+");
        }
        public bool isString(string str)
        {
            return Regex.IsMatch(str, "[A-Z][a-zA-Z]+");
        }
        public bool ValidatePassword(string password)
        {
            const int MinLength = 8;
            const int MaxLength = 15;
            if (password == null) throw new ArgumentNullException();
            bool meetsLengthRequirements = password.Length >= MinLength && password.Length <= MaxLength;
            bool hasUpperCaseLetter = false;
            bool hasLowerCaseLetter = false;
            bool hasDecimalDigit = false;

            if (meetsLengthRequirements)
            {
                foreach (char c in password)
                {
                    if (char.IsUpper(c)) hasUpperCaseLetter = true;
                    else if (char.IsLower(c)) hasLowerCaseLetter = true;
                    else if (char.IsDigit(c)) hasDecimalDigit = true;
                }
            }
            bool isValid = meetsLengthRequirements
                        && hasUpperCaseLetter
                        && hasLowerCaseLetter
                        && hasDecimalDigit
                        ;
            return isValid;
        }
        public bool IsValidAge(string age)
        {
            Regex regex = new Regex(@"^-?[0-9][0-9,\.]+$");
            var res = regex.IsMatch(age);
            if (res)
            {
                if (int.Parse(age) > 18) return true;

            }
            return false;
        }
        
        
    }
}
