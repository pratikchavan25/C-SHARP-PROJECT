using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace DEMO2.cs
{
    internal class Calculate_Percentage
    {
        static void Main(string[] args)
        {
            int sub1, sub2, sub3, sub4,total,percentage;
            Console.WriteLine("Enter the English marks =");
            sub1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Maths marks =");
            sub2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Science marks =");
            sub3 = Convert.ToInt32(Console.ReadLine());

            total = sub1 + sub2 + sub3;
            Console.WriteLine($"total {total}");
            percentage = (total / 3);
            Console.WriteLine($"percentage {percentage}");
        }
    }
}
