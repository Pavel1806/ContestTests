using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ContestTests
{
    
    class SeventhTask
    {
        static string[] RemovesDuplicates(string[] setModule, List<string>[] finish)
        {
            string[] array = setModule;

            if (finish[0] != null)
            {
                var l = finish.Where(x => x != null).SelectMany(x => x);

                array = setModule.Except(l).ToArray();
            }

            return array;
        }
        public static void Method()
        {
            var testCaseCount = byte.Parse(Console.ReadLine());

            Console.WriteLine();

            for (var n = 0; n < testCaseCount; n++)
            {
                var numberSetsModules = byte.Parse(Console.ReadLine());

                string[][] setsModules = new string[numberSetsModules][];

                for (var j = 0; j < numberSetsModules; j++)
                {
                    var rowsColumns = Console.ReadLine().Split(' ').Select(x => x).ToArray();

                    for (int c = 0; c < rowsColumns.Length; c++)
                    {
                        var t = rowsColumns[c].TrimEnd(':');
                        rowsColumns[c] = t;
                    }
                    setsModules[j] = rowsColumns;
                }

                var numberModules = byte.Parse(Console.ReadLine());

                string[] modules = new string[numberModules];

                for (var j = 0; j < numberModules; j++)
                {
                    modules[j] = Console.ReadLine();
                }

                List<string>[] finish = new List<string>[modules.Length];

                List<string> help = new List<string>();

                for (int k = 0; k < modules.Length; k++)
                {
                    help.Add(modules[k]);

                    string[] helpNoDuplicates = RemovesDuplicates(help.ToArray(), finish);

                    help = helpNoDuplicates.ToList();

                    for (int f = 0; f < help.Count; f++)
                    {
                        for (int u = 0; u < setsModules.Length; u++)
                        {
                            if (setsModules[u] != null)
                            {
                                if (help[f] == setsModules[u][0])
                                {
                                    if (finish[0] != null)
                                    {
                                        string[] vs = RemovesDuplicates(setsModules[u], finish);

                                        var list = help.Union(vs).ToList();

                                        help = list;

                                        setsModules[u] = null;
                                    }
                                    else
                                    {
                                        var y = help.Union(setsModules[u]).ToList();
                                        setsModules[u] = null;
                                        help = y;
                                    }
                                }
                            }
                        }
                    }

                    finish[k] = new List<string>();

                    var data = finish[k].Union(help).ToList();

                    finish[k] = data;

                    help.Clear();
                }

                for (int v = 0; v < finish.Length; v++)
                {
                    Console.Write($"{finish[v].Count()} ");

                    finish[v].Reverse();

                    foreach (var item in finish[v])
                    {
                        Console.Write($"{item} ");
                    }
                    Console.WriteLine();
                }

                Console.WriteLine();
            }
        }
    }
}
