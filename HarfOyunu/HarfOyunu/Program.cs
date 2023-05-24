using System;

string[] users = { "User 1", "User 2", "User 3", "User 4", "User 5" };
string correctLetters = "axezn";
int remainingLetters = correctLetters.Length;

foreach (string user in users)
{
    Console.WriteLine(user + ", lütfen bir harf girin:");
    string input = Console.ReadLine();

    if (correctLetters.Contains(input))
    {
        Console.WriteLine("Doğru! Geriye kalan harfler: " + --remainingLetters);
    }
    else
    {
        Console.WriteLine("Yanlış! Bu harf: " + input);
    }
}
