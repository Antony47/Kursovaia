using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuideDai.Models
{
    [Serializable]
    public class Transport
    {
        public Transport(string x, string y , string z , string e , string c , string v , string d)
        {
            Type = x;
            Marka = y;
            Color = z;
            NumberFactory = e;
            NumberBort = c;
            FeaturesOpus = v;
            DataOfLastControl = d;
        }
        public string Type { get; private set; }
        public string Marka { get; private set; }
        public string Color { get; private set; }
        public string NumberFactory { get; private set; }
        public string NumberBort { get; private set; }
        public string FeaturesOpus { get; set; }
        public string DataOfLastControl { get; set; }
    }
}
