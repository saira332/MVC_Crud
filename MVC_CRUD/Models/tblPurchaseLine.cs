//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVC_CRUD.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblPurchaseLine
    {
        public int PurchaseLineId { get; set; }
        public Nullable<int> PurchaseId { get; set; }
        public string ItemName { get; set; }
        public int Qyt { get; set; }
        public int Rate { get; set; }
    }
}
