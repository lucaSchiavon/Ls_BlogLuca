namespace LS_BlogLuca.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ArticoliCorrelati")]
    public partial class ArticoliCorrelati
    {
        public int? IdArticolo { get; set; }

        public int? IdArticoloCorrelato { get; set; }

        public int Id { get; set; }

        public virtual Articoli Articoli { get; set; }
    }
}
