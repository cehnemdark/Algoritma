while (true)
{
    Console.WriteLine("Kare için (1), Dikdörtgen için (2) veya 'Bitir' (0) yazın: ");
    string secim = Console.ReadLine();

    if (secim == "0")
    {
        break;
    }
    if (secim != "1" && secim != "2")
    {
        Console.WriteLine("Geçersiz seçim. Lütfen 1 veya 2 yazın.");
        continue;
    }

    Console.Write("Kenar uzunluğunu girin: ");
    int kenar1 = int.Parse(Console.ReadLine());

    if (secim == "1")
    {
        Console.WriteLine("Alan: " + Kare(kenar1));
    }
    else if (secim == "2")
    {
        Console.Write("Diğer kenarın uzunluğunu girin: ");
        int kenar2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Alan: " + Dikdortgen(kenar1, kenar2));
    }
    else
    {
        Console.WriteLine("Geçersiz seçim.");
    }
}

int Kare(int kenar)
{
    return kenar * kenar;
}

int Dikdortgen(int kenar1, int kenar2)
{
    return kenar1 * kenar2;
}
