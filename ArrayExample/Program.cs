using System;



string tekrar = "E";

while (tekrar == "E")
{

    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("==================================");
    Console.WriteLine("| ÖĞRENCİ NOT HESAPLAMA PROGRAMI |");
    Console.WriteLine("==================================");

    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write("| Kursunuza kayıtlı öğrenci sayısını giriniz: ");
    Console.ForegroundColor = ConsoleColor.White;

    int ogrenciSayisi;
    bool sayiDegilse = int.TryParse(Console.ReadLine(), out ogrenciSayisi);

    if (!sayiDegilse || ogrenciSayisi < 1)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Lütfen geçerli bir sayı girin!");
        continue;
    }

    int[,] ogrenciNotlari = new int[ogrenciSayisi, 5];
    double[] ogrenciOrtalamalari = new double[ogrenciSayisi];

    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("|-------------------------------------------");

    for (int i = 0; i < ogrenciSayisi; i++)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("{0}. öğrenci için ders notlarını giriniz:", i + 1);

        for (int j = 0; j < 5; j++)
        {
            switch (j)
            {
                case 0:
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.Write("| Matematik: ");
                    Console.ForegroundColor = ConsoleColor.White;

                    break;
                case 1:
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.Write("| Edebiyat: ");
                    Console.ForegroundColor = ConsoleColor.White;

                    break;
                case 2:
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.Write("| Tarih: ");
                    Console.ForegroundColor = ConsoleColor.White;

                    break;
                case 3:
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.Write("| Biyoloji: ");
                    Console.ForegroundColor = ConsoleColor.White;

                    break;
                case 4:
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.Write("| Resim: ");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
            }
            string notGirisi = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(notGirisi))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Not girişi yapılmadı. Lütfen 0-100 aralığında bir not giriniz.");
                j--;
                continue;
            }

            if (!int.TryParse(notGirisi, out int not))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Lütfen geçerli bir not girin! (0-100 aralığında)");
                j--;
                continue;
            }

            if (not < 0 || not > 100)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Girilen not 0-100 aralığında olmalıdır!");
                j--;
                continue;
            }
            ogrenciNotlari[i, j] = not;
        }

        double toplam = 0;

        for (int j = 0; j < 5; j++)
        {
            toplam += ogrenciNotlari[i, j];
        }

        ogrenciOrtalamalari[i] = toplam / 5;

        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("| {0} numaralı öğrencinin not ortalaması {1} olarak hesaplandı.", i + 1, ogrenciOrtalamalari[i]);
        Console.WriteLine("-------------------------------------------------");
    }

    double enYuksekOrtalama = 0;
    int enYuksekOrtalamaIndex = 0;

    for (int i = 0; i < ogrenciSayisi; i++)
    {
        if (ogrenciOrtalamalari[i] > enYuksekOrtalama)
        {
            enYuksekOrtalama = ogrenciOrtalamalari[i];
            enYuksekOrtalamaIndex = i;
        }
    }

    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("| Ortalama notu en yüksek olan öğrenci {0} numaralı öğrencidir. |", enYuksekOrtalamaIndex + 1);
    Console.WriteLine("| Not ortalaması: {0} |", enYuksekOrtalama);
    Console.WriteLine("-------------------------------------");

    Console.ForegroundColor = ConsoleColor.Gray;
    Console.Write("İşlemi tekrarlamak istiyor musunuz? (E/H): ");
    tekrar = Console.ReadLine().ToUpper();
    Console.ReadLine();

}