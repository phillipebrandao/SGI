namespace SGI.Application
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MembroHistorico")]
    public partial class MembroHistorico
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Departamento { get; set; }

        [Required]
        [StringLength(50)]
        public string Nucelo { get; set; }

        [Required]
        [StringLength(50)]
        public string Cargo { get; set; }

        public int Pessoa_Id { get; set; }

        public int CriadoPorId { get; set; }

        [Column(TypeName = "date")]
        public DateTime CriadoEm { get; set; }

        public virtual Pessoa Pessoa { get; set; }
    }
}
