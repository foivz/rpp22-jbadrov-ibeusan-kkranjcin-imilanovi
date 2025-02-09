//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataAccessLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;

    public partial class BookCopy
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BookCopy()
        {
            this.BorrowedBookOverviews = new HashSet<BorrowedBookOverview>();
        }
    
        public int Id { get; set; }
        public string Edition { get; set; }

        public Nullable<int> IdPublisher { get; set; }
        public Nullable<int> IdBook { get; set; }
        public Nullable<int> YearOfPublication { get; set; }
        public string Language { get; set; }
    
        public virtual Publisher Publisher { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BorrowedBookOverview> BorrowedBookOverviews { get; set; }
        public virtual Book Book { get; set; }
    }
}
