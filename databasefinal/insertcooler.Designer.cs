
namespace databasefinal
{
    partial class insertcooler
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
            this.back = new System.Windows.Forms.Button();
            this.insert = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Co_model = new System.Windows.Forms.TextBox();
            this.price = new System.Windows.Forms.TextBox();
            this.close = new System.Windows.Forms.Button();
            this.select = new System.Windows.Forms.ComboBox();
            this.socket = new System.Windows.Forms.ComboBox();
            this.brand = new System.Windows.Forms.ComboBox();
            this.update = new System.Windows.Forms.Button();
            this.keyword = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(11, 410);
            this.back.Margin = new System.Windows.Forms.Padding(2);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(67, 29);
            this.back.TabIndex = 27;
            this.back.Text = "上一頁";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // insert
            // 
            this.insert.Location = new System.Drawing.Point(362, 239);
            this.insert.Margin = new System.Windows.Forms.Padding(2);
            this.insert.Name = "insert";
            this.insert.Size = new System.Drawing.Size(79, 29);
            this.insert.TabIndex = 26;
            this.insert.Text = "確認新增";
            this.insert.UseVisualStyleBackColor = true;
            this.insert.Click += new System.EventHandler(this.insert_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(388, 163);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 19);
            this.label4.TabIndex = 23;
            this.label4.Text = "price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(382, 136);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 19);
            this.label3.TabIndex = 22;
            this.label3.Text = "brand";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(376, 110);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 19);
            this.label2.TabIndex = 21;
            this.label2.Text = "socket";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(354, 85);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 19);
            this.label1.TabIndex = 20;
            this.label1.Text = "Co_model";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Co_model
            // 
            this.Co_model.Location = new System.Drawing.Point(434, 82);
            this.Co_model.Margin = new System.Windows.Forms.Padding(2);
            this.Co_model.Name = "Co_model";
            this.Co_model.Size = new System.Drawing.Size(216, 22);
            this.Co_model.TabIndex = 19;
            // 
            // price
            // 
            this.price.Location = new System.Drawing.Point(434, 160);
            this.price.Margin = new System.Windows.Forms.Padding(2);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(216, 22);
            this.price.TabIndex = 16;
            // 
            // close
            // 
            this.close.Location = new System.Drawing.Point(713, 12);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(75, 23);
            this.close.TabIndex = 79;
            this.close.Text = "關閉";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // select
            // 
            this.select.FormattingEnabled = true;
            this.select.Location = new System.Drawing.Point(50, 82);
            this.select.Name = "select";
            this.select.Size = new System.Drawing.Size(215, 20);
            this.select.TabIndex = 82;
            this.select.SelectedIndexChanged += new System.EventHandler(this.select_SelectedIndexChanged);
            // 
            // socket
            // 
            this.socket.FormattingEnabled = true;
            this.socket.Location = new System.Drawing.Point(434, 109);
            this.socket.Name = "socket";
            this.socket.Size = new System.Drawing.Size(215, 20);
            this.socket.TabIndex = 83;
            // 
            // brand
            // 
            this.brand.FormattingEnabled = true;
            this.brand.Location = new System.Drawing.Point(434, 135);
            this.brand.Name = "brand";
            this.brand.Size = new System.Drawing.Size(215, 20);
            this.brand.TabIndex = 84;
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(627, 239);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(81, 29);
            this.update.TabIndex = 85;
            this.update.Text = "修改";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // keyword
            // 
            this.keyword.Location = new System.Drawing.Point(50, 138);
            this.keyword.Name = "keyword";
            this.keyword.Size = new System.Drawing.Size(215, 22);
            this.keyword.TabIndex = 91;
            this.keyword.TextChanged += new System.EventHandler(this.keyword_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(46, 116);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 19);
            this.label12.TabIndex = 114;
            this.label12.Text = "keyword";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(46, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 19);
            this.label5.TabIndex = 115;
            this.label5.Text = "cooler";
            // 
            // insertcooler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.keyword);
            this.Controls.Add(this.update);
            this.Controls.Add(this.brand);
            this.Controls.Add(this.socket);
            this.Controls.Add(this.select);
            this.Controls.Add(this.close);
            this.Controls.Add(this.back);
            this.Controls.Add(this.insert);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Co_model);
            this.Controls.Add(this.price);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "insertcooler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "insertcooler";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button insert;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Co_model;
        private System.Windows.Forms.TextBox price;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.ComboBox select;
        private System.Windows.Forms.ComboBox socket;
        private System.Windows.Forms.ComboBox brand;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.TextBox keyword;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label5;
    }
}