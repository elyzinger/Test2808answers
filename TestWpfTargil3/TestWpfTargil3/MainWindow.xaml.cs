﻿using Prism.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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

namespace TestWpfTargil3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MainWindowViewModel vm = new MainWindowViewModel();

        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = vm;

        }
        private void SafeInvoke(Action work)
        {
            if (Dispatcher.CheckAccess()) // CheckAccess returns true if you're on the dispatcher thread
            {
                work.Invoke();
                return;
            }
            this.Dispatcher.BeginInvoke(work);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string text = "";
            WebClient client = new WebClient();
            Startbtn.IsEnabled = false;
            string theUrl = UrlName.Text;

            Task.Run(() =>
            {

                using (client = new WebClient())
                {

                    text = client.DownloadString(theUrl);

                    int size = System.Text.ASCIIEncoding.ASCII.GetByteCount(text);

                    Action uiwork = () =>
                    {

                        ResultText.Text = $"The size is: {size} bytes";
                        Startbtn.IsEnabled = true;
                    };

                    SafeInvoke(uiwork);
                }
            });
        }


    }
      
    
}
