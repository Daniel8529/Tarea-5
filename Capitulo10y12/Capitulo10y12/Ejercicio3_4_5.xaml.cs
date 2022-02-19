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
using Capitulo10y12.Entidades;

namespace Capitulo10y12.Capitulo10
{
    /// <summary>
    /// Interaction logic for Ejercicio3_4_5.xaml
    /// </summary>
    public partial class Ejercicio3_4_5 : Window
    {
        public Ejercicio3_4_5()
        {
            InitializeComponent();
        }
       

        private void Calcular_Click(object sender, RoutedEventArgs e)
        {
            Poligono poligono= new Poligono(int.Parse(LadoATX.Text), int.Parse(LadoBTX.Text), int.Parse(LadoCTX.Text));

            MessageBox.Show(poligono.ValoresValido(int.Parse(LadoATX.Text), int.Parse(LadoBTX.Text), int.Parse(LadoCTX.Text)));

            PerimetroTX.Text =  poligono.ToString();
        }
    }
}
