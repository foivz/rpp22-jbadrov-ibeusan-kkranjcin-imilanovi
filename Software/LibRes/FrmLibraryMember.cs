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
        BorrowedBookOverviewService service = new BorrowedBookOverviewService();
        LibraryMember _member = null;
        public FrmLibraryMember(LibraryMember member)
        {
            InitializeComponent();
            _member = member;
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
                dgvMembersBooks.Columns["BookCopy"].Visible = false;
                dgvMembersBooks.Columns["BorrowedBookState"].Visible = false;
                dgvMembersBooks.Columns["LibraryMember"].Visible = false;
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
