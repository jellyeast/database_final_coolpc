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
using sql_demo;
using System.Runtime.InteropServices;

namespace databasefinal
{
    public partial class Form1 : Form
    {
        string selectvalue_using;
        string selectvalue_prefer;
        string selectvalue_socket;
        string selectvalue_size;
        string selectvalue_cpu;
        string selectvalue_mb;
        string selectvalue_cooler;
        string selectvalue_gpu;
        string selectvalue_psu;
        string selectvalue_case;
        string selectvalue_ram;
        string selectvalue_hdd;
        string selectvalue_ssd;
        float selectvalue_length;
        int ramMaxSlot;
        int sataMaxSlot;
        int pcieMaxSlot;
        int SSDslot;
        int total;
        int psu_watt;
        int gpu_watt;
        int cpu_watt;
        bool menucheck;
        public Form1()
        {
            InitializeComponent();
        }
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);



        bool beginMove = false;//初始化滑鼠位置
        int currentXPosition;
        int currentYPosition;

        //紀錄length
        public void getlength()
        {
            MySqlConnection connection = new MySqlConnection("server=100.25.117.10;uid=admin;pwd=0000;database=pc;CharSet=utf8;");
            string selectQuery = "SELECT length FROM `gpu` WHERE G_model='" + selectvalue_mb + "'";
            connection.Open();
            MySqlCommand command = new MySqlCommand(selectQuery, connection);

            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                selectvalue_length = (reader.GetFloat("length"));
            }
            connection.Close();
        }
        //紀錄size
        public void getsize()
        {
            MySqlConnection connection = new MySqlConnection("server=100.25.117.10;uid=admin;pwd=0000;database=pc;CharSet=utf8;");
            string selectQuery = "SELECT size FROM `mb` WHERE M_model='" + selectvalue_mb + "'";
            connection.Open();
            MySqlCommand command = new MySqlCommand(selectQuery, connection);

            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                selectvalue_size = (reader.GetString("size"));
            }
            connection.Close();
        }
        //紀錄socket
        public void getsocket()
        {
            MySqlConnection connection = new MySqlConnection("server=100.25.117.10;uid=admin;pwd=0000;database=pc;CharSet=utf8;");
            string selectQuery = "SELECT socket FROM `cpu` WHERE CPU_model='" + selectvalue_cpu + "'";
            connection.Open();
            MySqlCommand command = new MySqlCommand(selectQuery, connection);

            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                selectvalue_socket = (reader.GetString("socket"));
            }
            connection.Close();
        }


        //選擇cpu
        public void connectsql_cpu()
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("server=100.25.117.10;uid=admin;pwd=0000;database=pc;CharSet=utf8;");
                string selectQuery = "SELECT CPU_model FROM cpu WHERE propose= '" + selectvalue_using + "'AND brand='" + selectvalue_prefer + "'";
                connection.Open();
                MySqlCommand command = new MySqlCommand(selectQuery, connection);

                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    comboBox_cpu.Items.Add(reader.GetString("CPU_model"));
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        //選擇MB
        public void connectsql_mb()
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("server=100.25.117.10;uid=admin;pwd=0000;database=pc;CharSet=utf8;");
                string selectQuery = "SELECT * FROM mb WHERE propose= '" + selectvalue_using + "' AND socket ='" + selectvalue_socket + "'";
                connection.Open();
                MySqlCommand command = new MySqlCommand(selectQuery, connection);

                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    comboBox_mb.Items.Add(reader.GetString("M_model"));
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //選擇cooler
        public void connectsql_cooler()
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("server=100.25.117.10;uid=admin;pwd=0000;database=pc;CharSet=utf8;");
                string selectQuery = "SELECT Co_model FROM `cooler` WHERE socket='" + selectvalue_socket + "'";
                connection.Open();
                MySqlCommand command = new MySqlCommand(selectQuery, connection);

                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    comboBox_cooler.Items.Add(reader.GetString("Co_model"));
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //選擇gpu
        public void connectsql_gpu()
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("server=100.25.117.10;uid=admin;pwd=0000;database=pc;CharSet=utf8;");
                string selectQuery = "SELECT G_model FROM `gpu` WHERE propose='" + selectvalue_using + "'";
                connection.Open();
                MySqlCommand command = new MySqlCommand(selectQuery, connection);

                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    comboBox_gpu.Items.Add(reader.GetString("G_model"));
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //選擇psu
        public void connectsql_psu()
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("server=100.25.117.10;uid=admin;pwd=0000;database=pc;CharSet=utf8;");
                string selectQuery = "SELECT P_model FROM `psu` WHERE P_watt='" + selectvalue_using + "'";
                connection.Open();
                MySqlCommand command = new MySqlCommand(selectQuery, connection);

                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    comboBox_gpu.Items.Add(reader.GetString("P_watt"));
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //選擇ram
        public void connectsql_ram()
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("server=100.25.117.10;uid=admin;pwd=0000;database=pc;CharSet=utf8;");
                string selectQuery = "SELECT R_model FROM `ram` WHERE propose='" + selectvalue_using + "'";
                connection.Open();
                MySqlCommand command = new MySqlCommand(selectQuery, connection);

                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    comboBox_ram.Items.Add(reader.GetString("R_model"));
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //選擇case

        public void connectsql_using()
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("server=100.25.117.10;uid=admin;pwd=0000;database=pc;CharSet=utf8;");
                string selectQuery = "SELECT propose FROM propose where 1";           
                connection.Open();
                MySqlCommand command = new MySqlCommand(selectQuery, connection);

                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    comboBox_using.Items.Add(reader.GetString("propose"));
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void connectsql_prefer()
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("server=100.25.117.10;uid=admin;pwd=0000;database=pc;CharSet=utf8;");
                string selectQuery = "SELECT brand FROM cpu_brand where 1";
                connection.Open();
                MySqlCommand command = new MySqlCommand(selectQuery, connection);

                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    comboBox_prefer.Items.Add(reader.GetString("brand"));
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void connectsql_case()
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("server=100.25.117.10;uid=admin;pwd=0000;database=pc;CharSet=utf8;");
                string selectQuery;
                if (string.IsNullOrEmpty(comboBox_gpu.Text))
                {
                    selectQuery = "SELECT Ca_model FROM c_case where size='" + selectvalue_size + "'";
                }
                else
                {
                    selectQuery = "SELECT Ca_model FROM c_case where size='" + selectvalue_size + "' AND length >= '" + selectvalue_length + "'";
                }
                connection.Open();
                MySqlCommand command = new MySqlCommand(selectQuery, connection);

                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    comboBox_case.Items.Add(reader.GetString("Ca_model"));
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //選擇HDD
        public void connectsql_HDD()
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("server=100.25.117.10;uid=admin;pwd=0000;database=pc;CharSet=utf8;");
                string selectQuery = "SELECT * FROM HDD";
                connection.Open();
                MySqlCommand command = new MySqlCommand(selectQuery, connection);

                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    comboBox_HDD.Items.Add(reader.GetString("HDD_model"));
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //選擇SSD
        public void connectsql_SSD()
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("server=100.25.117.10;uid=admin;pwd=0000;database=pc;CharSet=utf8;");
                string selectQuery = "SELECT * FROM SSD ";
                connection.Open();
                MySqlCommand command = new MySqlCommand(selectQuery, connection);

                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    comboBox_SSD.Items.Add(reader.GetString("SSD_model"));
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            connectsql_using();
        }

        //依照選擇優先順序排列combobox
        private void comboBox_using_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox_cpu.Items.Clear();
            comboBox_gpu.Items.Clear();
            comboBox_prefer.Items.Clear();
            comboBox_mb.Items.Clear();
            comboBox_cooler.Items.Clear();
            comboBox_ram.Items.Clear();
            comboBox_case.Items.Clear();
            comboBox_psu.Items.Clear();
            selectvalue_cpu = "";
            selectvalue_gpu = "";
            selectvalue_mb = "";
            selectvalue_cooler = "";
            selectvalue_case = "";
            selectvalue_ram = "";
            selectvalue_psu = "";
            cpuNum.Items.Clear();
            cpuPriceTB.Clear();
            cpuSP.Clear();
            mbNum.Items.Clear();
            mbPriceTB.Clear();
            mbSP.Clear();
            gpuNum.Items.Clear();
            gpuPriceTB.Clear();
            gpuSP.Clear();
            coolerNum.Items.Clear();
            coolerPriceTB.Clear();
            coolerSP.Clear();
            ramNum.Items.Clear();
            ramPriceTB.Clear();
            ramSP.Clear();
            caseNum.Items.Clear();
            casePriceTB.Clear();
            caseSP.Clear();
            psuNum.Items.Clear();
            psuPriceTB.Clear();
            psuSP.Clear();
            cpu_watt = 0;
            gpu_watt = 0;
            selectvalue_using = comboBox_using.SelectedItem.ToString();

            connectsql_prefer();

        }

        private void comboBox_prefer_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox_cpu.Items.Clear();
            comboBox_case.Items.Clear();
            comboBox_cooler.Items.Clear();
            comboBox_mb.Items.Clear();
            comboBox_psu.Items.Clear();
            selectvalue_cpu = "";
            selectvalue_psu = "";
            selectvalue_mb = "";
            selectvalue_cooler = "";
            selectvalue_case = "";
            cpuNum.Items.Clear();
            cpuPriceTB.Clear();
            cpuSP.Clear();
            mbNum.Items.Clear();
            mbPriceTB.Clear();
            mbSP.Clear();
            coolerNum.Items.Clear();
            coolerPriceTB.Clear();
            coolerSP.Clear();
            caseNum.Items.Clear();
            casePriceTB.Clear();
            caseSP.Clear();
            psuNum.Items.Clear();
            psuPriceTB.Clear();
            psuSP.Clear();
            comboBox_gpu.Items.Clear();
            gpuNum.Items.Clear();
            gpuPriceTB.Clear();
            gpuSP.Clear();
            comboBox_HDD.Items.Clear();
            HDDNum.Items.Clear();
            HDDPriceTB.Clear();
            HDDSP.Clear();
            selectvalue_hdd = "";
            comboBox_SSD.Items.Clear();
            SSDNum.Items.Clear();
            SSDPriceTB.Clear();
            SSDSP.Clear();
            selectvalue_ssd = "";
            selectvalue_prefer = comboBox_prefer.SelectedItem.ToString();
            cpu_watt = 0;

            connectsql_cpu();
        }

        private void comboBox_cpu_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox_cooler.Items.Clear();
            coolerNum.Items.Clear();
            coolerPriceTB.Clear();
            coolerSP.Clear();
            comboBox_mb.Items.Clear();
            comboBox_case.Items.Clear();
            caseNum.Items.Clear();
            casePriceTB.Clear();
            caseSP.Clear();
            selectvalue_mb = "";
            selectvalue_cooler = "";
            selectvalue_case = "";
            cpuPriceTB.Clear();
            cpuNum.Items.Clear();
            mbPriceTB.Clear();
            mbNum.Items.Clear();
            mbSP.Clear();
            comboBox_HDD.Items.Clear();
            HDDNum.Items.Clear();
            HDDPriceTB.Clear();
            HDDSP.Clear();
            selectvalue_hdd = "";
            comboBox_SSD.Items.Clear();
            SSDNum.Items.Clear();
            SSDPriceTB.Clear();
            SSDSP.Clear();
            selectvalue_ssd = "";
            comboBox_psu.Items.Clear();
            selectvalue_psu = "";
            psuNum.Items.Clear();
            psuPriceTB.Clear();
            psuSP.Clear();
            cpuNum.Items.Add("1");
            cpuNum.SelectedIndex = 0;
            selectvalue_cpu = comboBox_cpu.SelectedItem.ToString();

            
            getsocket();

            connectsql_mb();
            connectsql_cooler();


            ////////////單價
            cpu_connect_price();
            /////獲得瓦數
            get_cpu_TDP();
            count_watt();
            totolPrice(1);

        }

        private void comboBox_mb_SelectedIndexChanged(object sender, EventArgs e)
        {
            mbPriceTB.Clear();
            comboBox_case.Items.Clear();
            caseNum.Items.Clear();
            casePriceTB.Clear();
            caseSP.Clear();

            comboBox_HDD.Items.Clear();
            HDDNum.Items.Clear();
            HDDPriceTB.Clear();
            HDDSP.Clear();
            selectvalue_hdd = "";
            comboBox_SSD.Items.Clear();
            SSDNum.Items.Clear();
            SSDPriceTB.Clear();
            SSDSP.Clear();
            selectvalue_ssd = "";
            selectvalue_case = "";
            mbNum.Items.Clear();
            mbNum.Items.Add("1");
            mbNum.SelectedIndex = 0;
            selectvalue_mb = comboBox_mb.SelectedItem.ToString();
            comboBox_gpu.Items.Clear();
            gpuNum.Items.Clear();
            gpuPriceTB.Clear();
            gpuSP.Clear();

            getsize();
            connectsql_case();
            mb_connect_price();
            connectsql_gpu();
            connectsql_ram();
            connectsql_HDD();
            connectsql_SSD();
            totolPrice(2);
            get_P_slot();
            get_S_slot();
        }

        private void comboBox_gpu_SelectedIndexChanged(object sender, EventArgs e)
        {
            gpuPriceTB.Clear();
            comboBox_case.Items.Clear();
            caseNum.Items.Clear();
            casePriceTB.Clear();
            caseSP.Clear();
            selectvalue_case = "";
            selectvalue_gpu = comboBox_gpu.SelectedItem.ToString();
            comboBox_psu.Items.Clear();
            selectvalue_psu = "";
            gpuNum.Items.Clear();
            comboBox_psu.Items.Clear();
            psuNum.Items.Clear();
            psuPriceTB.Clear();
            psuSP.Clear();
            getlength();

            connectsql_case();
            gpu_connect_price();
            //數量
            makeslotnum(2, pcieMaxSlot);
            if (pcieMaxSlot == 1)
            {
                gpuNum.SelectedIndex = 0;
                totolPrice(4);
            }
            /////獲得瓦數
            get_gpu_TDP();
        }

        private void comboBox_cooler_SelectedIndexChanged(object sender, EventArgs e)
        {
            coolerPriceTB.Clear();
            coolerNum.Items.Clear();
            coolerNum.Items.Add("1");
            coolerNum.SelectedIndex = 0;
            selectvalue_cooler = comboBox_cooler.SelectedItem.ToString();
            cooler_connect_price();
            totolPrice(3);
        }

        private void comboBox_ram_SelectedIndexChanged(object sender, EventArgs e)
        {
            ramPriceTB.Clear();
            ramNum.Items.Clear();
            selectvalue_ram = comboBox_ram.SelectedItem.ToString();
            ram_connect_price();
            //改變slot
            get_R_slot();
            makeslotnum(1, ramMaxSlot);
        }

        private void comboBox_case_SelectedIndexChanged(object sender, EventArgs e)
        {
            casePriceTB.Clear();
            caseNum.Items.Clear();
            caseNum.Items.Add("1");
            caseNum.SelectedIndex = 0;
            selectvalue_case = comboBox_case.SelectedItem.ToString();
            case_connect_price();
            totolPrice(6);
        }

        private void comboBox_HDD_SelectedIndexChanged(object sender, EventArgs e)
        {
            HDDPriceTB.Clear();
            HDDNum.Items.Clear();
            SSDNum.Items.Clear();
            selectvalue_hdd = comboBox_HDD.SelectedItem.ToString();
            HDD_connect_price();
            makeslotnum(3, sataMaxSlot);
        }

        private void comboBox_SSD_SelectedIndexChanged(object sender, EventArgs e)
        {
            SSDPriceTB.Clear();
            SSDNum.Items.Clear();
            selectvalue_ssd = comboBox_SSD.SelectedItem.ToString();
            SSD_connect_price();
            determinssd();
            makeslotnum(4, SSDslot);
        }

        private void button_WOC1_Click(object sender, EventArgs e)
        {
            getallprice();
            checkmenu();
            string priceSum = Convert.ToString(total);
            if (menucheck)
            {
                insertmenu();
                this.Hide();
                Form2 frame = new Form2();
                frame.Show();
                frame.show_data(selectvalue_cpu, selectvalue_mb, selectvalue_cooler, selectvalue_gpu, selectvalue_case, selectvalue_hdd, selectvalue_ssd, selectvalue_ram, selectvalue_psu, cpuNum.Text, mbNum.Text, coolerNum.Text, gpuNum.Text, caseNum.Text, HDDNum.Text, SSDNum.Text, ramNum.Text, psuNum.Text, priceSum);
            }
            else
            {
                MessageBox.Show("請確認數量都有選到 否則無法形成菜單");
            }
        }

        private void comboBox_psu_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectvalue_psu = comboBox_psu.SelectedItem.ToString();
            psu_connect_price();
            psuNum.Items.Add("1");
            psuNum.SelectedIndex = 0;
            totolPrice(5);

        }

        private void button_WOC2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                beginMove = true;
                currentXPosition = MousePosition.X;//滑鼠的x座標為當前窗體左上角x座標
                currentYPosition = MousePosition.Y;//滑鼠的y座標為當前窗體左上角y座標
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (beginMove)
            {
                this.Left += MousePosition.X - currentXPosition;//根據滑鼠x座標確定窗體的左邊座標x
                this.Top += MousePosition.Y - currentYPosition;//根據滑鼠的y座標窗體的頂部，即Y座標
                currentXPosition = MousePosition.X;
                currentYPosition = MousePosition.Y;
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                currentXPosition = 0; //設定初始狀態
                currentYPosition = 0;
                beginMove = false;
            }
        }

        public void cpu_connect_price()
        {

            string connString = "server=100.25.117.10;uid=admin;pwd=0000;database=pc;CharSet=utf8;";
            using (MySqlConnection mcon = new MySqlConnection(connString))
            using (MySqlCommand cmd = mcon.CreateCommand())
            {
                mcon.Open();

                cmd.CommandText = "SELECT price FROM cpu where CPU_model='" + selectvalue_cpu + "'";
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    reader.Read();
                    cpuSP.Text = reader.GetString(reader.GetOrdinal("price"));
                }
                mcon.Close();
            }
        }
        public void mb_connect_price()
        {

            string connString = "server=100.25.117.10;uid=admin;pwd=0000;database=pc;CharSet=utf8;";
            using (MySqlConnection mcon = new MySqlConnection(connString))
            using (MySqlCommand cmd = mcon.CreateCommand())
            {
                mcon.Open();
                cmd.CommandText = "SELECT price FROM mb where M_model='" + selectvalue_mb + "'";
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    reader.Read();
                    mbSP.Text = reader.GetString(reader.GetOrdinal("price"));
                }
                mcon.Close();
            }
        }
        public void cooler_connect_price()
        {

            string connString = "server=100.25.117.10;uid=admin;pwd=0000;database=pc;CharSet=utf8;";
            using (MySqlConnection mcon = new MySqlConnection(connString))
            using (MySqlCommand cmd = mcon.CreateCommand())
            {
                mcon.Open();
                cmd.CommandText = "SELECT price FROM cooler where Co_model='" + selectvalue_cooler + "'";
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    reader.Read();
                    coolerSP.Text = reader.GetString(reader.GetOrdinal("price"));
                }
                mcon.Close();
            }
        }
        public void gpu_connect_price()
        {

            string connString = "server=100.25.117.10;uid=admin;pwd=0000;database=pc;CharSet=utf8;";
            using (MySqlConnection mcon = new MySqlConnection(connString))
            using (MySqlCommand cmd = mcon.CreateCommand())
            {
                mcon.Open();

                cmd.CommandText = "SELECT * FROM gpu where G_model='" + selectvalue_gpu + "'";
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    reader.Read();
                    gpuSP.Text = reader.GetString(reader.GetOrdinal("price"));
                }
                mcon.Close();
            }
        }
        public void psu_connect_price()
        {

            string connString = "server=100.25.117.10;uid=admin;pwd=0000;database=pc;CharSet=utf8;";
            using (MySqlConnection mcon = new MySqlConnection(connString))
            using (MySqlCommand cmd = mcon.CreateCommand())
            {
                mcon.Open();

                cmd.CommandText = "SELECT * FROM psu where P_model='" + selectvalue_psu + "'";
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    reader.Read();
                    psuSP.Text = reader.GetString(reader.GetOrdinal("price"));
                }
                mcon.Close();
            }
        }
        public void case_connect_price()
        {

            string connString = "server=100.25.117.10;uid=admin;pwd=0000;database=pc;CharSet=utf8;";
            using (MySqlConnection mcon = new MySqlConnection(connString))
            using (MySqlCommand cmd = mcon.CreateCommand())
            {
                mcon.Open();

                cmd.CommandText = "SELECT price FROM c_case where Ca_model='" + selectvalue_case + "'";
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {

                    reader.Read();
                    caseSP.Text = reader.GetString(reader.GetOrdinal("price"));
                }
                mcon.Close();
            }
        }
        public void HDD_connect_price()
        {

            string connString = "server=100.25.117.10;uid=admin;pwd=0000;database=pc;CharSet=utf8;";
            using (MySqlConnection mcon = new MySqlConnection(connString))
            using (MySqlCommand cmd = mcon.CreateCommand())
            {
                mcon.Open();

                cmd.CommandText = "SELECT price FROM hdd where HDD_model='" + selectvalue_hdd + "'";
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    reader.Read();
                    HDDSP.Text = reader.GetString(reader.GetOrdinal("price"));
                }
                mcon.Close();
            }
        }
        public void SSD_connect_price()
        {

            string connString = "server=100.25.117.10;uid=admin;pwd=0000;database=pc;CharSet=utf8;";
            using (MySqlConnection mcon = new MySqlConnection(connString))
            using (MySqlCommand cmd = mcon.CreateCommand())
            {
                mcon.Open();
                cmd.CommandText = "SELECT price FROM ssd where SSD_model='" + selectvalue_ssd + "'";
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    reader.Read();
                    SSDSP.Text = reader.GetString("price");
                }
                mcon.Close();
            }
        }
        public void ram_connect_price()
        {
            string connString = "server=100.25.117.10;uid=admin;pwd=0000;database=pc;CharSet=utf8;";
            using (MySqlConnection mcon = new MySqlConnection(connString))
            using (MySqlCommand cmd = mcon.CreateCommand())
            {
                mcon.Open();

                cmd.CommandText = "SELECT price FROM ram where R_model='" + selectvalue_ram + "'";
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    reader.Read();
                    ramSP.Text = reader.GetString(reader.GetOrdinal("price"));
                }
                mcon.Close();
            }
        }
        public void get_R_slot()
        {
            string connString = "server=100.25.117.10;uid=admin;pwd=0000;database=pc;CharSet=utf8;";
            using (MySqlConnection mcon = new MySqlConnection(connString))
            using (MySqlCommand cmd = mcon.CreateCommand())
            {

                mcon.Open();

                cmd.CommandText = "SELECT R_slot FROM mb where M_model='" + selectvalue_mb + "'";
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    reader.Read();
                    string s = reader.GetString("R_slot");
                    ramMaxSlot = int.Parse(s);
                }
                mcon.Close();
            }
        }
        public void get_S_slot()
        {
            string connString = "server=100.25.117.10;uid=admin;pwd=0000;database=pc;CharSet=utf8;";
            using (MySqlConnection mcon = new MySqlConnection(connString))
            using (MySqlCommand cmd = mcon.CreateCommand())
            {
                mcon.Open();

                cmd.CommandText = "SELECT S_slot FROM mb where M_model='" + selectvalue_mb + "'";
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    reader.Read();
                    sataMaxSlot = reader.GetInt32(reader.GetOrdinal("S_slot"));
                }
                mcon.Close();
            }
        }
        public void get_P_slot()
        {
            string connString = "server=100.25.117.10;uid=admin;pwd=0000;database=pc;CharSet=utf8;";
            using (MySqlConnection mcon = new MySqlConnection(connString))
            using (MySqlCommand cmd = mcon.CreateCommand())
            {
                mcon.Open();

                cmd.CommandText = "SELECT P_slot FROM mb where M_model='" + selectvalue_mb + "'";
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    reader.Read();
                    pcieMaxSlot = reader.GetInt32(reader.GetOrdinal("P_slot"));
                }
                mcon.Close();
            }
        }
        public void makeslotnum(int box, int slot)
        {
            switch (box)
            {
                case 1:
                    for (int i = 1; i <= slot; i++)
                    {
                        ramNum.Items.Add(Convert.ToString(i));
                    }
                    break;
                case 2:
                    for (int i = 1; i <= slot; i++)
                    {
                        gpuNum.Items.Add(Convert.ToString(i));
                    }
                    break;
                case 3:
                    for (int i = 1; i <= slot; i++)
                    {
                        HDDNum.Items.Add(Convert.ToString(i));
                    }
                    break;
                case 4:
                    for (int i = 1; i <= slot; i++)
                    {
                        SSDNum.Items.Add(Convert.ToString(i));
                    }
                    break;
            }
        }
        public void totolPrice(int PriceBox)
        {
            switch (PriceBox)
            {
                case 1:
                    cpuPriceTB.Text = Convert.ToString(int.Parse(cpuSP.Text) * int.Parse(cpuNum.Text));
                    break;
                case 2:
                    mbPriceTB.Text = Convert.ToString(int.Parse(mbSP.Text) * int.Parse(mbNum.Text));
                    break;
                case 3:
                    coolerPriceTB.Text = Convert.ToString(int.Parse(coolerSP.Text) * int.Parse(coolerNum.Text));
                    break;
                case 4:
                    gpuPriceTB.Text = Convert.ToString(int.Parse(gpuSP.Text) * int.Parse(gpuNum.Text));
                    break;
                case 5:
                    psuPriceTB.Text = Convert.ToString(int.Parse(psuSP.Text) * int.Parse(psuNum.Text));
                    break;
                case 6:
                    casePriceTB.Text = Convert.ToString(int.Parse(caseSP.Text) * int.Parse(caseNum.Text));
                    break;
                case 7:
                    HDDPriceTB.Text = Convert.ToString(int.Parse(HDDSP.Text) * int.Parse(HDDNum.Text));
                    break;
                case 8:
                    SSDPriceTB.Text = Convert.ToString(int.Parse(SSDSP.Text) * int.Parse(SSDNum.Text));
                    break;
                case 9:
                    ramPriceTB.Text = Convert.ToString(int.Parse(ramSP.Text) * int.Parse(ramNum.Text));
                    break;

            }
        }
        public void determinssd()
        {
            if (string.IsNullOrEmpty(HDDNum.Text))
            {
                SSDslot = sataMaxSlot;
            }
            else
            {
                SSDslot = sataMaxSlot - int.Parse(HDDNum.Text);
            }
        }

        private void HDDNum_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (int.Parse(HDDNum.Text) == sataMaxSlot)
            {
                comboBox_SSD.Items.Clear();
                SSDNum.Items.Clear();
                SSDSP.Clear();
                SSDPriceTB.Clear();
                selectvalue_ssd = "";
                totolPrice(7);
            }
            else
            {
                comboBox_SSD.Items.Clear();
                selectvalue_ssd = "";
                SSDNum.Items.Clear();
                SSDSP.Clear();
                SSDPriceTB.Clear();
                connectsql_SSD();
                totolPrice(7);
            }

        }

        private void cpuNum_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox_psu.Items.Clear();
            selectvalue_psu = "";
            psuNum.Items.Clear();
            psuPriceTB.Clear();
            psuSP.Clear();
            select_psu();
        }

        private void mbNum_SelectedIndexChanged(object sender, EventArgs e)
        {
            //totolPrice(2);
        }

        private void coolerNum_SelectedIndexChanged(object sender, EventArgs e)
        {
            //totolPrice(3);
        }

        private void gpuNum_SelectedIndexChanged(object sender, EventArgs e)
        {
            count_watt();
            totolPrice(4);
            comboBox_psu.Items.Clear();
            selectvalue_psu = "";
            psuNum.Items.Clear();
            psuPriceTB.Clear();
            psuSP.Clear();
            select_psu();
        }

        private void psuNum_SelectedIndexChanged(object sender, EventArgs e)
        {
            //totolPrice(5);
        }

        private void ramNum_SelectedIndexChanged(object sender, EventArgs e)
        {
            totolPrice(9);
        }

        private void SSDNum_SelectedIndexChanged(object sender, EventArgs e)
        {
            totolPrice(8);
        }

        private void caseNum_SelectedIndexChanged(object sender, EventArgs e)
        {
            //totolPrice(6);
        }

        public void getallprice()
        {
            total = 0;
            if (!string.IsNullOrEmpty(cpuPriceTB.Text))
            {
                total += int.Parse(cpuPriceTB.Text);
            }
            if (!string.IsNullOrEmpty(mbPriceTB.Text))
            {
                total += int.Parse(mbPriceTB.Text);
            }
            if (!string.IsNullOrEmpty(gpuPriceTB.Text))
            {
                total += int.Parse(gpuPriceTB.Text);
            }
            if (!string.IsNullOrEmpty(coolerPriceTB.Text))
            {
                total += int.Parse(coolerPriceTB.Text);
            }
            if (!string.IsNullOrEmpty(casePriceTB.Text))
            {
                total += int.Parse(casePriceTB.Text);
            }
            if (!string.IsNullOrEmpty(HDDPriceTB.Text))
            {
                total += int.Parse(HDDPriceTB.Text);
            }
            if (!string.IsNullOrEmpty(SSDPriceTB.Text))
            {
                total += int.Parse(SSDPriceTB.Text);
            }
            if (!string.IsNullOrEmpty(ramPriceTB.Text))
            {
                total += int.Parse(ramPriceTB.Text);
            }
            if (!string.IsNullOrEmpty(psuPriceTB.Text))
            {
                total += int.Parse(psuPriceTB.Text);
            }
        }
        public void get_cpu_TDP()
        {
            string connString = "server=100.25.117.10;uid=admin;pwd=0000;database=pc;CharSet=utf8;";
            using (MySqlConnection mcon = new MySqlConnection(connString))
            using (MySqlCommand cmd = mcon.CreateCommand())
            {
                mcon.Open();

                cmd.CommandText = "SELECT CPU_TDP FROM cpu where CPU_model='" + selectvalue_cpu + "'";
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    reader.Read();
                    cpu_watt = reader.GetInt32(reader.GetOrdinal("CPU_TDP"));
                }
                mcon.Close();
            }
        }
        public void get_gpu_TDP()
        {
            string connString = "server=100.25.117.10;uid=admin;pwd=0000;database=pc;CharSet=utf8;";
            using (MySqlConnection mcon = new MySqlConnection(connString))
            using (MySqlCommand cmd = mcon.CreateCommand())
            {
                mcon.Open();

                cmd.CommandText = "SELECT G_TDP FROM gpu where G_model='" + selectvalue_gpu + "'";
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    reader.Read();
                    gpu_watt = reader.GetInt32(reader.GetOrdinal("G_TDP"));
                }
                mcon.Close();
            }
        }
        public void select_psu()
        {
            string connString = "server=100.25.117.10;uid=admin;pwd=0000;database=pc;CharSet=utf8;";
            using (MySqlConnection mcon = new MySqlConnection(connString))
            using (MySqlCommand cmd = mcon.CreateCommand())
            {
                mcon.Open();

                cmd.CommandText = "SELECT * FROM psu WHERE P_watt BETWEEN '" + (psu_watt + 200) + "' AND '" + (psu_watt + 400) + "'";
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        comboBox_psu.Items.Add(reader.GetString("P_model"));
                    }                  
                }
                mcon.Close();
            }
        }
        public void count_watt()
        {
            if (string.IsNullOrEmpty(gpuNum.Text))
            {
                psu_watt = cpu_watt;
            }
            else
            {
                psu_watt = cpu_watt + gpu_watt * int.Parse(gpuNum.Text);
            }
        }
        public void checkmenu()
        {
            if (!string.IsNullOrEmpty(comboBox_cpu.Text) && string.IsNullOrEmpty(cpuNum.Text))
            {
                menucheck = false;
            }
            else if (!string.IsNullOrEmpty(comboBox_mb.Text) && string.IsNullOrEmpty(mbNum.Text))
            {
                menucheck = false;
            }
            else if (!string.IsNullOrEmpty(comboBox_cooler.Text) && string.IsNullOrEmpty(coolerNum.Text))
            {
                menucheck = false;
            }
            else if (!string.IsNullOrEmpty(comboBox_gpu.Text) && string.IsNullOrEmpty(gpuNum.Text))
            {
                menucheck = false;
            }
            else if (!string.IsNullOrEmpty(comboBox_psu.Text) && string.IsNullOrEmpty(psuNum.Text))
            {
                menucheck = false;
            }
            else if (!string.IsNullOrEmpty(comboBox_case.Text) && string.IsNullOrEmpty(caseNum.Text))
            {
                menucheck = false;
            }
            else if (!string.IsNullOrEmpty(comboBox_HDD.Text) && string.IsNullOrEmpty(HDDNum.Text))
            {
                menucheck = false;
            }
            else if (!string.IsNullOrEmpty(comboBox_SSD.Text) && string.IsNullOrEmpty(SSDNum.Text))
            {
                menucheck = false;
            }
            else if (!string.IsNullOrEmpty(comboBox_ram.Text) && string.IsNullOrEmpty(ramNum.Text))
            {
                menucheck = false;
            }
            else
            {
                menucheck = true;
            }
        }
        public void insertmenu()
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("server=100.25.117.10;uid=admin;pwd=0000;database=pc;CharSet=utf8;");
                string selectQuery = "INSERT INTO `menu` (`M_ID`, `cpu`, `mb`, `gpu`, `ram`, `C_case`, `psu`, `HDD`, `SSD`, `cooler`, `cpu_num`, `mb_num`, `gpu_num`, `ram_num`, `case_num`, `psu_num`, `HDD_num`, `SSD_num`, `cooler_num`, `total`) VALUES (NULL,'" + selectvalue_cpu + "','" + selectvalue_mb + "','" + selectvalue_gpu + "','" + selectvalue_ram + "','" + selectvalue_case + "','" + selectvalue_psu + "','" + selectvalue_hdd + "','" + selectvalue_ssd + "','" + selectvalue_cooler + "','" + cpuNum.Text + "','" + mbNum.Text + "','" + gpuNum.Text + "','" +ramNum.Text + "','" + caseNum.Text + "','" + psuNum.Text + "','" + HDDNum.Text + "','" + SSDNum.Text + "','" + coolerNum.Text + "','" + total + "')";
                connection.Open();
                MySqlCommand command = new MySqlCommand(selectQuery, connection);

                MySqlDataReader reader = command.ExecuteReader();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}