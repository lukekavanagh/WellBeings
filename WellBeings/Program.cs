using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WellBeings
{
    class Program
    {
        static void Main(string[] args)
        {
            NiceBeing newBeing = new NiceBeing();
            newBeing.RunAsync();
            Console.ReadLine();
        }
    }
}
