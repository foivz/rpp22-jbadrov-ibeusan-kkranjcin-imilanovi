using BusinessLogicLayer.Services;
using DataAccessLayer;
using System;
using System.Windows.Forms;

namespace LibRes
{
    public partial class FrmUpdateMember : Form
    {
        LibraryMemberService service = new LibraryMemberService();
        LibraryMember libraryMember = null;
        public FrmUpdateMember(LibraryMember member)
        {
            InitializeComponent();
            libraryMember = member;
            ShowMemberDate();
        }

        private void ShowMemberDate()
        {
            txtFirstName.Text = libraryMember.FirstName;
            txtLastName.Text = libraryMember.LastName;
            txtMemberEmail.Text = libraryMember.Email;
        }

        private void btnUpdateMember_Click(object sender, EventArgs e)
        {

            if(txtFirstName.Text == "")
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

            libraryMember.FirstName = txtFirstName.Text;
            libraryMember.LastName = txtLastName.Text;
            libraryMember.Email = txtMemberEmail.Text;
            try
            {

                if (service.UpdateLibraryMember(libraryMember))
                {
                    MessageBox.Show("Successfully updated the library member: " + libraryMember.FirstName + " " + libraryMember.LastName);
                }
                else
                {
                    MessageBox.Show("There was a problem while updating the library member");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            

        }
    }
}
