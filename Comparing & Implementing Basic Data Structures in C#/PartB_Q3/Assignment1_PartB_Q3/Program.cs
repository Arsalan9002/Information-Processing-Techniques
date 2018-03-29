using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_PartB_Q3
{
    public class Program<T> 
    {

        int currentDecimalSize = 0;
        int currentDoubleSize = 0;
        int currentBoolSize = 0;
        int current_Array_Capacity;

        private T[] myDoubles;
        private T[] mDecimals;
        private T[] mBools;
       

        //arg constructor
        public Program(int initialCapacity)
        {
            myDoubles = new T[initialCapacity];
            mDecimals = new T[initialCapacity];
            mBools = new T[initialCapacity];

            current_Array_Capacity = initialCapacity;
        }

        public void AddDecimal(T newElement)
        {
           
            //if size approaches to capacity
            if (currentDecimalSize >= current_Array_Capacity)
            {
                current_Array_Capacity = current_Array_Capacity + 1000;
                Array.Resize(ref mDecimals, current_Array_Capacity);

            }
            //inserting at the end
            mDecimals[currentDecimalSize] = newElement;
            currentDecimalSize++;
            if (currentDecimalSize == 1000000)
            {
                SumDecimal();
            }

        }

        public void AddDouble(T newElement)
        {
            //if size approaches to capacity
            if (currentDoubleSize >= myDoubles.Length)
            {
                current_Array_Capacity= current_Array_Capacity + 1000;
                Array.Resize(ref myDoubles, current_Array_Capacity);

            }
            //inserting at the end
            myDoubles[currentDoubleSize] = newElement;
            currentDoubleSize++;
            if (currentDoubleSize == 1000000)
            {
                SumDouble();
            }
            
        }

        public void AddBool(T newElement)
        {
            //if size approaches to capacity
            if (currentBoolSize >= current_Array_Capacity)
            {
                current_Array_Capacity = current_Array_Capacity + 1000;
                Array.Resize(ref mBools, current_Array_Capacity);

            }
            //inserting at the end
            mBools[currentBoolSize] = newElement;
            currentBoolSize++;
            if (currentBoolSize == 1000000)
            {
                CompareInBoolArray();
            }
        }

        public void SumDecimal()
        {
            decimal sum=0;
            Stopwatch watch = Stopwatch.StartNew();
            for (int i = 0; i < current_Array_Capacity; i++)
            {
                sum =(sum) + Convert.ToDecimal(mDecimals[i]);
            }
            watch.Stop();
            Console.WriteLine("DynamicArray decimals/for: {0}ms ({1})", watch.ElapsedMilliseconds, sum);

        }
        public void SumDouble()
        {
            double sum = 0;
            Stopwatch watch = Stopwatch.StartNew();
            for (int i = 0; i < current_Array_Capacity; i++)
            {
                sum = (sum) + Convert.ToDouble(myDoubles[i]);
            }
            watch.Stop();
            Console.WriteLine("DynamicArray double/for: {0}ms ({1})", watch.ElapsedMilliseconds, sum);
           

        }

        public void CompareInBoolArray()
        {
            Stopwatch watch = Stopwatch.StartNew();
            if (mBools[1].Equals(mBools[1000])|| mBools[2].Equals(true))
            {
               Console.WriteLine("Successfull comparison");
            }
            watch.Stop();
            Console.WriteLine("DynamicArray boolean comparison time/for: {0}ms", watch.ElapsedMilliseconds);
            Console.WriteLine();
            Console.WriteLine();
        }

    }

    class Tester
    {
        // sum for list and c# array in decimal case
        public void SumForDecimals(List<decimal> myList, decimal[] myArray)
        {
            decimal sum = 0;
            Stopwatch watch = Stopwatch.StartNew();
            foreach (var i in myList)
            {
                sum = sum + i;
            }
            watch.Stop();
            Console.WriteLine("List decimals/for: {0}ms ({1})", watch.ElapsedMilliseconds, sum);

            sum = 0;
            watch = Stopwatch.StartNew();
            foreach (var t in myArray)
            {
                sum = sum + t;
            }
            watch.Stop();
            Console.WriteLine("array decimals/for: {0}ms ({1})", watch.ElapsedMilliseconds, sum);
            Console.WriteLine();
            Console.WriteLine();
        }
        // sum for list and c# array in double case
        public void SumForDoubles(List<double> myList, double[] myArray)
        {
            double sum = 0;
            Stopwatch watch = Stopwatch.StartNew();
            foreach (var i in myList)
            {
                sum = sum + i;
            }
            watch.Stop();
            Console.WriteLine("List double/for: {0}ms ({1})", watch.ElapsedMilliseconds, sum);

            sum = 0;
            watch = Stopwatch.StartNew();
            foreach (var t in myArray)
            {
                sum = sum + t;
            }
            watch.Stop();
            Console.WriteLine("array double/for: {0}ms ({1})", watch.ElapsedMilliseconds, sum);
            Console.WriteLine();
            Console.WriteLine();
        }

        public void ComparisonForBools(List<bool> myBoolsList, bool[] myBoolsArray)
        {
            Stopwatch watch = Stopwatch.StartNew();
            if (myBoolsList[1] ==myBoolsList[1000] || myBoolsList[2]==true)
            {
                Console.WriteLine("Successfull bool comparison");
            }
            watch.Stop();
            Console.WriteLine("List boolean comparison time/for: {0}ms", watch.ElapsedMilliseconds);

             watch = Stopwatch.StartNew();
            if (myBoolsArray[1] == myBoolsArray[1000] || myBoolsArray[2]==true)
            {

            }
            watch.Stop();
            Console.WriteLine("array boolean comparison time/for: {0}ms", watch.ElapsedMilliseconds);

        } 

        public static void Main(string[] args)
        {
            Program<double> myDynamicDoubles = new Program<double>(10);
            Program<decimal> myDynamicDecimals = new Program<decimal>(10);
            Program<bool> myDynamicBools = new Program<bool>(10);


            Random random = new Random();
            

            // for c# array
            decimal[] myDecimals = new decimal[1000000];
            double[] myDoubles = new double[1000000];
            bool[] myBools = new bool[1000000];

            //for list
            List<decimal> myDecimalList = new List<decimal>();
            List<double> myDoubleList = new List<double>();
            List<bool> myBoolList = new List<bool>();

            //populating list , c# array,  for decimals
            random = new Random();
            for (int i = 0; i < 1000000; i++)
            {
                var item = new decimal(random.NextDouble());
                myDecimalList.Add(item);
                myDecimals[i] = item;
                myDynamicDecimals.AddDecimal(item);

            }

            //populating list, c# array and dynamic array for doubles
            for (int i = 0; i < 1000000; i++)
            {
                var item = (random.NextDouble());
                myDoubleList.Add(item);
                myDoubles[i] = item;
                myDynamicDoubles.AddDouble(item);

            }
            //populating list, c# array and dynamic array for bools
            for (int i = 0; i < 1000000; i++)
            {
                myBoolList.Add(false);
                myBools[i] = false;
                myDynamicBools.AddBool(false);

            }

            Tester obj = new Tester();
            //calling functions
            obj.SumForDoubles(myDoubleList, myDoubles);
            obj.SumForDecimals(myDecimalList, myDecimals);
            obj.ComparisonForBools(myBoolList, myBools);

            Console.ReadLine();

        }

    }

}
       
    






