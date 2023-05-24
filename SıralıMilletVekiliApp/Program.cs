Console.Write("AKP'nin oy oranı: ");
int aOyOrani = Convert.ToInt32(Console.ReadLine());

Console.Write("CHP'nin oy oranı: ");
int bOyOrani = Convert.ToInt32(Console.ReadLine());

Console.Write("HDP'nin oy oranı: ");
int cOyOrani = Convert.ToInt32(Console.ReadLine());

int toplamOySayisi = aOyOrani + bOyOrani + cOyOrani;

int toplamMilVekSayisi = 3;

int kazanilanMilVekSayisiA = 0;
int kazanilanMilVekSayisiB = 0;
int kazanilanMilVekSayisiC = 0;

for (int i = 1; i <= toplamMilVekSayisi; i++)
{
    if (aOyOrani / (kazanilanMilVekSayisiA + 1) >= bOyOrani / (kazanilanMilVekSayisiB + 1) &&
        aOyOrani / (kazanilanMilVekSayisiA + 1) >= cOyOrani / (kazanilanMilVekSayisiC + 1))
    {
        kazanilanMilVekSayisiA++;
    }
    else if (bOyOrani / (kazanilanMilVekSayisiB + 1) >= cOyOrani / (kazanilanMilVekSayisiC + 1))
    {
        kazanilanMilVekSayisiB++;
    }
    else
    {
        kazanilanMilVekSayisiC++;
    }
}

Console.WriteLine("AKP: " + kazanilanMilVekSayisiA + " milletvekili");
Console.WriteLine("CHP: " + kazanilanMilVekSayisiB + " milletvekili");
Console.WriteLine("HDP: " + kazanilanMilVekSayisiC + " milletvekili");
