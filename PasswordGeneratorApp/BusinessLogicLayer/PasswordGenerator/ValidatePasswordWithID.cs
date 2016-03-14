using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogicLayer.Models;

namespace BusinessLogicLayer.PasswordGenerator
{
    public class ValidatePasswordWithID
    {
        private string _idByteString;
        private string _passwordByteString;

        public ValidatePasswordWithID()
        {
            this._idByteString = String.Empty;
            this._passwordByteString = String.Empty;
        }

        public List<PasswordsAndIds> ValidatePassword(string idNumber)
        {

            GenerateNewPassword newPassword = new GenerateNewPassword();
           List< PasswordsAndIds> passwordAndId = new List<PasswordsAndIds>();


            foreach(char password in newPassword.Generate())
            {
                _passwordByteString += ((byte)password).ToString();
            }

            foreach (char c in idNumber)
            {
                _idByteString += ((byte)c).ToString();
            }



            int idFourBytCode = Convert.ToInt32(_idByteString.Remove(0, 11));

            int passwordFourByteCode = Convert.ToInt32(_passwordByteString.Remove(0, 11));

            int byteCodeKey = idFourBytCode + passwordFourByteCode;


            if (byteCodeKey - passwordFourByteCode != idFourBytCode)
            {
                ValidatePassword(idNumber);
            }
            else
            {
                PasswordsAndIds newCredentials = new PasswordsAndIds();
                newCredentials.ID = _idByteString;
                newCredentials.Password = _passwordByteString;

                passwordAndId.Add(newCredentials);
            }

            return passwordAndId; 
        }
    }
}
