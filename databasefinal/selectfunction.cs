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
    public partial class selectfunction : Form
    {
        int function;
        public selectfunction()
        {
            InitializeComponent();
        }

        private void delete_Click(object sender, EventArgs e)
        {  
            Whichdetail f = new Whichdetail();
            function = 0;
            f.getfunction(function);
            this.Hide();
            f.Show();
        }

        private void insertupdate_Click(object sender, EventArgs e)
        {
            Whichdetail f = new Whichdetail();
            function = 1;
            f.getfunction(function);
            this.Hide();
            f.Show();
        }
        private void back_Click(object sender, EventArgs e)
        {

            detail f = new detail();
            this.Hide();
            f.Show();
        }
        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
