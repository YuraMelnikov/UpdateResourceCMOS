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
    
    public partial class SandwichPanel
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SandwichPanel()
        {
            this.SandwichPanel_PZ = new HashSet<SandwichPanel_PZ>();
        }
    
        public int id { get; set; }
        public Nullable<int> id_SandwichPanelCustomer { get; set; }
        public string id_AspNetUsersCreate { get; set; }
        public string numberOrder { get; set; }
        public string folder { get; set; }
        public bool onApprove { get; set; }
        public System.DateTime datetimeCreate { get; set; }
        public Nullable<System.DateTime> datetimeToCorrection { get; set; }
        public bool onCorrection { get; set; }
        public Nullable<System.DateTime> datetimeUploadNewVersion { get; set; }
        public bool onCustomer { get; set; }
        public Nullable<System.DateTime> datetimeToCustomer { get; set; }
        public bool onGetDateComplited { get; set; }
        public Nullable<System.DateTime> datetimePlanComplited { get; set; }
        public bool onComplited { get; set; }
        public Nullable<System.DateTime> datetimeComplited { get; set; }
        public bool remove { get; set; }
    
        public virtual AspNetUsers AspNetUsers { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SandwichPanel_PZ> SandwichPanel_PZ { get; set; }
        public virtual SandwichPanelCustomer SandwichPanelCustomer { get; set; }
    }
}
