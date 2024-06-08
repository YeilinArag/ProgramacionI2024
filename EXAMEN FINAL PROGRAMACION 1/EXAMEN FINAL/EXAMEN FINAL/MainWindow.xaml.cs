using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace ProductoApp
{
    public partial class MainWindow : Window
    {
        private AppDbContext _context;

        public MainWindow()
        {
            InitializeComponent();
            _context = new AppDbContext();
            LoadData();
        }

        private void LoadData()
        {
            ProductosDataGrid.ItemsSource = _context.Productos.ToList();
        }

        private void Nuevo_Click(object sender, RoutedEventArgs e)
        {
            var crearProductoWindow = new CrearProductoWindow();
            crearProductoWindow.ShowDialog();
            LoadData();
        }

        private void Editar_Click(object sender, RoutedEventArgs e)
        {
            if (ProductosDataGrid.SelectedItem is Producto producto)
            {
                var editarProductoWindow = new EditarProductoWindow(producto.Id);
                editarProductoWindow.ShowDialog();
                LoadData();
            }
            else
            {
                MessageBox.Show("Seleccione un producto para editar");
            }
        }

        private void Borrar_Click(object sender, RoutedEventArgs e)
        {
            if (ProductosDataGrid.SelectedItem is Producto producto)
            {
                _context.Productos.Remove(producto);
                _context.SaveChanges();
                LoadData();
            }
            else
            {
                MessageBox.Show("Seleccione un producto para borrar");
            }
        }

        private void Refrescar_Click(object sender, RoutedEventArgs e)
        {
            LoadData();
        }
    }
}
