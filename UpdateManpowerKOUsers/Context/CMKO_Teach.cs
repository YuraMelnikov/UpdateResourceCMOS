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
    
    public partial class CMKO_Teach
    {
        public int id { get; set; }
        public string id_CMKO_PeriodResult { get; set; }
        public string id_AspNetUsersTeacher { get; set; }
        public string id_AspNetUsersTeach { get; set; }
        public double cost { get; set; }
        public string description { get; set; }
        public System.DateTime datetimeCreate { get; set; }
        public string id_AspNetUsersCreate { get; set; }
        public System.DateTime datetimeUpdate { get; set; }
        public string id_AspNetUsersUpdate { get; set; }
        public string historyEdit { get; set; }
    
        public virtual AspNetUsers AspNetUsers { get; set; }
        public virtual AspNetUsers AspNetUsers1 { get; set; }
        public virtual AspNetUsers AspNetUsers2 { get; set; }
        public virtual AspNetUsers AspNetUsers3 { get; set; }
        public virtual CMKO_PeriodResult CMKO_PeriodResult { get; set; }
    }
}
