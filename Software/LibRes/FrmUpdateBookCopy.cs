using BusinessLogicLayer.Services;
using DataAccessLayer;
using System;
using System.Windows.Forms;

namespace LibRes
{
    public partial class FrmUpdateBookCopy : Form
    {
        private BookCopy _bookCopy;
        private Book _book;
        BookCopyService bookCopyService = new BookCopyService();
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
            if(cmbPublishers.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a publisher!");
                return;
            }
            if(txtEdition.Text == "")
            {

                MessageBox.Show("Please fill in the edition of the book copy!");
                return;
            }


            if (txtLanguage.Text == "")
            {

                MessageBox.Show("Please fill in the language of the book copy!");
                return;
            }


            if (txtYearOfPublication.Text == "")
            {

                MessageBox.Show("Please fill in the year of publication of the book copy!");
                return;
            }

            var publisher = cmbPublishers.SelectedItem as Publisher;
            _bookCopy.Edition = txtEdition.Text;
            _bookCopy.IdPublisher = publisher.Id;
            _bookCopy.YearOfPublication = int.Parse(txtYearOfPublication.Text);
            _bookCopy.Language = txtLanguage.Text;

            if (bookCopyService.UpdateBookCopy(_bookCopy))
            {
                MessageBox.Show("Successfully updated this copy of the book: " + _book.Title);
            }
            else
            {
                MessageBox.Show("Problem occurred while updating the book copy!");
            }
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
