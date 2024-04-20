using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Duplicacion_WPF
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // Lógica del botón 1
            MessageBox.Show("Has hecho clic en el Botón 1", "Información", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void Button_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            // Lógica del botón externo
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                MessageBox.Show("Boton 2", "Información", MessageBoxButton.OK, MessageBoxImage.Information);
 }
        }

        private void Button_PreviewMouseDown_1(object sender, MouseButtonEventArgs e)
        {
            // Lógica del botón interno
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                MessageBox.Show("Boton 2", "Información", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
             {
            // Lógica del botón 3
            MessageBox.Show("Has hecho clic en el Botón 3", "Información", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            // Lógica del botón 4
            MessageBox.Show("Has hecho clic en el Botón 4", "Información", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}