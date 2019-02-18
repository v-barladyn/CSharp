using System;
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

            Person Boy = new Person("Tom", "Male", 1998);
            Person Girl = new Person("Mary", "Female", 1998);
            Person Jim = new Person();



        }
    }

    class Person
    {
        public string YearOfBirth { get; set; }
        public int YearOfBirthInt { get; set; }
        public string Name { get; set; }

        public int Height { get; set; }
        public int Age { get; set; }
        public string Sex { get; set; }

        public Person()
        {

            Console.Write("Enter name: ");
            Name = Console.ReadLine();
            Console.Write("Entered name: " + Name);

            Console.Write("Enter Sex: ");
            Sex = Console.ReadLine();
            Console.Write("Entered Sex: " + Sex);

            Console.Write("Enter YearOfBirth: ");
            YearOfBirth = Console.ReadLine();
            YearOfBirthInt = Convert.ToInt32(YearOfBirth);
            Console.WriteLine("Entered YearOfBirth: " + YearOfBirthInt);

            ShowInfo();

        }
        public Person(string name, string sex, int yearOfBirthInt)
        {

            Name = name;
            Sex = sex;
            YearOfBirthInt = yearOfBirthInt;

            ShowInfo();

        }


        public int GetAge()
        {
            Age = Convert.ToInt32(DateTime.Now.Year.ToString()) - YearOfBirthInt;

            return Age;
        }

        public void ShowInfo()
        {
            Console.WriteLine("New person mane - " + Name);
            Console.WriteLine("Year of birth - " + YearOfBirth);
            Console.WriteLine("Age - " + GetAge());
            Console.WriteLine("Sex - " + Sex);

            Console.ReadKey();

        }

    }






}

