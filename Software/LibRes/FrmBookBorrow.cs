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
    public partial class FrmBookBorrow : Form
    {
        public FrmBookBorrow()
        {
            InitializeComponent();
        }
        private void FrmBookBorrow_Load(object sender, EventArgs e)
        {
            ShowAllMembers();
            ShowAllBooks();
        }

        private void ShowAllMembers()
        {
            throw new NotImplementedException();
        }

        private void ShowAllBooks()
        {
            
        }

        private void btnScanMember_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Successfully scanned a member!");
        }

        private void btnScanBook_Click(object sender, EventArgs e)
        {

        }

        private void btnBorrow_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Successfully borrowed book!");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
