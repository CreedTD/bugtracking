using Bugs.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bugs
{
    public partial class Form7 : Form
    {
        public UserContext DB { get; set; }
        //UserContext db = new UserContext();
        public Form7()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form9 addForm = new Form9();
            addForm.DB = this.DB;
            addForm.ShowDialog();
            dataGridView1.DataSource = DB.Workers.ToList();
        }

        private void button5_Click(object sender, EventArgs e)
        {
        //    db.Workers.Load();
        //    dataGridView1.DataSource = db.Workers.Local.ToBindingList();
        }
        private void button3_Click(object sender, EventArgs e)
        {

            string connectionString = @"data source=(LocalDB)\v11.0; Initial Catalog = userstore; Integrated Security=True;";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand com = new SqlCommand("DELETE FROM workers WHERE Login=@id", con);
                com.Parameters.AddWithValue("@id", textBox1.Text);
                con.Open(); //Открываем подключение
                try
                {
                    com.ExecuteNonQuery();
                    MessageBox.Show("Пользователь удален");
                }
                catch
                {
                    MessageBox.Show("Удалить не удалось!");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form10 newForm = new Form10();
            newForm.Show();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            DB = new UserContext();
            dataGridView1.DataSource = DB.Workers.ToList();
            dataGridView1.Columns[0].HeaderText = "Логин";
            dataGridView1.Columns[1].HeaderText = "Роль админа";
            dataGridView1.Columns[2].HeaderText = "Пароль";
        }
    }
}
