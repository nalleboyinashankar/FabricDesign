//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL.FabricDesign.edmx
{
    using System;
    using System.Collections.Generic;
    
    public partial class FactoryList
    {
        public int Id { get; set; }
        public string FactoryName { get; set; }
        public string City { get; set; }
        public Nullable<int> State { get; set; }
        public Nullable<int> Country { get; set; }
        public string CreatedByUserId { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public string UpdatedByUserId { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
    }
}
