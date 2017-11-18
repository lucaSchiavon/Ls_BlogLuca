namespace LS_BlogLuca.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Web.Mvc;

    [Table("About")]
    public partial class About
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public About()
        {
            //ArticoliCorrelati = new HashSet<ArticoliCorrelati>();
            //Post = new HashSet<Post>();
        }

        [Key]
        public int IdAbout { get; set; }
        [AllowHtml]
        public string Titolo { get; set; }
        [AllowHtml]
        public string Titolo_en { get; set; }
        [AllowHtml]
        public string Contenuti { get; set; }
        [AllowHtml]
        public string Contenuti_en { get; set; }
      
        public DateTime? DataInserimento { get; set; }

      
    }
}
