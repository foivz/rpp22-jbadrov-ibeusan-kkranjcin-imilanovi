using BusinessLogicLayer.Services;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace LibRes
{
    public partial class FrmUpdateBook : Form
    {
        private Book _book;
        BookService bookService = new BookService();
        AuthorService authorService = new AuthorService();
        GenreService genreService = new GenreService();
        BookAuthorService bookAuthorService = new BookAuthorService();
        BookGenreService bookGenreService = new BookGenreService();

        public FrmUpdateBook(Book book)
        {
            InitializeComponent();
            _book = book;
        }

        private void FrmUpdateBook_Load(object sender, EventArgs e)
        {
            ShowBookData();
        }

        private void ShowBookData()
        {
            var updatedBook = GetUpdatedBook();

            if (updatedBook.BorrowableBookState.Id == 1)
            {
                chbBorrowable.Checked = true;
                txtTitle.Text = updatedBook.Title;
                clbAuthors.DataSource = authorService.GetAuthors();
                
                var indexesOfAuthors = ItemsComparisonAuthors();
                foreach(var i in indexesOfAuthors)
                {
                    clbAuthors.SetItemCheckState(i, CheckState.Checked);
                }

                clbGenres.DataSource = genreService.GetGenres();
                var indexesOfGenres = ItemsComparisonGenres();
                foreach (var i in indexesOfGenres)
                {
                    clbGenres.SetItemCheckState(i, CheckState.Checked);
                }

                nudNumberOfPages.Value = (decimal)updatedBook.NumberOfPages;
                txtISBN.Text = updatedBook.ISBN;
            }
            else if (updatedBook.BorrowableBookState.Id == 2)
            {
                chbBorrowable.Checked = false;
                txtTitle.Text = updatedBook.Title;
                clbAuthors.DataSource = authorService.GetAuthors();

                var indexesOfAuthors = ItemsComparisonAuthors();
                foreach (var i in indexesOfAuthors)
                {
                    clbAuthors.SetItemCheckState(i, CheckState.Checked);
                }

                clbGenres.DataSource = genreService.GetGenres();
                var indexesOfGenres = ItemsComparisonGenres();
                foreach (var i in indexesOfGenres)
                {
                    clbGenres.SetItemCheckState(i, CheckState.Checked);
                }

                nudNumberOfPages.Value = (decimal)updatedBook.NumberOfPages;
                txtISBN.Text = updatedBook.ISBN;
            }
        }

        private List<int> ItemsComparisonGenres()
        {
            var updatedBook = GetUpdatedBook();

            var bookGenres = updatedBook.BookGenres.ToList();
            var genres = genreService.GetGenres();
            List<int> indexes = new List<int>();
            foreach (var genre in genres)
            {
                foreach (var bookGenre in bookGenres)
                {
                    if (genre.Id == bookGenre.Genre.Id)
                    {
                        indexes.Add(genres.IndexOf(genre));
                    }
                }
            }
            return indexes;
        }

        private List<int> ItemsComparisonAuthors()
        {
            var updatedBook = GetUpdatedBook();
            var bookAuthors = updatedBook.BookAuthors.ToList();
            var authors = authorService.GetAuthors();
            List<int> indexes = new List<int>();
            foreach (var author in authors)
            {
                foreach (var bookAuthor in bookAuthors) 
                { 
                    if (author.Id == bookAuthor.Author.Id)
                    {
                        indexes.Add(authors.IndexOf(author));
                    }
                }
            }
            return indexes;
        }

        private void btnUpdateBook_Click(object sender, EventArgs e)
        {
            try
            {
                var updatedBook = GetUpdatedBook();
                var hasChanged = false;

                updatedBook.Title = txtTitle.Text;
                updatedBook.NumberOfPages = (int?)nudNumberOfPages.Value;
                updatedBook.ISBN = txtISBN.Text;
                if (chbBorrowable.Checked)
                {
                    updatedBook.IdBorrowableState = 1;
                }
                else
                {
                    updatedBook.IdBorrowableState = 2;
                }

                var bookAuthorsList = updatedBook.BookAuthors.ToList();
                var authorsCount = clbAuthors.Items.Count;
                for (int i = 0; i < authorsCount; i++)
                {
                    var author = clbAuthors.Items[i] as Author;

                    if (clbAuthors.GetItemChecked(i))
                    {
                        if (bookAuthorsList.Count == 0)
                        {
                            var bookAuthor = new BookAuthor
                            {
                                IdBook = updatedBook.Id,
                                IdAuthor = author.Id
                            };
                            if (bookAuthorService.AddBookAuthor(bookAuthor))
                            {
                                hasChanged = true;
                            }
                        }
                        else
                        {
                            bool hasAuthor = false;
                            foreach (var a in bookAuthorsList)
                            {
                                if (a.IdAuthor == author.Id)
                                {
                                    hasAuthor = true;
                                }
                            }
                            if (!hasAuthor)
                            {
                                var bookAuthor = new BookAuthor
                                {
                                    IdBook = updatedBook.Id,
                                    IdAuthor = author.Id
                                };
                                if (bookAuthorService.AddBookAuthor(bookAuthor))
                                {
                                    hasChanged = true;
                                }
                            }
                        }
                    }
                    else
                    {
                        foreach (var a in bookAuthorsList)
                        {
                            if (a.IdAuthor == author.Id)
                            {
                                if (bookAuthorService.DeleteBookAuthor(a))
                                {
                                    hasChanged = true;
                                }
                            }
                        }
                    }
                }

                var bookGenresList = updatedBook.BookGenres.ToList();
                var genresCount = clbGenres.Items.Count;
                for (int i = 0; i < genresCount; i++)
                {
                    var genre = clbGenres.Items[i] as Genre;

                    if (clbGenres.GetItemChecked(i))
                    {
                        if (bookGenresList.Count == 0)
                        {
                            var bookGenre = new BookGenre
                            {
                                IdBook = updatedBook.Id,
                                IdGenre = genre.Id
                            };
                            if (bookGenreService.AddBookGenre(bookGenre))
                            {
                                hasChanged = true;
                            }
                        }
                        else
                        {
                            var hasGenre = false;
                            foreach (var g in bookGenresList)
                            {
                                if (g.IdGenre == genre.Id)
                                {
                                    hasGenre = true;
                                }
                            }
                            if (!hasGenre)
                            {
                                var bookGenre = new BookGenre
                                {
                                    IdBook = updatedBook.Id,
                                    IdGenre = genre.Id
                                };
                                if (bookGenreService.AddBookGenre(bookGenre))
                                {
                                    hasChanged = true;
                                }
                            }
                        }
                    }
                    else
                    {
                        foreach (var g in bookGenresList)
                        {
                            if (g.IdGenre == genre.Id)
                            {
                                if (bookGenreService.DeleteBookGenre(g))
                                {
                                    hasChanged = true;
                                }
                            }
                        }
                    }
                }
                if (bookService.UpdateBook(updatedBook) || hasChanged)
                {
                    MessageBox.Show("Successfully updated the book: " + updatedBook.Title + "!");
                }
                else
                {
                    MessageBox.Show("Nothing was changed!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            Close();
        }

        private Book GetUpdatedBook()
        {
            var bookUpdated = bookService.GetBookById(_book.Id);
            return bookUpdated[0];
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
