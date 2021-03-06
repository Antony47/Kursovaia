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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public Form2(bool Roll) : this()
        {
            RollControl(Roll);
        }
        
        public PersonInfo PersonInfo{ set; get; }

        public Form2(PersonInfo pinfo, bool Roll) : this()
        {
            PersonInfo = pinfo;
            pnameBox.Text = pinfo.PName;
            addressBox.Text = pinfo.Address;
            datapasportBox.Text = pinfo.DataPasport;
            typeBox.Text = pinfo.Type ;
            markaBox.Text = pinfo.Marka;
            colorBox.Text = pinfo.Color;
            numberfactoryBox.Text = pinfo.NumberFactory;
            numberbortBox.Text = pinfo.NumberBort;
            featuresopusBox.Text = pinfo.FeaturesOpus;
            controldateTimePicker.Value = pinfo.DataOfLastControl;
            RollControl(Roll);//перевірка режиму
        }

        private void RollControl(bool Roll)// якщо брехня, забороняє змінювати дані/ ховає кнопку збереження та запрошення
        {
            if (!Roll)
            {
                foreach (Control i in Controls)
                {
                    if (i is TextBox t)
                    {
                        t.ReadOnly = true;
                    }
                    if (i is DateTimePicker d)
                    {
                        d.Enabled = false;
                    }
                    if (i is GroupBox g)
                    {
                        foreach (Control j in g.Controls)
                        {
                            if (j is TextBox tb)
                            {
                                tb.ReadOnly = true;
                            }
                        }
                    }
                }
                saveButton.Hide();
                if (Client.Roll != ClientRoll.Admin)
                    invitationButton.Hide();
            }
        }
        private void saveButton_Click(object sender, EventArgs e)//кнопка збереження
        {
            if (PersonInfo == null)
            {
                PersonInfo = new PersonInfo();
            }
            PersonInfo.PName = pnameBox.Text;
            PersonInfo.Address = addressBox.Text;
            PersonInfo.DataPasport = datapasportBox.Text;
            PersonInfo.Type = typeBox.Text;
            PersonInfo.Marka = markaBox.Text;
            PersonInfo.Color = colorBox.Text;
            PersonInfo.NumberFactory = numberfactoryBox.Text;
            PersonInfo.NumberBort = numberbortBox.Text;
            PersonInfo.FeaturesOpus = featuresopusBox.Text;
            PersonInfo.DataOfLastControl = controldateTimePicker.Value;
        }

        
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)//перевірка на те, чи були заповнені всі важливі поля перед закриттям
        {
            if (DialogResult != DialogResult.OK)
                return;
            RequiredValidate(pnameBox, e);
            RequiredValidate(addressBox, e);
            RequiredValidate(datapasportBox, e);
            RequiredValidate(typeBox, e);
            RequiredValidate(markaBox, e);
            RequiredValidate(colorBox, e);
            RequiredValidate(numberfactoryBox, e);
            RequiredValidate(numberbortBox, e);
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            (sender as Control).BackColor = Color.White;
        }
        private void RequiredValidate(Control c, FormClosingEventArgs e)//зміна заднього кольору
        {
            if (string.IsNullOrWhiteSpace(c.Text))
            {
                c.BackColor = Color.Pink;
                e.Cancel = true;
            }
        }

        private void invitationButton_Click(object sender, EventArgs e)//перехід до форми запрошення
        {
            var pf = new Form3(pnameBox.Text, addressBox.Text);
            pf.ShowDialog();
        }
    }
}
