using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWork
{
    public partial class MainForm : Form
    {
        WriteRead wr = new WriteRead();

        public MainForm()
        {
            InitializeComponent();
            openFileDialog1.Filter = "Text files(.txt)|.txt|All files(.)|.";
            saveFileDialog1.Filter = "Text files(.txt)|.txt|All files(.)|.";
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private void createNewBase_Click(object sender, EventArgs e)
        {
            this.Hide();
            CreateNewbase createnewbase = new CreateNewbase();
            createnewbase.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginform = new LoginForm();
            loginform.Show();
        }

        private void savebut_Click(object sender, EventArgs e)
        {
            wr.Write();
        }

        private void openbut_Click(object sender, EventArgs e)
        {
            wr.Read();
        }

        private void editText_Click(object sender, EventArgs e)
        {
            this.Hide();
            EditForm editform = new EditForm();
            editform.Show();
        }

        private void referencebut_Click(object sender, EventArgs e)
        {
            this.Hide();
            RefForm refForm = new RefForm();
            refForm.Show();
        }

        private void deletebut_Click(object sender, EventArgs e)
        {
            this.Hide();
            DeleteForm delete = new DeleteForm();
            delete.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            ProgAboutForm faq = new ProgAboutForm();
            faq.Show();
        }
    }
}
