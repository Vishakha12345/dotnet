//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ECommAppORM
{
    using System;
    using System.Collections.Generic;
    
    public partial class Payment
    {
        public int PaymentId { get; set; }
        public Nullable<int> OrderId { get; set; }
        public Nullable<System.DateTime> PaymentDate { get; set; }
        public string PaymentMode { get; set; }
        public Nullable<decimal> Amount { get; set; }
    }
}
