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
        public UserContext DB { get; set; }
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            ERROR err = new ERROR()
            {
                Id = Convert.ToInt32(textBox4.Text),
                Code = textBox1.Text,
                Description = textBox2.Text,
                Variety = textBox5.Text,
                Dataivremya = dateTimePicker1.Value
                //Keyword = textBox3.Text,//virtual
            };
            DB.Errors.Add(err);
            DB.SaveChanges();// выдает ошибку
            MessageBox.Show("Вы зарегистрировали ошибку");
            Close();
        }
    }
}
