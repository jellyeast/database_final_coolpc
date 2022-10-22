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
using 保固頁;

namespace databasefinal
{
    public partial class mainpage : Form
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
        int HDDslot;
        int SSDslot;
        RMA fr2;

        public mainpage()
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
            MySqlConnection connection = new MySqlConnection("Server=localhost;Database=pc;Uid=root;Pwd=A130863543;Charset=utf8;");
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
            MySqlConnection connection = new MySqlConnection("Server=localhost;Database=pc;Uid=root;Pwd=A130863543;Charset=utf8;");
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
            MySqlConnection connection = new MySqlConnection("Server=localhost;Database=pc;Uid=root;Pwd=A130863543;Charset=utf8;");
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
                MySqlConnection connection = new MySqlConnection("Server=localhost;Database=pc;Uid=root;Pwd=A130863543;Charset=utf8;");
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
                MySqlConnection connection = new MySqlConnection("Server=localhost;Database=pc;Uid=root;Pwd=A130863543;Charset=utf8;");
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
                MySqlConnection connection = new MySqlConnection("Server=localhost;Database=pc;Uid=root;Pwd=A130863543;Charset=utf8;");
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
                MySqlConnection connection = new MySqlConnection("Server=localhost;Database=pc;Uid=root;Pwd=A130863543;Charset=utf8;");
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

        //選擇ram
        public void connectsql_ram()
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("Server=localhost;Database=pc;Uid=root;Pwd=A130863543;Charset=utf8;");
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
        public void connectsql_case()
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("Server=localhost;Database=pc;Uid=root;Pwd=A130863543;Charset=utf8;");
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
                MySqlConnection connection = new MySqlConnection("Server=localhost;Database=pc;Uid=root;Pwd=A130863543;Charset=utf8;");
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
                MySqlConnection connection = new MySqlConnection("Server=localhost;Database=pc;Uid=root;Pwd=A130863543;Charset=utf8;");
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
            comboBox_using.Items.Add("遊戲");
            comboBox_using.Items.Add("文書");
            comboBox_using.Items.Add("伺服器");

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
            selectvalue_using = comboBox_using.SelectedItem.ToString();

            comboBox_prefer.Items.Add("intel");
            comboBox_prefer.Items.Add("AMD");

        }

        private void comboBox_prefer_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox_cpu.Items.Clear();
            comboBox_case.Items.Clear();
            comboBox_cooler.Items.Clear();
            comboBox_mb.Items.Clear();
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
            selectvalue_prefer = comboBox_prefer.SelectedItem.ToString();

            connectsql_cpu();
        }

        private void comboBox_cpu_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox_cooler.Items.Clear();
            comboBox_mb.Items.Clear();
            comboBox_case.Items.Clear();
            cpuNum.Items.Add("1");
            selectvalue_cpu = comboBox_cpu.SelectedItem.ToString();

            getsocket();

            connectsql_mb();
            connectsql_cooler();


            ////////////單價
            cpu_connect_price();
        }

        private void comboBox_mb_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox_case.Items.Clear();
            mbNum.Items.Add("1");
            selectvalue_mb = comboBox_mb.SelectedItem.ToString();

            getsize();
            connectsql_case();
            mb_connect_price();
            connectsql_gpu();
            connectsql_ram();
            connectsql_HDD();
            connectsql_SSD();
            get_P_slot();
            get_S_slot();
        }

        private void comboBox_gpu_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox_case.Items.Clear();
            selectvalue_gpu = comboBox_gpu.SelectedItem.ToString();

            getlength();

            connectsql_case();
            gpu_connect_price();
            //數量
            makeslotnum(2, pcieMaxSlot);
        }

        private void comboBox_cooler_SelectedIndexChanged(object sender, EventArgs e)
        {
            coolerNum.Items.Add("1");
            selectvalue_cooler = comboBox_cooler.SelectedItem.ToString();
            cooler_connect_price();
        }

        private void comboBox_ram_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectvalue_ram = comboBox_ram.SelectedItem.ToString();
            ram_connect_price();
            //改變slot
            get_R_slot();
            makeslotnum(1, ramMaxSlot);
        }

        private void comboBox_case_SelectedIndexChanged(object sender, EventArgs e)
        {
            caseNum.Items.Add("1");
            selectvalue_case = comboBox_case.SelectedItem.ToString();
            case_connect_price();
        }

        private void comboBox_HDD_SelectedIndexChanged(object sender, EventArgs e)
        {
            HDDNum.Items.Clear();
            SSDNum.Items.Clear();
            selectvalue_hdd = comboBox_HDD.SelectedItem.ToString();
            HDD_connect_price();
            makeslotnum(3, sataMaxSlot);
        }

        private void comboBox_SSD_SelectedIndexChanged(object sender, EventArgs e)
        {
            SSDNum.Items.Clear();
            selectvalue_ssd = comboBox_SSD.SelectedItem.ToString();
            SSD_connect_price();
            determinssd();
            makeslotnum(4, SSDslot);
        }

        private void button_WOC1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 frame = new Form2();
            frame.Show();   
        }

        private void comboBox_psu_SelectedIndexChanged(object sender, EventArgs e)
        {
            psu_connect_price();
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

            string connString = "Server=localhost;Database=pc;Uid=root;Pwd=A130863543;Charset=utf8;";
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

            string connString = "Server=localhost;Database=pc;Uid=root;Pwd=A130863543;Charset=utf8;";
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

            string connString = "Server=localhost;Database=pc;Uid=root;Pwd=A130863543;Charset=utf8;";
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

            string connString = "Server=localhost;Database=pc;Uid=root;Pwd=A130863543;Charset=utf8;";
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

            string connString = "Server=localhost;Database=pc;Uid=root;Pwd=A130863543;Charset=utf8;";
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

            string connString = "Server=localhost;Database=pc;Uid=root;Pwd=A130863543;Charset=utf8;";
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

            string connString = "Server=localhost;Database=pc;Uid=root;Pwd=A130863543;Charset=utf8;";
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

            string connString = "Server=localhost;Database=pc;Uid=root;Pwd=A130863543;Charset=utf8;";
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
            string connString = "Server=localhost;Database=pc;Uid=root;Pwd=A130863543;Charset=utf8;";
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
            string connString = "Server=localhost;Database=pc;Uid=root;Pwd=A130863543;Charset=utf8;";
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
            string connString = "Server=localhost;Database=pc;Uid=root;Pwd=A130863543;Charset=utf8;";
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
            string connString = "Server=localhost;Database=pc;Uid=root;Pwd=A130863543;Charset=utf8;";
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
                HDDslot = 0;
                SSDslot = sataMaxSlot;
            }
            else
            {
                HDDslot = int.Parse(HDDNum.Text);
                SSDslot = sataMaxSlot - int.Parse(HDDNum.Text);
            }
        }

        private void HDDNum_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (int.Parse(HDDNum.Text) == sataMaxSlot)
            {
                comboBox_SSD.Items.Clear();
                SSDNum.Items.Clear();
            }
            else
            {
                connectsql_SSD();
            }
            totolPrice(7);
        }

        private void cpuNum_SelectedIndexChanged(object sender, EventArgs e)
        {
            totolPrice(1);
        }

        private void mbNum_SelectedIndexChanged(object sender, EventArgs e)
        {
            totolPrice(2);
        }

        private void coolerNum_SelectedIndexChanged(object sender, EventArgs e)
        {
            totolPrice(3);
        }

        private void gpuNum_SelectedIndexChanged(object sender, EventArgs e)
        {
            totolPrice(4);
        }

        private void psuNum_SelectedIndexChanged(object sender, EventArgs e)
        {
            totolPrice(5);
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
            totolPrice(6);
        }

        private void button_WOC3_Click(object sender, EventArgs e)
        {
            this.Hide();
            fr2 = new RMA();
            fr2.Show();
            fr2.show_cpu_data(selectvalue_cpu);
            fr2.show_mb_data(selectvalue_mb);
            fr2.show_co_data(selectvalue_cooler);
            fr2.show_gpu_data(selectvalue_gpu);
            fr2.show_psu_data(selectvalue_psu);
            fr2.show_case_data(selectvalue_case);
            fr2.show_HDD_data(selectvalue_hdd);
            fr2.show_SSD_data(selectvalue_ssd);
            fr2.show_ram_data(selectvalue_ram);
        }
    }
}