﻿
namespace databasefinal
{
    partial class insertrcapacity
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
            this.rc = new System.Windows.Forms.TextBox();
            this.select = new System.Windows.Forms.ComboBox();
            this.update = new System.Windows.Forms.Button();
            this.insert = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rc
            // 
            this.rc.Location = new System.Drawing.Point(333, 211);
            this.rc.Name = "rc";
            this.rc.Size = new System.Drawing.Size(121, 22);
            this.rc.TabIndex = 11;
            this.rc.TextChanged += new System.EventHandler(this.rc_TextChanged);
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
            this.update.Location = new System.Drawing.Point(496, 289);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(100, 38);
            this.update.TabIndex = 9;
            this.update.Text = "更改";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // insert
            // 
            this.insert.Location = new System.Drawing.Point(188, 289);
            this.insert.Name = "insert";
            this.insert.Size = new System.Drawing.Size(100, 38);
            this.insert.TabIndex = 8;
            this.insert.Text = "新增";
            this.insert.UseVisualStyleBackColor = true;
            this.insert.Click += new System.EventHandler(this.insert_Click);
            // 
            // close
            // 
            this.close.Location = new System.Drawing.Point(701, 12);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(87, 36);
            this.close.TabIndex = 7;
            this.close.Text = "關閉";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(12, 405);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(90, 33);
            this.back.TabIndex = 6;
            this.back.Text = "上一步";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(329, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 19);
            this.label1.TabIndex = 13;
            this.label1.Text = "R_capacity";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // insertrcapacity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rc);
            this.Controls.Add(this.select);
            this.Controls.Add(this.update);
            this.Controls.Add(this.insert);
            this.Controls.Add(this.close);
            this.Controls.Add(this.back);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "insertrcapacity";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "insertrcapacity";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox rc;
        private System.Windows.Forms.ComboBox select;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button insert;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Label label1;
    }
}