
namespace sql_demo
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cpuInfo = new System.Windows.Forms.TextBox();
            this.mbInfo = new System.Windows.Forms.TextBox();
            this.coolerInfo = new System.Windows.Forms.TextBox();
            this.gpuInfo = new System.Windows.Forms.TextBox();
            this.caseInfo = new System.Windows.Forms.TextBox();
            this.HDDInfo = new System.Windows.Forms.TextBox();
            this.SSDInfo = new System.Windows.Forms.TextBox();
            this.ramInfo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.psuInfo = new System.Windows.Forms.TextBox();
            this.cpuBuyNum = new System.Windows.Forms.TextBox();
            this.psuBuyNum = new System.Windows.Forms.TextBox();
            this.ramBuyNum = new System.Windows.Forms.TextBox();
            this.SSDBuyNum = new System.Windows.Forms.TextBox();
            this.HDDBuyNum = new System.Windows.Forms.TextBox();
            this.caseBuyNum = new System.Windows.Forms.TextBox();
            this.gpuBuyNum = new System.Windows.Forms.TextBox();
            this.coolerBuyNum = new System.Windows.Forms.TextBox();
            this.mbBuyNum = new System.Windows.Forms.TextBox();
            this.totalPrice = new System.Windows.Forms.TextBox();
            this.mySqlCommand1 = new MySqlConnector.MySqlCommand();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.button_WOC3 = new ePOSOne.btnProduct.Button_WOC();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(76, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 10, 0, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 36);
            this.label1.TabIndex = 2;
            this.label1.Text = "cpu";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.label2.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.Location = new System.Drawing.Point(81, 104);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 10, 0, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 36);
            this.label2.TabIndex = 3;
            this.label2.Text = "mb";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.label3.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label3.Location = new System.Drawing.Point(43, 160);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 10, 0, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 36);
            this.label3.TabIndex = 4;
            this.label3.Text = "cooler";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.label4.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label4.Location = new System.Drawing.Point(74, 216);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 10, 0, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 36);
            this.label4.TabIndex = 5;
            this.label4.Text = "gpu";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.label6.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label6.Location = new System.Drawing.Point(55, 327);
            this.label6.Margin = new System.Windows.Forms.Padding(3, 10, 0, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 36);
            this.label6.TabIndex = 7;
            this.label6.Text = "HDD";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.label7.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label7.Location = new System.Drawing.Point(67, 383);
            this.label7.Margin = new System.Windows.Forms.Padding(3, 10, 0, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 36);
            this.label7.TabIndex = 8;
            this.label7.Text = "SSD";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.label8.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label8.Location = new System.Drawing.Point(70, 271);
            this.label8.Margin = new System.Windows.Forms.Padding(3, 10, 0, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 36);
            this.label8.TabIndex = 9;
            this.label8.Text = "case";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.label9.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label9.Location = new System.Drawing.Point(69, 439);
            this.label9.Margin = new System.Windows.Forms.Padding(3, 10, 0, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 36);
            this.label9.TabIndex = 10;
            this.label9.Text = "ram";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cpuInfo
            // 
            this.cpuInfo.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cpuInfo.Location = new System.Drawing.Point(194, 48);
            this.cpuInfo.Name = "cpuInfo";
            this.cpuInfo.ReadOnly = true;
            this.cpuInfo.Size = new System.Drawing.Size(465, 36);
            this.cpuInfo.TabIndex = 11;
            // 
            // mbInfo
            // 
            this.mbInfo.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.mbInfo.Location = new System.Drawing.Point(194, 104);
            this.mbInfo.Name = "mbInfo";
            this.mbInfo.ReadOnly = true;
            this.mbInfo.Size = new System.Drawing.Size(465, 36);
            this.mbInfo.TabIndex = 12;
            // 
            // coolerInfo
            // 
            this.coolerInfo.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.coolerInfo.Location = new System.Drawing.Point(194, 160);
            this.coolerInfo.Name = "coolerInfo";
            this.coolerInfo.ReadOnly = true;
            this.coolerInfo.Size = new System.Drawing.Size(465, 36);
            this.coolerInfo.TabIndex = 13;
            // 
            // gpuInfo
            // 
            this.gpuInfo.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gpuInfo.Location = new System.Drawing.Point(194, 216);
            this.gpuInfo.Name = "gpuInfo";
            this.gpuInfo.ReadOnly = true;
            this.gpuInfo.Size = new System.Drawing.Size(465, 36);
            this.gpuInfo.TabIndex = 14;
            // 
            // caseInfo
            // 
            this.caseInfo.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.caseInfo.Location = new System.Drawing.Point(194, 271);
            this.caseInfo.Name = "caseInfo";
            this.caseInfo.ReadOnly = true;
            this.caseInfo.Size = new System.Drawing.Size(465, 36);
            this.caseInfo.TabIndex = 16;
            // 
            // HDDInfo
            // 
            this.HDDInfo.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.HDDInfo.Location = new System.Drawing.Point(194, 327);
            this.HDDInfo.Name = "HDDInfo";
            this.HDDInfo.ReadOnly = true;
            this.HDDInfo.Size = new System.Drawing.Size(465, 36);
            this.HDDInfo.TabIndex = 17;
            // 
            // SSDInfo
            // 
            this.SSDInfo.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.SSDInfo.Location = new System.Drawing.Point(194, 383);
            this.SSDInfo.Name = "SSDInfo";
            this.SSDInfo.ReadOnly = true;
            this.SSDInfo.Size = new System.Drawing.Size(465, 36);
            this.SSDInfo.TabIndex = 18;
            // 
            // ramInfo
            // 
            this.ramInfo.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ramInfo.Location = new System.Drawing.Point(194, 441);
            this.ramInfo.Name = "ramInfo";
            this.ramInfo.ReadOnly = true;
            this.ramInfo.Size = new System.Drawing.Size(465, 36);
            this.ramInfo.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.label5.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label5.Location = new System.Drawing.Point(70, 498);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 10, 0, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 36);
            this.label5.TabIndex = 6;
            this.label5.Text = "psu";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // psuInfo
            // 
            this.psuInfo.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.psuInfo.Location = new System.Drawing.Point(194, 498);
            this.psuInfo.Name = "psuInfo";
            this.psuInfo.ReadOnly = true;
            this.psuInfo.Size = new System.Drawing.Size(465, 36);
            this.psuInfo.TabIndex = 15;
            // 
            // cpuBuyNum
            // 
            this.cpuBuyNum.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cpuBuyNum.Location = new System.Drawing.Point(716, 48);
            this.cpuBuyNum.Name = "cpuBuyNum";
            this.cpuBuyNum.ReadOnly = true;
            this.cpuBuyNum.Size = new System.Drawing.Size(264, 36);
            this.cpuBuyNum.TabIndex = 21;
            this.cpuBuyNum.TextChanged += new System.EventHandler(this.cpuByeNum_TextChanged);
            // 
            // psuBuyNum
            // 
            this.psuBuyNum.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.psuBuyNum.Location = new System.Drawing.Point(716, 498);
            this.psuBuyNum.Name = "psuBuyNum";
            this.psuBuyNum.ReadOnly = true;
            this.psuBuyNum.Size = new System.Drawing.Size(264, 36);
            this.psuBuyNum.TabIndex = 22;
            // 
            // ramBuyNum
            // 
            this.ramBuyNum.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ramBuyNum.Location = new System.Drawing.Point(716, 439);
            this.ramBuyNum.Name = "ramBuyNum";
            this.ramBuyNum.ReadOnly = true;
            this.ramBuyNum.Size = new System.Drawing.Size(264, 36);
            this.ramBuyNum.TabIndex = 23;
            // 
            // SSDBuyNum
            // 
            this.SSDBuyNum.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.SSDBuyNum.Location = new System.Drawing.Point(716, 383);
            this.SSDBuyNum.Name = "SSDBuyNum";
            this.SSDBuyNum.ReadOnly = true;
            this.SSDBuyNum.Size = new System.Drawing.Size(264, 36);
            this.SSDBuyNum.TabIndex = 24;
            // 
            // HDDBuyNum
            // 
            this.HDDBuyNum.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.HDDBuyNum.Location = new System.Drawing.Point(716, 327);
            this.HDDBuyNum.Name = "HDDBuyNum";
            this.HDDBuyNum.ReadOnly = true;
            this.HDDBuyNum.Size = new System.Drawing.Size(264, 36);
            this.HDDBuyNum.TabIndex = 25;
            // 
            // caseBuyNum
            // 
            this.caseBuyNum.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.caseBuyNum.Location = new System.Drawing.Point(716, 271);
            this.caseBuyNum.Name = "caseBuyNum";
            this.caseBuyNum.ReadOnly = true;
            this.caseBuyNum.Size = new System.Drawing.Size(264, 36);
            this.caseBuyNum.TabIndex = 26;
            // 
            // gpuBuyNum
            // 
            this.gpuBuyNum.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gpuBuyNum.Location = new System.Drawing.Point(716, 216);
            this.gpuBuyNum.Name = "gpuBuyNum";
            this.gpuBuyNum.ReadOnly = true;
            this.gpuBuyNum.Size = new System.Drawing.Size(264, 36);
            this.gpuBuyNum.TabIndex = 27;
            // 
            // coolerBuyNum
            // 
            this.coolerBuyNum.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.coolerBuyNum.Location = new System.Drawing.Point(716, 160);
            this.coolerBuyNum.Name = "coolerBuyNum";
            this.coolerBuyNum.ReadOnly = true;
            this.coolerBuyNum.Size = new System.Drawing.Size(264, 36);
            this.coolerBuyNum.TabIndex = 28;
            // 
            // mbBuyNum
            // 
            this.mbBuyNum.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.mbBuyNum.Location = new System.Drawing.Point(716, 104);
            this.mbBuyNum.Name = "mbBuyNum";
            this.mbBuyNum.ReadOnly = true;
            this.mbBuyNum.Size = new System.Drawing.Size(264, 36);
            this.mbBuyNum.TabIndex = 29;
            // 
            // totalPrice
            // 
            this.totalPrice.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.totalPrice.Location = new System.Drawing.Point(194, 582);
            this.totalPrice.Name = "totalPrice";
            this.totalPrice.ReadOnly = true;
            this.totalPrice.Size = new System.Drawing.Size(465, 36);
            this.totalPrice.TabIndex = 30;
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CommandTimeout = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.Transaction = null;
            this.mySqlCommand1.UpdatedRowSource = System.Data.UpdateRowSource.None;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.label10.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label10.Location = new System.Drawing.Point(62, 582);
            this.label10.Margin = new System.Windows.Forms.Padding(3, 10, 0, 10);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 36);
            this.label10.TabIndex = 31;
            this.label10.Text = "總價";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.label11.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label11.Location = new System.Drawing.Point(811, 9);
            this.label11.Margin = new System.Windows.Forms.Padding(3, 10, 0, 10);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 36);
            this.label11.TabIndex = 32;
            this.label11.Text = "數量";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button_WOC3
            // 
            this.button_WOC3.BorderColor = System.Drawing.Color.Silver;
            this.button_WOC3.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.button_WOC3.CausesValidation = false;
            this.button_WOC3.FlatAppearance.BorderSize = 0;
            this.button_WOC3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.button_WOC3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.button_WOC3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_WOC3.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_WOC3.Location = new System.Drawing.Point(1026, 582);
            this.button_WOC3.Margin = new System.Windows.Forms.Padding(30);
            this.button_WOC3.Name = "button_WOC3";
            this.button_WOC3.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.button_WOC3.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.button_WOC3.OnHoverTextColor = System.Drawing.Color.Gray;
            this.button_WOC3.Size = new System.Drawing.Size(119, 64);
            this.button_WOC3.TabIndex = 33;
            this.button_WOC3.Text = "前往保固頁\r\n";
            this.button_WOC3.TextColor = System.Drawing.Color.White;
            this.button_WOC3.UseVisualStyleBackColor = true;
            this.button_WOC3.Click += new System.EventHandler(this.button_WOC3_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(1184, 681);
            this.Controls.Add(this.button_WOC3);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.totalPrice);
            this.Controls.Add(this.mbBuyNum);
            this.Controls.Add(this.coolerBuyNum);
            this.Controls.Add(this.gpuBuyNum);
            this.Controls.Add(this.caseBuyNum);
            this.Controls.Add(this.HDDBuyNum);
            this.Controls.Add(this.SSDBuyNum);
            this.Controls.Add(this.ramBuyNum);
            this.Controls.Add(this.psuBuyNum);
            this.Controls.Add(this.cpuBuyNum);
            this.Controls.Add(this.ramInfo);
            this.Controls.Add(this.SSDInfo);
            this.Controls.Add(this.HDDInfo);
            this.Controls.Add(this.caseInfo);
            this.Controls.Add(this.psuInfo);
            this.Controls.Add(this.gpuInfo);
            this.Controls.Add(this.coolerInfo);
            this.Controls.Add(this.mbInfo);
            this.Controls.Add(this.cpuInfo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form2_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form2_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form2_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox cpuInfo;
        private System.Windows.Forms.TextBox mbInfo;
        private System.Windows.Forms.TextBox coolerInfo;
        private System.Windows.Forms.TextBox gpuInfo;
        private System.Windows.Forms.TextBox caseInfo;
        private System.Windows.Forms.TextBox HDDInfo;
        private System.Windows.Forms.TextBox SSDInfo;
        private System.Windows.Forms.TextBox ramInfo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox psuInfo;
        private System.Windows.Forms.TextBox cpuBuyNum;
        private System.Windows.Forms.TextBox psuBuyNum;
        private System.Windows.Forms.TextBox ramBuyNum;
        private System.Windows.Forms.TextBox SSDBuyNum;
        private System.Windows.Forms.TextBox HDDBuyNum;
        private System.Windows.Forms.TextBox caseBuyNum;
        private System.Windows.Forms.TextBox gpuBuyNum;
        private System.Windows.Forms.TextBox coolerBuyNum;
        private System.Windows.Forms.TextBox mbBuyNum;
        private System.Windows.Forms.TextBox totalPrice;
        private MySqlConnector.MySqlCommand mySqlCommand1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private ePOSOne.btnProduct.Button_WOC button_WOC3;
    }
}