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
    
    public partial class ORDER_LINE_ITEMS
    {
        public decimal ORDER_ID { get; set; }
        public decimal PRODUCT_ID { get; set; }
        public Nullable<decimal> QUANTITY { get; set; }
        public Nullable<decimal> PRICE { get; set; }
        public Nullable<decimal> TOTAL_AMOUNT { get; set; }
        public string OFFERS_ID { get; set; }
    
        public virtual DEF_OFFERS DEF_OFFERS { get; set; }
        public virtual DEF_PRODUCT DEF_PRODUCT { get; set; }
    }
}
