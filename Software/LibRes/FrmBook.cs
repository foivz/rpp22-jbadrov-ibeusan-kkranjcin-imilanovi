using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogicLayer.Services;
using BusinessLogicLayer.Services_1;
using DataAccessLayer;
using DataAccessLayer.Repositories;

namespace LibRes
{
    public partial class FrmBook : Form
    {
        BorrowedBookOverviewService service = new BorrowedBookOverviewService();

        public FrmBook()
        {
            InitializeComponent();
        }
        
        private void FrmBook_Load(object sender, EventArgs e)
        {
            

            //ShowAllGenres();
            //ShowAllAuthors();
            //ShowBook();
            ShowAllBooks();
            ShowAllLibraryMembers();
        }

        private void ShowAllLibraryMembers()
        {
            var service = new LibraryMemberService();
            cmbMember.DataSource = service.GetLibraryMembers();
            cmbMember.DisplayMember = "Id";
            
        }

        private void ShowAllBooks()
        {
            var service = new BookCopyService();
            dgvBookCopies.DataSource = service.GetBookCopies();
            dgvBookCopies.Columns["Publisher"].Visible = false;
            dgvBookCopies.Columns["Book"].Visible = false;
            dgvBookCopies.Columns["BorrowedBookOverviews"].Visible = false;
            
            
            
           dgvBookCopies.CellFormatting += dgvBookCopies_CellFormatting;
            
            
        }

        private void ShowBook()
        {
            throw new NotImplementedException();
        }

        private void ShowAllGenres()
        {
            throw new NotImplementedException();
        }

        private void ShowAllAuthors()
        {
            throw new NotImplementedException();
        }

        private void btnReserve_Click(object sender, EventArgs e)
        {

            //var service = new BorrowedBookOverviewService();
            var bookCopy = dgvBookCopies.CurrentRow.DataBoundItem as BookCopy;
            if (service.IsReserved(bookCopy.Id))
            {
                MessageBox.Show("Book is already reserved");
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

        private void btnBorrow_Click(object sender, EventArgs e)
        {
            FrmBookBorrow frmBookBorrow = new FrmBookBorrow();
            frmBookBorrow.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            FrmUpdateBook frmUpdateBook = new FrmUpdateBook();
            frmUpdateBook.ShowDialog();
        }

        private void btnReserveForMember_Click(object sender, EventArgs e)
        {
            //var service = new BorrowedBookOverviewService();
            var bookCopy = dgvBookCopies.CurrentRow.DataBoundItem as BookCopy;
            if (service.IsReserved(bookCopy.Id))
            {
                MessageBox.Show("Book is already reserved");
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
                    IdState = borrowedBookState.Id,
                    BorrowDate = borrowedDate,
                    ReturnDate = returnDate,
                    IdBookCopy = bookCopy.Id,
                    BookCopy = bookCopy,
                    BorrowedBookState = borrowedBookState,
                    LibraryMember = libraryMember

                };
                
                var success = service.AddBorrowedBookOverview(bookOverview);
                if (success)
                {
                    MessageBox.Show("Successfully reserved book!");
                    Close();

                }
                else
                {
                    MessageBox.Show("Book was not successfully reserved");
                }

                

            }
            else
            {
                MessageBox.Show("Select one book");

            }
            
        }

        private void btnUpdateCopy_Click(object sender, EventArgs e)
        {
            FrmUpdateBookCopy frmUpdateBookCopy = new FrmUpdateBookCopy();
            frmUpdateBookCopy.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var dr = MessageBox.Show("Are You sure?", "Delete Copy", MessageBoxButtons.YesNo);

        }

        private void dgvBookCopies_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvBookCopies_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            
            var row = dgvBookCopies.Rows[e.RowIndex];
            
            var bookCopy = (BookCopy)row.DataBoundItem;

            //var service = new BorrowedBookOverviewService();
            if (service.IsReserved(bookCopy.Id))
            {
                
                row.DefaultCellStyle.BackColor = Color.Red;
            }
        }
    }
}
