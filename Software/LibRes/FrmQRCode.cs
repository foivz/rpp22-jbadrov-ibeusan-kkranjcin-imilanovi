using DataAccessLayer;
using QRCode;
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
    public partial class FrmQRCode : Form
    {
        private string _phrase { get; set; }
        public FrmQRCode(string phrase)
        {
            InitializeComponent();
            _phrase = phrase;
        }

        private void FrmQRCode_Load(object sender, EventArgs e)
        {
            pbQRCode.Image = QRCodeManager.GenerateQRCode(_phrase);
        }
    }
}
