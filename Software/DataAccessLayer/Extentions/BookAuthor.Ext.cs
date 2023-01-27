namespace DataAccessLayer
{
    public partial class BookAuthor
    {
        public override string ToString()
        {
            return Author.FirstName + ' ' + Author.LastName;
        }
    }
}
