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
    public partial class Whichone : Form
    {
        int function;
        public void Getfunction(int f)
        {
            function = f;
        }
        public Whichone()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            Whichfunction f = new Whichfunction();
            this.Hide();
            f.Show();
        }

        private void CPU_Click(object sender, EventArgs e)
        {
            if (function == 0)
            {
                insertcpu f = new insertcpu();
                this.Hide();
                f.Show();
            }
            
            else
            {
                this.Hide();
                delete_cpu f = new delete_cpu();
                f.Show();
            }
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MB_Click(object sender, EventArgs e)
        {
            if (function == 0)
            {
                insertmb f = new insertmb();
                this.Hide();
                f.Show();
            }
            
            else
            {
                this.Hide();
                delete_mb f = new delete_mb();
                f.Show();
            }
        }

        private void GPU_Click(object sender, EventArgs e)
        {
            if (function == 0)
            {
                insertgpu f = new insertgpu();
                this.Hide();
                f.Show();
            }
            
            else
            {
                this.Hide();
                delete_gpu f = new delete_gpu();
                f.Show();
            }
        }

        private void RAM_Click(object sender, EventArgs e)
        {
            if (function == 0)
            {
                insertram f = new insertram();
                this.Hide();
                f.Show();
            }
            
            else
            {
                this.Hide();
                delete_ram f = new delete_ram();
                f.Show();
            }
        }

        private void Cooler_Click(object sender, EventArgs e)
        {
            if (function == 0)
            {
                insertcooler f = new insertcooler();
                this.Hide();
                f.Show();
            }
            
            else
            {
                this.Hide();
                delete_cooler f = new delete_cooler();
                f.Show();
            }
        }

        private void Case_Click(object sender, EventArgs e)
        {
            if (function == 0)
            {
                insertcase f = new insertcase();
                this.Hide();
                f.Show();
            }
            
            else
            {
                this.Hide();
                delete_case f = new delete_case();
                f.Show();
            }
        }

        private void HDD_Click(object sender, EventArgs e)
        {
            if (function == 0)
            {
                inserthdd f = new inserthdd();
                this.Hide();
                f.Show();
            }
            
            else
            {
                this.Hide();
                delete_hdd f = new delete_hdd();
                f.Show();
            }
        }

        private void SSD_Click(object sender, EventArgs e)
        {
            if (function == 0)
            {
                insertssd f = new insertssd();
                this.Hide();
                f.Show();
            }
            
            else
            {
                this.Hide();
                delete_ssd f = new delete_ssd();
                f.Show();
            }
        }

        private void PSU_Click(object sender, EventArgs e)
        {
            if (function == 0)
            {
                insertpsu f = new insertpsu();
                this.Hide();
                f.Show();
            }
            
            else
            {
                this.Hide();
                delete_psu f = new delete_psu();
                f.Show();
            }
        }

        private void Whichone_Load(object sender, EventArgs e)
        {

        }
    }
}
