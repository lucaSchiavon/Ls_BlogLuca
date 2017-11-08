namespace LS_BlogLuca.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Etichette")]
    public partial class Etichette
    {
        [Key]
        public int IdEtichetta { get; set; }

        [StringLength(50)]
        public string Chiave { get; set; }

        public string Valore { get; set; }

        public string Valore_en { get; set; }
    }
}
