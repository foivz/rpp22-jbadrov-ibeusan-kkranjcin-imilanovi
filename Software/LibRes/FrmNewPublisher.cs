using BusinessLogicLayer.Services;
using DataAccessLayer;
using System;
using System.Windows.Forms;

namespace LibRes
{
    public partial class FrmNewPublisher : Form
    {
        public FrmNewPublisher()
        {
            InitializeComponent();
            HelpRequested += FrmNewPublisher_HelpRequested;
        }

        private void FrmNewPublisher_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Help.ShowHelp(this, "..\\..\\Resources\\help.chm", HelpNavigator.KeywordIndex, "NewPublisher");
        }

        private void btnAddPublisher_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                MessageBox.Show("Please fill in the name of the publisher!");
                return;
            }

            if (txtYearOfEst.Text == "")
            {
                MessageBox.Show("Please fill in the year of establishment of the publisher!");
                return;
            }

            Publisher publisher = new Publisher
            {
                Name = txtName.Text,
                Founded = int.Parse(txtYearOfEst.Text)
            };

            PublisherService publisherService = new PublisherService();
            if (publisherService.AddPublisher(publisher))
            {
                MessageBox.Show("Successfully added a new publisher: " + txtName + "!");
            }
            else
            {
                MessageBox.Show("Problem occurred while adding a new publisher!");
            }
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
