class Matematik
{
    public int Topla(int a, int b)
    {
        return a + b;
    }

    public int Topla(int a, int b, int c)
    {
        return a + b + c;
    }
}

class Program
{
    static void Main()
    {
        Matematik mat = new Matematik();

        Console.WriteLine(mat.Topla(2, 3));
        Console.WriteLine(mat.Topla(2, 3, 4));

        Console.ReadLine();
    }
}
