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
        public FrmUpdateBookCopy()
        {
            InitializeComponent();
        }

        private void FrmUpdateBookCopy_Load(object sender, EventArgs e)
        {
            //ShowBook();
            //ShowAllPublishers();
        }

        private void ShowBook()
        {
            throw new NotImplementedException();
        }

        private void ShowAllPublishers()
        {
            throw new NotImplementedException();
        }

        private void btnUpdateBookCopy_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Successfully added a new book copy!");
            Close();
        }
    }
}
