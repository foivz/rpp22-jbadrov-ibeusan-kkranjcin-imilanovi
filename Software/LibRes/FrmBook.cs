using BusinessLogicLayer.Services;
using DataAccessLayer;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace LibRes
{
    public partial class FrmBook : Form
    {
        public Book _book { get; set; }
        BookService bookService = new BookService();
        BookCopyService bookCopyService = new BookCopyService();

        BorrowedBookOverviewService service = new BorrowedBookOverviewService();

        public FrmBook(Book book)
        {
            InitializeComponent();
            _book = book;
        }
        
        private void FrmBook_Load(object sender, EventArgs e)
        {
            ShowAllLibraryMembers();
            ShowBook();
        }

        private void ShowAllLibraryMembers()
        {
            var service = new LibraryMemberService();
            cmbMember.DataSource = service.GetLibraryMembers();           
        }

       
        private void ShowBook()
        {
            var updatedBook = GetUpdatedBook();

            txtTitle.Text = updatedBook.Title;

            dgvAuthors.DataSource = updatedBook.BookAuthors.ToList();
            dgvAuthors.RowHeadersVisible = false;
            dgvAuthors.ColumnHeadersVisible = false;
            dgvAuthors.Columns[0].Visible = false;
            dgvAuthors.Columns[1].Visible = false;
            dgvAuthors.Columns[2].Visible = false;
            dgvAuthors.Columns[4].Visible = false;
            dgvAuthors.BackgroundColor = Color.White;
            dgvAuthors.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

            dgvGenres.DataSource = updatedBook.BookGenres.ToList();
            dgvGenres.RowHeadersVisible = false;
            dgvGenres.ColumnHeadersVisible = false;
            dgvGenres.Columns[0].Visible = false;
            dgvGenres.Columns[1].Visible = false;
            dgvGenres.Columns[2].Visible = false;
            dgvGenres.Columns[3].Visible = false;
            dgvGenres.BackgroundColor = Color.White;
            dgvGenres.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

            txtNumberOfPages.Text = updatedBook.NumberOfPages.ToString();
            txtISBN.Text = updatedBook.ISBN.ToString();

            dgvBookCopies.DataSource = updatedBook.BookCopies.ToList();
            dgvBookCopies.Columns[0].Visible = false;
            dgvBookCopies.Columns[2].Visible = false;
            dgvBookCopies.Columns[3].Visible = false;
            dgvBookCopies.Columns[6].Visible = false;
            dgvBookCopies.Columns[7].Visible = false;
            dgvBookCopies.Columns[8].Visible = false;

            dgvBookCopies.CellFormatting += dgvBookCopies_CellFormatting;
        }

        private Book GetUpdatedBook()
        {
            var bookUpdated = bookService.GetBookById(_book.Id);
            return bookUpdated[0];
        }

        private void btnReserve_Click(object sender, EventArgs e)
        {

            //var service = new BorrowedBookOverviewService();
            var bookCopy = dgvBookCopies.CurrentRow.DataBoundItem as BookCopy;
            if (service.IsReserved(bookCopy.Id))
            {
                MessageBox.Show("Book is already reserved");
            }
            else if(service.IsBorrowed(bookCopy.Id))
            {
                MessageBox.Show("Book is already borrowed");
            }
            else if (dgvBookCopies.SelectedRows.Count > 1)
            {
                MessageBox.Show("Select one book");
            }
            else if (dgvBookCopies.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select one book");
            }
            else
            {
                lblMember.Visible = true;
                cmbMember.Visible = true;
                btnReserve.Visible = false;
                btnReserveForMember.Visible = true;

            }
            
        }

        

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            FrmUpdateBook frmUpdateBook = new FrmUpdateBook(_book);
            frmUpdateBook.Closed += (s, args) => ShowBook();
            frmUpdateBook.ShowDialog();
        }

        private void btnReserveForMember_Click(object sender, EventArgs e)
        {
            try
            {
                var bookCopy = dgvBookCopies.CurrentRow.DataBoundItem as BookCopy;
                if (service.IsReserved(bookCopy.Id))
                {
                    MessageBox.Show("Book is already reserved");
                }

                else if (service.IsBorrowed(bookCopy.Id))
                {
                    MessageBox.Show("Book is borrowed");

                }

                else if (dgvBookCopies.SelectedRows.Count == 1)
                {
                    var libraryMember = cmbMember.SelectedItem as LibraryMember;

                    var borrowedDate = DateTime.Now;
                    var returnDate = DateTime.Now.AddDays(1);
                    var borrowedBookState = new BorrowedBookState();
                    var borrowedBookStateService = new BorrowedBookStateService();
                    borrowedBookState = borrowedBookStateService.GetBorrowedBookStates()[2];
                    var bookOverview = new BorrowedBookOverview
                    {
                        IdLibraryMember = libraryMember.Id,
                        IdState = 3,
                        BorrowDate = borrowedDate,
                        ReturnDate = returnDate,
                        IdBookCopy = bookCopy.Id

                    };


                    var success = service.AddBorrowedBookOverview(bookOverview);
                    if (success)
                    {
                        MessageBox.Show("Successfully reserved book!");
                        ShowBook();

                    }
                    else
                    {
                        MessageBox.Show("The book is not reserved, an error has occurred.");
                    }



                }
                else
                {
                    MessageBox.Show("Select one book");

                }

            }
            catch(Exception exc)
            {
                MessageBox.Show("You did not approve the correct parameters");
            }
            

        }

        private void btnAddCopy_Click(object sender, EventArgs e)
        {
            var updatedBook = GetUpdatedBook();
            FrmNewBookCopy frmNewBookCopy = new FrmNewBookCopy(updatedBook);
            frmNewBookCopy.FormClosed += (s, args) => ShowBook();
            frmNewBookCopy.ShowDialog();
        }

        private void btnUpdateCopy_Click(object sender, EventArgs e)
        {
            if(dgvBookCopies.SelectedRows.Count == 1)
            {
                var bookCopy = dgvBookCopies.CurrentRow.DataBoundItem as BookCopy;
                FrmUpdateBookCopy frmUpdateBookCopy = new FrmUpdateBookCopy(bookCopy, _book);
                frmUpdateBookCopy.FormClosed += (s, args) => ShowBook();
                frmUpdateBookCopy.ShowDialog();
            }
            else
            {
                MessageBox.Show("Choose one book copy that you want to update.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvBookCopies.SelectedRows.Count == 1)
            {
                var dr = MessageBox.Show("Are you sure you want to delete this copy?", "Delete Copy", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    var bookCopy = dgvBookCopies.CurrentRow.DataBoundItem as BookCopy;
                    if (bookCopyService.DeleteBookCopy(bookCopy))
                    {
                        MessageBox.Show("Successfully deleted selected book copy!");
                    }
                    else
                    {
                        MessageBox.Show("Problem occurred while deleting the book copy!");
                    }
                    ShowBook();
                }
            }
            else
            {
                MessageBox.Show("Choose one book copy that you want to delete.");
            }
        }

        private void dgvBookCopies_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            var row = dgvBookCopies.Rows[e.RowIndex];

            var bookCopy = (BookCopy)row.DataBoundItem;
            if (service.IsReserved(bookCopy.Id))
            {

                row.DefaultCellStyle.BackColor = Color.Orange;
            }
            else if (service.IsBorrowed(bookCopy.Id))
            {
                row.DefaultCellStyle.BackColor= Color.Red;
            }
            
        }

        private void btnDeleteReservation_Click(object sender, EventArgs e)
        {
            

            var bookCopy = dgvBookCopies.CurrentRow.DataBoundItem as BookCopy;
            if(dgvBookCopies.SelectedRows.Count == 1)
            {
                if (service.IsReserved(bookCopy.Id))
                {
                    var borrowedBookOverview = service.GetReserveddBookOverviewsByIdBook(bookCopy.Id)[0];
                    var success = service.DeleteBorrowedBookOverview(borrowedBookOverview);
                    if (success)
                    {
                        MessageBox.Show("The reservation has been canceled.");
                        ShowBook();
                    }
                    else
                    {
                        MessageBox.Show("The reservation has not been canceled, an error has occurred.");
                    }
                }
                else if (service.IsBorrowed(bookCopy.Id))
                {
                    MessageBox.Show("Book is borrowed");
                }
                else
                {
                    MessageBox.Show("The book is not reserved.");
                }

            }
            else
            {
                MessageBox.Show("Choose one book copy");
            }
            

        }
    }
}
