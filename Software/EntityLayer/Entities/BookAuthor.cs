namespace EntityLayer.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class BookAuthor
    {
        public int Id { get; set; }

        public int? IdBook { get; set; }

        public int? IdAuthor { get; set; }

        public virtual Author Author { get; set; }

        public virtual Book Book { get; set; }
    }
}
