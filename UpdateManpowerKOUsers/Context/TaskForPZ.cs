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
    
    public partial class TaskForPZ
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TaskForPZ()
        {
            this.Debit_WorkBit = new HashSet<Debit_WorkBit>();
        }
    
        public int id { get; set; }
        public string taskName { get; set; }
        public string id_User { get; set; }
        public int step { get; set; }
        public int time { get; set; }
        public int id_TypeTaskForPZ { get; set; }
        public Nullable<int> Predecessors { get; set; }
    
        public virtual AspNetUsers AspNetUsers { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Debit_WorkBit> Debit_WorkBit { get; set; }
        public virtual TypeTaskForPZ TypeTaskForPZ { get; set; }
    }
}
