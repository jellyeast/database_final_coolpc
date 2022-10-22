
namespace databasefinal
{
    partial class delete_case
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
            this.comboBox_case = new System.Windows.Forms.ComboBox();
            this.back = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.keyword = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Ca_model = new System.Windows.Forms.TextBox();
            this.size = new System.Windows.Forms.TextBox();
            this.length = new System.Windows.Forms.TextBox();
            this.brand = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBox_case
            // 
            this.comboBox_case.FormattingEnabled = true;
            this.comboBox_case.Location = new System.Drawing.Point(42, 74);
            this.comboBox_case.Name = "comboBox_case";
            this.comboBox_case.Size = new System.Drawing.Size(253, 20);
            this.comboBox_case.TabIndex = 6;
            this.comboBox_case.SelectedIndexChanged += new System.EventHandler(this.comboBox_case_SelectedIndexChanged);
            // 
            // back
            // 
            this.back.Font = new System.Drawing.Font("標楷體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.back.Location = new System.Drawing.Point(132, 270);
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
            this.button_delete.Location = new System.Drawing.Point(514, 270);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(102, 34);
            this.button_delete.TabIndex = 5;
            this.button_delete.Text = "確認刪除";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // close
            // 
            this.close.Font = new System.Drawing.Font("標楷體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.close.Location = new System.Drawing.Point(686, 12);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(102, 28);
            this.close.TabIndex = 7;
            this.close.Text = "關閉";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 19);
            this.label1.TabIndex = 8;
            this.label1.Text = "case";
            // 
            // keyword
            // 
            this.keyword.Location = new System.Drawing.Point(42, 140);
            this.keyword.Name = "keyword";
            this.keyword.Size = new System.Drawing.Size(253, 22);
            this.keyword.TabIndex = 91;
            this.keyword.TextChanged += new System.EventHandler(this.keyword_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(386, 181);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 19);
            this.label9.TabIndex = 98;
            this.label9.Text = "price";
            // 
            // price
            // 
            this.price.Location = new System.Drawing.Point(434, 183);
            this.price.Name = "price";
            this.price.ReadOnly = true;
            this.price.Size = new System.Drawing.Size(215, 22);
            this.price.TabIndex = 97;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(381, 153);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 19);
            this.label7.TabIndex = 96;
            this.label7.Text = "brand";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(378, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 19);
            this.label5.TabIndex = 95;
            this.label5.Text = "length";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(394, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 19);
            this.label3.TabIndex = 94;
            this.label3.Text = "size";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(352, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 19);
            this.label2.TabIndex = 93;
            this.label2.Text = "Ca_model";
            // 
            // Ca_model
            // 
            this.Ca_model.Location = new System.Drawing.Point(434, 72);
            this.Ca_model.Name = "Ca_model";
            this.Ca_model.ReadOnly = true;
            this.Ca_model.Size = new System.Drawing.Size(215, 22);
            this.Ca_model.TabIndex = 92;
            // 
            // size
            // 
            this.size.Location = new System.Drawing.Point(434, 100);
            this.size.Name = "size";
            this.size.ReadOnly = true;
            this.size.Size = new System.Drawing.Size(215, 22);
            this.size.TabIndex = 102;
            // 
            // length
            // 
            this.length.Location = new System.Drawing.Point(434, 128);
            this.length.Name = "length";
            this.length.ReadOnly = true;
            this.length.Size = new System.Drawing.Size(215, 22);
            this.length.TabIndex = 103;
            // 
            // brand
            // 
            this.brand.Location = new System.Drawing.Point(434, 156);
            this.brand.Name = "brand";
            this.brand.ReadOnly = true;
            this.brand.Size = new System.Drawing.Size(215, 22);
            this.brand.TabIndex = 104;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(38, 118);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 19);
            this.label12.TabIndex = 114;
            this.label12.Text = "keyword";
            // 
            // delete_case
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.brand);
            this.Controls.Add(this.length);
            this.Controls.Add(this.size);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.price);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Ca_model);
            this.Controls.Add(this.keyword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.close);
            this.Controls.Add(this.comboBox_case);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.back);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "delete_case";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "delete_case";
            this.Load += new System.EventHandler(this.delete_case_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBox_case;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox keyword;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox price;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Ca_model;
        private System.Windows.Forms.TextBox size;
        private System.Windows.Forms.TextBox length;
        private System.Windows.Forms.TextBox brand;
        private System.Windows.Forms.Label label12;
    }
}