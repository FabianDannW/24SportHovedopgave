namespace _24SportWebkatalog.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<userinfo> userinfoes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<userinfo>()
                .Property(e => e.firstname)
                .IsUnicode(false);

            modelBuilder.Entity<userinfo>()
                .Property(e => e.lastname)
                .IsUnicode(false);

            modelBuilder.Entity<userinfo>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<userinfo>()
                .Property(e => e.Username)
                .IsUnicode(false);

            modelBuilder.Entity<userinfo>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<userinfo>()
                .Property(e => e.confirmpassword)
                .IsUnicode(false);
        }
    }
}
