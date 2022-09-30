using System;
using System.Security.Cryptography.X509Certificates;

namespace MuhasebeX
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Sistem Bakiye Bilgileri

            float sistemBakiye = 50000;
            float sistemAdminYüzde = 1;

            #endregion

            #region Kullanıcı Bakiyeleri

            float birinciKullaniciBakiye = 1135;
            float ikinciKullaniciBakiye = 1645;
            float birinciKullaniciYüzde = 0;
            float ikinciKulaniciYüzde = 0;
            
            #endregion

            #region Total Yüzde Hesaplama

            sistemBakiye = sistemBakiye + birinciKullaniciBakiye;
            birinciKullaniciYüzde = (birinciKullaniciBakiye*100)/sistemBakiye;

            sistemBakiye = sistemBakiye + birinciKullaniciBakiye;
            ikinciKulaniciYüzde = (birinciKullaniciBakiye * 100) / sistemBakiye;

            sistemAdminYüzde = 100 - (birinciKullaniciYüzde + ikinciKulaniciYüzde);

            #endregion

            #region Sistem Para Artış

            sistemBakiye = sistemBakiye + 10000;

            #endregion

            #region kişi bazlı para hesabı

            //birinci kisi
            float birinciKisiBakiyeYeni = (sistemBakiye * birinciKullaniciYüzde) / 100;
            //ikinci kisi
            float ikinciKisiBakiyeYeni = (sistemBakiye * ikinciKulaniciYüzde) / 100;
            //admin
            float sistemAdminBakiyeYeni = (sistemBakiye * sistemAdminYüzde) / 100;

            //doğru mu kontrol

            float totalPara = birinciKisiBakiyeYeni + ikinciKisiBakiyeYeni + sistemAdminBakiyeYeni;
            if (totalPara == sistemBakiye)
            {
                Console.WriteLine("Ok!");

                Console.WriteLine(birinciKisiBakiyeYeni);
                Console.WriteLine(ikinciKisiBakiyeYeni);
                Console.WriteLine(sistemAdminBakiyeYeni);
            }

            #endregion









        }
    }

}
