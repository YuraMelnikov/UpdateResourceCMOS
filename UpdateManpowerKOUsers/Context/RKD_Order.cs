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
    
    public partial class RKD_Order
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RKD_Order()
        {
            this.RKD_Despatching = new HashSet<RKD_Despatching>();
            this.RKD_GIP = new HashSet<RKD_GIP>();
            this.RKD_Question = new HashSet<RKD_Question>();
            this.RKD_Task = new HashSet<RKD_Task>();
            this.RKD_Version = new HashSet<RKD_Version>();
        }
    
        public int id { get; set; }
        public int id_PZ_PlanZakaz { get; set; }
        public int id_RKD_Institute { get; set; }
        public System.DateTime datePlanCritical { get; set; }
    
        public virtual PZ_PlanZakaz PZ_PlanZakaz { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RKD_Despatching> RKD_Despatching { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RKD_GIP> RKD_GIP { get; set; }
        public virtual RKD_Institute RKD_Institute { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RKD_Question> RKD_Question { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RKD_Task> RKD_Task { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RKD_Version> RKD_Version { get; set; }
    }
}