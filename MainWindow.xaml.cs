﻿using System;
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
        private int maxTurns = 140;
        private int IncrementTop = 500000000;

        private int logicalProcessors = Environment.ProcessorCount;


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

            Bench();

            for (int i = 0; i < 101; i++)
            {
                await Task.Delay(100);

                pBar0.Value += i;
            }

        }

        private void Bench()
        {
            Benchmark bench = new Benchmark(maxTurns, IncrementTop, logicalProcessors);
            bench.StartBenchIncrement();

            Thread.Sleep(100);

            var SwIncrement = Stopwatch.StartNew();
            while (bench.GetTurnsAllThreads() < maxTurns)
            {
                Thread.Sleep(1);
            }

            SwIncrement.Stop();

            lbl_message.Content = "Benchmark Finished";
            lbl_result.Content = "Time: " + SwIncrement.Elapsed.TotalMilliseconds + "ms";
            // lbl_result.Content = "Time: " + SwIncrement.Elapsed.TotalMilliseconds / (double)maxTurns + "ms";
        }
    }
}
