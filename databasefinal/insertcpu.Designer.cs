
namespace databasefinal
{
    partial class insertcpu
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
            this.insert = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.close = new System.Windows.Forms.Button();
            this.select = new System.Windows.Forms.ComboBox();
            this.update = new System.Windows.Forms.Button();
            this.CPU_TDP = new System.Windows.Forms.ComboBox();
            this.propose = new System.Windows.Forms.ComboBox();
            this.socket = new System.Windows.Forms.ComboBox();
            this.brand = new System.Windows.Forms.ComboBox();
            this.CPU_model = new System.Windows.Forms.TextBox();
            this.clock = new System.Windows.Forms.TextBox();
            this.price = new System.Windows.Forms.TextBox();
            this.keyword = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // insert
            // 
            this.insert.Location = new System.Drawing.Point(362, 311);
            this.insert.Name = "insert";
            this.insert.Size = new System.Drawing.Size(87, 31);
            this.insert.TabIndex = 8;
            this.insert.Text = "新增";
            this.insert.UseVisualStyleBackColor = true;
            this.insert.Click += new System.EventHandler(this.insert_Click);
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(12, 403);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(85, 35);
            this.back.TabIndex = 9;
            this.back.Text = "上一步";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(395, 268);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 19);
            this.label7.TabIndex = 23;
            this.label7.Text = "price";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(390, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 19);
            this.label6.TabIndex = 22;
            this.label6.Text = "brand";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(393, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 19);
            this.label5.TabIndex = 21;
            this.label5.Text = "clock";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(384, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 19);
            this.label4.TabIndex = 20;
            this.label4.Text = "socket";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(375, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 19);
            this.label3.TabIndex = 19;
            this.label3.Text = "propose";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(358, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 19);
            this.label2.TabIndex = 18;
            this.label2.Text = "CPU_TDP";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(349, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 19);
            this.label1.TabIndex = 17;
            this.label1.Text = "CPU_model";
            // 
            // close
            // 
            this.close.Location = new System.Drawing.Point(701, 12);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(87, 35);
            this.close.TabIndex = 79;
            this.close.Text = "關閉";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // select
            // 
            this.select.FormattingEnabled = true;
            this.select.Location = new System.Drawing.Point(40, 97);
            this.select.Name = "select";
            this.select.Size = new System.Drawing.Size(208, 20);
            this.select.TabIndex = 80;
            this.select.SelectedIndexChanged += new System.EventHandler(this.comboBox_select_SelectedIndexChanged);
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(651, 311);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(83, 31);
            this.update.TabIndex = 81;
            this.update.Text = "修改";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // CPU_TDP
            // 
            this.CPU_TDP.FormattingEnabled = true;
            this.CPU_TDP.Location = new System.Drawing.Point(497, 127);
            this.CPU_TDP.Name = "CPU_TDP";
            this.CPU_TDP.Size = new System.Drawing.Size(121, 20);
            this.CPU_TDP.TabIndex = 82;
            // 
            // propose
            // 
            this.propose.FormattingEnabled = true;
            this.propose.Location = new System.Drawing.Point(497, 158);
            this.propose.Name = "propose";
            this.propose.Size = new System.Drawing.Size(121, 20);
            this.propose.TabIndex = 83;
            // 
            // socket
            // 
            this.socket.FormattingEnabled = true;
            this.socket.Location = new System.Drawing.Point(497, 186);
            this.socket.Name = "socket";
            this.socket.Size = new System.Drawing.Size(121, 20);
            this.socket.TabIndex = 84;
            // 
            // brand
            // 
            this.brand.FormattingEnabled = true;
            this.brand.Location = new System.Drawing.Point(497, 242);
            this.brand.Name = "brand";
            this.brand.Size = new System.Drawing.Size(121, 20);
            this.brand.TabIndex = 85;
            // 
            // CPU_model
            // 
            this.CPU_model.Location = new System.Drawing.Point(497, 97);
            this.CPU_model.Name = "CPU_model";
            this.CPU_model.Size = new System.Drawing.Size(121, 22);
            this.CPU_model.TabIndex = 86;
            // 
            // clock
            // 
            this.clock.Location = new System.Drawing.Point(497, 212);
            this.clock.Name = "clock";
            this.clock.Size = new System.Drawing.Size(121, 22);
            this.clock.TabIndex = 87;
            // 
            // price
            // 
            this.price.Location = new System.Drawing.Point(497, 270);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(121, 22);
            this.price.TabIndex = 88;
            // 
            // keyword
            // 
            this.keyword.Location = new System.Drawing.Point(40, 181);
            this.keyword.Name = "keyword";
            this.keyword.Size = new System.Drawing.Size(208, 22);
            this.keyword.TabIndex = 90;
            this.keyword.TextChanged += new System.EventHandler(this.keyword_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(36, 75);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(32, 19);
            this.label12.TabIndex = 114;
            this.label12.Text = "cpu";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(36, 156);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 19);
            this.label8.TabIndex = 115;
            this.label8.Text = "keyword";
            // 
            // insertcpu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.keyword);
            this.Controls.Add(this.price);
            this.Controls.Add(this.clock);
            this.Controls.Add(this.CPU_model);
            this.Controls.Add(this.brand);
            this.Controls.Add(this.socket);
            this.Controls.Add(this.propose);
            this.Controls.Add(this.CPU_TDP);
            this.Controls.Add(this.update);
            this.Controls.Add(this.select);
            this.Controls.Add(this.close);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.back);
            this.Controls.Add(this.insert);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "insertcpu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "insertcpu";
            this.Load += new System.EventHandler(this.insertcpu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button insert;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.ComboBox select;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.ComboBox CPU_TDP;
        private System.Windows.Forms.ComboBox propose;
        private System.Windows.Forms.ComboBox socket;
        private System.Windows.Forms.ComboBox brand;
        private System.Windows.Forms.TextBox CPU_model;
        private System.Windows.Forms.TextBox clock;
        private System.Windows.Forms.TextBox price;
        private System.Windows.Forms.TextBox keyword;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label8;
    }
}