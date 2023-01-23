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
    public partial class FrmUpdateBookCopy : Form
    {
        public BookCopy _bookCopy { get; set; }
        public Book _book { get; set; }
        public FrmUpdateBookCopy(BookCopy bookCopy, Book book)
        {
            InitializeComponent();
            _bookCopy = bookCopy;
            _book = book;
        }

        private void FrmUpdateBookCopy_Load(object sender, EventArgs e)
        {
            ShowBookCopy();
            ShowAllPublishers();
        }

        private void ShowBookCopy()
        {
            txtTitle.Text = _book.Title;
            txtEdition.Text = _bookCopy.Edition;
            txtYearOfPublication.Text = _bookCopy.YearOfPublication.ToString();
            txtLanguage.Text = _bookCopy.Language;
        }

        private void ShowAllPublishers()
        {
            PublisherService publisherService = new PublisherService();
            cmbPublishers.DataSource = publisherService.GetPublishers();
        }

        private void btnUpdateBookCopy_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Successfully updated the book copy!");
            Close();
        }
    }
}
