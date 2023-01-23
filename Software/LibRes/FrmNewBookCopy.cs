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
    public partial class FrmNewBookCopy : Form
    {
        public Book _book { get; set; }
        public FrmNewBookCopy(Book book)
        {
            InitializeComponent();
            _book = book;
        }


        private void FrmNewBookCopy_Load(object sender, EventArgs e)
        {
            txtTitle.Text = _book.Title;
            ShowAllPublishers();
        }

        private void ShowAllPublishers()
        {
            PublisherService publisherService = new PublisherService();
            cmbPublishers.DataSource = publisherService.GetPublishers();
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
