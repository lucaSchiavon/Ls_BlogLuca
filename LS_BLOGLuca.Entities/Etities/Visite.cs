namespace LS_BlogLuca.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Visite")]
    public partial class Visite
    {
        [Key]
        public int IdVisita { get; set; }

        [StringLength(50)]
        public string IndirizzoIP { get; set; }

        public int? PaginaVisitata { get; set; }

        public DateTime? DataVisita { get; set; }
    }
}
