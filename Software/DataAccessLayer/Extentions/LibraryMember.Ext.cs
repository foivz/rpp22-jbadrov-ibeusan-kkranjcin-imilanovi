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
