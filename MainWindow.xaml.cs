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

namespace Benchmark_Multi
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        // ------------ Options ------------
        private int maxTurns = 140;
        private int IncrementTop = 500000000;


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SetTextWait();

            Benchmark bench = new Benchmark(maxTurns, IncrementTop);
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

        private void SetTextWait()
        {
            lbl_message.Content = "Please Wait...";
        }
    }
}
