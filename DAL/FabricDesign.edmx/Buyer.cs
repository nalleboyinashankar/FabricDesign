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
    
    public partial class Buyer
    {
        public int Id { get; set; }
        public string BuyerName { get; set; }
        public Nullable<int> Countryid { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public Nullable<int> BuyingHouseId { get; set; }
        public Nullable<int> CommissionTypeId { get; set; }
        public Nullable<double> CommissionPercentage { get; set; }
    }
}
