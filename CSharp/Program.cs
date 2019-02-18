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
            DateType tt = new DateType();
            tt.SumTwoInt();
            tt.DifferenceBetweenFloatDoubleDecimal();
            tt.BoxingUnboxing(123);
            tt.BoxingUnboxing("123");
            tt.GetInfoAboutString();

        }
    }

    class DateType
    {
        public int ConvertToInt(string str)
        {
            return Convert.ToInt32(str);
        }

        public void DifferenceBetweenFloatDoubleDecimal()
        {
            float flt = 1F / 3;
            double dbl = 1D / 3;
            decimal dcm = 1M / 3;
            Console.WriteLine("float: {0} double: {1} decimal: {2}", flt, dbl, dcm);
            
        }

        public void SumTwoInt()
        {
            Console.WriteLine("enter int1");
            int int1 = ConvertToInt(Console.ReadLine());
            Console.WriteLine("enter int2");
            int int2 = int.Parse(Console.ReadLine());
            int sumInt = int1 + int2;

            Console.WriteLine("int1 {0} + int2 {1} = {2}", int1, int2, sumInt);
            

        }

        public void BoxingUnboxing(int i)
        {            
            Console.WriteLine(" i - " + i);
            object o = i;
            Console.WriteLine(" o - " + o);
            i = (int)o;
            Console.WriteLine(" i - " + i);          

        }

        public void GetInfoAboutString()
        {
            Console.WriteLine("enter string");
            string str = Console.ReadLine();
            int i = str.Length;
            var input = str.ToCharArray();
            char last = input[str.Length - 1];
            Console.WriteLine("Secound Char is   {0} ", input[1]);
            Console.WriteLine("Last value  {0} ", last);
            Console.WriteLine("Length of entered string is  {0} ", i);
            Console.ReadKey();

        }

    }






}

