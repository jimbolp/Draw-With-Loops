﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stop
{
    class Program
    {
       
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int j = 2 * n - 1;
            int k = 4 * n - 1;

            Console.WriteLine(new string('.', n + 1) + new string('_', 2 * n + 1) + new string('.', n + 1));

            for (int i=n; i>=1; i--)
            {                
                Console.WriteLine(new string('.', i) + "//" + new string('_', j) + @"\\" + new string('.', i));
                j += 2;
            }

            Console.WriteLine("//" + new string ('_', (4*n-1-5)/2) + "STOP!" + new string ('_', (4*n-1-5)/2) + @"\\");

            for (int i = 0; i <= n-1; i++)
            {
                Console.WriteLine(new string('.', i) + @"\\" + new string('_', k) + "//" + new string ('.', i));
                k -= 2;
            }
            Temp();
        }
        //All Rights Reserved® 
        public static void Temp()
        {
                int n = 0;
                while (n < 3 || n > 1000)
                {
                    Console.Write("Input a number: ");
                    n = int.Parse(Console.ReadLine());
                    if (n < 3 || n > 1000)
                        Console.WriteLine("Invalid input. Try again.");
                }
                int beg = n + 1;
                int inside = n * 2 - 1;
                string stop = "STOP!";
                for (int i = 0; i <= n + 1; i++)
                {
                    if (i == 0)
                    {
                        Console.WriteLine(new string('.', beg - i) + new string('_', inside + 2) + new string('.', beg - i));
                    }
                    else if (i == n + 1)
                    {
                        Console.WriteLine(new string('.', beg - i) + "//" + new string('_', (inside + i - 1) / 2 - stop.Length / 2) 
                                                                                            + stop + new string('_', (inside + i - 1) / 2 - stop.Length / 2) + "\\\\" + new string('.', beg - i));
                        inside++;
                    }
                    else
                    {
                        Console.WriteLine(new string('.', beg - i) + "//" + new string('_', inside + i - 1) + "\\\\" + new string('.', beg - i));
                        inside++;
                    }
                }
                for (int j = n + 1; j > 1; j--)
                {
                    Console.WriteLine(new string('.', beg - j) + "\\\\" + new string('_', inside + j - 2) + "//" + new string('.', beg - j));
                    inside--;
                }
            }
       }
}


