using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureProblem
{
    class PrimeNumbers
    {
        /// <summary>
        /// Demoe is an method created where we will check the prime numbers and also the prime number is palendrome or not.
        /// </summary>
        public void PrimeNum()
        {
            Console.WriteLine("Enter number Of Element");
            int number = Convert.ToInt32(Console.ReadLine());
            this.Check(number);
        }
        public void Check(int number)
        {
            ////Indexing for prime num array
            int k = 0;
            Console.WriteLine("Prime numbers are:");
            int countPrime = 0;

            ////Array for storing prime number 
            int[] array = new int[number];
            for (int var_i = 1; var_i <= number; var_i++)
            {
                int count = 0;
                for (int var_j = var_i; var_j >= 1; var_j--)
                {

                    ////Condition of prime number
                    if (var_i % var_j == 0)
                    {
                        count++;
                    }
                }

                ////If my count becomes 2 such that number has to divide of one and itself
                if (count == 2)
                {
                    Console.Write(var_i + " ");

                    ////Storing the prime numbers in this array
                    array[k++] = var_i;
                    countPrime++;
                }
            }
            Console.WriteLine("\nPalindrome: ");
            for (int var_e = 0; var_e < countPrime; var_e++)
            {
                int sum = 0;
                int value = array[var_e];
                if (value != 0)
                {
                    if (value > 9)

                        ////Condition to check whether the primenumber is palendrome or not
                        while (value > 0)
                        {
                            int rem = value % 10;
                            sum = sum * 10 + rem;
                            value = value / 10;
                        }
                    if (sum == array[e])
                    {
                        Console.Write("palendrome " + array[var_e] + " ");
                    }
                }
            }
        }
    }
}