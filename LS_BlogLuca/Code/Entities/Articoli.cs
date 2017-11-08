namespace LS_BlogLuca.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Web.Mvc;

    [Table("Articoli")]
    public partial class Articoli
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Articoli()
        {
            ArticoliCorrelati = new HashSet<ArticoliCorrelati>();
            Post = new HashSet<Post>();
        }

        [Key]
        public int IdArticolo { get; set; }

        public int? IdCategoria { get; set; }
        [AllowHtml]
        public string Titolo { get; set; }
        [AllowHtml]
        public string Titolo_en { get; set; }
        [AllowHtml]
        public string Contenuti { get; set; }
        [AllowHtml]
        public string Contenuti_en { get; set; }

        public bool? Attivo { get; set; }

        public DateTime? DataInserimento { get; set; }

        public string Tags { get; set; }

        public virtual Categorie Categorie { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ArticoliCorrelati> ArticoliCorrelati { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Post> Post { get; set; }
    }
}
