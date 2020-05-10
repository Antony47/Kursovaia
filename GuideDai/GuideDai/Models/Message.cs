using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuideDai.Models
{
    [Serializable]
    public class Message
    {
        public Message(List<string> txtmsg, List<Employee> emp)
        {
            TextMsg = txtmsg;
            Employees = emp;
        }
        public List<string> TextMsg { get; private set; }
        public List<Employee> Employees { get; private set; }
    }
}
