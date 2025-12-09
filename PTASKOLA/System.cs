using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTASKOLA
{
    internal class System : ISystem
    {
        private string _name;
        private int _version;
        private int _number;
        private bool _isRunning;

        public System(string name, int version, int number, bool isRunning)
        {
            _name = name;
            _version = version;
            _number = number;
            _isRunning = isRunning;
        }

        public string Name => _name;
        public int Version => _version;
        public int Number => _number;


        public bool Restart()
        {
            if (_isRunning)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Restarting system ");
                for (int i = 3; i > 0; i--)
                {
                    Console.Write(". ");
                    Thread.Sleep(1000);
                }
                Console.ResetColor();
            }
            Console.WriteLine();
            return false;
        }

        public bool ShowInfo()
        {
            Console.WriteLine("System Information:");
            Console.WriteLine($"Name: {_name}");
            Console.WriteLine($"Version: {_version}");
            Console.WriteLine($"Number: {_number}");
            if (_isRunning == true)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Status: {(_isRunning ? "Running" : "Stopped")}");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Status: {(_isRunning ? "Running" : "Stopped")}");
            }
            Console.ResetColor();
            Console.WriteLine();
            return false;
        }

        public bool Shutdown()
        {
            if (_isRunning)
            {
                _isRunning = false;
                Console.WriteLine("System shut down successfully.");
            }
            Console.WriteLine();
            return false;
        }

        public bool Startup()
        {
            if (!_isRunning)
            {
                _isRunning = true;
                if (_isRunning)
                {
                    Console.WriteLine("System started successfully.");
                }
            }
            Console.WriteLine();
            return false;
        }

        public override string ToString()
        {
            return $"{_name} - Version: {_version}, Number: {_number}";
        }
    }
}
