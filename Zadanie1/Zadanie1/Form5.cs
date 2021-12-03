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
using ClassLibrary3;

namespace Zadanie1
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Class1 conn4 = new Class1();
            MySqlConnection connect = new MySqlConnection(conn4.connDB); 
            string fioStud = textBox2.Text; 
            string time = DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss"); 
            MessageBox.Show(time);
            string timeStud = textBox1.Text == "" ? time : textBox1.Text; 
            string sql = $"INSERT INTO t_PraktStud (fioStud, datetimeStud)  VALUES ('{fioStud}','{timeStud}');";
            int counter = 0;
            try
            {
                connect.Open();

                MySqlCommand command1 = new MySqlCommand(sql, connect);
                counter = command1.ExecuteNonQuery();

            }
            catch
            {
                MessageBox.Show("Произошла ошибка");
            }
            finally
            {
                connect.Close();

                if (counter != 0)
                {
                    MessageBox.Show("Ввод данных успешен");
                }
            }
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }
    }
}
