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
        public Admin()//адмін = логін + пароль = "admin" + "12345"
        {
            Name = "admin";
            Password = "12345";
        }
    }
}
