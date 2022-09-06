using System.Drawing;
using System.Drawing.Imaging;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography;
using QRCoder;
using Microsoft.AspNetCore.Mvc;


namespace TestQRGenerator.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GeneratorTestController : Controller
    {
        public class MyFirstObj
        {
            public string Name { get; set; }
            public string Surname { get; set; }
        }
        private byte[] Imagetoarray(System.Drawing.Image imagein)
        {
            MemoryStream ms = new MemoryStream();
            imagein.Save(ms,System.Drawing.Imaging.ImageFormat.Jpeg);
            return ms.ToArray();
        }

        [HttpPost("[action]")]
        public async Task<ActionResult> GenerateQRCode([FromForm] MyFirstObj obj)
        {
            QRCodeGenerator _qrCode = new QRCodeGenerator();
            QRCodeData _qrCodeData = _qrCode.CreateQrCode($"{obj.Name} {obj.Surname}", QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(_qrCodeData);
            Image qrCodeImage = qrCode.GetGraphic(20);

            var bytes = Imagetoarray(qrCodeImage);
            return File(bytes, "image/bmp");
        }
    }
}
