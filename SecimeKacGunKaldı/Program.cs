DateTime date1 = DateTime.Now;
DateTime date2 = new DateTime(2023, 5, 14);

if (date2 < date1)
{
    date2 = date2.AddYears(1);
}

TimeSpan remainingTime = date2 - date1;

Console.WriteLine(remainingTime.TotalDays);
//Console.WriteLine("Kalan gün: " + remainingTime.Days);
//Console.WriteLine("Kalan saat: " + remainingTime.Hours);
//Console.WriteLine("Kalan dakika: " + remainingTime.Minutes);
//Console.WriteLine("Kalan saniye: " + remainingTime.Seconds);
//Console.WriteLine("Kalan salise: " + remainingTime.Milliseconds);