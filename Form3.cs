using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //отправить
            if (textBox2.Text == textBox1.Text)
            {
                // подключение вадима MySqlConnection conn = new MySqlConnection("server=192.168.4.211;port=3306;username=student;password=12345;database=voronin431");
                string conn = "server = 192.168.4.211;" + "port = 3306;" + "user = student;" + "database = karpova;" + "password = 12345;";
                MySqlConnection conn1 = new MySqlConnection(conn);
                conn1.Open();

                MySqlCommand reg = new MySqlCommand("INSERT INTO shop (name, login, password) values ('" + textBox4.Text + "', '" + textBox3.Text + "', '" + textBox1.Text + "');" , conn1);
                reg.ExecuteNonQuery();

                conn1.Close();

                // Команда-запрос в БД, чтобы записать нового пользователя - insert into


                Hide();
                Form2 newForm = new Form2();
                newForm.Show();
                this.Close();
            }
            else MessageBox.Show("Пароли не совпадают! Попробуйте снова","Ошибка");

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //назад
            Form1 newForm = new Form1();
            newForm.Show();
            this.Hide();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            //логин
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            //почта
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //пароль
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //повтор пароля
        }
    }
}
