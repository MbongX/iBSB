using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I_Bank___Student_Bank.Modules
{
    public class Validation
    {
        public static bool IsNumber(string str)
        {
            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                    return false;
            }

            return true;
        }
        public static bool notNull(string text)
        {
            bool validate;
            int charLength;
            text = text.Trim();
            charLength = text.Length;
            if (charLength == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public static bool validateLogin(string user, string pass)
        {
            if (notNull(user) && notNull(pass) && (IsNumber(user)!=true && IsNumber(pass) != true))
            {
                return true;
            }
            else 
            {
                return false; 
            }

        }

    }
}
