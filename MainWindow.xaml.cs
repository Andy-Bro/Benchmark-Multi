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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            lbl_message.Content = "Please Wait...";

            Benchmark bench = new Benchmark();
            bench.StartBench();

            while (bench.GetTurnsAllThreads() < 50)
            {
                Thread.Sleep(1000);

                bench.SetTurnsAllThreads();

                lbl_result.Content = "Turns: " + bench.GetTurnsAllThreads().ToString();
            }

            lbl_message.Content = "Benchmark Finished";
        }
    }
}
