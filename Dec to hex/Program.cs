using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dec_to_hex
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input a byte:");
            int sum = 0;
            string userAnswer = Console.ReadLine();
            int thePow = 0;
            int theNum = 0;
            int counter = 0;
            int aryCount = 0;
            int theAns = 0;


            for (counter = userAnswer.Length - 1; counter >= 0; counter--)
            {
                theNum = int.Parse(userAnswer[aryCount].ToString());
                thePow = (int)(Math.Pow(2, counter));
                theAns = thePow * theNum;
                sum += theAns;
                aryCount++;
            }
            System.Console.WriteLine(sum);

            {
               int decValue = (sum);
               string hexValue = decValue.ToString("X");
                // or string hexValue = Convert.ToString(sum , 16);


                System.Console.WriteLine(hexValue);
            }

            System.Console.ReadLine();
        }
    }
}
