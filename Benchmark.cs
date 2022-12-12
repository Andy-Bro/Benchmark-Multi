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
    public class Benchmark
    {
        public static int TurnsAllThreads = 1;

        public static int MaxTurnsAllThreads { get; set; }
        public static int IncrementTop { get; set; }

        public Benchmark(int _maxTurnsAllThreads, int _incrementTop)
        {
            MaxTurnsAllThreads = _maxTurnsAllThreads;
            IncrementTop = _incrementTop;

            TurnsAllThreads = 1;
        }

        public int GetTurnsAllThreads()
        {
            return TurnsAllThreads;
        }

        public static void ThreadPowerIncrement()
        {
            Thread.Sleep(100);

            int upToIncrement = IncrementTop;
            while (TurnsAllThreads < MaxTurnsAllThreads)
            {
                for (int i = 0; i < upToIncrement; i++)
                {

                }

                TurnsAllThreads += 1;
            }
        }

        public void StartBenchIncrement()
        {
            Thread tPower0 = new Thread(new ThreadStart(ThreadPowerIncrement));
            Thread tPower1 = new Thread(new ThreadStart(ThreadPowerIncrement));
            Thread tPower2 = new Thread(new ThreadStart(ThreadPowerIncrement));
            Thread tPower3 = new Thread(new ThreadStart(ThreadPowerIncrement));
            Thread tPower4 = new Thread(new ThreadStart(ThreadPowerIncrement));
            Thread tPower5 = new Thread(new ThreadStart(ThreadPowerIncrement));
            Thread tPower6 = new Thread(new ThreadStart(ThreadPowerIncrement));
            Thread tPower7 = new Thread(new ThreadStart(ThreadPowerIncrement));
            Thread tPower8 = new Thread(new ThreadStart(ThreadPowerIncrement));
            Thread tPower9 = new Thread(new ThreadStart(ThreadPowerIncrement));
            Thread tPower10 = new Thread(new ThreadStart(ThreadPowerIncrement));
            // Thread tPower11 = new Thread(new ThreadStart(ThreadPowerIncrement));

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
            // tPower11.Start();
        }
    }
}
