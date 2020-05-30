using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuideDai.Models
{
    public static class Client//статичний клас з роллю
    {
        public static ClientRoll Roll { get; set; } = ClientRoll.User;
    }
}
