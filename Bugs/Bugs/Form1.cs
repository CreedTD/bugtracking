﻿using Bugs.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bugs
{
    public partial class Form1 : Form
    {
        UserContext db = new UserContext();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*WORKER worker = new WORKER();
            worker.Login = textBox1.Text;
            worker.Password = Convert.ToInt32(textBox2.Text);
            if (worker.Login && worker.Password)
            */
            Form2 newForm = new Form2();
                newForm.Show();
        }
    }
}