
namespace databasefinal
{
    partial class insertpsu
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.P_model = new System.Windows.Forms.TextBox();
            this.price = new System.Windows.Forms.TextBox();
            this.insert = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.select = new System.Windows.Forms.ComboBox();
            this.update = new System.Windows.Forms.Button();
            this.P_watt = new System.Windows.Forms.ComboBox();
            this.brand = new System.Windows.Forms.ComboBox();
            this.keyword = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(344, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "P_model";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(363, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "brand";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(368, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(356, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "P_watt";
            // 
            // P_model
            // 
            this.P_model.Location = new System.Drawing.Point(416, 71);
            this.P_model.Name = "P_model";
            this.P_model.Size = new System.Drawing.Size(174, 22);
            this.P_model.TabIndex = 9;
            // 
            // price
            // 
            this.price.Location = new System.Drawing.Point(416, 155);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(174, 22);
            this.price.TabIndex = 12;
            // 
            // insert
            // 
            this.insert.Location = new System.Drawing.Point(287, 229);
            this.insert.Name = "insert";
            this.insert.Size = new System.Drawing.Size(94, 37);
            this.insert.TabIndex = 13;
            this.insert.Text = "新增";
            this.insert.UseVisualStyleBackColor = true;
            this.insert.Click += new System.EventHandler(this.insert_Click);
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(12, 402);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(94, 36);
            this.back.TabIndex = 14;
            this.back.Text = "上一步";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // close
            // 
            this.close.Location = new System.Drawing.Point(700, 12);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(88, 35);
            this.close.TabIndex = 78;
            this.close.Text = "關閉";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // select
            // 
            this.select.FormattingEnabled = true;
            this.select.Location = new System.Drawing.Point(35, 71);
            this.select.Name = "select";
            this.select.Size = new System.Drawing.Size(215, 20);
            this.select.TabIndex = 81;
            this.select.SelectedIndexChanged += new System.EventHandler(this.select_SelectedIndexChanged);
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(613, 229);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(94, 37);
            this.update.TabIndex = 82;
            this.update.Text = "修改";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // P_watt
            // 
            this.P_watt.FormattingEnabled = true;
            this.P_watt.Location = new System.Drawing.Point(416, 104);
            this.P_watt.Name = "P_watt";
            this.P_watt.Size = new System.Drawing.Size(174, 20);
            this.P_watt.TabIndex = 84;
            // 
            // brand
            // 
            this.brand.FormattingEnabled = true;
            this.brand.Location = new System.Drawing.Point(416, 130);
            this.brand.Name = "brand";
            this.brand.Size = new System.Drawing.Size(174, 20);
            this.brand.TabIndex = 85;
            // 
            // keyword
            // 
            this.keyword.Location = new System.Drawing.Point(35, 145);
            this.keyword.Name = "keyword";
            this.keyword.Size = new System.Drawing.Size(215, 22);
            this.keyword.TabIndex = 91;
            this.keyword.TextChanged += new System.EventHandler(this.keyword_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(31, 123);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 19);
            this.label12.TabIndex = 114;
            this.label12.Text = "keyword";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(31, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 19);
            this.label5.TabIndex = 115;
            this.label5.Text = "psu";
            // 
            // insertpsu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.keyword);
            this.Controls.Add(this.brand);
            this.Controls.Add(this.P_watt);
            this.Controls.Add(this.update);
            this.Controls.Add(this.select);
            this.Controls.Add(this.close);
            this.Controls.Add(this.back);
            this.Controls.Add(this.insert);
            this.Controls.Add(this.price);
            this.Controls.Add(this.P_model);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "insertpsu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "insertram";
            this.Load += new System.EventHandler(this.insertpsu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox P_model;
        private System.Windows.Forms.TextBox price;
        private System.Windows.Forms.Button insert;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.ComboBox select;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.ComboBox P_watt;
        private System.Windows.Forms.ComboBox brand;
        private System.Windows.Forms.TextBox keyword;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label5;
    }
}