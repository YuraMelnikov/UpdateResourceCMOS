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
    
    public partial class RKD_TaskVersion
    {
        public int id { get; set; }
        public int id_RKD_Version { get; set; }
        public int id_RKD_Task { get; set; }
        public System.DateTime finishDate { get; set; }
        public bool tpComplited { get; set; }
        public bool allComplited { get; set; }
        public Nullable<bool> uslovnoeComplited { get; set; }
        public Nullable<bool> osComplited { get; set; }
        public Nullable<bool> manufComplited { get; set; }
    
        public virtual RKD_Task RKD_Task { get; set; }
        public virtual RKD_Version RKD_Version { get; set; }
    }
}
