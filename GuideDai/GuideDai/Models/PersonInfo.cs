using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuideDai.Models
{
    //
    // Інформація про персону = ПІБ + Адреса проживання + паспортні дані

    [Serializable]
    public class PersonInfo
    {

        public PersonInfo(string pName, string address, string datapasport, string x, string y, string z, string e, string c, string v, string d)
        {
            PName = pName;
            Address = address;
            DataPasport = datapasport;
            Type = x;
            Marka = y;
            Color = z;
            NumberFactory = e;
            NumberBort = c;
            FeaturesOpus = v;
            DataOfLastControl = d;
        }
        public PersonInfo() { }
        public string PName { get; set; }
        public string Address { get; set; }
        public string DataPasport { get; set; }
        public string Type { get; set; }
        public string Marka { get; set; }
        public string Color { get; set; }
        public string NumberFactory { get; set; }
        public string NumberBort { get; set; }
        public string FeaturesOpus { get; set; }
        public string DataOfLastControl { get; set; }

    }
}
