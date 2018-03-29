using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Collections;
using System.Diagnostics;


namespace PartA_Q1
{
    public class DynamicIntArray
    {
        int current_Array_Size = 0;
        int current_Array_Capacity;
        int[] myArray;

        //No arg constructor
        DynamicIntArray()
        {
            myArray = new int[10];
            current_Array_Capacity = myArray.Length;
        }

        //arg constructor
        DynamicIntArray(int initialCapacity)
        {
            myArray = new int[initialCapacity];
            current_Array_Capacity = myArray.Length;
            //initializing 5 indexes of the array initially with random numbers
            Random RNG = new Random();
            for (int i = 0; i < 5; i++)
            {
                myArray[i] = RNG.Next(1, current_Array_Capacity); ;
                current_Array_Size++;
            }
        }

        void Add(int newElement)
        {
            Console.WriteLine("before insertion");
            Console.WriteLine("current capacity before " + current_Array_Capacity);
            Console.WriteLine("current size is before " + current_Array_Size);
            foreach (var arrayIndex in myArray)
            {
                Console.WriteLine(arrayIndex);
            }

            //if size approaches to capacity
            if (current_Array_Size >= current_Array_Capacity)
            {
                current_Array_Capacity = current_Array_Capacity + 10;
                Array.Resize(ref myArray, current_Array_Capacity);

            }
            //inserting at the end
            myArray[current_Array_Size] = newElement;
            current_Array_Size++;

            //printing the array
            Console.WriteLine("after insertion");
            Console.WriteLine("current capacity after " + current_Array_Capacity);
            Console.WriteLine("current size after " + current_Array_Size);
            foreach (var arrayIndex in myArray)
            {
                Console.WriteLine(arrayIndex);
            }
        }


        void Get(int valueAtIndex)
        {
            for (int i = 0; i < myArray.Length; i++)
            {
                if (i == valueAtIndex)
                {
                    Console.WriteLine("value at index " + i + " is " + myArray[i]);
                }
            }

        }


        int IndexOf(int indexOfValue)
        {
            for (int j = 0; j < current_Array_Capacity; j++)
            {
                if (myArray[j] == indexOfValue)
                {
                    return j;
                }
            }
            return -1;
        }


        void SumAndSearchTimeComparsion()
        {
            Array.Clear(myArray, 0, current_Array_Capacity);
            current_Array_Size = 0;
            ArrayList myArrayList = new ArrayList();
            List<int> myList = new List<int>();
            Random rng = new Random();


            for (int i = 0; i < 1000000; i++)
            {
                int randomNumber = rng.Next(1, 1000000);
                myArrayList.Add(randomNumber);
                if (current_Array_Size >= current_Array_Capacity)
                {
                    current_Array_Capacity = current_Array_Capacity + 100000;
                    Array.Resize(ref myArray, current_Array_Capacity);
                    myArray[i] = randomNumber;
                    current_Array_Size++;

                }
                else
                {
                    myArray[i] = randomNumber;
                    current_Array_Size++;
                }
                myList.Add(randomNumber);
            }

            //Console.WriteLine(myArray.Length);
            //Console.WriteLine(myArrayList.Capacity);
            //Console.WriteLine(myList.Capacity);
            //for array list
            int sum = 0;
            Stopwatch watch = Stopwatch.StartNew();
            foreach (int i in myArrayList)
            {
                sum = sum + i;
            }
            watch.Stop();
            Console.WriteLine("ArrayList/for: {0}ms ({1})", watch.ElapsedMilliseconds, sum);

            //for dynamic array ints
            sum = 0;
            watch = Stopwatch.StartNew();
            foreach (int j in myArray)
            {

                sum = sum + j;
            }
            watch.Stop();
            Console.WriteLine("Array/for: {0}ms ({1})", watch.ElapsedMilliseconds, sum);

            //for list
            sum = 0;
            watch = Stopwatch.StartNew();
            foreach (int j in myList)
            {
                sum = sum + j;
            }
            watch.Stop();
            Console.WriteLine("List/for: {0}ms ({1})", watch.ElapsedMilliseconds, sum);
            Console.WriteLine();
            Console.WriteLine();

            //Console.WriteLine(current_Array_Size);
            //Console.WriteLine(current_Array_Capacity);
            watch = Stopwatch.StartNew();
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(rng.Next(0, myArray.Length));
            }
            watch.Stop();
            Console.WriteLine("Search time for 5 random values from array is : {0}ms", watch.ElapsedMilliseconds);
            Console.WriteLine();
            watch = Stopwatch.StartNew();
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(rng.Next(0, myArrayList.Capacity));
            }
            watch.Stop();
            Console.WriteLine("Search time for 5 random values from arraylist is : {0}ms", watch.ElapsedMilliseconds);
            Console.WriteLine();
            watch = Stopwatch.StartNew();
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(rng.Next(0, myList.Capacity));
            }
            watch.Stop();
            Console.WriteLine("Search time for 5 random values from List is : {0}ms", watch.ElapsedMilliseconds);
            Console.WriteLine();
            Console.WriteLine();

        }






        static void Main(string[] args)
        {
            DynamicIntArray obj = new DynamicIntArray(10);
            Console.WriteLine("**************PART-A Question-1********************");

            Console.WriteLine("Enter the element to add at the end of array :");
            int addElememtAtEnd = Convert.ToInt32(Console.ReadLine());
            obj.Add(addElememtAtEnd);
            Console.WriteLine();


            Console.WriteLine("Enter the index to get the corresponding value :");
            int getValueAtIndex = Convert.ToInt32(Console.ReadLine());
            obj.Get(getValueAtIndex);
            Console.WriteLine();

            Console.WriteLine("Enter the value to get its corresponding index :");
            int getIndexOfValue = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Index at input Value " + getIndexOfValue + " is " + obj.IndexOf(getIndexOfValue));
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("**************PART-A Question-2********************");
            obj.SumAndSearchTimeComparsion();




            Console.ReadLine();

        }
    }
}
