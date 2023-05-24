using System;

class Program
{
    static void Main(string[] args)
    {
        string sifre = "argus";
        string input;
        int denemeSayisi = 0;
        bool isAuthenticated = false;

        while (!isAuthenticated)
        {
            Console.Write("Şifrenizi Girin: ");
            input = Console.ReadLine();

            if (input == sifre)
            {
                isAuthenticated = true;
                Console.WriteLine("Giriş başarılı.");
            }
            else
            {
                denemeSayisi++;

                if (denemeSayisi == 3)
                {
                    Console.WriteLine("Maksimum deneme sayısını aştınız. Devam etmek için aşağıdaki kodu girin:");
                    string kod = GenerateRandomCode(10);
                    Console.WriteLine($"Kod: {kod}");
                    Console.Write("Kodu girin: ");
                    string inputKod = Console.ReadLine();

                    if (inputKod == kod)
                    {
                        denemeSayisi = 0;
                        Console.WriteLine("Kod kabul edildi. Lütfen şifrenizi girerek tekrar deneyin.");
                    }
                    else
                    {
                        Console.WriteLine("Yanlış kod girdiniz. Lütfen daha sonra tekrar deneyin.");
                        return;
                    }
                }
                else
                {
                    Console.WriteLine($"Yanlış şifre. {3 - denemeSayisi} deneme hakkı kaldı.");
                }
            }
        }
    }

    static string GenerateRandomCode(int uzunluk)
    {
        const string karakterler = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
        var rastgele = new Random();
        return new string(Enumerable.Repeat(karakterler, uzunluk)
          .Select(s => s[rastgele.Next(s.Length)]).ToArray());
    }
}
