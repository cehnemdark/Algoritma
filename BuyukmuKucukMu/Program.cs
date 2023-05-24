//int num1, num2;
//Console.WriteLine("Lütfen ilk sayıyı girin:");
//num1 = int.Parse(Console.ReadLine());
//Console.WriteLine("Lütfen ikinci sayıyı girin:");
//num2 = int.Parse(Console.ReadLine());

//if (num1 > num2)
//{
//    Console.WriteLine("İlk sayı büyüktür");
//}
//else if (num1 < num2)
//{
//    Console.WriteLine("İkinci sayı büyüktür");
//}
//else
//{
//    Console.WriteLine("İki sayı eşittir");
//}


Console.WriteLine("Lütfen 3 sayı girin:");

int max = 0;
int min = 0;

for (int i = 0; i < 3; i++)
{
    int sayi = Convert.ToInt32(Console.ReadLine());

    if (i == 0) // ilk sayıyı varsayılan maksimum ve minimum olarak ata
    {
        max = sayi;
        min = sayi;
    }
    else
    {
        if (sayi > max) // sayı, mevcut en büyük sayıdan büyükse
        {
            max = sayi; // en büyük sayıyı güncelle
        }

        if (sayi < min) // sayı, mevcut en küçük sayıdan küçükse
        {
            min = sayi; // en küçük sayıyı güncelle
        }
    }
}

if (max == min) // tüm sayılar aynıysa
{
    Console.WriteLine("Girilen sayılar eşittir.");
}
else // farklı sayılar varsa
{
    Console.WriteLine("En büyük sayı: " + max);
    Console.WriteLine("En küçük sayı: " + min);
}