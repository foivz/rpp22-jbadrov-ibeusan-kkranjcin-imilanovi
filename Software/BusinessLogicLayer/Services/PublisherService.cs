using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using DataAccessLayer.Repositories;

namespace BusinessLogicLayer.Services
{
    internal class PublisherService
    {

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

        public bool UpdatePublisher(Publisher publisher)
        {
            using (var repo = new PublisherRepository())
            {
                var num = repo.Update(publisher);
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

        public bool DeletePublisher(Publisher publisher)
        {
            using (var repo = new PublisherRepository())
            {
                var num = repo.Delete(publisher);
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
