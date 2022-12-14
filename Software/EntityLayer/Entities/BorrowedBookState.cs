namespace EntityLayer.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("BorrowedBookState")]
    public partial class BorrowedBookState
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BorrowedBookState()
        {
            BorrowedBookOverviews = new HashSet<BorrowedBookOverview>();
        }

        public int Id { get; set; }

        [StringLength(50)]
        public string State { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BorrowedBookOverview> BorrowedBookOverviews { get; set; }
    }
}
