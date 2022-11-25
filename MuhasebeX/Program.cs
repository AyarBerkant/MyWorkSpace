using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace MuhasebeX
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Test SystemDesign 1.1

            //TODO  Sisteme Giren Kisiler Kâr hesaplaması yapılmalı
            //Yatırım geldikçe paraları artmamalı. Artsaydı easy ama artmamalı.
            //Base değer üzerinden denenebilir.
            /*Girilen tüm değerleri tutsak BaseDeğer dahil. 
             *MATH
             *Sisteme birileri paraları ile giriş yapıcaklar zaman içerisin de ve 1 ay süre sonra sistemden çıkış yapıcaklar
             *Ekledikleri para anaparaya eklenecek
             *Girisler Farklı zamanlarda olabilir.
             *1 Ay sonra çıkış paraları
             * Kullanıcılar 1 ay dışında farklı zaman dilimlerine sahip paketler almak isteyebilir.
             * Paketler için ücretler belirlenmei
             */

            //TODO Solution1
            /*
             * Sisteme giren kullanıcılara yeni eklenen para üzerinden bir yüzde verilecek
             * Sisteme her kullanıcı dahil olduğunda sahip olduğu para üzerinde ki yüzdesinden parası hesaplanacak ve yeni parada ki yüzde miktarı belirlenecek...
             *TODO Bu İşlem Şu şekilde yapılacak
             * O anda sistem de ki kullanıcının para miktarı yüzdesi üzerinden hesaplanacak. Yeni kullanıcının yatırmış olduğu para miktarı anapara üzerine eklenecek
             * ve işlem yapılan diğer kullanıcının yüzdesi TODO yüzdehesaplama metodu ile hesaplanacak ve db ye kayıt edilecek
             * Bu şekilde her kullanıcı katıldığında elimizde ki kullanıcıları o ana kadar yapmıs oldukları kâr miktarı ile anaparaları,kâr,zararları üzerinde herhangi bi değişiklik yapmadan
             * yeni yüzdelerini belirleyerek haksız kazanç artış ve azalış miktarları hesaplanır.
             * Tek hesap üzerinden birden fazla kullanıcıya hizmet verileceği için her sekilde herkesin sistemin ne kadarına sahip oldukları hesabının yapılması gerekmektedir.
             * Aynı şekilde bir kullanıcı sistemden çıkacağı zamanda o kullanıcının yüzdesi bilindiği için ana para üzerinden sahip olduğu para hesaplanmalı
             * komisyon düşülmeli ve sistemsahibi kâr payı çıkartılmalı. Bu şekilde kullanıcıya parası verilmeli.
             * Sistem çalışmaya devam edeceği ve hem para hem yüzde çıkışı olduğu için diğer kullanıcıların sırasıyla öncelikle sistemde ki paraları hesaplanmalı ardından sistem
             * üzerinden para düşüldüğünde ellerinde ki para ile sistemde sahip oldukları yüzde hesaplanmalı ve bu sekilde bu yüzdeler sisteme kayıt edilmeli.
             * Bu şekilde sistemden kullanıcığı çıktığında sistem üzerinde ki diğer kullanıcılar para kaybına uğramamalı.
             * Sistem için eğer softdelete kullanılıcaksa repo islemlerine bu belirtilmeli.
             *  
             * TODO yüzdehesaplama
             * Sahip olduğu yüzde miktarı üzerinden sistem de ki para hesaplanacak Anapara üzerinde ki değişim gerçkleştirilecek
             * Yeni ana para üzerinde ki yüzdesi hesaplanacak
             * Parası = anapara*yüzdesi/100
             * Yeni yüzde  = Yenianapara*100/Parası
             *
             *
             *
             * */

            #endregion


            #region Test 1.1

            //string[] x = { "Berkant", "Berkant", "Achmet", "Pasia" };

            //var y = x.Distinct().Count();

            //Console.WriteLine(y);


            //string xyyy = "11312";
            //var bbb = xyyy.ToList();

            //int a = 54;  // int double 
            //string xxx = "kljhjkh";
            //string xxxxx = a.ToString(); // 54 to "54"

            //var sxgsdfg = "sdafasd";

            //List<string> myList = new List<string>();

            //myList.Add("Berkant");
            //myList.Add("Alper");
            //myList.Add("Alper2");

            //MyClass asdsdsdx = new MyClass("asda");



            //var abc = Toplama(5, 2);

            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //foreach (var XXXX in myList)
            //{
            //    var xxcxc = XXXX.First();
            //}

            //while (true)
            //{

            //}

            //do
            //{

            //} while (x=5);

            #endregion


            #region Test 1.2

            //while (true)
            //{

            //}

            //do
            //{

            //} while (x=5);

            //#region Sistem Bakiye Bilgileri

            //float sistemBakiye = 50000;
            //float sistemAdminYüzde = 1;

            //#endregion

            //#region Kullanıcı Bakiyeleri

            //float birinciKullaniciBakiye = 1135;
            //float ikinciKullaniciBakiye = 1645;
            //float birinciKullaniciYüzde = 0;
            //float ikinciKulaniciYüzde = 0;

            //#endregion

            //#region Total Yüzde Hesaplama

            //sistemBakiye = sistemBakiye + birinciKullaniciBakiye;
            //birinciKullaniciYüzde = (birinciKullaniciBakiye*100)/sistemBakiye;

            //sistemBakiye = sistemBakiye + birinciKullaniciBakiye;
            //ikinciKulaniciYüzde = (birinciKullaniciBakiye * 100) / sistemBakiye;

            //sistemAdminYüzde = 100 - (birinciKullaniciYüzde + ikinciKulaniciYüzde);

            //#endregion

            //#region Sistem Para Artış

            //sistemBakiye = sistemBakiye + 10000;

            //#endregion

            //#region kişi bazlı para hesabı

            ////birinci kisi
            //float birinciKisiBakiyeYeni = (sistemBakiye * birinciKullaniciYüzde) / 100;
            ////ikinci kisi
            //float ikinciKisiBakiyeYeni = (sistemBakiye * ikinciKulaniciYüzde) / 100;
            ////admin
            //float sistemAdminBakiyeYeni = (sistemBakiye * sistemAdminYüzde) / 100;

            ////doğru mu kontrol

            //float totalPara = birinciKisiBakiyeYeni + ikinciKisiBakiyeYeni + sistemAdminBakiyeYeni;
            //if (totalPara == sistemBakiye)
            //{
            //    Console.WriteLine("Ok!");

            //    Console.WriteLine(birinciKisiBakiyeYeni);
            //    Console.WriteLine(ikinciKisiBakiyeYeni);
            //    Console.WriteLine(sistemAdminBakiyeYeni);
            //}

            //#endregion

            #endregion


        }

        #region Test MethodClass 1.1

        //public class MyClass
        //{
        //    public string Name { get; set; } = "Berkant";
        //    public int Yas { get; set; } = 10;

        //    public MyClass(string Xxxx)
        //    {
        //        Name = Xxxx;
        //    }
        //}

        //public static int Toplama(int x, int y)
        //{
        //    int c = x + y;
        //    return c;
        //}

        #endregion

    }

}
