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
    public partial class Avtorization : Form
    {
        private Form Form1;
        public Avtorization(Form form)
        {
            InitializeComponent();
            Form1 = form;
        }
        
        private void enterButton_Click(object sender, EventArgs e)
        {
            if(true)
            {
                Form1.Visible = true;
                this.Close();
            }
        }
        private void registrButton_Click(object sender, EventArgs e)
        {

        }
        private void Avtorization_FormClosed(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
