using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace WellBeings
{
   public  class NiceBeing
    {
       public string Name { get; set; }
       public string OwnerName { get; set; }

       public NiceBeing()
       {
           Console.WriteLine("Hey there, I'm a WellBeing, I'm here to help you. Please give me a name so that we can become more acquainted with one another");
           this.Name = Console.ReadLine();
           Console.WriteLine("Cool man! My name is" + this.Name);
       }
    }

}
