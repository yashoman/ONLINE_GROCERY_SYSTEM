//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OGS_Library
{
    using System;
    using System.Collections.Generic;
    
    public partial class DEF_OFFER_TYPE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DEF_OFFER_TYPE()
        {
            this.DEF_OFFERS = new HashSet<DEF_OFFERS>();
        }
    
        public decimal OFFER_TYPE_ID { get; set; }
        public string OFFER_TYPE { get; set; }
        public Nullable<System.DateTime> CREATED_DATE { get; set; }
        public string CREATED_USER { get; set; }
        public Nullable<System.DateTime> MODIFIED_DATE { get; set; }
        public string MODIFIED_USER { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DEF_OFFERS> DEF_OFFERS { get; set; }
    }
}
