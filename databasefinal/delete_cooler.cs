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

namespace databasefinal
{
    public partial class delete_cooler : Form
    {
        public delete_cooler()
        {
            InitializeComponent();
            connectsql();
        }

        public void connectsql()
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("server=100.25.117.10;uid=admin;pwd=0000;database=pc;CharSet=utf8;");
                string selectQuery = "SELECT Co_model FROM cooler WHERE 1";
                connection.Open();
                MySqlCommand command = new MySqlCommand(selectQuery, connection);

                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    comboBox_cooler.Items.Add(reader.GetString("Co_model"));
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            Whichfunction f = new Whichfunction();
            this.Hide();
            f.Show();
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            var Result = MessageBox.Show("確認即無法回頭", "請確定好再點選!!!!!!", MessageBoxButtons.OKCancel);
            if (Result == DialogResult.OK)
            {
                try
                {
                    MySqlConnection connection = new MySqlConnection("server=100.25.117.10;uid=admin;pwd=0000;database=pc;CharSet=utf8;");
                    string selectQuery = "DELETE FROM `cooler` WHERE Co_model='" + comboBox_cooler.Text + "' ";
                    connection.Open();
                    MySqlCommand command = new MySqlCommand(selectQuery, connection);

                    MySqlDataReader reader = command.ExecuteReader();


                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                Whichfunction f = new Whichfunction();
                this.Hide();
                f.Show();
            }
        }

        private void comboBox_cooler_SelectedIndexChanged(object sender, EventArgs e)
        {
            string select = this.comboBox_cooler.Text;
            string connString = "server=100.25.117.10;uid=admin;pwd=0000;database=pc;CharSet=utf8;";
            using (MySqlConnection mcon = new MySqlConnection(connString))
            using (MySqlCommand cmd = mcon.CreateCommand())
            {
                mcon.Open();

                cmd.CommandText = "SELECT * FROM `cooler` WHERE Co_model='" + select + "'";
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    reader.Read();
                    Co_model.Text = reader.GetString("Co_model");
                    socket.Text = reader.GetString(reader.GetOrdinal("socket"));
                    brand.Text = reader.GetString("brand");
                    price.Text = reader.GetString(reader.GetOrdinal("price"));
                }
                mcon.Close();
            }
        }

        private void delete_cooler_Load(object sender, EventArgs e)
        {

        }

        private void keyword_TextChanged(object sender, EventArgs e)
        {
            string keyword = this.keyword.Text;
            string key = "%" + keyword + "%";
            comboBox_cooler.Items.Clear();
            string connString = "server=100.25.117.10;uid=admin;pwd=0000;database=pc;CharSet=utf8;";
            using (MySqlConnection mcon = new MySqlConnection(connString))
            using (MySqlCommand cmd = mcon.CreateCommand())
            {
                mcon.Open();

                cmd.CommandText = "SELECT * FROM `cooler` WHERE Co_model LIKE'" + key + "'";

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        comboBox_cooler.Items.Add(reader.GetString("Co_model"));
                    }
                }
                mcon.Close();
            }
        }
    }
}
