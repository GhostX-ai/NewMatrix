using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace NewMatrix
{
    class Program
    {
        static int Counter;
        static Random RanPos = new Random();
        static int FlowSpeed = 100;
        static int FastFlow = FlowSpeed + 30;
        static int TextSpeed = FastFlow + 50;

        static ConsoleColor baseColor = ConsoleColor.DarkGreen;
        static ConsoleColor greenColor = ConsoleColor.Green;
        static ConsoleColor fadedColor = ConsoleColor.White;

        static string endText = "There is a big power in MacBook Pro";

        static char AssciCharacters
        {
            get
            {
                int t = RanPos.Next();
                if (t <= 2)
                    return (char)('0' + RanPos.Next(10));
                else if (t <= 4)
                    return (char)('a' + RanPos.Next(27));
                else if (t <= 6)
                    return (char)('A' + RanPos.Next(27));
                else
                    return (char)(RanPos.Next(32, 255));
            }
        }
        static void Main()
        {
            }
        
        
    }
}
