﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GsbMecenat.BO
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class GsbMecenatEntities : DbContext
    {
        public GsbMecenatEntities()
            : base("name=GsbMecenatEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ActionMecenat> ActionMecenats { get; set; }
        public virtual DbSet<Association> Associations { get; set; }
        public virtual DbSet<JournalIntervention> JournalInterventions { get; set; }
        public virtual DbSet<Mission> Missions { get; set; }
        public virtual DbSet<Partenariat> Partenariats { get; set; }
        public virtual DbSet<Pay> Pays { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<Utilisateur> Utilisateurs { get; set; }
    }
}
