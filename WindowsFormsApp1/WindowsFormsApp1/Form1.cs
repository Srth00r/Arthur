using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Common;

namespace WindowsFormsApp1
{
    public partial class Авторизация : Form
    {
        SqlConnection connect = new SqlConnection("Data Source = 303-3\\SQLEXPRESS; Initial Catalog = driver_db; Integrated Security = true;");
        public Авторизация()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connect.Open();
            SqlCommand auth = new SqlCommand("SELECT * FROM dbo.loginpass WHERE login = '" + textBox1.Text + "' AND pass = '" + textBox2.Text + "'", connect);
            SqlDataReader sqr = auth.ExecuteReader();
            if (sqr.HasRows) MessageBox.Show("Вы авторизовались");
            {
                this.Hide();
                Form2 f2 = new Form2();
                f2.Show();
            }           
            else
            {
             if(Properties.Settings.Default.time <= DateTime, UtcNow)
                {
                    Properties.Settings.Default.co++;
                    if(Properties.Settings.Default.co > 2)
                    {
                        Properties.Settings.Default.time = DateTime.UtcNow.AddMinutes(1);
                        Properties.Settings.Default.co = 0;
                        button1.Enabled = false;
                    }
                }
                MessageBox.Show("Неправильный логин и пароль");
            }
            connect.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
    }
}
