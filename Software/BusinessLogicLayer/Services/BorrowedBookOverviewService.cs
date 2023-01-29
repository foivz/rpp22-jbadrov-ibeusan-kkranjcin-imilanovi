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

        /// <summary>
        /// Checks if reservation time ended for any of the reserved books
        /// </summary>
        private static void OnTimedEvent(object source, ElapsedEventArgs e)
        {
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
        }

        /// <summary>
        /// Adds the <paramref name="borrowedBookOverview"/> into the database
        /// </summary>
        /// <param name="borrowedBookOverview"><see cref="BorrowedBookOverview"/> intended for adding into the database</param>
        /// <returns><see langword="True"/> if borrowed book overview was added successfully, <see langword="False"/> if problem occurred</returns>
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

        /// <summary>
        /// Updates the <paramref name="borrowedBookOverview"/> in the database
        /// </summary>
        /// <param name="borrowedBookOverview"><see cref="BorrowedBookOverview"/> intended for updating in the database</param>
        /// <returns><see langword="True"/> if update is successful, <see langword="False"/> if not</returns>
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

        /// <summary>
        /// Deletes the <paramref name="borrowedBookOverview"/> from the database
        /// </summary>
        /// <param name="borrowedBookOverview">Borrowed book overview intended for deleting from the database</param>
        /// <returns><see langword="True"/> if delete is successful, <see langword="False"/> if not</returns>
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

        /// <summary>
        /// Gets all borrowed book overviews
        /// </summary>
        /// <returns>List of <see cref="BorrowedBookOverview"/> objects</returns>
        public List<BorrowedBookOverview> GetBorrowedBookOverviews()
        {
            using(var repo = new BorrowedBookOverviewRepository())
            {
                var borrowedBookOverviews = repo.GetAll();
                return borrowedBookOverviews.ToList();
            }
        }

        /// <summary>
        /// Gets details about borrowed book by given library member
        /// </summary>
        /// <param name="libraryMemberId">Id of a library member</param>
        /// <returns>List of <see cref="BorrowedBookDetails"/> objects</returns>
        public List<BorrowedBookDetails> GetDetailsByLibraryMember(int libraryMemberId)
        {
            using (var repo = new BorrowedBookOverviewRepository())
            {
                var borrowedBookOverviews = repo.GetDetailsByLibraryMember(libraryMemberId);
                return borrowedBookOverviews.ToList();
            }
        }

        /// <summary>
        /// Gets book overview for given id of a book and id of a library member
        /// </summary>
        /// <param name="bookId"></param>
        /// <param name="libraryMemberId"></param>
        /// <returns>List of <see cref="BorrowedBookOverview"/> objects</returns>
        public List<BorrowedBookOverview> GetBookOverviewByIdBookAndIdLibraryMember(int bookId, int libraryMemberId)
        {
            using (var repo = new BorrowedBookOverviewRepository())
            {
                var borrowedBookOverviews = repo.GetByBookIdAndLibraryMemberId(bookId, libraryMemberId);
                return borrowedBookOverviews.ToList();
            }
        }

        /// <summary>
        /// Gets book overview by given <paramref name="id"/>
        /// </summary>
        /// <param name="id">Id of a book overview</param>
        /// <returns>List of <see cref="BorrowedBookOverview"/> objects</returns>
        public List<BorrowedBookOverview> GetBorrowedBookOverviewsById(int id)
        {
            using (var repo = new BorrowedBookOverviewRepository())
            {
                var borrowedBookOverviews = repo.GetById(id);
                return borrowedBookOverviews.ToList();
            }
        }

        /// <summary>
        /// Gets book overviews for reserved book
        /// </summary>
        /// <param name="idBook">Id of a book that is being checked for reservation</param>
        /// <returns>List of <see cref="BorrowedBookOverview"/> objects</returns>
        public List<BorrowedBookOverview> GetReservedBookOverviewsByIdBook(int idBook)
        {
            using (var repo = new BorrowedBookOverviewRepository())
            {
                var borrowedBookOverviews = repo.GetReservedByIdBook(idBook);
                return borrowedBookOverviews.ToList();
            }
        }

        /// <summary>
        /// Checks if book is reserved
        /// </summary>
        /// <param name="id">Id of a book that is being checked for reservation</param>
        /// <returns><see langword="True"/> if book is reserved, <see langword="False"/> if it is not</returns>
        public bool IsReserved(int id)
        {
            using(var repo = new BorrowedBookOverviewRepository())
            {
                return repo.IsReserved(id);
            }
        }

        /// <summary>
        /// Checks if book is borrowed
        /// </summary>
        /// <param name="id">Id of a book that is being checked</param>
        /// <returns><see langword="True"/> if book is borrowed, <see langword="False"/> if it is not</returns>
        public bool IsBorrowed(int id)
        {
            using (var repo = new BorrowedBookOverviewRepository())
            {
                return repo.IsBorrowed(id);
            }
        }

        /// <summary>
        /// Checks if book in reserved for specific library member
        /// </summary>
        /// <param name="bookId">Id of a book that is being checked for reservation</param>
        /// <param name="libraryMemberId">Id of a library member that is being checked for reservation</param>
        /// <returns><see langword="True"/> if book is reserved by the library member, <see langword="False"/> if it is not</returns>
        public bool IsReservedForLibraryMember(int bookId, int libraryMemberId)
        {
            using (var repo = new BorrowedBookOverviewRepository())
            {
                return repo.IsReservedForLibraryMember(bookId, libraryMemberId);
            }
        }
    }
}
