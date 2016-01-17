using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public class Inversion
    {

        public string Inverser( char[] msgAinverser )
        {
            string msg = "";

            for (int i = 0; i < msgAinverser.Length; i++)
            {
                    int a = Convert.ToInt32(msgAinverser[i]);
                    msgAinverser[i] = Convert.ToChar(a + 1);
                    msg += msgAinverser[i];
            }
            
            return msg ;
        }

        //private string messageRetour;
    }
}
