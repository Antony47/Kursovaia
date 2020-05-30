using GuideDai.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading.Tasks;



namespace GuideDai.DAL
{
    public class Dao
    {
        Database database;
        const string filePath = "database.bin";//файл в який загружається та вигружається інформація

        public Dao(Database database)
        {
            this.database = database;
        }

        public void Save()//збереження
        {
            using (Stream stream = File.Create(filePath))
            {
                var serializer = new BinaryFormatter();
                serializer.Serialize(stream, database);
            }
        }

        public void Load()//завантаження
        {
            using (Stream stream = File.OpenRead(filePath))
            {
                var serializer = new BinaryFormatter();
                Database st = (Database)serializer.Deserialize(stream);
                Copy(st.PersonInfos, database.PersonInfos);
                Copy(st.Employees, database.Employees);
            }

            void Copy<T>(List<T> from, List<T> to)//копіювання
            {
                to.Clear();
                to.AddRange(from);
            }
        }

    }
}
