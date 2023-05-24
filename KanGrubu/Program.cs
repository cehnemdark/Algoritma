using System;

class Program
{
    static void Main(string[] args)
    {
        string kanGrubu;
        string devam;

        do
        {
            Console.WriteLine("Lütfen kan grubunuzu girin (A+, A-, B+, B-, AB+, AB-, 0+, 0-):");
            kanGrubu = Console.ReadLine().ToUpper(); // Kullanıcının girdiği kan grubunu büyük harflere çevirir.

            // Hangi kan gruplarına kan verebileceği kontrol edilir.
            switch (kanGrubu)
            {
                case "A+":
                    Console.WriteLine("A+ ve AB+ kan gruplarına kan verebilirsiniz.");
                    break;
                case "A-":
                    Console.WriteLine("A+, A-, AB+ ve AB- kan gruplarına kan verebilirsiniz.");
                    break;
                case "B+":
                    Console.WriteLine("B+ ve AB+ kan gruplarına kan verebilirsiniz.");
                    break;
                case "B-":
                    Console.WriteLine("B+, B-, AB+ ve AB- kan gruplarına kan verebilirsiniz.");
                    break;
                case "AB+":
                    Console.WriteLine("AB+ kan grubuna kan verebilirsiniz.");
                    break;
                case "AB-":
                    Console.WriteLine("AB+ ve AB- kan gruplarına kan verebilirsiniz.");
                    break;
                case "0+":
                    Console.WriteLine("A+, B+, AB+ ve 0+ kan gruplarına kan verebilirsiniz.");
                    break;
                case "0-":
                    Console.WriteLine("Tüm kan gruplarına kan verebilirsiniz.");
                    break;
                default:
                    Console.WriteLine("Lütfen geçerli bir kan grubu girin.");
                    break;
            }

            Console.WriteLine("Başka bir işlem yapmak istiyor musunuz? (E/H)");
            devam = Console.ReadLine();
        } while (devam == "E" || devam == "e");
    }
}
