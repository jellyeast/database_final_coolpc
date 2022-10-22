
namespace databasefinal
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.comboBox_using = new System.Windows.Forms.ComboBox();
            this.comboBox_prefer = new System.Windows.Forms.ComboBox();
            this.comboBox_cpu = new System.Windows.Forms.ComboBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.comboBox_mb = new System.Windows.Forms.ComboBox();
            this.comboBox_cooler = new System.Windows.Forms.ComboBox();
            this.comboBox_ram = new System.Windows.Forms.ComboBox();
            this.comboBox_gpu = new System.Windows.Forms.ComboBox();
            this.comboBox_case = new System.Windows.Forms.ComboBox();
            this.comboBox_HDD = new System.Windows.Forms.ComboBox();
            this.comboBox_SSD = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBox_psu = new System.Windows.Forms.ComboBox();
            this.cpuPriceTB = new System.Windows.Forms.TextBox();
            this.mbPriceTB = new System.Windows.Forms.TextBox();
            this.coolerPriceTB = new System.Windows.Forms.TextBox();
            this.gpuPriceTB = new System.Windows.Forms.TextBox();
            this.psuPriceTB = new System.Windows.Forms.TextBox();
            this.casePriceTB = new System.Windows.Forms.TextBox();
            this.HDDPriceTB = new System.Windows.Forms.TextBox();
            this.SSDPriceTB = new System.Windows.Forms.TextBox();
            this.ramPriceTB = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.ramSP = new System.Windows.Forms.TextBox();
            this.SSDSP = new System.Windows.Forms.TextBox();
            this.HDDSP = new System.Windows.Forms.TextBox();
            this.caseSP = new System.Windows.Forms.TextBox();
            this.psuSP = new System.Windows.Forms.TextBox();
            this.gpuSP = new System.Windows.Forms.TextBox();
            this.coolerSP = new System.Windows.Forms.TextBox();
            this.mbSP = new System.Windows.Forms.TextBox();
            this.cpuSP = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cpuNum = new System.Windows.Forms.ComboBox();
            this.mbNum = new System.Windows.Forms.ComboBox();
            this.coolerNum = new System.Windows.Forms.ComboBox();
            this.gpuNum = new System.Windows.Forms.ComboBox();
            this.psuNum = new System.Windows.Forms.ComboBox();
            this.caseNum = new System.Windows.Forms.ComboBox();
            this.HDDNum = new System.Windows.Forms.ComboBox();
            this.SSDNum = new System.Windows.Forms.ComboBox();
            this.ramNum = new System.Windows.Forms.ComboBox();
            this.button_WOC2 = new ePOSOne.btnProduct.Button_WOC();
            this.button_WOC1 = new ePOSOne.btnProduct.Button_WOC();
            this.SuspendLayout();
            // 
            // comboBox_using
            // 
            this.comboBox_using.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_using.FormattingEnabled = true;
            this.comboBox_using.Location = new System.Drawing.Point(341, 71);
            this.comboBox_using.Name = "comboBox_using";
            this.comboBox_using.Size = new System.Drawing.Size(155, 20);
            this.comboBox_using.TabIndex = 0;
            this.comboBox_using.SelectedIndexChanged += new System.EventHandler(this.comboBox_using_SelectedIndexChanged);
            // 
            // comboBox_prefer
            // 
            this.comboBox_prefer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_prefer.FormattingEnabled = true;
            this.comboBox_prefer.Location = new System.Drawing.Point(690, 71);
            this.comboBox_prefer.Name = "comboBox_prefer";
            this.comboBox_prefer.Size = new System.Drawing.Size(155, 20);
            this.comboBox_prefer.TabIndex = 1;
            this.comboBox_prefer.SelectedIndexChanged += new System.EventHandler(this.comboBox_prefer_SelectedIndexChanged);
            // 
            // comboBox_cpu
            // 
            this.comboBox_cpu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_cpu.FormattingEnabled = true;
            this.comboBox_cpu.Location = new System.Drawing.Point(223, 181);
            this.comboBox_cpu.Margin = new System.Windows.Forms.Padding(10);
            this.comboBox_cpu.Name = "comboBox_cpu";
            this.comboBox_cpu.Size = new System.Drawing.Size(463, 20);
            this.comboBox_cpu.TabIndex = 2;
            this.comboBox_cpu.SelectedIndexChanged += new System.EventHandler(this.comboBox_cpu_SelectedIndexChanged);
            // 
            // comboBox_mb
            // 
            this.comboBox_mb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_mb.FormattingEnabled = true;
            this.comboBox_mb.Location = new System.Drawing.Point(223, 221);
            this.comboBox_mb.Margin = new System.Windows.Forms.Padding(10);
            this.comboBox_mb.Name = "comboBox_mb";
            this.comboBox_mb.Size = new System.Drawing.Size(463, 20);
            this.comboBox_mb.TabIndex = 3;
            this.comboBox_mb.SelectedIndexChanged += new System.EventHandler(this.comboBox_mb_SelectedIndexChanged);
            // 
            // comboBox_cooler
            // 
            this.comboBox_cooler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_cooler.FormattingEnabled = true;
            this.comboBox_cooler.Location = new System.Drawing.Point(223, 261);
            this.comboBox_cooler.Margin = new System.Windows.Forms.Padding(10);
            this.comboBox_cooler.Name = "comboBox_cooler";
            this.comboBox_cooler.Size = new System.Drawing.Size(463, 20);
            this.comboBox_cooler.TabIndex = 4;
            this.comboBox_cooler.SelectedIndexChanged += new System.EventHandler(this.comboBox_cooler_SelectedIndexChanged);
            // 
            // comboBox_ram
            // 
            this.comboBox_ram.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_ram.FormattingEnabled = true;
            this.comboBox_ram.Location = new System.Drawing.Point(223, 501);
            this.comboBox_ram.Margin = new System.Windows.Forms.Padding(10);
            this.comboBox_ram.Name = "comboBox_ram";
            this.comboBox_ram.Size = new System.Drawing.Size(463, 20);
            this.comboBox_ram.TabIndex = 5;
            this.comboBox_ram.SelectedIndexChanged += new System.EventHandler(this.comboBox_ram_SelectedIndexChanged);
            // 
            // comboBox_gpu
            // 
            this.comboBox_gpu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_gpu.FormattingEnabled = true;
            this.comboBox_gpu.Location = new System.Drawing.Point(223, 301);
            this.comboBox_gpu.Margin = new System.Windows.Forms.Padding(10);
            this.comboBox_gpu.Name = "comboBox_gpu";
            this.comboBox_gpu.Size = new System.Drawing.Size(463, 20);
            this.comboBox_gpu.TabIndex = 6;
            this.comboBox_gpu.SelectedIndexChanged += new System.EventHandler(this.comboBox_gpu_SelectedIndexChanged);
            // 
            // comboBox_case
            // 
            this.comboBox_case.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_case.FormattingEnabled = true;
            this.comboBox_case.Location = new System.Drawing.Point(223, 381);
            this.comboBox_case.Margin = new System.Windows.Forms.Padding(10);
            this.comboBox_case.Name = "comboBox_case";
            this.comboBox_case.Size = new System.Drawing.Size(463, 20);
            this.comboBox_case.TabIndex = 7;
            this.comboBox_case.SelectedIndexChanged += new System.EventHandler(this.comboBox_case_SelectedIndexChanged);
            // 
            // comboBox_HDD
            // 
            this.comboBox_HDD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_HDD.FormattingEnabled = true;
            this.comboBox_HDD.Location = new System.Drawing.Point(223, 421);
            this.comboBox_HDD.Margin = new System.Windows.Forms.Padding(10);
            this.comboBox_HDD.Name = "comboBox_HDD";
            this.comboBox_HDD.Size = new System.Drawing.Size(463, 20);
            this.comboBox_HDD.TabIndex = 8;
            this.comboBox_HDD.SelectedIndexChanged += new System.EventHandler(this.comboBox_HDD_SelectedIndexChanged);
            // 
            // comboBox_SSD
            // 
            this.comboBox_SSD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_SSD.FormattingEnabled = true;
            this.comboBox_SSD.Location = new System.Drawing.Point(223, 461);
            this.comboBox_SSD.Margin = new System.Windows.Forms.Padding(10);
            this.comboBox_SSD.Name = "comboBox_SSD";
            this.comboBox_SSD.Size = new System.Drawing.Size(463, 20);
            this.comboBox_SSD.TabIndex = 9;
            this.comboBox_SSD.SelectedIndexChanged += new System.EventHandler(this.comboBox_SSD_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.label1.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(284, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 19);
            this.label1.TabIndex = 10;
            this.label1.Text = "用途";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.label2.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(157, 382);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 19);
            this.label2.TabIndex = 11;
            this.label2.Text = "case";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.label3.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(168, 302);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 19);
            this.label3.TabIndex = 12;
            this.label3.Text = "gpu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.label4.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(135, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 19);
            this.label4.TabIndex = 13;
            this.label4.Text = "cooler";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.label5.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(179, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 19);
            this.label5.TabIndex = 14;
            this.label5.Text = "mb";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.label6.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(168, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 19);
            this.label6.TabIndex = 15;
            this.label6.Text = "cpu";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.label7.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(591, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 19);
            this.label7.TabIndex = 16;
            this.label7.Text = "偏好廠牌";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.label8.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(168, 342);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 19);
            this.label8.TabIndex = 17;
            this.label8.Text = "psu";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.label9.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(168, 502);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 19);
            this.label9.TabIndex = 18;
            this.label9.Text = "ram";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.label10.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(168, 462);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 19);
            this.label10.TabIndex = 19;
            this.label10.Text = "SSD";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.label11.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(168, 422);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 19);
            this.label11.TabIndex = 20;
            this.label11.Text = "HDD";
            // 
            // comboBox_psu
            // 
            this.comboBox_psu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_psu.FormattingEnabled = true;
            this.comboBox_psu.Location = new System.Drawing.Point(223, 341);
            this.comboBox_psu.Margin = new System.Windows.Forms.Padding(10);
            this.comboBox_psu.Name = "comboBox_psu";
            this.comboBox_psu.Size = new System.Drawing.Size(463, 20);
            this.comboBox_psu.TabIndex = 21;
            this.comboBox_psu.SelectedIndexChanged += new System.EventHandler(this.comboBox_psu_SelectedIndexChanged);
            // 
            // cpuPriceTB
            // 
            this.cpuPriceTB.Font = new System.Drawing.Font("新細明體", 8F);
            this.cpuPriceTB.Location = new System.Drawing.Point(909, 182);
            this.cpuPriceTB.Name = "cpuPriceTB";
            this.cpuPriceTB.ReadOnly = true;
            this.cpuPriceTB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cpuPriceTB.Size = new System.Drawing.Size(66, 20);
            this.cpuPriceTB.TabIndex = 24;
            // 
            // mbPriceTB
            // 
            this.mbPriceTB.Font = new System.Drawing.Font("新細明體", 8F);
            this.mbPriceTB.Location = new System.Drawing.Point(909, 222);
            this.mbPriceTB.Name = "mbPriceTB";
            this.mbPriceTB.ReadOnly = true;
            this.mbPriceTB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mbPriceTB.Size = new System.Drawing.Size(66, 20);
            this.mbPriceTB.TabIndex = 25;
            // 
            // coolerPriceTB
            // 
            this.coolerPriceTB.Font = new System.Drawing.Font("新細明體", 8F);
            this.coolerPriceTB.Location = new System.Drawing.Point(909, 261);
            this.coolerPriceTB.Name = "coolerPriceTB";
            this.coolerPriceTB.ReadOnly = true;
            this.coolerPriceTB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.coolerPriceTB.Size = new System.Drawing.Size(66, 20);
            this.coolerPriceTB.TabIndex = 26;
            // 
            // gpuPriceTB
            // 
            this.gpuPriceTB.Font = new System.Drawing.Font("新細明體", 8F);
            this.gpuPriceTB.Location = new System.Drawing.Point(909, 301);
            this.gpuPriceTB.Name = "gpuPriceTB";
            this.gpuPriceTB.ReadOnly = true;
            this.gpuPriceTB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gpuPriceTB.Size = new System.Drawing.Size(66, 20);
            this.gpuPriceTB.TabIndex = 27;
            // 
            // psuPriceTB
            // 
            this.psuPriceTB.Font = new System.Drawing.Font("新細明體", 8F);
            this.psuPriceTB.Location = new System.Drawing.Point(909, 341);
            this.psuPriceTB.Name = "psuPriceTB";
            this.psuPriceTB.ReadOnly = true;
            this.psuPriceTB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.psuPriceTB.Size = new System.Drawing.Size(66, 20);
            this.psuPriceTB.TabIndex = 28;
            // 
            // casePriceTB
            // 
            this.casePriceTB.Font = new System.Drawing.Font("新細明體", 8F);
            this.casePriceTB.Location = new System.Drawing.Point(909, 381);
            this.casePriceTB.Name = "casePriceTB";
            this.casePriceTB.ReadOnly = true;
            this.casePriceTB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.casePriceTB.Size = new System.Drawing.Size(66, 20);
            this.casePriceTB.TabIndex = 29;
            // 
            // HDDPriceTB
            // 
            this.HDDPriceTB.Font = new System.Drawing.Font("新細明體", 8F);
            this.HDDPriceTB.Location = new System.Drawing.Point(909, 421);
            this.HDDPriceTB.Name = "HDDPriceTB";
            this.HDDPriceTB.ReadOnly = true;
            this.HDDPriceTB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.HDDPriceTB.Size = new System.Drawing.Size(66, 20);
            this.HDDPriceTB.TabIndex = 30;
            // 
            // SSDPriceTB
            // 
            this.SSDPriceTB.Font = new System.Drawing.Font("新細明體", 8F);
            this.SSDPriceTB.Location = new System.Drawing.Point(909, 461);
            this.SSDPriceTB.Name = "SSDPriceTB";
            this.SSDPriceTB.ReadOnly = true;
            this.SSDPriceTB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.SSDPriceTB.Size = new System.Drawing.Size(66, 20);
            this.SSDPriceTB.TabIndex = 31;
            // 
            // ramPriceTB
            // 
            this.ramPriceTB.Font = new System.Drawing.Font("新細明體", 8F);
            this.ramPriceTB.Location = new System.Drawing.Point(909, 501);
            this.ramPriceTB.Name = "ramPriceTB";
            this.ramPriceTB.ReadOnly = true;
            this.ramPriceTB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ramPriceTB.Size = new System.Drawing.Size(66, 20);
            this.ramPriceTB.TabIndex = 32;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.label12.Font = new System.Drawing.Font("標楷體", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(904, 138);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 29);
            this.label12.TabIndex = 33;
            this.label12.Text = "總價";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.label13.Font = new System.Drawing.Font("標楷體", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(806, 138);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(75, 29);
            this.label13.TabIndex = 43;
            this.label13.Text = "單價";
            // 
            // ramSP
            // 
            this.ramSP.Font = new System.Drawing.Font("新細明體", 8F);
            this.ramSP.Location = new System.Drawing.Point(811, 501);
            this.ramSP.Name = "ramSP";
            this.ramSP.ReadOnly = true;
            this.ramSP.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ramSP.Size = new System.Drawing.Size(66, 20);
            this.ramSP.TabIndex = 42;
            // 
            // SSDSP
            // 
            this.SSDSP.Font = new System.Drawing.Font("新細明體", 8F);
            this.SSDSP.Location = new System.Drawing.Point(811, 461);
            this.SSDSP.Name = "SSDSP";
            this.SSDSP.ReadOnly = true;
            this.SSDSP.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.SSDSP.Size = new System.Drawing.Size(66, 20);
            this.SSDSP.TabIndex = 41;
            // 
            // HDDSP
            // 
            this.HDDSP.Font = new System.Drawing.Font("新細明體", 8F);
            this.HDDSP.Location = new System.Drawing.Point(811, 421);
            this.HDDSP.Name = "HDDSP";
            this.HDDSP.ReadOnly = true;
            this.HDDSP.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.HDDSP.Size = new System.Drawing.Size(66, 20);
            this.HDDSP.TabIndex = 40;
            // 
            // caseSP
            // 
            this.caseSP.Font = new System.Drawing.Font("新細明體", 8F);
            this.caseSP.Location = new System.Drawing.Point(811, 381);
            this.caseSP.Name = "caseSP";
            this.caseSP.ReadOnly = true;
            this.caseSP.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.caseSP.Size = new System.Drawing.Size(66, 20);
            this.caseSP.TabIndex = 39;
            // 
            // psuSP
            // 
            this.psuSP.Font = new System.Drawing.Font("新細明體", 8F);
            this.psuSP.Location = new System.Drawing.Point(811, 341);
            this.psuSP.Name = "psuSP";
            this.psuSP.ReadOnly = true;
            this.psuSP.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.psuSP.Size = new System.Drawing.Size(66, 20);
            this.psuSP.TabIndex = 38;
            // 
            // gpuSP
            // 
            this.gpuSP.Font = new System.Drawing.Font("新細明體", 8F);
            this.gpuSP.Location = new System.Drawing.Point(811, 301);
            this.gpuSP.Name = "gpuSP";
            this.gpuSP.ReadOnly = true;
            this.gpuSP.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gpuSP.Size = new System.Drawing.Size(66, 20);
            this.gpuSP.TabIndex = 37;
            // 
            // coolerSP
            // 
            this.coolerSP.Font = new System.Drawing.Font("新細明體", 8F);
            this.coolerSP.Location = new System.Drawing.Point(811, 261);
            this.coolerSP.Name = "coolerSP";
            this.coolerSP.ReadOnly = true;
            this.coolerSP.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.coolerSP.Size = new System.Drawing.Size(66, 20);
            this.coolerSP.TabIndex = 36;
            // 
            // mbSP
            // 
            this.mbSP.Font = new System.Drawing.Font("新細明體", 8F);
            this.mbSP.Location = new System.Drawing.Point(811, 222);
            this.mbSP.Name = "mbSP";
            this.mbSP.ReadOnly = true;
            this.mbSP.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mbSP.Size = new System.Drawing.Size(66, 20);
            this.mbSP.TabIndex = 35;
            // 
            // cpuSP
            // 
            this.cpuSP.Font = new System.Drawing.Font("新細明體", 8F);
            this.cpuSP.Location = new System.Drawing.Point(811, 182);
            this.cpuSP.Name = "cpuSP";
            this.cpuSP.ReadOnly = true;
            this.cpuSP.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cpuSP.Size = new System.Drawing.Size(66, 20);
            this.cpuSP.TabIndex = 34;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.label14.Font = new System.Drawing.Font("標楷體", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(711, 138);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(75, 29);
            this.label14.TabIndex = 44;
            this.label14.Text = "數量";
            // 
            // cpuNum
            // 
            this.cpuNum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cpuNum.FormattingEnabled = true;
            this.cpuNum.Location = new System.Drawing.Point(716, 181);
            this.cpuNum.Name = "cpuNum";
            this.cpuNum.Size = new System.Drawing.Size(70, 20);
            this.cpuNum.TabIndex = 45;
            this.cpuNum.SelectedIndexChanged += new System.EventHandler(this.cpuNum_SelectedIndexChanged);
            // 
            // mbNum
            // 
            this.mbNum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mbNum.FormattingEnabled = true;
            this.mbNum.Location = new System.Drawing.Point(716, 221);
            this.mbNum.Name = "mbNum";
            this.mbNum.Size = new System.Drawing.Size(70, 20);
            this.mbNum.TabIndex = 46;
            this.mbNum.SelectedIndexChanged += new System.EventHandler(this.mbNum_SelectedIndexChanged);
            // 
            // coolerNum
            // 
            this.coolerNum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.coolerNum.FormattingEnabled = true;
            this.coolerNum.Location = new System.Drawing.Point(716, 261);
            this.coolerNum.Name = "coolerNum";
            this.coolerNum.Size = new System.Drawing.Size(70, 20);
            this.coolerNum.TabIndex = 47;
            this.coolerNum.SelectedIndexChanged += new System.EventHandler(this.coolerNum_SelectedIndexChanged);
            // 
            // gpuNum
            // 
            this.gpuNum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gpuNum.FormattingEnabled = true;
            this.gpuNum.Location = new System.Drawing.Point(716, 301);
            this.gpuNum.Name = "gpuNum";
            this.gpuNum.Size = new System.Drawing.Size(70, 20);
            this.gpuNum.TabIndex = 48;
            this.gpuNum.SelectedIndexChanged += new System.EventHandler(this.gpuNum_SelectedIndexChanged);
            // 
            // psuNum
            // 
            this.psuNum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.psuNum.FormattingEnabled = true;
            this.psuNum.Location = new System.Drawing.Point(716, 341);
            this.psuNum.Name = "psuNum";
            this.psuNum.Size = new System.Drawing.Size(70, 20);
            this.psuNum.TabIndex = 49;
            this.psuNum.SelectedIndexChanged += new System.EventHandler(this.psuNum_SelectedIndexChanged);
            // 
            // caseNum
            // 
            this.caseNum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.caseNum.FormattingEnabled = true;
            this.caseNum.Location = new System.Drawing.Point(716, 382);
            this.caseNum.Name = "caseNum";
            this.caseNum.Size = new System.Drawing.Size(70, 20);
            this.caseNum.TabIndex = 50;
            this.caseNum.SelectedIndexChanged += new System.EventHandler(this.caseNum_SelectedIndexChanged);
            // 
            // HDDNum
            // 
            this.HDDNum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.HDDNum.FormattingEnabled = true;
            this.HDDNum.Location = new System.Drawing.Point(716, 420);
            this.HDDNum.Name = "HDDNum";
            this.HDDNum.Size = new System.Drawing.Size(70, 20);
            this.HDDNum.TabIndex = 51;
            this.HDDNum.SelectedIndexChanged += new System.EventHandler(this.HDDNum_SelectedIndexChanged);
            // 
            // SSDNum
            // 
            this.SSDNum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SSDNum.FormattingEnabled = true;
            this.SSDNum.Location = new System.Drawing.Point(716, 460);
            this.SSDNum.Name = "SSDNum";
            this.SSDNum.Size = new System.Drawing.Size(70, 20);
            this.SSDNum.TabIndex = 52;
            this.SSDNum.SelectedIndexChanged += new System.EventHandler(this.SSDNum_SelectedIndexChanged);
            // 
            // ramNum
            // 
            this.ramNum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ramNum.FormattingEnabled = true;
            this.ramNum.Location = new System.Drawing.Point(716, 500);
            this.ramNum.Name = "ramNum";
            this.ramNum.Size = new System.Drawing.Size(70, 20);
            this.ramNum.TabIndex = 53;
            this.ramNum.SelectedIndexChanged += new System.EventHandler(this.ramNum_SelectedIndexChanged);
            // 
            // button_WOC2
            // 
            this.button_WOC2.BorderColor = System.Drawing.Color.Silver;
            this.button_WOC2.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.button_WOC2.FlatAppearance.BorderSize = 0;
            this.button_WOC2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.button_WOC2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.button_WOC2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_WOC2.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_WOC2.Location = new System.Drawing.Point(825, 587);
            this.button_WOC2.Margin = new System.Windows.Forms.Padding(30);
            this.button_WOC2.Name = "button_WOC2";
            this.button_WOC2.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.button_WOC2.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.button_WOC2.OnHoverTextColor = System.Drawing.Color.Gray;
            this.button_WOC2.Size = new System.Drawing.Size(150, 55);
            this.button_WOC2.TabIndex = 23;
            this.button_WOC2.Text = "結束";
            this.button_WOC2.TextColor = System.Drawing.Color.White;
            this.button_WOC2.UseVisualStyleBackColor = true;
            this.button_WOC2.Click += new System.EventHandler(this.button_WOC2_Click);
            // 
            // button_WOC1
            // 
            this.button_WOC1.BorderColor = System.Drawing.Color.Silver;
            this.button_WOC1.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.button_WOC1.FlatAppearance.BorderSize = 0;
            this.button_WOC1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.button_WOC1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.button_WOC1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_WOC1.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_WOC1.Location = new System.Drawing.Point(995, 587);
            this.button_WOC1.Margin = new System.Windows.Forms.Padding(30);
            this.button_WOC1.Name = "button_WOC1";
            this.button_WOC1.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.button_WOC1.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.button_WOC1.OnHoverTextColor = System.Drawing.Color.Gray;
            this.button_WOC1.Size = new System.Drawing.Size(150, 55);
            this.button_WOC1.TabIndex = 22;
            this.button_WOC1.Text = "下一步";
            this.button_WOC1.TextColor = System.Drawing.Color.White;
            this.button_WOC1.UseVisualStyleBackColor = true;
            this.button_WOC1.Click += new System.EventHandler(this.button_WOC1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(1184, 681);
            this.Controls.Add(this.ramNum);
            this.Controls.Add(this.SSDNum);
            this.Controls.Add(this.HDDNum);
            this.Controls.Add(this.caseNum);
            this.Controls.Add(this.psuNum);
            this.Controls.Add(this.gpuNum);
            this.Controls.Add(this.coolerNum);
            this.Controls.Add(this.mbNum);
            this.Controls.Add(this.cpuNum);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.ramSP);
            this.Controls.Add(this.SSDSP);
            this.Controls.Add(this.HDDSP);
            this.Controls.Add(this.caseSP);
            this.Controls.Add(this.psuSP);
            this.Controls.Add(this.gpuSP);
            this.Controls.Add(this.coolerSP);
            this.Controls.Add(this.mbSP);
            this.Controls.Add(this.cpuSP);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.ramPriceTB);
            this.Controls.Add(this.SSDPriceTB);
            this.Controls.Add(this.HDDPriceTB);
            this.Controls.Add(this.casePriceTB);
            this.Controls.Add(this.psuPriceTB);
            this.Controls.Add(this.gpuPriceTB);
            this.Controls.Add(this.coolerPriceTB);
            this.Controls.Add(this.mbPriceTB);
            this.Controls.Add(this.cpuPriceTB);
            this.Controls.Add(this.button_WOC2);
            this.Controls.Add(this.button_WOC1);
            this.Controls.Add(this.comboBox_psu);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_SSD);
            this.Controls.Add(this.comboBox_HDD);
            this.Controls.Add(this.comboBox_case);
            this.Controls.Add(this.comboBox_gpu);
            this.Controls.Add(this.comboBox_ram);
            this.Controls.Add(this.comboBox_cooler);
            this.Controls.Add(this.comboBox_mb);
            this.Controls.Add(this.comboBox_cpu);
            this.Controls.Add(this.comboBox_prefer);
            this.Controls.Add(this.comboBox_using);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_using;
        private System.Windows.Forms.ComboBox comboBox_prefer;
        private System.Windows.Forms.ComboBox comboBox_cpu;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ComboBox comboBox_mb;
        private System.Windows.Forms.ComboBox comboBox_cooler;
        private System.Windows.Forms.ComboBox comboBox_ram;
        private System.Windows.Forms.ComboBox comboBox_gpu;
        private System.Windows.Forms.ComboBox comboBox_case;
        private System.Windows.Forms.ComboBox comboBox_HDD;
        private System.Windows.Forms.ComboBox comboBox_SSD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBox_psu;
        private ePOSOne.btnProduct.Button_WOC button_WOC1;
        private ePOSOne.btnProduct.Button_WOC button_WOC2;
        private System.Windows.Forms.TextBox cpuPriceTB;
        private System.Windows.Forms.TextBox mbPriceTB;
        private System.Windows.Forms.TextBox coolerPriceTB;
        private System.Windows.Forms.TextBox gpuPriceTB;
        private System.Windows.Forms.TextBox psuPriceTB;
        private System.Windows.Forms.TextBox casePriceTB;
        private System.Windows.Forms.TextBox HDDPriceTB;
        private System.Windows.Forms.TextBox SSDPriceTB;
        private System.Windows.Forms.TextBox ramPriceTB;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox ramSP;
        private System.Windows.Forms.TextBox SSDSP;
        private System.Windows.Forms.TextBox HDDSP;
        private System.Windows.Forms.TextBox caseSP;
        private System.Windows.Forms.TextBox psuSP;
        private System.Windows.Forms.TextBox gpuSP;
        private System.Windows.Forms.TextBox coolerSP;
        private System.Windows.Forms.TextBox mbSP;
        private System.Windows.Forms.TextBox cpuSP;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cpuNum;
        private System.Windows.Forms.ComboBox mbNum;
        private System.Windows.Forms.ComboBox coolerNum;
        private System.Windows.Forms.ComboBox gpuNum;
        private System.Windows.Forms.ComboBox psuNum;
        private System.Windows.Forms.ComboBox caseNum;
        private System.Windows.Forms.ComboBox HDDNum;
        private System.Windows.Forms.ComboBox SSDNum;
        private System.Windows.Forms.ComboBox ramNum;
    }
}

