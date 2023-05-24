
int babaninYasi;
int ananinYasi;
int cocugunYasi;

Console.WriteLine("Lütfen 3 müşterinin de yaşını sırayla giriniz");
babaninYasi = Convert.ToInt32(Console.ReadLine());
ananinYasi = Convert.ToInt32(Console.ReadLine());
cocugunYasi = Convert.ToInt32(Console.ReadLine());

if (babaninYasi < 6)
{
    Console.WriteLine("Kullanıcının yaşı küçük olduğundan para tahsil edilemez");
}
else if (babaninYasi > 6)
{
    Console.WriteLine("Kullanının yaşı 6'dan büyüktür, 60 lira ödemelidir");
}
else
    Console.WriteLine("Kullanıcının yaşı 12'den büyüktür, 120 lira ödemelidir");

