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
    public partial class FrmNewPublisher : Form
    {
        public FrmNewPublisher()
        {
            InitializeComponent();
        }

        private void btnAddPublisher_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Successfully added a new publisher!");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
