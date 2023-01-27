using BusinessLogicLayer.Services;
using DataAccessLayer;
using System;
using System.Windows.Forms;

namespace LibRes
{
    public partial class FrmNewAuthor : Form
    {
        public FrmNewAuthor()
        {
            InitializeComponent();
        }

        private void btnAddAuthor_Click(object sender, EventArgs e)
        {
            if (txtFirstName.Text == "")
            {
                MessageBox.Show("Please fill in the first name of the author");
                return;
            }

            if (txtLastName.Text == "")
            {
                MessageBox.Show("Please fill in the last name of the author");
                return;
            }

            if (dtpDateOfBirth.Value == default)
            {
                MessageBox.Show("Please fill in the date of birth of the author");
                return;
            }

            AuthorService authorService = new AuthorService();
            Author author = new Author
            {
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                DateOfBirth = dtpDateOfBirth.Value
            };

            if (authorService.AddAuthor(author))
            {
                MessageBox.Show("Successfully added a new author: " + author.FirstName + " " + author.LastName + "!");
            }
            else
            {
                MessageBox.Show("Problem occured while adding a new author!");
            }
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
