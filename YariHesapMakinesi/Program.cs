

Console.WriteLine("Lütfen yapmak istediğiniz istediğniz işlem tipini seçin:");
Console.WriteLine("--------");
Console.WriteLine("----  + - / *   ----");
string islem = (Console.ReadLine());





int sayi1;


int sayi2;

if (islem == "+")
{
    Console.WriteLine("Lütfen 1. sayıyı girin");
    sayi1 = Int32.Parse(Console.ReadLine());
    Console.WriteLine("Lütfen 2. sayıyı girin");
    sayi2 = Int32.Parse(Console.ReadLine());
    Console.WriteLine(sayi1 + sayi2);
}
else if (islem == "-")
{
    Console.WriteLine("Lütfen 1. sayıyı girin");
    sayi1 = Int32.Parse(Console.ReadLine());
    Console.WriteLine("Lütfen 2. sayıyı girin");
    sayi2 = Int32.Parse(Console.ReadLine());
    Console.WriteLine(sayi1 - sayi2);
}
else if (islem == "*")
{
    Console.WriteLine("Lütfen 1. sayıyı girin");
    sayi1 = Int32.Parse(Console.ReadLine());
    Console.WriteLine("Lütfen 2. sayıyı girin");
    sayi2 = Int32.Parse(Console.ReadLine());
    Console.WriteLine(sayi1 * sayi2);
}
else if (islem == "/")
{
    Console.WriteLine("Lütfen 1. sayıyı girin");
    sayi1 = Int32.Parse(Console.ReadLine());
    Console.WriteLine("Lütfen 2. sayıyı girin");
    sayi2 = Int32.Parse(Console.ReadLine());
    Console.WriteLine(sayi1 / sayi2);
}

else
{
    Console.WriteLine("Böyle bir işlem bulunamadı");
}
Console.ReadLine();

//----------------------------------------------------------------------


// Switch Case
//Console.WriteLine("Lütfen 1. sayıyı girin");
//int sayi1 = Int32.Parse(Console.ReadLine());

//Console.WriteLine("Lütfen 2. sayıyı girin");
//int sayi2 = Int32.Parse(Console.ReadLine());

//Console.WriteLine("Lütfen işlem türünü girin");
//Console.WriteLine("+ - * / ");
//string islem = (Console.ReadLine());

//switch (islem)
//{
//    case "+": Console.WriteLine(sayi1 + sayi2); break;
//    case "-": Console.WriteLine(sayi1 - sayi2); break;
//    case "*": Console.WriteLine(sayi1 * sayi2); break;
//    case "/": Console.WriteLine(sayi1 / sayi2); break;

//    default: Console.WriteLine("Böyle bir işlem bulunamadı"); break;
//}

//Console.ReadLine();
