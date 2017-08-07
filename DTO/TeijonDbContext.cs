using System;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Data.Entity.Infrastructure;

namespace DTO
{
    public partial class CustomBDContext : DbContext, IDbContext
    {
        public CustomBDContext()
            : base("name=TeijonModel")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Job>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<Job>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<Job>()
                .HasMany(e => e.people)
                .WithOptional(e => e.job)
                .HasForeignKey(e => e.id_job);

            modelBuilder.Entity<Person>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<Person>()
                .Property(e => e.sex)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Person>()
                .Property(e => e.description)
                .IsUnicode(false);
        }

        public new IDbSet<TEntity> Set<TEntity>() where TEntity : BaseEntity
        {
            return base.Set<TEntity>();
        }
        
        public new DbEntityEntry<TEntity> Entry<TEntity>(TEntity t) where TEntity : BaseEntity
        {
            return base.Entry<TEntity>(t);
        }

    }
}
