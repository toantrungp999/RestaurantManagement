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
    using System.Collections.Generic;
    
    public partial class DetailBill
    {
        public int ID_Bill { get; set; }
        public int ID_Food { get; set; }
        public Nullable<int> Amount { get; set; }
        public Nullable<int> Sale { get; set; }
        public Nullable<int> Price { get; set; }
        public Nullable<int> ID_Employee { get; set; }
    
        public virtual Bill Bill { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual Food Food { get; set; }
    }
}
