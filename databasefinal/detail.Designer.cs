
namespace databasefinal
{
    partial class detail
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
            this.things = new System.Windows.Forms.Button();
            this.det = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // things
            // 
            this.things.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.things.Location = new System.Drawing.Point(216, 182);
            this.things.Name = "things";
            this.things.Size = new System.Drawing.Size(102, 37);
            this.things.TabIndex = 0;
            this.things.Text = "零組件";
            this.things.UseVisualStyleBackColor = true;
            this.things.Click += new System.EventHandler(this.things_Click);
            // 
            // det
            // 
            this.det.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.det.Location = new System.Drawing.Point(481, 182);
            this.det.Name = "det";
            this.det.Size = new System.Drawing.Size(102, 37);
            this.det.TabIndex = 1;
            this.det.Text = "細項";
            this.det.UseVisualStyleBackColor = true;
            this.det.Click += new System.EventHandler(this.det_Click);
            // 
            // back
            // 
            this.back.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.back.Location = new System.Drawing.Point(12, 402);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(97, 36);
            this.back.TabIndex = 2;
            this.back.Text = "上一步";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // close
            // 
            this.close.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.close.Location = new System.Drawing.Point(698, 12);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(90, 37);
            this.close.TabIndex = 3;
            this.close.Text = "關閉";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // detail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.close);
            this.Controls.Add(this.back);
            this.Controls.Add(this.det);
            this.Controls.Add(this.things);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "detail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "detail";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button things;
        private System.Windows.Forms.Button det;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button close;
    }
}