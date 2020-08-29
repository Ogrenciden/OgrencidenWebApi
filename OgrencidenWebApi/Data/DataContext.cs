using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OgrencidenWebApi.Models;

namespace OgrencidenWebApi.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            //first many to many relation
            modelBuilder.Entity<FavAds>().HasKey(fv => new { fv.AdId, fv.UserId });
            modelBuilder.Entity<FavAds>()
                .HasOne<Ad>(fa => fa.Ad)
                .WithMany(a => a.FavAdses)
                .HasForeignKey(fa => fa.AdId);
            modelBuilder.Entity<FavAds>()
                .HasOne<User>(fa => fa.User)
                .WithMany(u => u.FavAdses)
                .HasForeignKey(fa => fa.UserId);
            //second many to many relation
            modelBuilder.Entity<AdAndCategory>().HasKey(ac => new { ac.CategoryId, ac.AdId });
            modelBuilder.Entity<AdAndCategory>()
                .HasOne<Ad>(ac => ac.Ad)
                .WithMany(a => a.AdAndCategories)
                .HasForeignKey(ac => ac.AdId);
            modelBuilder.Entity<AdAndCategory>()
                .HasOne<Category>(ac => ac.Category)
                .WithMany(aac => aac.AdAndCategories)
                .HasForeignKey(ac => ac.CategoryId);

        }

        public DbSet<Ad> Ads { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Photo> Photos { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<FavAds> FavAdses { get; set; }
        public DbSet<AdAndCategory> AdAndCategories { get; set; }
        public DbSet<UserProfilePhoto> UserProfilePhotos { get; set; }
    }
}
