
// == != && || =  >= <=

using System;
using System.Collections.Specialized;
using System.Reflection.Metadata;

//int number;

//Console.WriteLine("Lütfen bir sayı tanımlayınız");

//number = Convert.ToInt32(Console.ReadLine());


//if (number >= 0 && number < 100 && number == 100)
//{
//    if (number > 95)
//    {
//        Console.WriteLine("Tanımlı sayı {0} dir, 95 ten büyüktür", number);
//    }
//    else
//    {
//        Console.WriteLine("Tanımlı sayı {0} dir, 0 ve 100 arasındadır.", number);
//    }

//}
//else if (number > 100 && number <= 250)
//{
//    Console.WriteLine("Tanımlı sayı {0} dir, 101 ve 250  arasında değildir.", number);
//}
//else
//{
//    Console.WriteLine("Tanımlı sayı {0} dir, 0 ve 250 arasındadır değildir.", number);
//}


//int number;

//Console.WriteLine("Lütfen bir sayı tanımlayınız");

//number = Convert.ToInt32(Console.ReadLine());


//switch (number)
//{   
//    case 1:
//    Console.WriteLine("sayınız {0}",number); 
//    break;

//    case 2:
//        Console.WriteLine("sayınız {0}", number);
//        break;

//    default:
//    Console.WriteLine("sayınız bir değildi: {0}", number);
//    break;
//}





//int number1;
//int number2;
//Console.WriteLine("Lütfen iki sayı giriniz");
//number1 = Convert.ToInt32(Console.ReadLine());
//number2 = Convert.ToInt32(Console.ReadLine());

//if (number1 > number2)
//{
//    Console.WriteLine("{0} > {1}",number1,number2);
//}else if (number2 > number1)
//{
//    Console.WriteLine("{0} > {1}", number2, number1);
//}
//else 
//{
//    Console.WriteLine("{0} = {1}", number2, number1);
//}

//int number1; //a
//int number2; //b
//int number3; //c
//Console.WriteLine("Lütfen 3 sayı giriniz");
//number1 = Convert.ToInt32(Console.ReadLine());
//number2 = Convert.ToInt32(Console.ReadLine());
//number3 = Convert.ToInt32(Console.ReadLine());



//if (number1 > number2 && number1 > number3) // a>b ve a>c
//{
//    //if (number2 > number3)//b>c
//    //{
//    //    Console.WriteLine("{0} > {1} > {2}", number1, number2, number3);
//    //}
//    //else if(number3> number2) //c>b
//    //{ 
//    //    Console.WriteLine("{0} > {1} > {2}", number1, number3, number2); 
//    //}else
//    //{//b=c
//    //    Console.WriteLine("{0} > {1} = {2}", number1, number3, number2);
//    //}


//--------------------------------------------------------------------------------------------
//int a;
//int b;
//int c;
//Console.WriteLine("Lütfen iki sayı giriniz");
//a = Convert.ToInt32(Console.ReadLine());
//b = Convert.ToInt32(Console.ReadLine());
//c = Convert.ToInt32(Console.ReadLine());

//if (a > b && a > c)
//{
//    if (b > c)
//    {
//        Console.WriteLine("{0} > {1} > {2}", a, b, c);
//    } else if (c > b)
//    {   Console.WriteLine("{0} > {1} > {2}", a, c, b);
//    }
//    else
//    {
//        Console.WriteLine("{0} > {1} = {2}", a, c, b);
//    }
//} else if (b > c && b > a)
//{ Console.WriteLine("{0} > {1} > {2}", b, a, c);

//} else if(b<c)
//{
//    Console.WriteLine("{0} = {1} < {2}", c, a, b);

//}else{
//    Console.WriteLine("{0} = {1} > {2}", c, b, a);
//}
//if (c > a)
//{
//    Console.WriteLine("{0} > {1} = {2}", a, c, b);
//}










//}
//else if (number2 > number1 && number2 > number3) // b>a ve b>c
//{
//    if (number1 > number3) // a>c
//    {
//        Console.WriteLine("{0} > {1} > {2}", number2, number1, number3);
//    }
//    else
//    { //c>a
//        Console.WriteLine("{0} > {1} > {2}", number2, number3, number1);
//    }
//}
//else if (number3 > number1 && number3 > number2) // c>a ve c>b
//{
//    if (number1 > number2) // a>b
//    {
//        Console.WriteLine("{0} > {1} > {2}", number3, number1, number2);
//    }
//    else
//    {// b>a
//        Console.WriteLine("{0} > {1} > {2}", number3, number1, number2);
//    }
//}
//else
//{
//    Console.WriteLine("{0} = {1} = {2}", number3, number1, number2);
//}




//int number1; //a
//int number2; //b
//int number3; //c
//int number4; //d
//Console.WriteLine("Lütfen 4 sayı giriniz");
//number1 = Convert.ToInt32(Console.ReadLine());
//number2 = Convert.ToInt32(Console.ReadLine());
//number3 = Convert.ToInt32(Console.ReadLine());
//number4 = Convert.ToInt32(Console.ReadLine());

//if (number1 > number2 && number1 > number3 && number1 > number4) // a>b ve a>c ve a>d
//{
//    if (number2 > number3 && number4 > number3) // b>c ve d>c
//    {
//        Console.WriteLine("{0} > {1} > {2} > {3}", number1, number2, number3, number4);
//    }
//    else
//    {//c>b ve c>d
//        Console.WriteLine("{0} > {1} > {2} > {3}", number1, number3, number2, number4);
//    }
//}
//else if (number2 > number1 && number2 > number3 && number2 > number4) // b>a ve b>c ve b>d
//{
//    if (number1 > number3 && number1 >number4) // a>c ve a>d
//    {
//        Console.WriteLine("{0} > {1} > {2} > {3}", number2, number1, number3, number4);
//    }
//    else
//    { //c>a
//        Console.WriteLine("{0} > {1} > {2}", number2, number3, number1);
//    }
//}
//else if (number3 > number1 && number3 > number2 && number3 > number4) // c>a ve c>b ve c>d
//{
//    if (number1 > number2) // a>b
//    {
//        Console.WriteLine("{0} > {1} > {2}", number3, number1, number2);
//    }
//    else
//    {// b>a
//        Console.WriteLine("{0} > {1} > {2}", number3, number1, number2);
//    }
//}

//int number1;
//int number2;
//int number3;

//number1 = Convert.ToInt32(Console.ReadLine());
//number2 = Convert.ToInt32(Console.ReadLine());
//number3 = Convert.ToInt32(Console.ReadLine());

//if(number1 > number2 && number1 > number3)
//{
//    Console.WriteLine("Büyük sayı {0}", number1);
//}else if(number2 > number1 && number2 > number3){
//    Console.WriteLine("Büyük sayı {0}", number2);
//}else{
//    Console.WriteLine("Büyük sayı {0}", number3);
//}


//int userInput;

//Console.WriteLine("Lütfen bir sayı tanımlayınız");

//userInput = Convert.ToInt32(Console.ReadLine());


//switch (userInput % 2)
//{
//    case 0:
//        Console.WriteLine("Doğru! Girilen sayı çift bir sayıdır.");
//        break;
//    default:
//        Console.WriteLine("Yanlış! Girilen sayı tek bir sayıdır.");
//        break;
//}


//int userInput;

//Console.WriteLine("Bir sayı giriniz:");
//userInput = int.Parse(Console.ReadLine());

//switch (userInput)
//{
//    case 0:
//    case 1:
//    case 2:
//        Console.WriteLine("The number is small.");
//        break;
//    case 3:
//    case 4:
//    case 5:
//        Console.WriteLine("The number is medium.");
//        break;
//    default:
//        Console.WriteLine("The number is large.");
//        break;
//}


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