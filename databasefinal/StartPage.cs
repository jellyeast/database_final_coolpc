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
    public partial class StartPage : Form
    {
        public StartPage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 frame = new Form1();
            frame.Show();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginPage frame = new LoginPage();
            frame.Show();
        }
    }
}
