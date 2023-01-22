using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public partial class LibraryMember
    {
        public override string ToString()
        {
            return Id.ToString() +" "+ FirstName + " " + LastName;
        }
    }
}
