namespace SGI.Db
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Pessoa")]
    public partial class Pessoa
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Pessoa()
        {
            Membroes = new HashSet<Membro>();
            MembroHistoricoes = new HashSet<MembroHistorico>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Nome { get; set; }

        public int Idade { get; set; }

        [Required]
        [StringLength(15)]
        public string Sexo { get; set; }

        [Required]
        [StringLength(11)]
        public string CPF { get; set; }

        [Required]
        [StringLength(10)]
        public string RG { get; set; }

        [Required]
        [StringLength(100)]
        public string Endereco { get; set; }

        [StringLength(50)]
        public string Bairro { get; set; }

        [Required]
        [StringLength(50)]
        public string Cidade { get; set; }

        [Required]
        [StringLength(50)]
        public string Email { get; set; }

        [Required]
        [StringLength(50)]
        public string Curso { get; set; }

        public int SemestreAtual { get; set; }

        public int SemestreEntrada { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Membro> Membroes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MembroHistorico> MembroHistoricoes { get; set; }
    }
}
