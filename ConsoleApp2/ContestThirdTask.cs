using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ContestTests
{
    class ContestThirdTask
    {
        public static void Method()
        {
            var input = Console.ReadLine().Split(' ').Select(x => x).ToList();

            var numberUsers = int.Parse(input[0]);

            var numberRequests = int.Parse(input[1]);

            List<List<int>> usersAndMassage = new List<List<int>>();

            List<string> usersData = new List<string>();

            for (int i = 0; i < numberUsers; i++)
            {
                usersAndMassage.Add(new List<int>() { i + 1 });
            }

            for (int j = 0; j < numberRequests; j++)
            {
                var request = Console.ReadLine().Replace(' ', ';');
                usersData.Add(request);
            }

            int incomingMessages = 0;

            for (int r = 0; r < usersData.Count; r++)
            {
                var number = usersData[r].Split(';').Select(x => x).ToList();

                var numberMassage = int.Parse(number[0]);

                var numberUser = int.Parse(number[1]);

                if (numberMassage == 1)
                {
                    incomingMessages++;

                    if (numberUser != 0)
                    {
                        for (int o = 0; o < usersAndMassage.Count; o++)
                        {
                            if (usersAndMassage[o][0] == numberUser)
                            {
                                usersAndMassage[o].Add(incomingMessages);
                            }
                        }
                    }
                    else if (numberUser == 0)
                    {
                        for (int o = 0; o < usersAndMassage.Count; o++)
                        {
                            usersAndMassage[o].Add(incomingMessages);
                        }
                    }
                }
                else if (numberMassage == 2)
                {
                    bool p = false;

                    for (int o = 0; o < usersAndMassage.Count; o++)
                    {
                        if (usersAndMassage[o][0] == numberUser)
                        {
                            if (usersAndMassage[o].Count != 1)
                            {
                                Console.WriteLine(usersAndMassage[o][usersAndMassage[o].Count - 1]);
                                p = true;
                            }
                        }
                    }

                    if (!p)
                    {
                        Console.WriteLine(0);
                    }
                }
            }
        }

        void Method1()
        {
            var input = Console.ReadLine().Split(' ').Select(x => x).ToList();

            var numberUsers = int.Parse(input[0]);

            var numberRequests = int.Parse(input[1]);

            Dictionary<int, List<int>> usersAndMassage = new Dictionary<int, List<int>>();

            Queue<string> usersData = new Queue<string>();

            for (int i = 0; i < numberUsers; i++)
            {
                usersAndMassage[i + 1] = new List<int>();
            }

            for (int j = 0; j < numberRequests; j++)
            {
                var request = Console.ReadLine().Replace(' ', ';');
                usersData.Enqueue(request);
            }

            int incomingMessages = 0;

            while (usersData.Count != 0)
            {
                var number = usersData.Dequeue().Split(';').Select(x => x).ToList();

                var numberMassage = int.Parse(number[0]);

                var numberUser = int.Parse(number[1]);

                if (numberMassage == 1)
                {
                    incomingMessages++;

                    if (numberUser != 0)
                    {
                        for (int o = 1; o <= usersAndMassage.Count; o++)
                        {
                            if (o == numberUser)
                            {
                                usersAndMassage[o].Add(incomingMessages);
                            }
                        }
                    }
                    else if (numberUser == 0)
                    {
                        for (int o = 1; o <= usersAndMassage.Count; o++)
                        {
                            usersAndMassage[o].Add(incomingMessages);
                        }
                    }
                }
                else if (numberMassage == 2)
                {
                    bool p = false;

                    for (int o = 1; o <= usersAndMassage.Count; o++)
                    {
                        if (o == numberUser)
                        {
                            if (usersAndMassage[o].Count != 0)
                            {
                                Console.WriteLine(usersAndMassage[o][usersAndMassage[o].Count - 1]);
                                p = true;
                            }
                        }
                    }

                    if (!p)
                    {
                        Console.WriteLine(0);
                    }

                }
            }
            
        }
        void Method3()
        {
            List<string> usersData = new List<string>()
            {
                "1;1","1;0","2;1","2;1","2;1","1;1","1;1","1;1","2;1","1;1",/*"1;4", "2;5", "1;6", "2;4", "1;0", "1;2", "2;2", "2;1", "1;0", "2;3"*/
            };


            Dictionary<int, List<int>> usersAndMassage = new Dictionary<int, List<int>>();

            for (int i = 0; i < 6; i++)
            {
                usersAndMassage[i + 1] = new List<int>();
            }

            int incomingMessages = 0;

            for (int r = 0; r < usersData.Count; r++)
            {
                var number = usersData[r].Split(';').Select(x => x).ToList();

                var numberMassage = int.Parse(number[0]);

                var numberUser = int.Parse(number[1]);

                if (numberMassage == 1)
                {
                    incomingMessages++;

                    if (numberUser != 0)
                    {
                        for (int o = 1; o <= usersAndMassage.Count; o++)
                        {
                            if (o == numberUser)
                            {
                                usersAndMassage[o].Add(incomingMessages);
                            }
                        }
                    }
                    else if (numberUser == 0)
                    {
                        for (int o = 1; o <= usersAndMassage.Count; o++)
                        {
                            usersAndMassage[o].Add(incomingMessages);
                        }
                    }
                }
                else if (numberMassage == 2)
                {
                    bool p = false;

                    for (int o = 0; o < usersAndMassage.Count; o++)
                    {
                        if (o == numberUser)
                        {
                            if (usersAndMassage[o].Count != 0)
                            {
                                Console.WriteLine(usersAndMassage[o][usersAndMassage[o].Count - 1]);
                                p = true;
                            }
                        }
                    }

                    if (!p)
                    {
                        Console.WriteLine(0);
                    }

                }
            }
        }
    }
}
