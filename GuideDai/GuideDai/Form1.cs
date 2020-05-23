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
            personInfosBindingSource.DataSource = datab.PersonInfos;
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



        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
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

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var toEdit = infoGridView.SelectedRows[0].DataBoundItem as PersonInfo;
            var pf = new Form2(toEdit);
            if (pf.ShowDialog() == DialogResult.OK)
            {
                personInfosBindingSource.ResetBindings(false);
                datab.IsDirty = true;
            }

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
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
    }
}
