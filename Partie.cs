//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServiceWeb2
{
    using System;
    using System.Collections.Generic;
    
    public partial class Partie
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Partie()
        {
            this.Salle = new HashSet<Salle>();
        }
    
        public int Id { get; set; }
        public Nullable<int> id_personnage { get; set; }
        public Nullable<int> salle_actuelle { get; set; }
        public Nullable<int> difficulte { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Salle> Salle { get; set; }

        public PartieDto toDto()
        {
            return new Mapping().toDto(this);
        }
    }
}