int[,] array4 = { { 25, 33, 12 }, { 87, 66, 63 }, { 45, 90, 34 }, { 22, 46, 14 } };
int maxNumber = array4[0, 0];
for (int i = 0; i < array4.GetLength(0); i++)
{
    for (int j = 0; j < array4.GetLength(1); j++)
    {
        if (array4[i, j] > maxNumber)
        {
            maxNumber = array4[i, j];
        }
    }
}
Console.WriteLine("En büyük sayı: " + maxNumber);


//int[,] array4 = { { 25, 33, 12 }, { 87, 66, 63 }, { 45, 90, 34 }, { 22, 46, 14 } };
//int maxNumber = array4.Cast<int>().Max();
//Console.WriteLine("En büyük sayı: " + maxNumber);