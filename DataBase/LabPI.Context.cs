﻿//------------------------------------------------------------------------------
// <auto-generated>
//    Этот код был создан из шаблона.
//
//    Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//    Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Constructor.DataBase
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class LabPIContext : DbContext
    {
        public LabPIContext()
            : base("name=LabPIContext")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Answer> Answers { get; set; }
        public DbSet<Cell> Cells { get; set; }
        public DbSet<Constructor> Constructors { get; set; }
        public DbSet<Option> Options { get; set; }
        public DbSet<Report> Reports { get; set; }
        public DbSet<Statistic> Statistics { get; set; }
        public DbSet<Test> Tests { get; set; }
        public DbSet<User_of_labPI> User_of_labPI { get; set; }
    }
}
