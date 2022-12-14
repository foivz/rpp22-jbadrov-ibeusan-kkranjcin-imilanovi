using EntityLayer.Entities;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace DataAccessLayer
{
    public partial class LibResModel : DbContext
    {
        public LibResModel()
            : base("name=LibResModel")
        {
        }

        public virtual DbSet<Author> Authors { get; set; }
        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<BookAuthor> BookAuthors { get; set; }
        public virtual DbSet<BookGenre> BookGenres { get; set; }
        public virtual DbSet<BorrowableBookCopy> BorrowableBookCopies { get; set; }
        public virtual DbSet<BorrowableBookState> BorrowableBookStates { get; set; }
        public virtual DbSet<BorrowedBookOverview> BorrowedBookOverviews { get; set; }
        public virtual DbSet<BorrowedBookState> BorrowedBookStates { get; set; }
        public virtual DbSet<Genre> Genres { get; set; }
        public virtual DbSet<LibraryMember> LibraryMembers { get; set; }
        public virtual DbSet<Publisher> Publishers { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<UnborrowableBookCopy> UnborrowableBookCopies { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author>()
                .HasMany(e => e.BookAuthors)
                .WithOptional(e => e.Author)
                .HasForeignKey(e => e.IdAuthor);

            modelBuilder.Entity<Book>()
                .HasMany(e => e.BookAuthors)
                .WithOptional(e => e.Book)
                .HasForeignKey(e => e.IdBook);

            modelBuilder.Entity<Book>()
                .HasMany(e => e.BookGenres)
                .WithOptional(e => e.Book)
                .HasForeignKey(e => e.IdBook);

            modelBuilder.Entity<Book>()
                .HasMany(e => e.UnborrowableBookCopies)
                .WithOptional(e => e.Book)
                .HasForeignKey(e => e.IdBook);

            modelBuilder.Entity<BorrowableBookCopy>()
                .Property(e => e.Edition)
                .IsUnicode(false);

            modelBuilder.Entity<BorrowableBookCopy>()
                .HasMany(e => e.BorrowedBookOverviews)
                .WithOptional(e => e.BorrowableBookCopy)
                .HasForeignKey(e => e.IdBook);

            modelBuilder.Entity<BorrowableBookState>()
                .HasMany(e => e.Books)
                .WithOptional(e => e.BorrowableBookState)
                .HasForeignKey(e => e.IdBorrowableState);

            modelBuilder.Entity<BorrowedBookState>()
                .HasMany(e => e.BorrowedBookOverviews)
                .WithOptional(e => e.BorrowedBookState)
                .HasForeignKey(e => e.IdState);

            modelBuilder.Entity<Genre>()
                .HasMany(e => e.BookGenres)
                .WithOptional(e => e.Genre)
                .HasForeignKey(e => e.IdGenre);

            modelBuilder.Entity<LibraryMember>()
                .HasMany(e => e.BorrowedBookOverviews)
                .WithOptional(e => e.LibraryMember)
                .HasForeignKey(e => e.IdLibraryMember);

            modelBuilder.Entity<Publisher>()
                .HasMany(e => e.UnborrowableBookCopies)
                .WithOptional(e => e.Publisher)
                .HasForeignKey(e => e.IdPublisher);

            modelBuilder.Entity<Role>()
                .HasMany(e => e.Users)
                .WithOptional(e => e.Role)
                .HasForeignKey(e => e.IdRole);
        }
    }
}
