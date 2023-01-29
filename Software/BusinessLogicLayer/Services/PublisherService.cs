using System.Collections.Generic;
using System.Linq;
using DataAccessLayer;
using DataAccessLayer.Repositories;

namespace BusinessLogicLayer.Services
{
    public class PublisherService
    {
        /// <summary>
        /// Adds the <paramref name="publisher"/> into the database
        /// </summary>
        /// <param name="publisher">Publisher of the book intended for adding into the database</param>
        /// <returns><see langword="True"/> if publisher was added successfully, <see langword="False"/> if problem occurred</returns>
        public bool AddPublisher(Publisher publisher)
        {
            using (var repo = new PublisherRepository())
            {
                var num = repo.Add(publisher);
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
        /// Gets all publishers
        /// </summary>
        /// <returns>List of <see cref="Publisher"/> objects</returns>
        public List<Publisher> GetPublishers()
        {
            using(var repo = new PublisherRepository())
            {
                var publishers = repo.GetAll();
                return publishers.ToList();
            }
        }
    }
}
