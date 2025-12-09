using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTASKOLA
{
    internal interface ISystem
    {
        string Name { get; }
        int Version { get; }
        int Number { get; }

        bool Startup();
        bool Restart();
        bool Shutdown();
        bool ShowInfo();
    }
}
