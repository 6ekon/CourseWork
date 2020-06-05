namespace CourseWork
{
    partial class MainForm
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
            this.createNewBase = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.referencebut = new System.Windows.Forms.Button();
            this.editText = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.savebut = new System.Windows.Forms.Button();
            this.openbut = new System.Windows.Forms.Button();
            this.deletebut = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // createNewBase
            // 
            this.createNewBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.createNewBase.Location = new System.Drawing.Point(33, 103);
            this.createNewBase.Name = "createNewBase";
            this.createNewBase.Size = new System.Drawing.Size(250, 49);
            this.createNewBase.TabIndex = 0;
            this.createNewBase.Text = "Создание новой информационной базы";
            this.createNewBase.UseVisualStyleBackColor = true;
            this.createNewBase.Click += new System.EventHandler(this.createNewBase_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(27, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Меню Управления";
            // 
            // referencebut
            // 
            this.referencebut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.referencebut.Location = new System.Drawing.Point(33, 268);
            this.referencebut.Name = "referencebut";
            this.referencebut.Size = new System.Drawing.Size(250, 70);
            this.referencebut.TabIndex = 2;
            this.referencebut.Text = "Выдача справок и информации о всех автобусах";
            this.referencebut.UseVisualStyleBackColor = true;
            this.referencebut.Click += new System.EventHandler(this.referencebut_Click);
            // 
            // editText
            // 
            this.editText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editText.Location = new System.Drawing.Point(33, 158);
            this.editText.Name = "editText";
            this.editText.Size = new System.Drawing.Size(250, 49);
            this.editText.TabIndex = 4;
            this.editText.Text = "Редактирование информационной базы";
            this.editText.UseVisualStyleBackColor = true;
            this.editText.Click += new System.EventHandler(this.editText_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // savebut
            // 
            this.savebut.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.savebut.Location = new System.Drawing.Point(86, 387);
            this.savebut.Name = "savebut";
            this.savebut.Size = new System.Drawing.Size(90, 42);
            this.savebut.TabIndex = 14;
            this.savebut.Text = "Save";
            this.savebut.UseVisualStyleBackColor = true;
            this.savebut.Click += new System.EventHandler(this.savebut_Click);
            // 
            // openbut
            // 
            this.openbut.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.openbut.Location = new System.Drawing.Point(181, 387);
            this.openbut.Name = "openbut";
            this.openbut.Size = new System.Drawing.Size(102, 42);
            this.openbut.TabIndex = 15;
            this.openbut.Text = "Open";
            this.openbut.UseVisualStyleBackColor = true;
            this.openbut.Click += new System.EventHandler(this.openbut_Click);
            // 
            // deletebut
            // 
            this.deletebut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deletebut.Location = new System.Drawing.Point(33, 213);
            this.deletebut.Name = "deletebut";
            this.deletebut.Size = new System.Drawing.Size(250, 49);
            this.deletebut.TabIndex = 16;
            this.deletebut.Text = "Удаление данных";
            this.deletebut.UseVisualStyleBackColor = true;
            this.deletebut.Click += new System.EventHandler(this.deletebut_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::CourseWork.Properties.Resources.back;
            this.button1.Location = new System.Drawing.Point(12, 378);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(68, 60);
            this.button1.TabIndex = 13;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(12, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 30);
            this.button2.TabIndex = 17;
            this.button2.Text = "О программе";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.deletebut);
            this.Controls.Add(this.openbut);
            this.Controls.Add(this.savebut);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.editText);
            this.Controls.Add(this.referencebut);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.createNewBase);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button createNewBase;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button referencebut;
        private System.Windows.Forms.Button editText;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button savebut;
        private System.Windows.Forms.Button openbut;
        private System.Windows.Forms.Button deletebut;
        private System.Windows.Forms.Button button2;
    }
}