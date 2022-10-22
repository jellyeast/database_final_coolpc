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
using System.Windows;
using Excel = Microsoft.Office.Interop.Excel;//添加命名空间

namespace databasefinal
{
    public partial class RMA : Form
    {
        string selectname_cpu;
        string selectname_mb;
        string selectname_co;
        string selectname_gpu;
        string selectname_psu;
        string selectname_case;
        string selectname_ram;
        string selectname_hdd;
        string selectname_ssd;
        DataTable dtTable = new DataTable();
        ListViewItem lvi = new ListViewItem();
        bool[] selected = new bool[] { false, false, false, false, false, false, false, false, false, };
        public RMA()
        {
            InitializeComponent(); 
        }

        //由翁旻醇編輯"server=localhost;uid=root;pwd=xxxxxxxx;database=xxx;CharSet=utf8;"已經全部由serverdata取代
        
        string serverdata = "server=100.25.117.10;uid=admin;pwd=0000;database=pc;CharSet=utf8;";
        public void connectsql_cpu()
        {
            MySqlConnection connection = new MySqlConnection(serverdata);
            string cname = "SELECT brand FROM `cpu` WHERE CPU_model='" + selectname_cpu + "'";
            connection.Open();
            MySqlCommand command = new MySqlCommand(cname, connection);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                lvi.SubItems.Add(reader.GetString("brand"));
            }
            connection.Close();
        }
        public void connectsql_a_cname()
        {
            MySqlConnection connection = new MySqlConnection(serverdata);
            string cname = "SELECT Agent_name FROM `cpu`,`agent` WHERE cpu.brand=agent.brand AND CPU_model='" + selectname_cpu + "'";
            connection.Open();
            MySqlCommand command = new MySqlCommand(cname, connection);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                lvi.SubItems.Add(reader.GetString("Agent_name"));
            }
            connection.Close();
        }
        public void connectsql_pw_cname()
        {
            MySqlConnection connection = new MySqlConnection(serverdata);
            string cname = "SELECT telephone,web FROM  (`cpu`NATURAL JOIN `agent` )NATURAL JOIN `company`  WHERE agent.Agent_name=company.Agent_name AND CPU_model='" + selectname_cpu + "'";
            connection.Open();
            MySqlCommand command = new MySqlCommand(cname, connection);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                lvi.SubItems.Add(reader.GetString("telephone"));
                lvi.SubItems.Add(reader.GetString("web"));
            }
            connection.Close();
        }
        public void connectsql_mb()
        {
            MySqlConnection connection = new MySqlConnection(serverdata);
            string cname = "SELECT brand FROM `mb` WHERE M_model='" + selectname_mb + "'";
            connection.Open();
            MySqlCommand command = new MySqlCommand(cname, connection);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                lvi.SubItems.Add(reader.GetString("brand"));
            }
            connection.Close();
        }
        public void connectsql_a_mname()
        {
            MySqlConnection connection = new MySqlConnection(serverdata);
            string cname = "SELECT Agent_name FROM `mb`,`agent` WHERE mb.brand=agent.brand AND M_model='" + selectname_mb + "'";
            connection.Open();
            MySqlCommand command = new MySqlCommand(cname, connection);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                lvi.SubItems.Add(reader.GetString("Agent_name"));
            }
            connection.Close();
        }
        public void connectsql_pw_mname()
        {
            MySqlConnection connection = new MySqlConnection(serverdata);
            string cname = "SELECT telephone,web FROM  (`mb`NATURAL JOIN `agent` )NATURAL JOIN `company`  WHERE agent.Agent_name=company.Agent_name AND M_model='" + selectname_mb + "'";
            connection.Open();
            MySqlCommand command = new MySqlCommand(cname, connection);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                lvi.SubItems.Add(reader.GetString("telephone"));
                lvi.SubItems.Add(reader.GetString("web"));
            }
            connection.Close();
        }
        public void connectsql_co()
        {
            MySqlConnection connection = new MySqlConnection(serverdata);
            string cname = "SELECT brand FROM `cooler` WHERE Co_model='" + selectname_co + "'";
            connection.Open();
            MySqlCommand command = new MySqlCommand(cname, connection);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                lvi.SubItems.Add(reader.GetString("brand"));
            }
            connection.Close();
        }
        public void connectsql_a_coname()
        {
            MySqlConnection connection = new MySqlConnection(serverdata);
            string cname = "SELECT Agent_name FROM `cooler`,`agent` WHERE cooler.brand=agent.brand AND Co_model='" + selectname_co + "'";
            connection.Open();
            MySqlCommand command = new MySqlCommand(cname, connection);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                lvi.SubItems.Add(reader.GetString("Agent_name"));
            }
            connection.Close();
        }
        public void connectsql_pw_coname()
        {
            MySqlConnection connection = new MySqlConnection(serverdata);
            string cname = "SELECT telephone,web FROM  (`cooler`NATURAL JOIN `agent` )NATURAL JOIN `company`  WHERE agent.Agent_name=company.Agent_name AND Co_model='" + selectname_co + "'";
            connection.Open();
            MySqlCommand command = new MySqlCommand(cname, connection);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                lvi.SubItems.Add(reader.GetString("telephone"));
                lvi.SubItems.Add(reader.GetString("web"));
            }
            connection.Close();
        }
        public void connectsql_gpu()
        {
            MySqlConnection connection = new MySqlConnection(serverdata);
            string cname = "SELECT brand FROM `gpu` WHERE G_model='" + selectname_gpu + "'";
            connection.Open();
            MySqlCommand command = new MySqlCommand(cname, connection);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                lvi.SubItems.Add(reader.GetString("brand"));
            }
            connection.Close();
        }
        public void connectsql_a_gname()
        {
            MySqlConnection connection = new MySqlConnection(serverdata);
            string cname = "SELECT Agent_name FROM `gpu`,`agent` WHERE gpu.brand=agent.brand AND G_model='" + selectname_gpu + "'";
            connection.Open();
            MySqlCommand command = new MySqlCommand(cname, connection);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                lvi.SubItems.Add(reader.GetString("Agent_name"));
            }
            connection.Close();
        }
        public void connectsql_pw_gname()
        {
            MySqlConnection connection = new MySqlConnection(serverdata);
            string cname = "SELECT telephone,web FROM  (`gpu`NATURAL JOIN `agent` )NATURAL JOIN `company`  WHERE agent.Agent_name=company.Agent_name AND G_model='" + selectname_gpu + "'";
            connection.Open();
            MySqlCommand command = new MySqlCommand(cname, connection);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                lvi.SubItems.Add(reader.GetString("telephone"));
                lvi.SubItems.Add(reader.GetString("web"));
            }
            connection.Close();
        }
        public void connectsql_psu()
        {
            MySqlConnection connection = new MySqlConnection(serverdata);
            string cname = "SELECT brand FROM `psu` WHERE P_model='" + selectname_psu + "'";
            connection.Open();
            MySqlCommand command = new MySqlCommand(cname, connection);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                lvi.SubItems.Add(reader.GetString("brand"));
            }
            connection.Close();
        }
        public void connectsql_a_pname()
        {
            MySqlConnection connection = new MySqlConnection(serverdata);
            string cname = "SELECT Agent_name FROM `psu`,`agent` WHERE psu.brand=agent.brand AND P_model='" + selectname_psu + "'";
            connection.Open();
            MySqlCommand command = new MySqlCommand(cname, connection);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                lvi.SubItems.Add(reader.GetString("Agent_name"));
            }
            connection.Close();
        }
        public void connectsql_pw_pname()
        {
            MySqlConnection connection = new MySqlConnection(serverdata);
            string cname = "SELECT telephone,web FROM  (`psu`NATURAL JOIN `agent` )NATURAL JOIN `company`  WHERE agent.Agent_name=company.Agent_name AND P_model='" + selectname_psu + "'";
            connection.Open();
            MySqlCommand command = new MySqlCommand(cname, connection);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                lvi.SubItems.Add(reader.GetString("telephone"));
                lvi.SubItems.Add(reader.GetString("web"));
            }
            connection.Close();
        }
        public void connectsql_case()
        {
            MySqlConnection connection = new MySqlConnection(serverdata);
            string cname = "SELECT brand FROM `c_case` WHERE Ca_model='" + selectname_case + "'";
            connection.Open();
            MySqlCommand command = new MySqlCommand(cname, connection);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                lvi.SubItems.Add(reader.GetString("brand"));
            }
            connection.Close();
        }
        public void connectsql_a_caname()
        {
            MySqlConnection connection = new MySqlConnection(serverdata);
            string cname = "SELECT Agent_name FROM `c_case`,`agent` WHERE c_case.brand=agent.brand AND Ca_model='" + selectname_case + "'";
            connection.Open();
            MySqlCommand command = new MySqlCommand(cname, connection);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                lvi.SubItems.Add(reader.GetString("Agent_name"));
            }
            connection.Close();
        }
        public void connectsql_pw_caname()
        {
            MySqlConnection connection = new MySqlConnection(serverdata);
            string cname = "SELECT telephone,web FROM  (`c_case`NATURAL JOIN `agent` )NATURAL JOIN `company`  WHERE agent.Agent_name=company.Agent_name AND Ca_model='" + selectname_case + "'";
            connection.Open();
            MySqlCommand command = new MySqlCommand(cname, connection);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                lvi.SubItems.Add(reader.GetString("telephone"));
                lvi.SubItems.Add(reader.GetString("web"));
            }
            connection.Close();
        }
        public void connectsql_HDD()
        {
            MySqlConnection connection = new MySqlConnection(serverdata);
            string cname = "SELECT brand FROM `hdd` WHERE HDD_model='" + selectname_hdd + "'";
            connection.Open();
            MySqlCommand command = new MySqlCommand(cname, connection);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                lvi.SubItems.Add(reader.GetString("brand"));
            }
            connection.Close();
        }
        public void connectsql_a_hname()
        {
            MySqlConnection connection = new MySqlConnection(serverdata);
            string cname = "SELECT Agent_name FROM `hdd`,`agent` WHERE hdd.brand=agent.brand AND HDD_model='" + selectname_hdd + "'";
            connection.Open();
            MySqlCommand command = new MySqlCommand(cname, connection);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                lvi.SubItems.Add(reader.GetString("Agent_name"));
            }
            connection.Close();
        }
        public void connectsql_pw_hname()
        {
            MySqlConnection connection = new MySqlConnection(serverdata);
            string cname = "SELECT telephone,web FROM  (`hdd`NATURAL JOIN `agent` )NATURAL JOIN `company`  WHERE agent.Agent_name=company.Agent_name AND HDD_model='" + selectname_hdd + "'";
            connection.Open();
            MySqlCommand command = new MySqlCommand(cname, connection);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                lvi.SubItems.Add(reader.GetString("telephone"));
                lvi.SubItems.Add(reader.GetString("web"));
            }
            connection.Close();
        }
        public void connectsql_SSD()
        {
            MySqlConnection connection = new MySqlConnection(serverdata);
            string cname = "SELECT brand FROM `ssd` WHERE SSD_model='" + selectname_ssd + "'";
            connection.Open();
            MySqlCommand command = new MySqlCommand(cname, connection);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                lvi.SubItems.Add(reader.GetString("brand"));
            }
            connection.Close();
        }
        public void connectsql_a_sname()
        {
            MySqlConnection connection = new MySqlConnection(serverdata);
            string cname = "SELECT Agent_name FROM `ssd`,`agent` WHERE ssd.brand=agent.brand AND SSD_model='" + selectname_ssd + "'";
            connection.Open();
            MySqlCommand command = new MySqlCommand(cname, connection);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                lvi.SubItems.Add(reader.GetString("Agent_name"));
            }
            connection.Close();
        }
        public void connectsql_pw_sname()
        {
            MySqlConnection connection = new MySqlConnection(serverdata);
            string cname = "SELECT telephone,web FROM  (`ssd`NATURAL JOIN `agent` )NATURAL JOIN `company`  WHERE agent.Agent_name=company.Agent_name AND SSD_model='" + selectname_ssd + "'";
            connection.Open();
            MySqlCommand command = new MySqlCommand(cname, connection);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                lvi.SubItems.Add(reader.GetString("telephone"));
                lvi.SubItems.Add(reader.GetString("web"));
            }
            connection.Close();
        }
        public void connectsql_RAM()
        {
            MySqlConnection connection = new MySqlConnection(serverdata);
            string cname = "SELECT brand FROM `ram` WHERE R_model='" + selectname_ram + "'";
            connection.Open();
            MySqlCommand command = new MySqlCommand(cname, connection);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                lvi.SubItems.Add(reader.GetString("brand"));
            }
            connection.Close();
        }
        public void connectsql_a_rname()
        {
            MySqlConnection connection = new MySqlConnection(serverdata);
            string cname = "SELECT Agent_name FROM `ram`,`agent` WHERE ram.brand=agent.brand AND R_model='" + selectname_ram + "'";
            connection.Open();
            MySqlCommand command = new MySqlCommand(cname, connection);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                lvi.SubItems.Add(reader.GetString("Agent_name"));
            }
            connection.Close();
        }
        public void connectsql_pw_rname()
        {
            MySqlConnection connection = new MySqlConnection(serverdata);
            string cname = "SELECT telephone,web FROM  (`ram`NATURAL JOIN `agent` )NATURAL JOIN `company`  WHERE agent.Agent_name=company.Agent_name AND R_model='" + selectname_ram + "'";
            connection.Open();
            MySqlCommand command = new MySqlCommand(cname, connection);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                lvi.SubItems.Add(reader.GetString("telephone"));
                lvi.SubItems.Add(reader.GetString("web"));
            }
            connection.Close();
        }
        private void RMA_Load(object sender, EventArgs e)
        {
            ImageList imgList = new ImageList();
            imgList.ImageSize = new Size(1, 30);
            listView_agent.SmallImageList = imgList;
            listView_agent.GridLines = true;
            listView_agent.FullRowSelect = true;

            listView_agent.View = View.Details;
            listView_agent.Scrollable = true;
            listView_agent.MultiSelect = false;

            listView_agent.Columns.Add("零件", 70, HorizontalAlignment.Center);
            listView_agent.Columns.Add("品名", 270, HorizontalAlignment.Center);
            listView_agent.Columns.Add("數量", 50, HorizontalAlignment.Center);
            listView_agent.Columns.Add("廠牌", 90, HorizontalAlignment.Center);
            listView_agent.Columns.Add("代理商名字", 100, HorizontalAlignment.Center);
            listView_agent.Columns.Add("電話", 100, HorizontalAlignment.Center);
            listView_agent.Columns.Add("網站", 300, HorizontalAlignment.Center);
        }
        public void show_cpu_data(string datac, string num)
        {
            if (datac != null)
                selected[0] = true;
            selectname_cpu = datac;
            lvi.SubItems.Clear();
            lvi.SubItems[0].Text = "CPU";
            lvi.SubItems.Add(datac);
            lvi.SubItems.Add(num);
            connectsql_cpu();
            connectsql_a_cname();
            connectsql_pw_cname();
            listView_agent.Items.Add(lvi);
        }

        public void show_mb_data(string datam, string num)
        {
            if (datam != null)
                selected[1] = true;
            selectname_mb = datam;
            lvi = new ListViewItem();
            lvi.SubItems[0].Text = "MB";
            lvi.SubItems.Add(datam);
            lvi.SubItems.Add(num);
            connectsql_mb();
            connectsql_a_mname();
            connectsql_pw_mname();
            listView_agent.Items.Add(lvi);
        }
        public void show_co_data(string datac, string num)
        {
            if (datac != null)
                selected[2] = true;
            selectname_co = datac;
            lvi = new ListViewItem();
            lvi.SubItems[0].Text = "Cooler";
            lvi.SubItems.Add(datac);
            lvi.SubItems.Add(num);
            connectsql_co();
            connectsql_a_coname();
            connectsql_pw_coname();
            listView_agent.Items.Add(lvi);
        }
        public void show_gpu_data(string datag, string num)
        {
            if (datag != null)
                selected[3] = true;
            selectname_gpu = datag;
            lvi = new ListViewItem();
            lvi.SubItems[0].Text = "GPU";
            lvi.SubItems.Add(datag);
            lvi.SubItems.Add(num);
            connectsql_gpu();
            connectsql_a_gname();
            connectsql_pw_gname();
            listView_agent.Items.Add(lvi);
        }
        public void show_psu_data(string datap, string num)
        {
            if (datap != null)
                selected[4] = true;
            selectname_psu = datap;
            lvi = new ListViewItem();
            lvi.SubItems[0].Text = "PSU";
            lvi.SubItems.Add(datap);
            lvi.SubItems.Add(num);
            connectsql_psu();
            connectsql_a_pname();
            connectsql_pw_pname();
            listView_agent.Items.Add(lvi);
        }
        public void show_case_data(string dataca, string num)
        {
            if (dataca != null)
                selected[5] = true;
            selectname_case = dataca;
            lvi = new ListViewItem();
            lvi.SubItems[0].Text = "Case";
            lvi.SubItems.Add(dataca);
            lvi.SubItems.Add(num);
            connectsql_case();
            connectsql_a_caname();
            connectsql_pw_caname();
            listView_agent.Items.Add(lvi);
        }
        public void show_HDD_data(string datah, string num)
        {
            if (datah != null)
                selected[6] = true;
            selectname_hdd = datah;
            lvi = new ListViewItem();
            lvi.SubItems[0].Text = "HDD";
            lvi.SubItems.Add(datah);
            lvi.SubItems.Add(num);
            connectsql_HDD();
            connectsql_a_hname();
            connectsql_pw_hname();
            listView_agent.Items.Add(lvi);
        }
        public void show_SSD_data(string datas, string num)
        {
            if (datas != null)
                selected[7] = true;
            selectname_ssd = datas;
            lvi = new ListViewItem();
            lvi.SubItems[0].Text = "SSD";
            lvi.SubItems.Add(datas);
            lvi.SubItems.Add(num);
            connectsql_SSD();
            connectsql_a_sname();
            connectsql_pw_sname();
            listView_agent.Items.Add(lvi);
        }
        public void show_ram_data(string datar, string num)
        {
            if (datar != null)
                selected[8] = true;
            selectname_ram = datar;
            lvi = new ListViewItem();
            lvi.SubItems[0].Text = "RAM";
            lvi.SubItems.Add(datar);
            lvi.SubItems.Add(num);
            connectsql_RAM();
            connectsql_a_rname();
            connectsql_pw_rname();
            listView_agent.Items.Add(lvi);
        }
        
        public void show_price(string totalprice)
        {
            lvi = new ListViewItem();
            lvi.SubItems[0].Text = "總價";
            lvi.SubItems.Add(totalprice);
            listView_agent.Items.Add(lvi);
        }

            private void listView_agent_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button_WOC2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_WOC1_Click(object sender, EventArgs e)
        {
            OperateExcel(listView_agent, "材料清單");
        }

        public void OperateExcel(ListView list, string text)
        {
            Excel.Application ss = new Excel.Application();
            ss.Application.Workbooks.Add(true);
            ss.Visible = true;
            ss.Cells[1, 4] = text;
            for (int x = 1; x <= list.Columns.Count; x++)
            {
                ss.Rows.Cells[2, x] = list.Columns[x - 1].Text;
            }
            for (int i = 3; i <= list.Items.Count + 2; i++)
            {
                for (int j = 1; j <= list.Columns.Count; j++)
                {
                    try
                    {
                        ss.Rows.Cells[i, j] = list.Items[i - 3].SubItems[j - 1].Text.ToString();
                    }
                    catch
                    {

                    }
                }
            }
        }

        private void button_WOC3_Click(object sender, EventArgs e)
        {
            this.Hide();
            StartPage f = new StartPage();
            f.Show();
        }
    }
}
