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
    
    public partial class DEF_LOCATION
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DEF_LOCATION()
        {
            this.DEF_SUPER_MARKET = new HashSet<DEF_SUPER_MARKET>();
        }
    
        public string LOCATION_ID { get; set; }
        public string CITY { get; set; }
        public string NO { get; set; }
        public string LANE { get; set; }
        public Nullable<decimal> PROVINCE_ID { get; set; }
        public string LAND_MARK { get; set; }
        public Nullable<System.DateTime> CREATED_DATE { get; set; }
        public string CREATED_USER { get; set; }
        public Nullable<System.DateTime> MODIFIED_DATE { get; set; }
        public string MODIFIED_USER { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DEF_SUPER_MARKET> DEF_SUPER_MARKET { get; set; }
    }
}