using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ContestTests
{
    class People
    {
        public string Name { get; set; }
        public List<string> phones;
        public People()
        {
            phones = new List<string>();
        }
    }
    class FifthTask
    {
       public static void Method()
        {
            var testCaseCount = int.Parse(Console.ReadLine());

            for (var i = 0; i < testCaseCount; i++)
            {
                var numberEntries = int.Parse(Console.ReadLine());

                string[] entry = new string[numberEntries];

                for (var j = 0; j < numberEntries; j++)
                {
                    entry[j] = Console.ReadLine().Replace(" ", ";");
                }

                var phoneBook = entry.Select((x) => new { Value = x.Split(new char[] { ';' }) })
                .GroupBy(x => x.Value[0]).OrderBy(x => x.Key)
                .Select(x => new People { Name = x.Key, phones = x.Select(p => p.Value[1]).Reverse().ToList() }).ToList();

                foreach (var item in phoneBook)
                {
                    if (item.phones.Distinct().Count() <= 5)
                    {
                        Console.Write($"{item.Name}: ");
                        Console.Write($"{item.phones.Distinct().Count()} ");
                        foreach (var item1 in item.phones.Distinct())
                        {
                            Console.Write($"{item1} ");
                        }
                        Console.WriteLine();
                    }
                    else if (item.phones.Distinct().Count() > 5)
                    {
                        Console.Write($"{item.Name}: ");
                        Console.Write($"5 ");
                        for (int k = 0; k < 5; k++)
                        {
                            var f = item.phones.Distinct().ToList();

                            Console.Write($"{f[k]} ");
                        }
                        Console.WriteLine();
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
