using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace GraKosci
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<int> results { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            results = new ObservableCollection<int>();

            DataContext = this;
        }

        private void Clear_Button_Click(object sender, RoutedEventArgs e)
        {
            results.Clear();
            for (int i = 0; i < 10; i++)
            {
                results.Add(0);
            }
        }

        private void Roll_Button_Click(object sender, RoutedEventArgs e)
        {
            results.Clear();
            var random = new Random();
            for(int i=0;i<10; i++)
            {
                results.Add(random.Next(1, 7));
            }
        }
    }
}
