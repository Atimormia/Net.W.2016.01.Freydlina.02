﻿using System;
using System.Collections.Generic;
using Tasks;

namespace Tasks.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Input:\n1. Task 1 - Array\n2. Task 2 - String\n3. Task 3 - Numbers\n>>");
                int task = 0;
                if (!Int32.TryParse(Console.ReadLine(), out task))
                {
                    Console.WriteLine("Input Error");
                    continue;
                }
                switch (task)
                {
                    case 1: Task1();
                        break;
                    case 2: Task2();
                        break;
                    case 3: Task3();
                        break;
                    default: Console.WriteLine("No task");
                        break;
                }

            }
        }

        static void Task1()
        {
            Console.Write("Input array arr = ");
            string[] str = Console.ReadLine().Split(' ');
            List<int> arr = new List<int>();
            foreach (var val in str)
            {
                int number = 0;
                if (!Int32.TryParse(val, out number))
                {
                    Console.WriteLine("Input Error");
                    return;
                }
                arr.Add(number);
            }
            Console.WriteLine(">"+Solver.Task1(arr.ToArray()));
        }

        static void Task2()
        {
            Console.Write("Input string a = ");
            string a = Console.ReadLine();
            Console.Write("Input string b = ");
            string b = Console.ReadLine();
            Console.WriteLine(">" + Solver.LongestTask2(a, b));
        }

        static void Task3()
        {
            int a, b, i, j;
            try
            {
                Console.Write("Input number a = ");
                a = Int32.Parse(Console.ReadLine());
                Console.Write("Input number b = ");
                b = Int32.Parse(Console.ReadLine());
                Console.Write("Input index i = ");
                i = Int32.Parse(Console.ReadLine());
                Console.Write("Input index j = ");
                j = Int32.Parse(Console.ReadLine());
                if (i > j)
                {
                    throw new Exception("Must be i < j");
                }
            }
            catch
            {
                Console.WriteLine("Input Error");
                return;
            }
            Console.WriteLine(">" + Solver.InsertionTask3(a, b, i, j));
        }
    }
}
