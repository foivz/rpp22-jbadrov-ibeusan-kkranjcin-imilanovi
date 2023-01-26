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
                MessageBox.Show("Successfully added new user!");
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
