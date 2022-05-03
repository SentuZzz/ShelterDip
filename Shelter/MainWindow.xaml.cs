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

namespace Shelter
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //int k = 0;
        //int k1 = 0;
        public int k = 0;
        public int k1 = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            InShel inShel = new InShel();
            ShelPage.NavigationService.Navigate(inShel);
            //k1++;
            //if (k1 > 0) { label2.Content = k1 + 1; }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            InFam inFam = new InFam();
            ShelPage.NavigationService.Navigate(inFam);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            FAQ1 q1 = new FAQ1();
            ShelPage.NavigationService.Navigate(q1);
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            FAQ2 q2 = new FAQ2();
            ShelPage.NavigationService.Navigate(q2);
        }
    }
}
