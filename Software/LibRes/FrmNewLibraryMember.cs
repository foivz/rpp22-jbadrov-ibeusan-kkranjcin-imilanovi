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
            var email = txtMemberEmail.Text;
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(email);
            LibraryMember member = null;
            if (match.Success)
            { 
                member = new LibraryMember
                {
                    FirstName = txtFirstName.Text,
                    LastName = txtLastName.Text,
                    Email = txtMemberEmail.Text,

                };
            } 
            else
            {
                MessageBox.Show("Member email is invalid");
                return;
            }
            var add = service.AddLibraryMember(member);
            if (add)
            {
                var dr = MessageBox.Show("Successfully added a new library member!");
                if(dr == DialogResult.OK)
                {
                    Close();
                }
            }
            else
            {
                var dr = MessageBox.Show("I couldn't add a new library member!");
                if (dr == DialogResult.OK)
                {
                    Close();
                }
            }
        }
    }
}
