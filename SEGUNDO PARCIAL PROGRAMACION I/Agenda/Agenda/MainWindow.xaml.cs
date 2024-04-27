
using System.Windows;


namespace Agenda
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void AbrirAgendaBasica (object sender, RoutedEventArgs e)
        {
            AgendaBasicaWindow agendaBasica = new AgendaBasicaWindow();
            agendaBasica.Show();
        }

        private void AbrirAgendaAvanzada (object sender, RoutedEventArgs e)
        {
            AgendaAvanzadaWindow agendaAvanzada = new AgendaAvanzadaWindow();
            agendaAvanzada.Show();
        }
    }
}