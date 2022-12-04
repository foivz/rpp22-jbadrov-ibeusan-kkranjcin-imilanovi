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
    public partial class FrmUpdateLibrarian : Form
    {
        public FrmUpdateLibrarian()
        {
            InitializeComponent();
        }

        private void btnUpdateLibrarian_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Successfully updated a librarian!");
            Close();
        }

        private void btnUpdateFaceRecognition_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Successfully updated a face for recognition!");
        }
    }
}
