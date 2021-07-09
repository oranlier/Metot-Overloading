using System;

namespace Metot_Overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            //out parametreler
            string sayi = "999";
            int OutSayi;

            bool sonuc = int.TryParse(sayi, out OutSayi);

            if (sonuc)
            {
                Console.WriteLine("Başarılı!");
                Console.WriteLine(OutSayi);
            }
            else{
                Console.WriteLine("Başarısız!");
            }

            Metotlar instance =new Metotlar();
            instance.Topla(4,5, out int toplamSonucu);
            Console.WriteLine(toplamSonucu);

            //METOT AŞIRI YÜKLEME
            int ifade = 999;
            instance.EkranaYazdir(Convert.ToString(ifade));
            instance.EkranaYazdir(999);
            instance.EkranaYazdir("999", "888");
        }
    }

    class Metotlar
    {
        public void Topla(int a, int b, out int Toplam)
        {
            Toplam=a+b;
        }

        public void EkranaYazdir(string Veri)
        {
            Console.WriteLine(Veri);
        }

        public void EkranaYazdir(int Veri)
        {
            Console.WriteLine(Veri);
        }

        public void EkranaYazdir(string Veri1, string veri2)
        {
            Console.WriteLine(Veri1+veri2);
        }
    }
}
