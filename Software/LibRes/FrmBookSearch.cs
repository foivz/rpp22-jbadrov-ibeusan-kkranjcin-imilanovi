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
    public partial class FrmBookSearch : Form
    {
        public FrmBookSearch()
        {
            InitializeComponent();
        }

        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            var dr = MessageBox.Show("Are You sure?", "Button Delete", MessageBoxButtons.YesNo);
        }

        private void FrmBookSearch_Load(object sender, EventArgs e)
        {
            //ShowAllBooks();
        }

        private void ShowAllBooks()
        {
            throw new NotImplementedException();
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            FrmNewBook frmNewBook = new FrmNewBook();
            frmNewBook.ShowDialog();
        }

        private void btnAddCopy_Click(object sender, EventArgs e)
        {
            FrmNewBookCopy frmNewBookCopy = new FrmNewBookCopy();
            frmNewBookCopy.ShowDialog();
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
            FrmBook frmBook = new FrmBook();
            frmBook.ShowDialog();
        }

        private void btnAddLibrerian_Click(object sender, EventArgs e)
        {
            FrmNewLibrarian frmNewLibrarian = new FrmNewLibrarian();
            frmNewLibrarian.ShowDialog();
        }
    }
}
