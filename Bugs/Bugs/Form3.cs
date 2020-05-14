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

using System.Data.Entity;
using System.Data.SqlClient;

namespace Bugs
{
    public partial class Form3 : Form
    {
        UserContext db = new UserContext();
        public Form3()
        {
            InitializeComponent();
            db.Errors.Load();

            dataGridView1.DataSource = db.Errors.Local.ToBindingList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form4 newForm = new Form4();
            newForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 newForm = new Form5();
            newForm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            db.Errors.Load();

            dataGridView1.DataSource = db.Errors.Local.ToBindingList();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string connectionString = @"data source=(LocalDB)\v11.0; Initial Catalog = userstore; Integrated Security=True;";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand com = new SqlCommand("DELETE FROM errors WHERE Id=@id", con);
                com.Parameters.AddWithValue("@id", textBox1.Text);
                con.Open(); //Открываем подключение
                try
                {
                    com.ExecuteNonQuery();
                    MessageBox.Show("Ошибка удалена");
                }
                catch
                {
                    MessageBox.Show("Удалить не удалось!");
                }
            }
        }
    }
}
