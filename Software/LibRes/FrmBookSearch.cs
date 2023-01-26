using BusinessLogicLayer.Services;
using DataAccessLayer;
using System;
using System.Linq;
using System.Windows.Forms;

namespace LibRes
{
    public partial class FrmBookSearch : Form
    {
        public FrmBookSearch()
        {
            InitializeComponent();
        }

        private void FrmBookSearch_Load(object sender, EventArgs e)
        {
            ShowAllBooks();
        }

        private void ShowAllBooks()
        {
            BookService bookService = new BookService();
            var books = bookService.GetBooks();
            dgvBooks.DataSource = books;

            dgvBooks.Columns[2].HeaderText = "Number of pages";
            dgvBooks.Columns[5].HeaderText = "Borrowable";
            dgvBooks.Columns[0].Visible = false;
            dgvBooks.Columns[3].Visible = false;
            dgvBooks.Columns[6].Visible = false;
            dgvBooks.Columns[7].Visible = false;
            dgvBooks.Columns[8].Visible = false;
        }

        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            BookService bookService = new BookService();
            BookAuthorService bookAuthorService = new BookAuthorService();
            BookGenreService bookGenreService = new BookGenreService();

            if (dgvBooks.SelectedRows.Count == 1)
            {
                var dr = MessageBox.Show("Are you sure you want to delete this book?", "Button Delete", MessageBoxButtons.YesNo);
                if(dr == DialogResult.Yes)
                {
                    var book = dgvBooks.CurrentRow.DataBoundItem as Book;

                    foreach (var a in book.BookAuthors.ToList())
                    {
                        bookAuthorService.DeleteBookAuthor(a);                        
                    }
                    foreach (var g in book.BookGenres.ToList())
                    {
                        bookGenreService.DeleteBookGenre(g);
                    }

                    if (bookService.DeleteBook(book))
                    {
                        MessageBox.Show("Book was successfully deleted.");
                    }
                    else
                    {
                        MessageBox.Show("Problem occured while deleting the book.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Select a book from the list that you want to delete.");
            }

            ShowAllBooks();
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            FrmNewBook frmNewBook = new FrmNewBook();
            frmNewBook.ShowDialog();
            ShowAllBooks();
        }

        private void btnMembers_Click(object sender, EventArgs e)
        {
            FrmLibraryMemberSearch frmLibraryMemberSearch = new FrmLibraryMemberSearch();
            frmLibraryMemberSearch.ShowDialog();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void btnViewBook_Click(object sender, EventArgs e)
        {
            if (dgvBooks.SelectedRows.Count == 1)
            {
                var selectedBook = dgvBooks.CurrentRow.DataBoundItem as Book;
                FrmBook frmBook = new FrmBook(selectedBook);
                frmBook.FormClosed += (s, args) => ShowAllBooks();
                frmBook.ShowDialog();
            }
            else
            {
                MessageBox.Show("Select a book from the list for which you want to see the details.");
            }
        }

        private void btnAddLibrarian_Click(object sender, EventArgs e)
        {
            FrmNewLibrarian frmNewLibrarian = new FrmNewLibrarian();
            frmNewLibrarian.ShowDialog();
        }

        private void btnBorrowBook_Click(object sender, EventArgs e)
        {
            FrmBookBorrow frmBookBorrow = new FrmBookBorrow();
            frmBookBorrow.ShowDialog();
        }
    }
}
