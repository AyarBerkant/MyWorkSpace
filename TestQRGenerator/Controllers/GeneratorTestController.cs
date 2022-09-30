using System.Drawing;
using System.Drawing.Imaging;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography;
using System.Text;
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
        public async Task<ActionResult> GenerateQRCode([FromForm] string a )
        {
            RandomNumberGenerator generator = new RandomNumberGenerator();
            string pass = generator.GenerateQrCode();

            QRCodeGenerator _qrCode = new QRCodeGenerator();
            QRCodeData _qrCodeData = _qrCode.CreateQrCode(a, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(_qrCodeData);
            Image qrCodeImage = qrCode.GetGraphic(20);

            MemoryStream ms = new MemoryStream();
            qrCodeImage.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
            var bytes = ms.ToArray();

            return File(bytes, "image/png");
        }
    }
    public class RandomNumberGenerator
    {
        // Generate a random number between two numbers    
        public int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }

        // Generate a random string with a given size and case.   
        // If second parameter is true, the return string is lowercase  
        public string RandomString(int size, bool lowerCase)
        {
            StringBuilder builder = new StringBuilder();
            Random random = new Random();
            for (int i = 0; i < 50; i++)
            {
                builder.Append((char)random.Next(48, 57));
                Console.WriteLine(builder);
            }
            char ch;
            for (int i = 0; i < size; i++)
            {
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                builder.Append(ch);
            }
            if (lowerCase)
                return builder.ToString().ToLower();
            return builder.ToString();
        }

        // Generate a random password of a given length (optional)  
        public string RandomPassword(int size = 0)
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(RandomString(4, true));
            builder.Append(RandomNumber(1000, 9999));
            builder.Append(RandomString(2, false));
            return builder.ToString();
        }
        public string GenerateQrCode()
        {
            StringBuilder password = new StringBuilder();
            Random random = new Random();

            while (password.Length < 30)
            {
                password.Append((char)random.Next(48,57));
                //password.Append((char)random.Next(97, 122));
            }
            return password.ToString();
        }
    }
}
