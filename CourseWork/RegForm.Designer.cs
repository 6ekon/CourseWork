namespace CourseWork
{
    partial class RegForm
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
            this.rlog = new System.Windows.Forms.TextBox();
            this.rname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rsurname = new System.Windows.Forms.TextBox();
            this.regestration = new System.Windows.Forms.Button();
            this.rpassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.backbut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rlog
            // 
            this.rlog.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rlog.Location = new System.Drawing.Point(367, 180);
            this.rlog.Name = "rlog";
            this.rlog.Size = new System.Drawing.Size(189, 35);
            this.rlog.TabIndex = 12;
            // 
            // rname
            // 
            this.rname.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rname.Location = new System.Drawing.Point(85, 180);
            this.rname.Name = "rname";
            this.rname.Size = new System.Drawing.Size(189, 35);
            this.rname.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(207, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 39);
            this.label2.TabIndex = 8;
            this.label2.Text = "Регистрация";
            // 
            // rsurname
            // 
            this.rsurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rsurname.Location = new System.Drawing.Point(85, 251);
            this.rsurname.Name = "rsurname";
            this.rsurname.Size = new System.Drawing.Size(189, 35);
            this.rsurname.TabIndex = 15;
            // 
            // regestration
            // 
            this.regestration.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.regestration.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.regestration.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.regestration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.regestration.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.regestration.ForeColor = System.Drawing.SystemColors.ControlText;
            this.regestration.Location = new System.Drawing.Point(212, 310);
            this.regestration.Name = "regestration";
            this.regestration.Size = new System.Drawing.Size(229, 39);
            this.regestration.TabIndex = 14;
            this.regestration.Text = "Зарегестрироваться";
            this.regestration.UseVisualStyleBackColor = false;
            this.regestration.Click += new System.EventHandler(this.regestration_Click);
            // 
            // rpassword
            // 
            this.rpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rpassword.Location = new System.Drawing.Point(367, 251);
            this.rpassword.Name = "rpassword";
            this.rpassword.Size = new System.Drawing.Size(189, 35);
            this.rpassword.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(103, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 25);
            this.label1.TabIndex = 17;
            this.label1.Text = "Введите Имя";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(76, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(213, 25);
            this.label3.TabIndex = 18;
            this.label3.Text = "Введите Фамилию";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(376, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 25);
            this.label4.TabIndex = 19;
            this.label4.Text = "Введите Логин";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(367, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(189, 25);
            this.label5.TabIndex = 20;
            this.label5.Text = "Введите Пароль";
            // 
            // backbut
            // 
            this.backbut.BackgroundImage = global::CourseWork.Properties.Resources.back;
            this.backbut.Location = new System.Drawing.Point(12, 12);
            this.backbut.Name = "backbut";
            this.backbut.Size = new System.Drawing.Size(72, 63);
            this.backbut.TabIndex = 21;
            this.backbut.UseVisualStyleBackColor = true;
            this.backbut.Click += new System.EventHandler(this.backbut_Click);
            // 
            // RegForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(654, 389);
            this.Controls.Add(this.backbut);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rpassword);
            this.Controls.Add(this.rsurname);
            this.Controls.Add(this.regestration);
            this.Controls.Add(this.rlog);
            this.Controls.Add(this.rname);
            this.Controls.Add(this.label2);
            this.Name = "RegForm";
            this.Text = "RegForm";
            this.Load += new System.EventHandler(this.RegForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox rlog;
        private System.Windows.Forms.TextBox rname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox rsurname;
        private System.Windows.Forms.Button regestration;
        private System.Windows.Forms.TextBox rpassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button backbut;
    }
}