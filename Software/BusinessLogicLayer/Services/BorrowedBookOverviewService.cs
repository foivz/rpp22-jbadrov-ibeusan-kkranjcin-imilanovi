using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using DataAccessLayer.Repositories;

namespace BusinessLogicLayer.Services_1
{
    internal class BorrowedBookOverviewService
    {
        public bool AddBorrowedBookOverview(BorrowedBookOverview borrowedBookOverview)
        {
            using (var repo = new BorrowedBookOverviewRepository())
            {
                var num = repo.Add(borrowedBookOverview);
                if (num > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public bool UpdateBorrowedBookOverview(BorrowedBookOverview borrowedBookOverview)
        {
            using (var repo = new BorrowedBookOverviewRepository())
            {
                var num = repo.Update(borrowedBookOverview);
                if (num > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public bool DeleteBorrowedBookOverview(BorrowedBookOverview borrowedBookOverview)
        {
            using (var repo = new BorrowedBookOverviewRepository())
            {
                var num = repo.Delete(borrowedBookOverview);
                if (num > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public List<BorrowedBookOverview> GetBorrowedBookOverviews()
        {
            using(var repo = new BorrowedBookOverviewRepository())
            {
                var borrowedBookOverviews = repo.GetAll();
                return borrowedBookOverviews.ToList();
            }
        }
    }
}
