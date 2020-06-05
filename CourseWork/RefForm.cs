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
    public partial class RefForm : Form
    {
        public RefForm()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mf = new MainForm();
            mf.Show();
        }

        private void destination_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            try
            {
                int count = 0;
                string destination = textBox1.Text;
                for (int i = 0; i < ClassforClass.N; i++)
                {
                    if (destination == ClassforClass.busschedules[i].destination)
                    {
                        richTextBox1.Text = $"Справка о автобусе в {destination}\n";
                        richTextBox1.Text += $"Место назначения {ClassforClass.busschedules[i].destination}\n";
                        richTextBox1.Text += $"Номер автобуса {ClassforClass.busschedules[i].busnum}\n";
                        richTextBox1.Text += $"Время отправления {ClassforClass.busschedules[i].departuretime}\n";
                        richTextBox1.Text += $"Время прибытия {ClassforClass.busschedules[i].arrivetime}\n";
                        richTextBox1.Text += $"Цена билета {ClassforClass.busschedules[i].price}\n\n";
                        count++;
                    }
                }
                if (count == 0)
                    MessageBox.Show("Данного маршрута не существует!");
            }
            catch
            {
                MessageBox.Show("Введите корректный маршрут!");
            }
        }

        private void arrivetime_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            try
            {
                int count = 0;
                string busnum = textBox4.Text;
                for (int i = 0; i < ClassforClass.N; i++)
                {
                    if (busnum == ClassforClass.busschedules[i].busnum)
                    {
                        richTextBox1.Text = "Справка о времени прибытия";
                        richTextBox1.Text += $"Место назначения {ClassforClass.busschedules[i].destination}\n";
                        richTextBox1.Text += $"Номер автобуса {ClassforClass.busschedules[i].busnum}\n";
                        richTextBox1.Text += $"Время отправления {ClassforClass.busschedules[i].departuretime}\n";
                        richTextBox1.Text += $"Время прибытия {ClassforClass.busschedules[i].arrivetime}\n";
                        richTextBox1.Text += $"Цена билета {ClassforClass.busschedules[i].price}\n\n";
                        count++;
                    }
                }
                if (count == 0)
                    MessageBox.Show("Данного маршрута не существует!");
            }
            catch
            {
                MessageBox.Show("Введите корректный маршрут!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            try
            {
                int count = 0;
                string destination = textBox6.Text;
                for (int i = 0; i < ClassforClass.N; i++)
                {
                    if (destination == ClassforClass.busschedules[i].destination)
                    {
                        richTextBox1.Text = "Справка о времени отправления";
                        richTextBox1.Text += $"Место назначения {ClassforClass.busschedules[i].destination}\n";
                        richTextBox1.Text += $"Номер автобуса {ClassforClass.busschedules[i].busnum}\n";
                        richTextBox1.Text += $"Время отправления {ClassforClass.busschedules[i].departuretime}\n";
                        richTextBox1.Text += $"Время прибытия {ClassforClass.busschedules[i].arrivetime}\n";
                        richTextBox1.Text += $"Цена билета {ClassforClass.busschedules[i].price}\n\n";
                        count++;
                    }
                }
                if (count == 0)
                    MessageBox.Show("Данного маршрута не существует!");
            }
            catch
            {
                MessageBox.Show("Введите корректный маршрут!");
            }
        }
    }
}
