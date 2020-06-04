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
    public partial class Form10 : Form
    {
        public UserContext DB { get; set; }
        public WORKER Workerq { get; set; }
        public Form10()
        {
            InitializeComponent();
            Workerq = null;
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            textBox1.ReadOnly = true;
            if (Workerq != null)
            {
                textBox1.Text = Workerq.Login;
                checkBox1.Checked = Workerq.Role;
                textBox2.Text = Workerq.Password;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Workerq.Login = textBox1.Text;
            Workerq.Role = checkBox1.Checked;
            Workerq.Password = textBox2.Text;
            DB.SaveChanges();
            MessageBox.Show("Вы обновили пользователя");
            Close();
        }
    }
}