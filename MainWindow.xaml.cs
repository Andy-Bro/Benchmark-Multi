using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using System.Diagnostics;
using System.Threading;
using System.Windows.Media.Animation;

namespace Benchmark_Multi
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // ------------ Options ------------
        private int maxTurns = 800;
        private int incrementTop = 100000000;
        private int searchValueString = 1000000;

        private int logicalProcessors = Environment.ProcessorCount;

        private double swBenchIncrement = 0;
        private double swBenchStringSearch = 0;
        

        public MainWindow()
        {
            InitializeComponent();

            Trace.WriteLine("Number Of Logical Processors: " + logicalProcessors.ToString());
        }



        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            /*            ProgressBar progbar = new ProgressBar();
                        progbar.IsIndeterminate = true;
                        progbar.Orientation = Orientation.Horizontal;
                        Duration duration = new Duration(TimeSpan.FromSeconds(3));
                        DoubleAnimation doubleanimation = new DoubleAnimation(100.0, duration);
                        progbar.BeginAnimation(ProgressBar.ValueProperty, doubleanimation);*/

            lbl_message.Content = "Benchmark 1 of 2. Please Wait";

            await SimulateProgressBar(pBar0);

            BenchIncrement();

            await Task.Delay(3000);

            await SimulateProgressBar(pBar0);

            BenchStringSearch();
        }

        
        public static async Task SimulateProgressBar(ProgressBar pBar)
        {
            pBar.Value = 0;

            for (int i = 0; i < 101; i++)
            {
                await Task.Delay(40);

                pBar.Value += i;
            }
        }


        private void BenchIncrement()
        {
            Benchmark bench = new Benchmark(maxTurns, incrementTop, searchValueString, logicalProcessors);
            bench.StartBenchIncrement();

            Thread.Sleep(100);

            var SwIncrement = Stopwatch.StartNew();
            while (bench.GetTurnsAllThreads() < maxTurns)
            {
                Thread.Sleep(1);
            }

            SwIncrement.Stop();

            lbl_message.Content = "Benchmark 2 of 2. Please Wait";

            swBenchIncrement = Math.Round(SwIncrement.Elapsed.TotalMilliseconds, 2);
            lbl_result.Content = "Bench 1: " + swBenchIncrement + "ms";
            // lbl_result.Content = "Time: " + SwIncrement.Elapsed.TotalMilliseconds / (double)maxTurns + "ms";
        }

        private void BenchStringSearch()
        {
            Benchmark bench = new Benchmark(maxTurns, incrementTop, searchValueString, logicalProcessors);
            bench.StartBenchStringSearch();

            Thread.Sleep(100);

            var Sw = Stopwatch.StartNew();
            while (bench.GetTurnsAllThreads() < maxTurns)
            {
                Thread.Sleep(1);
            }

            Sw.Stop();

            lbl_message.Content = "Benchmark Complete";

            swBenchStringSearch = Math.Round(Sw.Elapsed.TotalMilliseconds, 2);
            lbl_result.Content = "Benchmark Total: " + (swBenchStringSearch + swBenchIncrement) + "ms" + " Bench 1: " + swBenchIncrement + "ms" + " Bench 2: " + swBenchStringSearch + "ms";

        }
    }
}
