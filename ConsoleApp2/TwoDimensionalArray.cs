using System;
using System.Collections.Generic;
using System.Text;

namespace ContestTests
{
    class TwoDimensionalArray
    {
        public static int[,] Sort_String(int[,] array, int[,] sort_directive)
        {

            int array_rows = array.GetLength(0);

            int array_columns = array.Length / array_rows;

            int sort_directive_columns = sort_directive.GetLength(0);

            for (int i = 0; i < array_rows - 1; i++)
            {
                for (int j = i + 1; j < array_rows; j++)
                {
                    for (int c = 0; c < sort_directive_columns; c++)
                    {

                        if (sort_directive[c, 1] == -1 &&
                           array[i, sort_directive[c, 0]].CompareTo(array[j, sort_directive[c, 0]]) < 0)
                        {

                            for (int d = 0; d < array_columns; d++)
                            {
                                int h = array[j, d];
                                array[j, d] = array[i, d];
                                array[i, d] = h;
                            }

                            break;
                        }

                        else if (sort_directive[c, 1] == -1 &&
                                array[i, sort_directive[c, 0]].CompareTo(array[j, sort_directive[c, 0]]) > 0)
                            break;

                        else if (sort_directive[c, 1] == 1 &&
                                array[i, sort_directive[c, 0]].CompareTo(array[j, sort_directive[c, 0]]) > 0)
                        {

                            for (int d = 0; d < array_columns; d++)
                            {
                                int h = array[j, d];
                                array[j, d] = array[i, d];
                                array[i, d] = h;
                            }

                            break;
                        }

                        else if (sort_directive[c, 1] == 1 &&
                                array[i, sort_directive[c, 0]].CompareTo(array[j, sort_directive[c, 0]]) < 0)
                            break;
                    }
                }
            }

            return array;
        }
    }
}
