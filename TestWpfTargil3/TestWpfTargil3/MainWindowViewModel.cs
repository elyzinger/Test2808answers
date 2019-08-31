using Prism.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TestWpfTargil3
{
    class MainWindowViewModel
    {
        public DelegateCommand DelegateRead { get; set; }
        bool isReadFinish;
        public string Url { get; set; }
        public Read reads { get; set; }
        string text;
        public MainWindowViewModel()
        {
            DelegateRead = new DelegateCommand(ExecuteCommand, CanExecuteMethod);
            isReadFinish = true;
            reads = new Read() { Reads = "Please wait..." };

            Task.Run(() =>
            {
                while (true)
                {
                    DelegateRead.RaiseCanExecuteChanged(); // go check the enable/disable
                    Thread.Sleep(500);
                }

            });
        }
        private bool CanExecuteMethod()
        {
            if (Url != "" && isReadFinish == true)
            {
                return true;
            }
            return false;
        }
        private async void ExecuteCommand()
        {
            isReadFinish = false;
            
            await Task.Run(() =>
            {
                using (WebClient client = new WebClient())
                {
                    text = client.DownloadString(Url);
                }

                int size = System.Text.ASCIIEncoding.ASCII.GetByteCount(text);

                reads.Reads = $"Size is: {size} bytes";
            });
            isReadFinish = true;
        }
    }
}
