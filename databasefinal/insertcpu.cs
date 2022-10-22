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
    public partial class insertcpu : Form
    {
        public insertcpu()
        {
            InitializeComponent();
            display_select();
            display_CPU_TDP();
            display_propose();
            display_brand();
            display_socket();
        }

        private void back_Click(object sender, EventArgs e)
        {
            Whichone f = new Whichone();
            this.Hide();
            f.Show();
        }

        private void insert_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("server=100.25.117.10;uid=admin;pwd=0000;database=pc;CharSet=utf8;");
                string selectQuery = "INSERT INTO `cpu`(`CPU_model`, `CPU_TDP`, `propose`, `socket`, `clock`, `brand`, `price`) VALUES ('" + CPU_model.Text + "','" + CPU_TDP.Text + "','" + propose.Text + "','" + socket.Text + "','" + clock.Text + "','" + brand.Text + "','" + price.Text + "') ";
                connection.Open();
                MySqlCommand command = new MySqlCommand(selectQuery, connection);

                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                }
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

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public void display_select()
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("server=100.25.117.10;uid=admin;pwd=0000;database=pc;CharSet=utf8;");
                string selectQuery = "SELECT * FROM cpu WHERE 1";
                connection.Open();
                MySqlCommand command = new MySqlCommand(selectQuery, connection);

                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    select.Items.Add(reader.GetString("CPU_model"));
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public void display_CPU_TDP()
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("server=100.25.117.10;uid=admin;pwd=0000;database=pc;CharSet=utf8;");
                string selectQuery = "SELECT * FROM cpu_tdp WHERE 1";
                connection.Open();
                MySqlCommand command = new MySqlCommand(selectQuery, connection);

                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    CPU_TDP.Items.Add(reader.GetString("CPU_TDP"));
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public void display_propose()
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("server=100.25.117.10;uid=admin;pwd=0000;database=pc;CharSet=utf8;");
                string selectQuery = "SELECT * FROM propose WHERE 1";
                connection.Open();
                MySqlCommand command = new MySqlCommand(selectQuery, connection);

                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    propose.Items.Add(reader.GetString("propose"));
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public void display_socket()
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("server=100.25.117.10;uid=admin;pwd=0000;database=pc;CharSet=utf8;");
                string selectQuery = "SELECT * FROM socket WHERE 1";
                connection.Open();
                MySqlCommand command = new MySqlCommand(selectQuery, connection);

                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    socket.Items.Add(reader.GetString("socket"));
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public void display_brand()
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("server=100.25.117.10;uid=admin;pwd=0000;database=pc;CharSet=utf8;");
                string selectQuery = "SELECT * FROM cpu_brand WHERE 1";
                connection.Open();
                MySqlCommand command = new MySqlCommand(selectQuery, connection);

                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    brand.Items.Add(reader.GetString("brand"));
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void insertcpu_Load(object sender, EventArgs e)
        {

        }
        private void comboBox_select_SelectedIndexChanged(object sender, EventArgs e)
        {
            string select = this.select.Text;
            string connString = "server=100.25.117.10;uid=admin;pwd=0000;database=pc;CharSet=utf8;";
            using (MySqlConnection mcon = new MySqlConnection(connString))
            using (MySqlCommand cmd = mcon.CreateCommand())
            {
                mcon.Open();

                cmd.CommandText = "SELECT * FROM `cpu` WHERE CPU_model='" + select + "'";
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    reader.Read();
                    CPU_model.Text = reader.GetString("CPU_model");
                    CPU_TDP.Text = reader.GetString(reader.GetOrdinal("CPU_TDP"));
                    propose.Text = reader.GetString("propose");
                    socket.Text = reader.GetString("socket");
                    clock.Text = reader.GetString("clock");
                    brand.Text = reader.GetString("brand");
                    price.Text = reader.GetString(reader.GetOrdinal("price"));
                }
                mcon.Close();
            }
        }

        private void update_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("server=100.25.117.10;uid=admin;pwd=0000;database=pc;CharSet=utf8;");
                string selectQuery = "UPDATE `cpu` SET `CPU_model`='" + CPU_model.Text + "',`CPU_TDP`='" + CPU_TDP.Text + "',`propose`='" + propose.Text + "',`socket`='" + socket.Text + "',`clock`='" + clock.Text + "',`brand`='" + brand.Text + "',`price`='" + price.Text + "' WHERE CPU_model='" + select.Text + "'";
                connection.Open();
                MySqlCommand command = new MySqlCommand(selectQuery, connection);

                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                }
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

        private void keyword_TextChanged(object sender, EventArgs e)
        {
            string keyword = this.keyword.Text;
            string key = "%" + keyword + "%";
            select.Items.Clear();
            string connString = "server=100.25.117.10;uid=admin;pwd=0000;database=pc;CharSet=utf8;";
            using (MySqlConnection mcon = new MySqlConnection(connString))
            using (MySqlCommand cmd = mcon.CreateCommand())
            {
                mcon.Open();

                cmd.CommandText = "SELECT * FROM `cpu` WHERE CPU_model LIKE'" + key + "'";

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        select.Items.Add(reader.GetString("CPU_model"));
                    }
                }
                mcon.Close();
            }
        }
    }
}
