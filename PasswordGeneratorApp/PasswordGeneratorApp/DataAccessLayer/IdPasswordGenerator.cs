using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogicLayer;
using BusinessLogicLayer.Interfaces;
using BusinessLogicLayer.Models;

namespace DataAccessLayer
{
    public class IdPasswordGenerator : IPasswordIdRepository
    {
        public List<PasswordsAndIds> GetAll()
        {
            return null;
        }
    }
}
