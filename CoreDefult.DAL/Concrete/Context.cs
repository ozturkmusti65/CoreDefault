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
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Message2>()
                .HasOne(x => x.SenderUser)
                .WithMany(y => y.Sender)
                .HasForeignKey(z => z.SenderId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder.Entity<Message2>()
                .HasOne(x => x.ReceiverUser)
                .WithMany(y => y.Receiver)
                .HasForeignKey(z => z.ReveiverId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        }

        public DbSet<About> Abouts{ get; set; }
        public DbSet<Blog> Blogs{ get; set; }
        public DbSet<Category> Categories{ get; set; }
        public DbSet<Comment> Comments{ get; set; }
        public DbSet<Contact> Contacts{ get; set; }
        public DbSet<Writer> Writers { get; set; }
        public DbSet<NewsLetter> NewsLetters { get; set; }
        public DbSet<BlogRayting> BlogRaytings { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Message2> Message2s { get; set; }
        public DbSet<Admin> Admins { get; set; }
    }
}
