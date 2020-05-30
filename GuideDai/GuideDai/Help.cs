using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuideDai
{
    public partial class Help : Form
    {
        public Help()
        {
            InitializeComponent();
            richTextBox1.Enabled = false;//заблоковано  зміну тексту, тут я звертаюсь до користувачів (але не до адміна)-> для нього інструкція в курсовій
        }
    }
}
