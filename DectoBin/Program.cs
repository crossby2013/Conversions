using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DectoBin
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = "148";
            int decimalNum = int.Parse(line);
            //int remainder;
            //string num = "";
       
          // while(decimalNum > 0)
           // {
               // remainder = decimalNum % 2;
               // decimalNum /= 2;
            Console.WriteLine(Convert.ToString(decimalNum, 2));

           // }
           
            Console.ReadLine();
           
        }
                
            
             
     }
    
      
}
