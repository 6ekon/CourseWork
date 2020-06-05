using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWork
{
    public partial class RegForm : Form
    {
        ClassforClass classforclass = new ClassforClass();
        public RegForm()
        {
            InitializeComponent();
        }

        private void RegForm_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private void regestration_Click(object sender, EventArgs e)
        {
            string name, surname, login, password;
            int count = 0;
            try
            {
                name = rname.Text;
                surname = rsurname.Text;
                login = rlog.Text;
                password = rpassword.Text;

                for (int i = 0; i < ClassforClass.K; i++)
                {
                    if (login == ClassforClass.passwordcheck[i].login)
                        count++;
                }
                if (count != 0)
                {
                    MessageBox.Show("Данный пользователь уже существует!");
                }
                else
                {
                    if (name.Length >= 2 && surname.Length >= 2 && login.Length >= 2 && password.Length >= 2)
                    {
                        ClassforClass.K++;
                        classforclass.ArrayResPasswordCheck();
                        ClassforClass.passwordcheck[ClassforClass.D].name = name;
                        ClassforClass.passwordcheck[ClassforClass.D].surname = surname;
                        ClassforClass.passwordcheck[ClassforClass.D].login = login;
                        ClassforClass.passwordcheck[ClassforClass.D].password = password;
                        ClassforClass.D++;

                        this.Hide();
                        MainForm mainform = new MainForm();
                        mainform.Show();
                    }
                    else 
                    {
                        MessageBox.Show("Недопустимая длина введенной информации!");
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
                MessageBox.Show("Введите корректные данные!");
            }
            rname.Clear();
            rsurname.Clear();
            rlog.Clear();
            rpassword.Clear();
        }

        private void backbut_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginform = new LoginForm();
            loginform.Show();
        }
        
    }
}
