using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLaba3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 9, -8, 9, 10, 18, 21, -22, 5, 7 };
            for(int i = 0; i < numbers.Length; i++)
            {
                numbers[i] %= 10; 
            }

            IEnumerable<int> dodatni = from n in numbers where n > 0 select n;
            IEnumerable<int> dis = dodatni.Distinct();
            foreach (var i in dis)
            {
                Console.Write(i +" ");
            }
        }
    }
}
