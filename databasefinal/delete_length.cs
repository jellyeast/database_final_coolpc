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
    public partial class delete_length : Form
    {
        public delete_length()
        {
            InitializeComponent();
            connectsql();
        }


        private void back_Click(object sender, EventArgs e)
        {
            selectfunction f = new selectfunction();
            this.Hide();
            f.Show();
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            var Result = MessageBox.Show("確認即無法回頭", "請確定好再點選!!!!!!", MessageBoxButtons.OKCancel);
            if (Result == DialogResult.OK)
            {
                try
                {
                    MySqlConnection connection = new MySqlConnection("server=100.25.117.10;uid=admin;pwd=0000;database=pc;CharSet=utf8;");
                    string selectQuery = "DELETE FROM `length` WHERE length='" + comboBox_length.Text + "'";
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
        }
        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void connectsql()
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("server=100.25.117.10;uid=admin;pwd=0000;database=pc;CharSet=utf8;");
                string selectQuery = "SELECT length FROM length WHERE 1";
                connection.Open();
                MySqlCommand command = new MySqlCommand(selectQuery, connection);

                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    comboBox_length.Items.Add(reader.GetString("length"));
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
