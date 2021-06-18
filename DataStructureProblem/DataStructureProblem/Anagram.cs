using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureProblem
{
    class Anagram
    {
        /// <summary>
        /// Check is a method to check whether the two given strings are anagram or not.
        /// </summary>
        public void Check()
        {
            ////Reading of 1st strings 
            Console.WriteLine("Enter The First String");
            String first_string = Console.ReadLine();

            Console.WriteLine("Enter The Second String");
            ////Reading of 2 strings 
            String second_String = Console.ReadLine();

            if (first_string.Length == second_String.Length)
            {
                int count = 0;

                ////converting string to array
                char[] string_One = first_string.ToCharArray();
                char[] string_Two = second_String.ToCharArray();

                ////Sorting of array`
                Array.Sort(string_One);
                Console.WriteLine(string_One);
                Array.Sort(string_Two);
                Console.WriteLine(string_Two);
                for (int var_i = 0; var_i < string_One.Length; var_i++)
                {
                    // if string 1 length is == string two length
                    if (string_One[var_i] == string_Two[var_i])
                    {
                        //count = count+1
                        count++;
                    }
                }
                //if count is equal to firststring length
                if (count == first_string.Length)
                {
                    // its a anagram
                    Console.WriteLine("Its a Anagram");
                }
                else
                {
                    //its not a anagram
                    Console.WriteLine("Its Not a Anagram");
                }

            }
            else
            {
                //String's entered should be of same length
                Console.WriteLine("String's entered should be of same length");
            }
        }
    }
}
