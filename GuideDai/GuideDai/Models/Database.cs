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
        public List<Message> Messages { get; private set; }

        // If any data changed.
        public bool IsDirty;

        public Database(List<PersonInfo> prs)
        {
            PersonInfos = prs;
        }
        public Database()
        {
            PersonInfos = new List<PersonInfo>();
            Messages = new List<Message>();
        }

       /* Buyers.Clear();
            for (int i = 1; i <= n; i++)
            {
                Buyers.Add(new Buyer { Name = $"Buer{i}", Password = "123" });
            }*/
        public void FillTestData(int n)
        {
            PersonInfos.Clear();
            for (int i = 1; i <= n; i++)
            {
                PersonInfos.Add(new PersonInfo(1, "garik", "string address", "string datapasport", "sv", "afe", "ave", "vr", "aew", "grew", "wvr"));
            }
        }
        public void FillMessage() { }

        public void AddInfo(PersonInfo pinfo)
        {
            pinfo.NumberRow = PersonInfos.Count + 1;
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
