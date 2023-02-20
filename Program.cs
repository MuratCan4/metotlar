using System;

namespace metots
{
    class Program
    {
        static void Main (string[] args)
        {
            int a = 15;
            int b = 77;
            int sonuc = toplama(a,b);
            Console.WriteLine(sonuc);

            Metotlar metot = new Metotlar();
            metot.EkranaYazdir(sonuc.ToString());
        } 

        static int toplama (int sayi1, int sayi2)
        {
            return(sayi1+sayi2);
        }
    }
    class Metotlar
    {
        public void EkranaYazdir(string veri)
        {
            Console.WriteLine(veri);
        }
    }
}