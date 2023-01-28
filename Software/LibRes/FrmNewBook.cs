using BusinessLogicLayer.Services;
using DataAccessLayer;
using LibRes.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace LibRes
{
    public partial class FrmNewBook : Form
    {
        public FrmNewBook()
        {
            InitializeComponent();
        }

        private void FrmNewBook_Load(object sender, EventArgs e)
        {
            ShowAllAuthors();
            ShowAllGenres();
        }

        private void ShowAllAuthors()
        {
            AuthorService authorService = new AuthorService();
            var authors = authorService.GetAuthors().ToList();
            clbAuthors.DataSource = authors;
        }

        private void ShowAllGenres()
        {
            GenreService genreService = new GenreService();
            var genres = genreService.GetGenres().ToList();
            clbGenres.DataSource = genres;
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            BookService bookService = new BookService();
            BookAuthorService bookAuthorService = new BookAuthorService();
            BookGenreService bookGenreService = new BookGenreService();

            if(txtTitle.Text == "")
            {
                MessageBox.Show("Please write the title for this book.");
                return;
            }

            List<Author> authorsList = new List<Author>();
            foreach (var a in clbAuthors.CheckedItems)
            {
                var author = a as Author;
                authorsList.Add(author);
            }
            if (authorsList.Count == 0)
            {
                MessageBox.Show("Please choose at least one author for this book.");
                return;
            }

            List<Genre> genresList = new List<Genre>();
            foreach (var g in clbGenres.CheckedItems)
            {
                var genre = g as Genre;
                genresList.Add(genre);
            }
            if (genresList.Count == 0)
            {
                MessageBox.Show("Please choose at least one genre for this book.");
                return;
            }

            if(nudNumberOfPages.Value == 0)
            {
                MessageBox.Show("Please add the number of pages for this book.");
                return;
            }

            if (bookService.IsInputCorrect(txtISBN.Text))
            {
                Book book;
                if (chbBorrowable.Checked == true)
                {
                    book = new Book
                    {
                        IdBorrowableState = 1,
                        Title = txtTitle.Text,
                        NumberOfPages = (int?)nudNumberOfPages.Value,
                        ISBN = txtISBN.Text
                    };
                }
                else
                {
                    book = new Book
                    {
                        IdBorrowableState = 2,
                        Title = txtTitle.Text,
                        NumberOfPages = (int?)nudNumberOfPages.Value,
                        ISBN = txtISBN.Text
                    };
                }

                if (bookService.AddBook(book))
                {
                    MessageBox.Show("Successfully added a new book: " + book.Title + "!");
                }
                else
                {
                    MessageBox.Show("Problem occurred while adding the book!");
                    return;
                }

                var allBooks = bookService.GetBooks();
                var addedBook = allBooks.Last();

                foreach (var author in authorsList)
                {
                    BookAuthor bookAuthor = new BookAuthor
                    {
                        IdBook = addedBook.Id,
                        IdAuthor = author.Id
                    };
                    bookAuthorService.AddBookAuthor(bookAuthor);
                }

                foreach (var genre in genresList)
                {
                    BookGenre bookGenre = new BookGenre
                    {
                        IdBook = addedBook.Id,
                        IdGenre = genre.Id
                    };
                    bookGenreService.AddBookGenre(bookGenre);
                }

                Close();
            }
            else
            {
                var ex = new UserInputException("Book ISBN should be 10 digits long and start with 978 or 979!");
                MessageBox.Show(ex.MessageForUser);
                return;
            }
        }

        private void btnAddAuthor_Click(object sender, EventArgs e)
        {
            FrmNewAuthor frmNewAuthor = new FrmNewAuthor();
            frmNewAuthor.ShowDialog();
            ShowAllAuthors();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
