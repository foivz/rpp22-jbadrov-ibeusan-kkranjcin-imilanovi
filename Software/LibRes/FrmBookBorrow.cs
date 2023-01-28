using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using BusinessLogicLayer.Services;
using DataAccessLayer;
using ZXing;

namespace LibRes
{
    public partial class FrmBookBorrow : Form
    {
        public FrmBookBorrow()
        {
            InitializeComponent();
        }

        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice videoCaptureDevice;
        private void FrmBookBorrow_Load(object sender, EventArgs e)
        {
            
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filterInfo in filterInfoCollection)
            {
                cmbDevices.Items.Add(filterInfo.Name);
            }
            cmbDevices.SelectedIndex = 0;

            ShowAllMembers();
            ShowAllBooks();
            ShowAllBookCopies();
            pictureBoxScanedMember.Visible = false;
            pictureBoxScanedBook.Visible = false;
        }

        private void ShowAllBookCopies()
        {
            var book = cmbBook.SelectedItem as Book;
            var service = new BookCopyService();
            cmbBookCopy.DataSource = service.GetBookCopiesByBookId(book.Id);
        }

        private void ShowAllMembers()
        {
            var service = new LibraryMemberService();
            cmbLibraryMembers.DataSource = service.GetLibraryMembers();
        }

        private void ShowAllBooks()
        {
            var service = new BookService();
            cmbBook.DataSource = service.GetBooks();
        }

        

        private void btnScanMember_Click(object sender, EventArgs e)
        {
            videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[cmbDevices.SelectedIndex].MonikerString);
            videoCaptureDevice.NewFrame += VideoCaptureDevice_NewFrame;
            videoCaptureDevice.Start();
            timerForScaningMember.Start();
        }

        private void VideoCaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pbScan.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void btnScanBook_Click(object sender, EventArgs e)
        {
            videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[cmbDevices.SelectedIndex].MonikerString);
            videoCaptureDevice.NewFrame += VideoCaptureDevice_NewFrame;
            videoCaptureDevice.Start();
            timerForScaningBook.Start();
        }

        private void btnBorrow_Click(object sender, EventArgs e)
        {
            var bookCopy = cmbBookCopy.SelectedItem as BookCopy;
            var libraryMember = cmbLibraryMembers.SelectedItem as LibraryMember;
            var stateService = new BorrowedBookStateService();
            var bookState = stateService.GetBorrowedBookStates();
            DateTime borrowDate = DateTime.Now;
            DateTime returnDate = borrowDate.AddDays(21);

            var service = new BorrowedBookOverviewService();
            if (service.IsBorrowed(bookCopy.Id))
            {
                MessageBox.Show("The book is already borrowed");
            }
            else if (service.IsReserved(bookCopy.Id))
            {
                if(service.IsReservedForLibraryMember(bookCopy.Id, libraryMember.Id))
                {
                    var toUpdate = service.GetBookOverviewByIdBookAndIdLibraryMember(bookCopy.Id, libraryMember.Id)[0];

                    toUpdate.BorrowDate = borrowDate;
                    toUpdate.ReturnDate = returnDate;
                    toUpdate.IdState = bookState[0].Id;

                    var success = service.UpdateBorrowedBookOverview(toUpdate);
                    if (success)
                    {
                        MessageBox.Show("The book has been successfully borrowed.");
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("The book is not borrowed, an error has occurred.");
                    }
                    

                }
                else
                {
                    MessageBox.Show("The book is already reserved");
                }

            }
            else
            {

                var borrowableBookOverview = new BorrowedBookOverview
                {
                    IdLibraryMember = libraryMember.Id,
                    IdState = 1,
                    BorrowDate = borrowDate,
                    ReturnDate = returnDate,
                    IdBookCopy = bookCopy.Id
                };

                var success = service.AddBorrowedBookOverview(borrowableBookOverview);
                if (success)
                {
                    MessageBox.Show("The book is borrowed.");
                    Close();
                }
                else
                {
                    MessageBox.Show("The book is not borrowed, an error has occurred.");
                }
            }
            //MessageBox.Show("Successfully borrowed book!");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmBookBorrow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (videoCaptureDevice != null)
            {
                if (videoCaptureDevice.IsRunning)
                {
                    videoCaptureDevice.Stop();
                }

            }    
        }

        private void timmerForScaning_Tick(object sender, EventArgs e)
        {
            if (pbScan.Image != null)
            {

                pictureBoxScanedMember.Visible = false;
                BarcodeReader barcodeReader = new BarcodeReader();
                Result result = barcodeReader.Decode((Bitmap)pbScan.Image);
                try
                {
                    if (result != null)
                    {
                        var service = new LibraryMemberService();
                        var scaned = service.GetLibraryMemberById(int.Parse(result.ToString()))[0];

                        foreach (var item in cmbLibraryMembers.Items)
                        {
                            var member = item as LibraryMember;
                            if (scaned.Id == member.Id)
                            {
                                cmbLibraryMembers.SelectedItem = item;
                                break;
                            }
                        }


                        timerForScaningMember.Stop();
                        if (videoCaptureDevice.IsRunning)
                        {
                            videoCaptureDevice.Stop();
                            pbScan.Image = null;
                            pictureBoxScanedMember.Visible = true;

                        }
                    }

                }
                catch (Exception)
                {
                    MessageBox.Show("Wrong QR code");
                    timerForScaningMember.Stop();
                    if (videoCaptureDevice.IsRunning)
                    {
                        videoCaptureDevice.Stop();
                        pbScan.Image = null;
                    }
                }

            }
        }

        private void cmbBook_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowAllBookCopies();
        }

        private void timerForScaningBook_Tick(object sender, EventArgs e)
        {
            if (pbScan.Image != null)
            {

                pictureBoxScanedBook.Visible = false;
                BarcodeReader barcodeReader = new BarcodeReader();
                Result result = barcodeReader.Decode((Bitmap)pbScan.Image);
                //cmbBook.Text = result.ToString();

                try
                {
                    if (result != null)
                    {
                        var service = new BookCopyService();
                        var scaned = service.GetBookCopyById(int.Parse(result.ToString()))[0];

                        var bookService = new BookService();
                        var bookForCopy = bookService.GetBookById(int.Parse(scaned.IdBook.ToString()))[0];

                        foreach (var item in cmbBook.Items)
                        {
                            var book = item as Book;
                            if (bookForCopy.Id == book.Id)
                            {
                                cmbBook.SelectedItem = item;
                                ShowAllBookCopies();
                                break;
                            }
                        }

                        foreach (var item in cmbBookCopy.Items)
                        {
                            var bookCopy = item as BookCopy;
                            if (scaned.Id == bookCopy.Id)
                            {
                                cmbBookCopy.SelectedItem = item;
                                break;
                            }
                        }




                        timerForScaningMember.Stop();
                        if (videoCaptureDevice.IsRunning)
                        {
                            videoCaptureDevice.Stop();
                            pbScan.Image = null;
                            pictureBoxScanedBook.Visible = true;

                        }
                    }
                    

                }
                catch(Exception)
                {
                    MessageBox.Show("Wrong QR code");
                    timerForScaningMember.Stop();
                    if (videoCaptureDevice.IsRunning)
                    {
                        videoCaptureDevice.Stop();
                        pbScan.Image = null;
                        

                    }
                }
                
            }

        }

        private void pictureBoxScaned_Click(object sender, EventArgs e)
        {

        }
    }
}