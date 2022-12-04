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
    public partial class FrmNewBook : Form
    {
        public FrmNewBook()
        {
            InitializeComponent();
        }

        private void FrmNewBook_Load(object sender, EventArgs e)
        {
            ShowAllAuthors();
            ShowAllGenres();
        }

        private void ShowAllAuthors()
        {
            throw new NotImplementedException();
        }

        private void ShowAllGenres()
        {
            throw new NotImplementedException();
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Successfully added book!");
            Close();
        }

        private void btnAddAuthor_Click(object sender, EventArgs e)
        {
            FrmNewAuthor frmNewAuthor = new FrmNewAuthor();
            frmNewAuthor.ShowDialog();
        }
    }
}
