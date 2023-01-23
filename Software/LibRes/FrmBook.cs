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
        
        public FrmBook(Book book)
        {
            InitializeComponent();
            _book = book;
        }
        private void FrmBook_Load(object sender, EventArgs e)
        {
            ShowBook();
        }

        private void ShowBook()
        {
            BookService bookService = new BookService();
            var bookFromService = bookService.GetBookById(_book.Id);
            var bookUpdated = bookFromService[0];

            txtTitle.Text = bookUpdated.Title;

            dgvAuthors.DataSource = bookUpdated.BookAuthors.ToList();
            dgvAuthors.RowHeadersVisible = false;
            dgvAuthors.ColumnHeadersVisible = false;
            dgvAuthors.Columns[0].Visible = false;
            dgvAuthors.Columns[1].Visible = false;
            dgvAuthors.Columns[2].Visible = false;
            dgvAuthors.Columns[4].Visible = false;
            dgvAuthors.BackgroundColor = Color.White;
            dgvAuthors.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

            dgvGenres.DataSource = bookUpdated.BookGenres.ToList();
            dgvGenres.RowHeadersVisible = false;
            dgvGenres.ColumnHeadersVisible = false;
            dgvGenres.Columns[0].Visible = false;
            dgvGenres.Columns[1].Visible = false;
            dgvGenres.Columns[2].Visible = false;
            dgvGenres.Columns[3].Visible = false;
            dgvGenres.BackgroundColor = Color.White;
            dgvGenres.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

            txtNumberOfPages.Text = bookUpdated.NumberOfPages.ToString();
            txtISBN.Text = bookUpdated.ISBN.ToString();
        }

        private void btnReserve_Click(object sender, EventArgs e)
        {
            lblMember.Visible = true;
            cmbMember.Visible = true;
            btnReserve.Visible = false;
            btnReserveForMember.Visible = true;
        }

        private void btnBorrow_Click(object sender, EventArgs e)
        {
            FrmBookBorrow frmBookBorrow = new FrmBookBorrow();
            frmBookBorrow.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            FrmUpdateBook frmUpdateBook = new FrmUpdateBook(_book);
            frmUpdateBook.Closed += (s, args) => ShowBook();
            frmUpdateBook.ShowDialog();
        }

        private void btnReserveForMember_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Successfully reserved book!");
            Close();
        }

        private void btnUpdateCopy_Click(object sender, EventArgs e)
        {
            var bookCopy = dgvBookCopies.CurrentRow.DataBoundItem as BookCopy;
            FrmUpdateBookCopy frmUpdateBookCopy = new FrmUpdateBookCopy(bookCopy, _book);
            frmUpdateBookCopy.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            BookCopyService bookCopyService = new BookCopyService();
            var dr = MessageBox.Show("Are you sure you want to delete this copy?", "Delete Copy", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                var bookCopy = dgvBookCopies.CurrentRow.DataBoundItem as BookCopy;
                bookCopyService.DeleteBookCopy(bookCopy);
            }
        }

        private void btnAddCopy_Click(object sender, EventArgs e)
        {
            FrmNewBookCopy frmNewBookCopy = new FrmNewBookCopy(_book);
            frmNewBookCopy.ShowDialog();
        }
    }
}
