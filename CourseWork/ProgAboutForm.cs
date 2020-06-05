using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWork
{
    public partial class ProgAboutForm : Form
    {
        public ProgAboutForm()
        {
            InitializeComponent();
            faq.Text = "Данная программа позволяет вам организовать собственную информационную базу.\n\nДля начала работы вам требуется войти в свою учетную запись, если она имеется или зарегистрировать ее.";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            faq.Text = "Для начала вам нужно войти в свою учетную запись, используя поля: Логин и Пароль. Требуется указать данные которые вы вводили при Регистрации. Затем вы перейдете в Меню Управления информационной базой! В данном разделе вы можете создавать, редактировать, удалять и получать все нужные вам сведения.";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            faq.Text = "В данном разделе вы можете создать нужную вам базу, заполнив соответствующие формы!";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            faq.Text = "В данном разделе вы можете отредактировать созданную вами ранее инфомрационную базу и внести нужные вам корректировки, нажав на кнопку сохранить! Также вы можете вывести на экран информацию по всей базе.";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            faq.Text = "В данном разделе вы можете удалить ненужную вам инфомрацию по нажатию на кнопку Удалить. Или же очистить всю информацию о прошедшем рейсе, введя конечную точку маршрута в соответствующее окно.";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            faq.Text = "В данном разделе вы можете получить справку: о всех автобусах в нужном вам направлении, о времени их прибытия и отбытия";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mf = new MainForm();
            mf.Show();
        }

        private void ProgAboutForm_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }
    }
}
