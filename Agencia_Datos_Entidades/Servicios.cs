//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Agencia_Datos_Entidades
{
    using System;
    using System.Collections.Generic;
    
    public partial class Servicios
    {
        public Servicios()
        {
            this.ServicioEmpleado = new HashSet<ServicioEmpleado>();
        }
    
        public int IDServicio { get; set; }
        public string NombreServicio { get; set; }
        public string Descripcion { get; set; }
    
        public virtual ICollection<ServicioEmpleado> ServicioEmpleado { get; set; }
    }
}
