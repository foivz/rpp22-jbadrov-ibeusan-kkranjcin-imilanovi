using System.Collections.Generic;
using System.Linq;
using DataAccessLayer;
using DataAccessLayer.Repositories;

namespace BusinessLogicLayer.Services
{
    internal class BookCopyStateService
    {
        public List <BorrowableBookState> GetBookStates()
        {
            using (var repo = new BookCopyStateRepository())
            {
               var bookCopyStates = repo.GetAll();
                return bookCopyStates.ToList();
               
            }
        }
    }
}
