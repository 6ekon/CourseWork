using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWork
{
    class WriteRead
    {
        public void Write()
        {
            SaveFileDialog savefiledialog = new SaveFileDialog();
            if (savefiledialog.ShowDialog() == DialogResult.OK)
            {
                string filename = savefiledialog.FileName;
                FileStream fs = new FileStream(filename, FileMode.OpenOrCreate, FileAccess.Write);
                BinaryWriter bw = new BinaryWriter(fs, Encoding.UTF8);
                bw.Write(ClassforClass.N);
                bw.Write(ClassforClass.M);
                for (int i = 0; i < ClassforClass.N; i++)
                {
                    bw.Write(ClassforClass.busschedules[i].arrivetime);
                    bw.Write(ClassforClass.busschedules[i].busnum);
                    bw.Write(ClassforClass.busschedules[i].destination);
                    bw.Write(ClassforClass.busschedules[i].departuretime);
                    bw.Write(ClassforClass.busschedules[i].price);
                }
                MessageBox.Show("Данные сохранены");
                bw.Close();
                fs.Close();
            }


        }

        public void Read()
        {
            ClassforClass cc = new ClassforClass();
            OpenFileDialog openfiledialog = new OpenFileDialog();
            if (openfiledialog.ShowDialog() == DialogResult.OK)
            {
                string filename = openfiledialog.FileName;
                FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs, Encoding.UTF8);
                ClassforClass.N = br.ReadInt32();
                ClassforClass.M = br.ReadInt32();
                cc.ArrayResBusSchedule();
                for (int i = 0; i < ClassforClass.N; i++)
                {
                    ClassforClass.busschedules[i].arrivetime = br.ReadString();
                    ClassforClass.busschedules[i].busnum = br.ReadString();
                    ClassforClass.busschedules[i].destination = br.ReadString();
                    ClassforClass.busschedules[i].departuretime = br.ReadString();
                    ClassforClass.busschedules[i].price = br.ReadInt32();
                }
                MessageBox.Show("Данные загружены");
                br.Close();
                fs.Close();
            }

        }
    }
}
