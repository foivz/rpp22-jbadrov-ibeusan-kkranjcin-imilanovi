using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    internal class BookJoinBookCopies
    {
        public string Title { get; set; }
        public int NumberOfPages { get; set; }
        public int BorrowableState { get; set; }
        public string ISBN { get; set; }
        public string Edition { get; set; }
        public int IdPublisher { get; set; }
        public int YearOfPublication { get; set; }
        public string Language { get; set; }
    }
}
