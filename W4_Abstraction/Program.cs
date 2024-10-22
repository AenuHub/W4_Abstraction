
using W4_Abstraction;

internal class Program
{
    private static void Main(string[] args)
    {
        ProjectManager manager = new ProjectManager();
        manager.FirstName = "John";
        manager.LastName = "Wick";
        manager.Department = "Chaos & Destruction";
        manager.PrintPosition();

        Designer dev = new Designer();
        dev.FirstName = "Steve";
        dev.LastName = "Jobs";
        dev.Department = "UI/UX";
        dev.PrintPosition();

        Console.ReadKey();
    }
}