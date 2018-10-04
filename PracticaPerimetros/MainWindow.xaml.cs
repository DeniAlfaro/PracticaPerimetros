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

namespace PracticaPerimetros
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void cbTipoFigura_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            controlPerimetroCirculo.Visibility = Visibility.Collapsed;
            controlPerimetroCuadrado.Visibility = Visibility.Collapsed;

            switch(cbTipoFigura.SelectedIndex)
            {
                case 0:
                    controlPerimetroCirculo.Visibility = Visibility.Visible;
                    //circulo
                    break;
                case 1:
                    controlPerimetroCuadrado.Visibility = Visibility.Visible;
                    //cuadrado
                    break;
                case 2:
                    controlPerimetroTrapecio.Visibility = Visibility.Visible;
                    //trapecio
                    break;
                case 3:
                    controlPerimetroRectangulo.Visibility = Visibility.Visible;
                    //rectangulo
                    break;
                default:
                    break;
            }
        }

        private void btnCalcular_Click(object sender, RoutedEventArgs e)
        {
            float perimetro = 0.0f;

            switch (cbTipoFigura.SelectedIndex)
            {
                case 0:
                    float radio = float.Parse(controlPerimetroCirculo.txtRadio.Text);
                    perimetro = 2 * radio * 3.14159f;
                    break;
                case 1:
                    float lado = float.Parse(controlPerimetroCuadrado.txtLado.Text);
                    perimetro = lado * 4;
                    break;
                case 2:
                    float ladoTrapecio = float.Parse(controlPerimetroTrapecio.txtLadoTrapecio.Text);
                    float ladoTrapecio2 = float.Parse(controlPerimetroTrapecio.txtLadoTrapecio2.Text);
                    float Lados = float.Parse(controlPerimetroTrapecio.txtLados.Text);
                    perimetro = ladoTrapecio + ladoTrapecio2 + Lados;
                    break;
                case 3:
                    float Base = float.Parse(controlPerimetroRectangulo.txtBase.Text);
                    float altura = float.Parse(controlPerimetroRectangulo.txtAltura.Text);
                    perimetro = 2 * (Base + altura);
                    break;
                default:
                    break;

            }
            lblResultado.Text = perimetro.ToString();
        }
    }
}
