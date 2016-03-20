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
        private string _passwordString;

        public ValidatePasswordWithID()
        {
            this._idByteString = String.Empty;
            this._passwordByteString = String.Empty;
            this._passwordString = String.Empty;
        }

        public PasswordsAndIds ValidatePassword(string idNumber)
        {

            GenerateNewPassword newPassword = new GenerateNewPassword();
           PasswordsAndIds passwordAndId = new PasswordsAndIds();

            _passwordString = newPassword.Generate();



            foreach (char password in _passwordString)
            {
                _passwordByteString += ((byte)password).ToString();
            }

            foreach (char c in idNumber)
            {
                _idByteString += ((byte)c).ToString();
            }

            

            string passwordTruncatedString = (_passwordByteString.Length > 3) ? _passwordByteString.Substring(_passwordByteString.Length - 5, 5) : _passwordByteString;
            string idTruncatedString = (_idByteString.Length > 3) ? _idByteString.Substring(_idByteString.Length - 5, 5) : _idByteString;



            int idFiveBytCode = Convert.ToInt32(idTruncatedString);

            int passwordFiveByteCode = Convert.ToInt32(passwordTruncatedString);

            int byteCodeKey = idFiveBytCode + passwordFiveByteCode;


            if (byteCodeKey - passwordFiveByteCode != idFiveBytCode)
            {
                ValidatePassword(idNumber);
            }
            else
            {

                passwordAndId.ID = idNumber;
                passwordAndId.Password = _passwordString;

                
            }

            return passwordAndId; 
        }
    }
}
