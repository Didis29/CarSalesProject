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
    
    public partial class VehiculeOccasion
    {
        public string Immatriculation { get; set; }
        public int KilometrageAchat { get; set; }
        public int KilometrageVente { get; set; }
    
        public virtual Vehicule Vehicule { get; set; }
    }
}