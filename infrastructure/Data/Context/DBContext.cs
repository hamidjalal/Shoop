using System.Drawing;
using System;
using Microsoft.EntityFrameworkCore;
using infrastructure.Data.Entites;
namespace infrastructure.Data.Context
{
    public class Context : DbContext
    {
        public DbSet<Categore> categores { get; set; }
        public DbSet<Tbl_Color> Colors { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder db)
        {
            db.UseSqlServer("Data source = . ; initial Catalog = Shoop ; integrated security = true ;");
        }
    }
}