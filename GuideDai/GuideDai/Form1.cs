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
            if(ClientRoll.User == Client.Roll)//якщо роль користувача, блокуємо відповідні кнопки, та ховаемо
            {
                BlockForUser();
            }
            KeyPreview = true;//дозволяє реагувати командам на натискання клавіш
            datab = new Database();
            personInfosBindingSource.DataSource = datab.PersonInfos;// з'єднуємо джерело та з'єднувач

            datab.Load();//завантажуємо збережені дані/ це для того, щоб потім передати формі

            this.Visible = false;//сховуємо дану форму
            var pf = new Avtorization(datab);//запускаємо форму авторизації
            pf.ShowDialog();
            datab.FillTest(20);//заповнюємо тестовими даними персонинфо
            
            personInfosBindingSource.ResetBindings(false);//відображення значень
            datab.Save();
        }
        

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)//Загрузка з файлу
        {
            datab.Load();
            personInfosBindingSource.ResetBindings(false);
        }
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)// Збереження
        {
            datab.Save();
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)// Вихід 
        {
            Close();
        }



        private void Form1_FormClosing(object sender, FormClosingEventArgs e)//форма закриття, в якій попередження перед виходом, про змінну в таблиці
        {
            if (!datab.IsDirty)
                return;
            var res = MessageBox.Show("Зберегти дані перед закриттям?", "Попередження", MessageBoxButtons.YesNoCancel);
            switch (res)
            {
                case DialogResult.Cancel:
                    e.Cancel = true;
                    break;
                case DialogResult.Yes:
                    datab.Save();
                    break;
                case DialogResult.No:
                    break;
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)//створення нового елемента в таблиці
        {
            var pf = new Form2();
            if (pf.ShowDialog() == DialogResult.OK)
            {
                datab.AddInfo(pf.PersonInfo);
                personInfosBindingSource.ResetBindings(false);
                datab.IsDirty = true;

                // select and scroll to the last row
                var lastIdx = infoGridView.Rows.Count - 1;
                infoGridView.Rows[lastIdx].Selected = true;
                infoGridView.FirstDisplayedScrollingRowIndex = lastIdx;
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)// зміна параметрів вже існуючого елемента
        {
            var toEdit = infoGridView.SelectedRows[0].DataBoundItem as PersonInfo;
            var pf = new Form2(toEdit, true);
            if (pf.ShowDialog() == DialogResult.OK)
            {
                personInfosBindingSource.ResetBindings(false);
                datab.IsDirty = true;
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)//видалення елемента з таблиці
        {
            var toDel = infoGridView.SelectedRows[0].DataBoundItem as PersonInfo;
            var res = MessageBox.Show($"Delete {toDel.PName} ?", "", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                datab.PersonInfos.Remove(toDel);
                personInfosBindingSource.ResetBindings(false);
                datab.IsDirty = true;
            }
        }

        private void invitationToolStripMenuItem_Click(object sender, EventArgs e)//відкриваємо форму для запрошення на техогляд
        {
            var pf = new Form3();
            pf.ShowDialog();
        }

        private void showInfoButton_Click(object sender, EventArgs e)//кнопка для показу всієї інформації про елемент
        {
            var toEdit = infoGridView.SelectedRows[0].DataBoundItem as PersonInfo;
            var pf = new Form2(toEdit, false);
            pf.ShowDialog();
        }
        private void BlockForUser()//метод для блокування непотрібних для користувача кнопок
        {
            tableToolStripMenuItem.Enabled = false;
            invitationToolStripMenuItem.Enabled = false;
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)//виведення форми для входу адміністратора
        {
            if(e.KeyCode == Keys.Insert && e.Control)//перевірка на ктрл + инсрт 
            {
                var pf = new AdminAvtorization();
                pf.ShowDialog();
                if (Client.Roll == ClientRoll.Admin)//якщо зміна ролі на адмінську відбулась, то ми відкриваємо заблоковані раніше методи
                    OpenAllBlock();
            }
        }
        private void OpenAllBlock()//метод відкриття всіх заблокованих кнопок
        {
            tableToolStripMenuItem.Enabled = true;
            invitationToolStripMenuItem.Enabled = true;
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)// кнопка "Допомога"
        {
            var pf = new Help();
            pf.ShowDialog();
        }

        private void searchInfoBox_TextChanged(object sender, EventArgs e)//для пошуку в таблиці
        {
            if (string.IsNullOrWhiteSpace(PoshukBox.Text))
            {
                personInfosBindingSource.DataSource = datab.PersonInfos;
                personInfosBindingSource.ResetBindings(false);
            }
            else
            {
                switch (ParametrComboBox.Text)
                {
                    case "ПІП":
                        personInfosBindingSource.DataSource = datab.PersonInfos.Where(o => o.PName.StartsWith(PoshukBox.Text)).ToList();
                        personInfosBindingSource.ResetBindings(false);
                        break;
                    case "Адреса":
                        personInfosBindingSource.DataSource = datab.PersonInfos.Where(o => o.Address.StartsWith(PoshukBox.Text)).ToList();
                        personInfosBindingSource.ResetBindings(false);
                        break;
                    case "Тип транспорту":
                        personInfosBindingSource.DataSource = datab.PersonInfos.Where(o => o.Type.StartsWith(PoshukBox.Text)).ToList();
                        personInfosBindingSource.ResetBindings(false);
                        break;
                    case "Марка":
                        personInfosBindingSource.DataSource = datab.PersonInfos.Where(o => o.Marka.StartsWith(PoshukBox.Text)).ToList();
                        personInfosBindingSource.ResetBindings(false);
                        break;
                    case "Колір":
                        personInfosBindingSource.DataSource = datab.PersonInfos.Where(o => o.Color.StartsWith(PoshukBox.Text)).ToList();
                        personInfosBindingSource.ResetBindings(false);
                        break;
                    case "Бортовий номер":
                        personInfosBindingSource.DataSource = datab.PersonInfos.Where(o => o.NumberBort.StartsWith(PoshukBox.Text)).ToList();
                        personInfosBindingSource.ResetBindings(false);
                        break;
                }
            }
        }

        private void TableForUserToolStripMenuItem_Click(object sender, EventArgs e)//відкриття форми з користувачами
        {
            var tu = new TableUser(datab);
            tu.Show();
        }
    }
}
