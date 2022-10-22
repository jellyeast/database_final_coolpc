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
    public partial class Whichdetail : Form
    {
        int function;
        public Whichdetail()
        {
            InitializeComponent();
        }
        public void getfunction(int f)
        {
            function = f;
        }
        private void cpu_brand_Click(object sender, EventArgs e)
        {
            if (function == 0)
            {
                delete_cpu_brand d = new delete_cpu_brand();
                this.Hide();
                d.Show();
            }
            else
            {
                insertcpu_brand d = new insertcpu_brand();
                this.Hide();
                d.Show();
            }
        }

        private void cpu_TDP_Click(object sender, EventArgs e)
        {
            if (function == 0)
            {
                delete_cpu_TDP d = new delete_cpu_TDP();
                this.Hide();
                d.Show();
            }
            else
            {
                insertCPU_TDP d = new insertCPU_TDP();
                this.Hide();
                d.Show();
            }
        }

        private void case_brand_Click(object sender, EventArgs e)
        {
            if (function == 0)
            {
                delete_case_brand d = new delete_case_brand();
                this.Hide();
                d.Show();
            }
            else
            {
                insertcase_brand d = new insertcase_brand();
                this.Hide();
                d.Show();
            }
        }

        private void psu_brand_Click(object sender, EventArgs e)
        {
            if (function == 0)
            {
                delete_psu_brand d = new delete_psu_brand();
                this.Hide();
                d.Show();
            }
            else
            {
                insertpsu_brand d = new insertpsu_brand();
                this.Hide();
                d.Show();
            }
        }

        private void ram_brand_Click(object sender, EventArgs e)
        {
            if (function == 0)
            {
                delete_ram_brand d = new delete_ram_brand();
                this.Hide();
                d.Show();
            }
            else
            {
                insertrambrand d = new insertrambrand();
                this.Hide();
                d.Show();
            }
        }

        private void mg_brand_Click(object sender, EventArgs e)
        {
            if (function == 0)
            {
                delete_mg_brand d = new delete_mg_brand();
                this.Hide();
                d.Show();
            }
            else
            {
                insertmg_brand d = new insertmg_brand();
                this.Hide();
                d.Show();
            }
        }

        private void ram_hz_Click(object sender, EventArgs e)
        {
            if (function == 0)
            {
                delete_ram_hz d = new delete_ram_hz();
                this.Hide();
                d.Show();
            }
            else
            {
                insertramhz d = new insertramhz();
                this.Hide();
                d.Show();
            }
        }

        private void cooler_brand_Click(object sender, EventArgs e)
        {
            if (function == 0)
            {
                delete_cooler_brand d = new delete_cooler_brand();
                this.Hide();
                d.Show();
            }
            else
            {
                insertcooler_brand d = new insertcooler_brand();
                this.Hide();
                d.Show();
            }
        }

        private void length_Click(object sender, EventArgs e)
        {
            if (function == 0)
            {
                delete_length d = new delete_length();
                this.Hide();
                d.Show();
            }
            else
            {
                insertlength d = new insertlength();
                this.Hide();
                d.Show();
            }
        }

        private void storage_brand_Click(object sender, EventArgs e)
        {
            if (function == 0)
            {
                delete_storage_brand d = new delete_storage_brand();
                this.Hide();
                d.Show();
            }
            else
            {
                insert_storage_brand d = new insert_storage_brand();
                this.Hide();
                d.Show();
            }
        }

        private void socket_Click(object sender, EventArgs e)
        {
            if (function == 0)
            {
                delete_socket d = new delete_socket();
                this.Hide();
                d.Show();
            }
            else
            {
                insertsocket d = new insertsocket();
                this.Hide();
                d.Show();
            }
        }

        private void PS_slot_Click(object sender, EventArgs e)
        {
            if (function == 0)
            {
                delete_PS_slot d = new delete_PS_slot();
                this.Hide();
                d.Show();
            }
            else
            {
                insertPSslot d = new insertPSslot();
                this.Hide();
                d.Show();
            }
        }

        private void r_capacity_Click(object sender, EventArgs e)
        {
            if (function == 0)
            {
                delete_r_capacity d = new delete_r_capacity();
                this.Hide();
                d.Show();
            }
            else
            {
                insertrcapacity d = new insertrcapacity();
                this.Hide();
                d.Show();
            }
        }

        private void G_TDP_Click(object sender, EventArgs e)
        {
            if (function == 0)
            {
                delete_g_TDP d = new delete_g_TDP();
                this.Hide();
                d.Show();
            }
            else
            {
                insertG_TDP d = new insertG_TDP();
                this.Hide();
                d.Show();
            }
        }

        private void propose_Click(object sender, EventArgs e)
        {
            if (function == 0)
            {
                delete_propose d = new delete_propose();
                this.Hide();
                d.Show();
            }
            else
            {
                insertpropose d = new insertpropose();
                this.Hide();
                d.Show();
            }
        }

        private void p_watt_Click(object sender, EventArgs e)
        {
            if (function == 0)
            {
                delete_p_watt d = new delete_p_watt();
                this.Hide();
                d.Show();
            }
            else
            {
                insertPwatt d = new insertPwatt();
                this.Hide();
                d.Show();
            }
        }

        private void size_Click(object sender, EventArgs e)
        {
            if (function == 0)
            {
                delete_size d = new delete_size();
                this.Hide();
                d.Show();
            }
            else
            {
                insertsize d = new insertsize();
                this.Hide();
                d.Show();
            }
        }

        private void r_slot_Click(object sender, EventArgs e)
        {
            if (function == 0)
            {
                delete_r_slot d = new delete_r_slot();
                this.Hide();
                d.Show();
            }
            else
            {
                insert_rslot d = new insert_rslot();
                this.Hide();
                d.Show();
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
    }
}
