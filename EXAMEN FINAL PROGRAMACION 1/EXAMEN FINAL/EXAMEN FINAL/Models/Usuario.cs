using System.Collections.Generic;

public class Usuario
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public ICollection<Producto> Productos { get; set; }
}
