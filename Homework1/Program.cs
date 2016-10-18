using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Task1();
            Task2();
            Task3();
        }

        public static void Task1()
        {
            Console.WriteLine("Task 1:");
            Console.WriteLine();

            IIntegerList listOfIntegers = new IntegerList();
            ListExample(listOfIntegers);

            Console.WriteLine("----------------------------");
        }

        public static void Task2()
        {
            Console.WriteLine("Task 2:");
            Console.WriteLine();

            IGenericList<int> listOfIntegers = new GenericList<int>();
            listOfIntegers.Add(1);   // [1]
            listOfIntegers.Add(2);   // [1,2]
            listOfIntegers.Add(3);   // [1,2,3]
            listOfIntegers.Add(4);   // [1,2,3,4]
            listOfIntegers.Add(5);   // [1,2,3,4,5]
            listOfIntegers.RemoveAt(0); // [2,3,4,5]
            listOfIntegers.Remove(5); //[2,3,4]
            Console.WriteLine(listOfIntegers.Count); // 3
            Console.WriteLine(listOfIntegers.Remove(100)); //  false
            Console.WriteLine(listOfIntegers.RemoveAt(5)); //  false
            listOfIntegers.Clear(); // []
            Console.WriteLine(listOfIntegers.Count); // 0

            Console.WriteLine("----------------------------");
        }


        public static void ListExample(IIntegerList listOfIntegers)
        {
            listOfIntegers.Add(1);   // [1]
            listOfIntegers.Add(2);   // [1,2]
            listOfIntegers.Add(3);   // [1,2,3]
            listOfIntegers.Add(4);   // [1,2,3,4]
            listOfIntegers.Add(5);   // [1,2,3,4,5]
            listOfIntegers.RemoveAt(0); // [2,3,4,5]
            listOfIntegers.Remove(5); //[2,3,4]
            Console.WriteLine(listOfIntegers.Count); // 3
            Console.WriteLine(listOfIntegers.Remove(100)); //  false
            Console.WriteLine(listOfIntegers.RemoveAt(5)); //  false
            listOfIntegers.Clear(); // []
            Console.WriteLine(listOfIntegers.Count); // 0
        }

        public static void Task3 ()
        {
            Console.WriteLine("Task 3:");
            Console.WriteLine();

            IGenericList<string> stringList = new GenericList<string>();
            stringList.Add("Hello");
            stringList.Add("World");
            stringList.Add("!");

            //  foreach
            foreach (string value in stringList)
            {
                Console.WriteLine(value);
            }

            //  foreach  without  the  syntax  sugar
            IEnumerator<string> enumerator = stringList.GetEnumerator();
            while (enumerator.MoveNext())
            {
                string value = (string)enumerator.Current;
                Console.WriteLine(value);
            }

            Console.WriteLine("----------------------------");
        }
    }
}
