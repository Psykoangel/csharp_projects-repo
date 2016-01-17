using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main( string[] args )
        {
            string message = "";
            message = "salut";
            char[] charMessage = new char[message.Length];
            charMessage = message.ToCharArray();
            Console.WriteLine(message);

            Inversion newInversion = new Inversion();
            message = newInversion.Inverser(charMessage);
            Console.WriteLine(message);
            Console.WriteLine(Environment.NewLine);

            
        }
    }
}
