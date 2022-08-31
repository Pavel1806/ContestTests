using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ContestTests
{
    class SixthTask
    {
        class Wagon
        {
            public string Name { get; set; }
            public Coupe[] coupes { get; set; }

            public Wagon()
            {
            }
        }
        class Coupe
        {
            public int Number { get; set; }
            public bool busyFree { get; set; }

            public Place[] places { get; set; }
            public Coupe()
            {
            }
        }
        class Place
        {
            public int Number { get; set; }
            public bool busyFree { get; set; }

            public Place()
            {
            }
        }
        public static void Method()
        {
            var testCaseCount = int.Parse(Console.ReadLine());

            Console.WriteLine();

            for (var n = 0; n < testCaseCount; n++)
            {
                var coupeNumberRequests = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();

                string[] requests = new string[coupeNumberRequests[1]];

                for (var j = 0; j < coupeNumberRequests[1]; j++)
                {
                    requests[j] = Console.ReadLine().Replace(" ", ";");
                }

                Console.WriteLine();

                for (var j = 0; j < requests.Length; j++)
                {
                    if (requests[j].IndexOf(";") == -1)
                    {
                        requests[j] = "3; ";
                    }
                }

                int f = 0;

                var wagonPlace = new Wagon()
                {
                    Name = "Ракета",
                    coupes = new Coupe[Convert.ToInt32(coupeNumberRequests[0].ToString())]
                };

                for (int i = 0; i < wagonPlace.coupes.Length; i++)
                {
                    wagonPlace.coupes[i] = new Coupe { busyFree = true, places = new Place[2] };

                    for (int j = 0; j < wagonPlace.coupes[i].places.Length; j++)
                    {
                        f++;

                        wagonPlace.coupes[i].places[j] = new Place { busyFree = true, Number = f };
                    }
                }

                var request = requests.Select((x) => new { Value = x.Split(new char[] { ';' }) }).Select(x => new { id = x.Value[0], numberPlace = x.Value[1] }).ToList();

                for (int i = 0; i < request.Count(); i++)
                {
                    int numberCoupe = 0;

                    int numberPlace = 0;

                    if (request[i].numberPlace != " ")
                    {
                        numberPlace = Convert.ToInt32(request[i].numberPlace);
                    }

                    if (request[i].numberPlace != " " && numberPlace % 2 == 1)
                    {
                        numberCoupe = Convert.ToInt32(request[i].numberPlace) / 2;
                    }
                    else if (request[i].numberPlace != " " && numberPlace % 2 == 0)
                    {
                        numberCoupe = Convert.ToInt32(request[i].numberPlace) / 2 - 1;
                    }

                    if (numberCoupe > Convert.ToInt32(coupeNumberRequests[0]))
                    {
                        Console.WriteLine("FAIL");

                        continue;
                    }

                    if (Convert.ToInt32(request[i].id.ToString()) == 1)
                    {
                        foreach (var item in wagonPlace.coupes[numberCoupe].places)
                        {
                            if (item.Number == numberPlace)
                            {
                                if (item.busyFree)
                                {
                                    Console.WriteLine("SUCCESS");

                                    item.busyFree = false;

                                    wagonPlace.coupes[numberCoupe].busyFree = false;

                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("FAIL");
                                }
                            }
                        }
                    }
                    else if (Convert.ToInt32(request[i].id.ToString()) == 2)
                    {
                        foreach (var item in wagonPlace.coupes[numberCoupe].places)
                        {
                            if (item.Number == numberPlace)
                            {
                                if (!item.busyFree)
                                {
                                    Console.WriteLine("SUCCESS");

                                    item.busyFree = true;

                                    var busyFreeCoupe = wagonPlace.coupes[numberCoupe].places.All(x => x.busyFree == true);

                                    busyFreeCoupe = true ? wagonPlace.coupes[numberCoupe].busyFree = true : wagonPlace.coupes[numberCoupe].busyFree = false;

                                    break;
                                }

                                else
                                {
                                    Console.WriteLine("FAIL");
                                }
                            }
                        }
                    }
                    else if (Convert.ToInt32(request[i].id.ToString()) == 3)
                    {
                        int s = 0;
                        foreach (var item in wagonPlace.coupes)
                        {
                            if (item.busyFree)
                            {
                                Console.Write($"SUCCESS ");

                                for (int t = 0; t < item.places.Length; t++)
                                {
                                    if (t == 0)
                                        Console.Write($"{item.places[t].Number}-");

                                    if (t == 1)
                                        Console.WriteLine($"{item.places[t].Number}");

                                    item.busyFree = false;

                                    item.places[0].busyFree = false;

                                    item.places[1].busyFree = false;
                                }
                                break;
                            }
                            else if (wagonPlace.coupes.Length == s + 1)
                            {
                                Console.WriteLine($"FAIL ");
                            }
                            s++;
                        }
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
