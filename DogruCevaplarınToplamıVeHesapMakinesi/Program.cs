string cevap;

do
{
    int dogrucevapsayacı = 0;
    Console.Write("Lütfen 1 ve 9 arasında bir sayı girin: ");
    int sayi = int.Parse(Console.ReadLine());

    while (sayi <= 1 && sayi >= 9)
    {
        Console.WriteLine("Girdiğiniz sayı sadece 1 ve 9 arasında olmalıdır. Lütfen tekrar girin:");
        sayi = int.Parse(Console.ReadLine());
    }

    for (int i = 1; i <= 9; i++)
    {
        Console.Write(sayi + " x " + i + " = ");
        int kullanicinincevabi;
        bool gecerliCevap = int.TryParse(Console.ReadLine(), out kullanicinincevabi);

        while (!gecerliCevap)
        {
            Console.WriteLine("Lütfen geçerli bir cevap girin.");
            Console.Write(sayi + " x " + i + " = ");
            gecerliCevap = int.TryParse(Console.ReadLine(), out kullanicinincevabi);
        }

        if (kullanicinincevabi == sayi * i)
        {
            dogrucevapsayacı++;
        }
    }

    Console.WriteLine("9 sorudan " + dogrucevapsayacı + " tanesini doğru yanıtladınız.");

    Console.Write("İşlemi tekrar yapmak istiyor musun? (evet/e veya hayır/h): ");
    cevap = Console.ReadLine();

} while (cevap == "evet" || cevap == "e");

Console.WriteLine("İşlem sonlandırıldı.");