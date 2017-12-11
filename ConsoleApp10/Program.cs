using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            int sum = 0;
            int size  = 20;
            Random randomize = new Random();
            for(int i=0;i<size;i++)
            {
                list.Add(randomize.Next() % 10);
                if(i%2==0)
                {
                    sum += list[i];
                }
            }
            int max =list[0];
            foreach (var numbers in list)
            {
                if(numbers>max)
                {
                    max = numbers;
                }
                Console.Write(numbers+"   ");
            }
            Console.WriteLine("\n");
            int max2 = list[0];
            foreach(var numbers in list)
            {
                if(numbers>max2&&numbers<max)
                {
                    max2 = numbers;
                }
            }
            Console.WriteLine("max = "+max);
            Console.WriteLine("max2 = " + max2);
            Console.WriteLine("sum = " + sum);
            Console.ReadLine();
        }
    }
}
