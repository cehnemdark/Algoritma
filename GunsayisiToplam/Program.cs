using System.Diagnostics;

int yas, gun, ucret;
Console.WriteLine("Lütfen yaşınızı giriniz:");
yas = Convert.ToInt32(Console.ReadLine());


if (yas < 6)
{
    ucret = 0;
}
else if (yas >= 6 && yas <= 12)
{
    ucret = 60;
}
else
{
    ucret = 120;
}


Console.WriteLine("Otelde kaç gün kalacaksınız?");
gun = Convert.ToInt32(Console.ReadLine());
int toplamUcret = ucret * gun;
Console.WriteLine("Ödemeniz gereken tutar: " + toplamUcret + " lira");

