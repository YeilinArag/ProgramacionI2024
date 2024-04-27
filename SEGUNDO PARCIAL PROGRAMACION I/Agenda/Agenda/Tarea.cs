using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda
{
    public class Tarea
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public DateTime Fecha { get; set; }

        public Tarea (string nombre, string descripcion, DateTime fecha)
        {
            Nombre = nombre;
            Descripcion = descripcion;
            Fecha = fecha;
        }
    }
}
