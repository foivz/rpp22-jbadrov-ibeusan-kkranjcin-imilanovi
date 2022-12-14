namespace EntityLayer.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("BorrowableBookCopy")]
    public partial class BorrowableBookCopy
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BorrowableBookCopy()
        {
            BorrowedBookOverviews = new HashSet<BorrowedBookOverview>();
        }

        public int Id { get; set; }

        [StringLength(10)]
        public string Edition { get; set; }

        public DateTime? BorrowDate { get; set; }

        public DateTime? ReturnDate { get; set; }

        public int? IdPublisher { get; set; }

        public int? IdBook { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BorrowedBookOverview> BorrowedBookOverviews { get; set; }
    }
}
