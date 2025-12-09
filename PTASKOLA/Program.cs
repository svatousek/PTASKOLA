using PTASKOLA;
using MySystem = PTASKOLA.System;

internal class Program
{
    private static void Main(string[] args)
    {
        ISystem system = new MySystem("TestSystem", 1, 100, false);
        system.Startup();
        system.ShowInfo();
        system.Restart();
        system.Shutdown();
        system.ShowInfo();
        Add(system);

    }

    static void Add(ISystem system)
    {
        Console.WriteLine($"Představuje Vám System Name: {system.Name}, Version: {system.Version}, Number: {system.Number}");
        Console.WriteLine();
    }


    static void SystemTest(ISystem system)
    {
        if (system.Startup())
        {
            Console.WriteLine("System started successfully.");
        }
        system.Restart();
        if(system.Shutdown())
        {
            Console.WriteLine("System shut down successfully.");
        }
    }
}
