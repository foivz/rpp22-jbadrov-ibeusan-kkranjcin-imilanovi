using BusinessLogicLayer.Services;
using DataAccessLayer;
using System;
using System.Linq;
using System.Windows.Forms;

namespace LibRes
{
    public partial class FrmNewLibraryMember : Form
    {
        LibraryMemberService service = new LibraryMemberService();
        public FrmNewLibraryMember()
        {
            InitializeComponent();
        }

        private void btnAddMember_Click(object sender, EventArgs e)
        {
            if (txtFirstName.Text == "")
            {
                MessageBox.Show("Please fill in the first name of the library member!");
                return;
            }

            if (txtLastName.Text == "")
            {
                MessageBox.Show("Please fill in the last name of the library member!");
                return;
            }

            if (txtMemberEmail.Text == "")
            {
                MessageBox.Show("Please fill in the e-mail adress of the library member!");
                return;
            }

            else
            {

                var member = new LibraryMember
                {
                    FirstName = txtFirstName.Text,
                    LastName = txtLastName.Text,
                    Email = txtMemberEmail.Text,

                };
                var add = false;
                try
                {
                    add = service.AddLibraryMember(member);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                if (add)
                {
                    var dr = MessageBox.Show("Successfully added a new library member: " + member.FirstName + " " + member.LastName + "!");
                    if(dr == DialogResult.OK)
                    {
                        var memberForQr = service.GetLibraryMembers().Last();
                        FrmQRCode frmQRCode = new FrmQRCode(memberForQr.Id.ToString());
                        frmQRCode.ShowDialog();
                        Close();
                    }
                }
                else
                {
                    var dr = MessageBox.Show("I couldn't add a new library member!", "Invalid member data", MessageBoxButtons.RetryCancel);
                    if (dr == DialogResult.Cancel)
                    {
                        Close();
                    }
                }
            }
        }
    }
}
