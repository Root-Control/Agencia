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
    
    public partial class Empleado_Detalle
    {
        public int IDEmpleadoDetalle { get; set; }
        public System.DateTime Fecha_Disponibilidad { get; set; }
        public string Modalidad { get; set; }
        public string Experiencia { get; set; }
        public string Desc_Experiencia { get; set; }
        public string Experiencia_Recien_Nacidos { get; set; }
        public string Hobbies { get; set; }
        public int IDEmpleado { get; set; }
    
        public virtual Empleado Empleado { get; set; }
    }
}
