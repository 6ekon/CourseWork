using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWork
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private void regbut_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegForm regform = new RegForm();
            regform.Show();
        }

        private void enterbut_Click(object sender, EventArgs e)
        {
            int count = 0;
            string login, password;

            login = LoginT.Text;
            password = PasswordT.Text;

            for (int i = 0; i < ClassforClass.K; i++)
            {
                if (login == ClassforClass.passwordcheck[i].login && password == ClassforClass.passwordcheck[i].password)
                {
                    ClassforClass.D = i;
                    count++;

                    this.Hide();
                    MainForm mainform = new MainForm();
                    mainform.Show();
                    break;
                }
            }
            if (count == 0)
            {
                MessageBox.Show("При вводе вы допустили ошибку или такой пользователь не существует.");
            }
            LoginT.Clear();
            PasswordT.Clear();
        }
    }
}
