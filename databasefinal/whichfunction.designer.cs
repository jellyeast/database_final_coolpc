
namespace databasefinal
{
    partial class Whichfunction
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
            this.Insert_b = new System.Windows.Forms.Button();
            this.Delete_b = new System.Windows.Forms.Button();
            this.Back_b = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Insert_b
            // 
            this.Insert_b.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Insert_b.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Insert_b.Location = new System.Drawing.Point(213, 158);
            this.Insert_b.Name = "Insert_b";
            this.Insert_b.Size = new System.Drawing.Size(140, 44);
            this.Insert_b.TabIndex = 0;
            this.Insert_b.Text = "新增/修改";
            this.Insert_b.UseVisualStyleBackColor = true;
            this.Insert_b.Click += new System.EventHandler(this.Insert_b_Click);
            // 
            // Delete_b
            // 
            this.Delete_b.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Delete_b.Location = new System.Drawing.Point(481, 158);
            this.Delete_b.Name = "Delete_b";
            this.Delete_b.Size = new System.Drawing.Size(96, 44);
            this.Delete_b.TabIndex = 2;
            this.Delete_b.Text = "刪除";
            this.Delete_b.UseVisualStyleBackColor = true;
            this.Delete_b.Click += new System.EventHandler(this.Delete_b_Click);
            // 
            // Back_b
            // 
            this.Back_b.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Back_b.Location = new System.Drawing.Point(12, 406);
            this.Back_b.Name = "Back_b";
            this.Back_b.Size = new System.Drawing.Size(173, 32);
            this.Back_b.TabIndex = 3;
            this.Back_b.Text = "退出管理員權限";
            this.Back_b.UseVisualStyleBackColor = true;
            this.Back_b.Click += new System.EventHandler(this.Back_b_Click);
            // 
            // close
            // 
            this.close.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.close.Location = new System.Drawing.Point(713, 12);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(75, 29);
            this.close.TabIndex = 78;
            this.close.Text = "關閉";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // back
            // 
            this.back.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.back.Location = new System.Drawing.Point(213, 406);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(131, 32);
            this.back.TabIndex = 79;
            this.back.Text = "上一步";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // Whichfunction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.back);
            this.Controls.Add(this.close);
            this.Controls.Add(this.Back_b);
            this.Controls.Add(this.Delete_b);
            this.Controls.Add(this.Insert_b);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Whichfunction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Whichfunction";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Insert_b;
        private System.Windows.Forms.Button Delete_b;
        private System.Windows.Forms.Button Back_b;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Button back;
    }
}