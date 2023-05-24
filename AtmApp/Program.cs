
Console.WriteLine("Z bankasına hoş geldiniz!");
Console.WriteLine("Lütfen kartınızı takınız...");


string parola;
Console.WriteLine("Kartınıza ait parolayı giriniz:");
parola = Convert.ToString(Console.ReadLine());




int bakiye = 1000;
int paracekme;
Console.WriteLine("işlemler listesi:");
Console.WriteLine("a - Para Çekme");
Console.WriteLine("b - Bakiye Görüntüleme");
string IslemlerListesi = Console.ReadLine();
if (IslemlerListesi == "a")
{
    Console.WriteLine("Lütfen para çekme miktarını giriniz.");
    paracekme = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("-------------------------------------------");
    Console.WriteLine("Çekilen para : " + paracekme);
    bakiye = bakiye - paracekme;
    Console.WriteLine("Bakiyeniz : " + bakiye);

    Console.WriteLine("Bakiye görüntülemek için 'b' tuşuna basınız.");
    IslemlerListesi = Console.ReadLine();
    if (IslemlerListesi == "a")
    {
        Console.WriteLine("Kalan bakiye:"+ bakiye);
    }
    else
    {
        Console.WriteLine("Geçersiz işlem yapıldı");
    }
}
else if (IslemlerListesi == "b")
{
    Console.WriteLine("Kalan bakiye:" + bakiye);
}
else
{
    Console.WriteLine("Geçersiz işlem yapıldı");
}
