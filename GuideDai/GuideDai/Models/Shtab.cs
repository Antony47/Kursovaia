using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuideDai.Models
{
    [Serializable]
    public class Shtab
    {
        
        public Shtab()
        {
            Messages = new List<Message>();
            Databases = new List<Database>();
        }
        public List<Message> Messages { get; private set; }
        public List<Database> Databases { get; private set; }
    }
}
