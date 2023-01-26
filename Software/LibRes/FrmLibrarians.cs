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
    public partial class FrmLibrarians : Form
    {
        UserService userService = new UserService();
        public FrmLibrarians()
        {
            InitializeComponent();
        }

        private void FrmLibrarians_Load(object sender, EventArgs e)
        {
            ShowAllLibrarians();
        }

        private void ShowAllLibrarians()
        {
            var users = userService.GetUsers();
            List<User> librarians = new List<User>();
            foreach (var user in users)
            {
                if(user.IdRole == 2)
                {
                    librarians.Add(user);
                }
            }
            dgvLibrarians.DataSource = librarians;
            dgvLibrarians.Columns[0].Visible = false;
            dgvLibrarians.Columns[4].Visible = false;
            dgvLibrarians.Columns[5].Visible = false;
            dgvLibrarians.Columns[6].Visible = false;
        }

        private void btnAddLibrarian_Click(object sender, EventArgs e)
        {
            FrmNewLibrarian frmNewLibrarian = new FrmNewLibrarian();
            frmNewLibrarian.FormClosed += (s, args) => ShowAllLibrarians();
            frmNewLibrarian.ShowDialog();
        }

        private void btnUpdateLibrarian_Click(object sender, EventArgs e)
        {
            if (dgvLibrarians.SelectedRows.Count == 1)
            {
                var selectedUser = dgvLibrarians.CurrentRow.DataBoundItem as User;
                FrmUpdateLibrarian frmUpdateLibrarian = new FrmUpdateLibrarian(selectedUser);
                frmUpdateLibrarian.FormClosed += (s, args) => ShowAllLibrarians();
                frmUpdateLibrarian.ShowDialog();
            }
            else
            {
                MessageBox.Show("Choose one librarian that you want to update.");
            }

            
        }

        private void btnDeleteLibrarian_Click(object sender, EventArgs e)
        {
            if (dgvLibrarians.SelectedRows.Count == 1)
            {
                var dr = MessageBox.Show("Are you sure you want to delete this librarian?", "Delete Copy", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    var user = dgvLibrarians.CurrentRow.DataBoundItem as User;
                    if (userService.DeleteUser(user))
                    {
                        MessageBox.Show("Successfully deleted selected librarian!");
                        ShowAllLibrarians();
                    }
                    else
                    {
                        MessageBox.Show("Problem occurred while deleting the librarian!");
                    }
                    ShowAllLibrarians();
                }
            }
            else
            {
                MessageBox.Show("Choose one librarian that you want to delete.");
            }
        }
    }
}
