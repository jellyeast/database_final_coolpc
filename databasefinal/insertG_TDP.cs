﻿using System;
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
    public partial class insertG_TDP : Form
    {
        public insertG_TDP()
        {
            InitializeComponent();
            display_select();
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void back_Click(object sender, EventArgs e)
        {
            selectfunction f = new selectfunction();
            this.Hide();
            f.Show();
        }

        private void insert_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("server=100.25.117.10;uid=admin;pwd=0000;database=pc;CharSet=utf8;");
                string selectQuery = "INSERT INTO g_tdp(G_TDP) VALUES ('" + G_TDP.Text + "')";
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
                string selectQuery = "UPDATE `G_TDP` SET `G_TDP`='" + G_TDP.Text + "' WHERE G_TDP='" + select.Text + "'";
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

        private void select_SelectedIndexChanged(object sender, EventArgs e)
        {
            string select = this.select.Text;
            string connString = "server=100.25.117.10;uid=admin;pwd=0000;database=pc;CharSet=utf8;";
            using (MySqlConnection mcon = new MySqlConnection(connString))
            using (MySqlCommand cmd = mcon.CreateCommand())
            {
                mcon.Open();

                cmd.CommandText = "SELECT * FROM `G_TDP` WHERE G_TDP='" + select + "'";
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    reader.Read();
                    G_TDP.Text = reader.GetString("G_TDP");
                }
                mcon.Close();
            }
        }
        public void display_select()
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("server=100.25.117.10;uid=admin;pwd=0000;database=pc;CharSet=utf8;");
                string selectQuery = "SELECT * FROM G_TDP WHERE 1";
                connection.Open();
                MySqlCommand command = new MySqlCommand(selectQuery, connection);

                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    select.Items.Add(reader.GetString("G_TDP"));
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
