﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PenaltyCalculation
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class PenaltyCalEntities : DbContext
    {
        public PenaltyCalEntities()
            : base("name=PenaltyCalEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Country> Country { get; set; }
        public DbSet<CountryHoliday> CountryHoliday { get; set; }
        public DbSet<Users> Users { get; set; }
    }
}
