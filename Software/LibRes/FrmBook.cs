using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibRes
{
    public partial class FrmBook : Form
    {
        public FrmBook()
        {
            InitializeComponent();
        }
        private void FrmBook_Load(object sender, EventArgs e)
        {
            //ShowAllGenres();
            //ShowAllAuthors();
            //ShowBook();
        }

        private void ShowAllLibraryMembers()
        {
            var service = new LibraryMemberService();
            cmbMember.DataSource = service.GetLibraryMembers();
            //cmbMember.DisplayMember = "Id";
            
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
            FrmUpdateBook frmUpdateBook = new FrmUpdateBook();
            frmUpdateBook.ShowDialog();
        }

        private void btnReserveForMember_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Successfully reserved book!");
            Close();
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
    }
}
