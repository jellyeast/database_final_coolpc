
namespace databasefinal
{
    partial class insertPwatt
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
            this.P_watt = new System.Windows.Forms.TextBox();
            this.select = new System.Windows.Forms.ComboBox();
            this.update = new System.Windows.Forms.Button();
            this.insert = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // P_watt
            // 
            this.P_watt.Location = new System.Drawing.Point(333, 215);
            this.P_watt.Name = "P_watt";
            this.P_watt.Size = new System.Drawing.Size(121, 22);
            this.P_watt.TabIndex = 11;
            // 
            // select
            // 
            this.select.FormattingEnabled = true;
            this.select.Location = new System.Drawing.Point(333, 126);
            this.select.Name = "select";
            this.select.Size = new System.Drawing.Size(121, 20);
            this.select.TabIndex = 10;
            this.select.SelectedIndexChanged += new System.EventHandler(this.select_SelectedIndexChanged);
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(505, 296);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(91, 31);
            this.update.TabIndex = 9;
            this.update.Text = "更改";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // insert
            // 
            this.insert.Location = new System.Drawing.Point(197, 296);
            this.insert.Name = "insert";
            this.insert.Size = new System.Drawing.Size(91, 31);
            this.insert.TabIndex = 8;
            this.insert.Text = "新增";
            this.insert.UseVisualStyleBackColor = true;
            this.insert.Click += new System.EventHandler(this.insert_Click);
            // 
            // close
            // 
            this.close.Location = new System.Drawing.Point(702, 12);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(86, 34);
            this.close.TabIndex = 7;
            this.close.Text = "關閉";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(12, 407);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(86, 31);
            this.back.TabIndex = 6;
            this.back.Text = "上一步";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(329, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 19);
            this.label1.TabIndex = 13;
            this.label1.Text = "P_watt";
            // 
            // insertPwatt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.P_watt);
            this.Controls.Add(this.select);
            this.Controls.Add(this.update);
            this.Controls.Add(this.insert);
            this.Controls.Add(this.close);
            this.Controls.Add(this.back);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "insertPwatt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "insertPwatt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox P_watt;
        private System.Windows.Forms.ComboBox select;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button insert;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Label label1;
    }
}