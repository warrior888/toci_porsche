﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Toci.CarRental.Dal.EF
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class carrentalEntities : DbContext
    {
        public carrentalEntities()
            : base("name=carrentalEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<carfeature> carfeature { get; set; }
        public virtual DbSet<carfeaturemap> carfeaturemap { get; set; }
        public virtual DbSet<client> client { get; set; }
        public virtual DbSet<driverslicense> driverslicense { get; set; }
        public virtual DbSet<driverslicensecategory> driverslicensecategory { get; set; }
        public virtual DbSet<rental> rental { get; set; }
        public virtual DbSet<rentaloption> rentaloption { get; set; }
    }
}
