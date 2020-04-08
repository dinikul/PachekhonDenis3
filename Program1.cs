using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLaba3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            string set = "5 7 8 1 2 -5 2 5 6 8 7";
            var C1 = new List<int>();
            var C2 = new List<int>();
            int[] arr = set.Split(' ').Select(i => int.Parse(i.ToString())).ToArray();
            int x = 0;
            while (arr[x] != -5)
            {
                C1.Add(arr[x]);
                x++;  
            }
            while(x < arr.Length - 1)
            {
                x++;
                C2.Add(arr[x]);

            }
            C1.Sort();
            C2.Sort();
            Console.Write("C1: ");
            foreach (var n in C1)
            {
                Console.Write(n + " ");
            }
            Console.WriteLine("");
            Console.Write("C2: ");
            foreach (var n in C2)
            {
                Console.Write(n + " " );
            }
            Console.ReadLine();
        }
    }
}
