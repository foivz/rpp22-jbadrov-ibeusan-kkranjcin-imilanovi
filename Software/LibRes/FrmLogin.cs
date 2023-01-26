using BusinessLogicLayer.Services;
using DataAccessLayer;
using System;
using System.Windows.Forms;

namespace LibRes
{
    public partial class FrmLogin : Form
    {
        UserService userService = new UserService();
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var userFromDB = userService.GetUserByUsername(txtUsername.Text);
            if (userFromDB.Count > 0)
            {
                if (userFromDB[0].Password == txtPassword.Text)
                {
                    MessageBox.Show("Login successful!");
                    LibResUser.CurrentUser = userFromDB[0];
                    FrmBookSearch frmBookSearch = new FrmBookSearch();
                    Hide();
                    frmBookSearch.FormClosed += (s, args) => Close();
                    frmBookSearch.Show();
                }
                else
                {
                    MessageBox.Show("Password is incorrect!");
                }
            }
            else
            {
                MessageBox.Show("User with username '" + txtUsername.Text + "' does not exist!");
                return;
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
