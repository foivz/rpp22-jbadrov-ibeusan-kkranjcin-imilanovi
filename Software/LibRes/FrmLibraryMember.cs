using BusinessLogicLayer.Services;
using DataAccessLayer;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace LibRes
{
    public partial class FrmLibraryMember : Form
    {
        BookService bookService = new BookService();
        BorrowedBookOverviewService service = new BorrowedBookOverviewService();
        LibraryMember _member = null;
        public FrmLibraryMember(LibraryMember member)
        {
            InitializeComponent();
            _member = member;
            Text = _member.FirstName + " " + _member.LastName;
            HelpRequested += FrmLibraryMember_HelpRequested;
        }

        private void FrmLibraryMember_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Help.ShowHelp(this, "..\\..\\Resources\\help.chm", HelpNavigator.KeywordIndex, "LibraryMember");

        }

        private void FrmLibraryMember_Load(object sender, EventArgs e)
        {
            ShowMemberData();
        }

        private void ShowMemberData()
        {
            if(_member != null)
            {
                txtFirstName.Text = _member.FirstName;
                txtLastName.Text = _member.LastName;
                txtMemberEmail.Text = _member.Email;
                var membersBooks = from b in service.GetBorrowedBookOverviews()
                                   where b.IdLibraryMember == _member.Id
                                   select b;
                dgvMembersBooks.DataSource = membersBooks.ToList();
                dgvMembersBooks.Columns["BorrowedBookState"].Visible = false;
                dgvMembersBooks.Columns["LibraryMember"].Visible = false;
                dgvMembersBooks.Columns["IdLibraryMember"].Visible = false;
                dgvMembersBooks.Columns["Id"].Visible = false;
                dgvMembersBooks.Columns["IdBookCopy"].Visible = false;
                dgvMembersBooks.Columns["IdState"].Visible = false;
                dgvMembersBooks.Columns["BookCopy"].Visible = false;
                dgvMembersBooks.Columns.Add("BookTitle", "Title");
                dgvMembersBooks.Columns.Add("BookEdition", "Edition");
                var rows = dgvMembersBooks.Rows;
                for (int i = 0; i < rows.Count; i++)
                {
                    rows[i].Cells["BookTitle"].Value = bookService.GetBookById((int)membersBooks.ToList()[i].BookCopy.IdBook)[0].Title;
                }
                for (int i = 0; i < rows.Count; i++)
                {
                    rows[i].Cells["BookEdition"].Value = membersBooks.ToList()[i].BookCopy.Edition;
                }
            }
        }

        private void btnUpdateMember_Click(object sender, EventArgs e)
        {
            FrmUpdateMember frmUpdateMember = new FrmUpdateMember(_member);
            frmUpdateMember.ShowDialog();
            frmUpdateMember.FormClosed += FrmUpdateMember_FormClosed;
        }

        private void FrmUpdateMember_FormClosed(object sender, FormClosedEventArgs e)
        {
            ShowMemberData();
        }
    }
}
