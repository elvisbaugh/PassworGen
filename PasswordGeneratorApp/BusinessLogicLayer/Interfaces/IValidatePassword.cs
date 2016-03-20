﻿using BusinessLogicLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Interfaces
{
   public interface IValidatePassword
    {
        PasswordsAndIds ValidatePassword(string idNumber);
    }
}
