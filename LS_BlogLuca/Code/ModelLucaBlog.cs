namespace LS_BlogLuca.EF
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ModelLucaBlog : DbContext
    {
        public ModelLucaBlog()
            : base("name=ModelLucaBlog")
        {
        }

        public virtual DbSet<Articoli> Articoli { get; set; }
        public virtual DbSet<ArticoliCorrelati> ArticoliCorrelati { get; set; }
        public virtual DbSet<Categorie> Categorie { get; set; }
        public virtual DbSet<Contatti> Contatti { get; set; }
        public virtual DbSet<Etichette> Etichette { get; set; }
        public virtual DbSet<Post> Post { get; set; }
        public virtual DbSet<Utenti> Utenti { get; set; }
        public virtual DbSet<UtentiRegistrati> UtentiRegistrati { get; set; }
        public virtual DbSet<Visite> Visite { get; set; }
        public virtual DbSet<About> About { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
