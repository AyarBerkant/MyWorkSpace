using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace Tester
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //#region Task #5012 Hastane Yetkilisi - Mernis

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

            //#endregion

            string x = "ÖöUüIİiı";
            x = x.ToLower();
            Console.WriteLine(x);

        }

        public static string toUpper(string text)
        {
            return text.ToUpper();
        }
        public  string toLowerspecial( string text)
        {
            return text.ToLower();
        }
    }   
}
