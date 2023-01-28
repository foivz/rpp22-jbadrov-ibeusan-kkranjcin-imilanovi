using System;
using System.Collections.Generic;
using System.Linq;
using System.Timers;
using DataAccessLayer;
using DataAccessLayer.DataGridViewModel;
using DataAccessLayer.Repositories;

namespace BusinessLogicLayer.Services
{
    public class BorrowedBookOverviewService
    {
        private readonly System.Timers.Timer _timer = new System.Timers.Timer(1000);
        

        public BorrowedBookOverviewService()
        {
            
            _timer.Elapsed += new ElapsedEventHandler(OnTimedEvent);
            _timer.Enabled = true;
        }

        private static void OnTimedEvent(object source, ElapsedEventArgs e)
        {
            //var dateTime = DateTime.Now;
            using(var repo = new BorrowedBookOverviewRepository())
            {
                var borrowedBookOverviews = repo.GetAll().ToList();
                foreach(var borrowedBookOverview in borrowedBookOverviews)
                {
                    if(borrowedBookOverview.ReturnDate < DateTime.Now && borrowedBookOverview.IdState == 3)
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

        public List<BorrowedBookDetails> GetDetailsByLibraryMember(int libraryMemberId)
        {
            using (var repo = new BorrowedBookOverviewRepository())
            {
                var borrowedBookOverviews = repo.GetDetailsByLibraryMember(libraryMemberId);
                return borrowedBookOverviews.ToList();
            }
        }

        public List<BorrowedBookOverview> GetBookOverviewByIdBookAndIdLibraryMember(int bookId, int libraryMemberId)
        {
            using (var repo = new BorrowedBookOverviewRepository())
            {
                var borrowedBookOverviews = repo.GetByBookIDAndLibraryMemberId(bookId, libraryMemberId);
                return borrowedBookOverviews.ToList();
            }
        }

        public List<BorrowedBookOverview> GetBorrowedBookOverviewsById(int id)
        {
            using (var repo = new BorrowedBookOverviewRepository())
            {
                var borrowedBookOverviews = repo.GetById(id);
                return borrowedBookOverviews.ToList();
            }
        }

        public List<BorrowedBookOverview> GetReserveddBookOverviewsByIdBook(int idBook)
        {
            using (var repo = new BorrowedBookOverviewRepository())
            {
                var borrowedBookOverviews = repo.GetReservedByIdBook(idBook);
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

        public bool IsBorrowed(int id)
        {
            using (var repo = new BorrowedBookOverviewRepository())
            {
                return repo.IsBorrowed(id);
            }
        }

        public bool IsReservedForLibraryMember(int bookId, int libraryMemberId)
        {
            using (var repo = new BorrowedBookOverviewRepository())
            {
                return repo.IsReservedForLibraryMember(bookId, libraryMemberId);
            }

        }
    }
}
