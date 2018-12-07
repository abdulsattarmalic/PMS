

namespace App_Project.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class PMS_DBEntities : DbContext
    {
        public PMS_DBEntities()
            : base("name=PMS_DBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<tbl_Admin> tbl_Admin { get; set; }
        public virtual DbSet<tbl_Doc> tbl_Doc { get; set; }
        public virtual DbSet<tbl_Employee> tbl_Employee { get; set; }
        public virtual DbSet<tbl_Message> tbl_Message { get; set; }
        public virtual DbSet<tbl_PM> tbl_PM { get; set; }
        public virtual DbSet<tbl_Task> tbl_Task { get; set; }
        public virtual DbSet<tbl_Projects> tbl_Projects { get; set; }
    }
}
