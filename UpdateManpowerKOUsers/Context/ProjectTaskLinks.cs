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
    
    public partial class ProjectTaskLinks
    {
        public int id { get; set; }
        public int id_ProjectTaskPredecessor { get; set; }
        public int id_ProjectTaskSuccessor { get; set; }
        public int id_ProjectTypesLine { get; set; }
        public int lag { get; set; }
    
        public virtual ProjectTask ProjectTask { get; set; }
        public virtual ProjectTask ProjectTask1 { get; set; }
        public virtual ProjectTypesLine ProjectTypesLine { get; set; }
    }
}
