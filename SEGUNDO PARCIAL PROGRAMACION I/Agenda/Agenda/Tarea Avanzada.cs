using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Agenda
{
    public class Tarea_Avanzada : Tarea 
    {
        public string Estado { get; set; }
        public string Responsable { get; set; }

        public Tarea_Avanzada(string nombre, string descripcion, DateTime fecha, string estado, string responsable) : base(nombre, descripcion, fecha)
        {
            Estado = estado;
            Responsable = responsable;
        }

        public void CambiarEstado(string nuevoEstado)
        {
            Estado = nuevoEstado;
        }

        public void CambiarResponsable(string nuevoResponsable)
        {
            Responsable= nuevoResponsable;
        }
    }
}
