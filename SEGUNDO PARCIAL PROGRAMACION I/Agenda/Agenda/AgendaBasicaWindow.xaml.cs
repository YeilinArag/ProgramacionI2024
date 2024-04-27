using System;
using System.Collections.Generic;

using System.Collections.ObjectModel;
using System.Windows;

namespace Agenda
{using System.Linq;
    /// <summary>
    /// Lógica de interacción para AgendaBasicaWindow.xaml
    /// </summary>
    public partial class AgendaBasicaWindow : Window
    {
        private ObservableCollection<Tarea> tareas = new ObservableCollection<Tarea>();
        public AgendaBasicaWindow()
        {
            InitializeComponent();
            ListaTareas.ItemsSource = tareas;
        }
        private void AgregarTarea(object sender, RoutedEvent e)
        {
            string nombre=NombreTarea.Text;
            string descripcion=DescripcionTarea.Text;
            DateTime fecha=FechaTarea.SelectedDate ?? DateTime.Now;

            Tarea nuevaTarea=new Tarea(nombre, descripcion, fecha);
            tareas.Add(nuevaTarea);

            NombreTarea.Clear();
            DescripcionTarea.Clear();
            FechaTarea.SelectedDate = null; 
          }
        private void EliminarTarea(object sender, RoutedEventArgs e)
        {
            Tarea tareaSeleccionada = (Tarea)ListaTareas.SelectedItem;
            if(tareaSeleccionada != null)
            {
                tareas.Remove(tareaSeleccionada);
            }
        }
    }
}
