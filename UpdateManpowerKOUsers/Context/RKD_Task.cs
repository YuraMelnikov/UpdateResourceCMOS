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
    
    public partial class RKD_Task
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RKD_Task()
        {
            this.RKD_TaskVersion = new HashSet<RKD_TaskVersion>();
        }
    
        public int id { get; set; }
        public int id_RKD_Order { get; set; }
        public int id_RKD_TypeTask { get; set; }
        public Nullable<System.Guid> UID_Task { get; set; }
    
        public virtual RKD_Order RKD_Order { get; set; }
        public virtual RKD_TypeTask RKD_TypeTask { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RKD_TaskVersion> RKD_TaskVersion { get; set; }
    }
}
