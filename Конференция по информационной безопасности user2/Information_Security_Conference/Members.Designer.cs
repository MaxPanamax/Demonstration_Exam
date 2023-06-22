namespace Information_Security_Conference
{
    partial class Members
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
            this.label3Heder = new System.Windows.Forms.Label();
            this.button1Return = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3Heder
            // 
            this.label3Heder.AutoSize = true;
            this.label3Heder.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3Heder.ForeColor = System.Drawing.Color.Gray;
            this.label3Heder.Location = new System.Drawing.Point(60, 18);
            this.label3Heder.Name = "label3Heder";
            this.label3Heder.Size = new System.Drawing.Size(556, 50);
            this.label3Heder.TabIndex = 10;
            this.label3Heder.Text = "Конференция по информационной безопасности \r\nформа Участников";
            // 
            // button1Return
            // 
            this.button1Return.BackColor = System.Drawing.Color.Lime;
            this.button1Return.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1Return.ForeColor = System.Drawing.Color.White;
            this.button1Return.Location = new System.Drawing.Point(41, 361);
            this.button1Return.Name = "button1Return";
            this.button1Return.Size = new System.Drawing.Size(154, 51);
            this.button1Return.TabIndex = 11;
            this.button1Return.Text = "Вернуться";
            this.button1Return.UseVisualStyleBackColor = false;
            this.button1Return.Click += new System.EventHandler(this.button1Return_Click);
            // 
            // Members
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1Return);
            this.Controls.Add(this.label3Heder);
            this.Name = "Members";
            this.Text = "Members";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3Heder;
        private System.Windows.Forms.Button button1Return;
    }
}