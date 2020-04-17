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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form6 newForm = new Form6();
            newForm.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 newForm = new Form3();
            newForm.Show();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form8 newForm = new Form8();
            newForm.Show();
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form7 newForm = new Form7();
            newForm.Show();
            this.Close();
        }
    }
}
