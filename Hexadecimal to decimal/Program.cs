using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hexadecimal_to_decimal
{
    class Program
    {
        static void Main(string[] args)
        {
            string hex = "2E6";

            int dec = Convert.ToInt32(hex, 16);
           
            System.Console.WriteLine(dec);

            System.Console.ReadLine();
        }
          
            
       
          
    }

}
