//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ManageLibrary.Database
{
    using System;
    using System.Collections.Generic;
    
    public partial class READER
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public READER()
        {
            this.CARDS = new HashSet<CARD>();
        }
    
        public System.Guid idReader { get; set; }
        public string nameReader { get; set; }
        public Nullable<bool> sex { get; set; }
        public Nullable<System.DateTime> birthday { get; set; }
        public Nullable<System.Guid> idClass { get; set; }
        public string address { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CARD> CARDS { get; set; }
        public virtual CLASS CLASS { get; set; }
    }
}
