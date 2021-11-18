using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //пароль
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //назад
            Form1 newForm = new Form1();
            newForm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //отпраить
            
            String log_user = textBox1.Text;
            String pass_user = textBox2.Text;


            DataTable table = new DataTable();

            string conn = "server=192.168.4.211;port=3306;username=student;password=12345;database = karpova";


            MySqlConnection conn1 = new MySqlConnection(conn);
            conn1.Open();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `shop` WHERE `login` = loginUser AND `password` = passUser");
            //в адекватном случае, если @uL и @uP будут стоять вместо loginUser и passUser
            command.Parameters.Add("@loginUser", MySqlDbType.VarChar).Value = log_user;
            command.Parameters.Add("@passUser", MySqlDbType.VarChar).Value = pass_user;
            adapter.SelectCommand = command;
            adapter.Fill(table);


            if (log_user == "" && pass_user == "")
            {
                MessageBox.Show("Значения пустые");
            }
            else if (log_user == "" || pass_user == "")
            {
                MessageBox.Show("Вы заполнили не все поля");
            }
            else if (table.Rows.Count > 0)
            {
                MessageBox.Show("Поздравляю, вы вошли");
            }
            else
            {
                MessageBox.Show("Какая-та ошибка");
            }

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            //хз что это
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //логин
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
