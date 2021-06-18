using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Data Structure Problems");
            Console.WriteLine("Press 1 for Bubble Sort Problem");
            Console.WriteLine("Press 2 for Insertion Sort Problem");
            Console.WriteLine("Press 3 for Permutation Problem");
            Console.WriteLine("Press 4 for Anagram Problem");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    //Bubble Sort
                    var Output = new BubbleSort(10);
                    Random random = new Random(20);
                    for (int i = 0; i < 10; i++)
                    Output.InsertNumbers((int)(random.NextDouble() * 10));
                    Console.WriteLine("Before sorting:");
                    Output.DisplayElements();
                    Console.WriteLine("During sorting:");
                    Output.BubbleSorts();
                    Console.WriteLine("After sorting:");
                    Output.DisplayElements();
                    Console.ReadKey();
                    break;
                case 2:
                    //insertion sort 
                    InsertionSort.sort();
                    Console.ReadKey();
                    break;
                 case 3:
                    Permutation permutation = new Permutation();
                    String str = "Shreya";
                    int Outputs = str.Length;
                    Permutation.Permute(str, 0, Outputs - 1);
                    Console.ReadKey();
                    break;
                case 4:
                    //Anagram  
                    Anagram anagram = new Anagram();
                    anagram.Check();
                    Console.ReadKey();
                    break;
                default:
                    Console.WriteLine("Invalid Selection. Enter a valid option:");
                    break;
            }
        }
    }
}

