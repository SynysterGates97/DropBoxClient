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
using System.Net.Http;

namespace dBoxClient
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static DropBoxClient DropBoxClient;

        static async Task WaitAndApologizeAsync()
        {
            await Task.Delay(2000);

            string  asyncResult = await DropBoxClient.Get();
            MessageBox.Show(asyncResult);
        }
        public MainWindow()
        {
            InitializeComponent();
            DropBoxClient = new DropBoxClient();
        }

        private async void button_Click(object sender, RoutedEventArgs e)
        {
            var asyncResult = await DropBoxClient.Get();
            MessageBox.Show(asyncResult);
        }
    }
}
