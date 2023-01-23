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
    public partial class FrmNewAuthor : Form
    {
        public FrmNewAuthor()
        {
            InitializeComponent();
        }

        private void btnAddAuthor_Click(object sender, EventArgs e)
        {
            AuthorService authorService = new AuthorService();
            Author author = new Author
            {
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                DateOfBirth = dtpDateOfBirth.Value
            };

            if (authorService.AddAuthor(author))
            {
                MessageBox.Show("Successfully added new author!");
            }
            else
            {
                MessageBox.Show("Problem occured while adding the author!");
            }
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
