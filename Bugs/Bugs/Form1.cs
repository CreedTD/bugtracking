using Bugs.Classes;
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
        UserContext db;
        public Form1()
        {
            InitializeComponent();
            db = new UserContext();
            db.Workers.Load();

            dataGridView1.DataSource = db.Workers.Local.ToBindingList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 newForm = new Form2();
            newForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}