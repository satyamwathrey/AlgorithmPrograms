﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AlgorithmPrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string flag = "Y";
            while (flag == "Y" || flag == "y")
            {
                Console.WriteLine("--------------------------------------------------------------------------");
                Console.WriteLine("-----------------Data Sructures Algorithm Programs------------------------");
                Console.WriteLine("--------------------------------------------------------------------------\n");
                Console.WriteLine("1.Permutation Using Recursion\n2.InsertionSort\n3.BubbleSort\n4.MergeSort\n5.Anagram\n7.PrimeNumbers\n");
                Console.WriteLine("Enter Your Option");
                int num = Convert.ToInt32(Console.ReadLine());
                switch (num)
                {
                    case 1:
                        Console.WriteLine("Enter String to find Permutation ");
                        string str = Console.ReadLine();
                        int n = str.Length;
                        Permutation.Permutate(str, 0, n - 1);
                        break;


                    default:
                        Console.WriteLine("-------Enter the valid option---");
                        break;
                }
                Console.WriteLine("\nDo you want to continue");
                flag = Console.ReadLine();
            }
            Console.ReadLine();
        }
    }
}
