// LinkedIn Learning Course .NET Programming with C# by Joe Marini
// Example file for working with Dates and Times
DateTime AprFools = new DateTime(2025, 4, 1, 13, 23, 30);

// TODO: Use DateTime.Now property to get the current date and time
DateTime now = DateTime.Now;
Console.WriteLine(now);

// TODO: DateTime.Today gets just the current date with time set to 12:00:00 AM
DateTime today = DateTime.Today;
Console.WriteLine(today);


// TODO: DateOnly and TimeOnly represent just dates and times
DateOnly dt = DateOnly.FromDateTime(DateTime.Now); //only the date part
TimeOnly tm = TimeOnly.FromDateTime(DateTime.Now); //only the time part
Console.WriteLine(dt);
Console.WriteLine(tm);

// TODO: Dates have properties that can be inspected
Console.WriteLine(today.DayOfWeek);
Console.WriteLine(today.DayOfYear);

// TODO: Dates also have methods to change their values
now = now.AddDays(5);
now = now.AddHours(9);
now = now.AddMonths(1);
Console.WriteLine(now);

// TODO: The TimeSpan class represents a duration of time
// DateTime AprilFools = new DateTime(now.Year, 4, 1);
// DateTime NewYears = new DateTime(now.Year, 1, 1);

// TODO: Dates can be compared using regular operators
