// LinkedIn Learning Course .NET Programming with C# by Joe Marini
// Example file for searching string content

string teststr = "The quick brown Fox jumps over the lazy Dog";

// TODO: Contains determines whether a string contains certain content
// Console.WriteLine($"{teststr.Contains("fox")}"); // false
// Console.WriteLine($"{teststr.Contains("fox", StringComparison.CurrentCultureIgnoreCase)}"); // true

// // TODO: StartsWith and EndsWith determine if a string starts 
// // or ends with a given test string
// Console.WriteLine($"{teststr.StartsWith("The")}"); // true
// Console.WriteLine($"{teststr.StartsWith("the", StringComparison.CurrentCultureIgnoreCase)}");
// Console.WriteLine($"{teststr.StartsWith("dog")}"); // false

// TODO: IndexOf, LastIndexOf finds the index of a substring
// Console.WriteLine($"{teststr.IndexOf("the")}"); // lowercase version at 31

// TODO: Determining empty, null, or whitespace
string str1 = null;
string str2 = "   ";
string str3 = String.Empty;

// Console.WriteLine($"{String.IsNullOrEmpty(str1)}"); // true
// Console.WriteLine($"{String.IsNullOrEmpty(str3)}"); // false
// Console.WriteLine($"{String.IsNullOrWhiteSpace(str2)}"); // true 
