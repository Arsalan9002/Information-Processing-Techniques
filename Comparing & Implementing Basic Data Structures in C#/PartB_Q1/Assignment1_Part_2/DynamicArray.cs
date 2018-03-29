using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_Part_2
{
    public class DynamicArray<T>
    {
        private T[] myArray;
        int current_Array_Size = 0;
        int current_Array_Capacity;

        public DynamicArray()
        {
            myArray = new T[10];
            current_Array_Capacity = myArray.Length;
        }

        //arg constructor
        public DynamicArray(int initialCapacity)
        {
            myArray = new T[initialCapacity];
            current_Array_Capacity = myArray.Length;
        }

        public void Add(T newElement)
        {
            Console.WriteLine("before insertion");
            Console.WriteLine("current capacity before " + current_Array_Capacity);
            Console.WriteLine("current size is before " + current_Array_Size);
            /*foreach (var arrayIndex in myArray)
            {
                Console.WriteLine(arrayIndex);
            }
            */
            //if size approaches to capacity
            if (current_Array_Size >= current_Array_Capacity)
            {
                current_Array_Capacity++;
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

        public void Get(int valueAtIndex)
        {
            for (int index = 0; index < myArray.Length; index++)
            {
                if (index == valueAtIndex)
                {
                    Console.WriteLine("value at index " + index + " is " + myArray[index]);
                }
            }

        }

        public int IndexOf(T indexOfValue)
        {
            for (int index = 0; index < current_Array_Capacity; index++)
            {
                if (myArray[index].Equals(indexOfValue))
                {
                    return index;
                }
            }
            return -1;
        }
    }

    class Tester {
        static void Main(string[] args)
        {
            Console.WriteLine("**************PART-A Question-1********************");
            Console.WriteLine("Press 1 for Float , 2 for integer and 3 for double ");
            int caseChoice = Convert.ToInt32(Console.ReadLine());
            switch (caseChoice)
            {
                case 1:
                {
                    DynamicArray<float> objFloat = new DynamicArray<float>(10);
                    
                    Console.WriteLine("Enter thefloat value to add at the end of array :");
                    float addFloatElememt = float.Parse(Console.ReadLine());
                    objFloat.Add(addFloatElememt);
                    Console.WriteLine();

                    Console.WriteLine("Enter the index to get the corresponding value :");
                    int getFloatValueAtIndex = Convert.ToInt32(Console.ReadLine());
                    objFloat.Get(getFloatValueAtIndex);
                    Console.WriteLine();

                    Console.WriteLine("Enter the value to get its corresponding index :");
                    float getIndexOfFloatValue = float.Parse(Console.ReadLine());
                    Console.WriteLine("Index at input Value " + getIndexOfFloatValue + " is " + objFloat.IndexOf(getIndexOfFloatValue));
                    Console.WriteLine();
                    Console.WriteLine();
                    break;
                }
                case 2:
                {
                    DynamicArray<int> objInt = new DynamicArray<int>(10);
                    Console.WriteLine("Enter the integer value to add at the end of array :");
                    int addElememtInt = Convert.ToInt32(Console.ReadLine());
                    objInt.Add(addElememtInt);
                    Console.WriteLine();

                    Console.WriteLine("Enter the index to get the corresponding value :");
                    int getIntValueAtIndex = Convert.ToInt32(Console.ReadLine());
                    objInt.Get(getIntValueAtIndex);
                    Console.WriteLine();

                    Console.WriteLine("Enter the value to get its corresponding index :");
                    int getIndexOfIntValue= Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Index at input Value " + getIndexOfIntValue + " is " + objInt.IndexOf(getIndexOfIntValue));
                    Console.WriteLine();
                    Console.WriteLine();
                    break;
                }
                case 3:
                {
                    DynamicArray<int> objdecimal = new DynamicArray<int>(10);
                    Console.WriteLine("Enter the integer value to add at the end of array :");
                    int addElememtDecimal = Convert.ToInt32(Console.ReadLine());
                    objdecimal.Add(addElememtDecimal);
                    Console.WriteLine();

                    Console.WriteLine("Enter the index to get the corresponding value :");
                    int getDecimalValueAtIndex = Convert.ToInt32(Console.ReadLine());
                    objdecimal.Get(getDecimalValueAtIndex);
                    Console.WriteLine();

                    Console.WriteLine("Enter the value to get its corresponding index :");
                    int getIndexOfDecimalValue = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Index at input Value " + getIndexOfDecimalValue + " is " + objdecimal.IndexOf(getIndexOfDecimalValue));
                    Console.WriteLine();
                    Console.WriteLine();
                    break;
                }
                    

                default:
                    break;

            }
          
            Console.ReadLine();


        }
    }
     
}
