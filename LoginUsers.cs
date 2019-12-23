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

namespace Fall_Project_2._0
{
    public partial class LoginUsers : Form
    {
        public LoginUsers()
        {
            InitializeComponent();

            refresh();
        }
        void refresh()
        {
            MySqlConnection fall = new MySqlConnection("Server = localhost; Database = journal of progress; uid=root; pwd= ; Charset=utf8");
            MySqlDataAdapter da = new MySqlDataAdapter("select * from log", fall);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            fall.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection fall = new MySqlConnection("Server = localhost; Database = journal of progress; uid=root; pwd= ; Charset=utf8");
            MySqlDataAdapter da = new MySqlDataAdapter("insert into log(Clog,Cpass) values('" + Login.Text + "','" + Password.Text + "')", fall);
            DataTable dt = new DataTable();
            da.Fill(dt);
            fall.Close();
            refresh();
        }

        private void AddPerson_Load(object sender, EventArgs e)
        {

        }

        private void FChildren_TextChanged(object sender, EventArgs e)
        {

        }

        private void NChildren_TextChanged(object sender, EventArgs e)
        {

        }

        private void DeletePerson_Click(object sender, EventArgs e)
        {
            MySqlConnection fall = new MySqlConnection("Server = localhost; Database = journal of progress; uid=root; pwd= ; Charset=utf8");
            MySqlDataAdapter da = new MySqlDataAdapter("delete from log where id_c=" + textBox1.Text, fall);
            DataTable dt = new DataTable();
            da.Fill(dt);
            fall.Close();
            refresh();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Backtomenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu f2 = new Menu();
            f2.Show();
        }
    }
}
