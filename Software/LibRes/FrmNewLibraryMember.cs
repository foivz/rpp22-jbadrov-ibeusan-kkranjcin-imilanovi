using BusinessLogicLayer.Services;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
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
            if(txtFirstName.Text == "" || txtLastName.Text == "" || txtMemberEmail.Text == "")
            {
                MessageBox.Show("All member data is required!");
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
                    var dr = MessageBox.Show("Successfully added a new library member!");
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
