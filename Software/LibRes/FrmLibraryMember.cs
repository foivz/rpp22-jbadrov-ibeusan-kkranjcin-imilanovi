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
    public partial class FrmLibraryMember : Form
    {
        public FrmLibraryMember()
        {
            InitializeComponent();
        }

        private void FrmLibraryMember_Load(object sender, EventArgs e)
        {
            ShowMemberData();
        }

        private void ShowMemberData()
        {
            throw new NotImplementedException();
        }

        private void btnUpdateMember_Click(object sender, EventArgs e)
        {
            FrmUpdateMember frmUpdateMember = new FrmUpdateMember();
            frmUpdateMember.ShowDialog();
        }
    }
}
