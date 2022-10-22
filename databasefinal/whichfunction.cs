using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace databasefinal
{
    public partial class Whichfunction : Form
    {
        int function;
 
        public Whichfunction()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Insert_b_Click(object sender, EventArgs e)
        {
            this.Hide();
            Whichone f = new Whichone();
            function = 0;
            f.Getfunction(function);
            f.Show();
        }

        private void Update_b_Click(object sender, EventArgs e)
        {
            this.Hide();
            Whichone f = new Whichone();
            function = 0;
            f.Getfunction(function);
            f.Show();
        }

        private void Delete_b_Click(object sender, EventArgs e)
        {
            this.Hide();
            Whichone f = new Whichone();
            function = 2;
            f.Getfunction(function);
            f.Show();
        }

        private void Back_b_Click(object sender, EventArgs e)
        {
            this.Hide();
            StartPage f = new StartPage();
            f.Show();
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void back_Click(object sender, EventArgs e)
        {
            detail f = new detail();
            this.Hide();
            f.Show();
        }
    }
}
