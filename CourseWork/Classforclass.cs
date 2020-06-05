using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork
{
    public struct PasswordCheck
    {
        public string name;
        public string surname;
        public string login;
        public string password;
    }

    public struct BusSchedule
    {
        public string destination;
        public string busnum;
        public string departuretime;
        public string arrivetime;
        public double price;
    }

    class ClassforClass
    {
        //BusSchedule bs = new BusSchedule();
        public static int N = 0, M = N;
        public static BusSchedule[] busschedules = new BusSchedule[N];
        public static int K = 0, D = K;
        public static PasswordCheck[] passwordcheck = new PasswordCheck[K];

        public void ArrayResBusSchedule()
        {
            Array.Resize(ref busschedules, N);
        }

        public void ArrayResPasswordCheck()
        {
            Array.Resize(ref passwordcheck, K);
        }

        public void Delete(int actual)
        {
            int NN = N - 1;
            BusSchedule[] TempArray = new BusSchedule[NN];
            Array.Copy(busschedules, 0, TempArray, 0, actual);
            Array.Copy(busschedules, actual + 1, TempArray, actual, N - actual - 1);
            Clear();
            N = NN;
            M = N;
            ArrayResBusSchedule();
            Array.Copy(TempArray, 0, busschedules, 0, N);
            Array.Clear(TempArray, 0, N);
        }

        public void Clear()
        {
            Array.Clear(busschedules, 0, N);
            N = 0;
            M = 0;
        }
    }
}
