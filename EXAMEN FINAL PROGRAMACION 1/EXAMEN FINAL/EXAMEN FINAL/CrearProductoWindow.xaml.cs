using System.Linq;
using System.Windows;

namespace ProductoApp
{
    public partial class CrearProductoWindow : Window
    {
        private AppDbContext _context;

        public CrearProductoWindow()
        {
            InitializeComponent();
            _context = new AppDbContext();
            LoadUsuarios();
        }

        private void LoadUsuarios()
        {
            UsuarioComboBox.ItemsSource = _context.Usuarios.ToList();
            UsuarioComboBox.DisplayMemberPath = "Nombre";
            UsuarioComboBox.SelectedValuePath = "Id";
        }

        private void Guardar_Click(object sender, RoutedEventArgs e)
        {
            var nuevoProducto = new Producto
            {
                Codigo = CodigoTextBox.Text,
                Nombre = NombreTextBox.Text,
                Precio = decimal.Parse(PrecioTextBox.Text),
                Existencia = int.Parse(ExistenciaTextBox.Text),
                UsuarioId = (int)UsuarioComboBox.SelectedValue
            };

            _context.Productos.Add(nuevoProducto);
            _context.SaveChanges();
            this.Close();
        }
    }
}

