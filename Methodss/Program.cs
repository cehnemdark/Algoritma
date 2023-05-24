
//int Add( int number1, int number2)
//{
//    number1 = 30;
//    int result = number1 + number2;
//    return result;
//}

//int number1 = 20;
//int number2 = 100;

//var add = Add( number1, number2);


//Console.WriteLine(add);
//Console.WriteLine(number1);



//int ortalamabul(int number1, int number2, int number3)
//{
//    return (number1 + number2 + number3) / 3;
//}

//int ortalama = ortalamabul(5, 10, 15);
//Console.WriteLine("Ortalama: " + ortalama);




//int ortalama(int number1, int number2, int number3)
//    {
//        return (number1 + number2 + number3) / 3;
//    }


//    {
//        Console.Write("İlk sayıyı girin: ");
//        int number1 = Convert.ToInt32(Console.ReadLine());
//        Console.Write("İkinci sayıyı girin: ");
//        int number2 = Convert.ToInt32(Console.ReadLine());
//        Console.Write("Üçüncü sayıyı girin: ");
//        int number3 = Convert.ToInt32(Console.ReadLine());

//        Console.Write("Üç sayının ortalaması: " + ortalama(number1, number2, number3));
//    }

using Methods;
using Methodss;
using System.ComponentModel;

//Console.WriteLine(Serhat.Add(1, 5));
//Console.WriteLine(Serhat.Add(2, 5,6));
//Console.WriteLine(Serhat.Add(2));


//  Serhat.Customer metodunu farklı parametrelerle çağırmak
//  Console.WriteLine(Methodss.Serhat.Customer("Serhat")); // Sadece Personel Adı
//  Console.WriteLine(Methodss.Serhat.Customer("Serhat", "Developer")); // Personel Adı ve İş Adı
//  Console.WriteLine(Methodss.Serhat.Customer("Serhat", "Developer", "5000")); // Personel Adı, İş Adı ve Alınan Maaş

//  Serhat.Add metodunu farklı parametrelerle çağırmak
//  Console.WriteLine(Personel.Information("personName"));
//  Console.WriteLine(Methodss.Serhat.Add(2, 3)); // İki sayı toplama
//  Console.WriteLine(Methodss.Serhat.Add(4)); // Tek sayıyı döndürme
//  Console.WriteLine(Methodss.Serhat.Add(2, 3, 4)); // Üç sayıyı çarpma



        Console.WriteLine(Personel.Information("Serhat")); // Sadece Personel Adı
        Console.WriteLine(Personel.Information("Serhat", "Developer")); // Personel Adı ve İş Adı
        Console.WriteLine(Personel.Information("Serhat", "Developer", "5000")); // Personel Adı, İş Adı ve Alınan Maaş

