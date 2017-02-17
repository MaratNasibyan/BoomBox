using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Kdram.DbMap.Entities
{
    public partial class KdramResultsEntities : DbContext
    {
        public virtual DbSet<Human> Human { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            #warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
            optionsBuilder.UseSqlServer(@"Data Source= MARAT; Initial Catalog=Kdram; Integrated Security=True; Trusted_Connection=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Human>(entity =>
            {
                entity.HasKey(e => e.Isn)
                    .HasName("PK_HUMAN");

                entity.ToTable("HUMAN");

                entity.HasIndex(e => e.Name)
                    .HasName("NCI_HUMANNAME");

                entity.Property(e => e.Isn).HasColumnName("ISN");

                entity.Property(e => e.Creationdate)
                    .HasColumnName("CREATIONDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dateofbirth)
                    .HasColumnName("DATEOFBIRTH")
                    .HasColumnType("date");

                entity.Property(e => e.Descript)
                    .HasColumnName("DESCRIPT")
                    .HasMaxLength(50);

                entity.Property(e => e.Idcard)
                    .HasColumnName("IDCARD")
                    .HasMaxLength(10);

                entity.Property(e => e.Lastmodificationdate)
                    .HasColumnName("LASTMODIFICATIONDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("NAME")
                    .HasMaxLength(50);

                entity.Property(e => e.Patronymic)
                    .IsRequired()
                    .HasColumnName("PATRONYMIC")
                    .HasMaxLength(50);

                entity.Property(e => e.Soccard)
                    .HasColumnName("SOCCARD")
                    .HasMaxLength(10);

                entity.Property(e => e.Surname)
                    .IsRequired()
                    .HasColumnName("SURNAME")
                    .HasMaxLength(50);
            });
        }
    }
}