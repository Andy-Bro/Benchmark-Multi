using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

using System.Diagnostics;

namespace Benchmark_Multi
{
    public class Benchmark : MainWindow
    {
        public static int TurnsAllThreads = 1;

        public int GetTurnsAllThreads()
        {
            return TurnsAllThreads;
        }

        public void SetTurnsAllThreads()
        {
            TurnsAllThreads += 1;
        }

        public static void ThreadPower()
        {
            Thread.Sleep(100);

            int testValue;

            while (TurnsAllThreads < 50)
            {
                testValue = 0;
                for (int i = 0; i < int.MaxValue; i++)
                {
                    testValue += i;
                }

                TurnsAllThreads += 1;
            }
        }

        public void StartBench()
        {
            Thread tPower0 = new Thread(new ThreadStart(ThreadPower));
            Thread tPower1 = new Thread(new ThreadStart(ThreadPower));
            Thread tPower2 = new Thread(new ThreadStart(ThreadPower));
            Thread tPower3 = new Thread(new ThreadStart(ThreadPower));
            Thread tPower4 = new Thread(new ThreadStart(ThreadPower));
            Thread tPower5 = new Thread(new ThreadStart(ThreadPower));
            Thread tPower6 = new Thread(new ThreadStart(ThreadPower));
            Thread tPower7 = new Thread(new ThreadStart(ThreadPower));
            Thread tPower8 = new Thread(new ThreadStart(ThreadPower));
            Thread tPower9 = new Thread(new ThreadStart(ThreadPower));
            Thread tPower10 = new Thread(new ThreadStart(ThreadPower));
            Thread tPower11 = new Thread(new ThreadStart(ThreadPower));

            tPower0.Start();
            tPower1.Start();
            tPower2.Start();
            tPower3.Start();
            tPower4.Start();
            tPower5.Start();
            tPower6.Start();
            tPower7.Start();
            tPower8.Start();
            tPower9.Start();
            tPower10.Start();
            tPower11.Start();
        }
    }
}
