using System;

namespace HızVeZamanHesaplama
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Atış hızını giriniz (m/s): ");
            double hiz = Convert.ToDouble(Console.ReadLine());

            string sonuc = YukseklıkVeZaman.HesaplaAt(hiz);

            Console.WriteLine(sonuc);
            Console.ReadLine();
        }
    }
}