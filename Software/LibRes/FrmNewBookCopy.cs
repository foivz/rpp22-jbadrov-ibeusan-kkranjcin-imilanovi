using BusinessLogicLayer.Services;
using DataAccessLayer;
using System;
using System.Linq;
using System.Windows.Forms;

namespace LibRes
{
    public partial class FrmNewBookCopy : Form
    {
        public Book _book { get; set; }
        BookCopyService bookCopyService = new BookCopyService();
        PublisherService publisherService = new PublisherService();
        public FrmNewBookCopy(Book book)
        {
            InitializeComponent();
            _book = book;
            HelpRequested += FrmNewBookCopy_HelpRequested;
        }

        private void FrmNewBookCopy_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Help.ShowHelp(this, "..\\..\\Resources\\help.chm", HelpNavigator.KeywordIndex, "NewBookCopy");
        }

        private void FrmNewBookCopy_Load(object sender, EventArgs e)
        {
            txtTitle.Text = _book.Title;
            ShowAllPublishers();
        }

        private void ShowAllPublishers()
        {
            cmbPublishers.DataSource = publisherService.GetPublishers();
        }

        private void btnAddBookCopy_Click(object sender, EventArgs e)
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
            if (int.Parse(txtYearOfPublication.Text) > 2023)
            {
                MessageBox.Show("Year of publication can't be in the future!");
                return;
            }
            var publisher = cmbPublishers.SelectedItem as Publisher;
            var bookCopy = new BookCopy 
            { 
                Edition = txtEdition.Text,
                YearOfPublication = int.Parse(txtYearOfPublication.Text),
                Language = txtLanguage.Text,
                IdBook = _book.Id,
                IdPublisher = publisher.Id
            };

            if (bookCopyService.AddBookCopy(bookCopy))
            {
                MessageBox.Show("Successfully added a new book copy of: " + _book.Title + "!");

                var bookCopies = bookCopyService.GetBookCopies();
                var addedBookCopy = bookCopies.Last();
                FrmQRCode frmQRCode = new FrmQRCode(addedBookCopy.Id.ToString());
                frmQRCode.ShowDialog();
                Close();
            }
            else
            {
                MessageBox.Show("Problem occurred while adding a new book copy!");
                Close();
            }
        }

        private void btnAddPublisher_Click(object sender, EventArgs e)
        {
            FrmNewPublisher frmNewPublisher = new FrmNewPublisher();
            frmNewPublisher.FormClosed += (s, args) => ShowAllPublishers();
            frmNewPublisher.ShowDialog();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
