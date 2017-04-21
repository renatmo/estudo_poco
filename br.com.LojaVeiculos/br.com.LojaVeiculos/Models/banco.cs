namespace br.com.LojaVeiculos.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class banco : DbContext
    {
        public banco()
            : base("name=banco")
        {
        }

        public virtual DbSet<TB_CLIENTE> TB_CLIENTE { get; set; }
        public virtual DbSet<TB_MULTA> TB_MULTA { get; set; }
        public virtual DbSet<TB_VEICULO> TB_VEICULO { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TB_CLIENTE>()
                .Property(e => e.NM_CLIENTE)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CLIENTE>()
                .Property(e => e.NM_TELEFONE)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CLIENTE>()
                .HasMany(e => e.TB_VEICULO)
                .WithRequired(e => e.TB_CLIENTE)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TB_MULTA>()
                .Property(e => e.DES_OCORRENCIA)
                .IsUnicode(false);

            modelBuilder.Entity<TB_MULTA>()
                .Property(e => e.VAL_MULTA)
                .HasPrecision(10, 2);

            modelBuilder.Entity<TB_VEICULO>()
                .Property(e => e.NOM_MARCA)
                .IsUnicode(false);

            modelBuilder.Entity<TB_VEICULO>()
                .Property(e => e.DES_MODELO)
                .IsUnicode(false);

            modelBuilder.Entity<TB_VEICULO>()
                .Property(e => e.NOM_COR)
                .IsUnicode(false);

            modelBuilder.Entity<TB_VEICULO>()
                .HasMany(e => e.TB_MULTA)
                .WithRequired(e => e.TB_VEICULO)
                .HasForeignKey(e => e.ID_VEICULO)
                .WillCascadeOnDelete(false);
        }
    }
}
