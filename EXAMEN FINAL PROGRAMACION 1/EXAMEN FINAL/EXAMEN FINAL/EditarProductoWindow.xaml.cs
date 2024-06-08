
using System.Linq;
using System.Windows;

namespace ProductoApp
{
    public partial class EditarProductoWindow : Window
    {
        private AppDbContext _context;
        private int _productoId;

        public EditarProductoWindow(int productoId)
        {
            InitializeComponent();
            _context = new AppDbContext();
            _productoId = productoId;
            LoadProducto();
            LoadUsuarios();
        }

        private void LoadProducto()
        {
            var producto = _context.Productos.Find(_productoId);
            if (producto != null)
            {
                CodigoTextBox.Text = producto.Codigo;
                NombreTextBox.Text = producto.Nombre;
                PrecioTextBox.Text = producto.Precio.ToString();
                ExistenciaTextBox.Text = producto.Existencia.ToString();
                UsuarioComboBox.SelectedValue = producto.UsuarioId;
            }
        }

        private void LoadUsuarios()
        {
            UsuarioComboBox.ItemsSource = _context.Usuarios.ToList();
            UsuarioComboBox.DisplayMemberPath = "Nombre";
            UsuarioComboBox.SelectedValuePath = "Id";
        }

        private void Guardar_Click(object sender, RoutedEventArgs e)
        {
            var producto = _context.Productos.Find(_productoId);
            if (producto != null)
            {
                producto.Codigo = CodigoTextBox.Text;
                producto.Nombre = NombreTextBox.Text;
                producto.Precio = decimal.Parse(PrecioTextBox.Text);
                producto.Existencia = int.Parse(ExistenciaTextBox.Text);
                producto.UsuarioId = (int)UsuarioComboBox.SelectedValue;

                _context.SaveChanges();
                this.Close();
            }
        }
    }
}
