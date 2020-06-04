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
        public UserContext DB { get; set; }

        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) //Назад
        {
            Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e) //Поиск ошибки
        {
            
            Form4 addForm = new Form4();
            addForm.DB = this.DB;
            addForm.ShowDialog();
            dataGridView1.DataSource = DB.Errors.ToList();
        }

        private void button2_Click(object sender, EventArgs e) //Добавить ошибку
        {
            Form5 addForm = new Form5();
            addForm.DB = this.DB;
            addForm.ShowDialog();
            dataGridView1.DataSource = DB.Errors.ToList();
        }

        private void button6_Click(object sender, EventArgs e) //Обновить
        {
        }

        private void button7_Click(object sender, EventArgs e) //Удалить пользователя
        {
            /*string connectionString = @"data source=(LocalDB)\v11.0; Initial Catalog = userstore; Integrated Security=True;";
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
            }*/
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            DB = new UserContext();
            dataGridView1.DataSource = DB.Errors.ToList();
            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[1].HeaderText = "Код";
            dataGridView1.Columns[2].HeaderText = "Описание";
            dataGridView1.Columns[3].HeaderText = "Разновидность";
            dataGridView1.Columns[4].HeaderText = "Дата";
            dataGridView1.Columns[5].HeaderText = "Решения";
            dataGridView1.Columns[6].HeaderText = "Ключевые слова";
            dataGridView1.Columns[7].HeaderText = "Работник";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            /*var id = dataGridView1.CurrentRow.Cells[0].Value;
            ERROR e = (from error in DB.Errors
                        where error.Id == id
                        select error).FirstOrDefault<ERROR>();
            Form11 addForm = new Form11();
            addForm.Workerq = e;
            addForm.DB = this.DB;
            addForm.ShowDialog();
            dataGridView1.DataSource = DB.Workers.ToList();*/
 
    }
    }
}
