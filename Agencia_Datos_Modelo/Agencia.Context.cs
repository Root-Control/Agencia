﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class AgenciaContext : DbContext, IDisposable
    {
        public AgenciaContext()
            : base("name=AgenciaContext")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Cliente> Cliente { get; set; }
        public virtual DbSet<Contrato> Contrato { get; set; }
        public virtual DbSet<Control_Electrodomestico_Empleado> Control_Electrodomestico_Empleado { get; set; }
        public virtual DbSet<Control_Electrodomesticos> Control_Electrodomesticos { get; set; }
        public virtual DbSet<Doc_Identidad> Doc_Identidad { get; set; }
        public virtual DbSet<Documentos> Documentos { get; set; }
        public virtual DbSet<DocumentoxEmpleado> DocumentoxEmpleado { get; set; }
        public virtual DbSet<Empleado> Empleado { get; set; }
        public virtual DbSet<Empleado_Detalle> Empleado_Detalle { get; set; }
        public virtual DbSet<Estudios> Estudios { get; set; }
        public virtual DbSet<HabilidadEmpleado> HabilidadEmpleado { get; set; }
        public virtual DbSet<Habilidades> Habilidades { get; set; }
        public virtual DbSet<Idiomas> Idiomas { get; set; }
        public virtual DbSet<MenuEmpleado> MenuEmpleado { get; set; }
        public virtual DbSet<Menus> Menus { get; set; }
        public virtual DbSet<Religion> Religion { get; set; }
        public virtual DbSet<ServicioEmpleado> ServicioEmpleado { get; set; }
        public virtual DbSet<Servicios> Servicios { get; set; }
        public virtual DbSet<TipoUsuario> TipoUsuario { get; set; }
        public virtual DbSet<Ubigeo> Ubigeo { get; set; }
    }
}
