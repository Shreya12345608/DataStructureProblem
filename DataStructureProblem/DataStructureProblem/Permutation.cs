using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureProblem
{
    /// <summary>
    /// claaa for permutation
    /// </summary>
    class Permutation
    {
        /// <summary>
        /// method for permute with string str int left and iint right
        /// permutation function
        /// str string to
        ///calculate permutation for
        /// l starting index r end index
        /// </summary>
        /// <param name="str"></param>
        /// <param name="left"></param>
        /// <param name="right"></param>
        public static void Permute(String str, int startingIndex, int endIndex)
        {
            //if startindex ==  endindex print str
            if (startingIndex == endIndex)
                Console.WriteLine(str);
            else
            {

                for (int var_i = startingIndex; var_i <= endIndex; var_i++)
                {
                    str = Swap(str, startingIndex, var_i);
                    Permute(str, startingIndex + 1, endIndex);
                    str = Swap(str, startingIndex, var_i);
                }
            }
        }
        /// <summary>
        /// Swap Characters at position
        /// inputForWord string value
        /// left position 1
        /// var_i position 2
        /// </summary>
        /// <param name="inputword"></param>
        /// <param name="left"></param>
        /// <param name="var_i"></param>
        /// <returns></returns>


        public static string Swap(string inputForWord, int left, int var_i)
        {
            char temp;
            char[] charArray = inputForWord.ToCharArray();
            temp = charArray[left];
            charArray[left] = charArray[var_i];
            charArray[var_i] = temp;
            string Output = new string(charArray);
            return Output;
        }
    }
}
