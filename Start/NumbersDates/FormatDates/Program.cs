// LinkedIn Learning Course .NET Programming with C# by Joe Marini
// Example file for formatting date information

// Define a date
DateTime AprFools = new DateTime(2025, 4, 1, 13, 23, 30);

// TODO: 'd' Short date: mm/dd/yyyy (or dd/mm depending on locale)
DateTime now = DateTime.Now;
Console.WriteLine(now);

// TODO: 'D' Full date: mm/dd/yyyy (or dd/mm depending on locale)
DateTime today = DateTime.Today;
Console.WriteLine(today);

// TODO: 'f' Full date, short time
DateOnly dt = DateOnly.FromDateTime(DateTime.Now); //only the date part
TimeOnly tm = TimeOnly.FromDateTime(DateTime.Now); //only the time part
Console.WriteLine(dt);
Console.WriteLine(tm);

// TODO: 'F' Full date, long time
Console.WriteLine(today.DayOfWeek);
Console.WriteLine(today.DayOfYear);

// TODO: 'g' General date and time
now = now.AddDays(5);
now = now.AddHours(9);
now = now.AddMonths(1);
Console.WriteLine(now);

// TODO: 'G' General date and time


// TODO: Format using a specific CultureInfo


// TODO: Defining custom date and time formats
