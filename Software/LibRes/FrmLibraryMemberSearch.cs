using BusinessLogicLayer.Services;
using DataAccessLayer;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace LibRes
{
    public partial class FrmLibraryMemberSearch : Form
    {
        LibraryMemberService service = new LibraryMemberService();
        public FrmLibraryMemberSearch()
        {
            InitializeComponent();
            HelpRequested += FrmLibraryMemberSearch_HelpRequested;
        }

        private void FrmLibraryMemberSearch_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Help.ShowHelp(this, "..\\..\\Resources\\help.chm", HelpNavigator.KeywordIndex, "LibraryMemberSearch");
        }

        private void FrmLibraryMemberSearch_Load(object sender, EventArgs e)
        {
            ShowAllMembers();
        }

        private void btnSearchMembers_Click(object sender, EventArgs e)
        {
            SearchMembers();
        }

        private void btnAddMember_Click(object sender, EventArgs e)
        {
            FrmNewLibraryMember frmNewLibraryMember = new FrmNewLibraryMember();
            frmNewLibraryMember.ShowDialog();
            frmNewLibraryMember.Closed += FrmLibraryMember_FormClosed;
        }

        private void btnDeleteMember_Click(object sender, EventArgs e)
        {
            var dr = MessageBox.Show("Are You sure?", "Button Delete", MessageBoxButtons.YesNo);
            if(dr == DialogResult.Yes)
            {
                var member = dgvMembers.CurrentRow.DataBoundItem as LibraryMember;
                service.DeleteLibraryMember(member);
            }
            ShowAllMembers();
        }

        private void btnViewMember_Click(object sender, EventArgs e)
        {
            var member = dgvMembers.CurrentRow.DataBoundItem as LibraryMember;
            FrmLibraryMember frmLibraryMember = new FrmLibraryMember(member);
            frmLibraryMember.ShowDialog();

        }

        private void FrmLibraryMember_FormClosed(object sender, EventArgs e)
        {
            ShowAllMembers();
        }

        private void txtSearchMember_TextChanged(object sender, EventArgs e)
        {
            SearchMembers();
        }

        /// <summary>
        /// Fills the <see cref="DataGridView"/> with all the library members.
        /// </summary>
        private void ShowAllMembers()
        {
            var allMembers = service.GetLibraryMembers();
            dgvMembers.DataSource = allMembers;
            dgvMembers.Columns["Id"].Visible = false;
            dgvMembers.Columns[4].Visible = false;
        }

        /// <summary>
        /// Fills the <see cref="DataGridView"/> with all the library members that match the search criteria.
        /// </summary>
        private void SearchMembers()
        {
            var members = from m in service.GetLibraryMembers()
                          where m.ToString().ToLower().Contains(txtSearchMember.Text.ToLower())
                          select m;
            dgvMembers.DataSource = members.ToList();
            dgvMembers.Columns["Id"].Visible = false;
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            if (pnFilter.Visible)
            {
                pnFilter.Visible = false;
            }
            else
            {
                pnFilter.Visible = true;
            }
        }

        private void btnFirstNameAsc_Click(object sender, EventArgs e)
        {
            var members = from m in service.GetLibraryMembers()
                          orderby m.FirstName ascending
                          select m;
            dgvMembers.DataSource = members.ToList();
        }

        private void btnFirstNameDesc_Click(object sender, EventArgs e)
        {
            var members = from m in service.GetLibraryMembers()
                          orderby m.FirstName descending
                          select m;
            dgvMembers.DataSource = members.ToList();
        }

        private void btnLastNameAsc_Click(object sender, EventArgs e)
        {
            var members = from m in service.GetLibraryMembers()
                          orderby m.LastName ascending
                          select m;
            dgvMembers.DataSource = members.ToList();
        }

        private void btnLastNameDesc_Click(object sender, EventArgs e)
        {
            var members = from m in service.GetLibraryMembers()
                          orderby m.LastName descending
                          select m;
            dgvMembers.DataSource = members.ToList();
        }
    }
}
