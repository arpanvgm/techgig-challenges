using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindTwoItems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var tests = int.Parse(Console.ReadLine());
            for (var t = 0; t < tests; t++)
            {
                var givenAmount = int.Parse(Console.ReadLine());
                var items = int.Parse(Console.ReadLine());
                var sep = new char[] { ' ' };
                var prices = Console.ReadLine().Split(sep).Select(c => int.Parse(c)).ToArray();
                int item1 = -1, item2 = -1;
                for (var i = 0; i < items; i++)
                {
                    for (var j = i + 1; j < items; j++)
                    {
                        if (prices[i] + prices[j] <= givenAmount)
                        {
                            if (item1 == -1)
                            {
                                item1 = i; item2 = j;
                                continue;
                            }
                            if (prices[i] + prices[j] > prices[item1] + prices[item2])
                            {
                                item1 = i; item2 = j;
                            }
                        }
                    }
                }
                Console.WriteLine("{0} {1}", item1 + 1, item2 + 1);
            } // close tests loop

            Console.ReadKey();
        }// close main
    }
}
