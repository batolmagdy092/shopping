﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace loginshopping
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class shoppingsEntities : DbContext
    {
        public shoppingsEntities()
            : base("name=shoppingsEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Admin_> Admin_ { get; set; }
        public virtual DbSet<delivry> delivries { get; set; }
        public virtual DbSet<product> products { get; set; }
        public virtual DbSet<Userr_> Userr_ { get; set; }
    }
}
