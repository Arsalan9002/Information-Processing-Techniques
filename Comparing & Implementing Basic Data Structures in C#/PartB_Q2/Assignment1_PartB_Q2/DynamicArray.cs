using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment1_PartB_Q2;

namespace Assignment1_PartB_Q2
{
    class DynamicArray<T> : IList<T>
    {
        public IList<T> _MyList;
        public int CurrentArraySize = 0;
        public int _currentArrayCapacity;

        public DynamicArray()
        {
            _MyList =  new List<T>(10);
            _currentArrayCapacity = _MyList.Count;
        }

        //arg constructor
        public DynamicArray(int initialCapacity)
        {
            _MyList = new List<T>(10);
            _currentArrayCapacity = initialCapacity;
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Add(T item)
        {

            _MyList.Add(item);
            CurrentArraySize++;
            foreach (var arrayIndex in _MyList)
            {
                Console.WriteLine(arrayIndex);
            }
            // Console.WriteLine("size is "+_myList.Count);

            /*foreach (var i in _myList)
            {
                Console.WriteLine(i);
            }*/
            // Console.WriteLine(CurrentArraySize);

        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(T item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public bool Remove(T item)
        {
            throw new NotImplementedException();
        }

        public int Count { get; }
        public bool IsReadOnly { get; }

        public T Get(int valueAtIndex)
        {

            return _MyList[valueAtIndex];




        }

        public int IndexOf(T item)
        {
            for (int j = 0; j < _MyList.Count; j++)
            {
                if (_MyList[j].Equals(item))
                {
                    return j;
                }
            }
            return -1;
        }

        public void Insert(int index, T item)
        {
            throw new NotImplementedException();
        }

        public void RemoveAt(int index)
        {
            throw new NotImplementedException();
        }

        public T this[int index]
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    }




    class Tester
    {

        static void Main(string[] args)
        {
            Console.WriteLine("**************PART-B Question-2********************");
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
                        int getIndexOfIntValue = Convert.ToInt32(Console.ReadLine());
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
    


       
    
