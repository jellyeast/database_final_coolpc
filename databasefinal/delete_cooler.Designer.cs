
namespace databasefinal
{
    partial class delete_cooler
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
            this.close = new System.Windows.Forms.Button();
            this.comboBox_cooler = new System.Windows.Forms.ComboBox();
            this.button_delete = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.keyword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lable5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Co_model = new System.Windows.Forms.TextBox();
            this.price = new System.Windows.Forms.TextBox();
            this.brand = new System.Windows.Forms.TextBox();
            this.socket = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // close
            // 
            this.close.Font = new System.Drawing.Font("標楷體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.close.Location = new System.Drawing.Point(680, 12);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(108, 27);
            this.close.TabIndex = 7;
            this.close.Text = "關閉";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // comboBox_cooler
            // 
            this.comboBox_cooler.FormattingEnabled = true;
            this.comboBox_cooler.Location = new System.Drawing.Point(68, 74);
            this.comboBox_cooler.Name = "comboBox_cooler";
            this.comboBox_cooler.Size = new System.Drawing.Size(235, 20);
            this.comboBox_cooler.TabIndex = 6;
            this.comboBox_cooler.SelectedIndexChanged += new System.EventHandler(this.comboBox_cooler_SelectedIndexChanged);
            // 
            // button_delete
            // 
            this.button_delete.Font = new System.Drawing.Font("標楷體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_delete.Location = new System.Drawing.Point(499, 260);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(113, 34);
            this.button_delete.TabIndex = 5;
            this.button_delete.Text = "確認刪除";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // back
            // 
            this.back.Font = new System.Drawing.Font("標楷體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.back.Location = new System.Drawing.Point(117, 260);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(154, 34);
            this.back.TabIndex = 4;
            this.back.Text = "回到選擇功能";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 19);
            this.label1.TabIndex = 9;
            this.label1.Text = "cooler";
            // 
            // keyword
            // 
            this.keyword.Location = new System.Drawing.Point(68, 124);
            this.keyword.Name = "keyword";
            this.keyword.Size = new System.Drawing.Size(235, 22);
            this.keyword.TabIndex = 92;
            this.keyword.TextChanged += new System.EventHandler(this.keyword_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(368, 156);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 19);
            this.label4.TabIndex = 98;
            this.label4.Text = "price";
            // 
            // lable5
            // 
            this.lable5.AutoSize = true;
            this.lable5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable5.Location = new System.Drawing.Point(363, 129);
            this.lable5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lable5.Name = "lable5";
            this.lable5.Size = new System.Drawing.Size(47, 19);
            this.lable5.TabIndex = 97;
            this.lable5.Text = "brand";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(357, 101);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 19);
            this.label2.TabIndex = 96;
            this.label2.Text = "socket";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(334, 75);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 19);
            this.label5.TabIndex = 95;
            this.label5.Text = "Co_model";
            // 
            // Co_model
            // 
            this.Co_model.Location = new System.Drawing.Point(421, 68);
            this.Co_model.Margin = new System.Windows.Forms.Padding(2);
            this.Co_model.Name = "Co_model";
            this.Co_model.ReadOnly = true;
            this.Co_model.Size = new System.Drawing.Size(216, 22);
            this.Co_model.TabIndex = 94;
            // 
            // price
            // 
            this.price.Location = new System.Drawing.Point(421, 153);
            this.price.Margin = new System.Windows.Forms.Padding(2);
            this.price.Name = "price";
            this.price.ReadOnly = true;
            this.price.Size = new System.Drawing.Size(216, 22);
            this.price.TabIndex = 93;
            // 
            // brand
            // 
            this.brand.Location = new System.Drawing.Point(421, 126);
            this.brand.Name = "brand";
            this.brand.ReadOnly = true;
            this.brand.Size = new System.Drawing.Size(216, 22);
            this.brand.TabIndex = 101;
            // 
            // socket
            // 
            this.socket.Location = new System.Drawing.Point(421, 98);
            this.socket.Name = "socket";
            this.socket.ReadOnly = true;
            this.socket.Size = new System.Drawing.Size(216, 22);
            this.socket.TabIndex = 102;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(64, 102);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 19);
            this.label12.TabIndex = 114;
            this.label12.Text = "keyword";
            // 
            // delete_cooler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.socket);
            this.Controls.Add(this.brand);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lable5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Co_model);
            this.Controls.Add(this.price);
            this.Controls.Add(this.keyword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.close);
            this.Controls.Add(this.comboBox_cooler);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.back);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "delete_cooler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "delete_cooler";
            this.Load += new System.EventHandler(this.delete_cooler_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button close;
        private System.Windows.Forms.ComboBox comboBox_cooler;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox keyword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lable5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Co_model;
        private System.Windows.Forms.TextBox price;
        private System.Windows.Forms.TextBox brand;
        private System.Windows.Forms.TextBox socket;
        private System.Windows.Forms.Label label12;
    }
}