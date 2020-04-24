using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Asp.net_Core_Project.Models;
using Asp.net_Core_Project.Models.Common;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Asp.net_Core_Project.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {}

        public DbSet<Bar> Bars { get; set; }

        public DbSet<Comment> Comments { get; set; }


        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default) =>
            this.SaveChangesAsync(true, cancellationToken);
        public override Task<int> SaveChangesAsync(
          bool acceptAllChangesOnSuccess,
          CancellationToken cancellationToken = default)
        {
            this.ApplyAuditInfoRules();
            return base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Bar>().HasData(new Bar {UserId= "92d6b2d5-255c-4066-9846-d5ab5f0b1916", Id=1, Name = "Center", ImageUrl = "data:image/jpeg;base64,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", Address = "stz 112", Town = "Urugvai" });
            builder.Entity<Comment>().HasData(new Comment { Content = "Lorem ipsum", BarId = 1, CreatedOn = DateTime.UtcNow, Id = 1 });
        }
        private void ApplyAuditInfoRules()
        {
            var changedEntries = this.ChangeTracker
                .Entries()
                .Where(e =>
                    e.Entity is IAuditInfo &&
                    (e.State == EntityState.Added || e.State == EntityState.Modified));

            foreach (var entry in changedEntries)
            {
                var entity = (IAuditInfo)entry.Entity;
                if (entry.State == EntityState.Added && entity.CreatedOn == default)
                {
                    entity.CreatedOn = DateTime.UtcNow;
                }
                else
                {
                    entity.ModifiedOn = DateTime.UtcNow;
                }
            }

        }
    }
}

