using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Array
            Array tt = new Array();
            tt.PrintArray(tt.GenerateRandomArray(7, 20, 1));
            tt.SumOFArray(tt.GenerateRandomArray(7, 20, 1));
            tt.PrintArrayReverseOrder(tt.GenerateRandomArray(7, 20, 1));
            tt.MaxValueInArray(tt.GenerateRandomArray(7, 20, 1));

            //arraylist
            ArrayListCustom hh = new ArrayListCustom();
            hh.printArray(hh.ArrayListCreation());
            hh.Sort(hh.ArrayListSimple());
            hh.Reverse(hh.ArrayListSimple());
            hh.FindElementInArray(hh.ArrayListSimple(), "Cat");
            hh.FindIndexOfElement(hh.ArrayListSimple(), "Cat");
            


            //Dictionary

            DictionaryCustom rr = new DictionaryCustom();
            rr.printDictionary(rr.CreateNewDictionary());
            rr.RemoveRecordByKey(rr.CreateNewDictionary(), "dib");
            rr.FindByKey(rr.CreateNewDictionary(), "dib");
            rr.FindByvalue(rr.CreateNewDictionary(), "wordpad.exe");


            //List

            ListCustom gg = new ListCustom();
            gg.PrintArray(gg.CreateList());
            gg.AddElement(gg.CreateList(), 2);
            gg.AddRage(gg.CreateList(), tt.GenerateRandomArray(7, 20, 1));
            gg.AddElementToPosition(gg.CreateList(), 99, 0);

            gg.PrintArray(gg.AddElementToPosition(gg.CreateList(), 99, 0));

            Console.ReadKey();
        }
    }

    class Array
    {


        int[] array2 = new int[] { 1, 3, 5, 7, 9 };
        Random randNum = new Random();

        public int[] GenerateRandomArray(int countOfElements, int maxValue, int minValue)
        {

            int[] array = new int[countOfElements];

            Random randNum = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = randNum.Next(minValue, maxValue);
            }

            return array;
        }

        public void PrintArray(int[] array)
        {
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();
        }

        public void PrintArrayReverseOrder(int[] array)
        {
            int[] arrayNew = new int[array.Length];
            int i = array.Length;

            foreach (var item in array)
            {
                i--;
                arrayNew[i] = item;

            }

            foreach (var item in arrayNew)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();


        }

        public int SumOFArray(int[] array)
        {
            int sum = 0;
            foreach (var item in array)
            {
                sum += item;
            }

            Console.WriteLine("Sum of elements = " + sum);
            return sum;
        }

        public void MaxValueInArray(int[] array)
        {
            int max = array[0];
            foreach (var item in array)
            {
                if (max < item)
                {
                    max = item;
                }
            }

            Console.WriteLine("Max value in array = " + max);
        }




    }

    class ArrayListCustom
    {
        public ArrayList ArrayListCreation()
        {
            var list1 = new ArrayList();
            list1.Add("Visual Basic");
            list1.Add(344);
            list1.Add(55);
            list1.Add(new Array());
            list1.Insert(0, "Carrot");
            list1.RemoveAt(1);
            list1.RemoveRange(1, 1);
            list1.Remove(55);





            var list2 = list1.GetRange(1, 1);
            list2.Add(10);
            list2.Add(13);

            list1.AddRange(list2);

            return list1;
        }

        public ArrayList Sort(ArrayList list)
        {
            list.Sort();

            foreach (string value in list)
            {
                Console.WriteLine(value);
            }

            return list;
        }
        public ArrayList Reverse(ArrayList list)
        {    

            list.Sort();

            list.Reverse();

            foreach (string value in list)
            {
                Console.WriteLine(value);
            }

            return list;
        }

        public ArrayList ArrayListSimple()
        {
            ArrayList list = new ArrayList();
            list.Add("Cat");
            list.Add("Zebra");
            list.Add("Dog");
            list.Add("Cow");

            return list;
        }



        public void FindElementInArray(ArrayList list, string findInArray)
        {
            foreach (object el in list)
            {
                if (el == findInArray)
                {
                    Console.WriteLine("element '" + findInArray + "' Is presented in array");

                }

            }

            foreach (object el in list)
            {
                Console.WriteLine(el);
            }
        }

        public int FindIndexOfElement(ArrayList list, string findInArray)
        {

            int index = list.IndexOf(findInArray);
            Console.WriteLine("index " + index);


            return index;
        }



        public void printArray(ArrayList list)
        {
            foreach (object el in list)
            {
                Console.WriteLine(el);
            }
        }
    }

    class DictionaryCustom
    {
        public Dictionary<string, string> CreateNewDictionary()
        {

            Dictionary<string, string> openWith = new Dictionary<string, string>();

            openWith.Add("txt", "notepad.exe");
            openWith.Add("bmp", "paint.exe");
            openWith.Add("dib", "paint.exe");
            openWith.Add("rtf", "wordpad.exe");          

            return openWith;
        }


        public Dictionary<string, string> RemoveRecordByKey(Dictionary<string, string> list, string key)
        {
            list.Remove(key);
            return list;
        }


        public bool FindByKey(Dictionary<string, string> list, string key)
        {
            bool isPresented = list.ContainsKey("rtf");
            Console.WriteLine("rtf - {0}", list.ContainsKey("rtf"));

            return isPresented;
        }

        public bool FindByvalue(Dictionary<string, string> list, string key)
        {
            bool isPresented = list.ContainsValue("wordpad.exe");
            Console.WriteLine("rtf - {0}", list.ContainsValue("wordpad.exe"));

            return isPresented;
        }       
            

           

        public void printDictionary(Dictionary<string, string> copy)
        {
            foreach (KeyValuePair<string, string> item in copy)
            {
                Console.WriteLine("Key = {0}, Value = {1}",
                   item.Key, item.Value);
            }
        }

    }

    class ListCustom
    {
        public List<int> CreateList()
        {
            List<int> numbers = new List<int>() { 1, 2, 3, 45 };                       
           
            numbers.RemoveAt(1);          

            return numbers;
        }

        public List<int> AddRage(List<int> list, int[] array)
        {
            list.AddRange(array);

            return list;
        }

        public List<int> AddElement(List<int> list, int el)
        {
            list.Add(el);

            return list;
        }

        public List<int> AddElementToPosition(List<int> list, int el, int position)
        {
            list.Insert(position, el);

            return list;
        }

        public void PrintArray(List<int> list)
        {
            foreach (int i in list)
            {
                Console.WriteLine(i);
            }
        }
    }

    

}

