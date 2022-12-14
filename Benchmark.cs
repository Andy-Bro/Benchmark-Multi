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
        public static int TurnsAllThreads = 0;

        public static int MaxTurnsAllThreads { get; set; }
        public static int IncrementTop { get; set; }
        public static int StringSearchNumber { get; set; }
        public static int LogicalProcessors { get; set; }


        public Benchmark(int _maxTurnsAllThreads, int _incrementTop, int _stringSearchNumber, int _logicalProcessors)
        {
            MaxTurnsAllThreads = _maxTurnsAllThreads;
            IncrementTop = _incrementTop;
            StringSearchNumber = _stringSearchNumber;

            LogicalProcessors = _logicalProcessors;

            TurnsAllThreads = 0;
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

        public static void ThreadPowerStringSearch()
        {
            Thread.Sleep(100);

            int upToIncrement = StringSearchNumber;
            string searchFor = "Hallo World " + StringSearchNumber;
            bool findString = false;

            while (TurnsAllThreads < MaxTurnsAllThreads)
            {
                for (int i = 0; i < upToIncrement; i++)
                {
                    if (searchFor == "Hallo World " +i)
                    {
                        findString = true;
                    }
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
            Thread tPower11 = new Thread(new ThreadStart(ThreadPowerIncrement));
            Thread tPower12 = new Thread(new ThreadStart(ThreadPowerIncrement));
            Thread tPower13 = new Thread(new ThreadStart(ThreadPowerIncrement));
            Thread tPower14 = new Thread(new ThreadStart(ThreadPowerIncrement));
            Thread tPower15 = new Thread(new ThreadStart(ThreadPowerIncrement));
            Thread tPower16 = new Thread(new ThreadStart(ThreadPowerIncrement));
            Thread tPower17 = new Thread(new ThreadStart(ThreadPowerIncrement));
            Thread tPower18 = new Thread(new ThreadStart(ThreadPowerIncrement));
            Thread tPower19 = new Thread(new ThreadStart(ThreadPowerIncrement));
            Thread tPower20 = new Thread(new ThreadStart(ThreadPowerIncrement));
            Thread tPower21 = new Thread(new ThreadStart(ThreadPowerIncrement));
            Thread tPower22 = new Thread(new ThreadStart(ThreadPowerIncrement));



            if (LogicalProcessors == 1)
            {
                tPower0.Start();
            }
            else if (LogicalProcessors == 2)
            {
                tPower0.Start();
                tPower1.Start();
            }
            else if (LogicalProcessors == 4)
            {
                tPower0.Start();
                tPower1.Start();
                tPower2.Start();
            }
            else if (LogicalProcessors == 8)
            {
                tPower0.Start();
                tPower1.Start();
                tPower2.Start();
                tPower3.Start();
                tPower4.Start();
                tPower5.Start();
                tPower6.Start();
            }
            else if (LogicalProcessors == 12)
            {
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
            else if (LogicalProcessors >= 16 && LogicalProcessors < 24)
            {
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
                tPower12.Start();
                tPower13.Start();
                tPower14.Start();
            }
            else if (LogicalProcessors >= 24)
            {
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
                tPower12.Start();
                tPower13.Start();
                tPower14.Start();
                tPower15.Start();
                tPower16.Start();
                tPower17.Start();
                tPower18.Start();
                tPower19.Start();
                tPower20.Start();
                tPower21.Start();
                tPower22.Start();
            }
        }

        public void StartBenchStringSearch()
        {
            Thread tPower0 = new Thread(new ThreadStart(ThreadPowerStringSearch));
            Thread tPower1 = new Thread(new ThreadStart(ThreadPowerStringSearch));
            Thread tPower2 = new Thread(new ThreadStart(ThreadPowerStringSearch));
            Thread tPower3 = new Thread(new ThreadStart(ThreadPowerStringSearch));
            Thread tPower4 = new Thread(new ThreadStart(ThreadPowerStringSearch));
            Thread tPower5 = new Thread(new ThreadStart(ThreadPowerStringSearch));
            Thread tPower6 = new Thread(new ThreadStart(ThreadPowerStringSearch));
            Thread tPower7 = new Thread(new ThreadStart(ThreadPowerStringSearch));
            Thread tPower8 = new Thread(new ThreadStart(ThreadPowerStringSearch));
            Thread tPower9 = new Thread(new ThreadStart(ThreadPowerStringSearch));
            Thread tPower10 = new Thread(new ThreadStart(ThreadPowerStringSearch));
            Thread tPower11 = new Thread(new ThreadStart(ThreadPowerStringSearch));
            Thread tPower12 = new Thread(new ThreadStart(ThreadPowerStringSearch));
            Thread tPower13 = new Thread(new ThreadStart(ThreadPowerStringSearch));
            Thread tPower14 = new Thread(new ThreadStart(ThreadPowerStringSearch));
            Thread tPower15 = new Thread(new ThreadStart(ThreadPowerStringSearch));
            Thread tPower16 = new Thread(new ThreadStart(ThreadPowerStringSearch));
            Thread tPower17 = new Thread(new ThreadStart(ThreadPowerStringSearch));
            Thread tPower18 = new Thread(new ThreadStart(ThreadPowerStringSearch));
            Thread tPower19 = new Thread(new ThreadStart(ThreadPowerStringSearch));
            Thread tPower20 = new Thread(new ThreadStart(ThreadPowerStringSearch));
            Thread tPower21 = new Thread(new ThreadStart(ThreadPowerStringSearch));
            Thread tPower22 = new Thread(new ThreadStart(ThreadPowerStringSearch));



            if (LogicalProcessors == 1)
            {
                tPower0.Start();
            }
            else if (LogicalProcessors == 2)
            {
                tPower0.Start();
                tPower1.Start();
            }
            else if (LogicalProcessors == 4)
            {
                tPower0.Start();
                tPower1.Start();
                tPower2.Start();
            }
            else if (LogicalProcessors == 8)
            {
                tPower0.Start();
                tPower1.Start();
                tPower2.Start();
                tPower3.Start();
                tPower4.Start();
                tPower5.Start();
                tPower6.Start();
            }
            else if (LogicalProcessors == 12)
            {
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
            else if (LogicalProcessors >= 16 && LogicalProcessors < 24)
            {
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
                tPower12.Start();
                tPower13.Start();
                tPower14.Start();
            }
            else if (LogicalProcessors >= 24)
            {
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
                tPower12.Start();
                tPower13.Start();
                tPower14.Start();
                tPower15.Start();
                tPower16.Start();
                tPower17.Start();
                tPower18.Start();
                tPower19.Start();
                tPower20.Start();
                tPower21.Start();
                tPower22.Start();
            }
        }
    }
}
