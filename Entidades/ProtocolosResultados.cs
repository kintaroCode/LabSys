namespace Entidades
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ProtocolosResultados
    {
        [Key]
        public int IDProtocolo { get; set; }

        [StringLength(10)]
        public string DNI { get; set; }

        [Required]
        [StringLength(50)]
        public string Nombre { get; set; }

        [Required]
        [StringLength(50)]
        public string Apellido { get; set; }

        [StringLength(10)]
        public string Sexo { get; set; }

        [StringLength(50)]
        public string Ciuda { get; set; }

        [StringLength(50)]
        public string ObraSocial { get; set; }

        public string Prestaciones { get; set; }

        [Column(TypeName = "date")]
        public DateTime? FechaProtocolo { get; set; }
    }
}
