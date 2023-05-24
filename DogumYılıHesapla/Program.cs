using System;

namespace AgeCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen doğum tarihinizi (GG/AA/YYYY şeklinde) girin:");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());
            int age = DateTime.Now.Year - birthDate.Year;

            if (DateTime.Now.Month < birthDate.Month ||
                (DateTime.Now.Month == birthDate.Month && DateTime.Now.Day < birthDate.Day))
            {
                age--;
            }

            Console.WriteLine("Yaşınız: " + age);
            Console.ReadLine();
        }
    }
}
