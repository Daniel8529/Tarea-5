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
using Capitulo10y12.Capitulo10;

namespace Capitulo10y12
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
        
        private void capitulo10Ejercicio1_Click(object sender, RoutedEventArgs e)
        {
            new Ejercicio1().Show();
        }
        private void Ejercicio2_Click(object sender, RoutedEventArgs e)
        {
            new Ejercicio2().Show();
        }

        private void ejercicio123(object sender, RoutedEventArgs e)
        {
            new Ejercicio3_4_5().Show();
        }
    }
}
