using System.Collections.Generic;
using System.Linq;
using DataAccessLayer;
using DataAccessLayer.Repositories;

namespace BusinessLogicLayer.Services
{
    public class BorrowedBookStateService
    {
        /// <summary>
        /// Gets all borrowed book states
        /// </summary>
        /// <returns>List of <see cref="BorrowedBookState"/> objects</returns>
        public List<BorrowedBookState> GetBorrowedBookStates()
        {
            using (var repo = new BorrowedBookStateRepository())
            {
                var borrowedBookStates = repo.GetAll();
                return borrowedBookStates.ToList();
            }
        }
    }
}
