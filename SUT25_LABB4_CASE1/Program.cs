using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUT25_LABB4_CASE1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 2 fel vad jag förstod: ett semikolon efter första C.W
            // och att elseif ska separeras 'else if'
            int number = 2;

            if (number >= 3) //lade till en '=' tecken som också saknades
            {
                // Console.WriteLine behöver ett ';' i endan 
                Console.WriteLine("Talet är större än tre");
            }
            // elseif ska skrivas separat = else if
            else if(number < 3)
            {
                Console.WriteLine("Talet är mindre än tre");
            }

        }
    }
}
