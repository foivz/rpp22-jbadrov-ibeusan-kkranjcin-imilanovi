using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using DataAccessLayer;
using DataAccessLayer.Repositories;

namespace BusinessLogicLayer.Services
{
    public class LibraryMemberService
    {
        public bool AddLibraryMember(LibraryMember libraryMember)
        {
            var email = libraryMember.Email;
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(email);
            if (match.Success)
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
            else
            {
                throw new Exception("Member e-mail is not a valid e-mail adress");
            }
        }

        public bool UpdateLibraryMember(LibraryMember libraryMember)
        {
            var email = libraryMember.Email;
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(email);
            if (!match.Success)
            {
                throw new Exception("The e-mail adress you provided is not valid!");
            }
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

        public List<LibraryMember> GetLibraryMemberById(int id)
        {
            using (var repo = new LibraryMemberRepository())
            {
                var libraryMembers = repo.GetById(id);
                return libraryMembers.ToList();
            }
        }
    }
}
