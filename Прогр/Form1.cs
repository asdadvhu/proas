﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Прогр
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Нажал на кнопку");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Нажал на кнопочку");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Нажал на кнпку");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Нажал на саму длинную кнопку здесь");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Нажал на очередную кнопку");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"вы ввели вот это: {textBox1.Text}");
        }
    }
}
