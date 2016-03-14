using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class GenerateNewPassword
    {
        private const string AllowedCharacters = "abcdefghijkmnopqrstuvwxyzABCDEFGHJKLMNOPQRSTUVWXYZ0123456789 - ";
        public string PasswordValue { get; set; }

        public string Generate()
        {
            Random rnd = new Random();
            for (int i = 0; i <= 4; i++)
            {
                int RandomValue = rnd.Next(0, AllowedCharacters.Length - 1);
                PasswordValue += AllowedCharacters.Substring(RandomValue, 1);
            }
            return PasswordValue;
        }
            


        }

    }

