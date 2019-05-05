namespace SGI.Db
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Membro")]
    public partial class Membro
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Departamento { get; set; }

        [Required]
        [StringLength(50)]
        public string Nucleo { get; set; }

        [Required]
        [StringLength(10)]
        public string NucleoAbreviacao { get; set; }

        [Required]
        [StringLength(50)]
        public string Cargo { get; set; }

        public int Pessoa_Id { get; set; }

        public virtual Pessoa Pessoa { get; set; }
    }
}
