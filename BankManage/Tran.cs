//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BankManage
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tran
    {
        public string STK { get; set; }
        public string MaGD { get; set; }
        public string LoaiGD { get; set; }
        public Nullable<int> Money { get; set; }
        public Nullable<System.DateTime> ThoigianGD { get; set; }
        public string ReceivedSTK { get; set; }
    
        public virtual Customer Customer { get; set; }
        public virtual Customer Customer1 { get; set; }
    }
}