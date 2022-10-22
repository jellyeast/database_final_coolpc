using databasefinal;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
namespace sql_demo
{
    public partial class Form2 : Form
    {
        public Form2()
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

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button_WOC1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        

        private void Form2_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                currentXPosition = 0; //設定初始狀態
                currentYPosition = 0;
                beginMove = false;
            }
        }

        private void Form2_MouseMove(object sender, MouseEventArgs e)
        {
            if (beginMove)
            {
                this.Left += MousePosition.X - currentXPosition;//根據滑鼠x座標確定窗體的左邊座標x
                this.Top += MousePosition.Y - currentYPosition;//根據滑鼠的y座標窗體的頂部，即Y座標
                currentXPosition = MousePosition.X;
                currentYPosition = MousePosition.Y;
            }
        }

        private void Form2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                beginMove = true;
                currentXPosition = MousePosition.X;//滑鼠的x座標為當前窗體左上角x座標
                currentYPosition = MousePosition.Y;//滑鼠的y座標為當前窗體左上角y座標
            }
        }

        public void show_data(string datacpu, string datamb, string datacooler, string datagpu, string datacase, string dataHDD, string dataSSD, string dataram, string datapsu, string datacpuNum, string datambNum, string datacoolerNum, string datagpuNum, string datacaseNum, string dataHDDNum, string dataSSDNum, string dataramNum, string datapsuNum, string dataTotal)
        {
            cpuInfo.Text = datacpu;
            mbInfo.Text = datamb;
            coolerInfo.Text = datacooler;
            gpuInfo.Text = datagpu;
            psuInfo.Text = datapsu;
            caseInfo.Text = datacase;
            HDDInfo.Text = dataHDD;
            SSDInfo.Text = dataSSD;
            ramInfo.Text = dataram;

            cpuBuyNum.Text = datacpuNum;
            mbBuyNum.Text = datambNum;
            coolerBuyNum.Text = datacoolerNum;
            gpuBuyNum.Text = datagpuNum;
            psuBuyNum.Text = datapsuNum;
            caseBuyNum.Text = datacaseNum;
            HDDBuyNum.Text = dataHDDNum;
            SSDBuyNum.Text = dataSSDNum;
            ramBuyNum.Text = dataramNum;
            totalPrice.Text = dataTotal;
        }

        private void cpuByeNum_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_WOC3_Click(object sender, EventArgs e)
        {
            
            var Result = MessageBox.Show("確認即無法返回 " ,"請確定好再點選保固頁!!!!!!", MessageBoxButtons.OKCancel);
            if (Result == DialogResult.OK)
            {
                this.Hide();
                RMA frR = new RMA();
                frR.Show();
                frR.show_cpu_data(cpuInfo.Text, cpuBuyNum.Text);
                frR.show_mb_data(mbInfo.Text, mbBuyNum.Text);
                frR.show_co_data(coolerInfo.Text, coolerBuyNum.Text);
                frR.show_gpu_data(gpuInfo.Text, gpuBuyNum.Text);
                frR.show_psu_data(psuInfo.Text, psuBuyNum.Text);
                frR.show_case_data(caseInfo.Text, caseBuyNum.Text);
                frR.show_HDD_data(HDDInfo.Text, HDDBuyNum.Text);
                frR.show_SSD_data(SSDInfo.Text, SSDBuyNum.Text);
                frR.show_ram_data(ramInfo.Text, ramBuyNum.Text);

                frR.show_price(totalPrice.Text);
            }
            
        }
    }
}
