
namespace databasefinal
{
    partial class delete_psu_brand
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
            this.comboBox_psubrand = new System.Windows.Forms.ComboBox();
            this.back = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // close
            // 
            this.close.Font = new System.Drawing.Font("標楷體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.close.Location = new System.Drawing.Point(688, 12);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(100, 31);
            this.close.TabIndex = 10;
            this.close.Text = "關閉";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // comboBox_psubrand
            // 
            this.comboBox_psubrand.FormattingEnabled = true;
            this.comboBox_psubrand.Location = new System.Drawing.Point(289, 141);
            this.comboBox_psubrand.Name = "comboBox_psubrand";
            this.comboBox_psubrand.Size = new System.Drawing.Size(232, 20);
            this.comboBox_psubrand.TabIndex = 13;
            // 
            // back
            // 
            this.back.Font = new System.Drawing.Font("標楷體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.back.Location = new System.Drawing.Point(159, 256);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(110, 34);
            this.back.TabIndex = 14;
            this.back.Text = "上一步";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // button_delete
            // 
            this.button_delete.Font = new System.Drawing.Font("標楷體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_delete.Location = new System.Drawing.Point(539, 258);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(107, 32);
            this.button_delete.TabIndex = 15;
            this.button_delete.Text = "確認刪除";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(285, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 19);
            this.label1.TabIndex = 18;
            this.label1.Text = "brand";
            // 
            // delete_psu_brand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.back);
            this.Controls.Add(this.comboBox_psubrand);
            this.Controls.Add(this.close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "delete_psu_brand";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "psu_brand";
            this.Load += new System.EventHandler(this.delete_psu_brand_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button close;
        private System.Windows.Forms.ComboBox comboBox_psubrand;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Label label1;
    }
}