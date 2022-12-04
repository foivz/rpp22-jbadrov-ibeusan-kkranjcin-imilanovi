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
    public partial class FrmBookReturn : Form
    {
        public FrmBookReturn()
        {
            InitializeComponent();
        }

        public void FrmBookReturn_Load(object sender, EventArgs e)
        {
            ShowAllBooks();
            ShowAllMembers();
        }

        private void ShowAllBooks() 
        {
            throw new NotImplementedException();
        }

        private void ShowAllMembers()
        {
            throw new NotImplementedException();
        }

        private void btnScanBook_Click(object sender, EventArgs e)
        {

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Successfully borrowed book!");
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnScanMember_Click(object sender, EventArgs e)
        {
            
        }
    }
}
