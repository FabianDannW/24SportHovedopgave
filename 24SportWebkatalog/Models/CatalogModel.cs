using System.Data.Entity;

namespace _24SportWebkatalog.Models
{
    public partial class CatalogModel : DbContext
    {
        public CatalogModel() : base("name=CatalogModel")
        {

        }

        public virtual DbSet<CatalogItem> catalogItems { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CatalogItem>().Property(e => e.Id);

            modelBuilder.Entity<CatalogItem>().Property(e => e.ItemName).IsUnicode(false);

            modelBuilder.Entity<CatalogItem>().Property(e => e.ImgPath).IsUnicode(false);

            modelBuilder.Entity<CatalogItem>().Property(e => e.Price);

            modelBuilder.Entity<CatalogItem>().Property(e => e.Description).IsUnicode(false);




        }
    }
}