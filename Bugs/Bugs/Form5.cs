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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (UserContext dc = new UserContext())
            {
                ERROR error = new ERROR();

                error.Id = Convert.ToInt32(textBox4.Text);
                error.Code = textBox1.Text;
                error.Description = textBox2.Text;
                error.Variety = textBox5.Text;

                dc.Errors.Add(error);
                dc.SaveChanges();
            }
            MessageBox.Show("Вы зарегистрировали ошибку");
            this.Close();
        }
    }
}
