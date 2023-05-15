Console.ForegroundColor = ConsoleColor.Magenta;

// DateTime
Console.WriteLine(DateTime.Now);
Console.WriteLine(DateTime.Now.Date);
Console.WriteLine(DateTime.Now.Day);
Console.WriteLine(DateTime.Now.Month);
Console.WriteLine(DateTime.Now.Year);
Console.WriteLine(DateTime.Now.Hour);
Console.WriteLine(DateTime.Now.Minute);
Console.WriteLine(DateTime.Now.Second);

Console.WriteLine(DateTime.Now.DayOfWeek);
Console.WriteLine(DateTime.Now.DayOfYear);

// Better for UI
Console.WriteLine(DateTime.Now.ToLongDateString());
Console.WriteLine(DateTime.Now.ToShortDateString());
Console.WriteLine(DateTime.Now.ToLongTimeString());
Console.WriteLine(DateTime.Now.ToShortTimeString());

Console.WriteLine(DateTime.Now.AddDays(2));
Console.WriteLine(DateTime.Now.AddHours(5));
Console.WriteLine(DateTime.Now.AddSeconds(30));
Console.WriteLine(DateTime.Now.AddMinutes(20));
Console.WriteLine(DateTime.Now.AddMonths(2));
Console.WriteLine(DateTime.Now.AddYears(2));
Console.WriteLine(DateTime.Now.AddMilliseconds(1000));

// DateTime Formatting
Console.WriteLine(DateTime.Now.ToString("dd")); // 16
Console.WriteLine(DateTime.Now.ToString("ddd")); //Tue
Console.WriteLine(DateTime.Now.ToString("dddd")); //Saturday

Console.WriteLine(DateTime.Now.ToString("MM")); // 05
Console.WriteLine(DateTime.Now.ToString("MMM")); // May (short)
Console.WriteLine(DateTime.Now.ToString("MMMM")); // May (long)

Console.WriteLine(DateTime.Now.ToString("yy")); // 23
Console.WriteLine(DateTime.Now.ToString("yyyy")); // 2023

// Math Library
Console.WriteLine(Math.Abs(-20)); // returns absolute
Console.WriteLine(Math.Sin(10));
Console.WriteLine(Math.Cos(10));
Console.WriteLine(Math.Tan(10));

Console.WriteLine(Math.Ceiling(22.3)); // returns 23
Console.WriteLine(Math.Floor(22.7)); // returns 22
Console.WriteLine(Math.Round(22.3)); // returns whichever integer is closer
Console.WriteLine(Math.Round(22.7));

Console.WriteLine(Math.Min(2, 7));
Console.WriteLine(Math.Max(2, 7));

Console.WriteLine(Math.Pow(3, 2)); // returns 3^2
Console.WriteLine(Math.Sqrt(9)); // returns square root
Console.WriteLine(Math.Log(9));  // returns Log(9)
Console.WriteLine(Math.Exp(3)); // returns e^3
Console.WriteLine(Math.Log10(10)); // returns Log10(10)
