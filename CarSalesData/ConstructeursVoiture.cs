//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CarSalesData
{
    using System;
    using System.Collections.Generic;
    
    public partial class ConstructeursVoiture
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ConstructeursVoiture()
        {
            this.Vehicule = new HashSet<Vehicule>();
        }
    
        public string Nom { get; set; }
        public string Adresse1 { get; set; }
        public string Adresse2 { get; set; }
        public string Zip { get; set; }
        public string Ville { get; set; }
        public string Pays { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Vehicule> Vehicule { get; set; }
    }
}