using System;


//Console.Write("Bir sayı girin: ");
//int sayi = int.Parse(Console.ReadLine());

//int birlerBasamagi = sayi % 10;
//int onlarBasamagi = (sayi / 10) % 10;
//int yuzlerBasamagi = (sayi / 100) % 10;
//int binlerBasamagi = (sayi / 1000) % 10;

//int toplam = 0;

//if (birlerBasamagi >= 0)
//{
//    toplam += birlerBasamagi;
//}

//if (onlarBasamagi >= 0)
//{
//    toplam += onlarBasamagi;
//}

//if (yuzlerBasamagi >= 0)
//{
//    toplam += yuzlerBasamagi;
//}

//if (binlerBasamagi >= 0)
//{
//    toplam += binlerBasamagi;
//}


//Console.WriteLine("Rakamların toplamı: " + toplam);


//Console.Write("Bir sayı girin: ");
//int sayi = int.Parse(Console.ReadLine());

//int toplam = 0;

//while (sayi > 0)
//{
//    toplam += sayi % 10;
//    sayi /= 10;
//}

//Console.WriteLine("Rakamların toplamı: " + toplam);

Console.Write("Bir sayı girin: ");
int sayi = int.Parse(Console.ReadLine());

int toplam = sayi.ToString().Sum(c => c - '0');

Console.WriteLine("Rakamların toplamı: " + toplam);