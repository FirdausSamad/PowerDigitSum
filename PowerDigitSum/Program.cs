using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerDigitSum
{
    class Program
    {
        static void Main(string[] args)
        {
            //Power digit sum
            //2 power of 15 = 32768 and the sum of its digits is 3 + 2 + 7 + 6 + 8 = 26.
            //What is the sum of the digits of the number 21000?

            int digit =0, num=0,sum=0;
            digit = Convert.ToInt32(Math.Pow(2,15));
            Console.WriteLine("Power digit sum\n");
            while (digit>0)
            { 
                num = digit % 10;
                digit = digit / 10;

                sum = sum + num;
                Console.Write("{0} + ",num);
            }
            Console.Write("= {0}", sum);
            Console.ReadLine();
        }
    }
}
