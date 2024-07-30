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

namespace WpfApp
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            this.Loaded += MainWindow_Loaded;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {

            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int valor = Convert.ToInt32(txtTexto.Text);
            Servicio1.Service1Client proxy = new Servicio1.Service1Client();
            string mensaje = proxy.GetData(valor);
            MessageBox.Show(mensaje);
        }
    }
}
