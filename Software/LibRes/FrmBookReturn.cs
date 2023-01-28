using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogicLayer.Services;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;
using DataAccessLayer;
using DataAccessLayer.DataGridViewModel;

namespace LibRes
{
    public partial class FrmBookReturn : Form
    {
        public FrmBookReturn()
        {
            InitializeComponent();
        }
        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice videoCaptureDevice;

        

        public void FrmBookReturn_Load(object sender, EventArgs e)
        {
            pbScanMember.Visible = false;
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filterInfo in filterInfoCollection)
            {
                cmbDevices.Items.Add(filterInfo.Name);
            }
            cmbDevices.SelectedIndex = 0;
            //ShowAllBooks();
            ShowAllMembers();
            dgvBookOverviews.DataSource = null;
            HidePenaltyRelatedControls();


        }

        public void HidePenaltyRelatedControls()
        {
            lblReturn.Visible = false;
            lblLate.Visible = false;
            lblPenalty.Visible = false;
            txtLate.Visible = false;
            txtPenalty.Visible = false;
            btnOK.Visible = false;
        }

        public void ShowPenaltyRelatedControls()
        {
            lblReturn.Visible = true;
            lblLate.Visible = true;
            lblPenalty.Visible = true;
            txtLate.Visible = true;
            txtPenalty.Visible = true;
            btnOK.Visible = true;
        }



        private void ShowAllMembers()
        {
            var service = new LibraryMemberService();
            cmbMember.DataSource = service.GetLibraryMembers();

        }

        private void btnScanBook_Click(object sender, EventArgs e)
        {

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            if(dgvBookOverviews.SelectedRows.Count == 1)
            {
                var item = dgvBookOverviews.CurrentRow.DataBoundItem as BorrowedBookDetails;
                var service = new BorrowedBookOverviewService();
                var borrowedBookOverview = service.GetBorrowedBookOverviewById(item.Id)[0];
                int lateDays = CalculateDifferenceInDays(borrowedBookOverview.ReturnDate);
                double penalty = lateDays * 0.1;
                borrowedBookOverview.IdState = 2;
                var sucess = service.UpdateBorrowedBookOverview(borrowedBookOverview);

                if (sucess)
                {
                    txtLate.Text = lateDays.ToString() + " days";
                    txtPenalty.Text = penalty.ToString() + " EUR";
                    lblReturn.Text = "The book has been returned";
                    ShowPenaltyRelatedControls();

                    ShowBookOverviewsForLibraryMember();

                }
                else
                {
                    MessageBox.Show("The book has not been returned, an error occurred");
                }

                
                
            }
            else
            {
                MessageBox.Show("Choose one book");
            }
            
        }

        private int CalculateDifferenceInDays(DateTime? returnDate)
        {
            DateTime today = DateTime.Today;
            if (returnDate.HasValue)
            {
                TimeSpan difference = today - returnDate.Value ;
                if (difference.TotalDays > 0)
                {
                    return difference.Days;
                }
                else return 0;
                
            }
            else
            {
                return -1; 
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnScanMember_Click(object sender, EventArgs e)
        {

            videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[cmbDevices.SelectedIndex].MonikerString);
            videoCaptureDevice.NewFrame += VideoCaptureDevice_NewFrame;
            videoCaptureDevice.Start();
            timerForScaning.Start();
            

        }

        private void VideoCaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            
            pbScan.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void timerForScaning_Tick(object sender, EventArgs e)
        {
            if (pbScan.Image != null)
            {
                pbScanMember.Visible = false;
                BarcodeReader barcodeReader = new BarcodeReader();
                Result result = barcodeReader.Decode((Bitmap)pbScan.Image);
                try
                {
                    if (result != null)
                    {
                        var service = new LibraryMemberService();
                        var scaned = service.GetLibraryMemberById(int.Parse(result.ToString()))[0];

                        foreach (var item in cmbMember.Items)
                        {
                            var member = item as LibraryMember;
                            if (scaned.Id == member.Id)
                            {
                                cmbMember.SelectedItem = item;
                                
                                break;
                            }
                        }


                        timerForScaning.Stop();
                        if (videoCaptureDevice.IsRunning)
                        {
                            videoCaptureDevice.Stop();
                            pbScan.Image = null;
                            pbScanMember.Visible = true;
                           

                        }
                    }

                }
                catch (Exception)
                {
                    MessageBox.Show("Wrong QR code");
                    timerForScaning.Stop();
                    if (videoCaptureDevice.IsRunning)
                    {
                        videoCaptureDevice.Stop();
                        pbScan.Image = null;
                        timerForScaning.Stop();
                    }
                }

            }

        }

        private void FrmBookReturn_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (videoCaptureDevice != null)
            {
                if (videoCaptureDevice.IsRunning)
                {
                    videoCaptureDevice.Stop();
                }

            }

        }

        private void cmbMember_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowBookOverviewsForLibraryMember();
            
        }

        private void ShowBookOverviewsForLibraryMember()
        {
            var member = cmbMember.SelectedItem as LibraryMember;
            var serviceOverview = new BorrowedBookOverviewService();
            dgvBookOverviews.DataSource = serviceOverview.GetBorrowedBookDetailsByLibraryMember(member.Id);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            HidePenaltyRelatedControls();
        }
    }
}
