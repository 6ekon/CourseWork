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
    public partial class EditForm : Form
    {
        WriteRead wr = new WriteRead();
        int R;
        public EditForm()
        {
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            int count = 0;
            string destination = EnterField.Text;
            for (int i = 0; i < ClassforClass.N; i++)
            {
                if (destination == ClassforClass.busschedules[i].destination)
                {
                    R = i;
                    textBox1.Text = ClassforClass.busschedules[R].destination;
                    textBox2.Text = Convert.ToString(ClassforClass.busschedules[R].busnum);
                    textBox3.Text = Convert.ToString(ClassforClass.busschedules[R].departuretime);
                    textBox4.Text = Convert.ToString(ClassforClass.busschedules[R].arrivetime);
                    textBox5.Text = Convert.ToString(ClassforClass.busschedules[R].price);
                    count++;
                }
            }
            if (count == 0)
            {
                MessageBox.Show("Данный маршрут не существует.");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string destination, busnum, departuretime, arrivetime;
            double price;
            try
            {
                destination = textBox1.Text;
                busnum = textBox2.Text;
                departuretime = textBox3.Text;
                arrivetime = textBox4.Text;
                price = Convert.ToDouble(textBox5.Text);
                if (destination.Length >= 2 && busnum.Length >= 0 && price > 0 && departuretime.Length >= 0 && arrivetime.Length > 0 && price > 0)
                {
                    ClassforClass.busschedules[R].destination = destination;
                    ClassforClass.busschedules[R].busnum = busnum;
                    ClassforClass.busschedules[R].departuretime = departuretime;
                    ClassforClass.busschedules[R].arrivetime = arrivetime;
                    ClassforClass.busschedules[R].price = price;
                    MessageBox.Show("Данные перезаписаны!");
                }
                else
                {
                    MessageBox.Show("Недопустимая длина введенной информации!");
                }
            }
            catch
            {
                MessageBox.Show("Введите корректные данные!");
            }
        }

        private void savebut_Click(object sender, EventArgs e)
        {
            wr.Write();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы хотите вернуться назад? (несохраненная информация будет потеряна)", "", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                MainForm mainform = new MainForm();
                mainform.Show();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                int count = 0;
                string destination = textBox7.Text;
                for (int i = 0; i < ClassforClass.N; i++)
                {
                    if (destination == ClassforClass.busschedules[i].destination)
                    {
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
