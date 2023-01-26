using BusinessLogicLayer.Services;
using DataAccessLayer;
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
            _librarian.FirstName = txtFirstName.Text;
            _librarian.LastName = txtLastName.Text;
            _librarian.Username = txtUsername.Text;
            _librarian.Password = txtPassword.Text;

            if (userService.UpdateUser(_librarian))
            {
                MessageBox.Show("Successfully updated the librarian!");
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
