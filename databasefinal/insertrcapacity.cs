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
    public partial class insertrcapacity : Form
    {
        public insertrcapacity()
        {
            InitializeComponent();
            display_select();
        }
        public void display_select()
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("server=100.25.117.10;uid=admin;pwd=0000;database=pc;CharSet=utf8;");
                string selectQuery = "SELECT * FROM `r_capacity` WHERE 1";
                connection.Open();
                MySqlCommand command = new MySqlCommand(selectQuery, connection);

                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    select.Items.Add(reader.GetString("R_capacity"));
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
            selectfunction f = new selectfunction();
            this.Hide();
            f.Show();
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void select_SelectedIndexChanged(object sender, EventArgs e)
        {
            string select = this.select.Text;
            string connString = "server=100.25.117.10;uid=admin;pwd=0000;database=pc;CharSet=utf8;";
            using (MySqlConnection mcon = new MySqlConnection(connString))
            using (MySqlCommand cmd = mcon.CreateCommand())
            {
                mcon.Open();

                cmd.CommandText = "SELECT * FROM `r_capacity` WHERE R_capacity='" + select + "'";
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    reader.Read();
                    rc.Text = reader.GetString("R_capacity");
                }
                mcon.Close();
            }
        }

        private void insert_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("server=100.25.117.10;uid=admin;pwd=0000;database=pc;CharSet=utf8;");
                string selectQuery = "INSERT INTO `r_capacity`(`R_capacity`) VALUES ('" + rc.Text + "')";
                connection.Open();
                MySqlCommand command = new MySqlCommand(selectQuery, connection);

                MySqlDataReader reader = command.ExecuteReader();

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            selectfunction f = new selectfunction();
            this.Hide();
            f.Show();
        }

        private void update_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("server=100.25.117.10;uid=admin;pwd=0000;database=pc;CharSet=utf8;");
                string selectQuery = "UPDATE `r_capacity` SET `R_capacity`='" + rc.Text + "' WHERE R_capacity='" + select.Text + "'";
                connection.Open();
                MySqlCommand command = new MySqlCommand(selectQuery, connection);

                MySqlDataReader reader = command.ExecuteReader();

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            selectfunction f = new selectfunction();
            this.Hide();
            f.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void rc_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
