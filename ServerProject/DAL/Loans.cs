//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Loans
    {
        public int Id { get; set; }
        public int BorrowerId { get; set; }
        public decimal Money { get; set; }
    
        public virtual Customers Customers { get; set; }
    }
}