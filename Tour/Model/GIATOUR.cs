//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Tour.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class GIATOUR
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GIATOUR()
        {
            this.TOURDULICHes = new HashSet<TOURDULICH>();
        }
    
        public string IDGIATOUR { get; set; }
        public Nullable<System.DateTime> TGBatDau { get; set; }
        public Nullable<System.DateTime> TGKetThuc { get; set; }
        public Nullable<int> ThanhTien { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TOURDULICH> TOURDULICHes { get; set; }
    }
}
