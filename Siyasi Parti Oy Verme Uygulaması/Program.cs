using System;

class Program
{
    static void Main(string[] args)
    {
        int toplamOySayisi = 3000;
        string[] partiler = { "AK Parti", "CHP", "HDP", "MHP", "İYİ Parti", "Türkiye İşçi Partisi", "DP", "Memleket Partisi",
            "BBP", "DEVA" };
        int[] oySayilari = new int[partiler.Length];
        for (int i = 0; i < partiler.Length; i++)
        {
            int oy = 0;
            bool gecerliOySayisi = false;
            while (!gecerliOySayisi)
            {
                Console.Write($"{partiler[i]} için oy sayısı: ");
                 oy = Convert.ToInt32(Console.ReadLine());
                if (oy < 0)
                {
                    Console.WriteLine("Negatif oy sayısı girilemez!");
                }
                else if (oy > toplamOySayisi)
                {
                    Console.WriteLine("Toplam oy sayısından fazla oy girilemez!");
                }
                else
                {
                    gecerliOySayisi = true;
                }
            }
            oySayilari[i] = oy;
            toplamOySayisi -= oySayilari[i];
            Console.WriteLine($"Kalan oy sayısı: {toplamOySayisi}");
            if (toplamOySayisi == 0)
            {
                Console.WriteLine("Mevcut oy sayısı 0 olduğu için program sonlandırıldı.");
                Console.WriteLine($"1. parti: {partiler[i]}");
                Console.ReadLine();
                return;
            }
        }

        for (int i = 0; i < partiler.Length; i++)
        {
            double oyYuzdesi = (double)oySayilari[i] / (double)(toplamOySayisi + oySayilari[i]) * 100;
            Console.WriteLine($"{partiler[i]} oy oranı: %{oyYuzdesi.ToString("0.##")}");
        }

        int birinciPartiIndex = 0;
        for (int i = 1; i < oySayilari.Length; i++)

        {
            if (oySayilari[i] > oySayilari[birinciPartiIndex])
            {
                birinciPartiIndex = i;
            }
        }

        Console.WriteLine($"1. parti: {partiler[birinciPartiIndex]}");

        Console.ReadLine();
    }
}
