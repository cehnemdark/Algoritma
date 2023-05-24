using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Write("Lütfen 3 harfli bir kelime girin: ");
            string kelime = Console.ReadLine();

            if (kelime.Length != 3)
            {
                Console.WriteLine("Hatalı giriş yaptınız. Lütfen 3 harfli bir kelime girin.");
                continue;
            }

            // Kelimeyi şifrele
            string sifreliKelime = "";
            sifreliKelime += (char)((kelime[0] - 'a' + 2) % 29 + 'a');
            sifreliKelime += (char)((kelime[1] - 'a' + 2) % 29 + 'a');
            sifreliKelime += (char)((kelime[2] - 'a' + 2) % 29 + 'a');

            // Şifrelenmiş kelimeyi ekrana yazdır
            Console.WriteLine("Şifreleme değeri: " + sifreliKelime);

            string cevap = "";
            while (cevap != "e" && cevap != "h")
            {
                Console.Write("Tekrar işlem yapmak istiyor musunuz? (E/H): ");
                cevap = Console.ReadLine().ToLower();

                if (cevap != "e" && cevap != "h")
                {
                    Console.WriteLine("Lütfen doğru bir yanıt girin (E/H).");
                }
            }

            if (cevap == "h") break;
        }

        Console.WriteLine("Program sonlandı. Çıkmak için bir tuşa basın...");
        System.Threading.Thread.Sleep(1000); // 1 saniye bekle
    }
}
