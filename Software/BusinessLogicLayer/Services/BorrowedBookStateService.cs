using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using DataAccessLayer.Repositories;

namespace BusinessLogicLayer.Services
{
    internal class BorrowedBookStateService
    {

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
