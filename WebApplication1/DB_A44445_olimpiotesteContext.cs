using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace WebApplication1
{
    public partial class DB_A44445_olimpiotesteContext : DbContext
    {
        public DB_A44445_olimpiotesteContext()
        {
        }

        public DB_A44445_olimpiotesteContext(DbContextOptions<DB_A44445_olimpiotesteContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Usuario> Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=SQL5063.site4now.net,1433;Initial Catalog=DB_A44445_olimpioteste;User Id=DB_A44445_olimpioteste_admin;Password=senha1234;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.ToTable("Usuario");

                //entity.HasKey(x => x.Id);

                //entity.Property(x => x.Id).IsRequired(true).HasMaxLength(200);

                entity.Property(e=>e.Id).ValueGeneratedOnAdd(); 
                entity.Property(e => e.DataNascimento).HasColumnType("date");
                // entity.Property(e => e.Id).Metadata.SetAfterSaveBehavior(PropertySaveBehavior.Ignore);

                //entity.Property(d => d.Id).ValueGeneratedOnAdd();
                //entity.HasKey(d => d.Id);
                //entity.Property(ent => ent.Id).ValueGeneratedOnAdd();
                

                //            entity   .Entity<DestuffedContainer>()
                //.Property(d => d.DestuffedContainerId)
                //.ValueGeneratedOnAdd();

                //            entity
                //            .Entity<DestuffedContainer>()
                //            .HasKey(d => d.DestuffedContainerId);

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sobrenome)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
