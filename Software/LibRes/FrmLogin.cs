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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            FrmBookSearch frmBookSearch = new FrmBookSearch();
            Hide();
            frmBookSearch.ShowDialog();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
