using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GuideDai.Models;

namespace GuideDai
{
    public partial class Form3 : Form
    {

        public Form3()
        {
            InitializeComponent();
        }
        public Form3(string nameOfPerson, string adressOfPerson)
        {
            InitializeComponent();
            textBox1.Text = nameOfPerson;
            textBox2.Text = adressOfPerson;
        }
        private string text;
        private void printButton_Click(object sender, EventArgs e)
        {
            text = "Запрошення на техогляд\n\n";// задаем текст для печати
            text += "	Шановний ";
            text += textBox1.Text;
            text += "\n";
            text += richTextBox1.Text;
            text += "\n\n\n\n";
            text += "Адреса: ";
            text += textBox2.Text;
            //////////////////////////////////////////////////////////////////
            PrintDocument printDocument = new PrintDocument();// объект для печати
            
            printDocument.PrintPage += PrintPageHandler;// обработчик события печати

            PrintDialog printDialog = new PrintDialog();// диалог настройки печати

            printDialog.Document = printDocument;// установка объекта печати для его настройки

            if (printDialog.ShowDialog() == DialogResult.OK)// если в диалоге было нажато ОК
                printDialog.Document.Print(); // печатаем
        }
        
        void PrintPageHandler(object sender, PrintPageEventArgs e)// обработчик события печати
        {
            e.Graphics.DrawString(text, new Font("Arial", 14), Brushes.Black, 0, 0);// печать строки result
        }
    }
}
