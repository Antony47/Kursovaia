using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GuideDai.Models;


namespace GuideDai
{
    public partial class Form1 : Form
    {
        Database datab;
        public Form1()
        {
            
            InitializeComponent();
            datab = new Database();
            datab.FillTestData(20);
            personInfosBindingSource.DataSource = datab.PersonInfos;
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            datab.Load();
            personInfosBindingSource.ResetBindings(false);
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            datab.Save();
        }

        
    }
}
