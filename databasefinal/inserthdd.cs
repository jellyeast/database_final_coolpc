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
    public partial class inserthdd : Form
    {
        public inserthdd()
        {
            InitializeComponent();
            display_select();
            display_brand();
        }
        private void back_Click(object sender, EventArgs e)
        {
            Whichone f = new Whichone();
            this.Hide();
            f.Show();
        }


        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void back_Click_1(object sender, EventArgs e)
        {
            Whichone f = new Whichone();
            this.Hide();
            f.Show();
        }

        
        public void display_select()
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("server=100.25.117.10;uid=admin;pwd=0000;database=pc;CharSet=utf8;");
                string selectQuery = "SELECT * FROM hdd WHERE 1";
                connection.Open();
                MySqlCommand command = new MySqlCommand(selectQuery, connection);

                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    select.Items.Add(reader.GetString("HDD_model"));
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
                string selectQuery = "SELECT * FROM storage_brand WHERE 1";
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
        

        private void select_SelectedIndexChanged(object sender, EventArgs e)
        {
            string select = this.select.Text;
            string connString = "server=100.25.117.10;uid=admin;pwd=0000;database=pc;CharSet=utf8;";
            using (MySqlConnection mcon = new MySqlConnection(connString))
            using (MySqlCommand cmd = mcon.CreateCommand())
            {
                mcon.Open();

                cmd.CommandText = "SELECT * FROM `hdd` WHERE HDD_model='" + select + "'";
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    reader.Read();
                    HDD_model.Text = reader.GetString("HDD_model");
                    brand.Text = reader.GetString("brand");
                    price.Text = reader.GetString(reader.GetOrdinal("price"));
                }
                mcon.Close();
            }
        }

        private void insert_Click_2(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("server=100.25.117.10;uid=admin;pwd=0000;database=pc;CharSet=utf8;");
                string selectQuery = "INSERT INTO HDD(HDD_model,brand, price) VALUES ('" + HDD_model.Text + "','" + brand.Text + "','" + price.Text + "')";
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
            Whichone f = new Whichone();
            this.Hide();
            f.Show();
        }

        private void update_Click_1(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("server=100.25.117.10;uid=admin;pwd=0000;database=pc;CharSet=utf8;");
                string selectQuery = "UPDATE `hdd` SET `HDD_model`='" + HDD_model.Text + "',`brand`='" + brand.Text + "',`price`='" + price.Text + "' WHERE HDD_model='" + select.Text + "'";
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

                cmd.CommandText = "SELECT * FROM `hdd` WHERE HDD_model LIKE'" + key + "'";

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        select.Items.Add(reader.GetString("HDD_model"));
                    }
                }
                mcon.Close();
            }
        }
    }
}
