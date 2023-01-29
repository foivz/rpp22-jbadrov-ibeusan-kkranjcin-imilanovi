using QRCode;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace LibRes
{
    public partial class FrmQRCode : Form
    {
        private string _phrase { get; set; }
        public FrmQRCode(string phrase)
        {
            InitializeComponent();
            LoadPrinters();
            _phrase = phrase;
            HelpRequested += FrmQRCode_HelpRequested;
        }

        private void FrmQRCode_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Help.ShowHelp(this, "..\\..\\Resources\\help.chm", HelpNavigator.KeywordIndex, "QRCode");
        }

        private void LoadPrinters()
        {
            var printers = new List<string>();
            if(printers.Count == 0)
            {
                foreach(string s in PrinterSettings.InstalledPrinters)
                {
                    printers.Add(s);
                }
            }
            cbPrinters.DataSource = printers;
        }

        private void FrmQRCode_Load(object sender, EventArgs e)
        {
            pbQRCode.Image = QRCodeManager.GenerateQRCode(_phrase);
        }

        protected void btnPrint_Click(object sender, EventArgs e)
        {
            if(cbPrinters.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a printer!");
                return;
            }

            PrinterSettings printerSettings = new PrinterSettings();
            printerSettings.PrinterName = cbPrinters.SelectedItem as string;

            PrintDocument pd = new PrintDocument();
            pd.PrintPage += PrintPage;

            try
            {
                pd.Print();
            }
            catch (InvalidPrinterException ex)
            {
                MessageBox.Show(ex.Message + "\n Please choose a connected printer");
            }
        }

        private void PrintPage(object o, PrintPageEventArgs e)
        {
            Image img = pbQRCode.Image;
            Point loc = new Point(100, 100);
            e.Graphics.DrawImage(img, loc);
        }
    }
}
