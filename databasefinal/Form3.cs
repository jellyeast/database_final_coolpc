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
    public partial class Form3 : Form
    {
        string selectname_mb;
        string selectname_co;
        string selectname_gpu;
        string selectname_psu;
        string selectname_case;
        string selectname_ram;
        string selectname_hdd;
        string selectname_ssd;
        ListViewItem lvi = new ListViewItem();
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
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
            listView_agent.Columns.Add("廠牌", 90, HorizontalAlignment.Center);
            listView_agent.Columns.Add("代理商名字", 100, HorizontalAlignment.Center);
            listView_agent.Columns.Add("電話", 100, HorizontalAlignment.Center);
            listView_agent.Columns.Add("網站", 300, HorizontalAlignment.Center);
        }
        public void connectsql_cpu()
        {
            MySqlConnection connection = new MySqlConnection("server=localhost;uid=root;pwd=1234qwer;database=finalproject;CharSet=utf8;");
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
            MySqlConnection connection = new MySqlConnection("server=localhost;uid=root;pwd=1234qwer;database=finalproject;CharSet=utf8;");
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
            MySqlConnection connection = new MySqlConnection("server=localhost;uid=root;pwd=1234qwer;database=finalproject;CharSet=utf8;");
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
            MySqlConnection connection = new MySqlConnection("server=localhost;uid=root;pwd=1234qwer;database=finalproject;CharSet=utf8;");
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
            MySqlConnection connection = new MySqlConnection("server=localhost;uid=root;pwd=1234qwer;database=finalproject;CharSet=utf8;");
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
            MySqlConnection connection = new MySqlConnection("server=localhost;uid=root;pwd=1234qwer;database=finalproject;CharSet=utf8;");
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
            MySqlConnection connection = new MySqlConnection("server=localhost;uid=root;pwd=1234qwer;database=finalproject;CharSet=utf8;");
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
            MySqlConnection connection = new MySqlConnection("server=localhost;uid=root;pwd=1234qwer;database=finalproject;CharSet=utf8;");
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
            MySqlConnection connection = new MySqlConnection("server=localhost;uid=root;pwd=1234qwer;database=finalproject;CharSet=utf8;");
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
            MySqlConnection connection = new MySqlConnection("server=localhost;uid=root;pwd=1234qwer;database=finalproject;CharSet=utf8;");
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
            MySqlConnection connection = new MySqlConnection("server=localhost;uid=root;pwd=1234qwer;database=finalproject;CharSet=utf8;");
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
            MySqlConnection connection = new MySqlConnection("server=localhost;uid=root;pwd=1234qwer;database=finalproject;CharSet=utf8;");
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
            MySqlConnection connection = new MySqlConnection("server=localhost;uid=root;pwd=1234qwer;database=finalproject;CharSet=utf8;");
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
            MySqlConnection connection = new MySqlConnection("server=localhost;uid=root;pwd=1234qwer;database=finalproject;CharSet=utf8;");
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
            MySqlConnection connection = new MySqlConnection("server=localhost;uid=root;pwd=1234qwer;database=finalproject;CharSet=utf8;");
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
            MySqlConnection connection = new MySqlConnection("server=localhost;uid=root;pwd=1234qwer;database=finalproject;CharSet=utf8;");
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
            MySqlConnection connection = new MySqlConnection("server=localhost;uid=root;pwd=1234qwer;database=finalproject;CharSet=utf8;");
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
            MySqlConnection connection = new MySqlConnection("server=localhost;uid=root;pwd=1234qwer;database=finalproject;CharSet=utf8;");
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
            MySqlConnection connection = new MySqlConnection("server=localhost;uid=root;pwd=1234qwer;database=finalproject;CharSet=utf8;");
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
            MySqlConnection connection = new MySqlConnection("server=localhost;uid=root;pwd=1234qwer;database=finalproject;CharSet=utf8;");
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
            MySqlConnection connection = new MySqlConnection("server=localhost;uid=root;pwd=1234qwer;database=finalproject;CharSet=utf8;");
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
            MySqlConnection connection = new MySqlConnection("server=localhost;uid=root;pwd=1234qwer;database=finalproject;CharSet=utf8;");
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
            MySqlConnection connection = new MySqlConnection("server=localhost;uid=root;pwd=1234qwer;database=finalproject;CharSet=utf8;");
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
            MySqlConnection connection = new MySqlConnection("server=localhost;uid=root;pwd=1234qwer;database=finalproject;CharSet=utf8;");
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
            MySqlConnection connection = new MySqlConnection("server=localhost;uid=root;pwd=1234qwer;database=finalproject;CharSet=utf8;");
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
            MySqlConnection connection = new MySqlConnection("server=localhost;uid=root;pwd=1234qwer;database=finalproject;CharSet=utf8;");
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
            MySqlConnection connection = new MySqlConnection("server=localhost;uid=root;pwd=1234qwer;database=finalproject;CharSet=utf8;");
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
        public void show_cpu_data(string datac)
        {
            selectname_cpu = datac;
            lvi.SubItems.Clear();
            lvi.SubItems[0].Text = "CPU";
            lvi.SubItems.Add(selectname_cpu);
            connectsql_cpu();
            connectsql_a_cname();
            connectsql_pw_cname();
            listView_agent.Items.Add(lvi);
        }
        public void show_mb_data(string datam)
        {
            selectname_mb = datam;
            lvi = new ListViewItem();
            lvi.SubItems[0].Text = "MB";
            lvi.SubItems.Add(datam);
            connectsql_mb();
            connectsql_a_mname();
            connectsql_pw_mname();
            listView_agent.Items.Add(lvi);
        }
        public void show_co_data(string datac)
        {
            selectname_co = datac;
            lvi = new ListViewItem();
            lvi.SubItems[0].Text = "Cooler";
            lvi.SubItems.Add(datac);
            connectsql_co();
            connectsql_a_coname();
            connectsql_pw_coname();
            listView_agent.Items.Add(lvi);
        }
        public void show_gpu_data(string datag)
        {
            selectname_gpu = datag;
            lvi = new ListViewItem();
            lvi.SubItems[0].Text = "GPU";
            lvi.SubItems.Add(datag);
            connectsql_gpu();
            connectsql_a_gname();
            connectsql_pw_gname();
            listView_agent.Items.Add(lvi);
        }
        public void show_psu_data(string datap)
        {
            selectname_psu = datap;
            lvi = new ListViewItem();
            lvi.SubItems[0].Text = "PSU";
            lvi.SubItems.Add(datap);
            connectsql_psu();
            connectsql_a_pname();
            connectsql_pw_pname();
            listView_agent.Items.Add(lvi);
        }
        public void show_case_data(string dataca)
        {
            selectname_case = dataca;
            lvi = new ListViewItem();
            lvi.SubItems[0].Text = "Case";
            lvi.SubItems.Add(dataca);
            connectsql_case();
            connectsql_a_caname();
            connectsql_pw_caname();
            listView_agent.Items.Add(lvi);
        }
        public void show_HDD_data(string datah)
        {
            selectname_hdd = datah;
            lvi = new ListViewItem();
            lvi.SubItems[0].Text = "HDD";
            lvi.SubItems.Add(datah);
            connectsql_HDD();
            connectsql_a_hname();
            connectsql_pw_hname();
            listView_agent.Items.Add(lvi);
        }
        public void show_SSD_data(string datas)
        {
            selectname_ssd = datas;
            lvi = new ListViewItem();
            lvi.SubItems[0].Text = "SSD";
            lvi.SubItems.Add(datas);
            connectsql_SSD();
            connectsql_a_sname();
            connectsql_pw_sname();
            listView_agent.Items.Add(lvi);
        }
        public void show_ram_data(string datar)
        {
            selectname_ram = datar;
            lvi = new ListViewItem();
            lvi.SubItems[0].Text = "RAM";
            lvi.SubItems.Add(datar);
            connectsql_RAM();
            connectsql_a_rname();
            connectsql_pw_rname();
            listView_agent.Items.Add(lvi);
        }
    }
}
