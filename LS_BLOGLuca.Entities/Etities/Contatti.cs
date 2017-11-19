namespace LS_BlogLuca.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Contatti")]
    public partial class Contatti
    {
        [Key]
        public int IdContatto { get; set; }

        [StringLength(255)]
        public string Nome { get; set; }

        [StringLength(255)]
        public string Email { get; set; }

        public string Message { get; set; }

        public bool? Newsletter { get; set; }

        public DateTime? DataInserimento { get; set; }
    }
}
