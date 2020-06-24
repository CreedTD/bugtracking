using Bugs.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bugs
{
    public partial class Form9 : Form
    {
        public UserContext DB { get; set; }
        public Form9()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string login = textBox1.Text;
            WORKER q = (from worker in DB.Workers
                        where worker.Login == login
                        select worker).FirstOrDefault<WORKER>();
            if (q != null)
            {
                MessageBox.Show("Пользователь с таким логином уже существует");
            }
            else
            {
                WORKER w = new WORKER()
                {
                    Login = textBox1.Text,
                    Role = checkBox1.Checked,
                    Password = textBox2.Text
                };
                DB.Workers.Add(w);
                DB.SaveChanges();
                MessageBox.Show("Вы зарегистрировали пользователя");
                Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
        
    }
}
