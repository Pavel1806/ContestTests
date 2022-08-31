using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ContestTests
{
    static class ContestSecondTask
    {
        static public void Method()
        {
            var testCaseCount = int.Parse(Console.ReadLine());

            for (var m = 0; m < testCaseCount; m++)
            {
                var numberDevelopers = int.Parse(Console.ReadLine());

                var rowsColumns = Console.ReadLine().Split(' ').Select(x => x).ToList();

                List<string> developerLevel = new List<string>();

                for (int d = 0; d < rowsColumns.Count; d++)
                {
                    developerLevel.Add($"{d + 1};{rowsColumns[d]}");
                }

                List<int> vs = new List<int>();

                List<string> teams = new List<string>();

                while (developerLevel.Count > 0)
                {

                    for (int n = 1; n < developerLevel.Count; n++)
                    {
                        var number = developerLevel[n].Split(';').Select(x => x).ToList();

                        var number1 = developerLevel[0].Split(';').Select(x => x).ToList();

                        var u = int.Parse(number1[1]);

                        var y = int.Parse(number[1]);

                        int t = Math.Abs(int.Parse(number1[1]) - int.Parse(number[1]));
                        vs.Add(t);
                    }

                    int min = vs[0];
                    int index = 0;
                    int k = 0;
                    for (k = 1; k < vs.Count; k++)

                        if (min > vs[k])
                        {
                            min = vs[k];

                            index = k;
                        }
                    var uy = developerLevel[0].Split(';').Select(x => x).ToList();
                    var ui = developerLevel[index + 1].Split(';').Select(x => x).ToList();

                    teams.Add($"{uy[0]} {ui[0]}");

                    Console.WriteLine($"{uy[0]} {ui[0]}");

                    developerLevel.RemoveAt(0);
                    developerLevel.RemoveAt(index);
                    vs.Clear();
                }
            }
        }
    }
}
