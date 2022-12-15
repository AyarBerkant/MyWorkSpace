using System;

namespace CSharper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            uyeClass uyeClass = new uyeClass();

            uyeStruct s = new uyeStruct(20);
     
        }
    }

    internal class uyeClass
    {
        private string deger;

        public uyeClass()
        {
            deger = "berkant";
        }
    }

    internal struct uyeStruct
    {
        public int yas { get; set; }

        public uyeStruct(int yas2)
        {
            yas = yas2;
        }
    }
}
