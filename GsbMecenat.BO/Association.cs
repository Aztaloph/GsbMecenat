//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class Association
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Association()
        {
            this.Partenariats = new HashSet<Partenariat>();
        }
    
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Responsable { get; set; }
        public string CodeISOPays { get; set; }
        public int IdMission { get; set; }
    
        public virtual Pay Pay { get; set; }
        public virtual Mission Mission { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Partenariat> Partenariats { get; set; }
    }
}
