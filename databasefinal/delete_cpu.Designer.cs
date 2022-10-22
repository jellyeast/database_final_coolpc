
namespace databasefinal
{
    partial class delete_cpu
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
            this.comboBox_cpu = new System.Windows.Forms.ComboBox();
            this.back = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.keyword = new System.Windows.Forms.TextBox();
            this.price = new System.Windows.Forms.TextBox();
            this.clock = new System.Windows.Forms.TextBox();
            this.CPU_model = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.brand = new System.Windows.Forms.TextBox();
            this.socket = new System.Windows.Forms.TextBox();
            this.propose = new System.Windows.Forms.TextBox();
            this.CPU_TDP = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBox_cpu
            // 
            this.comboBox_cpu.FormattingEnabled = true;
            this.comboBox_cpu.Location = new System.Drawing.Point(50, 76);
            this.comboBox_cpu.Name = "comboBox_cpu";
            this.comboBox_cpu.Size = new System.Drawing.Size(232, 20);
            this.comboBox_cpu.TabIndex = 0;
            this.comboBox_cpu.SelectedIndexChanged += new System.EventHandler(this.comboBox_model_SelectedIndexChanged);
            // 
            // back
            // 
            this.back.Font = new System.Drawing.Font("標楷體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.back.Location = new System.Drawing.Point(136, 295);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(146, 34);
            this.back.TabIndex = 4;
            this.back.Text = "回到選擇功能";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // button_delete
            // 
            this.button_delete.Font = new System.Drawing.Font("標楷體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_delete.Location = new System.Drawing.Point(518, 295);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(108, 34);
            this.button_delete.TabIndex = 5;
            this.button_delete.Text = "確認刪除";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // close
            // 
            this.close.Font = new System.Drawing.Font("標楷體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.close.Location = new System.Drawing.Point(688, 12);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(100, 30);
            this.close.TabIndex = 7;
            this.close.Text = "關閉";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 19);
            this.label1.TabIndex = 18;
            this.label1.Text = "cpu";
            // 
            // keyword
            // 
            this.keyword.Location = new System.Drawing.Point(50, 128);
            this.keyword.Name = "keyword";
            this.keyword.Size = new System.Drawing.Size(232, 22);
            this.keyword.TabIndex = 92;
            this.keyword.TextChanged += new System.EventHandler(this.keyword_TextChanged);
            // 
            // price
            // 
            this.price.Location = new System.Drawing.Point(505, 240);
            this.price.Name = "price";
            this.price.ReadOnly = true;
            this.price.Size = new System.Drawing.Size(121, 22);
            this.price.TabIndex = 106;
            // 
            // clock
            // 
            this.clock.Location = new System.Drawing.Point(505, 182);
            this.clock.Name = "clock";
            this.clock.ReadOnly = true;
            this.clock.Size = new System.Drawing.Size(121, 22);
            this.clock.TabIndex = 105;
            // 
            // CPU_model
            // 
            this.CPU_model.Location = new System.Drawing.Point(505, 67);
            this.CPU_model.Name = "CPU_model";
            this.CPU_model.ReadOnly = true;
            this.CPU_model.Size = new System.Drawing.Size(121, 22);
            this.CPU_model.TabIndex = 104;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(403, 238);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 19);
            this.label7.TabIndex = 99;
            this.label7.Text = "price";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(398, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 19);
            this.label6.TabIndex = 98;
            this.label6.Text = "brand";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(401, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 19);
            this.label5.TabIndex = 97;
            this.label5.Text = "clock";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(392, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 19);
            this.label4.TabIndex = 96;
            this.label4.Text = "socket";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(383, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 19);
            this.label3.TabIndex = 95;
            this.label3.Text = "propose";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(366, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 19);
            this.label2.TabIndex = 94;
            this.label2.Text = "CPU_TDP";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(357, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 19);
            this.label8.TabIndex = 93;
            this.label8.Text = "CPU_model";
            // 
            // brand
            // 
            this.brand.Location = new System.Drawing.Point(505, 212);
            this.brand.Name = "brand";
            this.brand.ReadOnly = true;
            this.brand.Size = new System.Drawing.Size(121, 22);
            this.brand.TabIndex = 107;
            // 
            // socket
            // 
            this.socket.Location = new System.Drawing.Point(505, 153);
            this.socket.Name = "socket";
            this.socket.ReadOnly = true;
            this.socket.Size = new System.Drawing.Size(121, 22);
            this.socket.TabIndex = 108;
            // 
            // propose
            // 
            this.propose.Location = new System.Drawing.Point(505, 125);
            this.propose.Name = "propose";
            this.propose.ReadOnly = true;
            this.propose.Size = new System.Drawing.Size(121, 22);
            this.propose.TabIndex = 109;
            // 
            // CPU_TDP
            // 
            this.CPU_TDP.Location = new System.Drawing.Point(505, 97);
            this.CPU_TDP.Name = "CPU_TDP";
            this.CPU_TDP.ReadOnly = true;
            this.CPU_TDP.Size = new System.Drawing.Size(121, 22);
            this.CPU_TDP.TabIndex = 110;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(46, 106);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 19);
            this.label12.TabIndex = 114;
            this.label12.Text = "keyword";
            // 
            // delete_cpu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.CPU_TDP);
            this.Controls.Add(this.propose);
            this.Controls.Add(this.socket);
            this.Controls.Add(this.brand);
            this.Controls.Add(this.price);
            this.Controls.Add(this.clock);
            this.Controls.Add(this.CPU_model);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.keyword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.close);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.back);
            this.Controls.Add(this.comboBox_cpu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "delete_cpu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "delete_cpu";
            this.Load += new System.EventHandler(this.delete_cpu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_cpu;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox keyword;
        private System.Windows.Forms.TextBox price;
        private System.Windows.Forms.TextBox clock;
        private System.Windows.Forms.TextBox CPU_model;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox brand;
        private System.Windows.Forms.TextBox socket;
        private System.Windows.Forms.TextBox propose;
        private System.Windows.Forms.TextBox CPU_TDP;
        private System.Windows.Forms.Label label12;
    }
}