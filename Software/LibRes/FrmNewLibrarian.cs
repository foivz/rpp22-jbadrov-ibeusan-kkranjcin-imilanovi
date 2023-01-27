using BusinessLogicLayer.Services;
using DataAccessLayer;
using System;
using System.Windows.Forms;

namespace LibRes
{
    public partial class FrmNewLibrarian : Form
    {
        UserService userService = new UserService();
        public FrmNewLibrarian()
        {
            InitializeComponent();
        }

        private void FrmNewLibrarian_Load(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
        }

        private void btnAddLibrarian_Click(object sender, EventArgs e)
        {
            if (txtFirstName.Text == "")
            {
                MessageBox.Show("Please fill in the first name of the librarian!");
                return;
            }
            if (txtLastName.Text == "")
            {
                MessageBox.Show("Please fill in the last name of the librarian!");
                return;
            }
            if (txtUsername.Text == "")
            {
                MessageBox.Show("Please fill in the username of the librarian!");
                return;
            }
            if (txtPassword.Text == "")
            {
                MessageBox.Show("Please fill in the password of the librarian!");
                return;
            }
            var user = new User
            {
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                Username = txtUsername.Text,
                Password = txtPassword.Text,
                IdRole = 2
            };

            if (userService.AddUser(user))
            {
                MessageBox.Show("Successfully added new user: " + user.FirstName + " " + user.LastName + "!");
                Close();
            }
            else
            {
                MessageBox.Show("Problem occurred while adding new user!");
                Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cbPasswordVisible_CheckStateChanged(object sender, EventArgs e)
        {
            if (cbPasswordVisible.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }
    }
}
