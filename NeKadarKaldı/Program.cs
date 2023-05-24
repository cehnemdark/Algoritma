using System;

namespace GenelSeçim2023
{
    class Program
    {
        static void Main(string[] args)
        {
           
            DateTime seçimTarihi = new DateTime(2023, 5, 14);
            TimeSpan kalanSüre = seçimTarihi - DateTime.Now;
            int kalanGün = (int)kalanSüre.TotalDays;

            Console.WriteLine("2023 Genel Seçimlerine kalan gün sayısı: " + kalanGün);
        }
    }
}
