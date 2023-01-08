using System;

namespace metotOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            //out parametreler
            string sayi = "999";
          bool sonuc = int.TryParse(sayi,out int outSayi);
          if ( sonuc)
          {
            Console.WriteLine("basarili");
            Console.WriteLine(outSayi);
          }
          else{
            Console.WriteLine("Basarisiz");
          }

          Metotlar instance = new Metotlar();
          instance.Topla(2,3, out int toplamsonuc);
          Console.WriteLine(toplamsonuc);


          // Metot Overloading
            int ifade = 959;
            instance.EkranaYazdir(Convert.ToString(ifade));
            instance.EkranaYazdir(ifade);
            instance.EkranaYazdir("Gökhan","Çüryan");

        }
    }

    class Metotlar
    {
        public void Topla(int a, int b, out int toplam)
        {
            toplam = a+b;
        }

        public void EkranaYazdir(string veri)
        {
            Console.WriteLine(veri);
        }
        public void EkranaYazdir(int veri)
        {
            Console.WriteLine(veri);
        }
        public void EkranaYazdir(string veri1, string veri2)
        {
            Console.WriteLine(veri1 + veri2);
        }
    }
}