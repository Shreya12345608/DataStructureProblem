using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureProblem
{
    class BubbleSort
    {

        public int[] arr;
        public int Top;
        public int numElements;

        /// <summary>
        /// constructor for bubble sort with parametr size
        /// </summary>
        /// <param name="size"></param>
        public BubbleSort(int size)
        {
            // storing int size in arr
            arr = new int[size];
            //top = size - 1
            Top = size - 1;
            // by default numElement is 0
            numElements = 0;
        }
        /// <summary>
        /// insert array 
        /// </summary>
        /// <param name="item"></param>
        public void InsertNumbers(int item)
        {

            arr[numElements] = item;
            numElements++;
        }
        /* Prints the array */
        public void DisplayElements()
        {
            //loop if display = 0 display <= top value ; den increment by 1
            for (int display = 0; display <= Top; display++)
                // display array list ,
                Console.WriteLine(arr[display] + ",");
        }

        /// <summary>
        ///method for  bubble sort 
        /// </summary>
        public void BubbleSorts()
        {
            // instance variable
            int temp;
            //loop taking top value in outer ; outer > =1 ; outer +1
            for (int outer = Top; outer >= 1; outer--)
            {
                //loop for inner is 0 ; inner < =1 ; inner +1
                for (int inner = 0; inner <= outer - 1; inner++)
                    if ((int)arr[inner] > arr[inner + 1])
                    {
                        // swap temp and arr[inner]
                        temp = arr[inner];
                        arr[inner] = arr[inner + 1];
                        arr[inner + 1] = temp;
                    }
            }
            //last display Elements
            this.DisplayElements();
        }
    }
}