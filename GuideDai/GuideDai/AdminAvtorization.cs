﻿using GuideDai.Models;
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
    public partial class AdminAvtorization : Form
    {
        public AdminAvtorization()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)//перевірка правильності вводу, у разі правильності, зміна ролі на адмін
        {
            if(textBox1.Text == "admin" && textBox2.Text == "12345")
            {
                Client.Roll = ClientRoll.Admin;
                this.Close();
            }
        }
    }
}
