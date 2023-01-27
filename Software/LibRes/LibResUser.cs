using DataAccessLayer;

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
