using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GuideDai.DAL;

namespace GuideDai.Models
{
    //
    //База даних = колекція транспортів + к. персональних даних + к. повідомлень

    [Serializable]
    public class Database
    {
        public List<PersonInfo> PersonInfos { private set; get; }
        public List<Employee> Employees { get; private set; }
        public Admin admin { get; private set; }

        // If any data changed.
        public bool IsDirty;

        public Database(List<PersonInfo> prs)
        {
            PersonInfos = prs;
        }
        public Database()
        {
            PersonInfos = new List<PersonInfo>();
            Employees = new List<Employee>();
            admin = new Admin("", "");
        }

       /* Buyers.Clear();
            for (int i = 1; i <= n; i++)
            {
                Buyers.Add(new Buyer { Name = $"Buer{i}", Password = "123" });
            }*/
        

        public void AddInfo(PersonInfo pinfo)
        {
            PersonInfos.Add(pinfo);
        }

        public void Save()
        {
            new Dao(this).Save();
            IsDirty = false;
        }

        public void Load()
        {
            new Dao(this).Load();
            IsDirty = false;
        }
    }
}
