//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IC.Server.DataLayerModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class ProductPrice
    {
        public string StoreID { get; set; }
        public int ProductID { get; set; }
        public System.DateTime DateBegin { get; set; }
        public System.DateTime DateEnd { get; set; }
        public decimal PriceValue { get; set; }
    }
}
