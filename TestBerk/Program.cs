using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Xml.Linq;

namespace Tester
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task #5012 Hastane Yetkilisi - Mernis

            //string abc = "123456789";
            //string x = abc.Substring(0, 2);

            //if (x == "99" || x == "98")
            //{
            //    //direkt save
            //    Console.WriteLine("Yabancı");
            //}
            //else
            //{
            //    //mernis'e gider
            //    Console.WriteLine("türk");
            //}

            #endregion

            #region Test 1.1 SubStr 

            //string x = "TK123AS67";
            //var x2 = x.Substring(2, 7);
            //Console.WriteLine(x2);

            //bool SayiMi(string text)
            //{
            //    foreach (char chr in text)
            //    {
            //        if (!Char.IsNumber(chr)) return false;
            //    }
            //    return true;
            //}

            //bool sonuc = SayiMi(x2);

            //if (sonuc == false)
            //{
            //    Console.WriteLine("HATAXX");
            //}

            #endregion

            #region MyRegion

            //string x = DateTime.Now.ToString("MM/dd/yyyy");
            //Console.WriteLine(x);
            //string xxx = "YEY";
            //string yyy = $"sdfsdf{xxx}";
            //Console.WriteLine(yyy);

            #endregion

            #region X

            //Int32 xx = 157286400;
            //var yyyy = xx;

            //var xxxxx = "";

            //string isim = "Muhammed";

            //Console.WriteLine($"Berkant {isim}");

            //string xx = "ö";

            //string xx1 = xx.ToUpper();

            //Console.WriteLine(xx1);

            //string yy = "i";

            //string yy1 = yy.ToUpper();

            //Console.WriteLine(yy1);

            //string deneme = "igIİğOoÖöçÇCcşŞÜüberkanttttttt";
            //string xx = TurkishCharacter(deneme);

            //Console.WriteLine(xx);

            //Console.WriteLine(xx.ToUpper());

            //var xxxx = RandomString();
            //Console.WriteLine(xxxx);


            //var yarram = DistinctString("1,2,3,3,3,3,3");

            //Console.WriteLine(yarram);

            #endregion

            #region MyRegion

            //Human humanBerkant = new Human
            //{
            //    Age = 10,
            //    Name = "Berkant",
            //    Surnam = "Ayar"
            //};

            //Human humanIbrahim = new Human
            //{
            //    Age = 10,
            //    Name = "asd",
            //    Surnam = "asd"
            //};

            //Console.WriteLine(humanBerkant.Name + humanIbrahim.Name  + humanBerkant.Surnam + humanBerkant.Age);

            //Human asd = new Human("berkatn", "sfdsd ", 23);

            //Dog dog1 = new Dog
            //{
            //    Age = 1,
            //    Name = "Dog1",
            //    Type = "Kangal"
            //};


            //List<Human> listHumans = new List<Human>();

            //Human human1 = new Human("berkant", "asd", 1);

            //listHumans.Add(human1);

            //Human human2 = new Human("safds", "dsafsdfs", 2);

            //listHumans.Add(human2);

            //Humans xxx = new Humans
            //{
            //    HumansX = listHumans,
            //    CompanyName = ",",
            //    HumanCount = listHumans.Count
            //};

            //xxx.HumansX.Where(x=> x.Name.Trim().ToLower().Contains("berk".Trim().ToLower()));

            //Human human2222 = new Human("eren", "yaman");


            #endregion

            #region PingATMA

            // string urlOrIpAddress = "webmail.kultur.gov.tr"; // Ping atılacak URL veya IP adresi

            //Ping ping = new Ping();
            //try
            //{
            //    PingReply reply = ping.Send(urlOrIpAddress);

            //    if (reply.Status == IPStatus.Success)
            //    {
            //        Console.WriteLine($"Ping başarılı. Yanıt süresi: {reply.RoundtripTime} ms");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"Ping başarısız. Yanıt kodu: {reply.Status}");
            //    }

            //    Console.WriteLine($"Hedef adres: {reply.Address}");
            //    Console.WriteLine($"Paket boyutu: {reply.Buffer.Length} bytes");
            //    Console.WriteLine($"TTL (Time To Live): {reply.Options?.Ttl}");
            //}
            //catch (PingException ex)
            //{
            //    Console.WriteLine($"Ping hatası: {ex.Message}");
            //}

            #endregion

            #region MyRegion

            //string url = "webmail.kultur.gov.tr"; // Hedef URL
            //int port = 25; // Hedef port (HTTP için genellikle 80 kullanılır)

            //using (HttpClient client = new HttpClient())
            //{
            //    // İstek gönderme
            //    HttpResponseMessage response = await client.GetAsync($"{url}:{port}");

            //    if (response.IsSuccessStatusCode)
            //    {
            //        // Başarılı yanıt alındığında içeriği oku
            //        string content = await response.Content.ReadAsStringAsync();
            //        Console.WriteLine("Başarılı istek:");
            //        Console.WriteLine(content);
            //    }
            //    else
            //    {
            //        Console.WriteLine($"Hata kodu: {response.StatusCode}");
            //    }
            //}
            //string serverIpAddress = "webmail.kultur.gov.tr"; // Hedef sunucu IP adresi veya alan adı
            //int port = 25; // Hedef port (HTTP için genellikle 80)

            //try
            //{
            //    // TCP istemcisini oluştur
            //    using (TcpClient client = new TcpClient(serverIpAddress, port))
            //    {
            //        // Istek metni oluştur
            //        string request = "GET / HTTP/1.1\r\n" +
            //                         "Host: " + serverIpAddress + "\r\n" +
            //                         "Connection: Close\r\n\r\n";

            //        // Istegi sunucuya gönder
            //        byte[] requestData = Encoding.ASCII.GetBytes(request);
            //        NetworkStream stream = client.GetStream();
            //        stream.Write(requestData, 0, requestData.Length);

            //        // Yanıtı oku
            //        byte[] responseData = new byte[4096];
            //        int bytesRead;
            //        StringBuilder response = new StringBuilder();

            //        do
            //        {
            //            bytesRead = stream.Read(responseData, 0, responseData.Length);
            //            response.Append(Encoding.ASCII.GetString(responseData, 0, bytesRead));
            //        } while (bytesRead > 0);

            //        Console.WriteLine("Sunucu yanıtı:");
            //        Console.WriteLine(response.ToString());
            //    }
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine($"Hata: {ex.Message}");


            #endregion



            // Büyük CSV dosyasının yolu
            string buyukDosyaYolu = "C:\\Users\\Berkant AYAR\\Desktop\\IpCountry\\yeni-dosya8.CSV";

            // Yeni CSV dosyasının yolu
            string yeniDosyaYolu = "C:\\Users\\Berkant AYAR\\Desktop\\IpCountry\\yeni-dosya10.CSV";



            // CSV dosyasını oku
            var records = ReadCsv(buyukDosyaYolu);

            // İlk satırdaki belirli sütunlardaki değerleri değiştir
            ModifyFirstRow(records);

            // Değişiklikleri içeren dosyayı yaz
            WriteCsv(yeniDosyaYolu, records);

            Console.WriteLine("İşlem tamamlandı.");
        }

        static List<string[]> ReadCsv(string filePath)
        {
            return File.ReadAllLines(filePath)
                .Select(line => line.Split(','))
                .ToList();
        }

        static void ModifyFirstRow(List<string[]> records)
        {
            // Başlık satırındaki indeksleri belirle
            int ipStartIndex = 1; // 2. sütun
            int ipEndIndex = 2;   // 3. sütun
            int countryCodeIndex = 3; // 4. sütun
            int countryNameIndex = 4; // 5. sütun

            // İlk satırdaki belirli sütunlardaki değerleri değiştir
            records[0][ipStartIndex] = "ipStart";
            records[0][ipEndIndex] = "ipEnd";
            records[0][countryCodeIndex] = "CountryCode";
            records[0][countryNameIndex] = "CountryName";
        }

        static void WriteCsv(string filePath, List<string[]> records)
        {
            File.WriteAllLines(filePath, records.Select(record => string.Join(",", record)));
        }



        static void GruplaVeYaz(string kaynakDosya, string hedefDosya, int ilkSutunIndeks)
        {
            try
            {
                using (StreamReader reader = new StreamReader(kaynakDosya))
                using (StreamWriter writer = new StreamWriter(hedefDosya))
                {
                    // Başlık satırını oku ve yaz
                    string baslikSatiri = reader.ReadLine();
                    writer.WriteLine(baslikSatiri);

                    // Verileri grupla ve yaz
                    var gruplar = new Dictionary<string, List<string[]>>();
                    while (!reader.EndOfStream)
                    {
                        string satir = reader.ReadLine();
                        string[] sutunlar = satir.Split(',');

                        // Grup anahtarını al
                        string grupAnahtari = sutunlar[ilkSutunIndeks];

                        // Grup anahtarına göre verileri grupla
                        if (!gruplar.ContainsKey(grupAnahtari))
                        {
                            gruplar[grupAnahtari] = new List<string[]>();
                        }

                        gruplar[grupAnahtari].Add(sutunlar);
                    }

                    // Her bir grup için en küçük ve en büyük değerleri yaz
                    foreach (var grup in gruplar)
                    {
                        string grupAnahtari = grup.Key;
                        List<string[]> grupVerileri = grup.Value;

                        // Her sütun için en küçük ve en büyük değerleri bul
                        string[] enKucukDegerler = grupVerileri.Select(veri => veri.Min()).ToArray();
                        string[] enBuyukDegerler = grupVerileri.Select(veri => veri.Max()).ToArray();

                        // Yeni satırı oluştur ve yaz
                        string yeniSatir = string.Join(",", enKucukDegerler.Take(ilkSutunIndeks + 1).Concat(new[] { grupAnahtari }).Concat(enBuyukDegerler.Skip(ilkSutunIndeks + 1)));
                        writer.WriteLine(yeniSatir);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata: " + ex.Message);
            }
        }

        static void BirlestirVeYaz(string kaynakDosya, string hedefDosya, int birlestirilecekSutunIndeks)
        {
            try
            {
                using (StreamReader reader = new StreamReader(kaynakDosya))
                using (StreamWriter writer = new StreamWriter(hedefDosya))
                {
                    // Başlık satırını oku ve yaz
                    string baslikSatiri = reader.ReadLine();
                    writer.WriteLine(baslikSatiri);

                    // Ülkeleri birleştir ve yeni dosyaya yaz
                    Dictionary<string, string> ulkeVerileri = new Dictionary<string, string>();
                    while (!reader.EndOfStream)
                    {
                        string satir = reader.ReadLine();
                        string[] sutunlar = satir.Split(',');

                        // Birleştirilecek sütun değerini al
                        string birlestirilecekDeger = sutunlar[birlestirilecekSutunIndeks];

                        // Birleştirilecek değeri anahtar olarak kullanarak ülke verilerini güncelle
                        if (ulkeVerileri.ContainsKey(birlestirilecekDeger))
                        {
                            // Eğer zaten bir değer varsa, en büyüğü al
                            string eskiDeger = ulkeVerileri[birlestirilecekDeger];
                            string yeniDeger = sutunlar.Max().ToString();
                            ulkeVerileri[birlestirilecekDeger] = yeniDeger;
                        }
                        else
                        {
                            // Eğer değer yoksa, ekleyerek sütunları yaz
                            ulkeVerileri.Add(birlestirilecekDeger, string.Join(",", sutunlar));
                        }
                    }

                    // Ülke verilerini yaz
                    foreach (var ulkeVerisi in ulkeVerileri)
                    {
                        writer.WriteLine(ulkeVerisi.Value);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata: " + ex.Message);
            }


        }
   
        #region Test 1.1 FuncMeth

        public static string toUpper(string text)
        {
            return text.ToUpper();
        }

        public static int topla(int x, int y)
        {
            //if (x == 6)
            //    return 0;

            int result;

            result = x + y;

            return result;
        }

        public string toLowerspecial(string text)
        {
            return text.ToLower();
        }

        #endregion

        #region 3/30/23

        //public static string TurkishCharacter(string text)
        //{
        //    char[] turkishChars = { 'ı', 'ğ', 'İ', 'Ğ', 'ç', 'Ç', 'ş', 'Ş', 'ö', 'Ö', 'ü', 'Ü' };
        //    char[] englishChars = { 'i', 'g', 'I', 'G', 'c', 'C', 's', 'S', 'o', 'O', 'u', 'U' };

        //    // Match chars
        //    for (int i = 0; i < turkishChars.Length; i++)
        //        text = text.Replace(turkishChars[i], englishChars[i]);

        //    return text;
        //}

        //public static string RandomString(int length = 6)
        //{
        //    Random random = new Random();
        //    const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
        //    return new string(Enumerable.Repeat(chars, length)
        //        .Select(s => s[random.Next(s.Length)]).ToArray());
        //}

        #endregion

        #region DistinctString


        //public static string DistinctString(string text)


        #endregion


        public class BaseClass
        {
            public string Name { get; set; }
            public int Age { get; set; } = 5;
        }
        public class Human : BaseClass
        {
            //public string Name { get; set; }
            public string Surnam { get; set; } = "lafjksd";
            //public int Age { get; set; }

            public Human(string name, string surname, int x)
            {
                Name = name;
                Surnam = surname;
                Age = x;
            }

            public Human(string name, string surnam)
            {
                Name = name;
                Surnam = surnam;
                Age = 5;
            }

        }
        public class Dog : BaseClass
        {
            public string Type { get; set; }
            //public string Name { get; set; }
            //public int Age { get; set; }

        }

        public class Humans
        {
            public List<Human> HumansX { get; set; }
            public int HumanCount { get; set; }
            public string CompanyName { get; set; }

        }


        public static Exc Topla(int x, int y)
        {
            //int c = x+y;
            //return c;

            var a = x + y;

            var xy = new Exc($"Benim Toplamım şu: {a} ");

            return xy;
        }

        public class Exc
        {
            public string Desc { get; set; }

            public Exc(string x)
            {
                Desc = x;
            }
        }

    }
}
