using System;

class MainClass
{
    public static void Main(string[] args)
    {
        int num;
        Console.WriteLine("Bir sayı girin:");
        num = int.Parse(Console.ReadLine());

        if (num % 2 == 0)
            Console.WriteLine("Sayı çifttir.");
        else
            Console.WriteLine("Sayı tektir.");
    }
}
