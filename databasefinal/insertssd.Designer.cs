
namespace databasefinal
{
    partial class insertssd
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
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SSD_model = new System.Windows.Forms.TextBox();
            this.price = new System.Windows.Forms.TextBox();
            this.insert = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.select = new System.Windows.Forms.ComboBox();
            this.brand = new System.Windows.Forms.ComboBox();
            this.keyword = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(357, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "SSD_model";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(402, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 19);
            this.label6.TabIndex = 6;
            this.label6.Text = "price";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(397, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 19);
            this.label7.TabIndex = 7;
            this.label7.Text = "brand";
            // 
            // SSD_model
            // 
            this.SSD_model.Location = new System.Drawing.Point(457, 90);
            this.SSD_model.Name = "SSD_model";
            this.SSD_model.Size = new System.Drawing.Size(169, 22);
            this.SSD_model.TabIndex = 8;
            // 
            // price
            // 
            this.price.Location = new System.Drawing.Point(457, 146);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(169, 22);
            this.price.TabIndex = 10;
            // 
            // insert
            // 
            this.insert.Location = new System.Drawing.Point(338, 216);
            this.insert.Name = "insert";
            this.insert.Size = new System.Drawing.Size(94, 37);
            this.insert.TabIndex = 11;
            this.insert.Text = "新增";
            this.insert.UseVisualStyleBackColor = true;
            this.insert.Click += new System.EventHandler(this.button1_Click);
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(12, 397);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(99, 41);
            this.back.TabIndex = 12;
            this.back.Text = "上一步";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // close
            // 
            this.close.Location = new System.Drawing.Point(693, 12);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(95, 36);
            this.close.TabIndex = 79;
            this.close.Text = "關閉";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(644, 216);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(94, 37);
            this.update.TabIndex = 83;
            this.update.Text = "修改";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // select
            // 
            this.select.FormattingEnabled = true;
            this.select.Location = new System.Drawing.Point(44, 92);
            this.select.Name = "select";
            this.select.Size = new System.Drawing.Size(291, 20);
            this.select.TabIndex = 84;
            this.select.SelectedIndexChanged += new System.EventHandler(this.select_SelectedIndexChanged);
            // 
            // brand
            // 
            this.brand.FormattingEnabled = true;
            this.brand.Location = new System.Drawing.Point(457, 120);
            this.brand.Name = "brand";
            this.brand.Size = new System.Drawing.Size(169, 20);
            this.brand.TabIndex = 85;
            // 
            // keyword
            // 
            this.keyword.Location = new System.Drawing.Point(44, 151);
            this.keyword.Name = "keyword";
            this.keyword.Size = new System.Drawing.Size(291, 22);
            this.keyword.TabIndex = 91;
            this.keyword.TextChanged += new System.EventHandler(this.keyword_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(40, 129);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 19);
            this.label12.TabIndex = 114;
            this.label12.Text = "keyword";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 19);
            this.label2.TabIndex = 115;
            this.label2.Text = "ssd";
            // 
            // insertssd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.keyword);
            this.Controls.Add(this.brand);
            this.Controls.Add(this.select);
            this.Controls.Add(this.update);
            this.Controls.Add(this.close);
            this.Controls.Add(this.back);
            this.Controls.Add(this.insert);
            this.Controls.Add(this.price);
            this.Controls.Add(this.SSD_model);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "insertssd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "insertssd";
            this.Load += new System.EventHandler(this.insertssd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox SSD_model;
        private System.Windows.Forms.TextBox price;
        private System.Windows.Forms.Button insert;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.ComboBox select;
        private System.Windows.Forms.ComboBox brand;
        private System.Windows.Forms.TextBox keyword;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label2;
    }
}