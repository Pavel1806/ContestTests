using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ContestTests
{
    static class SecondTask
    {
      public static void Method()
        {
            var testCaseCount = int.Parse(Console.ReadLine());

            for (var i = 0; i < testCaseCount; i++)
            {
                var numberPieces = int.Parse(Console.ReadLine());
                var collection = Console.ReadLine().Split(' ').Select(it => int.Parse(it)).ToList();

                var t = collection
                    .GroupBy(x => x, (int k, IEnumerable<int> e) => (k, e.Count())).ToList();

                var s = collection
                    .GroupBy(x => x, (int k, IEnumerable<int> e) => (k, e.Count()))
                    .Select(x => x.k * (x.Item2 - x.Item2 / 3)).ToList();

                int sum = collection
                    .GroupBy(x => x, (int k, IEnumerable<int> e) => (k, e.Count()))
                    .Select(x => x.k * (x.Item2 - x.Item2 / 3))
                    .Sum();

                Console.WriteLine(sum);
            }   
        }
    }
}
