//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Toci.CarRental.Dal.EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class car
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public car()
        {
            this.carfeaturemap = new HashSet<carfeaturemap>();
            this.rental = new HashSet<rental>();
        }
    
        public int id { get; set; }
        public string mark { get; set; }
        public string model { get; set; }
        public string vin { get; set; }
        public string color { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<carfeaturemap> carfeaturemap { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<rental> rental { get; set; }
    }
}
