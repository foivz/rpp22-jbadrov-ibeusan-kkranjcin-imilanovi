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
    public partial class FrmNewBookCopy : Form
    {
        public FrmNewBookCopy()
        {
            InitializeComponent();
        }


        private void FrmNewBookCopy_Load(object sender, EventArgs e)
        {
            //ShowBook();
            //ShowAllPublishers();
        }

        private void ShowAllBooks()
        {
            throw new NotImplementedException();
        }

        private void ShowAllPublishers()
        {
            throw new NotImplementedException();
        }

        private void btnAddBookCopy_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Successfully added a new book copy!");
        }

        private void btnAddPublisher_Click(object sender, EventArgs e)
        {
            FrmNewPublisher frmNewPublisher = new FrmNewPublisher();
            frmNewPublisher.ShowDialog();
        }
    }
}
