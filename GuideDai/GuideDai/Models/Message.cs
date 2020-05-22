using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuideDai.Models
{
    //
    // Повідомлення = Текст повідомлення + користувач

    [Serializable]
    public class Message
    {
        public Message(string txtmsg, string emp)
        {
            TextMsg = txtmsg;
            Employees = emp;
        }
        public Message() { }
        public string TextMsg { get; set; }
        public string Employees { get; set; }
    }
}
