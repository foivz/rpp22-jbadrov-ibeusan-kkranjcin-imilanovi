using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QRCoder;

namespace QRCode
{
    public static class QRCodeManager
    {
        public static Bitmap GenerateQRCode(string text)
        {
            var qrCodeData = QRCodeGenerator.GenerateQrCode(text, QRCodeGenerator.ECCLevel.Q);
            QRCoder.QRCode qRCode = new QRCoder.QRCode(qrCodeData);
            return qRCode.GetGraphic(5);
        }
    }
}
