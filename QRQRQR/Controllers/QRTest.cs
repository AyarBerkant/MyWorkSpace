using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using QRCoder;

namespace QRQRQR.Controllers
{
    [Route("/[controller]")]
    [ApiController]
    public class QRTest : Controller
    {
        public byte[] Imagetoarray(System.Drawing.Image imagein)
        {
            MemoryStream ms = new MemoryStream();
            imagein.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            return ms.ToArray();
        }

        [HttpPost("[action]xx")]
        public async Task<IActionResult> GenerateQRCode(string qrCodeText)
        {
            QRCodeGenerator _qrCode = new QRCodeGenerator();
            QRCodeData _qrCodeData = _qrCode.CreateQrCode(qrCodeText, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(_qrCodeData);
            Image qrCodeImage = qrCode.GetGraphic(20);

            var bytes = Imagetoarray(qrCodeImage);
            return File(bytes, "image/bmp");
        }
    }
}
