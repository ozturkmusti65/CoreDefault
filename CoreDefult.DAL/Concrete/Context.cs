using CoreDefault.Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreDefult.DAL.Concrete
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("User ID=postgres;Password=1234;Server =localhost;Port=5432;Database=CoreDefaultDb;");
            //optionsBuilder.UseNpgsql("User ID=root;Password=1234;Host=localhost;Port=5432;Database=CoreDefaultDb;Pooling=true;Min Pool Size=0;Max Pool Size=100;Connection Lifetime=0;");
        }

        public DbSet<About> Abouts{ get; set; }
        public DbSet<Blog> Blogs{ get; set; }
        public DbSet<Category> Categories{ get; set; }
        public DbSet<Comment> Comments{ get; set; }
        public DbSet<Contact> Contacts{ get; set; }
        public DbSet<Writer> Writers { get; set; }
    }
}
