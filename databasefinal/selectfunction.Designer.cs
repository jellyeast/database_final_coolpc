
namespace databasefinal
{
    partial class selectfunction
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
            this.delete = new System.Windows.Forms.Button();
            this.insertupdate = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // delete
            // 
            this.delete.Font = new System.Drawing.Font("標楷體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.delete.Location = new System.Drawing.Point(439, 208);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(124, 34);
            this.delete.TabIndex = 44;
            this.delete.Text = "刪除";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // insertupdate
            // 
            this.insertupdate.Font = new System.Drawing.Font("標楷體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.insertupdate.Location = new System.Drawing.Point(203, 208);
            this.insertupdate.Name = "insertupdate";
            this.insertupdate.Size = new System.Drawing.Size(161, 34);
            this.insertupdate.TabIndex = 45;
            this.insertupdate.Text = "新增/修改";
            this.insertupdate.UseVisualStyleBackColor = true;
            this.insertupdate.Click += new System.EventHandler(this.insertupdate_Click);
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(12, 403);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(94, 35);
            this.back.TabIndex = 46;
            this.back.Text = "上一步";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // close
            // 
            this.close.Location = new System.Drawing.Point(696, 12);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(92, 37);
            this.close.TabIndex = 47;
            this.close.Text = "關閉";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // selectfunction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.close);
            this.Controls.Add(this.back);
            this.Controls.Add(this.insertupdate);
            this.Controls.Add(this.delete);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "selectfunction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "selectfunction";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button insertupdate;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button close;
    }
}