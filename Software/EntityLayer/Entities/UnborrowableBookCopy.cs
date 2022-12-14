namespace EntityLayer.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("UnborrowableBookCopy")]
    public partial class UnborrowableBookCopy
    {
        public int Id { get; set; }

        [StringLength(10)]
        public string Edition { get; set; }

        public int? IdBook { get; set; }

        public int? IdPublisher { get; set; }

        public virtual Book Book { get; set; }

        public virtual Publisher Publisher { get; set; }
    }
}
