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
    
    public partial class HabilidadEmpleado
    {
        public int IdHabilidadEmpleado { get; set; }
        public int IdEmpleado { get; set; }
        public int IDHabilidad { get; set; }
    
        public virtual Empleado Empleado { get; set; }
        public virtual Habilidades Habilidades { get; set; }
    }
}