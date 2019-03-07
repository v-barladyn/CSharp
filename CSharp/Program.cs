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

            OperationsWithCollections gg = new OperationsWithCollections();
            gg.GetMean(gg.numbers);
            gg.GetMedian(gg.numbers);
            gg.GetMode(gg.numbers);
            gg.FindElementsInList(gg.ShuffleList(gg.strings), "Peter");
            gg.ParseInt(gg.strList);          


            Console.ReadKey();
        }
    }



    class OperationsWithCollections
    {
        public List<int> numbers = new List<int>() { 1, 2, 4, 2, 3, 45 };
        public List<string> strings = new List<string>() { "Ivan", "Peter", "Adam", "John", "Adam", "Janes", "Janes" };
        public List<string> strList = new List<string>() { "Ann", "34", "Dog", "Aplle 64" };


        public double GetMean(List<int> list)
        {
            double mean = 0;
            int sum = 0;
            int i = 0;

            do
            {
                sum += list[i];
                i++;
            } while (i < list.Count());

            // for  (int i = 0; i < list.Count(); i++)
            // {
            //     sum += list[i];
            //}

            mean = sum / list.Count();
            Console.WriteLine("Mean - " + mean);

            return mean;
        }

        public double GetMedian(List<int> list)
        {
            double median = 0;
            list.Sort();

            if (list.Count() % 2 == 0)
            {

                median = (list[list.Count() / 2] + list[(list.Count() / 2) + 1]) / 2;

            }
            else
            {
                median = list[(int)Math.Round((double)list.Count() / 2)];
            }

            Console.WriteLine("Median - " + median);

            return median;
        }

        public int GetMode(List<int> list)
        {

            int mode = default(int);

            if (list != null && list.Count() > 0)
            {

                Dictionary<int, int> counts = new Dictionary<int, int>();

                foreach (int element in list)
                {
                    if (counts.ContainsKey(element))
                        counts[element]++;
                    else
                        counts.Add(element, 1);
                }

                int max = 0;
                foreach (KeyValuePair<int, int> count in counts)
                {
                    if (count.Value > max)
                    {

                        mode = count.Key;
                        max = count.Value;
                    }
                }
            }

            Console.WriteLine("Mode - " + mode);
            return mode;
        }

        public void FindElementsInList(List<string> list, string str)


        {


            int i = 0;

            foreach (string el in list)
            {

                if (el == str)
                {
                    if (el == "Janes")
                    {
                        i++;
                        Console.WriteLine(" James Found");
                        break;
                    }
                    if (el == "Adam")
                    {
                        i++;
                        Console.WriteLine("Adam Found");
                        continue;
                        Console.WriteLine("11");
                    }
                    else
                    {
                        i++;
                    }
                }
            }

            if (i > 0)
            {
                Console.WriteLine("Succes , you found - {0} in array {1} times ", str, i);
            }
            else
            {
                Console.WriteLine("Fail  , you did not  find - {0} in array  ", str);
            }

        }

        public List<string> ShuffleList(List<string> list)
        {
            Random random = new Random();

            for (int i = 0; i < list.Count; i++)
            {
                string temp = list[i];
                int randomIndex = random.Next(i, list.Count);
                list[i] = list[randomIndex];
                list[randomIndex] = temp;

                //Console.WriteLine(list[randomIndex]);

            }

            return list;
        }

        public void ParseInt(List<string> list)
        {
            int[] ints = new int[list.Count];
            int i = 0;

            foreach (string s in list)
            {

                int parsedInt = 0;
                if (int.TryParse(s, out parsedInt))
                {
                    ints[i] = parsedInt;
                    Console.WriteLine(ints[i]);

                    i++;
                }
                else
                {
                    string b = string.Empty;

                    for (int k = 0; k < s.Length; k++)
                    {
                        if (Char.IsDigit(s[k]))
                            b += s[k];
                    }


                    if (b.Length > 0)
                    {
                        ints[i] = int.Parse(b);
                        Console.WriteLine(int.Parse(b));

                    }

                    i++;

                }
            }
            foreach (int elm in ints)
            {
                Console.WriteLine("q -" + elm);
            }
        }
    }
}
    





