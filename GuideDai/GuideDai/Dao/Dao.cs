using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading.Tasks;
using GuideDai.Models;


namespace GuideDai.Dao
{
        public class Dao
        {
            Shtab shtab;
            const string filePath = "shtab.bin";

            public Dao(Shtab shtab)
            {
                this.shtab = shtab;
            }

            public void Save()
            {
                using (Stream stream = File.Create(filePath))
                {
                    var serializer = new BinaryFormatter();
                    serializer.Serialize(stream, shtab);
                }
            }

            public void Load()
            {
                using (Stream stream = File.OpenRead(filePath))
                {
                    var serializer = new BinaryFormatter();
                    Shtab st = (Shtab)serializer.Deserialize(stream);
                    Copy(st.Messages, shtab.Messages);
                    Copy(st.Databases, shtab.Databases);
                }

                void Copy<T>(List<T> from, List<T> to)
                {
                    to.Clear();
                    to.AddRange(from);
                }
            }
        }
}
