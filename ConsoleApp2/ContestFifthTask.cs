using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ContestTests
{
    class ContestFifthTask
    {
        public static void Method()
        {
            var testCaseCount = int.Parse(Console.ReadLine());

            for (var i = 0; i < testCaseCount; i++)
            {
                var numberTasks = int.Parse(Console.ReadLine());

                var report = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToList();

                bool flag = true;

                for (int n = 0; n < report.Count - 1; n++)
                {
                    if (report[n] != report[n + 1])
                    {
                        var y = report.Select((value, position) => new { position, value }).Where(x => x.position > n).Any(y => y.value == report[n]);

                        if (y)
                        {
                            Console.WriteLine("NO");
                            flag = false;
                            break;
                        }
                    }
                    else if (report[n] == report[n + 1])
                    {
                        continue;
                    }
                }
                if (flag)
                    Console.WriteLine("YES");
            }
        }
    }
}
