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
    
    public partial class Cliente
    {
        public Cliente()
        {
            this.Contrato = new HashSet<Contrato>();
        }
    
        public int IDCliente { get; set; }
        public string Nombre { get; set; }
        public string Ape_Pat { get; set; }
        public string Ape_Mat { get; set; }
        public string NombresCompletos { get; set; }
        public string Nro_Documento { get; set; }
        public System.DateTime Fecha_Nacimiento { get; set; }
        public string E_mail { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Celular { get; set; }
        public string Estado_Civil { get; set; }
        public string IdUbigeo { get; set; }
        public int IDTipoUsuario { get; set; }
        public int IDReligion { get; set; }
        public int IDDoc_Identidad { get; set; }
        public int IDIdioma { get; set; }
    
        public virtual ICollection<Contrato> Contrato { get; set; }
        public virtual Idiomas Idiomas { get; set; }
        public virtual Ubigeo Ubigeo { get; set; }
        public virtual Doc_Identidad Doc_Identidad { get; set; }
        public virtual Religion Religion { get; set; }
        public virtual TipoUsuario TipoUsuario { get; set; }
    }
}
