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
    public partial class Informatics : Form
    {
        public Informatics()
        {
            InitializeComponent();

            refresh();
        }

        void refresh()
        {
            MySqlConnection fall = new MySqlConnection("Server = localhost; Database = journal of progress; uid=root; pwd= ; Charset=utf8");
            MySqlDataAdapter da = new MySqlDataAdapter("select * from informatics", fall);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            fall.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FullName_TextChanged(object sender, EventArgs e)
        {

        }

        private void Evaluationn_TextChanged(object sender, EventArgs e)
        {

        }

        private void Date_TextChanged(object sender, EventArgs e)
        {

        }

        private void Save_Click(object sender, EventArgs e)
        {
            MySqlConnection fall = new MySqlConnection("Server = localhost; Database = journal of progress; uid=root; pwd= ; Charset=utf8");
            MySqlDataAdapter da = new MySqlDataAdapter("insert into informatics(cname,cevaluation,cdate) values('" + FullName.Text + "','" + Evaluationn.Text + "','" + Date.Text + "')", fall);
            DataTable dt = new DataTable();
            da.Fill(dt);
            fall.Close();
            refresh();
        }

        private void Dell_TextChanged(object sender, EventArgs e)
        {

        }

        private void Delete_Click(object sender, EventArgs e)
        {
            MySqlConnection fall = new MySqlConnection("Server = localhost; Database = journal of progress; uid=root; pwd= ; Charset=utf8");
            MySqlDataAdapter da = new MySqlDataAdapter("delete from informatics where id_c=" + Dell.Text, fall);
            DataTable dt = new DataTable();
            da.Fill(dt);
            fall.Close();
            refresh();
        }

        private void LogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            Authorization f2 = new Authorization();
            f2.Show();
        }

        private void Backtomenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu f2 = new Menu();
            f2.Show();
        }
    }
}
