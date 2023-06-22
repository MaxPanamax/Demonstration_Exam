namespace Information_Security_Conference
{
    partial class Authentication
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button3Activ = new System.Windows.Forms.Button();
            this.button2Event = new System.Windows.Forms.Button();
            this.label3Heder = new System.Windows.Forms.Label();
            this.dataGridView1Information = new System.Windows.Forms.DataGridView();
            this.textBox1Mail = new System.Windows.Forms.TextBox();
            this.label4Mail = new System.Windows.Forms.Label();
            this.textBox2Password = new System.Windows.Forms.TextBox();
            this.label5Password = new System.Windows.Forms.Label();
            this.button1Entrace = new System.Windows.Forms.Button();
            this.button4Registration = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1Information)).BeginInit();
            this.SuspendLayout();
            // 
            // button3Activ
            // 
            this.button3Activ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button3Activ.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3Activ.ForeColor = System.Drawing.Color.White;
            this.button3Activ.Location = new System.Drawing.Point(517, 85);
            this.button3Activ.Name = "button3Activ";
            this.button3Activ.Size = new System.Drawing.Size(240, 44);
            this.button3Activ.TabIndex = 11;
            this.button3Activ.Text = "Активности";
            this.button3Activ.UseVisualStyleBackColor = false;
            this.button3Activ.Click += new System.EventHandler(this.button3Activ_Click);
            // 
            // button2Event
            // 
            this.button2Event.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button2Event.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2Event.ForeColor = System.Drawing.Color.White;
            this.button2Event.Location = new System.Drawing.Point(517, 135);
            this.button2Event.Name = "button2Event";
            this.button2Event.Size = new System.Drawing.Size(240, 44);
            this.button2Event.TabIndex = 12;
            this.button2Event.Text = "Мероприятия";
            this.button2Event.UseVisualStyleBackColor = false;
            this.button2Event.Click += new System.EventHandler(this.button2Event_Click);
            // 
            // label3Heder
            // 
            this.label3Heder.AutoSize = true;
            this.label3Heder.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3Heder.ForeColor = System.Drawing.Color.Gray;
            this.label3Heder.Location = new System.Drawing.Point(105, 19);
            this.label3Heder.Name = "label3Heder";
            this.label3Heder.Size = new System.Drawing.Size(549, 25);
            this.label3Heder.TabIndex = 13;
            this.label3Heder.Text = "Конференция по информационной безопасности";
            // 
            // dataGridView1Information
            // 
            this.dataGridView1Information.BackgroundColor = System.Drawing.Color.Pink;
            this.dataGridView1Information.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1Information.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1Information.GridColor = System.Drawing.Color.Pink;
            this.dataGridView1Information.Location = new System.Drawing.Point(517, 214);
            this.dataGridView1Information.Name = "dataGridView1Information";
            this.dataGridView1Information.RowHeadersWidth = 20;
            this.dataGridView1Information.Size = new System.Drawing.Size(238, 154);
            this.dataGridView1Information.TabIndex = 14;
            // 
            // textBox1Mail
            // 
            this.textBox1Mail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1Mail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.textBox1Mail.Location = new System.Drawing.Point(12, 85);
            this.textBox1Mail.Multiline = true;
            this.textBox1Mail.Name = "textBox1Mail";
            this.textBox1Mail.Size = new System.Drawing.Size(326, 31);
            this.textBox1Mail.TabIndex = 15;
            // 
            // label4Mail
            // 
            this.label4Mail.AutoSize = true;
            this.label4Mail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4Mail.ForeColor = System.Drawing.Color.Red;
            this.label4Mail.Location = new System.Drawing.Point(12, 119);
            this.label4Mail.Name = "label4Mail";
            this.label4Mail.Size = new System.Drawing.Size(109, 18);
            this.label4Mail.TabIndex = 16;
            this.label4Mail.Text = "Введите почту";
            // 
            // textBox2Password
            // 
            this.textBox2Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2Password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.textBox2Password.Location = new System.Drawing.Point(12, 166);
            this.textBox2Password.Multiline = true;
            this.textBox2Password.Name = "textBox2Password";
            this.textBox2Password.PasswordChar = '*';
            this.textBox2Password.Size = new System.Drawing.Size(326, 35);
            this.textBox2Password.TabIndex = 17;
            // 
            // label5Password
            // 
            this.label5Password.AutoSize = true;
            this.label5Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5Password.ForeColor = System.Drawing.Color.Red;
            this.label5Password.Location = new System.Drawing.Point(12, 204);
            this.label5Password.Name = "label5Password";
            this.label5Password.Size = new System.Drawing.Size(120, 18);
            this.label5Password.TabIndex = 18;
            this.label5Password.Text = "Введите пароль";
            // 
            // button1Entrace
            // 
            this.button1Entrace.BackColor = System.Drawing.Color.Lime;
            this.button1Entrace.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1Entrace.ForeColor = System.Drawing.Color.White;
            this.button1Entrace.Location = new System.Drawing.Point(76, 246);
            this.button1Entrace.Name = "button1Entrace";
            this.button1Entrace.Size = new System.Drawing.Size(154, 51);
            this.button1Entrace.TabIndex = 19;
            this.button1Entrace.Text = "Вход";
            this.button1Entrace.UseVisualStyleBackColor = false;
            this.button1Entrace.Click += new System.EventHandler(this.button1Entrace_Click);
            // 
            // button4Registration
            // 
            this.button4Registration.BackColor = System.Drawing.Color.Lime;
            this.button4Registration.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4Registration.ForeColor = System.Drawing.Color.White;
            this.button4Registration.Location = new System.Drawing.Point(76, 329);
            this.button4Registration.Name = "button4Registration";
            this.button4Registration.Size = new System.Drawing.Size(154, 51);
            this.button4Registration.TabIndex = 20;
            this.button4Registration.Text = "Регистрация";
            this.button4Registration.UseVisualStyleBackColor = false;
            this.button4Registration.Click += new System.EventHandler(this.button4Registration_Click);
            // 
            // Authentication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button4Registration);
            this.Controls.Add(this.button1Entrace);
            this.Controls.Add(this.label5Password);
            this.Controls.Add(this.textBox2Password);
            this.Controls.Add(this.label4Mail);
            this.Controls.Add(this.textBox1Mail);
            this.Controls.Add(this.dataGridView1Information);
            this.Controls.Add(this.label3Heder);
            this.Controls.Add(this.button2Event);
            this.Controls.Add(this.button3Activ);
            this.Name = "Authentication";
            this.Text = "Authentication";
            this.Load += new System.EventHandler(this.Authentication_Load);
            this.Click += new System.EventHandler(this.Authentication_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1Information)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3Activ;
        private System.Windows.Forms.Button button2Event;
        private System.Windows.Forms.Label label3Heder;
        private System.Windows.Forms.DataGridView dataGridView1Information;
        private System.Windows.Forms.TextBox textBox1Mail;
        private System.Windows.Forms.Label label4Mail;
        private System.Windows.Forms.TextBox textBox2Password;
        private System.Windows.Forms.Label label5Password;
        private System.Windows.Forms.Button button1Entrace;
        private System.Windows.Forms.Button button4Registration;
    }
}

