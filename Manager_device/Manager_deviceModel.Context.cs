﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Manager_device
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Manager_deviceEntities : DbContext
    {
        public Manager_deviceEntities()
            : base("name=Manager_deviceEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<DETAIL_CHECK> DETAIL_CHECK { get; set; }
        public virtual DbSet<DEVICE> DEVICEs { get; set; }
        public virtual DbSet<GROUP_DEVICE> GROUP_DEVICE { get; set; }
        public virtual DbSet<RULE> RULEs { get; set; }
        public virtual DbSet<USER> USERs { get; set; }
    }
}
