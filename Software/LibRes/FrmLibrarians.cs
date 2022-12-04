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
    public partial class FrmLibrarians : Form
    {
        public FrmLibrarians()
        {
            InitializeComponent();
        }

        private void FrmLibrarians_Load(object sender, EventArgs e)
        {
            ShowAllLibrarians();
        }

        private void ShowAllLibrarians()
        {
            throw new NotImplementedException();
        }

        private void btnAddLibrarian_Click(object sender, EventArgs e)
        {
            FrmNewLibrarian frm = new FrmNewLibrarian();
            frm.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            FrmUpdateLibrarian frm = new FrmUpdateLibrarian();
            frm.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            
        }
    }
}
