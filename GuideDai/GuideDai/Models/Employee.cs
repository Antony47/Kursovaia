using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuideDai.Models
{
    //
    // Користувач = ПІБ + Пароль + Відділ + Ранг
    [Serializable]
    public class Employee : User
    {
        public Employee(string name, string password, string rank, string department) : base(name, password)
        {
            Rank = rank;
            Department = department;
        }
        public string Rank { private set; get; }
        public string Department { private set; get; }
    }
}
