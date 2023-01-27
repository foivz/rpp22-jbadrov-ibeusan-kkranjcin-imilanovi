using System;
using System.Windows.Forms;

namespace LibRes
{
    public partial class FrmBooksOverview : Form
    {
        public FrmBooksOverview()
        {
            InitializeComponent();
        }

        private void FrmBooksOverview_Load(object sender, EventArgs e)
        {
            ShowAllReservations();
            ShowAllBorrows();
        }

        private void ShowAllReservations()
        {
            throw new NotImplementedException();
        }

        private void ShowAllBorrows()
        {
            throw new NotImplementedException();
        }

        private void btnBorrow_Click(object sender, EventArgs e)
        {

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {

        }
    }
}
