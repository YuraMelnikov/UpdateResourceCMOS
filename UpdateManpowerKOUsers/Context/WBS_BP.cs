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
    
    public partial class WBS_BP
    {
        public int id { get; set; }
        public int id_PZ_PlanZakaz { get; set; }
        public int id_WBS { get; set; }
        public double duration { get; set; }
        public System.DateTime start { get; set; }
        public System.DateTime finish { get; set; }
        public double work { get; set; }
        public double percentComplite { get; set; }
        public double percentWorkComplite { get; set; }
    }
}