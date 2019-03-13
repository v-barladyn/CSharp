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

            Book gg = new Book("Glory", 23);
            gg.Info();
            MyBook jj = new MyBook("Some book", 23, "John");
            jj.Info();

            Console.WriteLine();
            Console.WriteLine("Amount of created objects - " + Book.count);

            Console.ReadKey();
        }
    }

    abstract class Item
    {
        protected string name { get; set; }
        protected int price { get; set; }

        public abstract void Info(); 
    }

    class Book : Item    {

        public static int count;
        

        public Book(string name, int price)
        {
            this.name = name;
            this.price = price;

            count++;
        }

        override public void Info()
        {
            Console.Write("Book name - {0}, Price - {1}", name, price);
        }
    }
    class MyBook : Book
    {
        protected string owner { get; set; }
        public MyBook(string name, int price, string owner) : base(name, price)
        {
            this.name = name;
            this.price = price;
            this.owner = owner;
        }

        override public void Info()
        {
            Console.WriteLine();
            base.Info();
            Console.Write(", Owner - {0}",owner);
        }
    }
}


    





