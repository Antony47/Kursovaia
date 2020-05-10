using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuideDai.Models
{
    [Serializable]
    public class PersonInfo
    {
        
        public PersonInfo(string pName, string address, string datapasport)
        {
            PName = pName;
            Address = address;
            DataPasport = datapasport;
        }
        public string PName { get; private set; }
        public string Address { get; private set; }
        public string DataPasport { get; private set; }
    }
}
