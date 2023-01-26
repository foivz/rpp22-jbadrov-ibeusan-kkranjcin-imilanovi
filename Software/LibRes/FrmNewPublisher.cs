using BusinessLogicLayer.Services;
using DataAccessLayer;
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
            Publisher publisher = new Publisher
            {
                Name = txtName.Text,
                Founded = int.Parse(txtYearOfEst.Text)
            };

            PublisherService publisherService = new PublisherService();
            if (publisherService.AddPublisher(publisher))
            {
                MessageBox.Show("Successfully added a new publisher!");
            }
            else
            {
                MessageBox.Show("Problem occurred while adding new publisher!");
            }
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
