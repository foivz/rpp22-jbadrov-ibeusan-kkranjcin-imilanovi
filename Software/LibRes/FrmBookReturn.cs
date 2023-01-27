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
using DataAccessLayer.DataGridViewModels;

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

            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filterInfo in filterInfoCollection)
            {
                cmbDevices.Items.Add(filterInfo.Name);
            }
            cmbDevices.SelectedIndex = 0;
            //ShowAllBooks();
            ShowAllMembers();
            dgvBookOverviews.DataSource = null;

            
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
                borrowedBookOverview.IdState = 2;
                var sucess = service.UpdateBorrowedBookOverview(borrowedBookOverview);

                if (sucess)
                {
                    MessageBox.Show("Succes");
                }
                ShowBookOverviewsForLibraryMember();
                
            }
            else
            {
                MessageBox.Show("Choose one book");
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
    }
}
