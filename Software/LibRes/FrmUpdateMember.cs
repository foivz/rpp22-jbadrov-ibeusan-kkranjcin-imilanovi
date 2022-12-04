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
    public partial class FrmUpdateMember : Form
    {
        public FrmUpdateMember()
        {
            InitializeComponent();
        }

        private void btnUpdateMember_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Successfully updated a library member");

        }
    }
}
