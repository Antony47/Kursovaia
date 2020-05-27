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
    public partial class Registration : Form
    {
        Employee empl;
        Database datab;

        public Registration(Database d)
        {
            InitializeComponent();
            datab = d;
            empl = new Employee();
        }

        private void Registration_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)//registration
        {
            empl.Name = textBox1.Text;
            empl.Department = textBox2.Text;
            empl.Rank = textBox3.Text;
            empl.Password =  textBox4.Text;

            datab.Employees.Add(empl);
            datab.Save();
            Hide();
        }
    }
}
