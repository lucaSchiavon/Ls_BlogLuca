namespace LS_BlogLuca.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Utenti")]
    public partial class Utenti
    {
        [Key]
        public int IdUtente { get; set; }

        [StringLength(50)]
        [DisplayName("user name")]
        [Required(ErrorMessage ="Questo campo è richiesto")]
        public string Username { get; set; }

        [StringLength(50)]
        [Required(ErrorMessage = "Questo campo è richiesto")]
        public string Password { get; set; }

        public bool? Attivo { get; set; }

        public DateTime? DataInserimento { get; set; }
    }
}
