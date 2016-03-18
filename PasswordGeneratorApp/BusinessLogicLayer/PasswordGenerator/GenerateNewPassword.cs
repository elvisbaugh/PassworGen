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
        private string _passwordValue;

        public string Generate()
        {
            Random rnd = new Random();
            for (int i = 0; i <= 4; i++)
            {
                int RandomValue = rnd.Next(0, AllowedCharacters.Length - 1);
                _passwordValue += AllowedCharacters.Substring(RandomValue, 1);
            }
            return _passwordValue;
        }
            


        }

    }

