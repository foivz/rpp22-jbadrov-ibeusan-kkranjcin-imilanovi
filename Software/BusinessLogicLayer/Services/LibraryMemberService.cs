using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using DataAccessLayer.Repositories;

namespace BusinessLogicLayer.Services
{
    internal class LibraryMemberService
    {
        public bool AddLibraryMember(LibraryMember libraryMember)
        {
            using (var repo = new LibraryMemberRepository())
            {
                var num = repo.Add(libraryMember);
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

        public bool UpdateLibraryMember(LibraryMember libraryMember)
        {
            using (var repo = new LibraryMemberRepository())
            {
                var num = repo.Update(libraryMember);
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

        public bool DeleteLibraryMember(LibraryMember libraryMember)
        {
            using (var repo = new LibraryMemberRepository())
            {
                var num = repo.Delete(libraryMember);
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

        public List<LibraryMember> GetLibraryMembers()
        {
            using(var repo = new LibraryMemberRepository())
            {
                var libraryMembers = repo.GetAll();
                return libraryMembers.ToList();
            }
        }

        public LibraryMember GetLibraryMemberById(int id)
        {
            using (var repo = new LibraryMemberRepository())
            {
                var libraryMembers = repo.GetById(id);
                return libraryMembers as LibraryMember;
            }
        }
    }
}
