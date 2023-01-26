using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibRes
{
    public static class LibResUser
    {
        public static User CurrentUser { get; set; }

        public static bool IsAdmin()
        {
            if(CurrentUser.IdRole == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
