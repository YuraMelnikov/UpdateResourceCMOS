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
    
    public partial class Debit_MT
    {
        public int id { get; set; }
        public int id_MatchingType { get; set; }
        public int id_Debit_WorkBit { get; set; }
        public Nullable<int> id_PlanZakaz { get; set; }
        public string NameMatchingType { get; set; }
        public Nullable<System.DateTime> dateClose { get; set; }
    }
}