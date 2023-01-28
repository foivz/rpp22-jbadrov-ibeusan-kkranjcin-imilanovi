using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.DataGridViewModel
{
    public class BorrowedBookDetails
    {
        public int Id { get; set; }
        public DateTime? BorrowedDate { get; set; }
        public DateTime? ReturnDate { get; set; }
        public string Title { get; set; }
    }
}
