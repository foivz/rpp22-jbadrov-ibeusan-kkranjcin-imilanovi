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
    public partial class FrmUpdateBook : Form
    {
        public FrmUpdateBook()
        {
            InitializeComponent();
        }

        private void FrmUpdateBook_Load(object sender, EventArgs e)
        {
            //ShowBook();
            //ShowAllGenres();
            //ShowAllAuthors();
        }

        private void ShowBook()
        {
            throw new NotImplementedException();
        }

        private void ShowAllGenres()
        {
            throw new NotImplementedException();
        }

        private void ShowAllAuthors()
        {
            throw new NotImplementedException();
        }

        private void btnUpdateBook_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Successfully updated a book");
            Close();
        }
    }
}
