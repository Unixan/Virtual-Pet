using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtual_Pet
{
    internal class Common
    {
        public static void Pause(string msg)
        {
            if (msg != "") Console.WriteLine(msg + "\nTrykk en tast for å fortsette");
            else Console.WriteLine("Trykk en tast for å fortsette");
            Console.ReadLine();
        }
    }
}
