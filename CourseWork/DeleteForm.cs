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
    public partial class DeleteForm : Form
    {
        ClassforClass cc = new ClassforClass();
        public DeleteForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string destination = textBox1.Text;
                for (int i = 0; i < ClassforClass.N; i++)
                {
                    if (destination == ClassforClass.busschedules[i].destination)
                        cc.Delete(i);
                }
                MessageBox.Show("Удалено!");
            }
            catch
            {
                MessageBox.Show("Введите корректный маршрут!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cc.Clear();
            MessageBox.Show("Информационная база очищена!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainform = new MainForm();
            mainform.Show();
        }

        private void DeleteForm_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }
    }
}
