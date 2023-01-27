using BusinessLogicLayer.Services;
using DataAccessLayer;
using System;
using System.Windows.Forms;

namespace LibRes
{
    public partial class FrmUpdateLibrarian : Form
    {
        private User _librarian { get; set; }
        UserService userService = new UserService();
        public FrmUpdateLibrarian(User librarian)
        {
            InitializeComponent();
            _librarian = librarian;
        }

        private void FrmUpdateLibrarian_Load(object sender, EventArgs e)
        {
            txtFirstName.Text = _librarian.FirstName;
            txtLastName.Text = _librarian.LastName;
            txtUsername.Text = _librarian.Username;
            txtPassword.Text = _librarian.Password;
            txtPassword.UseSystemPasswordChar = true;
        }

        private void btnUpdateLibrarian_Click(object sender, EventArgs e)
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

            _librarian.FirstName = txtFirstName.Text;
            _librarian.LastName = txtLastName.Text;
            _librarian.Username = txtUsername.Text;
            _librarian.Password = txtPassword.Text;

            if (userService.UpdateUser(_librarian))
            {
                MessageBox.Show("Successfully updated the librarian: " + _librarian.FirstName + " " + _librarian.LastName + "!");
            }
            else
            {
                MessageBox.Show("Problem occurred while updating the librarian!");
            }
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cbPasswordVisible_CheckStateChanged(object sender, EventArgs e)
        {
            if(cbPasswordVisible.Checked)
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
