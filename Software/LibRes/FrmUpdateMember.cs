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
            var email = txtMemberEmail.Text;
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(email);
            if (match.Success)
            {
                
                libraryMember.FirstName = txtFirstName.Text;
                libraryMember.LastName = txtLastName.Text;
                libraryMember.Email = txtMemberEmail.Text;
            }
            else
            {
                MessageBox.Show("Member email is invalid");
                return;
            }
            
            service.UpdateLibraryMember(libraryMember);
            MessageBox.Show("Successfully updated a library member");

        }
    }
}
