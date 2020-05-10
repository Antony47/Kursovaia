using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuideDai.Models
{
    [Serializable]
    public class Database
    {
        public Database(List<PersonInfo> prs, List<Transport> tr)
        {
            PersonInfos = prs;
            Transports = tr;
        }
        public List<PersonInfo> PersonInfos { private set; get; }
        public List<Transport> Transports { private set; get; }
    }
}
