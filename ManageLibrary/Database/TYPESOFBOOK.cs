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
    
    public partial class TYPESOFBOOK
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TYPESOFBOOK()
        {
            this.BOOKS = new HashSet<BOOK>();
        }
    
        public System.Guid idTypeOfBook { get; set; }
        public string nameTypeOfBook { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOOK> BOOKS { get; set; }
    }
}
