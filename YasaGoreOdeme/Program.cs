int yas1;
int yas2;
int yas3;

Console.WriteLine("Lütfen ilk müşterinin yaşını giriniz");
yas1 = Convert.ToInt32(Console.ReadLine());


if (yas1 < 6)
{
    yas1 = 0;
}
else if (6 <= yas1 && yas1 <= 12)
{
    yas1 = 60;
}
else
{
    yas1 = 120;

}

Console.WriteLine("Lütfen 2'nci müşterinin yaşını giriniz");
yas2 = Convert.ToInt32(Console.ReadLine());

if (yas2 < 6)
{
    yas2 = 0;
}
else if (6 <= yas2 && yas2 <= 12)
{
    yas2 = 60;
}
else
{
    yas2 = 120;

}

Console.WriteLine("Lütfen 3'üncü müşterinin yaşını giriniz");
yas3 = Convert.ToInt32(Console.ReadLine());

if (yas3 < 6)
{
    yas3 = 0;
}
else if (6 <= yas3 && yas3 <= 12)
{
    yas3 = 60;
}
else
{
    yas3 = 120;

}

int toplamucret = yas1 + yas2 + yas3;
Console.WriteLine(toplamucret+"TL");