//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace partI.DB_Layer
{
    using System;
    
    public partial class GetCancelledReport_Result
    {
        public int ID_Bill { get; set; }
        public int ID_Food { get; set; }
        public string FoodName { get; set; }
        public Nullable<int> Price { get; set; }
        public Nullable<int> Sale { get; set; }
        public Nullable<int> Location { get; set; }
        public int ID_Employee { get; set; }
        public string Name { get; set; }
        public Nullable<System.DateTime> Time { get; set; }
        public string Reason { get; set; }
    }
}
