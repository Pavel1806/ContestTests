using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ContestTests
{
   

    class ThirdTask
    {
        public static int[,] Sort_String(int[,] array, int click)
        {
            int u = click;

            int[,] array2 = new int[array.GetLength(0), array.GetLength(1)];

            int item = 0;

            for (int i = 0; i < array2.GetLength(0); i++)
            {
                array2[i, u] = array[i, u];
            }

            for (int i = 0; i < array2.GetLength(0); i++)
            {
                for (int j = 0; j < array2.GetLength(0) - 1; j++)
                {
                    if (array2[j, u] > array2[j + 1, u])
                    {
                        item = array2[j + 1, u];
                        array2[j + 1, u] = array2[j, u];
                        array2[j, u] = item;
                    }
                }
            }

            for (int i = 0; i < array2.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(0); j++)
                {
                    if (array2[i, u] == array[j, u])
                    {
                        for (int k = 0; k < array.GetLength(1); k++)
                        {
                            array2[i, k] = array[j, k];
                            array[j, k] = -1;
                        }
                        break;
                    }
                }

            }

            return array2;
        }
       public static void Method()
        {
            var testCaseCount = int.Parse(Console.ReadLine());

            for (var i = 0; i < testCaseCount; i++)
            {
                Console.WriteLine();

                var rowsColumns = Console.ReadLine().Split(' ').Select(it => int.Parse(it)).ToList();

                int[,] array = new int[rowsColumns[0], rowsColumns[1]];

                for (int j = 0; j < rowsColumns[0]; j++)
                {
                    var rows = Console.ReadLine().Split(' ').Select(it => int.Parse(it)).ToArray();

                    for (int k = 0; k < rows.Length; k++)
                    {
                        array[j, k] = rows[k];
                    }
                }

                int numberOfClicks = 0;
                while (numberOfClicks == 0)
                {
                    numberOfClicks = int.Parse(Console.ReadLine());
                }

                var columnNumbersForClicks = Console.ReadLine().Split(' ').Select(it => int.Parse(it)).ToArray();

                for (int g = 0; g < columnNumbersForClicks.Length; g++)
                {
                    if (g == 0)
                    {
                        array = Sort_String(array, columnNumbersForClicks[g]);
                    }
                    else
                    {
                        if (columnNumbersForClicks[g] == columnNumbersForClicks[g - 1])
                            continue;

                        array = Sort_String(array, columnNumbersForClicks[g]);
                    }

                }

                for (int a = 0; a < array.GetLength(0); a++)
                {
                    for (int b = 0; b < array.GetLength(1); b++)
                    {
                        Console.Write($"{array[a, b]} ");
                    }
                    Console.WriteLine();
                }
            }
        }

    }
}
