//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UpdateManpowerKOUsers.Context
{
    using System;
    using System.Collections.Generic;
    
    public partial class PostAlertShip
    {
        public int id { get; set; }
        public int id_Debit_WorkBit { get; set; }
        public System.DateTime datePost { get; set; }
        public string numPost { get; set; }
        public System.DateTime datePrihod { get; set; }
    
        public virtual Debit_WorkBit Debit_WorkBit { get; set; }
    }
}
