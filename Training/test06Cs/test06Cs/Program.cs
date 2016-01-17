using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace test06Cs
{
    class Program
    {
        static void Main( string[] args )
        {
            int a = 10, b = 15;
            Console.WriteLine(int.ReferenceEquals(a, b));
            Console.Beep(30000, a);
        }
    }
}
