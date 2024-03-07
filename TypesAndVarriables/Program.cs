using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndVarriables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Value Types
            //Console.WriteLine("Hello World!");

            double number4 = 10.4;
            decimal number5 = 10.4M;

            char character = 'a';
            bool condition = false; // bool: true veya false değerlerinden birini alır. Şart bloklarında sıklıkla kullanılır!

            byte number3 = 0; // byte: 8 bit yer kaplar. en az: 0 en çok: 255 değerlerini alır!
            short number0 = 32767; // short: 16 bit yer kaplar. en az: -32768 en çok: 32767 değerlerini alır!
            int number1 = 2147483647; // int: 32 bit yer kaplar. en az -2147483648, en çok: 2147483647 değerlerini alır!
            long number2 = 2147483648; // long: 64 bit yer kaplar en az: -9223372036854775808 en çok: 9223372036854775807 değerlerini alır!

            var number6 = 10;
            number6 = 'A';
            //number6 = "A";

            Console.WriteLine("Number1 is {0} ", number1);
            Console.WriteLine("Number2 is {0} ", number2);
            Console.WriteLine("Number0 is {0} ", number0);
            Console.WriteLine("Number3 is {0} ", number3);
            Console.WriteLine("Number4 is {0} ", number4);
            Console.WriteLine("Nummber6 is {0} ", number6);
            Console.WriteLine("Character is {0} ", character);
            Console.WriteLine((int)Days.Friday);

            Console.ReadLine();
        }
    }

    enum Days
    {
        Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
    }
}
