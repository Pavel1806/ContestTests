using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ContestTests
{
    class ContestFourthTask
    {
        public static void Method()
        {
            var testCaseCount = int.Parse(Console.ReadLine());

            List<string> passwords = new List<string>();

            for (var i = 0; i < testCaseCount; i++)
            {
                var password = Console.ReadLine();
                passwords.Add(password);
            }

            for (var j = 0; j < passwords.Count; j++)
            {
                string password = passwords[j];

                if (password.Intersect("euioayEUIOAY").Count() == 0)
                {
                    if (password.Intersect("bcdfghjklmnpqrstvwxzBCDFGHJKLMNPQRSTVWXZ").Count() == 0)
                    {
                        password = String.Concat(password, "aL");
                    }
                    else if (password.Intersect("bcdfghjklmnpqrstvwxzBCDFGHJKLMNPQRSTVWXZ").Count() > 0)
                    {
                        if (!password.Any(x => x >= 48 && x <= 57))
                        {
                            password = String.Concat(password, "0");

                            if (!password.Any(x => x >= 97 && x <= 122))
                            {
                                password = String.Concat(password, "a");
                            }
                            else if (!password.Any(x => x >= 65 && x <= 90))
                            {
                                password = String.Concat(password, "A");
                            }
                            else
                            {
                                password = String.Concat(password, "a");
                            }
                        }
                        else if (password.Any(x => x >= 48 && x <= 57))
                        {
                            if (!password.Any(x => x >= 97 && x <= 122))
                            {
                                password = String.Concat(password, "a");
                            }
                            else if (!password.Any(x => x >= 65 && x <= 90))
                            {
                                password = String.Concat(password, "A");
                            }
                            else
                            {
                                password = String.Concat(password, "A");
                            }

                        }
                    }
                }
                else if (password.Intersect("euioayEUIOAY").Count() > 0)
                {
                    if (password.Intersect("bcdfghjklmnpqrstvwxzBCDFGHJKLMNPQRSTVWXZ").Count() == 0)
                    {
                        if (!password.Any(x => x >= 48 && x <= 57))
                        {
                            password = String.Concat(password, "0");

                            if (!password.Any(x => x >= 97 && x <= 122))
                            {
                                password = String.Concat(password, "b");
                            }
                            else if (!password.Any(x => x >= 65 && x <= 90))
                            {
                                password = String.Concat(password, "B");
                            }
                            else
                            {
                                password = String.Concat(password, "b");
                            }
                        }
                        else if (password.Any(x => x >= 48 && x <= 57))
                        {
                            if (!password.Any(x => x >= 97 && x <= 122))
                            {
                                password = String.Concat(password, "b");
                            }
                            else if (!password.Any(x => x >= 65 && x <= 90))
                            {
                                password = String.Concat(password, "B");
                            }
                            else
                            {
                                password = String.Concat(password, "B");
                            }
                        }
                    }
                    else if (password.Intersect("bcdfghjklmnpqrstvwxzBCDFGHJKLMNPQRSTVWXZ").Count() > 0)
                    {
                        if (!password.Any(x => x >= 48 && x <= 57))
                        {
                            password = String.Concat(password, "0");

                            if (!password.Any(x => x >= 97 && x <= 122))
                            {
                                password = String.Concat(password, "b");
                            }
                            else if (!password.Any(x => x >= 65 && x <= 90))
                            {
                                password = String.Concat(password, "B");
                            }

                        }
                        else if (password.Any(x => x >= 48 && x <= 57))
                        {
                            if (!password.Any(x => x >= 97 && x <= 122))
                            {
                                password = String.Concat(password, "b");
                            }
                            else if (!password.Any(x => x >= 65 && x <= 90))
                            {
                                password = String.Concat(password, "B");
                            }
                        }
                    }
                }

                Console.WriteLine(password);
            }
        }
    }
}
