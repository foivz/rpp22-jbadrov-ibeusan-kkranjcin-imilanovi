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
        /// <summary>
        /// Adds the <paramref name="libraryMember"/> into the DB
        /// </summary>
        /// <param name="libraryMember">The library memeber intended for adding into the database</param>
        /// <returns><see langword="True"/> if add is successfull, <see langword="False"/> if not</returns>
        /// <exception cref="Exception">Throws <see cref="Exception"/> if member e-mail adress is invalid</exception>
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

        /// <summary>
        /// Updates the <paramref name="libraryMember"/> inside the DB
        /// </summary>
        /// <param name="libraryMember">The library memeber intended for updating inside the database</param>
        /// <returns><see langword="True"/> if update is successfull, <see langword="False"/> if not</returns>
        /// <exception cref="Exception">Throws <see cref="Exception"/> if member e-mail adress is invalid</exception>
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

        /// <summary>
        /// Deletes the <paramref name="libraryMember"/> inside the DB
        /// </summary>
        /// <param name="libraryMember">The library memeber intended for deleting inside the database</param>
        /// <returns><see langword="True"/> if delete is successfull, <see langword="False"/> if not</returns>
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

        /// <summary>
        /// Gets all library members
        /// </summary>
        /// <returns>List of <see cref="LibraryMember"/> objects</returns>
        public List<LibraryMember> GetLibraryMembers()
        {
            using(var repo = new LibraryMemberRepository())
            {
                var libraryMembers = repo.GetAll();
                return libraryMembers.ToList();
            }
        }

        /// <summary>
        /// Gets the <see cref="LibraryMember"/> with the matching <paramref name="id"/>
        /// </summary>
        /// <param name="id"></param>
        /// <returns>List containing only one <see cref="LibraryMember"/> object.</returns>
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
