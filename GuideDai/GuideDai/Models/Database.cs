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

        // If any data changed. перевірка чи змінювались елементи таблиця
        public bool IsDirty;

        public Database(List<PersonInfo> prs)
        {
            PersonInfos = prs;
        }
        public Database()
        {
            PersonInfos = new List<PersonInfo>();
            Employees = new List<Employee>();
            admin = new Admin();
        }

        public void FillTest(int n)// тестові дані
        {
            PersonInfos = new List<PersonInfo>();
            for (int i = 0; i < n; i++)
            {
                var c = new PersonInfo()
                {
                    PName = $"Людина{i}",
                    Address = $"Адреса{i}",
                    DataPasport = $"Datapasport{i}",
                    Type = $"Тип{i}",
                    Marka = $"Марка{i}",
                    Color = $"Колір{i}",
                    NumberFactory = $"Заводський{i}{i + 1}{i + 2}{i + 3}",
                    NumberBort = $"Бортовий{i}",
                    FeaturesOpus = $"Повна комлектація",
                    DataOfLastControl = DateTime.Now - TimeSpan.FromDays(i * 365)
                };
                PersonInfos.Add(c);
            }
        }
        public void AddInfo(PersonInfo pinfo)//додавання нового елементу в список персонинфо
        {
            PersonInfos.Add(pinfo);
        }

        public void Save()//збереження
        {
            new Dao(this).Save();
            IsDirty = false;
        }

        public void Load()//загрузка
        {
            new Dao(this).Load();
            IsDirty = false;
        }
    }
}
