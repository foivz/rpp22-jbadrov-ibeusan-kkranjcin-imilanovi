using BusinessLogicLayer.Services;
using DataAccessLayer;
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
            foreach (var a in clbAuthors.SelectedItems)
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
            foreach(var g in clbGenres.SelectedItems)
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

            /*
            if (txtISBN.Text == "")
            {
                MessageBox.Show("Please write an ISBN for this book.");
                return;
            }*/

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
                MessageBox.Show("Successfully added the book!");
            }
            else
            {
                MessageBox.Show("Problem occurred while adding the book!");
            }

            var allBooks = bookService.GetBooks();
            int id = 0;
            foreach(var b in allBooks)
            {
                if(b.Id > id)
                {
                    id = b.Id;
                }
            }

            var lastBook = bookService.GetBookById(id);
            Book addedBook = new Book();
            foreach(var b in lastBook)
            {
                addedBook = b;
            }

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
