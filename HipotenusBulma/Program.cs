



//Console.Write("Bir sayı girin: ");
//int number1 = Convert.ToInt32(Console.ReadLine());
//Console.Write("Bir sayı daha girin: ");
//int number2 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Karelerin toplamının karekökü: " + Math.Sqrt(number1 * number1 + number2 * number2));



Console.Write("Bir sayı girin: ");
string input1 = Console.ReadLine();
int number1;
while (!int.TryParse(input1, out number1))
{
    Console.WriteLine("Girdiğiniz değer sayı değil. Lütfen yeni bir sayı girin.");
    input1 = Console.ReadLine();
}

Console.Write("Bir sayı daha girin: ");
string input2 = Console.ReadLine();
int number2;
while (!int.TryParse(input2, out number2))
{
    Console.WriteLine("Girdiğiniz değer sayı değil. Lütfen yeni bir sayı girin.");
    input2 = Console.ReadLine();
}

KarelerininToplamiNinKarekokunuYazdir(number1, number2);

void KarelerininToplamiNinKarekokunuYazdir(int number1, int number2)
{
    int number1Karesi = number1 * number1;
    int number2Karesi = number2 * number2;
    double karekök = Math.Sqrt(number1Karesi + number2Karesi);
    if (Math.Floor(karekök) != karekök)
    {
        Console.WriteLine("Sonuç tam sayı değil. Lütfen yeni bir sayı girin.");
        Console.Write("Bir sayı girin: ");
        number1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Bir sayı daha girin: ");
        number2 = Convert.ToInt32(Console.ReadLine());
        KarelerininToplamiNinKarekokunuYazdir(number1, number2);
    }
    else
    {
        Console.WriteLine("Karelerin toplamının karekökü: " + karekök);
    }
}
