using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using DataAccessLayer;
using DataAccessLayer.Repositories;

namespace BusinessLogicLayer.Services_1
{
    public class BorrowedBookOverviewService
    {
        private readonly System.Timers.Timer _timer = new System.Timers.Timer(300000);
        

        public BorrowedBookOverviewService()
        {
            
            _timer.Elapsed += new ElapsedEventHandler(OnTimedEvent);
            _timer.Enabled = true;
        }

        private static void OnTimedEvent(object source, ElapsedEventArgs e)
        {
            var dateTime = DateTime.Now;
            using(var repo = new BorrowedBookOverviewRepository())
            {
                var borrowedBookOverviews = repo.GetAll().ToList();
                foreach(var borrowedBookOverview in borrowedBookOverviews)
                {
                    if(borrowedBookOverview.ReturnDate >dateTime && borrowedBookOverview.IdState == 3)
                    {
                        repo.Delete(borrowedBookOverview);
                    }
                }
            }
            //foreach ()
        }
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

        public bool IsReserved(int id)
        {
            using(var repo = new BorrowedBookOverviewRepository())
            {
                return repo.IsReserved(id);
            }
        }
    }
}
