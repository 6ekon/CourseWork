namespace CourseWork
{
    partial class LoginForm
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LoginT = new System.Windows.Forms.TextBox();
            this.PasswordT = new System.Windows.Forms.TextBox();
            this.enterbut = new System.Windows.Forms.Button();
            this.regbut = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(183, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Авторизация";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::CourseWork.Properties.Resources.pas;
            this.pictureBox2.Location = new System.Drawing.Point(142, 241);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(62, 70);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::CourseWork.Properties.Resources.login;
            this.pictureBox1.Location = new System.Drawing.Point(142, 137);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(62, 64);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // LoginT
            // 
            this.LoginT.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginT.Location = new System.Drawing.Point(210, 152);
            this.LoginT.Name = "LoginT";
            this.LoginT.Size = new System.Drawing.Size(189, 35);
            this.LoginT.TabIndex = 4;
            // 
            // PasswordT
            // 
            this.PasswordT.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordT.Location = new System.Drawing.Point(210, 262);
            this.PasswordT.Name = "PasswordT";
            this.PasswordT.Size = new System.Drawing.Size(189, 35);
            this.PasswordT.TabIndex = 5;
            this.PasswordT.UseSystemPasswordChar = true;
            // 
            // enterbut
            // 
            this.enterbut.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.enterbut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.enterbut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.enterbut.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.enterbut.Location = new System.Drawing.Point(223, 364);
            this.enterbut.Name = "enterbut";
            this.enterbut.Size = new System.Drawing.Size(145, 56);
            this.enterbut.TabIndex = 6;
            this.enterbut.Text = "Войти";
            this.enterbut.UseVisualStyleBackColor = false;
            this.enterbut.Click += new System.EventHandler(this.enterbut_Click);
            // 
            // regbut
            // 
            this.regbut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.regbut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.regbut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.regbut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.regbut.Location = new System.Drawing.Point(414, 373);
            this.regbut.Name = "regbut";
            this.regbut.Size = new System.Drawing.Size(146, 39);
            this.regbut.TabIndex = 7;
            this.regbut.Text = "Регистрация";
            this.regbut.UseVisualStyleBackColor = true;
            this.regbut.Click += new System.EventHandler(this.regbut_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CourseWork.Properties.Resources.vokzal;
            this.ClientSize = new System.Drawing.Size(603, 450);
            this.Controls.Add(this.regbut);
            this.Controls.Add(this.enterbut);
            this.Controls.Add(this.PasswordT);
            this.Controls.Add(this.LoginT);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox LoginT;
        private System.Windows.Forms.TextBox PasswordT;
        private System.Windows.Forms.Button enterbut;
        private System.Windows.Forms.Button regbut;
    }
}