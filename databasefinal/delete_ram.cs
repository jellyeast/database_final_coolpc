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
    public partial class delete_ram : Form
    {
        public delete_ram()
        {
            InitializeComponent();
            connectsql();
        }

        public void connectsql()
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("server=100.25.117.10;uid=admin;pwd=0000;database=pc;CharSet=utf8;");
                string selectQuery = "SELECT R_model FROM ram WHERE 1";
                connection.Open();
                MySqlCommand command = new MySqlCommand(selectQuery, connection);

                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    comboBox_ram.Items.Add(reader.GetString("R_model"));
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
                    string selectQuery = "DELETE FROM `ram` WHERE R_model='" + comboBox_ram.Text + "' ";
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

        private void delete_ram_Load(object sender, EventArgs e)
        {

        }

        private void comboBox_ram_SelectedIndexChanged(object sender, EventArgs e)
        {
            string select = this.comboBox_ram.Text;
            string connString = "server=100.25.117.10;uid=admin;pwd=0000;database=pc;CharSet=utf8;";
            using (MySqlConnection mcon = new MySqlConnection(connString))
            using (MySqlCommand cmd = mcon.CreateCommand())
            {
                mcon.Open();

                cmd.CommandText = "SELECT * FROM `ram` WHERE R_model='" + select + "'";
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    reader.Read();
                    R_model.Text = reader.GetString("R_model");
                    R_capacity.Text = reader.GetString(reader.GetOrdinal("R_capacity"));
                    propose.Text = reader.GetString(reader.GetOrdinal("propose"));
                    hz.Text = reader.GetString(reader.GetOrdinal("hz"));
                    brand.Text = reader.GetString("brand");
                    price.Text = reader.GetString(reader.GetOrdinal("price"));
                }
                mcon.Close();
            }
        }

        private void keyword_TextChanged(object sender, EventArgs e)
        {
            string keyword = this.keyword.Text;
            string key = "%" + keyword + "%";
            comboBox_ram.Items.Clear();
            string connString = "server=100.25.117.10;uid=admin;pwd=0000;database=pc;CharSet=utf8;";
            using (MySqlConnection mcon = new MySqlConnection(connString))
            using (MySqlCommand cmd = mcon.CreateCommand())
            {
                mcon.Open();

                cmd.CommandText = "SELECT * FROM `ram` WHERE R_model LIKE'" + key + "'";

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        comboBox_ram.Items.Add(reader.GetString("R_model"));
                    }
                }
                mcon.Close();
            }
        }
    }
}
