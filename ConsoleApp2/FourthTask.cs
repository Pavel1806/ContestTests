using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ContestTests
{
    class FourthTask
    {
        public static void Method()
        {
            var testCaseCount = int.Parse(Console.ReadLine());

            for (var i = 0; i < testCaseCount; i++)
            {
                int numberLogin = int.Parse(Console.ReadLine());

                string[] logins = new string[numberLogin];

                for (var j = 0; j < numberLogin; j++)
                {
                    var login = Console.ReadLine();
                    logins[j] = login.Trim().ToLower();
                }

                var p = logins.Select(c => new
                {
                    key = c,
                    value = c.Length >= 2 && c.Length <= 24 && !c.StartsWith("-") && c.All(x => x >= 48 && x <= 57 || x >= 65 && x <= 90 || x >= 97 && x <= 122 || x == 95 || x == 45),
                }).ToList();

                List<string> outputList = new List<string>();

                for (int j = 0; j < p.Count; j++)
                {
                    bool r = false;

                    foreach (var item in outputList)
                    {
                        if (p[j].key == item)
                        {
                            Console.WriteLine("No");
                            r = true;
                            break;
                        }
                    }
                    if (!r)
                    {
                        if (p[j].value)
                        {
                            Console.WriteLine("Yes");

                            outputList.Add(p[j].key);

                            continue;
                        }

                        Console.WriteLine("No");
                    }
                }
            }
        }
    }
}
