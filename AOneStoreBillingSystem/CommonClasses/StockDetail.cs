//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CommonClasses
{
    using System;
    using System.Collections.Generic;
    
    public partial class StockDetail
    {
        public int Id { get; set; }
        public long ProductId { get; set; }
        public string ProductName { get; set; }
        public long QuantityAvailable { get; set; }
        public decimal Price { get; set; }
        public string ProductDescription { get; set; }
        public string ProductAddedBy { get; set; }
    }
}