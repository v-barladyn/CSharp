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
        

        public Book(string name, int price)
        {
            this.name = name;
            this.price = price;
        }

        override public void Info()
        {
            Console.WriteLine("Book name - {0}, Price - {1}", name, price);
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
            Console.WriteLine("Book name - {0}, Price - {1}, Owner - {2}", name, price,owner);
        }
    }
}


    





