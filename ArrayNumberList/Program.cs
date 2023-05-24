//int[] list = {7,3,12,1,23,4,9,34,2,6 };

//foreach (int i in list)
//{
//    Console.Write("{0} < ",i);
//}

//Array.Sort(numbers);
//string sortedNumbers = string.Join(" < ", numbers);

class Program
{
    static void Main(string[] args)
    {
        bool repeat = true;

        while (repeat)
        {
            int[] sayilar = new int[10];
            Console.WriteLine("Lütfen 10 sayı giriniz:");

            for (int i = 0; i < 10; i++)
            {
                Console.Write("Sayı {0}: ", i + 1);
                string input = Console.ReadLine();

                // Girilen değerin sayı olup olmadığını kontrol et
                bool isNumeric = int.TryParse(input, out int sayi);

                while (!isNumeric)
                {
                    Console.WriteLine("Lütfen geçerli bir sayı giriniz:");
                    input = Console.ReadLine();
                    isNumeric = int.TryParse(input, out sayi);
                }

                sayilar[i] = sayi;
            }


            for (int i = 0; i < sayilar.Length - 1; i++)
            {
                for (int j = 0; j < sayilar.Length - i - 1; j++)
                {
                    if (sayilar[j] > sayilar[j + 1])
                    {
                        int geciciDeger = sayilar[j];
                        sayilar[j] = sayilar[j + 1];
                        sayilar[j + 1] = geciciDeger;
                    }
                }
            }

            int toplam = 0;
            int enBuyuk = sayilar[0];
            int enKucuk = sayilar[0];

            for (int i = 0; i < sayilar.Length; i++)
            {
                toplam += sayilar[i];

                if (sayilar[i] > enBuyuk)
                {
                    enBuyuk = sayilar[i];
                }

                if (sayilar[i] < enKucuk)
                {
                    enKucuk = sayilar[i];
                }
            }

            double ortalama = (double)toplam / sayilar.Length;

            Console.WriteLine("-----------------------------------------------------------------");
            Console.WriteLine("Toplam: {0}", toplam);
            Console.WriteLine("-----------------------------------------------------------------");

            Console.WriteLine("En büyük sayı: {0}", enBuyuk);
            Console.WriteLine("-----------------------------------------------------------------");

            Console.WriteLine("En küçük sayı: {0}", enKucuk);
            Console.WriteLine("-----------------------------------------------------------------");

            Console.WriteLine("Ortalama: {0}", ortalama);
            Console.WriteLine("-----------------------------------------------------------------");

            string siralanmisSayilar = string.Join(" < ", sayilar);
            Console.WriteLine("Sıralanmış Sayılar: {0}", siralanmisSayilar);
            Console.WriteLine("-----------------------------------------------------------------");

            Console.WriteLine("\nTekrar işlem yapmak istiyor musunuz? (E/H)");
            string cevap = Console.ReadLine().ToLower();

            if (cevap == "e")
            {
                repeat = true;
            }
            else
            {
                repeat = false;
            }

            int[] numbers = {3,5,-2,-9,2,-7 };

        }
    }
}