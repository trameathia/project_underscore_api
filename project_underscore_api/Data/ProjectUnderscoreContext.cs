using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using project_underscore_api.Models;

namespace project_underscore_api.Data
{
    public class ProjectUnderscoreContext : DbContext
    {
        public ProjectUnderscoreContext (DbContextOptions<ProjectUnderscoreContext> options) : base(options) {}

        public DbSet<User> Users { get; set; }
        public DbSet<UserItem> UserItems { get; set; }
        public DbSet<Tag> Tags { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<User>().Property(u => u.CreateDate).HasDefaultValueSql("getDate()");
            //modelBuilder.Entity<UserItem>().ToTable("UserItem");
            //modelBuilder.Entity<UserItemTag>().ToTable("UserItemTag");
        }
    }
}
