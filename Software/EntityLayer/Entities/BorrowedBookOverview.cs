namespace EntityLayer.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("BorrowedBookOverview")]
    public partial class BorrowedBookOverview
    {
        public int Id { get; set; }

        public int? IdBook { get; set; }

        public int? IdLibraryMember { get; set; }

        public int? IdState { get; set; }

        public virtual BorrowableBookCopy BorrowableBookCopy { get; set; }

        public virtual BorrowedBookState BorrowedBookState { get; set; }

        public virtual LibraryMember LibraryMember { get; set; }
    }
}
