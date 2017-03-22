namespace MyFrameWork.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class MyFrameWorkContext : DbContext
    {
        public MyFrameWorkContext()
            : base("name=MyFrameWorkModels")
        {
        }

        public virtual DbSet<Class> Class { get; set; }
        public virtual DbSet<Student> Student { get; set; }
        public virtual DbSet<UserDevices> UserDevices { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserDevices>()
                .Property(e => e.SessionKey)
                .IsUnicode(false);
        }
    }
}
