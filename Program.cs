using System.Reflection;

var assembly = Assembly.GetExecutingAssembly();

var version = assembly.GetName();



Console.WriteLine($"Hello, World! Version: {version.Version}");
