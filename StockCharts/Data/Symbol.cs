//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StockCharts.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Symbol
    {
        public Symbol()
        {
            this.Quotes = new HashSet<Quote>();
        }
    
        public long SymbolId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    
        public virtual ICollection<Quote> Quotes { get; set; }
    }
}
