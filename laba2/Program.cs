using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Rabota2
{
    class Program
    {
       
        static void Main(string[] args)
        {
            try
            {
                Double a, b, c, d;
                Console.WriteLine("Введите a");
                a = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите b");
                b = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите c ");
                c = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите d");
                d = double.Parse(Console.ReadLine());
                Double P = (a + b + c + d);
                Console.WriteLine("P=" + P);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}
