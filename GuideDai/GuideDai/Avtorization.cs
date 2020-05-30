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
    public partial class Avtorization : Form
    {

        Database datab;
        public Avtorization(Database d)// передаємо з минулої форми датабейс
        {
            InitializeComponent();
            datab = d;
        }
        
        private void enterButton_Click(object sender, EventArgs e)// перевірка чи є даний користувач в списку користувачів
        {
            for(int i = 0; i < datab.Employees.Count ;i++)
            {
                if(datab.Employees[i].Name == LoginUserBox.Text && datab.Employees[i].Password == PasswordUserBox.Text)
                {
                    Hide();
                }
            }
            label3.Visible = true;
        }
        private void registrButton_Click(object sender, EventArgs e)//перехід на реєстрацію
        {
            var pf = new Registration(datab);
            Hide();
            pf.ShowDialog();
        }

        private void Avtorization_FormClosed(object sender, FormClosedEventArgs e)//функція закриття
        {
            Application.Exit();
        }
    }
}
