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

namespace TestWpfTargil1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = this;
        }
        Targil1window2 window2 = new Targil1window2();
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            window2.Show();
            window2.INFORMATION.Text = ($"button width is: {Width.Value.ToString()} button hight is:{Hight.Value.ToString()}  how big is width : {Size1.Text.ToString()} how big is hight : {Size2.Text.ToString()}");
        }
    }
}
