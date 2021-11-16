using System;
using System.Collections.Generic;

namespace HomeWork4
{
    class Program
    {
        static void PrintList(List<int> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("---------");
        }

        static void PrintArray(int [] array)
        {
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("--------------------");
        }

        static int[] BubbleSort(int[] myArray)
        {
            var len = myArray.Length;

            for (int i = 1; i < myArray.Length; i++)
            {
                for (var j = 0; j < myArray.Length; j++)
                {
                    if (myArray[j] > myArray[i])
                    {
                        var temp = myArray[i];
                        myArray[i] = myArray[j];
                        myArray[j] = temp;
                    }
                }
            }
            return myArray;
        }

        static int[] ShellSort(int[] array)
        {          
            var d = array.Length / 2;
            while (d >= 1)
            {
                for (var i = d; i < array.Length; i++)
                {
                    var j = i;
                    while ((j >= d) && (array[j - d] > array[j]))
                    {
                        var t = array[j];
                        array[j] = array[j - d];
                        array[j - d] = t;
                        j = j - d;
                    }
                }
                d = d / 2;
            }
            return array;
        }

        static void Main(string[] args)
        {
            Random random = new Random();

            #region Exersixe 1
            //List<int> list1 = new List<int>();
            //List<int> list2 = new List<int>();
            //List<int> list3 = new List<int>();

            //for (int i = 0; i < 5; i++)
            //{
            //    list1.Add(random.Next(100));
            //    list2.Add(random.Next(100));
            //}

            //PrintList(list1);
            //PrintList(list2);

            //list3.AddRange(list1);
            //list3.AddRange(list2);

            //PrintList(list3);

            #endregion

            #region Exersize 2

            //int[] myArray = new int[10];

            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    myArray[i] = random.Next(1, 10);
            //}

            //int indexMin = Array.FindIndex(myArray, i => i == myArray.Min());
            //int indexMax = Array.FindIndex(myArray, i => i == myArray.Max());
            //int[] myArray2 = indexMax > indexMin? myArray[indexMin..++indexMax] : myArray[indexMax..++indexMin];      

            //int sum = myArray2.Sum();

            #endregion

            #region Exersize 3

            //List<int> circleMan = new List<int>(Enumerable.Range(1, 15));
            //PrintList(circleMan);

            //bool change = false;

            //while (circleMan.Count > 1)
            //{
            //    for (int i = 0; i < circleMan.Count; i++)
            //    {
            //        if (change)
            //        {
            //            circleMan.RemoveAt(i--);
            //        }
            //        change = !change;
            //    }
            //    PrintList(circleMan);
            //}

            //PrintList(circleMan);

            #endregion

            #region Exersize 4 

            //int[] myArray = new int[5];

            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    myArray[i] = random.Next(1, 50);
            //}         

            //PrintArray(myArray);            

            //ShellSort(myArray);
            //BubbleSort(myArray);

            //PrintArray(myArray);

            #endregion 
        }
    }
}
