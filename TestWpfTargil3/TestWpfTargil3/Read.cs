using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWpfTargil3
{
    class Read : INotifyPropertyChanged
    {
        private string reads;
        public string Reads
        {
            get
            {
                return this.reads;
            }
            set
            {
                this.reads = value;
                OnPropertyChanged("Read");
            }
        }
        public override string ToString()
        {
            return $"Read name {Reads}";
        }
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));

            }
        }
    }
}
        
