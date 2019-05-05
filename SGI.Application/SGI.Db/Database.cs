namespace SGI.Db
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Database : DbContext
    {
        public Database()
            : base("name=Database")
        {
        }

        public virtual DbSet<Membro> Membroes { get; set; }
        public virtual DbSet<MembroHistorico> MembroHistoricoes { get; set; }
        public virtual DbSet<Pessoa> Pessoas { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pessoa>()
                .HasMany(e => e.Membroes)
                .WithRequired(e => e.Pessoa)
                .HasForeignKey(e => e.Pessoa_Id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Pessoa>()
                .HasMany(e => e.MembroHistoricoes)
                .WithRequired(e => e.Pessoa)
                .HasForeignKey(e => e.CriadoPorId)
                .WillCascadeOnDelete(false);
        }
    }
}
