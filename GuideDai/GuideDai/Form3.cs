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
        public Form3(string nameOfPerson, string adressOfPerson)//форма з переданим ім'ям та адресою з форми 2
        {
            InitializeComponent();
            textBox1.Text = nameOfPerson;
            textBox2.Text = adressOfPerson;
        }
        private string text;//фінальний текст під друк
        private void printButton_Click(object sender, EventArgs e)//кнопка друкування
        {
            text = "Запрошення на техогляд\n\n";// задаємо текст для друкування
            text += "	Шановний ";
            text += textBox1.Text;
            text += "\n";
            text += richTextBox1.Text;
            text += "\n\n\n\n";
            text += "Адреса: ";
            text += textBox2.Text;
            //////////////////////////////////////////////////////////////////
            PrintDocument printDocument = new PrintDocument();// об'єкт для друку
            
            printDocument.PrintPage += PrintPageHandler;// "обработчик события" друку// слово українською не передасть того значення

            PrintDialog printDialog = new PrintDialog();// диалог налаштуванняи друку

            printDialog.Document = printDocument;// установка об'єкта друку для його налаштування

            if (printDialog.ShowDialog() == DialogResult.OK)// якщо в діалозі натиснуто ОК
                printDialog.Document.Print(); // друкуємо
        }
        
        void PrintPageHandler(object sender, PrintPageEventArgs e)// "обработчик события" друку
        {
            e.Graphics.DrawString(text, new Font("Arial", 14), Brushes.Black, 0, 0);// друк тексту 
        }
    }
}
