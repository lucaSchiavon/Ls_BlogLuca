namespace LS_BlogLuca.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Post")]
    public partial class Post
    {
        [Key]
        public int IdPost { get; set; }

        public int? IdArticolo { get; set; }

        public int? IdPostParente { get; set; }

        public int? IdUtenteRegistrato { get; set; }

        public string Contenuto { get; set; }

        public DateTime? DataInserimento { get; set; }

        [StringLength(50)]
        public string Cultura { get; set; }

        public virtual Articoli Articoli { get; set; }

        public virtual UtentiRegistrati UtentiRegistrati { get; set; }
    }
}
