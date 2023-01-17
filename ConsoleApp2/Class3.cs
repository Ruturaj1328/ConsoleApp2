using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Example 
    {                                  // 153 = 
        static void Main(string[] args)
        {
            int num,r,sum=0,temp;
            Console.WriteLine("Enter number");
            num=Convert.ToInt32(Console.ReadLine());
            temp = num;
            while (num != 0)
            {
                r = num % 10;
                sum = sum * 10 + (r * r * r);//27
                num = num / 10;
            }
            Console.WriteLine(sum);
        }

    }
}
