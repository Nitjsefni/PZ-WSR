﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RM
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class RMEntities : DbContext
    {
        public RMEntities()
            : base("name=RMEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Karetka> Karetkas { get; set; }
        public DbSet<Pacjenci1> Pacjenci1 { get; set; }
        public DbSet<Personel1> Personel1 { get; set; }
        public DbSet<Wypadek> Wypadeks { get; set; }
    }
}
