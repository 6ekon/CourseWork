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
    public partial class CreateNewbase : Form
    {
        public CreateNewbase()
        {
            InitializeComponent();
        }

        private void CreateNewbase_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private void CreateBase_Click(object sender, EventArgs e)
        {
            ClassforClass classforclass = new ClassforClass();
            string destination, busnum, departuretime, arrivetime;
            double price;
            int count = 0;
            try
            {
                destination = textBox1.Text;
                busnum = textBox2.Text;
                departuretime = textBox3.Text; 
                arrivetime = textBox4.Text;
                price = Convert.ToDouble(textBox5.Text);
                
                for (int i = 0; i < ClassforClass.N; i++)
                {
                    if (busnum == ClassforClass.busschedules[i].busnum)
                        count++;
                }
                if (count != 0)
                {
                    MessageBox.Show("Данный маршрут уже создан!");
                }
                else
                {
                    if (destination.Length >= 1 && busnum.Length > 0 && departuretime.Length > 0 && arrivetime.Length > 0 && price > 0)
                    {

                        ClassforClass.N++;
                        classforclass.ArrayResBusSchedule();
                        ClassforClass.busschedules[ClassforClass.M].destination = destination;
                        ClassforClass.busschedules[ClassforClass.M].busnum = busnum;
                        ClassforClass.busschedules[ClassforClass.M].departuretime = departuretime;
                        ClassforClass.busschedules[ClassforClass.M].arrivetime = arrivetime;
                        ClassforClass.busschedules[ClassforClass.M].price = price;
                        ClassforClass.M++;

                        MessageBox.Show("Данные сохранены!");
                    }
                    else
                    {
                        MessageBox.Show("Недопустимая длина введенной информации!");
                    }
                }
            }
            catch //(Exception exc)
            {
                //MessageBox.Show(exc.Message);
                MessageBox.Show("Введите корректные данные!");
            }
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainform = new MainForm();
            mainform.Show();
        }
    }
}
