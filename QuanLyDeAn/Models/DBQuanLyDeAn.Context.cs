﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuanLyDeAn.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DBQuanLyDeAnEntities : DbContext
    {
        public DBQuanLyDeAnEntities()
            : base("name=DBQuanLyDeAnEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<DeAn> DeAns { get; set; }
        public virtual DbSet<GiaoVien> GiaoViens { get; set; }
        public virtual DbSet<Nhom> Nhoms { get; set; }
        public virtual DbSet<SinhVien> SinhViens { get; set; }
        public virtual DbSet<TienDo> TienDoes { get; set; }
    }
}