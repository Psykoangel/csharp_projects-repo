using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace testCs03FW
{
    class Program
    {
        static void Main( string[] args )
        {
            Console.WriteLine(DateTime.Now);
            Console.WriteLine(Environment.UserName);
            Console.WriteLine(DateTime.Now.DayOfYear);
        }
    }
}
