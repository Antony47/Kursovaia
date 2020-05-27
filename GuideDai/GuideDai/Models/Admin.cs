using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuideDai.Models
{
    //
    // Адмін = Логін + Пароль

    [Serializable]
    public class Admin : User
    {
        public Admin() { }
        public Admin(string name, string password) : base(name, password) 
        {
            Name = "admin";
            Password = "4321";
        }
    }
}
