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
    
    public partial class DEF_OFFERS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DEF_OFFERS()
        {
            this.ITEM_LIST = new HashSet<ITEM_LIST>();
            this.ITEM_LIST_LINE_ITEMS = new HashSet<ITEM_LIST_LINE_ITEMS>();
            this.ORDER_LINE_ITEMS = new HashSet<ORDER_LINE_ITEMS>();
        }
    
        public string OFFERS_ID { get; set; }
        public string DESCRIPTION { get; set; }
        public Nullable<decimal> OFFER_TYPE_ID { get; set; }
        public Nullable<decimal> DISCOUNT___ { get; set; }
        public Nullable<System.DateTime> START_DATE { get; set; }
        public Nullable<System.DateTime> END_DATE { get; set; }
        public Nullable<decimal> STATUS { get; set; }
        public string CREATED_USER { get; set; }
        public Nullable<System.DateTime> CREATED_DATE { get; set; }
        public string MODIFIED_USER { get; set; }
        public Nullable<System.DateTime> MODIFIED_DATE { get; set; }
    
        public virtual DEF_OFFER_TYPE DEF_OFFER_TYPE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ITEM_LIST> ITEM_LIST { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ITEM_LIST_LINE_ITEMS> ITEM_LIST_LINE_ITEMS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ORDER_LINE_ITEMS> ORDER_LINE_ITEMS { get; set; }
    }
}