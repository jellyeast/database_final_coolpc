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
    public partial class delete_mb : Form
    {
        public delete_mb()
        {
            InitializeComponent();
            connectsql();
        }

        public void connectsql()
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("server=100.25.117.10;uid=admin;pwd=0000;database=pc;CharSet=utf8;");
                string selectQuery = "SELECT M_model FROM mb WHERE 1";
                connection.Open();
                MySqlCommand command = new MySqlCommand(selectQuery, connection);

                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    comboBox_mb.Items.Add(reader.GetString("M_model"));
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
                    string selectQuery = "DELETE FROM `mb` WHERE M_model='" + comboBox_mb.Text + "' ";
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

        private void back_Click_1(object sender, EventArgs e)
        {

        }

        private void close_Click_1(object sender, EventArgs e)
        {

        }

        private void delete_mb_Load(object sender, EventArgs e)
        {

        }

        private void comboBox_mb_SelectedIndexChanged(object sender, EventArgs e)
        {
            string select = this.comboBox_mb.Text;
            string connString = "server=100.25.117.10;uid=admin;pwd=0000;database=pc;CharSet=utf8;";
            using (MySqlConnection mcon = new MySqlConnection(connString))
            using (MySqlCommand cmd = mcon.CreateCommand())
            {
                mcon.Open();

                cmd.CommandText = "SELECT * FROM `mb` WHERE M_model='" + select + "'";
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    reader.Read();
                    M_model.Text = reader.GetString("M_model");
                    socket.Text = reader.GetString(reader.GetOrdinal("socket"));
                    size.Text = reader.GetString(reader.GetOrdinal("size"));
                    R_slot.Text = reader.GetString(reader.GetOrdinal("R_slot"));
                    S_slot.Text = reader.GetString(reader.GetOrdinal("S_slot"));
                    P_slot.Text = reader.GetString(reader.GetOrdinal("P_slot"));
                    R_capacity.Text = reader.GetString(reader.GetOrdinal("R_capacity"));
                    propose.Text = reader.GetString(reader.GetOrdinal("propose"));
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
            comboBox_mb.Items.Clear();
            string connString = "server=100.25.117.10;uid=admin;pwd=0000;database=pc;CharSet=utf8;";
            using (MySqlConnection mcon = new MySqlConnection(connString))
            using (MySqlCommand cmd = mcon.CreateCommand())
            {
                mcon.Open();

                cmd.CommandText = "SELECT * FROM `mb` WHERE M_model LIKE'" + key + "'";

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        comboBox_mb.Items.Add(reader.GetString("M_model"));
                    }
                }
                mcon.Close();
            }
        }
    }
}
