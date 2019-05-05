namespace SGI.Application
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Database : DbContext
    {
        public Database()
            : base("name=sgiconnection")
        {
        }

        public virtual DbSet<Membro> Membro { get; set; }
        public virtual DbSet<MembroHistorico> MembroHistorico { get; set; }
        public virtual DbSet<Pessoa> Pessoa { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pessoa>()
                .HasMany(e => e.Membro)
                .WithRequired(e => e.Pessoa)
                .HasForeignKey(e => e.Pessoa_Id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Pessoa>()
                .HasMany(e => e.MembroHistorico)
                .WithRequired(e => e.Pessoa)
                .HasForeignKey(e => e.CriadoPorId)
                .WillCascadeOnDelete(false);
        }
    }
}
