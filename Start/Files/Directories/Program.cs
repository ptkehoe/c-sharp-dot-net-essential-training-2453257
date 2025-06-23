// LinkedIn Learning Course .NET Programming with C# by Joe Marini
// Creating and Deleting Directories

const string dirname = "TestDir";

// TODO: Create a Directory if it doesn't already exist
// if (!Directory.Exists(dirname))
// {
//     Directory.CreateDirectory(dirname);
// }
// else
// {
//     Directory.Delete(dirname); // delete the directory if it exists
// }

// TODO: Get the path for the current directory
string curpath = Directory.GetCurrentDirectory();
//Console.WriteLine($"Current directory: {curpath}");

// TODO: Just like with files, you can retrieve info about a directory
// DirectoryInfo directoryInfo = new DirectoryInfo(curpath);
// Console.WriteLine($"Directory name: {directoryInfo.Name}");
// Console.WriteLine($"{directoryInfo.Parent}");
// Console.WriteLine($"{directoryInfo.CreationTime}");



// TODO: Enumerate the contents of directories
Console.WriteLine("Just directories:");
List<string> thedirs = new List<string>(Directory.EnumerateDirectories(curpath)); //code that loops through the directories
foreach(string dir in thedirs){
    Console.WriteLine(dir);
}

Console.WriteLine("---------------");

Console.WriteLine("Just files:");
thedirs = new List<string>(Directory.EnumerateFiles(curpath)); //code that loops through the files
foreach (string dir in thedirs)
{
    Console.WriteLine(dir);
}

Console.WriteLine("---------------");

Console.WriteLine("All directory contents:");
thedirs = new List<string>(Directory.EnumerateFileSystemEntries(curpath)); //code that loops through all the files and directories
foreach(string dir in thedirs){
    Console.WriteLine(dir);
}