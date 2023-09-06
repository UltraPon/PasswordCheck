using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordCheck
{
    public class PassCheck
    {
        public int Pass(string password)
        {

            int scores = 0;

            if (string.IsNullOrEmpty(password))
            {
                scores = 0;
            }

            if (password.Length > 7)
            {
                scores++;
            }

            if (password.Any(char.IsLower))
            {
                scores++;
            }

            if (password.Any(char.IsUpper))
            {
                scores++;
            }

            if (password.Any(char.IsDigit))
            {
                scores++;
            }

            if (password.Any(ch => !char.IsLetterOrDigit(ch)))
            { 
                scores++;
            }

            return scores;

        }
    }
}