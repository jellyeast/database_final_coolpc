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
    public partial class delete : Form
    {
        string select;//選擇刪除的零件
        string m = "_model";
        public void getselect(string s)
        {
            select = s;
        }
        public void connectsql()
        {
            string model = select + m;
            MessageBox.Show(model);
            try
            {
                MySqlConnection connection = new MySqlConnection("Datasource=localhost;port=3306;username=root;password=awds06758199;database=20210616");
                string selectQuery = "SELECT '" + model + "'FROM cpu ";
                connection.Open();
                MySqlCommand command = new MySqlCommand(selectQuery, connection);

                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    comboBox_model.Items.Add(reader.GetString("'" + model + "'"));
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public delete()
        {
            InitializeComponent();
            connectsql();
        }

        private void back_Click(object sender, EventArgs e)
        {
            Whichone f = new Whichone();
            this.Hide();
            f.Show();
        }

        private void comboBox_model_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_delete_Click(object sender, EventArgs e)
        {

        }
    }
}
