using System;
using System.Collections.Generic;
using System.Text;

namespace ContestTests
{
    class EighthTask
    {
       public static void Method()
        {
            List<List<char>> battlefield = new List<List<char>>()
            {
                new List<char>(){ '.','*','.','.','*','.','.','*','*','.','*','.','*' },
                new List<char>(){ '*','*','.','.','.','.','.','*','.','.','.','.','.' },
                new List<char>(){ '.','.','.','.','.','.','.','.','.','.','*','.','*' },
                new List<char>(){ '*','*','.','.','*','*','*','.','.','*','*','.','*' },
                new List<char>(){ '.','*','.','.','*','.','.','.','.','.','.','.','*' },
                new List<char>(){ '.','.','.','.','*','.','*','.','.','*','*','*','*' },

                //new List<char>(){ '.','.','.','.','.','.','.','.','.','.','.','.','.','*','.' },
                //new List<char>(){ '.','.','*','*','*','.','.','.','.','.','.','.','.','*','*' },
                //new List<char>(){ '.','.','*','.','.','.','.','.','.','.','.','.','.','.','.' },
                //new List<char>(){ '.','.','*','.','*','.','.','.','.','.','.','.','.','.','.' },
                //new List<char>(){ '.','.','.','.','*','.','.','.','.','.','*','.','*','*','.' },
                //new List<char>(){ '.','.','*','*','*','.','.','.','.','.','*','.','*','.','.' },
                //new List<char>(){ '.','.','.','.','.','.','.','.','.','.','*','.','.','.','.' },
                //new List<char>(){ '.','*','*','.','.','.','.','.','*','.','*','*','*','*','.' },
                //new List<char>(){ '.','*','.','.','.','.','.','.','*','.','.','.','.','.','.' },
                //new List<char>(){ '.','.','.','.','.','.','*','*','*','.','.','.','.','.','.' },
                //new List<char>(){ '.','.','.','.','.','.','.','.','.','.','*','.','.','.','.' },
                //new List<char>(){ '.','.','.','.','.','*','*','*','*','.','*','.','.','.','.' },
                //new List<char>(){ '.','.','.','.','.','*','.','.','.','.','*','.','.','.','.' },
                //new List<char>(){ '.','.','.','.','.','*','.','*','*','*','*','.','.','.','.' },
                //new List<char>(){ '*','.','.','.','.','*','.','.','.','.','.','.','.','*','.' },


            };
            //'','','','','','','','','','','','','','',''

            List<int> numberShips = new List<int>();


            for (int a = 0; a < battlefield.Count; a++)
            {
                for (int f = 0; f < battlefield[a].Count; f++)
                {
                    int r = 0;
                    if (battlefield[a][f] == '*')
                    {
                        ++r;
                        if (f + 1 < battlefield[a].Count && battlefield[a + 1][f] != '*')
                        {
                            if (f + 1 < battlefield[a].Count && a + 1 < battlefield.Count)
                            {
                                if (battlefield[a][f + 1] != '*' && battlefield[a + 1][f] != '*')
                                {
                                    numberShips.Add(1);
                                    battlefield[a][f] = '.';
                                    continue;

                                }
                                if (battlefield[a][f + 1] == '*' && battlefield[a + 1][f] == '*')
                                {
                                    for (int b = f; b < 4 + f; b++)
                                    {
                                        if (b + 1 < battlefield[a].Count)
                                        {
                                            if (battlefield[a][b + 1] != '*')
                                            {
                                                if (r == 2)
                                                    numberShips.Add(3);
                                                if (r == 3)
                                                    numberShips.Add(5);
                                                if (r == 4)
                                                    numberShips.Add(7);
                                                break;
                                            }
                                            ++r;
                                        }
                                    }

                                    for (int c = 0; c < r; c++)
                                    {
                                        battlefield[a][f + c] = '.';
                                        battlefield[a + c][f] = '.';
                                    }

                                    continue;
                                }
                                if (battlefield[a][f + 1] == '*' && battlefield[a + 1][f] != '*')
                                {
                                    for (int b = f; b < 4 + f; b++)
                                    {
                                        if (b + 1 < battlefield[a].Count)
                                        {
                                            if (battlefield[a][b + 1] != '*')
                                            {
                                                if (r == 2)
                                                    numberShips.Add(3);
                                                if (r == 3)
                                                    numberShips.Add(5);
                                                if (r == 4)
                                                    numberShips.Add(7);
                                                break;
                                            }
                                            ++r;
                                        }
                                    }

                                    for (int c = 0; c < r; c++)
                                    {
                                        battlefield[a][f + c] = '.';
                                        battlefield[a + c][f + r] = '.';
                                    }

                                    continue;
                                }
                                if (battlefield[a][f + 1] != '*' && battlefield[a + 1][f] == '*')
                                {
                                    for (int b = a; b < 4 + a; b++)
                                    {
                                        if (a + 1 < battlefield.Count)
                                        {
                                            if (battlefield[b + 1][f] != '*')
                                            {
                                                if (r == 2)
                                                    numberShips.Add(3);
                                                if (r == 3)
                                                    numberShips.Add(5);
                                                if (r == 4)
                                                    numberShips.Add(7);
                                                break;
                                            }
                                            ++r;
                                        }
                                    }
                                    if (battlefield[a + r - 1][f + 1] == '*')
                                    {
                                        for (int c = 0; c < r; c++)
                                        {
                                            battlefield[a + c][f] = '.';
                                            battlefield[a + r - 1][f + c] = '.';
                                        }

                                    }
                                    if (battlefield[a + r - 1][f - 1] == '*')
                                    {
                                        for (int c = 0; c < r; c++)
                                        {
                                            battlefield[a + c][f] = '.';
                                            battlefield[a + r - 1][f - c] = '.';
                                        }

                                    }

                                    continue;
                                }
                            }

                        }
                        else
                        {
                            numberShips.Add(1);
                            battlefield[a][f] = '.';
                            continue;
                        }
                    }

                }
            }

        }
    }
}
