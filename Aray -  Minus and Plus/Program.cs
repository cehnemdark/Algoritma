using System;

class Program
{
    static void Main(string[] args)
    {
        int[] sayilar = new int[10];
        int eksiIndex = 0, artiIndex = 0;

        for (int i = 0; i < sayilar.Length; i++)
        {
            Console.Write("Lütfen " + (i + 1) + ". sayıyı giriniz: ");
            sayilar[i] = Convert.ToInt32(Console.ReadLine());

            if (sayilar[i] < 0)
            {
                eksiIndex++;
            }
            else
            {
                artiIndex++;
            }
        }

        int[] eksiSayilar = new int[eksiIndex];
        int[] artiSayilar = new int[artiIndex];

        eksiIndex = 0;
        artiIndex = 0;

        for (int i = 0; i < sayilar.Length; i++)
        {
            if (sayilar[i] < 0)
            {
                eksiSayilar[eksiIndex] = sayilar[i];
                eksiIndex++;
            }
            else
            {
                artiSayilar[artiIndex] = sayilar[i];
                artiIndex++;
            }
        }

        Console.WriteLine("\nEksi Sayılar:");
        for (int i = 0; i < eksiSayilar.Length; i++)
        {
            Console.WriteLine(eksiSayilar[i]);
        }

        Console.WriteLine("\nArtı Sayılar:");
        for (int i = 0; i < artiSayilar.Length; i++)
        {
            Console.WriteLine(artiSayilar[i]);
        }

        Console.ReadKey();
    }
}