﻿using AgileHub.AsyncAwaitMagic.Standard;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace AgileHub.AsyncAwaitMagic.WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            RestClient restClient = new RestClient();

            // Console.WriteLine($"Current thread id is: { Thread.CurrentThread.ManagedThreadId }");

            var result = await restClient.Get("http://asyncawaitmagic.azurewebsites.net/api/demo");

            // Console.WriteLine($"Continuation thread id is: { Thread.CurrentThread.ManagedThreadId }");

            resultlabel.Text = await result.Content.ReadAsStringAsync();
        }
    }
}
