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
    public partial class FrmLibraryMemberSearch : Form
    {
        public FrmLibraryMemberSearch()
        {
            InitializeComponent();
        }

        private void FrmLibraryMemberSearch_Load(object sender, EventArgs e)
        {
            ShowAllMembers();
        }

        private void ShowAllMembers()
        {
            throw new NotImplementedException();
        }

        private void btnSearchMembers_Click(object sender, EventArgs e)
        {

        }

        private void btnAddMember_Click(object sender, EventArgs e)
        {
            FrmNewLibraryMember frmNewLibraryMember = new FrmNewLibraryMember();
            frmNewLibraryMember.ShowDialog();
        }

        private void btnDeleteMember_Click(object sender, EventArgs e)
        {
            var dr = MessageBox.Show("Are You sure?", "Button Delete", MessageBoxButtons.YesNo);
        }
    }
}
