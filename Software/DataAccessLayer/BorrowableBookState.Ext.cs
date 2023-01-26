using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public partial class BorrowableBookState
    {
        public override string ToString()
        {
            if(State == "borrowable")
            {
                return "\u2713";
            }
            else
            {
                return "\u2715";
            }
        }
    }
}
